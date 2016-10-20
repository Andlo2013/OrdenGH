using AutomatizerSQL.Utilidades;
using dllMensaje;
using Ordenes.Properties;
using System;
using System.Data;

namespace Ordenes.Clases
{

    public class clsRefPlacas
    {

        //Instancias - variables
        #region Instancias-Variables
        _SQLServer objSQLServer = frmPrincipal.getSQLServer;
        private string m_CodEmpresa = frmPrincipal.getSession.Empresa.Codigo;
        DataTable dtPlacasDET = null;
        #endregion

        public clsRefPlacas() { }

        //Carga el detalle de placas
        #region placaCargaDET
        public DataTable _placaCargaDET()
        {
            try
            {
                dtPlacasDET = objSQLServer._CargaDataTable(sqlTablasREF.placas_CargaDET,
                    new string[] {"@CodEmpresa" },new object[] {m_CodEmpresa });
                dtPlacasDET.Columns["idPlaca"].DefaultValue = 0;
                dtPlacasDET.Columns["Ancho"].DefaultValue = 0;
                dtPlacasDET.Columns["Alto"].DefaultValue = 0;
                dtPlacasDET.Columns["Costo"].DefaultValue = 0;
                dtPlacasDET.Columns["Estado"].DefaultValue = true;
                dtPlacasDET.Columns["Accion"].DefaultValue = "NUEVO";
                dtPlacasDET.Columns["Accion"].ReadOnly=false;
                return dtPlacasDET;
            }
            catch(Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar el detalle", "Placas",ex.InnerException.Message);
                return null;
            }
        }
        #endregion

        //calcula el id de placa
        #region placaID
        public int _placaID()
        {
            try
            {
                DataTable dtCodigo = objSQLServer._CargaDataTable(sqlTablasREF.placas_Codigo,
                    new string[] { "@CodEmpresa" }, new object[] { m_CodEmpresa });
                if(dtCodigo!=null && dtCodigo.Rows.Count == 1)
                {
                    return dtCodigo.Rows[0]["Codigo"].ToInt()+1;
                }
                return -1;
            }
            catch
            {
                return -1;
            }
        }
        #endregion

        //elimina una placa
        #region placaElimina
        public void _placaElimina(DataRow rowElimina)
        {
            if (rowElimina != null)
            {
                if (rowElimina["idPlaca"].ToInt() == 0)
                {
                    dtPlacasDET.Rows.Remove(rowElimina);
                }
                else
                {
                    clsMensaje._msjWarning("No se puede eliminar el registro" +
                        "\nIntente la opción inactivar", "Placas");
                }
            }
        }
        #endregion

        //guarda una placa
        #region placaGuardar
        public void _placaGuardar()
        {
            try
            {
                if (dtPlacasDET != null)
                {
                    DataRow[] rowModifica = dtPlacasDET.Select("Accion<>''");
                    if (rowModifica != null)
                    {
                        objSQLServer._Open();
                        objSQLServer._BeginTransacction();
                        foreach (DataRow row in rowModifica)
                        {
                            int idPlaca = row["idPlaca"].ToInt();
                            idPlaca = idPlaca == 0 ? _placaID() : idPlaca;
                            objSQLServer._Ejecutar(sqlTablasREF.placas_Guardar,
                                new string[] { "@idPlaca", "@Descripcion", "@Ancho", "@Alto", "@CostoPlaca", "@Estado" },
                                new object[] { idPlaca, row["Descripcion"], row["Ancho"], row["Alto"], row["Costo"], row["Estado"] });
                        }
                        objSQLServer._Commit();
                        objSQLServer._Close();
                    }
                }
            }
            catch(Exception ex)
            {
                objSQLServer._RollBack();
                objSQLServer._Close();
                clsMensaje._msjWarning("ERROR: Al intentar guardar la transacción", "Placas", ex.InnerException.Message);
            }

        }
        #endregion

        //cambia a estado editar una placa
        #region placaUpdate
        public void _placaUpdate(DataRow rowUpdate)
        {
            if (rowUpdate != null)
            {
                rowUpdate["Accion"] = "EDITAR";
            }
        }
        #endregion

        //Valida las placas
        #region placaValidar
        public bool _placaValidar()
        {
            if (dtPlacasDET != null)
            {
                dtPlacasDET.AcceptChanges();
                int numFila = 0;
                foreach (DataRow rowPlaca in dtPlacasDET.Rows)
                {
                    numFila++;
                    string msjFila = "El registro de la fila Nro: " + numFila.ToString().Trim();
                    if (rowPlaca["Descripcion"].ToString().Trim() == "")
                    {
                        msjFila = "\nLa descripcion es obligatorio";
                        clsMensaje._msjWarning(msjFila, "Placas");
                        return false;
                    }
                    else if (rowPlaca["Ancho"].ToDecimal() <= 0)
                    {
                        msjFila = "\nEl ancho debe ser mayor a cero";
                        clsMensaje._msjWarning(msjFila, "Placas");
                        return false;
                    }
                    else if (rowPlaca["Alto"].ToDecimal() <= 0)
                    {
                        msjFila = "\nEl alto debe ser mayor a cero";
                        clsMensaje._msjWarning(msjFila, "Placas");
                        return false;
                    }
                    else if (rowPlaca["Costo"].ToDecimal() <= 0)
                    {
                        msjFila = "\nEl costo debe ser mayor a cero";
                        clsMensaje._msjWarning(msjFila, "Placas");
                        return false;
                    }
                }
            }
            return true;
        }
        #endregion

    }

}
