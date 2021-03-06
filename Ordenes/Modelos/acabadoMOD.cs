﻿using Ordenes.Clases;
using Ordenes.Properties;
using System.ComponentModel.DataAnnotations;

namespace Ordenes.Modelos
{
    public class acabadoMOD: _modelo
    {

        _SQLServer objSQLServer = frmPrincipal.getSQLServer;
        const double maxRange = 999999999;
        const double minRange = 0.00000001;

        #region PROPIEDADES-MODELO
        [Required(ErrorMessage = "El componente o sección a crear es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El componente o sección a crear está fuera del rango")]
        public int Componente { get; set; }

        [Required(ErrorMessage = "El grupo del material es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El grupo del material está fuera del rango")]
        public int CodTalla { get; set; }

        [Required(ErrorMessage = "El secuencial de material es obligatorio")]
        [Range(1, maxRange, ErrorMessage = "El secuencial de material está fuera del rango")]
        public int SecMaterial { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un acabado")]
        [Range(1, maxRange, ErrorMessage = "El acabado está fuera del rango")]
        public int idAcabado { get; set; }

        [Required(ErrorMessage = "El área a la que se aplica el acabado es obligatoria")]
        public string areaAplica { get; set; }

        public int idTallaAcabado { get; set; }
        
        //CUANDO ES EXTERNO NO REGISTRA MATERIAL DE ACABADO
        public int SecMaterialAcabado { get; set; }

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
                    "@Componente","@TallaId", "@SecMaterial","@AcabadoId",
                    "@areaAplica","@TallaAcabadoId","@SecMaterialAcabado",
                    "@Costo","@TotalLinea" };


            object[] paramsValue = new object[] {idCotiza,secDetalle,
                    this.Componente,this.CodTalla,this.SecMaterial,
                    this.idAcabado,this.areaAplica,this.idTallaAcabado,
                    this.SecMaterialAcabado,this.Costo,this.TotalLinea};

            objSQLServer._Ejecutar(sqlCotizacion.cot_guardaDET_Acabado, paramsName, paramsValue);

        }

        public bool _validar()
        {
            return this._isValid();
            //OTRAS VALIDACIONES 
        }


    }
}
