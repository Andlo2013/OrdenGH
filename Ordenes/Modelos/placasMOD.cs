using Ordenes.Clases;
using Ordenes.Properties;
using System.ComponentModel.DataAnnotations;

namespace Ordenes.Modelos
{
    public class placasMOD:_modelo
    {

        _SQLServer objSQLServer = Form1.getSQLServer;
        const int maxRange = 999999999;
        const double minRange = 0.00000001;

        #region PROPIEDADES-MODELO

        [Required(ErrorMessage = "El componente o sección a crear es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El componente o sección a crear está fuera del rango")]
        public int Componente { get; set; }

        [Required(ErrorMessage = "El secuencial de material es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El secuencial de material está fuera del rango")]
        public int SecMaterial { get; set; }

        [Required(ErrorMessage = "El tipo de placa es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El tipo de placa está fuera del rango")]
        public int CodPlaca { get; set; }

        [Required(ErrorMessage = "Indicar los lados de la placa es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "Lados de la placa está fuera del rango")]
        public int LadoPlaca { get; set; }

        [Required(ErrorMessage = "El número de colores es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El número de colores está fuera del rango")]
        public int NumColores { get; set; }

        [Required(ErrorMessage = "El número de placas es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El número de placas está fuera del rango")]
        public int NumPlacas { get; set; }

        [Required(ErrorMessage = "El costo de la placa es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El costo de la placa está fuera del rango")]
        public decimal CostoPlaca { get; set; }

        [Required(ErrorMessage = "El número de paginas es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El número de páginas está fuera del rango")]
        public int NumPaginas { get; set; }

        [Required(ErrorMessage = "El número de trabajos por placa es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El número de trabajos por placa está fuera del rango")]
        public int TrabajosXplaca { get; set; }

        [Required(ErrorMessage = "El número de páginas por trabajo es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El número de páginas por trabajo está fuera del rango")]
        public int PaginasXtrabajo { get; set; }

        [Required(ErrorMessage = "El total de línea es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El total de línea está fuera del rango")]
        public decimal TotalLinea { get; set; }

        #endregion

        public void _Guardar(int idCotiza, int secDetalle)
        {
            string[] paramsName = new string[] { "@idCotiza","@SecDetalle",
                    "@Componente","@SecMaterial","@idPlaca","@LadoImpresion",
                    "@NumColores","@NumPlacas","@CostoPlaca","@Numpaginas",
                    "@trabajosXplaca","@paginasXtrabajo","@TotalLinea"};


            object[] paramsValue = new object[] {idCotiza,secDetalle,
                    this.Componente,this.SecMaterial,this.CodPlaca,this.LadoPlaca,
                    this.NumColores,this.NumPlacas,this.CostoPlaca,this.NumPaginas,
                    this.TrabajosXplaca,this.PaginasXtrabajo,this.TotalLinea};

            objSQLServer._Ejecutar(sqlCotizacion.cot_guardaDET_Placas, paramsName, paramsValue);


        }

        public bool _validar()
        {
            return this._isValid();
            //OTRAS VALIDACIONES 
        }

    }
}
