using AutomatizerSQL.Utilidades;
using dllBuscar;
using dllMensaje;
using Ordenes.Properties;
using System;
using System.Collections.Generic;
using System.Data;

namespace Ordenes.Clases
{
    public class clsRefProcesoIMP
    {
        //INSTANCIAS-VARIABLES
        #region Instancias-Variables
        _SQLServer objSQLServer = frmPrincipal.getSQLServer;
        _Comunes objComunes = new _Comunes();
        private string m_CodEmpresa = frmPrincipal.getSession.Empresa.Codigo;
        private string m_Servidor = frmPrincipal.getSession.Servidor;
        private string m_Catalogo = frmPrincipal.getSession.Catalogo;
        DataTable dtDetallePIMP = null;
        #endregion

        public clsRefProcesoIMP() { }

        //CARGA LAS PLACAS
        #region pimpCargaPlaca
        public DataTable _pimpCargaPlaca()
        {
            try
            {
                DataTable dtPlacas = objSQLServer._CargaDataTable(sqlCotizacion.cot_cargaPlacas,
                    new string[] { "@CodEmpresa" }, new object[] { m_CodEmpresa });
                return dtPlacas;
            }
            catch(Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar el combo máquinas", "Proceso Impresión", ex.Message);
                return null;
            }
        }
        #endregion

        //CARGA EL DETALLE
        #region pimpCargaDET
        public DataTable _pimpCargaDET(object CodMaquina)
        {
            try
            {
                CodMaquina = CodMaquina != null && CodMaquina != DBNull.Value ? CodMaquina : 0;
                dtDetallePIMP = objSQLServer._CargaDataTable(sqlTablasREF.pimp_CargaDET,
                    new string[] { "@CodMaquina"}, new object[] {CodMaquina });
                dtDetallePIMP.Columns["NumColores"].DefaultValue =1;
                dtDetallePIMP.Columns["CostoMIN"].DefaultValue = 0;
                dtDetallePIMP.Columns["PliegosMIN"].DefaultValue = 0;
                dtDetallePIMP.Columns["CostoPP"].DefaultValue = 0;
                dtDetallePIMP.Columns["MinutosPP"].DefaultValue = 0;
                return dtDetallePIMP;
            }
            catch(Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar el detalle", "Proceso Impresión", ex.Message);
                return null;
            }
        }
        #endregion

        //AGREGA UN GRUPO METODO PUBLICO
        #region pimpAgregaGRP
        public void _pimpAgregaGRP()
        {
            Dictionary<string, string> dicionario = new Dictionary<string, string>();
            dicionario.Add("Talla", "Grupo");
            frmBuscarITEM objBuscar = new frmBuscarITEM();
            objBuscar.pro_Configura
                ._set01Connection(m_Servidor, m_Catalogo)
                ._set02Find(sqlCotizacion.cot_disArmadosAgregaGrupo,
                            new string[] { "@CodEmpresa" },
                            new object[] { m_CodEmpresa })
                ._set03OptionsFilter(dicionario)
                ._setSeleccionSimple(false);

            objBuscar.ShowDialog();
            _pimpAddGrupo(objBuscar.pro_dtFilasSEL);

        }
        #endregion

        //METODO QUE AGREGA
        #region pimpAddGrupo
        private void _pimpAddGrupo(DataTable dtFilasSEL)
        {
            if(dtFilasSEL != null && dtDetallePIMP != null)
            {
                foreach (DataRow rowSEL in dtFilasSEL.Rows)
                {
                    DataRow newRow = dtDetallePIMP.NewRow();
                    newRow["CodTalla"] = rowSEL["Código"];
                    newRow["Talla"] = rowSEL["Grupo"];
                    dtDetallePIMP.Rows.Add(newRow);
                }
            }
        }
        #endregion

        //GUARDA LOS REGISTROS
        #region pimpGuardar
        public void _pimpGuardar(object CodMaquina)
        {
            try{
                if (dtDetallePIMP != null)
                {
                    objSQLServer._Open();
                    objSQLServer._BeginTransacction();
                    string[] paramsName = new string[] { "@idTalla", "@idPlaca", "@NumColores",
                            "@CostoIMPMIN","@NumPliegosMIN", "@CostoMINPP", "@NumMinutosPP" };
                    objSQLServer._Ejecutar(sqlTablasREF.pimp_EliminaG, 
                        new string[] { "@CodPlaca" }, new object[] { CodMaquina });
                    foreach (DataRow row in dtDetallePIMP.Rows)
                    {
                        objSQLServer._Ejecutar(sqlTablasREF.pimp_GuardaPIMP,paramsName,
                            new object[] {row["CodTalla"],CodMaquina,row["NumColores"],
                            row["CostoMIN"],row["PliegosMIN"],row["CostoPP"],row["MinutosPP"]});
                    }
                    objSQLServer._Commit();
                    objSQLServer._Close();
                }
            }
            catch(Exception ex)
            {
                objSQLServer._RollBack();
                objSQLServer._Close();
                string error = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                clsMensaje._msjWarning("ERROR: Al intentar guardar la transacción", "Proceso Impresión", error);
            }
        }
        #endregion

        //VALIDA LOS REGISTROS
        #region pimpValidar
        public bool _pimpValidar()
        {
            try
            {
                if (dtDetallePIMP != null)
                {
                    int numFila = 0;
                    foreach(DataRow row in dtDetallePIMP.Rows)
                    {
                        numFila++;
                        string msjFila = "El registro de la fila Nro: " + numFila.ToString();
                        if (row["CodTalla"].ToInt() <= 0)
                        {
                            msjFila += "\nNo tiene un grupo de material válido";
                            clsMensaje._msjWarning(msjFila, "Proceso Impresión");
                            return false;
                        }
                        else if (row["NumColores"].ToInt() <= 0)
                        {
                            msjFila += "\nEl número de colores debe ser mayor a cero";
                            clsMensaje._msjWarning(msjFila, "Proceso Impresión");
                            return false;
                        }
                        else if (row["CostoMIN"].ToDecimal() <= 0)
                        {
                            msjFila += "\nEl costo del minuto de impresión debe ser mayor a cero";
                            clsMensaje._msjWarning(msjFila, "Proceso Impresión");
                            return false;
                        }
                        else if (row["CostoPP"].ToDecimal() <= 0)
                        {
                            msjFila += "\nEl costo del minuto en preparar máquina debe ser mayor a cero";
                            clsMensaje._msjWarning(msjFila, "Proceso Impresión");
                            return false;
                        }
                        else if (row["MinutosPP"].ToInt() <= 0)
                        {
                            msjFila += "\nLos minutos para preparar máquina deben ser mayor a cero";
                            clsMensaje._msjWarning(msjFila, "Proceso Impresión");
                            return false;
                        }
                    }
                }
                return true;
            }
            catch(Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar verificar el detalle", "Proceso impresión",ex.Message);
                return false;
            }
        }
        #endregion

        #region pimpEliminaREG
        public void _pimpEliminaREG(DataRow rowElimina)
        {
            if (rowElimina != null)
            {
                dtDetallePIMP.Rows.Remove(rowElimina);
            }
        }
        #endregion

    }
}
