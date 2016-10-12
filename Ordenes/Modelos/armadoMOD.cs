using Ordenes.Clases;
using Ordenes.Properties;
using System.ComponentModel.DataAnnotations;

namespace Ordenes.Modelos
{
    public class armadoMOD:_modelo
    {
        _SQLServer objSQLServer = frmPrincipal.getSQLServer;
        const double maxRange = 999999999;
        const double minRange = 0.00000001;

        //PROPIEDADES DEL MODELO
        #region PROPIEDADES-MODELO

        [Required(ErrorMessage = "El componente o sección a crear es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El componente o sección a crear está fuera del rango")]
        public int Componente { get; set; }

        [Required(ErrorMessage = "El grupo del material es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El grupo del material está fuera del rango")]
        public int CodTalla { get; set; }

        [Required(ErrorMessage ="El material de trabajo es obligatorio")]
        [Range(1,maxRange,ErrorMessage ="El secuencial del material está fuera del rango")]
        public int SecMaterial { get; set; }

        [Required(ErrorMessage ="Número de páginas es un campo obligatorio")]
        [Range(1,maxRange,ErrorMessage ="Número de paginas esta fuera del intervalo")]
        public object NumPaginas { get; set; }

        [Required(ErrorMessage = "El ancho del trabajo es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El ancho del trabajo está fuera del rango")]
        public decimal TrabajoAncho { get; set; }

        [Required(ErrorMessage = "El alto del trabajo es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El alto del trabajo está fuera del rango")]
        public decimal TrabajoAlto { get; set; }

        [Required(ErrorMessage = "El Número de paginas por trabajo es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El Número de paginas por trabajo está fuera del rango")]
        public int PaginasXtrabajo { get; set; }

        [Required(ErrorMessage = "El Ancho del tamaño es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El Ancho del tamaño está fuera del rango")]
        public decimal TamanoAncho { get; set; }

        [Required(ErrorMessage = "El Alto del tamaño es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El Alto del tamaño está fuera del rango")]
        public decimal TamanoAlto { get; set; }

        [Required(ErrorMessage = "El número de trabajos por tamaño es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El número de trabajos por tamaño está fuera del rango")]
        public int TrabajosXtamano { get; set; }

        [Required(ErrorMessage = "El Ancho del pliego es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El Ancho del pliego está fuera del rango")]
        public decimal PliegoAncho { get; set; }

        [Required(ErrorMessage = "El Alto del pliego es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El Alto del pliego está fuera del rango")]
        public decimal PliegoAlto { get; set; }

        [Required(ErrorMessage = "El número de tamaños por pliego es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El número de tamaños por pliego está fuera del rango")]
        public int TamanosXpliego { get; set; }

        [Required(ErrorMessage = "La cantidad de pliegos es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "La cantidad de pliegos está fuera del rango")]
        public int PliegoCantidad { get; set; }

        [Required(ErrorMessage = "La cantidad de pliegos extras es obligatorio")]
        [Range(0, maxRange, ErrorMessage = "La cantidad de pliegos extras está fuera del rango")]
        public decimal Extra { get; set; }

        [Required(ErrorMessage = "El número de pliegos cotizados es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El número de pliegos cotizados está fuera del rango")]
        public int PliegoCotizados { get; set; }

        [Required(ErrorMessage = "El costo del material es obligatorio")]
        [Range(0.01, maxRange, ErrorMessage = "El costo del material está fuera del rango")]
        public decimal Costo { get; set; }

        [Required(ErrorMessage = "El Total de Línea es obligatorio")]
        [Range(0.01, maxRange, ErrorMessage = "El Total de Línea está fuera del rango")]
        public decimal TotalLinea { get; set; }

        [Required(ErrorMessage = "El campo seleccion automática es obligatorio")]
        public bool AUT { get; set; }

        [Required(ErrorMessage = "El campo código de placa es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El campo código de placa está fuera del rango")]
        public int CodPlaca { get; set; }

        #endregion

        public void _Guardar(int idCotiza)
        {


            string[] paramsName = new string[] { "@idCotiza","@Componente",
                    "@idTalla","@SecMaterial","@NumPaginas","@TrabajoAncho","@TrabajoAlto",
                    "@paginasXtrabajo","@TamanoAncho","@TamanoAlto","@trabajosXtamano",
                    "@PliegoAncho","@PliegoAlto","@tamanosXpliego","@pliegoCant","@pliegoPorcentajeEXT",
                    "@pliegoCotizados","@pliegoCosto","@TotalLinea","@seleccionAUT","@idPlaca" };


            object[] paramsValue = new object[] {idCotiza,this.Componente,
                    this.CodTalla,this.SecMaterial,this.NumPaginas,this.TrabajoAncho,this.TrabajoAlto,
                    this.PaginasXtrabajo,this.TamanoAncho,this.TamanoAlto,this.TrabajosXtamano,
                    this.PliegoAncho,this.PliegoAlto,this.TamanosXpliego,this.PliegoCantidad,this.Extra,
                    this.PliegoCotizados,this.Costo,this.TotalLinea,this.AUT,this.CodPlaca};

            objSQLServer._Ejecutar(sqlCotizacion.cot_guardaDET_Armados, paramsName, paramsValue);


        }

        public bool _validar()
        {
            return this._isValid();
            //OTRAS VALIDACIONES 
        }


    }
}
