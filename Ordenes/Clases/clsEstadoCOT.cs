using dllMensaje;
using Ordenes.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenes.Clases
{
    public class clsEstadoCOT
    {
        _SQLServer objSQLServer = frmPrincipal.getSQLServer;
        private string m_CodEmpresa = frmPrincipal.getSession.Empresa.Codigo;
        DataTable dtEstadoCOT = null;

        public clsEstadoCOT() { }

        public DataTable _cargaDET()
        {
            try
            {
                dtEstadoCOT = objSQLServer._CargaDataTable(sqlEstadoCOT.cotest_cargaDET,
                    new string[] { "@CodEmpresa" }, new object[] { m_CodEmpresa });
                dtEstadoCOT.Columns.Add("Seleccionar", Type.GetType("System.Boolean"));
                return dtEstadoCOT;
            }
            catch(Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los registros", "Cotizaciones", ex.Message);
                return null;
            }
        }

    }
}
