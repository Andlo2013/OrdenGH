using AutomatizerSQL.Utilidades;
using dllMensaje;
using Ordenes.Properties;
using System;
using System.Data;

namespace Ordenes.Clases
{

    public class clsRefCobertura
    {

        //Instancia-Variables de la clase
        #region Instancia-Variables
        _SQLServer objSQLServer = frmPrincipal.getSQLServer;
        private string m_CodEmpresa = frmPrincipal.getSession.Empresa.Codigo;
        DataTable dtCoberturas = null;
        #endregion

        public clsRefCobertura() { }

        //Carga el detalle de oberturas
        #region coberturaCargaDET
        public DataTable _coberturaCargaDET()
        {
            try
            {
                dtCoberturas = objSQLServer._CargaDataTable(sqlTablasREF.coberturas_CargaDET,
                    new string[] { "@CodEmpresa" }, new object[] { m_CodEmpresa });
                dtCoberturas.Columns["idCobertura"].DefaultValue = 0;
                dtCoberturas.Columns["Gramos"].DefaultValue = 0;
                dtCoberturas.Columns["Estado"].DefaultValue = true;
                dtCoberturas.Columns["Accion"].DefaultValue ="NUEVO";
                dtCoberturas.Columns["Accion"].ReadOnly = false;
                return dtCoberturas;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar el detalle", "Cobertura", ex.InnerException.Message);
                return null;
            }
        }
        #endregion

        //calcula el id
        #region coberturaID
        public int _coberturaID()
        {
            try
            {
                DataTable dtCoberturas = objSQLServer._CargaDataTable(sqlTablasREF.coberturas_Codigo,
                    new string[] { "@CodEmpresa" }, new object[] { m_CodEmpresa });
                if (dtCoberturas != null && dtCoberturas.Rows.Count==1)
                {
                    return dtCoberturas.Rows[0]["Codigo"].ToInt()+1;
                }
                return -1;
            }
            catch
            {
                return -1;
            }
        }
        #endregion

        //Guarda los registros
        #region coberturaGuardar
        public void _coberturaGuardar()
        {
            try
            {
                if (dtCoberturas != null)
                {
                    DataRow[] rowModifica = dtCoberturas.Select("Accion<>''");
                    dtCoberturas.AcceptChanges();
                    objSQLServer._Open();
                    objSQLServer._BeginTransacction();
                    foreach (DataRow rowCobertura in rowModifica)
                    {
                        int idCobertura = rowCobertura["idCobertura"].ToInt();
                        idCobertura = idCobertura == 0 ? _coberturaID() : idCobertura;
                        objSQLServer._Ejecutar(sqlTablasREF.coberturas_Guardar,
                            new string[] { "@idCobertura", "@Descripcion",
                            "@Gramos", "@Estado" },
                            new object[] {idCobertura,rowCobertura["Descripcion"],
                            rowCobertura["Gramos"],rowCobertura["Estado"]});
                    }
                    objSQLServer._Commit();
                    objSQLServer._Close();
                }
            }
            catch (Exception ex)
            {
                objSQLServer._RollBack();
                objSQLServer._Close();
                clsMensaje._msjWarning("ERROR: Al intentar guardar la transacción", "Coberturas", ex.InnerException.Message);
            }
        }
        #endregion

        //valida la informacion
        #region coberturaValidar
        public bool _coberturaValidar()
        {
            if (dtCoberturas != null)
            {
                int numFila = 0;
                for (int i = 0; i < dtCoberturas.Rows.Count; i++)
                {
                    numFila++;
                    DataRow rowCobertura = dtCoberturas.Rows[i];
                    string msjFila = "El registro de la fila Nro: " + numFila.ToString();
                    if (rowCobertura["Descripcion"].ToString().Trim() == "")
                    {
                        msjFila += "\nNo tiene descripción";
                        clsMensaje._msjWarning(msjFila, "Coberturas");
                        return false;
                    }
                    else if (rowCobertura["Gramos"].ToDecimal() <= 0)
                    {
                        msjFila += "\nLa cantidad en gramos debe ser mayor a cero";
                        clsMensaje._msjWarning(msjFila, "Coberturas");
                        return false;
                    }
                }
            }
            return true;
        }
        #endregion

        //Elimina una cobertura
        #region coberturaElimina
        public void _coberturaElimina(DataRow rowElimina)
        {
            if (rowElimina != null)
            {
                if (rowElimina["idCobertura"].ToInt() == 0)
                {
                    dtCoberturas.Rows.Remove(rowElimina);
                }
                else
                {
                    clsMensaje._msjWarning("No se permite eliminar el registro" +
                        "\nIntente la opción inactivar", "Coberturas");
                }
            }
        }
        #endregion

        //Cambia a estado EDITAR la fila
        #region coberturaUpdate
        public void _coberturaUpdate(DataRow rowUpdate)
        {
            if (rowUpdate != null)
            {
                rowUpdate["Accion"] = "EDITAR";
            }
        }
        #endregion

    }

}
