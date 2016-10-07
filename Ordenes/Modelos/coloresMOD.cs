using Ordenes.Clases;
using Ordenes.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenes.Modelos
{
    public class coloresMOD:_modelo
    {

        _SQLServer objSQLServer = Form1.getSQLServer;
        const double maxRange = 999999999.99;
        const double minRange = 0.00000001;
        //PROPIEDADES DEL MODELO
        #region PROPIEDADES-MODELO

        [Required(ErrorMessage = "El componente o sección a crear es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El componente o sección a crear está fuera del rango")]
        public int Componente { get; set; }

        [Required(ErrorMessage = "El secuencial del material es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El secuencial del materialr está fuera del rango")]
        public int SecMaterial { get; set; }

        [Required(ErrorMessage = "El lado de impresión es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El lado de impresión está fuera del rango")]
        public int LadoImpresion { get; set; }

        [Required(ErrorMessage = "El color es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El color está fuera del rango")]
        public int Color { get; set; }

        [Required(ErrorMessage = "El costo del gramo es obligatorio")]
        [Range(minRange, maxRange, ErrorMessage = "El costo del gramo está fuera del rango")]
        public decimal CostoGramo { get; set; }

        [Required(ErrorMessage = "El porcentaje de cobertura es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El porcentaje de cobertura está fuera del rango")]
        public int Cobertura { get; set; }

        [Range(1, maxRange, ErrorMessage = "El código de pantone está fuera del rango")]
        public int Pantone { get; set; }

        [Required(ErrorMessage = "El número de páginas es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El número de páginas está fuera del rango")]
        public int NumPaginas { get; set; }

        [Required(ErrorMessage = "El número de gramos por cm2 es obligatorio")]
        [Range(minRange, maxRange, ErrorMessage = "El número de gramos por cm2 está fuera del rango")]
        public decimal GramosXcm2 { get; set; }

        [Required(ErrorMessage = "El total de gramos es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El total de gramos está fuera del rango")]
        public decimal TotalGramos { get; set; }

        [Required(ErrorMessage = "El total de línea es obligatorio")]
        [Range(minRange, maxRange, ErrorMessage = "El total de línea está fuera del rango")]
        public decimal TotalLinea { get; set; }

        [Required(ErrorMessage = "El detalle de páginas en donde aplicar el color es obligatorio")]
        public string DetallePag { get; set; }

        #endregion

        public void _Guardar(int idCotiza,int secDetalle)
        {
            string[] paramsName = new string[] { "@idCotiza","@SecDetalle",
                    "@Componente","@SecMaterial","@LadoImpresion","@TipoColor",
                    "@CostoGramo","@Cobertura","@Pantone","@NumPaginas",
                    "@gramosXcm2","@TotalGramos", "@TotalLinea","@DetallePag" };


            object[] paramsValue = new object[] {idCotiza,secDetalle,
                    this.Componente,this.SecMaterial,this.LadoImpresion,this.Color,
                    this.CostoGramo,this.Cobertura,this.Pantone,this.NumPaginas,
                    this.GramosXcm2,this.TotalGramos,this.TotalLinea,this.DetallePag};

            objSQLServer._Ejecutar(sqlCotizacion.cot_guardaDET_Color, paramsName, paramsValue);


        }

        public bool _validar()
        {
            return this._isValid();
            //OTRAS VALIDACIONES 
        }


    }
}
