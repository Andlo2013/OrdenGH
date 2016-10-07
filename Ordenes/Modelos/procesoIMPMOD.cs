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

    public class procesoIMPMOD:_modelo
    {
        _SQLServer objSQLServer = Form1.getSQLServer;
        const int maxRange = 999999999;
        const double minRange = 0.00000001;

        #region PROPIEDADES-MODELO

        [Required(ErrorMessage = "El componente o sección a crear es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El componente o sección a crear está fuera del rango")]
        public int Componente { get; set; }

        [Required(ErrorMessage = "El grupo del material obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El grupo del material está fuera del rango")]
        public int idTalla { get; set; }

        [Required(ErrorMessage = "El secuencial del material es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El secuencial del material está fuera del rango")]
        public int SecMaterial { get; set; }

        [Required(ErrorMessage = "Debe seleccionar una placa")]
        [Range(1, maxRange, ErrorMessage = "El código de placa está fuera del rango")]
        public int PlacaId { get; set; }

        [Required(ErrorMessage = "El número de colores es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El número de colores está fuera del rango")]
        public int NumColores { get; set; }

        [Required(ErrorMessage = "El número de pliegos por minuto es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El número de pliegos por minuto está fuera del rango")]
        public int PliegosXmin { get; set; }

        [Required(ErrorMessage = "El costo de impresión por minuto es obligatorio")]
        [Range(minRange, maxRange, ErrorMessage = "El costo de impresión por minuto está fuera del rango")]
        public decimal CostoMinIMP { get; set; }

        [Required(ErrorMessage = "El número de pliegos es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El número de pliegos está fuera del rango")]
        public int NumPliegos { get; set; }

        [Required(ErrorMessage = "El número de impresiones por minuto es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El número de impresiones por minuto está fuera del rango")]
        public int NumMinIMP { get; set; }

        [Required(ErrorMessage = "El costo de impresiones por minuto es obligatorio")]
        [Range(minRange, maxRange, ErrorMessage = "El costo de impresiones por minuto está fuera del rango")]
        public decimal CostoXminPP { get; set; }

        [Required(ErrorMessage = "Los minutos necesarios para puesta en punto de la máquina es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "Los minutos necesarios para puesta en punto de la máquina está fuera del rango")]
        public int MinutosPP { get; set; }

        [Required(ErrorMessage = "El total de línea es obligatorio")]
        [Range(minRange, maxRange, ErrorMessage = "El total de línea está fuera del rango")]
        public decimal TotalLinea { get; set; }

        #endregion

        public void _Guardar(int idCotiza, int secDetalle)
        {
            string[] paramsName = new string[] {"@idCotiza","@SecDetalle",
                    "@Componente","@TallaId","@SecMaterial","@PlacaId",
                    "@NumColores","@pliegosXmin","@CostoMinIMP","@NumPliegos",
                    "@NumMinIMP","@CostoXminPP","@MinutosPP","@TotalLinea" };


            object[] paramsValue = new object[] {idCotiza,secDetalle,
                this.Componente,this.idTalla,this.SecMaterial,this.PlacaId,
                this.NumColores,this.PliegosXmin,this.CostoMinIMP,this.NumPliegos,
                this.NumMinIMP,this.CostoMinIMP,this.MinutosPP,this.TotalLinea};

            objSQLServer._Ejecutar(sqlCotizacion.cot_guardaDET_ProcesoIMP, paramsName, paramsValue);

        }

        public bool _validar()
        {
            return this._isValid();
            //OTRAS VALIDACIONES 
        }

    }

}
