using AutomatizerSQL.Utilidades;
using dllMensaje;
using Ordenes.Properties;
using System;
using System.Data;

namespace Ordenes.Clases
{
    public class clsRefPliegoEXT
    {
        //INSTANCIAS Y VARIABLES DE LA CLASE
        #region Instancias-Variables
        _SQLServer objSQLServer = frmPrincipal.getSQLServer;
        private string m_CodEmpresa = frmPrincipal.getSession.Empresa.Codigo;
        DataTable dtPliegoEXTDET = null;
        #endregion

        public clsRefPliegoEXT() { }

        //carga el detalle
        #region pextCargaDET
        public DataTable _pextCargaDET(object objCodGrupo,object objCodComponente)
        {
            try
            {
                objCodGrupo = objCodGrupo == null || objCodGrupo == DBNull.Value ? 0 : objCodGrupo;
                objCodComponente = objCodComponente == null || objCodComponente == DBNull.Value ? 0 : objCodComponente;

                dtPliegoEXTDET = objSQLServer._CargaDataTable(sqlTablasREF.pext_cargaDET,
                    new string[] {"@CodEmpresa","@CodGrupo","@CodComponente" },
                    new object[] { m_CodEmpresa, objCodGrupo.ToInt(), objCodComponente.ToInt() } );
                dtPliegoEXTDET.Columns["Porcentaje"].DefaultValue = 0;
                return dtPliegoEXTDET;
            }
            catch(Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar el detalle", "Pliegos Extra",ex.Message);
                return null;
            }
        }
        #endregion

        //agrega un grupo de materiales
        #region pextAgregaMAT
        public void _pextAgregaMAT()
        {
            _Comunes objComunes = new _Comunes();
            _pextAddRegistro(objComunes._agregaMATMultiple());
        }
        #endregion

        //agrega un registro a los pliegos extra
        #region pextAddRegistro
        private void _pextAddRegistro(DataTable dtRegistrosSEL)
        {
            if (dtRegistrosSEL != null && dtPliegoEXTDET != null)
            {
                foreach(DataRow rowPliego in dtRegistrosSEL.Rows)
                {
                    if (dtPliegoEXTDET.Select("SecMaterial=" + rowPliego["Secuencial"]).Length==0)
                    {
                        DataRow newRow = dtPliegoEXTDET.NewRow();
                        newRow["SecMaterial"] = rowPliego["Secuencial"];
                        newRow["Material"] = rowPliego["Descripción"];
                        newRow["Porcentaje"] = 0;
                        dtPliegoEXTDET.Rows.Add(newRow);
                    }
                }
            }
        }
        #endregion

        //guarda los procesos de pliegos extra
        #region pextGuarda
        public void _pextGuarda(object objCodGrupo, object objCodComponente)
        {
            try
            {
                if (dtPliegoEXTDET != null)
                {
                    objSQLServer._Open();
                    objSQLServer._BeginTransacction();
                    objSQLServer._Ejecutar(sqlTablasREF.pext_EliminaG,
                        new string[] { "@CodGrupo", "@CodComponente" }, 
                        new object[] { objCodGrupo, objCodComponente });
                    foreach (DataRow row in dtPliegoEXTDET.Rows)
                    {
                        objSQLServer._Ejecutar(sqlTablasREF.pext_Guarda,
                            new string[] { "@CodGrupo", "@CodComponente", "@SecMaterial", "@Porcentaje" },
                            new object[] { objCodGrupo, objCodComponente, row["SecMaterial"], row["Porcentaje"] });
                    }
                    objSQLServer._Commit();
                    objSQLServer._Close();
                }
            }
            catch(Exception ex)
            {
                objSQLServer._RollBack();
                objSQLServer._Close();
                clsMensaje._msjWarning("ERROR: Al intentar guardar la transacción", "Pliegos extra", ex.Message);
            }
        }
        #endregion

        //Valida el detalle de pliegos extra
        #region pextValida
        public bool _pextValida()
        {
            if (dtPliegoEXTDET != null)
            {
                int numFilas = 0;
                foreach(DataRow row in dtPliegoEXTDET.Rows)
                {
                    numFilas++;
                    string msjFila = "El registro de la fila Nro: " + numFilas.ToString();
                    if (row["Porcentaje"].ToDecimal() <= 0)
                    {
                        msjFila += "\nEl porcentaje debe ser mayor a cero";
                        clsMensaje._msjWarning(msjFila, "Pliegos extra");
                        return false;
                    }
                }
            }
            return true;
        }
        #endregion

        //Elimina un registro
        #region pextElimina
        public void _pextElimina(DataRow rowElimina)
        {
            if (rowElimina != null)
            {
                dtPliegoEXTDET.Rows.Remove(rowElimina);
            }
        }
        #endregion

    }
}
