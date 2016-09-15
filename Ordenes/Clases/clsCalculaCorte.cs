using AutomatizerSQL.Utilidades;
using dllMensaje;
using Ordenes.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenes.Clases
{
    public class clsCalculaCorte
    {

        //INSTANCIAS-VARIABLES DE LA CLASE
        #region Instancias-Variables

        _SQLServer objSQLServer = Form1.getSQLServer;

        private DataTable dtPliegosGRP = null;
        private DataTable dtPlacas = null;
        private DataRow rowMaterial = null;

        private string m_codEmpresa = Form1.getSession.Empresa.Codigo;

        private decimal m_tamanoAncho = 0;
        private decimal m_tamanoAlto = 0;
        private int m_tamanoCantidad = 0;

        private decimal m_materialAncho = 0;
        private decimal m_materialAlto = 0;

        private decimal m_corteAncho = 0;
        private decimal m_corteAlto = 0;

        private int m_numeroFIL = 0;
        private int m_numeroCOL = 0;
        private decimal m_Desperdicio = 0;

        #endregion

        public clsCalculaCorte() { }


        //MÉTODOS PROPIOS DE LA CLASE
        #region MÉTODOS

        //Calcula el area de desperdicio
        #region areaDesperdicio
        private decimal _AreaDesperdicio(decimal anchoMAT, decimal altoMAT, decimal anchoCOR, decimal altoCOR)
        {
            if (anchoMAT >= anchoCOR && altoMAT >= altoCOR)
            {
                decimal anchoResiduo = anchoMAT % anchoCOR;
                decimal altoResiduo = altoMAT % altoCOR;
                decimal areaDesperdicio = (anchoResiduo * altoMAT) + (altoResiduo * anchoMAT) - (anchoResiduo * altoResiduo);
                return areaDesperdicio;
            }
            return -1;
        }
        #endregion

        //Método central de cálculos
        #region Calcular
        public void _Calcular(decimal anchoMAT, decimal altoMAT, decimal anchoCOR, decimal altoCOR)
        {

            _InicializaVariables(anchoMAT, altoMAT, anchoCOR, altoCOR);
            if (anchoMAT > 0 && altoMAT > 0 && anchoCOR > 0 && altoCOR > 0)
            {
                decimal areaDesperdicio1 = _AreaDesperdicio(m_materialAncho, m_materialAlto, m_corteAncho, m_corteAlto);
                decimal areaDesperdicio2 = _AreaDesperdicio(m_materialAncho, m_materialAlto, m_corteAlto, m_corteAncho);

                m_tamanoAncho = m_corteAncho;
                m_tamanoAlto = m_corteAlto;
                m_Desperdicio = areaDesperdicio1;

                if (areaDesperdicio1 > areaDesperdicio2 && areaDesperdicio2 >= 0)
                {
                    m_tamanoAlto = m_corteAncho;
                    m_tamanoAncho = m_corteAlto;
                    m_Desperdicio = areaDesperdicio2;
                }

                m_numeroFIL = (Math.Floor(m_materialAlto / m_tamanoAlto)).ToInt();
                m_numeroCOL = (Math.Floor(m_materialAncho / m_tamanoAncho)).ToInt();
                m_tamanoCantidad = m_numeroFIL * m_numeroCOL;
            }
        }
        #endregion

        //Inicializa las variables
        #region InicializaVariables
        private void _InicializaVariables(decimal anchoMAT, decimal altoMAT, decimal anchoCOR, decimal altoCOR)
        {
            m_materialAncho = anchoMAT;
            m_materialAlto = altoMAT;
            m_corteAncho = anchoCOR;
            m_corteAlto = altoCOR;

            m_tamanoAncho = 0;
            m_tamanoAlto = 0;
            m_tamanoCantidad = 0;
            m_Desperdicio = 0;
        }
        #endregion

        //Recorre las opciones para seleccionar la mejor
        #region EligeMaterialAUT
        public void _EligeMaterialAUT(DataTable dtMateriales, decimal AnchoCOR, decimal AltoCOR)
        {

            clsCalculaCorte objResultAUX = new clsCalculaCorte();

            if (dtMateriales != null && dtMateriales.Rows.Count > 0)
            {
                decimal desperdicioTEMP = -1;
                bool isFirstTime = true;
                foreach (DataRow rowMP in dtMateriales.Rows)
                {
                    _Calcular(rowMP["Ancho"].ToDecimal(),
                        rowMP["Alto"].ToDecimal(), AnchoCOR, AltoCOR);

                    if (this.pro_Desperdicio >= 0)
                    {
                        if (isFirstTime ||
                            (this.pro_Desperdicio <= desperdicioTEMP &&
                            this.pro_TamanoCantidad > 0))
                        {
                            this.rowMaterial = rowMP;
                            desperdicioTEMP = this.pro_Desperdicio;
                            isFirstTime = false;
                            _updateInstance(this, objResultAUX);
                        }
                    }
                }
                _updateInstance(objResultAUX, this);
            }
        }
        #endregion

        //Actualiza las propiedades de las instancias
        #region updateInstance
        private void _updateInstance(clsCalculaCorte objetoORI, clsCalculaCorte objetoDEST)
        {
            if (objetoORI != null && objetoDEST != null)
            {
                objetoDEST.m_Desperdicio = objetoORI.pro_Desperdicio;
                objetoDEST.rowMaterial = objetoORI.pro_MaterialSEL;
                objetoDEST.m_tamanoAncho = objetoORI.pro_TamanoAncho;
                objetoDEST.m_tamanoAlto = objetoORI.pro_TamanoAlto;
                objetoDEST.m_tamanoCantidad = objetoORI.pro_TamanoCantidad;
            }
        }
        #endregion

        #endregion

        //PROPIEDADES
        #region PROPIEDADES

        //Ancho sugerido
        #region proTamanoAncho
        public decimal pro_TamanoAncho { get { return m_tamanoAncho; } }
        #endregion

        //Alto sugerido
        #region proTamanoAlto
        public decimal pro_TamanoAlto { get { return m_tamanoAlto; } }
        #endregion

        //Cantidad de cortes
        #region proTamanoCantidad
        public int pro_TamanoCantidad { get { return m_tamanoCantidad; } }
        #endregion

        //DataRow con el que se va a trabajar
        #region proMaterialSEL
        public DataRow pro_MaterialSEL { get { return rowMaterial; } }
        #endregion

        //Area desperdiciada
        #region proDesperdicio
        public decimal pro_Desperdicio { get { return m_Desperdicio; } }
        #endregion

        public int pro_numFilas
        {
            get { return m_numeroFIL; }
        }

        public int pro_numColumnas
        {
            get { return m_numeroCOL; }
        }

        #endregion

        //MÉTODOS QUE IMPLEMENTAN FUNCIONALIDAD DE CLASES EXTERNAS
        #region MÉTODOS: EXTERNOS

        //DISENO ARMADO CALCULAR
        #region ext_disenoArmadoCalcula
        public void _ext_disenoArmadoCalcula(DataRow rowSEL)
        {
            try
            {
                if (rowSEL != null)
                {
                    if (rowSEL["TrabajoAncho"].ToDecimal() > 0 && rowSEL["TrabajoAlto"].ToDecimal() > 0)
                    {
                        //elige las placas que entren en las medidas de los pliegos disponibles del grupo seleccionado
                        //EJEMPLO si la medida maxima de pliego en el grupo es 90*60 no puede usar una placa de 70*80
                        _ext_PlacasValidas(rowSEL);
                        _ext_disenoArmadoEligePlaca(rowSEL);
                        _ext_disenoArmadoEligePliego(rowSEL);
                        
                        
                        //Actualiza los valores de la fila para reflejar los cambios
                        rowSEL.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar calcular los valores de la fila", "Calcular fila", ex.Message);
            }
        }
        #endregion

        //PLACAS VALIDAS
        #region ext_PlacasValidas
        /// <summary>
        /// Verifica los placas que se pueden utilizar 
        /// en funcion de las medidas de las pliegos disponibles
        /// </summary>
        /// <param name="rowDetalle">DataRow a analizar</param>
        private void _ext_PlacasValidas(DataRow rowDetalle)
        {
            //Recupera todas las placas
            dtPlacas = objSQLServer._CargaDataTable(sqlCotizacion.cot_cargaPlacas,
                new string[] { "@CodEmpresa" }, new object[] { m_codEmpresa });

            //Recupera los pliegos del grupo
            dtPliegosGRP = objSQLServer._CargaDataTable(sqlCotizacion.cot_disArmadosCargaMAT,
                new string[] { "@CodEmpresa", "@CodGrupo", "@CodTalla", "@CodComponente" }, 
                new object[] { m_codEmpresa, rowDetalle["CodGrupo"], rowDetalle["CodTalla"], rowDetalle["Componente"] });
            //calcula las areas
            dtPlacas.Columns.Add("Area", System.Type.GetType("System.Decimal"), "Ancho*Alto");
            dtPliegosGRP.Columns.Add("Area", System.Type.GetType("System.Decimal"), "Ancho*Alto");

            //crea una lista para agregar pliegos que tienen area superior a las placas
            List<DataRow> rowEliminar = new List<DataRow>();
            //
            foreach (DataRow rowPlaca in dtPlacas.Rows)
            {
                //compara cada placa y busca si hay una pliego en el que pueda entrar
                if (dtPliegosGRP.Select("Area>=" + rowPlaca["Area"]).Length <= 0)
                {
                    //si no encuentra agrega a la lista de eliminar
                    rowEliminar.Add(rowPlaca);
                }
            }
            //elimina las pliegos mas grandes que las placas para no considerar en el calculo
            for (int i = 0; i < rowEliminar.Count; i++)
            {
                dtPlacas.Rows.Remove(rowEliminar[i]);
            }
        }
        #endregion

        //DISENO ARMADO ELIGE PLACA
        #region ext_disenoArmadoEligePlaca
        private void _ext_disenoArmadoEligePlaca(DataRow rowDetalle)
        {
            decimal trabajoAncho = rowDetalle["TrabajoAncho"].ToDecimal();
            decimal trabajoAlto = rowDetalle["TrabajoAlto"].ToDecimal();
            _EligeMaterialAUT(dtPlacas, trabajoAncho, trabajoAlto);
            if (this.pro_MaterialSEL != null)
            {
                rowDetalle["TamanoAncho"] = this.pro_TamanoAncho * pro_numColumnas; //this.pro_MaterialSEL["Ancho"];//rowPlaca["Ancho"];
                rowDetalle["TamanoAlto"] = this.pro_TamanoAlto * pro_numFilas;//this.pro_MaterialSEL["Alto"];//rowPlaca["Alto"];
                rowDetalle["TrabajoAncho"] = this.pro_TamanoAncho;
                rowDetalle["TrabajoAlto"] = this.pro_TamanoAlto;
                rowDetalle["TrabajosXtamano"] = this.pro_TamanoCantidad;
            }
            else
            {
                rowDetalle["TamanoAncho"] = 0;
                rowDetalle["TamanoAlto"] = 0;
                rowDetalle["TrabajoAncho"] = trabajoAncho;
                rowDetalle["TrabajoAlto"] = trabajoAlto;
                rowDetalle["TrabajosXtamano"] = 0;
            }

        }
        #endregion

        //DISENO ARMADO ELIGE PLIEGO
        #region ext_disenoArmadoEligePliego
        private void _ext_disenoArmadoEligePliego(DataRow rowDetalle)
        {
            decimal tamanoAncho = rowDetalle["TamanoAncho"].ToDecimal();
            decimal tamanoAlto = rowDetalle["TamanoAlto"].ToDecimal();
            _EligeMaterialAUT(dtPliegosGRP, tamanoAncho, tamanoAlto);
            if (this.pro_MaterialSEL != null)
            {
                rowDetalle["SecMaterial"] = this.pro_MaterialSEL["SecMaterial"];
                rowDetalle["Material"] = this.pro_MaterialSEL["Material"];
                rowDetalle["PliegoAncho"] = this.pro_MaterialSEL["Ancho"];
                rowDetalle["PliegoAlto"] = this.pro_MaterialSEL["Alto"];
                rowDetalle["TamanoAncho"] = this.pro_TamanoAncho;
                rowDetalle["TamanoAlto"] = this.pro_TamanoAlto;
                rowDetalle["TamanosXpliego"] = this.pro_TamanoCantidad;
                rowDetalle["PorcentajeEXT"] = this.pro_MaterialSEL["PorcentajeEXT"];
            }
            else
            {
                rowDetalle["SecMaterial"] = -1;
                rowDetalle["Material"] = "";
                rowDetalle["PliegoAncho"] = 0;
                rowDetalle["PliegoAlto"] = 0;
                rowDetalle["TamanoAncho"] = tamanoAncho;
                rowDetalle["TamanoAlto"] = tamanoAlto;
                rowDetalle["TrabajosXpliego"] = 0;
                rowDetalle["PorcentajeEXT"] = 0;
            }
        }
        #endregion

        #endregion

    }
}
