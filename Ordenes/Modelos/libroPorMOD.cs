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
    public class libroPorMOD
    {

        _SQLServer objSQLServer = Form1.getSQLServer;
        private string m_codEmpresa = "01";

        //PROPIEDADES DEL MODELO
        #region PROPIEDADES-MODELO
        public int TipoTamano { get; set; }

        public decimal Ancho { get; set; }

        public decimal Alto { get; set; }

        public int CodMaterial { get; set; }

        public string Material { get; set; }

        public int Gramos { get; set; }

        public int TiroColor { get; set; }

        public int TiroGuarda { get; set; }

        public int TiroCubierta { get; set; }

        public int RetiroColor { get; set; }

        public int RetiroGuarda { get; set; }

        public int RetiroCubierta { get; set; }

        public string ColorPantone { get; set; }

        public int CodGuardaMAT { get; set; }

        public string GuardaMAT { get; set; }

        public int CodCubiertaMAT { get; set; }

        public string CubiertaMAT { get; set; }

        public int TipoTroquel { get; set; }

        public int OrdenTroquel { get; set; }

        #endregion


        public libroPorMOD _cargaDET(int ordenID)
        {
            try
            {
                DataTable dtPortada = objSQLServer._CargaDataTable(sqlQuery.ord_LibroPORCargaDET,
                                        new string[] { "@CodEmpresa", "@OrdenID" },
                                        new object[] { m_codEmpresa, ordenID });
                //retorna la fila o nulo
                return dtPortada != null && dtPortada.Rows.Count == 1 ? 
                    _toEntity._row2object<libroPorMOD>(dtPortada.Rows[0]) : new libroPorMOD();
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar portada de libro", "Cargar datos", ex.Message);
                return null;
            }
        }

        public void _guardaPortada(libroPorMOD modelo, int ordenID)
        {
            string[] paramsNames = new string[] { "@CodEmpresa", "@ordenID",
            "@TipoTamano", "@Ancho", "@Alto", "@CodMaterial", "@Gramos", "@TiroColor",
            "@TiroGuarda", "@TiroCubierta", "@RetiroColor", "@RetiroGuarda", "@RetiroCubierta",
            "@ColorPantone", "@CodGuardaMAT", "@CodCubiertaMAT", "@TipoTroquel", "@ordenTroquel"};

            object[] paramsValues = new object[] {m_codEmpresa,ordenID,
            modelo.TipoTamano,modelo.Ancho,modelo.Alto,modelo.CodMaterial,modelo.Gramos,modelo.TiroColor,
            modelo.TiroGuarda,modelo.TiroCubierta,modelo.RetiroColor,modelo.RetiroGuarda,modelo.RetiroCubierta,
            modelo.ColorPantone,modelo.CodGuardaMAT,modelo.CodCubiertaMAT,modelo.TipoTroquel,modelo.OrdenTroquel};

            objSQLServer._Ejecutar(sqlQuery.ord_LibroPORGuarda, paramsNames, paramsValues);
        }



    }
}
