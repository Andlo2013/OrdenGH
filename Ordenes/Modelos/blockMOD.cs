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
    public class blockMOD
    {

        _SQLServer objSQLServer = Form1.getSQLServer;
        private string m_codEmpresa = "01";

        #region PROPIEDADES-MODELO
        public int NumCopias { get; set; }

        public int Juego { get; set; }

        public int TipoEmblocado { get; set; }

        public string Serie { get; set; }

        public int Inicia { get; set; }

        public int Termina { get; set; }

        public int TipoAcabado { get; set; }

        public int TipoTamano { get; set; }

        public decimal Ancho { get; set; }

        public decimal Alto { get; set; }

        public int CodMaterial { get; set; }

        public string Material { get; set; }

        public int Gramos { get; set; }

        public int Tiraje { get; set; }

        public int TipoTroquel { get; set; }

        public int OrdenTroquel { get; set; }

        public int Color { get; set; }

        public string Pantones { get; set; }

        #endregion


        public blockMOD _cargaDET(int ordenID)
        {
            try
            {
                DataTable dtBlock = objSQLServer._CargaDataTable(sqlQuery.ord_BlockCargaDET,
                                        new string[] { "@CodEmpresa", "@OrdenID" },
                                        new object[] { m_codEmpresa, ordenID });
                //retorna el objeto o nulo
                return dtBlock != null && dtBlock.Rows.Count == 1 ? 
                    _toEntity._row2object<blockMOD>(dtBlock.Rows[0]) : new blockMOD();
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los blocks", "Cargar datos", ex.Message);
                return null;
            }
        }

        public void _guardarDET(blockMOD modelo, int ordenID)
        {
            string[] paramsNames = new string[] { "@CodEmpresa", "@ordenID",
                "@NumCopias","@Juego","@TipoEmblocado","@Serie","@Inicia","@Termina",
                "@Acabado","@Tamano","@Ancho","@Alto","@ItmSecuencial","@Gramos","@Tiraje",
                "@CmbTroquel","@OrdenTroquel","@Color","@Pantones"};

            object[] paramsValues = new object[] {m_codEmpresa,ordenID,
            modelo.NumCopias,modelo.Juego,modelo.TipoEmblocado,modelo.Serie,modelo.Inicia,modelo.Termina,
            modelo.TipoAcabado,modelo.TipoTamano,modelo.Ancho,modelo.Alto,modelo.CodMaterial,modelo.Gramos,modelo.Tiraje,
            modelo.TipoTroquel,modelo.OrdenTroquel,modelo.Color,modelo.Pantones};

            objSQLServer._Ejecutar(sqlQuery.ord_BlockGuarda, paramsNames, paramsValues);
        }

    }
}
