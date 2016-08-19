using AutomatizerSQL.Utilidades;
using dllMensaje;
using Ordenes.Clases;
using Ordenes.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenes.Modelos
{
    public class ordenMOD
    {
        _SQLServer objSQLServer = Form1.getSQLServer;
        private string m_servidor = "Servidor";
        private string m_database = "Indalum";
        private string m_codEmpresa = "01";


        #region PROPIEDADES-MODELO
        public int id { get; set; }

        public int Orden { get; set; }

        public int NumCotiza { get; set; }

        public object FecCotiza { get; set; }

        public int CodigoCLI { get; set; }

        public string Cliente { get; set; }

        public int CodigoITM { get; set; }

        public string Item { get; set; }

        public object FechaINI { get; set; }

        public object FechaFIN { get; set; }

        public object FechaENT { get; set; }


        public int CodigoEPL { get; set; }

        public string NombreEPL { get; set; }

        public object FechaENTPP { get; set; }

        public object TipoOFF { get; set; }

        public object FechaFAC { get; set; }

        public object Cantidad { get; set; }

        public object PreUnitario { get; set; }

        public object Subtotal { get; set; }

        public object IVA { get; set; }

        public object Total { get; set; }

        public object Abono { get; set; }

        public object Saldo { get; set; }

        public object FechaENTGuillo { get; set; }

        public int CodigoEPLGuillo { get; set; }

        public string NombreEPLRESP_Guillo { get; set; }

        public int CodigoEPLRECMAT { get; set; }

        public string NombreEPLRECMAT_Guillo { get; set; }

        public bool AdjListaENT { get; set; }

        public string UUID { get; set; }

        public string Observaciones { get; set; }

        public bool _Estado { get; set; }

        #endregion


        

        public ordenMOD _BuscarORD()
        {
            try
            {
                dllBuscar.frmBuscarITEM objBuscar = new dllBuscar.frmBuscarITEM();
                Dictionary<string, string> dicFiltros = new Dictionary<string, string>();
                dicFiltros.Add("Orden", "Orden");
                dicFiltros.Add("LTRIM(RTRIM(ISNULL(dbo.climae.CliApl,'')+' '+ISNULL(dbo.climae.CliNom,'')))", "Cliente");
                objBuscar.pro_Configura
                    ._set01Connection(m_servidor, m_database)
                    ._set02Find(sqlQuery.ord_cabBuscaORD, new string[] { "@CodEmpresa" }, new object[] { m_codEmpresa })
                    ._set03OptionsFilter(dicFiltros)
                    ._setVisibleCOL(true, new string[] { "Orden", "Cliente", "Item", "Cantidad" })
                    ._setSeleccionSimple(true);
                objBuscar.ShowDialog();
                return _toEntity._row2object<ordenMOD>(objBuscar.pro_FilaSEL);
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los registros","Orden" ,ex.Message);
                return null;
            }
        }

        public void _guardaOrden(ordenMOD modelo)
        {
            string[] paramsNames = new string[] {"@CodEmpresa","@ordenID",
                "@numeroORD","@NumCotiza","@FecCotiza","@CodCliente","@FechaINI","@FechaFIN",
                "@CodigoEPL","@ItemSecuencial","@FechaENT","@FechaENTPP","@TipoOFFSET",
                "@FechaFAC","@AdjuntaLIS","@Cantidad","@PrecioUNI","@Subtotal","@IVA","@Total",
                "@Abono","@Saldo","@FechaENT_GUILLO","@EplRespondeGUILLO","EplRecibeMATGUILLO",
                "@UUID","@Observacion" };

            object[] paramsValues = new object[] {m_codEmpresa,modelo.id,
            modelo.Orden,modelo.NumCotiza,modelo.FecCotiza,modelo.CodigoCLI,modelo.FechaINI,modelo.FechaFIN,
            modelo.CodigoEPL,modelo.CodigoITM,modelo.FechaENT,modelo.FechaENTPP,modelo.TipoOFF,
            modelo.FechaFAC,modelo.AdjListaENT,modelo.Cantidad,modelo.PreUnitario,modelo.Subtotal,modelo.IVA,modelo.Total,
            modelo.Abono,modelo.Saldo,modelo.FechaENTGuillo,modelo.CodigoEPLGuillo,modelo.CodigoEPLRECMAT,
            modelo.UUID,modelo.Observaciones};

            objSQLServer._Ejecutar(sqlQuery.ord_cabEliminaG, paramsNames, paramsValues);
            objSQLServer._Ejecutar(sqlQuery.ord_cabGuardaORD, paramsNames, paramsValues);


        }
    }
}
