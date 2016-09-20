using DevExpress.XtraEditors;
using dllBuscar;
using dllMensaje;
using Ordenes.Modelos;
using Ordenes.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatizerSQL.Utilidades;
using Ordenes.Formularios;
using DevExpress.XtraEditors.Repository;

namespace Ordenes.Clases
{
    public class clsCotizacion
    {
        _SQLServer objSQLServer = Form1.getSQLServer;
        _Comunes objComunes = new _Comunes();
        DataTable dtClienteDEST = null;
        DataTable dtBlockColor = null;
        DataTable dtDisenoArmado = null;
        DataTable dtDisenoColor = null;
        DataTable dtDisenoPlaca = null;
        DataTable dtDisenoMaterialCLI = null;
        DataTable dtProcesoDET = null;

        DataTable dtDisenoPorCOB = null;
        DataTable dtColorPlanchas= null;
        //////ordenMOD modelo_Orden = new ordenMOD();
        trabajoGenMOD modelo_TrabajoGEN = new trabajoGenMOD();
        blockMOD modelo_Block = new blockMOD();
        libroEncMOD modelo_LibroENC = new libroEncMOD();
        libroPorMOD modelo_LibroPOR = new libroPorMOD();

        private string m_codEmpresa = Form1.getSession.Empresa.Codigo;
        private string m_Servidor = Form1.getSession.Servidor;
        private string m_Catalogo = Form1.getSession.Catalogo;
        //VALOR DE PINZAS SOLICITADO POR GLADYS QUE SE SUME EN FORMA AUTOMATICA 
        //A LAS MEDIDAS DE ANCHO Y ALTO DEL TRABAJO
        private decimal m_margenPinza = 1;

        public clsCotizacion() { _Inicializa(); }

        private void _Inicializa()
        {
            dtDisenoPorCOB = objSQLServer._CargaDataTable(sqlCotizacion.cmb_cargaPorcentajeCOB,
                 new string[] { "@CodEmpresa" }, new object[] { m_codEmpresa });
            dtColorPlanchas = objSQLServer._CargaDataTable(sqlCotizacion.cmb_colorPlancha,
                 new string[] { "@CodEmpresa" }, new object[] { m_codEmpresa });
        }

        //CLIENTE
        #region Cliente

        public DataRow _clienteBuscar()
        {
            try
            {
                frmBuscarITEM objBuscar = new frmBuscarITEM();
                Dictionary<string, string> dicFiltros = new Dictionary<string, string>();
                dicFiltros.Add("LTRIM(RTRIM(ISNULL(dbo.climae.CliApl,'')+' '+ISNULL(dbo.climae.CliNom,'')))", "Cliente");
                objBuscar.pro_Configura
                    ._set01Connection(m_Servidor, m_Catalogo)
                    ._set02Find(sqlCotizacion.cot_clienteBuscar, new string[] { "@CodEmpresa" }, new object[] { m_codEmpresa })
                    ._set03OptionsFilter(dicFiltros)
                    ._setSeleccionSimple(true);
                objBuscar.ShowDialog();
                return objBuscar.pro_FilaSEL;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los registros", ex.Message);
                return null;
            }
        }

        public DataTable _clienteCargaDEST(int cotizaID)
        {
            try
            {
                dtClienteDEST = objSQLServer._CargaDataTable(sqlCotizacion.cot_clienteCargaDestino,
                                                new string[] { "@CodEmpresa", "@cotizaID" },
                                                new object[] { m_codEmpresa, cotizaID });
                return dtClienteDEST;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar recuperar los destinos", "Cargar datos", ex.Message);
                return null;
            }
        }

        public DataTable _clienteCargaTEL(object CodCliente)
        {
            try
            {
                DataTable dtClienteTEL = objSQLServer._CargaDataTable(sqlCotizacion.cot_cliCargaTelefono,
                                                new string[] { "@CodEmpresa", "@CodigoCLI" },
                                                new object[] { m_codEmpresa, CodCliente });
                return dtClienteTEL;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar recuperar los teléfonos del cliente", "Cargar datos", ex.Message);
                return null;
            }
        }

        public void _clienteDESTAgrega(int CodigoCLI)
        {
            try
            {
                DataRow[] filasSEL = _clienteDESTBuscar(CodigoCLI);
                if (filasSEL != null)
                {
                    foreach (DataRow row in filasSEL)
                    {
                        DataRow rowDestino = dtClienteDEST.NewRow();
                        rowDestino["Secuencial"] = 0;
                        rowDestino["CodSucursal"] = row["CodSucursal"];
                        rowDestino["Ciudad"] = row["Ciudad"];
                        rowDestino["Direccion"] = row["Dirección"];
                        rowDestino["Cantidad"] = 0;
                        dtClienteDEST.Rows.Add(rowDestino);
                    }
                }
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar agregar el registro", "Agrega Destino", ex.Message);
            }

        }

        private DataRow[] _clienteDESTBuscar(int CodigoCLI)
        {
            DataTable dtSucursales = objSQLServer._CargaDataTable(sqlQuery.ord_CLIAgregaSUC,
                new string[] { "@CodEmpresa", "@CodigoCLI" }, new object[] { m_codEmpresa, CodigoCLI });
            frmBuscar objBuscar = new frmBuscar(dtSucursales);
            objBuscar._setVisibleCOL(new string[] { "Ciudad", "Dirección" }, true);
            objBuscar._setAnchoCOL(new string[] { "Ciudad", "Dirección" }, new int[] { 400, 600 });
            objBuscar._setMultiSelect(true);
            objBuscar.ShowDialog();
            return objBuscar.proFilasSEL;
        }

        public void _clienteDESTElimina(DataRow rowElimina)
        {
            try
            {
                if (rowElimina != null)
                {
                    dtClienteDEST.Rows.Remove(rowElimina);
                }
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar eliminar el registro", "Eliminar", ex.Message);
            }
        }

        #endregion

        //BLOCKS
        #region Block

        public DataTable _blockColorCargaDET(int cotizaID)
        {
            try
            {
                dtBlockColor = objSQLServer._CargaDataTable(sqlCotizacion.cot_blockCargaColor,
                    new string[] { "@cotizaID" },new object[] { cotizaID });
                return dtBlockColor;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los colores del block", "Cargar datos", ex.Message);
                return null;
            }
        }

        public void _blockColorElimina(DataRow rowElimina)
        {
            try
            {
                if (rowElimina != null)
                {
                    dtBlockColor.Rows.Remove(rowElimina);
                }
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar eliminar el registro", "Eliminar", ex.Message);
            }
        }

        #endregion


        //DISENO
        #region DISENO

        //DISEÑO ARMADOS
        #region Diseno-Armados

        //CARGA EL DETALLE DE LOS ARMADOS
        #region disenoArmadoCargaDET
        public DataTable _disenoArmadoCargaDET(int cotizaID,int tiraje,object CodGrupo)
        {
            try
            {
                dtDisenoArmado = objSQLServer._CargaDataTable(sqlCotizacion.cot_disArmadosDET,
                    new string[] { "@CodEmpresa", "@cotizaID" }, new object[] { m_codEmpresa, cotizaID });
                
                //AGREGA COLUMNAS AUXILIARES PARA CALCULO
                dtDisenoArmado.Columns.Add("CodGrupo", System.Type.GetType("System.Int32"));
                dtDisenoArmado.Columns.Add("PaginasXpliego", System.Type.GetType("System.Decimal"));
                dtDisenoArmado.Columns.Add("Tiraje", System.Type.GetType("System.Decimal"));
                dtDisenoArmado.Columns.Add("TrabajoAnchoMasPinza", System.Type.GetType("System.Decimal"), "TrabajoAncho+" + m_margenPinza);
                dtDisenoArmado.Columns.Add("TrabajoAltoMasPinza", System.Type.GetType("System.Decimal"), "TrabajoAlto+" + m_margenPinza);
                dtDisenoArmado.Columns.Add("PliegoCantidadAUX", System.Type.GetType("System.Decimal"));
                dtDisenoArmado.Columns.Add("Extra", System.Type.GetType("System.Decimal"), "Convert(PaginasXpliego*(PorcentajeEXT/100),'System.Int32')");
                dtDisenoArmado.Columns["CodGrupo"].DefaultValue = CodGrupo;
                dtDisenoArmado.Columns["NumPaginas"].DefaultValue = 1;
                dtDisenoArmado.Columns["PaginasXtrabajo"].DefaultValue = 1;
                dtDisenoArmado.Columns["PorcentajeEXT"].DefaultValue = 0;
                dtDisenoArmado.Columns["Tiraje"].DefaultValue = 0;
                dtDisenoArmado.Columns["AUT"].DefaultValue = true;
                dtDisenoArmado.Columns["CodPlaca"].DefaultValue = 0;
                dtDisenoArmado.Columns["TrabajosXtamano"].DefaultValue = 0;
                dtDisenoArmado.Columns["TamanosXpliego"].DefaultValue = 0;
                
                //actualiza el tiraje para que pueda hacer el calculo
                _disenoArmadoUPDColumna("Tiraje",tiraje);
                //actualiza la columna codGrupo para recuperar los porcentajes de perdida al agregar o cambiar materiales
                _disenoArmadoUPDColumna("CodGrupo", CodGrupo);
                //PAGINAS QUE SE IMPRIMEN POR PLIEGO
                dtDisenoArmado.Columns["PaginasXpliego"].Expression = "PaginasXtrabajo*TrabajosXtamano*TamanosXpliego";
                //ESTO PORQUE AL HACER UNA CONVERSION A (INT) DE ACUERDO A LOS DECIMALES A VECES REDONDEA AL INFERIOR Y FALTARIA UN PLIEGO
                dtDisenoArmado.Columns["PliegoCantidadAUX"].Expression= "Convert(IIF(PaginasXpliego>0,((NumPaginas*Tiraje)/PaginasXpliego),0),'System.Int32')";
                //ESTA ES LA CANTIDAD DEFINITICVA DE PLIEGOS.
                dtDisenoArmado.Columns["PliegoCantidad"].Expression = "IIF(PliegoCantidadAUX*PaginasXpliego>=(NumPaginas*Tiraje),PliegoCantidadAUX,PliegoCantidadAUX+1)";
                dtDisenoArmado.Columns["PliegoCotizados"].Expression = "PliegoCantidad+Extra";
                return dtDisenoArmado;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar el detalle de armados", "Cargar datos", ex.Message);
                return null;
            }
        }
        #endregion

        //FILTRA LOS MATERIALES DEL ARMADO POR EL COMPONENTE
        #region disenoArmadoFiltrar
        public DataView _disenoArmadoFiltrar(int codComponente)
        {
            if (dtDisenoArmado != null)
            {
                DataView dvFiltrar = new DataView(dtDisenoArmado);
                dvFiltrar.RowFilter = "Componente=" + codComponente;
                return dvFiltrar;
            }
            return null;
        }
        #endregion

        //AGREGA MATERIALES A LOS ARMADOS
        #region disenoArmadoAgregaMAT
        public void _disenoArmadoAgregaMAT(int aTrabajoAlto, int aTrabajoAncho, 
            int aTiraje,object codGrupo,object codComponente)
        {
            try
            {
                Dictionary<string, string> dicionario = new Dictionary<string, string>();
                dicionario.Add("Talla", "Grupo");
                frmBuscarITEM objBuscar = new frmBuscarITEM();
                objBuscar.pro_Configura
                    ._set01Connection(m_Servidor, m_Catalogo)
                    ._set02Find(sqlCotizacion.cot_disArmadosAgregaGrupo, 
                                new string[] { "@CodEmpresa" }, 
                                new object[] { m_codEmpresa })
                    ._set03OptionsFilter(dicionario)
                    ._setSeleccionSimple(false);

                objBuscar.ShowDialog();

                _disenoArmadoAddMAT(objBuscar.pro_dtFilasSEL,aTrabajoAlto,
                    aTrabajoAncho,aTiraje,codGrupo,codComponente);    
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar agregar materiales", "Agrega material", ex.Message);
            }
        }
        #endregion

        //AGREGA UN MATERIAL AL DETALLE
        #region disenoArmadoAddMAT
        private void _disenoArmadoAddMAT(DataTable filasSEL, decimal aTrabajoAlto,
            decimal aTrabajoAncho,int aTiraje,object codGrupo,object codComponente)
        {
            if (dtDisenoArmado != null && filasSEL != null)
            {
                clsCalculaCorte objCorte = new clsCalculaCorte();
                foreach (DataRow rowMAT in filasSEL.Rows)
                {
                    //NO PUEDE DUPLICAR EL MATERIAL EN LOS COMPONENTES
                    if (dtDisenoArmado.Select("Componente="+codComponente+
                        " AND CodTalla=" + rowMAT["Código"]).Length <= 0)
                    {
                        DataRow newRow = dtDisenoArmado.NewRow();
                        newRow["CodGrupo"] = codGrupo;
                        newRow["Componente"] = codComponente;
                        newRow["CodTalla"] = rowMAT["Código"];
                        newRow["Talla"] = rowMAT["Grupo"];
                        newRow["TrabajoAlto"] = aTrabajoAlto;
                        newRow["TrabajoAncho"] = aTrabajoAncho;
                        newRow["Tiraje"] = aTiraje;
                        dtDisenoArmado.Rows.Add(newRow);
                        //selecciona el pliego
                        objCorte._ext_disenoArmadoCalcula(newRow);
                    }
                }
            }
        }
        #endregion

        //HACE EL CALCULO DE OPTIMIZAR CORTES
        #region disenoArmadoCalcula
        public void _disenoArmadoCalcula(DataRow rowSEL)
        {
            try
            {
                if (rowSEL != null)
                {
                    clsCalculaCorte objCorte = new clsCalculaCorte();
                    objCorte._ext_disenoArmadoCalcula(rowSEL);
                }
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar calcular los valores de la fila", "Calcular fila", ex.Message);
            }
        }
        #endregion

        //HACE EL CALCULO Y MUESTRA LA GRAFICA DE CORTES
        #region disenoArmadoGrafica
        public void _disenoArmadoGrafica(DataRow rowSEL)
        {
            if (rowSEL != null)
            {
                frmCortes objCortes = new frmCortes();
                objCortes._ext_Graficar(rowSEL);
                objCortes.ShowDialog();
            }
        }
        #endregion

        //ELIMINA MATERIALES DE LOS ARMADOS
        #region disenoArmadoEliminaMAT
        public void _disenoArmadoEliminaMAT(DataRow rowElimina)
        {
            try
            {
                if (rowElimina != null)
                {
                    //ELIMINA TODAS LAS FILAS DE COLORES 
                    //QUE USEN EL MATERIAL EN EL COMPONENTE ELIMINADO

                    DataRow [] rowColoresELI = dtDisenoColor.Select("Componente=" + rowElimina["Componente"] +
                        " AND SecMaterial=" + rowElimina["SecMaterial"],"");

                    if (rowColoresELI != null)
                    {
                        foreach(DataRow rowColorELI in rowColoresELI)
                        {
                            _disenoColorElimina(rowColorELI);
                        }
                    }
                    dtDisenoArmado.Rows.Remove(rowElimina);
                    dtDisenoArmado.AcceptChanges();
                    
                }
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar eliminar el registro", "Eliminar", ex.Message);
            }
        }
        #endregion

        //VALIDA EL DETALLE DE ARMADOS
        #region disenoArmadoValida
        public bool _disenoArmadoValida()
        {
            try {
                if (dtDisenoArmado != null)
                {
                    int fila = 0;
                    foreach (DataRow row in dtDisenoArmado.Rows)
                    {
                        fila++;
                        string msj = "TABLA: DISEÑO -> ARMADOS\nEl registro de la fila Nro: " + fila.ToString() + "\n";

                        if (row["Componente"].ToInt() == 0)
                        {
                            msj += "No tiene asignado un componente";
                            clsMensaje._msjWarning(msj, "Verificar datos");
                            return false;
                        }
                        else if (row["SecMaterial"].ToInt() == 0)
                        {
                            msj += "No tiene asignado un material";
                            clsMensaje._msjWarning(msj, "Verificar datos");
                            return false;
                        }
                        else if (row["ArmadoAncho"].ToDecimal() <= 0)
                        {
                            msj += "El ancho del armado debe ser mayor a cero";
                            clsMensaje._msjWarning(msj, "Verificar datos");
                            return false;
                        }
                        else if (row["ArmadoAlto"].ToDecimal() <= 0)
                        {
                            msj += "El alto del armado debe ser mayor a cero";
                            clsMensaje._msjWarning(msj, "Verificar datos");
                            return false;
                        }
                        else if (row["PliegoAncho"].ToDecimal() <= 0)
                        {
                            msj += "El ancho del pliego debe ser mayor a cero";
                            clsMensaje._msjWarning(msj, "Verificar datos");
                            return false;
                        }
                        else if (row["PliegoAlto"].ToDecimal() <= 0)
                        {
                            msj += "El alto del pliego debe ser mayor a cero";
                            clsMensaje._msjWarning(msj, "Verificar datos");
                            return false;
                        }
                        else if (row["PliegoCantidad"].ToInt() <= 0)
                        {
                            msj += "La cantidad de pliegos debe ser mayor a cero";
                            clsMensaje._msjWarning(msj, "Verificar datos");
                            return false;
                        }
                        else if (row["Extra"].ToInt() <= 0)
                        {
                            msj += "La cantidad de impresiones extras debe ser mayor a cero";
                            clsMensaje._msjWarning(msj, "Verificar datos");
                            return false;
                        }
                        else if (row["Cotizadas"].ToInt() <= 0)
                        {
                            msj += "La cantidad de impresiones cotizadas debe ser mayor a cero";
                            clsMensaje._msjWarning(msj, "Verificar datos");
                            return false;
                        }
                        else if (row["Impresas"].ToInt() <= 0)
                        {
                            msj += "La cantidad de impresiones debe ser mayor a cero";
                            clsMensaje._msjWarning(msj, "Verificar datos");
                            return false;
                        }
                    }
                }
                return true;
            }catch(Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar verificar el detalle de Diseño->Armados", "Verificar datos", ex.Message);
                return false;
            }
        }
        #endregion

        //ACTUALIZA UNA COLUMNA COMPLETA EN EL DETALLE DE ARMADOS
        #region disenoArmadoUPDColumna
        public void _disenoArmadoUPDColumna(string columna,object valor)
        {
            if (dtDisenoArmado != null)
            {
                foreach (DataRow row in dtDisenoArmado.Rows)
                {
                    row[columna] = valor;
                }
            }
        }
        #endregion

        #endregion

        //DISEÑO COLOR
        #region Diseno-Color

        public void _disenoColorAddColor(object CodComponente)
        {
            DataView dvColores = new DataView(dtDisenoArmado);
            dvColores.RowFilter = "Componente=" + CodComponente;
            frmBuscar objBuscar = new frmBuscar(dvColores.ToTable());
            objBuscar._setVisibleCOL(new string[] { "Material" }, true);
            objBuscar._setMultiSelect(true);
            objBuscar.ShowDialog();
            DataRow [] drFilasSEL =objBuscar.proFilasSEL;
            if (dtDisenoColor != null && drFilasSEL!=null)
            {
                foreach (DataRow rowFila in drFilasSEL)
                {
                    DataRow rowColor = dtDisenoColor.NewRow();
                    rowColor["Componente"] = CodComponente;
                    rowColor["SecMaterial"] = rowFila["SecMaterial"];
                    rowColor["Material"] = rowFila["Material"];
                    rowColor["TamanoAncho"] = rowFila["TamanoAncho"];
                    rowColor["TamanoAlto"] = rowFila["TamanoAlto"];
                    rowColor["Cobertura"] = 0;
                    dtDisenoColor.Rows.Add(rowColor);
                }
            }
        }

        public void _disenoColorAgregaPantone(DataRow rowModifica)
        {
            try
            {
                DataRow rowSEL = objComunes._agregaMATSimple();
                if (rowSEL != null)
                {
                    rowModifica["Pantone"] = rowSEL["Descripción"];
                }
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar agregar materiales", "Agrega material", ex.Message);
            }
        }

        public void _disenoColorCargaCobertura(RepositoryItemLookUpEdit lueCobertura)
        {
            lueCobertura.DataSource = dtDisenoPorCOB;
            lueCobertura.ForceInitialize();
            lueCobertura.DisplayMember = "Descripcion";
            lueCobertura.ValueMember = "Codigo";
        }

        public void _disenoColorCargaPlanchas(RepositoryItemLookUpEdit lueColorPlancha)
        {
            lueColorPlancha.DataSource = dtColorPlanchas;
            lueColorPlancha.ForceInitialize();
            lueColorPlancha.DisplayMember = "Descripcion";
            lueColorPlancha.ValueMember = "Codigo";
        }

        public void _disenoColorCambiaCobertura(DataRow rowColor)
        {
            object coberturaTiro = rowColor["Cobertura"];

            DataRow [] rowCobertura=dtDisenoPorCOB.Select("Codigo="+coberturaTiro,"");
            if (rowCobertura != null && rowCobertura.Length == 1)
            {
                rowColor["Gramos"] = rowCobertura[0]["Gramos"];
            }
        }

        public void _disenoColorCambiaPlancha(DataRow rowColor)
        {
            object colorPlancha = rowColor["Color"];

            DataRow[] rowColorPlancha = dtColorPlanchas.Select("Codigo=" + colorPlancha, "");
            if (rowColorPlancha != null && rowColorPlancha.Length == 1)
            {
                rowColor["Color"] = rowColorPlancha[0]["Codigo"];
                rowColor["NumPlancha"] = rowColorPlancha[0]["Planchas"];
            }
        }

        public DataTable _disenoColorCargaDET(int cotizaID)
        {
            try
            {
                dtDisenoColor = objSQLServer._CargaDataTable(sqlCotizacion.cot_disColoresDET,
                    new string[] { "@CodEmpresa", "@cotizaID" }, new object[] { m_codEmpresa, cotizaID });
                dtDisenoColor.Columns.Add("Area", Type.GetType("System.Decimal"), "TamanoAncho*TamanoAlto");
                dtDisenoColor.Columns.Add("TotalGramos", Type.GetType("System.Decimal"), "Gramos*Area*NumPlancha");
                dtDisenoColor.Columns["Area"].DefaultValue = 0;
                dtDisenoColor.Columns["Gramos"].DefaultValue=0;
                dtDisenoColor.Columns["NumPaginas"].DefaultValue = 0;
                dtDisenoColor.Columns["NumPlancha"].DefaultValue = 0;
                return dtDisenoColor;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar el detalle de colores", "Cargar datos", ex.Message);
                return null;
            }
        }

        public void _disenoColorElimina(DataRow rowElimina)
        {
            try
            {
                if (rowElimina != null)
                {
                    dtDisenoColor.Rows.Remove(rowElimina);
                }
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar eliminar el registro", "Eliminar", ex.Message);
            }
        }

        public DataView _disenoColorFiltrar(int codComponente)
        {
            DataView dvFiltrar = new DataView(dtDisenoColor);
            dvFiltrar.RowFilter = "Componente=" + codComponente;
            return dvFiltrar;
        }

        public decimal[] _disenoColorTotales()
        {
            decimal gramosColor = 0;
            decimal gramosMetalizado = 0;
            decimal gramosPantone = 0;
            decimal numPlacas = 0;
            try
            {
                if (dtDisenoColor != null)
                {
                    //suma unColor, dosColores, fullColor
                    gramosColor = dtDisenoColor.Compute("SUM(TotalGramos)", "Color<=2").ToDecimal();
                    //suma Metalizado
                    gramosMetalizado = dtDisenoColor.Compute("SUM(TotalGramos)", "Color=4").ToDecimal();
                    //suma Pantones
                    gramosPantone = dtDisenoColor.Compute("SUM(TotalGramos)", "Color=5").ToDecimal();
                    //suma las placas
                    numPlacas= dtDisenoColor.Compute("SUM(NumPlancha)", "").ToDecimal();
                }
            }
            catch(Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar calcular los totales", "Totales", ex.Message);
            }
            return new decimal[] {gramosColor,gramosMetalizado,gramosPantone,numPlacas };
        }

        public bool _disenoColorValida()
        {
            try
            {
                if (dtDisenoColor != null)
                {
                    int fila = 0;
                    foreach (DataRow row in dtDisenoColor.Rows)
                    {
                        fila++;
                        string msj = "TABLA: DISEÑO -> COLOR\nEl registro de la fila Nro: " + fila.ToString() + "\n";
                        if (row["Componente"].ToInt() <= 0)
                        {
                            msj += "No tiene definido un componente";
                            clsMensaje._msjWarning(msj, "Verificar datos");
                            return false;
                        }
                        else if (row["Tiro"].ToInt() <= 0)
                        {
                            msj += "No tiene definido el color del Tiro";
                            clsMensaje._msjWarning(msj, "Verificar datos");
                            return false;
                        }
                        else if (row["Retiro"].ToInt() <= 0)
                        {
                            msj += "No tiene definido el color del Retiro";
                            clsMensaje._msjWarning(msj, "Verificar datos");
                            return false;
                        }
                        
                    }
                }
                return true;
            }
            catch(Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar verificar el detalle de Diseno->Colores", "Verificar datos", ex.Message);
                return false;
            }
        }

        #endregion

        //DISEÑO PLACAS
        #region Diseno-Placas

        public DataTable _disenoPlacaCargaDET(int cotizaID)
        {
            try
            {
                dtDisenoPlaca = objSQLServer._CargaDataTable(sqlCotizacion.cot_disPlacasDET,
                    new string[] { "@cotizaID" }, new object[] { cotizaID });
                return dtDisenoPlaca;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar el detalle de placas", "Cargar datos", ex.Message);
                return null;
            }
        }

        public DataView _disenoPlacaFiltrar(int codComponente)
        {
            DataView dvFiltrar = new DataView(dtDisenoPlaca);
            dvFiltrar.RowFilter = "Componente=" + codComponente;
            return dvFiltrar;
        }

        public void _disenoPlacaElimina(DataRow rowElimina)
        {
            try
            {
                if (rowElimina != null)
                {
                    dtDisenoPlaca.Rows.Remove(rowElimina);
                }
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar eliminar el registro", "Eliminar", ex.Message);
            }
        }

        #endregion

        //MATERIALES-CLIENTE
        #region Diseno-MaterialCliente

        public DataTable _disenoMATCLICargaDET(int cotizaID)
        {
            try
            {
                dtDisenoMaterialCLI = objSQLServer._CargaDataTable(sqlCotizacion.cot_disMATCLICargaDET,
                    new string[] {"@CodEmpresa", "@cotizaID" }, new object[] { m_codEmpresa,cotizaID });
                return dtDisenoMaterialCLI;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar el detalle de materiales del cliente", "Cargar datos", ex.Message);
                return null;
            }
        }

        public void _disenoMATCLIAgregaMAT()
        {
            try
            {
                DataTable dtFilasSEL = objComunes._agregaMATMultiple();
                _disenoMATCLIAddMAT(dtFilasSEL);
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar agregar materiales", "Agrega material", ex.Message);
            }
        }

        private void _disenoMATCLIAddMAT(DataTable filasSEL)
        {
            if (dtDisenoMaterialCLI != null && filasSEL != null)
            {
                foreach (DataRow rowMAT in filasSEL.Rows)
                {
                    int reg = dtDisenoMaterialCLI.Select("SecMaterial=" + rowMAT["Secuencial"].ToString(), "").Length;
                    if (reg <= 0)
                    {
                        DataRow newRow = dtDisenoMaterialCLI.NewRow();
                        newRow["SecMaterial"] = rowMAT["Secuencial"];
                        newRow["Material"] = rowMAT["Descripción"];
                        newRow["Cantidad"] = 0;
                        dtDisenoMaterialCLI.Rows.Add(newRow);
                    }
                }
            }
        }

        public void _disenoMATCLIEliminaMAT(DataRow rowElimina)
        {
            try
            {
                if (rowElimina != null)
                {
                    dtDisenoMaterialCLI.Rows.Remove(rowElimina);
                }
            }
            catch(Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar eliminar el registro", "Eliminar", ex.Message);
            }
        }

        #endregion

        #endregion

        //EMPLEADOS-VENDEDORES COTIZADORES
        #region Empleados

        public DataRow _empleadoBuscar()
        {
            try
            {
                frmBuscarITEM objBuscar = new frmBuscarITEM();
                Dictionary<string, string> dicFiltros = new Dictionary<string, string>();
                dicFiltros.Add("LTRIM(RTRIM((ISNULL(EplApl,'')+' '+ISNULL(EplNom,''))))", "Nombre");
                objBuscar.pro_Configura
                    ._set01Connection(m_Servidor, m_Catalogo)
                    ._set02Find(sqlCotizacion.cot_empleadoBusca, new string[] { "@CodEmpresa" }, new object[] { m_codEmpresa })
                    ._set03OptionsFilter(dicFiltros)
                    ._setSeleccionSimple(true);
                objBuscar.ShowDialog();
                return objBuscar.pro_FilaSEL;
            }
            catch(Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los registros", "Buscar vendedor", ex.Message);
                return null;
            }
        }

        #endregion

        //PROCESOS
        #region Procesos

        public DataTable _procesoCargaDET(int cotizaID)
        {
            try
            {
                dtProcesoDET = objSQLServer._CargaDataTable(sqlCotizacion.cot_procCargaDET,
                    new string[] { "@CodEmpresa", "@cotizaID" }, new object[] { m_codEmpresa, cotizaID });
                dtProcesoDET.Columns.Add("Total", System.Type.GetType("System.Decimal"));
                dtProcesoDET.Columns["Total"].Expression = "Costo*Cantidad";
                return dtProcesoDET;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar el detalle de procesos", "Cargar datos", ex.Message);
                return null;
            }
        }

        public void _procesoAgregaMAQ(int tiraje)
        {
            try
            {
                DataTable dtMaquinas = objSQLServer._CargaDataTable(sqlCotizacion.cot_procBuscaMAQ,
                    new string[] { "@CodEmpresa" }, new object[] { m_codEmpresa });
                dllBuscar.frmBuscar objBuscar = new dllBuscar.frmBuscar(dtMaquinas);
                objBuscar._setMultiSelect(true);
                objBuscar.ShowDialog();
                _procesoAddMAQ(objBuscar.proFilasSEL,tiraje);
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar agregar el proceso", "Procesos", ex.Message);
            }
        }

        private void _procesoAddMAQ(DataRow[] filasSEL,int tiraje)
        {
            if (dtProcesoDET != null && filasSEL!=null)
            {
                foreach (DataRow rowMAQ in filasSEL)
                {
                    int reg = dtProcesoDET.Select("CodigoMAQ='" + rowMAQ["Código"].ToString() + "'", "").Length;
                    if (reg <= 0)
                    {
                        DataRow newRow = dtProcesoDET.NewRow();
                        newRow["CodigoMAQ"] = rowMAQ["Código"];
                        newRow["Maquina"] = rowMAQ["Máquina"];
                        newRow["Costo"] = rowMAQ["Costo"];
                        newRow["Cantidad"] = tiraje;
                        dtProcesoDET.Rows.Add(newRow);
                    }
                }
            }
        }

        public void _procesoElimina(DataRow rowElimina)
        {
            try
            {
                if (rowElimina != null)
                {
                    dtProcesoDET.Rows.Remove(rowElimina);
                }
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar eliminar el registro", "Eliminar", ex.Message);
            }
        }

        #endregion


    }
}
