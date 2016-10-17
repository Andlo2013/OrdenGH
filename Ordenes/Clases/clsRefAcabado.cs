using AutomatizerSQL.Utilidades;
using dllMensaje;
using Ordenes.Properties;
using System;
using System.Data;

namespace Ordenes.Clases
{

    public class clsRefAcabado
    {
        //Instancias-Variables de la clase
        #region INSTANCIAS-VARIABLES
        _SQLServer objSQLServer = frmPrincipal.getSQLServer;
        private string m_CodEmpresa = frmPrincipal.getSession.Empresa.Codigo;
        DataTable dt_acabados = null;
        #endregion

        public clsRefAcabado() { }

        //carga el detalle
        #region acabadoCargaDET
        public DataTable _acabadoCargaDET()
        {
            try
            {
                dt_acabados = objSQLServer._CargaDataTable(sqlTablasREF.acabados_CargaDET,
                    new string[] { "@CodEmpresa" }, new object[] { m_CodEmpresa });
                dt_acabados.Columns["idAcabado"].DefaultValue = 0;
                dt_acabados.Columns["CodTalla"].DefaultValue = 0;
                dt_acabados.Columns["AplicaA"].DefaultValue = 0;
                dt_acabados.Columns["Estado"].DefaultValue = true;
                dt_acabados.Columns["Accion"].DefaultValue = "NUEVO";
                dt_acabados.Columns["Accion"].ReadOnly=false;
                return dt_acabados;
            }
            catch
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los acabados", "Acabados");
                return null;
            }
        }
        #endregion

        //carga combo tallas
        #region acabadoCargaTalla
        public DataTable _acabadoCargaTalla()
        {
            try
            {
                DataTable dt_tallas = objSQLServer._CargaDataTable(sqlTablasREF.acabados_CargaTallas,
                    new string[] { "@CodEmpresa" }, new object[] { m_CodEmpresa });
                return dt_tallas;
            }
            catch
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar el combo grupos", "Acabados");
                return null;
            }
        }
        #endregion

        //carga combo areas a las que aplicar
        #region acabadoCargaArea
        public DataTable _acabadoCargaArea()
        {
            string[] valores = new string[] { "T-FINAL", "PLIE-IMP" };
            DataTable dtAreaIMP = new DataTable();
            dtAreaIMP.Columns.Add("Codigo");
            dtAreaIMP.Columns.Add("Descripcion");
            foreach (string val in valores)
            {
                DataRow rowArea = dtAreaIMP.NewRow();
                rowArea["Codigo"] = val;
                rowArea["Descripcion"] = val;
                dtAreaIMP.Rows.Add(rowArea);
            }
            return dtAreaIMP;
        }
        #endregion

        //calcula el codigo de acabado
        #region acabadoID
        public int _acabadoID()
        {
            try
            {
                DataTable dtCodigo = objSQLServer._CargaDataTable(sqlTablasREF.acabados_Codigo,
                    new string[] { "@CodEmpresa" }, new object[] { m_CodEmpresa });
                if (dtCodigo != null && dtCodigo.Rows.Count==1)
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

        //guarda los acabados
        #region acabadoGuardar
        public void _acabadoGuardar()
        {
            try
            {
                if (dt_acabados != null)
                {
                    dt_acabados.AcceptChanges();
                    DataRow[] rowModifica = dt_acabados.Select("Accion<>''");
                    objSQLServer._Open();
                    objSQLServer._BeginTransacction();
                    foreach (DataRow rowAcabado in rowModifica)
                    {
                        int idAcabado = rowAcabado["idAcabado"].ToInt();
                        idAcabado = idAcabado == 0? _acabadoID() : idAcabado;
                        objSQLServer._Ejecutar(sqlTablasREF.acabados_Guardar,
                            new string[] { "@idAcabado", "@Descripcion", "@AplicaA",
                            "@CodTalla", "@Costo","@Estado" },
                            new object[] { idAcabado, rowAcabado["Descripcion"],rowAcabado["AplicaA"],
                            rowAcabado["CodTalla"],rowAcabado["Costo"],rowAcabado["Estado"] });
                    }
                    objSQLServer._Commit();
                    objSQLServer._Close();
                }
            }
            catch(Exception ex)
            {
                objSQLServer._RollBack();
                objSQLServer._Close();
                clsMensaje._msjError("ERROR: Al intentar guardar la transacción", "Acabados",ex.InnerException.Message);
            }
        }
        #endregion

        //valida los acabados
        #region acabadoValidar
        public bool _acabadoValidar()
        {
            if (dt_acabados != null)
            {
                dt_acabados.AcceptChanges();
                DataRow[] rowModificadas = dt_acabados.Select("Accion<>''");
                int numFila = 0;
                for (int i=0;i<dt_acabados.Rows.Count;i++)
                {
                    numFila++;
                    DataRow rowAcabado = dt_acabados.Rows[i];
                    string msjFila = "El registro de la fila Nro: " + numFila.ToString();
                    if (rowAcabado["Descripcion"].ToString() == "")
                    {
                        msjFila += "\nLa descripción del acabado es obligatorio";
                        clsMensaje._msjWarning(msjFila, "Detalle Acabados");
                        return false;
                    }
                    else if (rowAcabado["AplicaA"].ToString() == "")
                    {
                        msjFila += "\nEl area a la que aplica es obligatorio";
                        clsMensaje._msjWarning(msjFila, "Detalle Acabados");
                        return false;
                    }
                    else if (rowAcabado["Costo"].ToDecimal() <=0)
                    {
                        msjFila += "\nEl costo debe ser mayor a cero";
                        clsMensaje._msjWarning(msjFila, "Detalle Acabados");
                        return false;
                    }
                }
            }
            return true;
        }
        #endregion

        //elimina un registro
        #region acabdoEliminar
        public void _acabadoEliminar(DataRow rowEliminar)
        {
            if (rowEliminar != null)
            {
                if (rowEliminar["idAcabado"].ToInt() == 0)
                {
                    dt_acabados.Rows.Remove(rowEliminar);
                }
                else
                {
                    clsMensaje._msjWarning("No se permite eliminar el registro."+
                        "\nIntente la opción inactivar", "Eliminar");
                }
            }
        }
        #endregion

        //actualiza la columna a editar para guardar
        #region acabadoUpdate
        public void _acabadoUpdate(DataRow rowUpdate)
        {
            if (rowUpdate != null)
            {
                rowUpdate["Accion"] = "EDITAR";
            }
        }
        #endregion


    }

}
