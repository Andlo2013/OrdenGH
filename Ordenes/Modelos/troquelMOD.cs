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
    public class troquelMOD:_modelo
    {
        _SQLServer objSQLServer = frmPrincipal.getSQLServer;
        const double maxRange = 999999999;
        const double minRange = 0.00000001;

        #region PROPIEDADES-MODELO

        [Required(ErrorMessage = "El componente o sección a crear es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El componente o sección a crear está fuera del rango")]
        public int Componente { get; set; }

        [Required(ErrorMessage = "El secuencial del material es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El secuencial del material está fuera del rango")]
        public int SecMaterial { get; set; }

        [Required(ErrorMessage = "La longitud es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "La longitud está fuera del rango")]
        public decimal Longitud { get; set; }

        [Required(ErrorMessage = "El número de cortes es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El número de cortes está fuera del rango")]
        public int NumCortes { get; set; }

        [Required(ErrorMessage = "El costo de corte es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El costo de corte está fuera del rango")]
        public decimal CostoCorte { get; set; }

        [Required(ErrorMessage = "El total de línea es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El total de línea está fuera del rango")]
        public decimal TotalLinea { get; set; }

        #endregion

        public void _Guardar(int idCotiza, int secDetalle)
        {
            string[] paramsName = new string[] { "@idCotiza", "@SecDetalle",
                    "@Componente", "@SecMaterial", "@Longitud",
                    "@NumCortes","@CostoCorte","@TotalLinea" };


            object[] paramsValue = new object[] {idCotiza,secDetalle,
                    this.Componente,this.SecMaterial,this.Longitud,
                    this.NumCortes,this.CostoCorte,this.TotalLinea};

            objSQLServer._Ejecutar(sqlCotizacion.cot_guardaDET_Troquel, paramsName, paramsValue);


        }

        public bool _validar()
        {
            return this._isValid();
            //OTRAS VALIDACIONES 
        }

    }
}
