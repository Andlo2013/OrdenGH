using Ordenes.Clases;
using Ordenes.Properties;
using System.ComponentModel.DataAnnotations;

namespace Ordenes.Modelos
{

    public class ProcesosMOD : _modelo
    {

        _SQLServer objSQLServer = Form1.getSQLServer;
        const int maxRange = 999999999;
        const double minRange = 0.00000001;

        #region PROPIEDADES-MODELO

        [Required(ErrorMessage = "El código de máquina es obligatorio")]
        public string CodigoMAQ { get; set; }

        [Required(ErrorMessage = "El costo es obligatorio")]
        [Range(minRange, maxRange, ErrorMessage = "El costo está fuera del rango")]
        public decimal Costo { get; set; }

        [Required(ErrorMessage = "El número de minutos es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El número de minutos está fuera del rango")]
        public int Minutos { get; set; }

        [Required(ErrorMessage = "El total de línea es obligatorio")]
        [Range(minRange, maxRange, ErrorMessage = "El total de línea está fuera del rango")]
        public decimal TotalLinea { get; set; }

        #endregion

        public void _Guardar(int idCotiza)
        {
            string[] paramsName = new string[] { "@idCotiza", "@MaqCod",
                    "@Costo", "@Minutos", "@Total" };

            object[] paramsValue = new object[] {idCotiza,this.CodigoMAQ,
                    this.Costo,this.Minutos,this.TotalLinea};

            objSQLServer._Ejecutar(sqlCotizacion.cot_guardaDET_Proceso, paramsName, paramsValue);

        }

        public bool _validar()
        {
            return this._isValid();
            //OTRAS VALIDACIONES 
        }

    }

}
