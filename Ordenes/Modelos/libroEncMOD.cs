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
    public class libroEncMOD
    {

        _SQLServer objSQLServer = Form1.getSQLServer;
        private string m_codEmpresa = "01";

        #region PROPIEDADES-MODELO

        public int TipoLibro { get; set; }

        public int FormaLibro { get; set; }

        public int TipoTrabajo { get; set; }

        public int TamanoTrabajo { get; set; }

        public decimal Ancho { get; set; }

        public decimal Alto { get; set; }

        public int CodMaterial { get; set; }

        public string Material { get; set; }

        public int Gramos { get; set; }

        public int NumPaginas { get; set; }

        #endregion

        public libroEncMOD _cargaDET(int ordenID)
        {
            try
            {
                DataTable dtEncuadernado = objSQLServer._CargaDataTable(sqlQuery.ord_LibroENCCargaDET,
                                        new string[] { "@CodEmpresa", "@OrdenID" },
                                        new object[] { m_codEmpresa, ordenID });
                //retorna el objeto o nulo
                return dtEncuadernado != null && dtEncuadernado.Rows.Count == 1 ? 
                          _toEntity._row2object<libroEncMOD>(dtEncuadernado.Rows[0]) : new libroEncMOD();

            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar encuadernado de libro", "Cargar datos", ex.Message);
                return null;
            }
        }

        public void _guardaENC(libroEncMOD modelo, int ordenID)
        {
            string[] paramsNames = new string[] { "@CodEmpresa", "@ordenID",
                "@TipoLibro", "@FormaLibro", "@TipoTrabajo", "@TipoTamano",
                "@Ancho","@Alto","@CodMaterial", "@Gramos", "@NumPaginas" };

            object[] paramsValues = new object[] {m_codEmpresa,ordenID,
            modelo.TipoLibro,modelo.FormaLibro,modelo.TipoTrabajo,modelo.TamanoTrabajo,
            modelo.Ancho,modelo.Alto,modelo.CodMaterial,modelo.Gramos,modelo.NumPaginas};

            objSQLServer._Ejecutar(sqlQuery.ord_LibroENCGuarda, paramsNames, paramsValues);
        }

    }
}
