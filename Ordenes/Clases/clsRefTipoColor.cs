using AutomatizerSQL.Utilidades;
using dllMensaje;
using Ordenes.Properties;
using System;
using System.Data;

namespace Ordenes.Clases
{

    public class clsRefTipoColor
    {

        //INSTANCIAS-VARIABLES
        #region Instancia-Variables
        _SQLServer objSQLServer = frmPrincipal.getSQLServer;
        private string m_CodEmpresa = frmPrincipal.getSession.Empresa.Codigo;
        DataTable dtTipoColor = null;
        #endregion

        public clsRefTipoColor() { }

        //Carga el detalle
        #region CargaDET
        public DataTable _tipocolorCargaDET()
        {
            try
            {
                dtTipoColor = objSQLServer._CargaDataTable(sqlTablasREF.tipocolor_CargaDET,
                    new string[] { "@CodEmpresa" }, new object[] { m_CodEmpresa });
                dtTipoColor.Columns["idColor"].DefaultValue = 0;
                dtTipoColor.Columns["Costo"].DefaultValue = 0;
                dtTipoColor.Columns["Estado"].DefaultValue = true;
                dtTipoColor.Columns["Accion"].DefaultValue = "NUEVO";
                dtTipoColor.Columns["Accion"].ReadOnly = false;
                return dtTipoColor;
            }
            catch(Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar el detalle", "Tipo colores",ex.InnerException.Message);
                return null;
            }
        }
        #endregion

        //Calcula el codigo
        #region calculaID
        public int _tipocolorID()
        {
            try
            {
                DataTable dtCodigo = objSQLServer._CargaDataTable(sqlTablasREF.tipocolor_Codigo,
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

        //guarda los registros
        #region Guardar
        public void _tipocolorGuardar()
        {
            try
            {
                if (dtTipoColor != null)
                {
                    DataRow[] rowModifica = dtTipoColor.Select("Accion<>''");
                    if (rowModifica != null)
                    {
                        objSQLServer._Open();
                        objSQLServer._BeginTransacction();
                        foreach (DataRow row in rowModifica)
                        {
                            int idTipoColor = row["idColor"].ToInt();
                            idTipoColor = idTipoColor == 0 ? _tipocolorID() : idTipoColor;
                            objSQLServer._Ejecutar(sqlTablasREF.tipocolor_Guarda,
                                new string[] { "@idColor", "@Descripcion", "@Costo", "@Estado" },
                                new object[] {idTipoColor,row["Descripcion"],row["Costo"],row["Estado"] });
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
                clsMensaje._msjWarning("ERROR: Al intentar guardar la transacción", "Tipo Color", ex.Message);
            }
        }
        #endregion

        //Valida los datos
        #region Validar
        public bool _tipocolorValidar()
        {
            if (dtTipoColor != null)
            {
                int numFilas = 0;
                foreach(DataRow row in dtTipoColor.Rows)
                {
                    numFilas++;
                    string msjFila = "El registro de la fila Nro: " + numFilas;
                    if (row["Descripcion"].ToString().Trim() == "")
                    {
                        msjFila += "\nNo tiene ingresada una descripción";
                        clsMensaje._msjWarning(msjFila, "Tipo color");
                        return false;
                    }
                    else if (row["Costo"].ToDecimal() <=0)
                    {
                        msjFila += "\nEl costo debe ser mayor a cero";
                        clsMensaje._msjWarning(msjFila, "Tipo color");
                        return false;
                    }
                }
            }
            return true;
        }
        #endregion

        //Elimina un tipo de color
        #region Eliminar
        public void _tipocolorElimina(DataRow rowElimina)
        {
            if (rowElimina != null)
            {
                if (rowElimina["idColor"].ToInt() == 0)
                {
                    dtTipoColor.Rows.Remove(rowElimina);
                }
                else
                {
                    clsMensaje._msjWarning("No se puede eliminar el registro" +
                        "\nIntente la opción de inactivar", "Tipo color");
                }
            }
        }
        #endregion

        //Pone en edicion un registro
        #region Update
        public void _tipocolorUpdate(DataRow rowUpdate)
        {
            if (rowUpdate != null)
            {
                rowUpdate["Accion"] = "EDITAR";
            }
        }
        #endregion

    }

}
