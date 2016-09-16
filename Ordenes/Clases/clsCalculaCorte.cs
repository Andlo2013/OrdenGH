using AutomatizerSQL.Utilidades;
using dllMensaje;
using Ordenes.Properties;
using System;
using System.Data;
using System.Linq;

namespace Ordenes.Clases
{

    public class clsCalculaCorte
    {

        //INSTANCIAS-VARIABLES DE LA CLASE
        #region Instancias-Variables

        _SQLServer objSQLServer = Form1.getSQLServer;

        private DataTable dtPliegosGRP = null;
        private DataTable dtPlacas = null;
        private DataTable dtPliegosIMP = null;
        private DataRow rowMaterial = null;

        private string m_codEmpresa = Form1.getSession.Empresa.Codigo;
        
        //medidas del material
        private decimal m_materialAncho = 0;
        private decimal m_materialAlto = 0;

        //medidas del corte (usuario)
        private decimal m_corteAncho = 0;
        private decimal m_corteAlto = 0;

        //medidas a cortar (sugeridas por sistema)
        private decimal m_tamanoAncho = 0;
        private decimal m_tamanoAlto = 0;
        private int m_tamanoCantidad = 0;
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

                if ((areaDesperdicio1 > areaDesperdicio2 && areaDesperdicio2>=0) || (areaDesperdicio1<0 && areaDesperdicio2 >= 0))
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

        //Numero de filas en los cortes
        #region proNumFilas
        public int pro_numFilas
        {
            get { return m_numeroFIL; }
        }
        #endregion

        //Numero de columnas en los cortes
        #region proNumColumnas
        public int pro_numColumnas
        {
            get { return m_numeroCOL; }
        }
        #endregion

        //Ordena los pliegos de impresion y regresa un DataView 
        //para mostrar al usuario la seleccion del sistema
        #region pliegosIMP
        public DataView pro_PliegosIMP
        {
            get
            {
                /*ordena por:
                 * 1.- Desperdicio ascendente para tomar la menor perdida
                 * 2.- Total Pagina descendente en caso de igual perdida. Selecciona el que imprime mas paginas
                 * 3.- TrabajosXtamano descendente para hacer menos cortes a la materia prima
                */
                DataView dv = new DataView(dtPliegosIMP);
                dv.Sort = "PliegoDesperdicio, TotalPaginas DESC, TrabajosXtamano DESC";
                return dv;
            }
        }
        #endregion

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

                        //INICIA EL PROCESO DE CALCULO DE LOS ARMADOS (DISENO)
                        _disenoArmadoCalcular(rowSEL);

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

        //METODO INICIAL DEL CALCULO
        #region disenoArmadoCalcular
        private void _disenoArmadoCalcular(DataRow rowDetalle)
        {

            //Recupera todas las placas
            dtPlacas = objSQLServer._CargaDataTable(sqlCotizacion.cot_cargaPlacas,
                new string[] { "@CodEmpresa" }, new object[] { m_codEmpresa });

            //Recupera los pliegos del grupo
            dtPliegosGRP = objSQLServer._CargaDataTable(sqlCotizacion.cot_disArmadosCargaMAT,
                new string[] { "@CodEmpresa", "@CodGrupo", "@CodTalla", "@CodComponente" },
                new object[] { m_codEmpresa, rowDetalle["CodGrupo"], rowDetalle["CodTalla"], rowDetalle["Componente"] });

            _disenoArmadoCreaDTPliegoIMP(rowDetalle["PaginasXtrabajo"].ToInt());

            _disenoArmadoObtienePliegoIMP(rowDetalle["TrabajoAnchoMasPinza"].ToDecimal(), 
                rowDetalle["TrabajoAltoMasPinza"].ToDecimal(),rowDetalle["AUT"].ToBool(), rowDetalle["CodPlaca"].ToInt());

            _disenoArmadoSelMatPliego();

            _disenoArmadoOptimizaDesperdicio(rowDetalle);

            _disenoArmadoVerificaInvertir(rowDetalle);

        }
        #endregion

        //CREA EL DATATABLE DE PLIEGO DE IMPRESION
        #region disenoArmadoCreDTPliegoIMP
        private void _disenoArmadoCreaDTPliegoIMP(int PaginasXtrabajo)
        {
            dtPliegosIMP = new DataTable();
            dtPliegosIMP.Columns.Add("CodPlaca", System.Type.GetType("System.String"));
            dtPliegosIMP.Columns.Add("Placa", System.Type.GetType("System.String"));
            dtPliegosIMP.Columns.Add("TamanoAncho", System.Type.GetType("System.Decimal"));
            dtPliegosIMP.Columns.Add("TamanoAlto", System.Type.GetType("System.Decimal"));
            dtPliegosIMP.Columns.Add("TamanoFilas", System.Type.GetType("System.Int32"));
            dtPliegosIMP.Columns.Add("TamanoColumnas", System.Type.GetType("System.Int32"));
            dtPliegosIMP.Columns.Add("TrabajosXtamano", System.Type.GetType("System.Int32"));
            
            dtPliegosIMP.Columns.Add("SecMaterial", System.Type.GetType("System.Int32"));
            dtPliegosIMP.Columns.Add("Material", System.Type.GetType("System.String"));
            dtPliegosIMP.Columns.Add("PliegoAncho", System.Type.GetType("System.Decimal"));
            dtPliegosIMP.Columns.Add("PliegoAlto", System.Type.GetType("System.Decimal"));
            dtPliegosIMP.Columns.Add("PliegoDesperdicio", System.Type.GetType("System.Decimal"));
            dtPliegosIMP.Columns.Add("PliegoPorcentajeEXT", System.Type.GetType("System.Decimal"));
            dtPliegosIMP.Columns.Add("TamanosXpliego", System.Type.GetType("System.Int32"));
            dtPliegosIMP.Columns.Add("PaginasXTrabajo", System.Type.GetType("System.Int32"));
            dtPliegosIMP.Columns.Add("TotalPaginas", System.Type.GetType("System.Int32"),"TamanosXpliego*TrabajosXtamano*PaginasXtrabajo");
            dtPliegosIMP.Columns["PaginasXtrabajo"].Expression = PaginasXtrabajo.ToString();
        }
        #endregion

        //OBTIENE LOS TAMANOS DE LOS PLIEGOS DE IMPRESION
        #region disenoArmadoObtienePliegoIMP
        private void _disenoArmadoObtienePliegoIMP(decimal trabajoAncho,decimal trabajoAlto,bool esSeleccionAUT,int PlacaSEL)
        {
            string filtroPlaca = esSeleccionAUT==false && PlacaSEL > 0 ?  "Codigo=" + PlacaSEL.ToString() : "" ;
            DataRow [] drPlacas = dtPlacas.Select(filtroPlaca);

            if (drPlacas != null)
            {
                foreach (DataRow rowPlaca in drPlacas)
                {
                    _Calcular(rowPlaca["Ancho"].ToDecimal(), rowPlaca["Alto"].ToDecimal(),
                                    trabajoAncho, trabajoAlto);
                    if (this.pro_Desperdicio >= 0)
                    {
                        DataRow rowPliegoIMP = dtPliegosIMP.NewRow();
                        rowPliegoIMP["CodPlaca"] = rowPlaca["Codigo"];
                        rowPliegoIMP["Placa"] = rowPlaca["Placa"];
                        rowPliegoIMP["TamanoAncho"] = this.pro_TamanoAncho * this.pro_numColumnas;
                        rowPliegoIMP["TamanoAlto"] = this.pro_TamanoAlto * this.pro_numFilas;
                        rowPliegoIMP["TamanoFilas"] = this.pro_numFilas;
                        rowPliegoIMP["TamanoColumnas"] = this.pro_numColumnas;
                        rowPliegoIMP["TrabajosXtamano"] = this.pro_TamanoCantidad;
                        dtPliegosIMP.Rows.Add(rowPliegoIMP);
                    }
                }
            }
        }
        #endregion

        //SELECCIONA EL PLIEGO DE MATERIA PRIMA OPTIMO
        //PARA CADA PLACA O MAQUINA DISPONIBLE
        #region disenoArmadoSelMatPliego
        private void _disenoArmadoSelMatPliego()
        {

            foreach (DataRow rowPliegoIMP in dtPliegosIMP.Rows)
            {
                _EligeMaterialAUT(dtPliegosGRP,
                            rowPliegoIMP["TamanoAncho"].ToDecimal(),
                            rowPliegoIMP["TamanoAlto"].ToDecimal());

                if (this.pro_MaterialSEL != null)
                {
                    rowPliegoIMP["SecMaterial"] = this.pro_MaterialSEL["SecMaterial"];
                    rowPliegoIMP["Material"] = this.pro_MaterialSEL["Material"];
                    rowPliegoIMP["PliegoAncho"] = this.pro_MaterialSEL["Ancho"];
                    rowPliegoIMP["PliegoAlto"] = this.pro_MaterialSEL["Alto"];
                    rowPliegoIMP["TamanoAncho"] = this.pro_TamanoAncho;
                    rowPliegoIMP["TamanoAlto"] = this.pro_TamanoAlto;
                    rowPliegoIMP["TamanosXpliego"] = this.pro_TamanoCantidad;
                    rowPliegoIMP["PliegoDesperdicio"] = this.pro_Desperdicio;
                    rowPliegoIMP["PliegoPorcentajeEXT"] = this.pro_MaterialSEL["PorcentajeEXT"];
                }
            }
        }
        #endregion

        //SELECCIONA LA PLACA O MAQUINA QUE MENOR PERDIDA GENERA 
        #region disenoArmadoOptimizaDesperdicio
        private void _disenoArmadoOptimizaDesperdicio(DataRow rowDetalle)
        {
            if (dtPliegosIMP != null && dtPliegosIMP.Rows.Count > 0)
            {
                /*ordena por:
                 * 1.- Desperdicio ascendente para tomar la menor perdida
                 * 2.- Total Pagina descendente en caso de igual perdida. Selecciona el que imprime mas paginas
                 * 3.- TrabajosXtamano descendente para hacer menos cortes a la materia prima
                */
                var resultado = from registro in dtPliegosIMP.AsEnumerable()
                                orderby registro.Field<Decimal>("PliegoDesperdicio") ascending,
                                        registro.Field<Int32>("TotalPaginas") descending,
                                        registro.Field<Int32>("TrabajosXtamano") descending
                                select registro;

                foreach (DataRow rowPliego in resultado)
                {
                    rowDetalle["SecMaterial"] = rowPliego["SecMaterial"];
                    rowDetalle["Material"] = rowPliego["Material"];
                    rowDetalle["PliegoAncho"] = rowPliego["PliegoAncho"];
                    rowDetalle["PliegoAlto"] = rowPliego["PliegoAlto"];
                    rowDetalle["TamanoAncho"] = rowPliego["TamanoAncho"];
                    rowDetalle["TamanoAlto"] = rowPliego["TamanoAlto"];
                    rowDetalle["TrabajosXtamano"] = rowPliego["TrabajosXtamano"];
                    rowDetalle["TamanosXpliego"] = rowPliego["TamanosXpliego"];
                    rowDetalle["PorcentajeEXT"] = rowPliego["PliegoPorcentajeEXT"];
                    rowDetalle["CodPlaca"] = rowPliego["CodPlaca"];
                    rowDetalle["Placa"] = rowPliego["Placa"];
                    break;
                }
            }
            else
            {
                _disenoArmadoEnceraFila(rowDetalle);
            }
        }
        #endregion

        //CUANDO NO HAY PLIEGOS DE IMPRESION. ENCERA VALORES
        #region disenoArmadoEnceraFila
        private void _disenoArmadoEnceraFila(DataRow rowDetalle)
        {
            rowDetalle["SecMaterial"] = 0;
            rowDetalle["Material"] = "";
            rowDetalle["PliegoAncho"] = 0;
            rowDetalle["PliegoAlto"] = 0;
            rowDetalle["TamanoAncho"] = 0;
            rowDetalle["TamanoAlto"] = 0;
            rowDetalle["TrabajosXtamano"] = 0;
            rowDetalle["TamanosXpliego"] = 0;
            rowDetalle["PorcentajeEXT"] = 0;
            rowDetalle["CodPlaca"] = 0;
            rowDetalle["Placa"] = "";
        }
        #endregion

        //EL PLIEGO DE IMPRESION NUNCA GENERA PERDIDA PORQUE ES CORTADO ACORDE
        //A LAS MEDIDAS DEL TRABAJO Y DE LA MAQUINA. SI HAY UN DESPERDICIO
        //SE DEBE A QUE SE CAMBIO EL SENTIDO DEL PLIEGOIMP AL MOMENTO DE ACOMODAR
        // EN EL PLIEGO MATERIAMP
        #region disenoArmadoVerificaInvertir
        private void _disenoArmadoVerificaInvertir(DataRow rowDetalle)
        {
            //El pliegoIMP o tamano se calcula en funcion de las medidas del trabajo
            //por lo tanto siempre debe ser exacto. Caso contrario 
            //significa que al momento de cortar el pliegoMP se cambio el sentido
            //del pliegoIMP (HORIZONTAL->VERTICAL) entonces se actualiza medidas
            decimal anchoTamano = rowDetalle["TamanoAncho"].ToDecimal();
            decimal anchoTrabajo = rowDetalle["TrabajoAnchoMasPinza"].ToDecimal();
            if (( anchoTamano%anchoTrabajo ) > 0)
            {
                object aux = rowDetalle["TrabajoAncho"];
                rowDetalle["TrabajoAncho"] = rowDetalle["TrabajoAlto"];
                rowDetalle["TrabajoAlto"] = aux;
            }
        }
        #endregion

        #endregion

    }

}
