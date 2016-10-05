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
    public class blockMOD:_modelo
    {

        private _SQLServer objSQLServer = Form1.getSQLServer;
        private string m_codEmpresa = Form1.getSession.Empresa.Codigo;
        private DataTable dtColores = null;

        #region PROPIEDADES-MODELO
   
        public int CmbEmblocado { get; set; }

        [StringLength(10, ErrorMessage ="Referencia máximo 10 caracteres")]
        public string Serie { get; set; }

        [Range(0,9999999,ErrorMessage ="El valor inicial de numeración de blocks esta fuera del rango")]
        public int Inicia { get; set; }

        [Range(0, 9999999, ErrorMessage = "El valor final de numeración de blocks esta fuera del rango")]
        public int Termina { get; set; }

        [Range(0, 9999, ErrorMessage = "El juego de blocks esta fuera del rango")]
        public int Juego { get; set; }

        #endregion

        public blockMOD _cargaBlock(int cotizaID)
        {
            try
            {
                DataTable dtBlock = objSQLServer._CargaDataTable(sqlCotizacion.cot_blockCargaBlock,
                    new string[] { "@cotizaID" },new object[] { cotizaID });
                //retorna el objeto o nulo
                return dtBlock != null && dtBlock.Rows.Count == 1 ? 
                    _toEntity._row2object<blockMOD>(dtBlock.Rows[0]) : new blockMOD();
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los blocks", "Cargar datos", ex.Message);
                return null;
            }
        }

        public void _guardaBlock(int idCotiza)
        {
            if (this._isValid())
            {
                string[] paramsName = new string[] {"@idCotiza", "@Serie",
                    "@Inicia", "@Termina", "@Juego", "@CmbEmblocado" };

                object[] paramsValue = new object[] {idCotiza,this.Serie,
                    this.Inicia,this.Termina,this.Juego,this.CmbEmblocado};

                objSQLServer._Ejecutar(sqlCotizacion.cot_guardaBlock, paramsName, paramsValue);
            }
            else
            {
                clsMensaje._msjWarning("Se ha encontrado " + pro_getTotalErrors.ToString() + " errores",
                    "Verificar datos", pro_getErrrors);
            }
            
        }

    }
}
