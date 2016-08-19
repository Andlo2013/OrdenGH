using dllMensaje;
using Ordenes.Clases;
using Ordenes.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenes.Modelos
{
    public class trabajoGenMOD
    {
        _SQLServer objSQLServer = Form1.getSQLServer;
        private string m_codEmpresa = "01";

        #region PROPIEDADES-MODELO
        public int Trabajo { get; set; }
        public int Tiraje { get; set; }
        public int TipoTrabajo { get; set; }
        public int TipoTamano { get; set; }
        public decimal Ancho { get; set; }
        public decimal Alto { get; set; }
        public int CodMaterial { get; set; }
        public string Material { get; set; }
        public int Gramos { get; set; }
        public int TipoTroquel { get; set; }
        public object OrdenTroquel { get; set; }
        public int ColorTiro { get; set; }
        public int ColorRetiro { get; set; }
        public string Pantones { get; set; }
        #endregion

        public trabajoGenMOD _cargaDET(int ordenID)
        {
            try
            {
                DataTable dtGeneral = objSQLServer._CargaDataTable(sqlQuery.ord_GeneralCargaDET,
                                        new string[] { "@CodEmpresa", "@OrdenID" },
                                        new object[] { m_codEmpresa, ordenID });
                //retorna el objeto o nulo
                return dtGeneral != null && dtGeneral.Rows.Count == 1 ? _toEntity._row2object<trabajoGenMOD>(dtGeneral.Rows[0]) : new trabajoGenMOD();

            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los trabajos generales", "Cargar datos", ex.Message);
                return null;
            }
        }

        public void _guardaTrabajoGEN(trabajoGenMOD modelo,int ordenID)
        {
            string[] paramsNames = new string[] { "@CodEmpresa", "@ordenID",
                "@Trabajo", "@Tiraje", "@TipoTrabajo", "@Tamano", "@Ancho", "@Alto",
                "@ItmSecuencial", "@Gramos", "@TipoTroquel", "@OrdenTroquel", "@ColorTiro",
                "@ColorRetiro", "@Pantones"};

            object[] paramsValues = new object[] {m_codEmpresa,ordenID,
            modelo.Trabajo,modelo.Tiraje,modelo.TipoTrabajo,modelo.TipoTamano,modelo.Ancho,modelo.Alto,
            modelo.CodMaterial,modelo.Gramos,modelo.TipoTroquel,modelo.OrdenTroquel,modelo.ColorTiro,
            modelo.ColorRetiro,modelo.Pantones};

            objSQLServer._Ejecutar(sqlQuery.ord_GeneralGuarda, paramsNames, paramsValues);
        }

    }
}
