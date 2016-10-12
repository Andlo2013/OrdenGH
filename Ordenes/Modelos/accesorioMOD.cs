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
    public class accesorioMOD:_modelo
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

        [Required(ErrorMessage = "La columna tiraje debe ser llenada obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El tiraje está fuera del rango")]
        public int Tiraje { get; set; }

        [Required(ErrorMessage = "La cantidad es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "La cantidad está fuera del rango")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "El costo es obligatorio")]
        [Range(minRange, maxRange, ErrorMessage = "El costo está fuera del rango")]
        public decimal Costo { get; set; }

        [Required(ErrorMessage = "El total de línea es obligatorio")]
        [Range(minRange, maxRange, ErrorMessage = "El total de línea está fuera del rango")]
        public decimal TotalLinea { get; set; }

        #endregion

        public void _Guardar(int idCotiza, int secDetalle)
        {
            string[] paramsName = new string[] { "@idCotiza", "@SecDetalle",
                    "@Componente", "@SecMaterial","@Tiraje",
                    "@Cantidad","@Costo","@TotalLinea" };


            object[] paramsValue = new object[] {idCotiza,secDetalle,
                    this.Componente,this.SecMaterial,this.Tiraje,
                    this.Cantidad,this.Costo,this.TotalLinea};

            objSQLServer._Ejecutar(sqlCotizacion.cot_guardaDET_Accesorios, paramsName, paramsValue);


        }

        public bool _validar()
        {
            return this._isValid();
            //OTRAS VALIDACIONES 
        }


    }
}
