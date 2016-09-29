using dllMensaje;
using Ordenes.Clases;
using Ordenes.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ordenes.Modelos
{
    public class cotizaMOD:_modelo
    {
        _SQLServer objSQLServer = new _SQLServer();
        //PEDIDO ING. VELEZ DEFINIR EL NÚMERO COTIZACIÓN INICIA Y DESPUÉS SEA AUTOMÁTICO
        private int CotizaINI = 1;
        private string m_codEmpresa = Form1.getSession.Empresa.Codigo;
        private string m_servidor = Form1.getSession.Servidor;
        private string m_baseDatos = Form1.getSession.Catalogo;

        //PROPIEDADES DEL MODELO
        #region PROPIEDADES

        [Required(ErrorMessage ="ID es obligatorio")]
        [Range(1,9999999,ErrorMessage ="No es un número de 'ID' válido")]
        public int id { get; set; }

        [Required(ErrorMessage = "Número de cotización es obligatorio")]
        [Range(1, 9999999, ErrorMessage = "No es un 'Número Cotización' válido")]
        public int Cotizacion { get; set; }

        [Required(ErrorMessage = "Código de cliente es obligatorio")]
        [Range(1, 9999999, ErrorMessage = "No es un 'Código de cliente' válido")]
        public int CodigoCLI { get; set; }

        [Required(ErrorMessage = "Número de CI/RUC es obligatorio")]
        [StringLength(13, ErrorMessage = "No es un número de CI/RUC válido", MinimumLength = 10)]
        public string CIRUC { get; set; }

        [Required(ErrorMessage = "Nombre de cliente es obligatorio")]
        public string Cliente { get; set; }

        [Required(ErrorMessage = "Línea de producción es obligatorio")]
        [Range(1, 9999, ErrorMessage = "No es una 'Línea de Producción' válida")]
        public int LineaPRD { get; set; }

        [Required(ErrorMessage = "Grupo es obligatorio")]
        [Range(1, 9999, ErrorMessage = "No es un 'Grupo' válido")]
        public int Grupo { get; set; }

        [Required(ErrorMessage = "Subgrupo es obligatorio")]
        [Range(1, 9999, ErrorMessage = "No es un 'Subgrupo' válido")]
        public int Subgrupo { get; set; }

        [Required(ErrorMessage = "ITEM es obligatorio")]
        [Range(1, 9999999, ErrorMessage = "No es un 'ITEM' válido")]
        public int SecuencialITEM { get; set; }

        [Required(ErrorMessage = "Descripción del artículo es obligatorio")]
        public string Articulo { get; set; }

        [Required(ErrorMessage = "Tiraje es obligatorio")]
        [Range(1, 9999, ErrorMessage = "No es un 'Tiraje' válido")]
        public int Tiraje { get; set; }

        [Required(ErrorMessage = "Ancho es obligatorio")]
        [Range(1, 9999, ErrorMessage = "No es un 'Ancho' válido")]
        public decimal Ancho { get; set; }

        [Required(ErrorMessage = "Alto es obligatorio")]
        [Range(1, 9999, ErrorMessage = "No es un 'Alto' válido")]
        public decimal Alto { get; set; }

        [Required(ErrorMessage = "Fecha cotización es obligatorio")]
        public object FecCotiza { get; set; }

        [Required(ErrorMessage = "Fecha entrega es obligatorio")]
        public object FecEntrega { get; set; }

        [Required(ErrorMessage = "Estado cotización es obligatorio")]
        public int EstadoCOT { get; set; }

        [Required(ErrorMessage = "Cotizador es obligatorio")]
        [Range(1, 99999, ErrorMessage = "No es un 'Código de Cotizador' válido")]
        public int EplCotiza { get; set; }

        public string Cotizador { get; set; }

        [Required(ErrorMessage = "Vendedor es obligatorio")]
        [Range(1, 99999, ErrorMessage = "No es un 'Código de Vendedor' válido")]
        public int EplVendedor { get; set; }

        public string Vendedor { get; set; }

        [Required(ErrorMessage = "Estado del Registro es obligatorio")]
        public bool Estado { get; set; }

        #endregion


        private void _numeroCOT()
        {
            try
            {
                int secuencialCOT = objSQLServer._CalculaCodigo("pr_Cotiza","NumCotiza","WHERE (EmpCod=@CodEmpresa)",
                    new string[] {"@CodEmpresa" },new object[] {m_codEmpresa });
                secuencialCOT = secuencialCOT < CotizaINI ? CotizaINI : secuencialCOT;
                this.Cotizacion = secuencialCOT;
            }
            catch(Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar calcular el secuencial de cotización", "Cotización", ex.Message);
                this.Cotizacion= - 1;
            }
        }

        private void _calculaID()
        {
            try
            {
                this.id = objSQLServer._CalculaCodigo("pr_Cotiza", "NumCotiza", "",
                    new string[] { "@CodEmpresa" }, new object[] { m_codEmpresa });
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar calcular el identificador", "Cotización", ex.Message);
                this.id= -1;
            }
        }

        public void _nuevaCOT()
        {
            _numeroCOT();
            _calculaID();
        }

        public cotizaMOD _buscaCOT()
        {
            try {
                Dictionary<string, string> dicFiltro = new Dictionary<string, string>();
                dicFiltro.Add("NumCotiza", "Cotizacion");
                dicFiltro.Add("LTRIM(RTRIM(ISNULL(dbo.climae.CliApl,'')+' '+ISNULL(dbo.climae.CliNom,'')))", "Cliente");

                dllBuscar.frmBuscarITEM objFiltrar = new dllBuscar.frmBuscarITEM();
                objFiltrar.pro_Configura._set01Connection(m_servidor, m_baseDatos)
                    ._set02Find(sqlCotizacion.cot_buscaCOT, 
                    new string[] { "@CodEmpresa"},
                    new object[] { m_codEmpresa })
                    ._set03OptionsFilter(dicFiltro)
                    ._setSeleccionSimple(true)
                    ._setVisibleCOL(true, new string[] { "Cotizacion", "Cliente", "Articulo" });
                objFiltrar.ShowDialog();
                DataRow row = objFiltrar.pro_FilaSEL;

                return row != null ? _toEntity._row2object<cotizaMOD>(row) : new cotizaMOD();
            }
            catch(Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar buscar los registros", "Buscar", ex.Message);
                return new cotizaMOD();
            }

        }

        public void _guardaCOT()
        {
            if (this._isValid())
            {
                clsMensaje._msjInformation("Haz guardado el registro :) ", "Felicitaciones");
            }
            else
            {
                clsMensaje._msjWarning("Se ha encontrado "+ pro_getTotalErrors.ToString()+" errores", 
                    "Verificar datos", pro_getErrrors);
            }

        }
    }
}
