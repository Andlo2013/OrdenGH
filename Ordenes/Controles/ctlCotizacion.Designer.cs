namespace Ordenes.Controles
{
    partial class ctlCotizacion
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barraStandar = new dllStandardTool.StandardTool();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.lblEstadoCOT = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.xtcPestanas = new DevExpress.XtraTab.XtraTabControl();
            this.xtpDatosCLI = new DevExpress.XtraTab.XtraTabPage();
            this.cli_gcDestinos = new DevExpress.XtraGrid.GridControl();
            this.cmClienteSUC = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAgregarDestino = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuitarDestino = new System.Windows.Forms.ToolStripMenuItem();
            this.cli_gvDestino = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cli_gcColSecuencial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cli_gcColCodCiudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cli_gcColDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cli_gcColCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cli_gcContactos = new DevExpress.XtraGrid.GridControl();
            this.cli_gvContactos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcColContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcColNumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtpResumen = new DevExpress.XtraTab.XtraTabPage();
            this.tot_gcTotales = new DevExpress.XtraGrid.GridControl();
            this.tot_gvTotales = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tot_gcColDescripcionT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tot_gcColArmadosT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tot_gcColoresT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tot_gcPlacasT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tot_gcColTroquelT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tot_gcColAccesorioT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tot_gcColAcabadosT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tot_gcColProcesoIMPT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tot_gcColTotalLinealT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueLineaPRD = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtEplCotizador = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.beEplVendedor = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.lueSubgrupo = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.lueGrupo = new DevExpress.XtraEditors.LookUpEdit();
            this.xtpDiseno = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.dis_lueComponente = new DevExpress.XtraEditors.LookUpEdit();
            this.xtcDiseno = new DevExpress.XtraTab.XtraTabControl();
            this.dis_xtpGeneral = new DevExpress.XtraTab.XtraTabPage();
            this.dis_gpGraficasH = new DevExpress.XtraEditors.GroupControl();
            this.gen_gcGraficasH = new DevExpress.XtraGrid.GridControl();
            this.cmDisenoGeneralGH = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAgregaRegistroGH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEliminaRegistroGH = new System.Windows.Forms.ToolStripMenuItem();
            this.gen_gvGraficasH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dis_gcColDescripcionGH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gpOriginales = new DevExpress.XtraEditors.GroupControl();
            this.gen_gcOriginales = new DevExpress.XtraGrid.GridControl();
            this.cmDisenoGeneralORI = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAgregaRegistroORI = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEliminaRegistroORI = new System.Windows.Forms.ToolStripMenuItem();
            this.gen_gvOriginales = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gen_gcColDescripcionORI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_xtpArmados = new DevExpress.XtraTab.XtraTabPage();
            this.arm_gcArmados = new DevExpress.XtraGrid.GridControl();
            this.cmDisenoMatARMDIS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAgregaMATARMDIS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCalculaDISARM = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVerGraficaDISARM = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuitarMATARMDIS = new System.Windows.Forms.ToolStripMenuItem();
            this.arm_gvArmados = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.bandaPliegoMP = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.arm_gcColSeleccionAUT = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.arm_gcColGrupo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.arm_gcColMaterial = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandaPliegoIMP = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.arm_gcColPlaca = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.arm_gcColArmadoAncho = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.arm_gcColArmadoAlto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.arm_gcColImpXtamano = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandaPliego = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.arm_gcColPliegoMPAncho = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.arm_gcColPliegoMPAlto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.arm_gcColTamanosXpliego = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.arm_gcColPliegoCantidad = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.arm_gcColPliegoEXTPorcentaje = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_risePorcentajePliegoEXT = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.arm_gcColPliegoExtra = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.arm_gcColUndCotiza = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandaTrabajoFinal = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.arm_gcColAnchoTrabajoF = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_riseAnchoTFinal = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.arm_gcColAltoTrabajoF = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_ribeAltoTFinal = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.arm_gcColNumPaginas = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.arm_gcColPaginasXtrabajo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.arm_gcColTotalLinea = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_xtpColores = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.dis_seGramosPantone = new DevExpress.XtraEditors.SpinEdit();
            this.dis_seGramosMetalizado = new DevExpress.XtraEditors.SpinEdit();
            this.dis_seGramosColor = new DevExpress.XtraEditors.SpinEdit();
            this.col_gcColores = new DevExpress.XtraGrid.GridControl();
            this.cmDisenoColor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAgregaRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEliminaRegDisenoColor = new System.Windows.Forms.ToolStripMenuItem();
            this.col_gvColores = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_gcColMaterialC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_gcColArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_gcColLado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_rilueLadoImpresion = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.col_gcColTipoColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_rilueTipoColor = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.col_gcColCostoGramoColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_gcColCobertura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_rilueCobertura = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.col_gcColGramos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_gcColNumPaginasC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_gcColTotGramos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_gcColTotLinea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_gcColDetallePAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_xtpPlacas = new DevExpress.XtraTab.XtraTabPage();
            this.pla_gcPlacas = new DevExpress.XtraGrid.GridControl();
            this.pla_gvPlacas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pla_gcColMaterialP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pla_gcColPlacaP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pla_gcColLadoP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_rilueLadoImpresionP = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.pla_gcColNumColoresP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_riseNumColores = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.pla_gcColNumPaginasP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pla_gcColPaginasXplaca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pla_gcColPlacasMIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pla_gcColNumPlacasP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pla_gcColCostoPlaca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pla_gcTotalLineaP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_xtpTroquel = new DevExpress.XtraTab.XtraTabPage();
            this.tro_gcTrqouel = new DevExpress.XtraGrid.GridControl();
            this.cmDisenoTroquel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAgregaRegTroquel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEliminaRegTroquel = new System.Windows.Forms.ToolStripMenuItem();
            this.tro_gvTroquel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tro_gcColMaterialT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tro_gcColLongitud = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tro_gcColNumCortesT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tro_gcColCostoCorteT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tro_gcColTotaLineaT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_xtpAcabados = new DevExpress.XtraTab.XtraTabPage();
            this.aca_gcAcabados = new DevExpress.XtraGrid.GridControl();
            this.cmDisenoAcabado = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dis_mnuAgregaRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAgregaAcabado = new System.Windows.Forms.ToolStripMenuItem();
            this.dis_mnuEliminaRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.aca_gvAcabados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.aca_gcColMaterialA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.aca_gcColAreaA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.aca_gcColAcabadoA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.aca_gcColMatAcabado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.aca_gcColCostoA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.aca_gcColAplicaA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.aca_gcColTotalLineaA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_xtpAccesorios = new DevExpress.XtraTab.XtraTabPage();
            this.acce_gcAccesorios = new DevExpress.XtraGrid.GridControl();
            this.cmDisenoAccesorios = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAgregaAccesorio = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEliminaAccesorio = new System.Windows.Forms.ToolStripMenuItem();
            this.acce_gvAccesorios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.acce_gcColMaterialS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.acce_gcColTirajeS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.acce_gcColCantidadS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_riseCantAccesorio = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.acce_gcColCostoS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.acce_gcColTotalLineaS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_xtpProcesos = new DevExpress.XtraTab.XtraTabPage();
            this.proc_gcProcesos = new DevExpress.XtraGrid.GridControl();
            this.cmDisenoProcesos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAgregaProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuitarProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.proc_gvProcesos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.proc_gcColMaquina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.proc_gcColCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.proc_gcColMinutos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.proc_gcColTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_xtpProcesosIMP = new DevExpress.XtraTab.XtraTabPage();
            this.procimp_gcProcesoIMP = new DevExpress.XtraGrid.GridControl();
            this.procimp_bgvProcesoIMP = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.dis_bandaMaterial = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.procimp_gcColTallaI = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.procimp_gcColMaterialI = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.procimp_gcColNumColoresI = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.procimp_gcColPlacaI = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_bandaImpresion = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.procimp_gcColCostoXminuto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.procimp_gcColMinImpresion = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.procimp_gcColPliegosXminuto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.procimp_gcColNumPliegos = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_bandaPuestaPunto = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.procimp_gcColCostoXminutoPP = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.procimp_gcColMinutosPP = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_bandaTotal = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.procimp_gcColTotalLineaI = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_xtpMaterialCLI = new DevExpress.XtraTab.XtraTabPage();
            this.mcli_gcMaterialCLI = new DevExpress.XtraGrid.GridControl();
            this.cmClienteMAT = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAgregaMATCLI = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuitaMATCLI = new System.Windows.Forms.ToolStripMenuItem();
            this.mcli_gvMaterialCLI = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mcli_gcColMaterialCLI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mcli_gcColCantidadCLI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtpBlocks = new DevExpress.XtraTab.XtraTabPage();
            this.blo_seJuegos = new DevExpress.XtraEditors.SpinEdit();
            this.blo_seTermina = new DevExpress.XtraEditors.SpinEdit();
            this.blo_seInicia = new DevExpress.XtraEditors.SpinEdit();
            this.blo_gcCopias = new DevExpress.XtraGrid.GridControl();
            this.cmBlock = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuEliminaRegBlock = new System.Windows.Forms.ToolStripMenuItem();
            this.blo_gvCopias = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.blo_gcColSecuencial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.blo_gcColColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.blo_rilueColorCopia = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.blo_txtSerie = new DevExpress.XtraEditors.TextEdit();
            this.blo_lueTipoEmblocado = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.seTiraje = new DevExpress.XtraEditors.SpinEdit();
            this.seAlto = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.seAncho = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chkEstadoREG = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.deFechaCOT = new DevExpress.XtraEditors.DateEdit();
            this.txtCIRUCCLI = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.beNombreCLI = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.beNumeroCOT = new DevExpress.XtraEditors.ButtonEdit();
            this.deFechaENT = new DevExpress.XtraEditors.DateEdit();
            this.beArticulo = new DevExpress.XtraEditors.ButtonEdit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtcPestanas)).BeginInit();
            this.xtcPestanas.SuspendLayout();
            this.xtpDatosCLI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cli_gcDestinos)).BeginInit();
            this.cmClienteSUC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cli_gvDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cli_gcContactos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cli_gvContactos)).BeginInit();
            this.xtpResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tot_gcTotales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tot_gvTotales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLineaPRD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEplCotizador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beEplVendedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSubgrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGrupo.Properties)).BeginInit();
            this.xtpDiseno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_lueComponente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcDiseno)).BeginInit();
            this.xtcDiseno.SuspendLayout();
            this.dis_xtpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_gpGraficasH)).BeginInit();
            this.dis_gpGraficasH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gen_gcGraficasH)).BeginInit();
            this.cmDisenoGeneralGH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gen_gvGraficasH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_gpOriginales)).BeginInit();
            this.dis_gpOriginales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gen_gcOriginales)).BeginInit();
            this.cmDisenoGeneralORI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gen_gvOriginales)).BeginInit();
            this.dis_xtpArmados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arm_gcArmados)).BeginInit();
            this.cmDisenoMatARMDIS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arm_gvArmados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_risePorcentajePliegoEXT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_riseAnchoTFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_ribeAltoTFinal)).BeginInit();
            this.dis_xtpColores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_seGramosPantone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_seGramosMetalizado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_seGramosColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_gcColores)).BeginInit();
            this.cmDisenoColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.col_gvColores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_rilueLadoImpresion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_rilueTipoColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_rilueCobertura)).BeginInit();
            this.dis_xtpPlacas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pla_gcPlacas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pla_gvPlacas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_rilueLadoImpresionP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_riseNumColores)).BeginInit();
            this.dis_xtpTroquel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tro_gcTrqouel)).BeginInit();
            this.cmDisenoTroquel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tro_gvTroquel)).BeginInit();
            this.dis_xtpAcabados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aca_gcAcabados)).BeginInit();
            this.cmDisenoAcabado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aca_gvAcabados)).BeginInit();
            this.dis_xtpAccesorios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acce_gcAccesorios)).BeginInit();
            this.cmDisenoAccesorios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acce_gvAccesorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_riseCantAccesorio)).BeginInit();
            this.dis_xtpProcesos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proc_gcProcesos)).BeginInit();
            this.cmDisenoProcesos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proc_gvProcesos)).BeginInit();
            this.dis_xtpProcesosIMP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.procimp_gcProcesoIMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procimp_bgvProcesoIMP)).BeginInit();
            this.dis_xtpMaterialCLI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mcli_gcMaterialCLI)).BeginInit();
            this.cmClienteMAT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mcli_gvMaterialCLI)).BeginInit();
            this.xtpBlocks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blo_seJuegos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_seTermina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_seInicia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_gcCopias)).BeginInit();
            this.cmBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blo_gvCopias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_rilueColorCopia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_txtSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_lueTipoEmblocado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTiraje.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAlto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAncho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstadoREG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaCOT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaCOT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCIRUCCLI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beNombreCLI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beNumeroCOT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaENT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaENT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beArticulo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barraStandar
            // 
            this.barraStandar.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraStandar.Location = new System.Drawing.Point(0, 0);
            this.barraStandar.Name = "barraStandar";
            this.barraStandar.Size = new System.Drawing.Size(926, 24);
            this.barraStandar.TabIndex = 2;
            this.barraStandar.onNew += new dllStandardTool.StandardTool.delegateNew(this.barraStandar_onNew);
            this.barraStandar.onSave += new dllStandardTool.StandardTool.delegateSave(this.barraStandar_onSave);
            this.barraStandar.onEdit += new dllStandardTool.StandardTool.delegateEdit(this.barraStandar_onEdit);
            this.barraStandar.onDelete += new dllStandardTool.StandardTool.delegateDelete(this.barraStandar_onDelete);
            this.barraStandar.onUndo += new dllStandardTool.StandardTool.delegateUndo(this.barraStandar_onUndo);
            this.barraStandar.onFirst += new dllStandardTool.StandardTool.delegateFirst(this.barraStandar_onFirst);
            this.barraStandar.onPrevious += new dllStandardTool.StandardTool.delegatePrevious(this.barraStandar_onPrevious);
            this.barraStandar.onNext += new dllStandardTool.StandardTool.delegateNext(this.barraStandar_onNext);
            this.barraStandar.onLast += new dllStandardTool.StandardTool.delegateLast(this.barraStandar_onLast);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelControl14);
            this.panel1.Controls.Add(this.lblEstadoCOT);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.seTiraje);
            this.panel1.Controls.Add(this.seAlto);
            this.panel1.Controls.Add(this.labelControl7);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.seAncho);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.chkEstadoREG);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.deFechaCOT);
            this.panel1.Controls.Add(this.txtCIRUCCLI);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.beNombreCLI);
            this.panel1.Controls.Add(this.labelControl8);
            this.panel1.Controls.Add(this.beNumeroCOT);
            this.panel1.Controls.Add(this.deFechaENT);
            this.panel1.Controls.Add(this.beArticulo);
            this.panel1.Location = new System.Drawing.Point(3, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 463);
            this.panel1.TabIndex = 3;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(315, 75);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(31, 13);
            this.labelControl14.TabIndex = 79;
            this.labelControl14.Text = "Tiraje:";
            // 
            // lblEstadoCOT
            // 
            this.lblEstadoCOT.Appearance.Options.UseTextOptions = true;
            this.lblEstadoCOT.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblEstadoCOT.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblEstadoCOT.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblEstadoCOT.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblEstadoCOT.Location = new System.Drawing.Point(677, 5);
            this.lblEstadoCOT.Name = "lblEstadoCOT";
            this.lblEstadoCOT.Size = new System.Drawing.Size(142, 20);
            this.lblEstadoCOT.TabIndex = 72;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.xtcPestanas);
            this.groupBox1.Location = new System.Drawing.Point(3, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(877, 395);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trabajo";
            // 
            // xtcPestanas
            // 
            this.xtcPestanas.Location = new System.Drawing.Point(6, 19);
            this.xtcPestanas.Name = "xtcPestanas";
            this.xtcPestanas.SelectedTabPage = this.xtpDatosCLI;
            this.xtcPestanas.Size = new System.Drawing.Size(865, 341);
            this.xtcPestanas.TabIndex = 21;
            this.xtcPestanas.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpDatosCLI,
            this.xtpResumen,
            this.xtpDiseno,
            this.xtpBlocks});
            this.xtcPestanas.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtcPestanas_SelectedPageChanged);
            // 
            // xtpDatosCLI
            // 
            this.xtpDatosCLI.Controls.Add(this.cli_gcDestinos);
            this.xtpDatosCLI.Controls.Add(this.cli_gcContactos);
            this.xtpDatosCLI.Name = "xtpDatosCLI";
            this.xtpDatosCLI.Size = new System.Drawing.Size(859, 313);
            this.xtpDatosCLI.Text = "Cliente";
            // 
            // cli_gcDestinos
            // 
            this.cli_gcDestinos.ContextMenuStrip = this.cmClienteSUC;
            this.cli_gcDestinos.Location = new System.Drawing.Point(11, 12);
            this.cli_gcDestinos.MainView = this.cli_gvDestino;
            this.cli_gcDestinos.Name = "cli_gcDestinos";
            this.cli_gcDestinos.Size = new System.Drawing.Size(772, 98);
            this.cli_gcDestinos.TabIndex = 18;
            this.cli_gcDestinos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cli_gvDestino});
            // 
            // cmClienteSUC
            // 
            this.cmClienteSUC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAgregarDestino,
            this.mnuQuitarDestino});
            this.cmClienteSUC.Name = "cmSucursalCLI";
            this.cmClienteSUC.Size = new System.Drawing.Size(217, 48);
            // 
            // mnuAgregarDestino
            // 
            this.mnuAgregarDestino.Name = "mnuAgregarDestino";
            this.mnuAgregarDestino.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuAgregarDestino.Size = new System.Drawing.Size(216, 22);
            this.mnuAgregarDestino.Text = "Agregar Destino";
            this.mnuAgregarDestino.Click += new System.EventHandler(this.mnuAgregarDestino_Click);
            // 
            // mnuQuitarDestino
            // 
            this.mnuQuitarDestino.Name = "mnuQuitarDestino";
            this.mnuQuitarDestino.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.mnuQuitarDestino.Size = new System.Drawing.Size(216, 22);
            this.mnuQuitarDestino.Text = "Eliminar Destino";
            this.mnuQuitarDestino.Click += new System.EventHandler(this.mnuQuitarDestino_Click);
            // 
            // cli_gvDestino
            // 
            this.cli_gvDestino.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cli_gcColSecuencial,
            this.cli_gcColCodCiudad,
            this.cli_gcColDireccion,
            this.cli_gcColCantidad});
            this.cli_gvDestino.GridControl = this.cli_gcDestinos;
            this.cli_gvDestino.Name = "cli_gvDestino";
            this.cli_gvDestino.OptionsView.ShowGroupPanel = false;
            // 
            // cli_gcColSecuencial
            // 
            this.cli_gcColSecuencial.Caption = "Nro";
            this.cli_gcColSecuencial.FieldName = "Secuencial";
            this.cli_gcColSecuencial.Name = "cli_gcColSecuencial";
            this.cli_gcColSecuencial.OptionsColumn.AllowEdit = false;
            this.cli_gcColSecuencial.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.cli_gcColSecuencial.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.cli_gcColSecuencial.OptionsColumn.AllowMove = false;
            this.cli_gcColSecuencial.OptionsColumn.AllowShowHide = false;
            this.cli_gcColSecuencial.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.cli_gcColSecuencial.OptionsFilter.AllowAutoFilter = false;
            this.cli_gcColSecuencial.OptionsFilter.AllowFilter = false;
            this.cli_gcColSecuencial.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.cli_gcColSecuencial.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.cli_gcColSecuencial.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.cli_gcColSecuencial.Visible = true;
            this.cli_gcColSecuencial.VisibleIndex = 0;
            this.cli_gcColSecuencial.Width = 68;
            // 
            // cli_gcColCodCiudad
            // 
            this.cli_gcColCodCiudad.Caption = "Ciudad";
            this.cli_gcColCodCiudad.FieldName = "Ciudad";
            this.cli_gcColCodCiudad.Name = "cli_gcColCodCiudad";
            this.cli_gcColCodCiudad.OptionsColumn.AllowEdit = false;
            this.cli_gcColCodCiudad.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.cli_gcColCodCiudad.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.cli_gcColCodCiudad.OptionsColumn.AllowMove = false;
            this.cli_gcColCodCiudad.OptionsColumn.AllowShowHide = false;
            this.cli_gcColCodCiudad.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.cli_gcColCodCiudad.OptionsFilter.AllowAutoFilter = false;
            this.cli_gcColCodCiudad.OptionsFilter.AllowFilter = false;
            this.cli_gcColCodCiudad.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.cli_gcColCodCiudad.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.cli_gcColCodCiudad.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.cli_gcColCodCiudad.Visible = true;
            this.cli_gcColCodCiudad.VisibleIndex = 1;
            this.cli_gcColCodCiudad.Width = 335;
            // 
            // cli_gcColDireccion
            // 
            this.cli_gcColDireccion.Caption = "Dirección";
            this.cli_gcColDireccion.FieldName = "Direccion";
            this.cli_gcColDireccion.Name = "cli_gcColDireccion";
            this.cli_gcColDireccion.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.cli_gcColDireccion.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.cli_gcColDireccion.OptionsColumn.AllowMove = false;
            this.cli_gcColDireccion.OptionsColumn.AllowShowHide = false;
            this.cli_gcColDireccion.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.cli_gcColDireccion.OptionsFilter.AllowAutoFilter = false;
            this.cli_gcColDireccion.OptionsFilter.AllowFilter = false;
            this.cli_gcColDireccion.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.cli_gcColDireccion.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.cli_gcColDireccion.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.cli_gcColDireccion.Visible = true;
            this.cli_gcColDireccion.VisibleIndex = 2;
            this.cli_gcColDireccion.Width = 753;
            // 
            // cli_gcColCantidad
            // 
            this.cli_gcColCantidad.Caption = "Cantidad";
            this.cli_gcColCantidad.DisplayFormat.FormatString = "N0";
            this.cli_gcColCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cli_gcColCantidad.FieldName = "Cantidad";
            this.cli_gcColCantidad.Name = "cli_gcColCantidad";
            this.cli_gcColCantidad.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.cli_gcColCantidad.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.cli_gcColCantidad.OptionsColumn.AllowMove = false;
            this.cli_gcColCantidad.OptionsColumn.AllowShowHide = false;
            this.cli_gcColCantidad.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.cli_gcColCantidad.OptionsFilter.AllowAutoFilter = false;
            this.cli_gcColCantidad.OptionsFilter.AllowFilter = false;
            this.cli_gcColCantidad.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.cli_gcColCantidad.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.cli_gcColCantidad.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.cli_gcColCantidad.Visible = true;
            this.cli_gcColCantidad.VisibleIndex = 3;
            this.cli_gcColCantidad.Width = 156;
            // 
            // cli_gcContactos
            // 
            this.cli_gcContactos.Location = new System.Drawing.Point(11, 116);
            this.cli_gcContactos.MainView = this.cli_gvContactos;
            this.cli_gcContactos.Name = "cli_gcContactos";
            this.cli_gcContactos.Size = new System.Drawing.Size(772, 85);
            this.cli_gcContactos.TabIndex = 17;
            this.cli_gcContactos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cli_gvContactos});
            // 
            // cli_gvContactos
            // 
            this.cli_gvContactos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcColContacto,
            this.gcColNumero});
            this.cli_gvContactos.GridControl = this.cli_gcContactos;
            this.cli_gvContactos.Name = "cli_gvContactos";
            this.cli_gvContactos.OptionsView.ShowGroupPanel = false;
            // 
            // gcColContacto
            // 
            this.gcColContacto.Caption = "Contacto";
            this.gcColContacto.FieldName = "Contacto";
            this.gcColContacto.Name = "gcColContacto";
            this.gcColContacto.OptionsColumn.AllowEdit = false;
            this.gcColContacto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gcColContacto.OptionsColumn.AllowIncrementalSearch = false;
            this.gcColContacto.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gcColContacto.OptionsColumn.AllowMove = false;
            this.gcColContacto.OptionsColumn.ReadOnly = true;
            this.gcColContacto.Visible = true;
            this.gcColContacto.VisibleIndex = 0;
            this.gcColContacto.Width = 886;
            // 
            // gcColNumero
            // 
            this.gcColNumero.Caption = "Número";
            this.gcColNumero.FieldName = "Numero";
            this.gcColNumero.Name = "gcColNumero";
            this.gcColNumero.OptionsColumn.AllowEdit = false;
            this.gcColNumero.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gcColNumero.OptionsColumn.AllowIncrementalSearch = false;
            this.gcColNumero.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gcColNumero.OptionsColumn.AllowMove = false;
            this.gcColNumero.OptionsColumn.ReadOnly = true;
            this.gcColNumero.Visible = true;
            this.gcColNumero.VisibleIndex = 1;
            this.gcColNumero.Width = 426;
            // 
            // xtpResumen
            // 
            this.xtpResumen.Controls.Add(this.tot_gcTotales);
            this.xtpResumen.Controls.Add(this.lueLineaPRD);
            this.xtpResumen.Controls.Add(this.labelControl13);
            this.xtpResumen.Controls.Add(this.txtEplCotizador);
            this.xtpResumen.Controls.Add(this.labelControl12);
            this.xtpResumen.Controls.Add(this.beEplVendedor);
            this.xtpResumen.Controls.Add(this.labelControl9);
            this.xtpResumen.Controls.Add(this.labelControl10);
            this.xtpResumen.Controls.Add(this.lueSubgrupo);
            this.xtpResumen.Controls.Add(this.labelControl11);
            this.xtpResumen.Controls.Add(this.lueGrupo);
            this.xtpResumen.Name = "xtpResumen";
            this.xtpResumen.Size = new System.Drawing.Size(859, 313);
            this.xtpResumen.Text = "Resúmen";
            // 
            // tot_gcTotales
            // 
            this.tot_gcTotales.Location = new System.Drawing.Point(3, 84);
            this.tot_gcTotales.MainView = this.tot_gvTotales;
            this.tot_gcTotales.Name = "tot_gcTotales";
            this.tot_gcTotales.Size = new System.Drawing.Size(853, 226);
            this.tot_gcTotales.TabIndex = 78;
            this.tot_gcTotales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tot_gvTotales});
            // 
            // tot_gvTotales
            // 
            this.tot_gvTotales.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.tot_gcColDescripcionT,
            this.tot_gcColArmadosT,
            this.tot_gcColoresT,
            this.tot_gcPlacasT,
            this.tot_gcColTroquelT,
            this.tot_gcColAccesorioT,
            this.tot_gcColAcabadosT,
            this.tot_gcColProcesoIMPT,
            this.tot_gcColTotalLinealT});
            this.tot_gvTotales.GridControl = this.tot_gcTotales;
            this.tot_gvTotales.Name = "tot_gvTotales";
            this.tot_gvTotales.OptionsView.ShowFooter = true;
            this.tot_gvTotales.OptionsView.ShowGroupPanel = false;
            // 
            // tot_gcColDescripcionT
            // 
            this.tot_gcColDescripcionT.Caption = "Descripción";
            this.tot_gcColDescripcionT.FieldName = "Componente";
            this.tot_gcColDescripcionT.Name = "tot_gcColDescripcionT";
            this.tot_gcColDescripcionT.OptionsColumn.AllowEdit = false;
            this.tot_gcColDescripcionT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.tot_gcColDescripcionT.OptionsColumn.AllowIncrementalSearch = false;
            this.tot_gcColDescripcionT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.tot_gcColDescripcionT.OptionsColumn.AllowMove = false;
            this.tot_gcColDescripcionT.OptionsColumn.AllowShowHide = false;
            this.tot_gcColDescripcionT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.tot_gcColDescripcionT.OptionsColumn.ReadOnly = true;
            this.tot_gcColDescripcionT.OptionsFilter.AllowAutoFilter = false;
            this.tot_gcColDescripcionT.Visible = true;
            this.tot_gcColDescripcionT.VisibleIndex = 0;
            this.tot_gcColDescripcionT.Width = 210;
            // 
            // tot_gcColArmadosT
            // 
            this.tot_gcColArmadosT.Caption = "Armados";
            this.tot_gcColArmadosT.DisplayFormat.FormatString = "N2";
            this.tot_gcColArmadosT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tot_gcColArmadosT.FieldName = "Armados";
            this.tot_gcColArmadosT.Name = "tot_gcColArmadosT";
            this.tot_gcColArmadosT.OptionsColumn.AllowEdit = false;
            this.tot_gcColArmadosT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.tot_gcColArmadosT.OptionsColumn.AllowIncrementalSearch = false;
            this.tot_gcColArmadosT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.tot_gcColArmadosT.OptionsColumn.AllowMove = false;
            this.tot_gcColArmadosT.OptionsColumn.AllowShowHide = false;
            this.tot_gcColArmadosT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.tot_gcColArmadosT.OptionsColumn.ReadOnly = true;
            this.tot_gcColArmadosT.OptionsFilter.AllowAutoFilter = false;
            this.tot_gcColArmadosT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Armados", "{0:N2}")});
            this.tot_gcColArmadosT.Visible = true;
            this.tot_gcColArmadosT.VisibleIndex = 1;
            this.tot_gcColArmadosT.Width = 82;
            // 
            // tot_gcColoresT
            // 
            this.tot_gcColoresT.Caption = "Colores";
            this.tot_gcColoresT.DisplayFormat.FormatString = "N2";
            this.tot_gcColoresT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tot_gcColoresT.FieldName = "Colores";
            this.tot_gcColoresT.Name = "tot_gcColoresT";
            this.tot_gcColoresT.OptionsColumn.AllowEdit = false;
            this.tot_gcColoresT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.tot_gcColoresT.OptionsColumn.AllowIncrementalSearch = false;
            this.tot_gcColoresT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.tot_gcColoresT.OptionsColumn.AllowMove = false;
            this.tot_gcColoresT.OptionsColumn.AllowShowHide = false;
            this.tot_gcColoresT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.tot_gcColoresT.OptionsColumn.ReadOnly = true;
            this.tot_gcColoresT.OptionsFilter.AllowAutoFilter = false;
            this.tot_gcColoresT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Colores", "{0:N2}")});
            this.tot_gcColoresT.Visible = true;
            this.tot_gcColoresT.VisibleIndex = 2;
            this.tot_gcColoresT.Width = 76;
            // 
            // tot_gcPlacasT
            // 
            this.tot_gcPlacasT.Caption = "Placas";
            this.tot_gcPlacasT.DisplayFormat.FormatString = "N2";
            this.tot_gcPlacasT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tot_gcPlacasT.FieldName = "Placas";
            this.tot_gcPlacasT.Name = "tot_gcPlacasT";
            this.tot_gcPlacasT.OptionsColumn.AllowEdit = false;
            this.tot_gcPlacasT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.tot_gcPlacasT.OptionsColumn.AllowIncrementalSearch = false;
            this.tot_gcPlacasT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.tot_gcPlacasT.OptionsColumn.AllowMove = false;
            this.tot_gcPlacasT.OptionsColumn.AllowShowHide = false;
            this.tot_gcPlacasT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.tot_gcPlacasT.OptionsColumn.ReadOnly = true;
            this.tot_gcPlacasT.OptionsFilter.AllowAutoFilter = false;
            this.tot_gcPlacasT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Placas", "{0:N2}")});
            this.tot_gcPlacasT.Visible = true;
            this.tot_gcPlacasT.VisibleIndex = 3;
            this.tot_gcPlacasT.Width = 80;
            // 
            // tot_gcColTroquelT
            // 
            this.tot_gcColTroquelT.Caption = "Troquel";
            this.tot_gcColTroquelT.DisplayFormat.FormatString = "N2";
            this.tot_gcColTroquelT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tot_gcColTroquelT.FieldName = "Troquel";
            this.tot_gcColTroquelT.Name = "tot_gcColTroquelT";
            this.tot_gcColTroquelT.OptionsColumn.AllowEdit = false;
            this.tot_gcColTroquelT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.tot_gcColTroquelT.OptionsColumn.AllowIncrementalSearch = false;
            this.tot_gcColTroquelT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.tot_gcColTroquelT.OptionsColumn.AllowMove = false;
            this.tot_gcColTroquelT.OptionsColumn.AllowShowHide = false;
            this.tot_gcColTroquelT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.tot_gcColTroquelT.OptionsColumn.ReadOnly = true;
            this.tot_gcColTroquelT.OptionsFilter.AllowAutoFilter = false;
            this.tot_gcColTroquelT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Troquel", "{0:N2}")});
            this.tot_gcColTroquelT.Visible = true;
            this.tot_gcColTroquelT.VisibleIndex = 4;
            this.tot_gcColTroquelT.Width = 81;
            // 
            // tot_gcColAccesorioT
            // 
            this.tot_gcColAccesorioT.Caption = "Accesorios";
            this.tot_gcColAccesorioT.DisplayFormat.FormatString = "N2";
            this.tot_gcColAccesorioT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tot_gcColAccesorioT.FieldName = "Accesorios";
            this.tot_gcColAccesorioT.Name = "tot_gcColAccesorioT";
            this.tot_gcColAccesorioT.OptionsColumn.AllowEdit = false;
            this.tot_gcColAccesorioT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.tot_gcColAccesorioT.OptionsColumn.AllowIncrementalSearch = false;
            this.tot_gcColAccesorioT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.tot_gcColAccesorioT.OptionsColumn.AllowMove = false;
            this.tot_gcColAccesorioT.OptionsColumn.AllowShowHide = false;
            this.tot_gcColAccesorioT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.tot_gcColAccesorioT.OptionsColumn.ReadOnly = true;
            this.tot_gcColAccesorioT.OptionsFilter.AllowAutoFilter = false;
            this.tot_gcColAccesorioT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Accesorios", "{0:N2}")});
            this.tot_gcColAccesorioT.Visible = true;
            this.tot_gcColAccesorioT.VisibleIndex = 5;
            this.tot_gcColAccesorioT.Width = 79;
            // 
            // tot_gcColAcabadosT
            // 
            this.tot_gcColAcabadosT.Caption = "Acabados";
            this.tot_gcColAcabadosT.DisplayFormat.FormatString = "N2";
            this.tot_gcColAcabadosT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tot_gcColAcabadosT.FieldName = "Acabados";
            this.tot_gcColAcabadosT.Name = "tot_gcColAcabadosT";
            this.tot_gcColAcabadosT.OptionsColumn.AllowEdit = false;
            this.tot_gcColAcabadosT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.tot_gcColAcabadosT.OptionsColumn.AllowIncrementalSearch = false;
            this.tot_gcColAcabadosT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.tot_gcColAcabadosT.OptionsColumn.AllowMove = false;
            this.tot_gcColAcabadosT.OptionsColumn.AllowShowHide = false;
            this.tot_gcColAcabadosT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.tot_gcColAcabadosT.OptionsColumn.ReadOnly = true;
            this.tot_gcColAcabadosT.OptionsFilter.AllowAutoFilter = false;
            this.tot_gcColAcabadosT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Acabados", "{0:N2}")});
            this.tot_gcColAcabadosT.Visible = true;
            this.tot_gcColAcabadosT.VisibleIndex = 6;
            // 
            // tot_gcColProcesoIMPT
            // 
            this.tot_gcColProcesoIMPT.Caption = "Proceso IMP";
            this.tot_gcColProcesoIMPT.DisplayFormat.FormatString = "N2";
            this.tot_gcColProcesoIMPT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tot_gcColProcesoIMPT.FieldName = "ProcesosIMP";
            this.tot_gcColProcesoIMPT.Name = "tot_gcColProcesoIMPT";
            this.tot_gcColProcesoIMPT.OptionsColumn.AllowEdit = false;
            this.tot_gcColProcesoIMPT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.tot_gcColProcesoIMPT.OptionsColumn.AllowIncrementalSearch = false;
            this.tot_gcColProcesoIMPT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.tot_gcColProcesoIMPT.OptionsColumn.AllowMove = false;
            this.tot_gcColProcesoIMPT.OptionsColumn.AllowShowHide = false;
            this.tot_gcColProcesoIMPT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.tot_gcColProcesoIMPT.OptionsColumn.ReadOnly = true;
            this.tot_gcColProcesoIMPT.OptionsFilter.AllowAutoFilter = false;
            this.tot_gcColProcesoIMPT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ProcesosIMP", "{0:N2}")});
            this.tot_gcColProcesoIMPT.Visible = true;
            this.tot_gcColProcesoIMPT.VisibleIndex = 7;
            this.tot_gcColProcesoIMPT.Width = 100;
            // 
            // tot_gcColTotalLinealT
            // 
            this.tot_gcColTotalLinealT.Caption = "Total";
            this.tot_gcColTotalLinealT.DisplayFormat.FormatString = "N2";
            this.tot_gcColTotalLinealT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tot_gcColTotalLinealT.FieldName = "TotalLinea";
            this.tot_gcColTotalLinealT.Name = "tot_gcColTotalLinealT";
            this.tot_gcColTotalLinealT.OptionsColumn.AllowEdit = false;
            this.tot_gcColTotalLinealT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.tot_gcColTotalLinealT.OptionsColumn.AllowIncrementalSearch = false;
            this.tot_gcColTotalLinealT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.tot_gcColTotalLinealT.OptionsColumn.AllowMove = false;
            this.tot_gcColTotalLinealT.OptionsColumn.AllowShowHide = false;
            this.tot_gcColTotalLinealT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.tot_gcColTotalLinealT.OptionsColumn.ReadOnly = true;
            this.tot_gcColTotalLinealT.OptionsFilter.AllowAutoFilter = false;
            this.tot_gcColTotalLinealT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalLinea", "{0:N2}")});
            this.tot_gcColTotalLinealT.Visible = true;
            this.tot_gcColTotalLinealT.VisibleIndex = 8;
            this.tot_gcColTotalLinealT.Width = 127;
            // 
            // lueLineaPRD
            // 
            this.lueLineaPRD.Location = new System.Drawing.Point(101, 9);
            this.lueLineaPRD.Name = "lueLineaPRD";
            this.lueLineaPRD.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lueLineaPRD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueLineaPRD.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Línea Producción")});
            this.lueLineaPRD.Properties.DisplayMember = "Descripcion";
            this.lueLineaPRD.Properties.NullText = "";
            this.lueLineaPRD.Properties.ValueMember = "Codigo";
            this.lueLineaPRD.Size = new System.Drawing.Size(257, 20);
            this.lueLineaPRD.TabIndex = 18;
            this.lueLineaPRD.EditValueChanged += new System.EventHandler(this.lueLineaPRD_EditValueChanged);
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(542, 35);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(50, 13);
            this.labelControl13.TabIndex = 76;
            this.labelControl13.Text = "Cotizador:";
            // 
            // txtEplCotizador
            // 
            this.txtEplCotizador.Location = new System.Drawing.Point(598, 32);
            this.txtEplCotizador.Name = "txtEplCotizador";
            this.txtEplCotizador.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtEplCotizador.Properties.MaxLength = 50;
            this.txtEplCotizador.Properties.ReadOnly = true;
            this.txtEplCotizador.Size = new System.Drawing.Size(257, 20);
            this.txtEplCotizador.TabIndex = 75;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(542, 56);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(50, 13);
            this.labelControl12.TabIndex = 74;
            this.labelControl12.Text = "Vendedor:";
            // 
            // beEplVendedor
            // 
            this.beEplVendedor.Location = new System.Drawing.Point(598, 53);
            this.beEplVendedor.Name = "beEplVendedor";
            this.beEplVendedor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.beEplVendedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beEplVendedor.Properties.MaxLength = 50;
            this.beEplVendedor.Properties.ReadOnly = true;
            this.beEplVendedor.Size = new System.Drawing.Size(257, 20);
            this.beEplVendedor.TabIndex = 73;
            this.beEplVendedor.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beEplVendedor_ButtonClick);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(12, 12);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(84, 13);
            this.labelControl9.TabIndex = 67;
            this.labelControl9.Text = "Línea Producción:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(12, 34);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(33, 13);
            this.labelControl10.TabIndex = 68;
            this.labelControl10.Text = "Grupo:";
            // 
            // lueSubgrupo
            // 
            this.lueSubgrupo.Location = new System.Drawing.Point(101, 53);
            this.lueSubgrupo.Name = "lueSubgrupo";
            this.lueSubgrupo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lueSubgrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSubgrupo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Subgrupo")});
            this.lueSubgrupo.Properties.DisplayMember = "Descripcion";
            this.lueSubgrupo.Properties.NullText = "";
            this.lueSubgrupo.Properties.ValueMember = "Codigo";
            this.lueSubgrupo.Size = new System.Drawing.Size(257, 20);
            this.lueSubgrupo.TabIndex = 20;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(12, 56);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(50, 13);
            this.labelControl11.TabIndex = 69;
            this.labelControl11.Text = "Subgrupo:";
            // 
            // lueGrupo
            // 
            this.lueGrupo.Location = new System.Drawing.Point(101, 31);
            this.lueGrupo.Name = "lueGrupo";
            this.lueGrupo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lueGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueGrupo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Grupo")});
            this.lueGrupo.Properties.DisplayMember = "Descripcion";
            this.lueGrupo.Properties.NullText = "";
            this.lueGrupo.Properties.ValueMember = "Codigo";
            this.lueGrupo.Size = new System.Drawing.Size(257, 20);
            this.lueGrupo.TabIndex = 19;
            this.lueGrupo.EditValueChanged += new System.EventHandler(this.lueGrupo_EditValueChanged);
            // 
            // xtpDiseno
            // 
            this.xtpDiseno.Controls.Add(this.labelControl15);
            this.xtpDiseno.Controls.Add(this.dis_lueComponente);
            this.xtpDiseno.Controls.Add(this.xtcDiseno);
            this.xtpDiseno.Name = "xtpDiseno";
            this.xtpDiseno.Size = new System.Drawing.Size(859, 313);
            this.xtpDiseno.Text = "Diseño";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(11, 13);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(65, 13);
            this.labelControl15.TabIndex = 33;
            this.labelControl15.Text = "Componente:";
            // 
            // dis_lueComponente
            // 
            this.dis_lueComponente.Location = new System.Drawing.Point(96, 10);
            this.dis_lueComponente.Name = "dis_lueComponente";
            this.dis_lueComponente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dis_lueComponente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dis_lueComponente.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Componente")});
            this.dis_lueComponente.Properties.DisplayMember = "Descripcion";
            this.dis_lueComponente.Properties.NullText = "";
            this.dis_lueComponente.Properties.ValueMember = "Codigo";
            this.dis_lueComponente.Size = new System.Drawing.Size(201, 20);
            this.dis_lueComponente.TabIndex = 32;
            this.dis_lueComponente.EditValueChanged += new System.EventHandler(this.dis_lueComponente_EditValueChanged);
            // 
            // xtcDiseno
            // 
            this.xtcDiseno.Location = new System.Drawing.Point(3, 40);
            this.xtcDiseno.Name = "xtcDiseno";
            this.xtcDiseno.SelectedTabPage = this.dis_xtpGeneral;
            this.xtcDiseno.Size = new System.Drawing.Size(850, 270);
            this.xtcDiseno.TabIndex = 31;
            this.xtcDiseno.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.dis_xtpGeneral,
            this.dis_xtpArmados,
            this.dis_xtpColores,
            this.dis_xtpPlacas,
            this.dis_xtpTroquel,
            this.dis_xtpAcabados,
            this.dis_xtpAccesorios,
            this.dis_xtpProcesos,
            this.dis_xtpProcesosIMP,
            this.dis_xtpMaterialCLI});
            // 
            // dis_xtpGeneral
            // 
            this.dis_xtpGeneral.Controls.Add(this.dis_gpGraficasH);
            this.dis_xtpGeneral.Controls.Add(this.dis_gpOriginales);
            this.dis_xtpGeneral.Name = "dis_xtpGeneral";
            this.dis_xtpGeneral.Size = new System.Drawing.Size(844, 242);
            this.dis_xtpGeneral.Text = "General";
            // 
            // dis_gpGraficasH
            // 
            this.dis_gpGraficasH.Controls.Add(this.gen_gcGraficasH);
            this.dis_gpGraficasH.Location = new System.Drawing.Point(431, 5);
            this.dis_gpGraficasH.Name = "dis_gpGraficasH";
            this.dis_gpGraficasH.Size = new System.Drawing.Size(404, 232);
            this.dis_gpGraficasH.TabIndex = 35;
            this.dis_gpGraficasH.Text = "Gráficas Hernández";
            // 
            // gen_gcGraficasH
            // 
            this.gen_gcGraficasH.ContextMenuStrip = this.cmDisenoGeneralGH;
            this.gen_gcGraficasH.Location = new System.Drawing.Point(7, 23);
            this.gen_gcGraficasH.MainView = this.gen_gvGraficasH;
            this.gen_gcGraficasH.Name = "gen_gcGraficasH";
            this.gen_gcGraficasH.Size = new System.Drawing.Size(392, 204);
            this.gen_gcGraficasH.TabIndex = 32;
            this.gen_gcGraficasH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gen_gvGraficasH});
            // 
            // cmDisenoGeneralGH
            // 
            this.cmDisenoGeneralGH.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAgregaRegistroGH,
            this.mnuEliminaRegistroGH});
            this.cmDisenoGeneralGH.Name = "cmDisenoGeneralGH";
            this.cmDisenoGeneralGH.Size = new System.Drawing.Size(220, 48);
            // 
            // mnuAgregaRegistroGH
            // 
            this.mnuAgregaRegistroGH.Name = "mnuAgregaRegistroGH";
            this.mnuAgregaRegistroGH.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuAgregaRegistroGH.Size = new System.Drawing.Size(219, 22);
            this.mnuAgregaRegistroGH.Text = "Agregar Registro";
            this.mnuAgregaRegistroGH.Click += new System.EventHandler(this.mnuAgregaRegistroGH_Click);
            // 
            // mnuEliminaRegistroGH
            // 
            this.mnuEliminaRegistroGH.Name = "mnuEliminaRegistroGH";
            this.mnuEliminaRegistroGH.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.mnuEliminaRegistroGH.Size = new System.Drawing.Size(219, 22);
            this.mnuEliminaRegistroGH.Text = "Eliminar Registro";
            this.mnuEliminaRegistroGH.Click += new System.EventHandler(this.mnuEliminaRegistroGH_Click);
            // 
            // gen_gvGraficasH
            // 
            this.gen_gvGraficasH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.dis_gcColDescripcionGH});
            this.gen_gvGraficasH.GridControl = this.gen_gcGraficasH;
            this.gen_gvGraficasH.Name = "gen_gvGraficasH";
            this.gen_gvGraficasH.OptionsView.ShowGroupPanel = false;
            // 
            // dis_gcColDescripcionGH
            // 
            this.dis_gcColDescripcionGH.Caption = "Descripción";
            this.dis_gcColDescripcionGH.FieldName = "Descripcion";
            this.dis_gcColDescripcionGH.Name = "dis_gcColDescripcionGH";
            this.dis_gcColDescripcionGH.OptionsColumn.AllowEdit = false;
            this.dis_gcColDescripcionGH.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColDescripcionGH.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColDescripcionGH.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColDescripcionGH.OptionsColumn.AllowMove = false;
            this.dis_gcColDescripcionGH.OptionsColumn.AllowShowHide = false;
            this.dis_gcColDescripcionGH.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColDescripcionGH.OptionsColumn.ReadOnly = true;
            this.dis_gcColDescripcionGH.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColDescripcionGH.OptionsFilter.AllowFilter = false;
            this.dis_gcColDescripcionGH.Visible = true;
            this.dis_gcColDescripcionGH.VisibleIndex = 0;
            // 
            // dis_gpOriginales
            // 
            this.dis_gpOriginales.Controls.Add(this.gen_gcOriginales);
            this.dis_gpOriginales.Location = new System.Drawing.Point(11, 5);
            this.dis_gpOriginales.Name = "dis_gpOriginales";
            this.dis_gpOriginales.Size = new System.Drawing.Size(404, 232);
            this.dis_gpOriginales.TabIndex = 34;
            this.dis_gpOriginales.Text = "Originales";
            // 
            // gen_gcOriginales
            // 
            this.gen_gcOriginales.ContextMenuStrip = this.cmDisenoGeneralORI;
            this.gen_gcOriginales.Location = new System.Drawing.Point(5, 23);
            this.gen_gcOriginales.MainView = this.gen_gvOriginales;
            this.gen_gcOriginales.Name = "gen_gcOriginales";
            this.gen_gcOriginales.Size = new System.Drawing.Size(394, 204);
            this.gen_gcOriginales.TabIndex = 33;
            this.gen_gcOriginales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gen_gvOriginales});
            // 
            // cmDisenoGeneralORI
            // 
            this.cmDisenoGeneralORI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAgregaRegistroORI,
            this.mnuEliminaRegistroORI});
            this.cmDisenoGeneralORI.Name = "cmDisenoGeneralORI";
            this.cmDisenoGeneralORI.Size = new System.Drawing.Size(220, 48);
            // 
            // mnuAgregaRegistroORI
            // 
            this.mnuAgregaRegistroORI.Name = "mnuAgregaRegistroORI";
            this.mnuAgregaRegistroORI.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuAgregaRegistroORI.Size = new System.Drawing.Size(219, 22);
            this.mnuAgregaRegistroORI.Text = "Agregar Registro";
            this.mnuAgregaRegistroORI.Click += new System.EventHandler(this.mnuAgregaRegistroORI_Click);
            // 
            // mnuEliminaRegistroORI
            // 
            this.mnuEliminaRegistroORI.Name = "mnuEliminaRegistroORI";
            this.mnuEliminaRegistroORI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.mnuEliminaRegistroORI.Size = new System.Drawing.Size(219, 22);
            this.mnuEliminaRegistroORI.Text = "Eliminar Registro";
            this.mnuEliminaRegistroORI.Click += new System.EventHandler(this.mnuEliminaRegistroORI_Click);
            // 
            // gen_gvOriginales
            // 
            this.gen_gvOriginales.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gen_gcColDescripcionORI});
            this.gen_gvOriginales.GridControl = this.gen_gcOriginales;
            this.gen_gvOriginales.Name = "gen_gvOriginales";
            this.gen_gvOriginales.OptionsView.ShowGroupPanel = false;
            // 
            // gen_gcColDescripcionORI
            // 
            this.gen_gcColDescripcionORI.Caption = "Descripción";
            this.gen_gcColDescripcionORI.FieldName = "Descripcion";
            this.gen_gcColDescripcionORI.Name = "gen_gcColDescripcionORI";
            this.gen_gcColDescripcionORI.OptionsColumn.AllowEdit = false;
            this.gen_gcColDescripcionORI.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gen_gcColDescripcionORI.OptionsColumn.AllowIncrementalSearch = false;
            this.gen_gcColDescripcionORI.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gen_gcColDescripcionORI.OptionsColumn.AllowMove = false;
            this.gen_gcColDescripcionORI.OptionsColumn.AllowShowHide = false;
            this.gen_gcColDescripcionORI.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gen_gcColDescripcionORI.OptionsColumn.ReadOnly = true;
            this.gen_gcColDescripcionORI.OptionsFilter.AllowAutoFilter = false;
            this.gen_gcColDescripcionORI.OptionsFilter.AllowFilter = false;
            this.gen_gcColDescripcionORI.Visible = true;
            this.gen_gcColDescripcionORI.VisibleIndex = 0;
            // 
            // dis_xtpArmados
            // 
            this.dis_xtpArmados.Controls.Add(this.arm_gcArmados);
            this.dis_xtpArmados.Name = "dis_xtpArmados";
            this.dis_xtpArmados.Size = new System.Drawing.Size(844, 242);
            this.dis_xtpArmados.Text = "Papel";
            // 
            // arm_gcArmados
            // 
            this.arm_gcArmados.ContextMenuStrip = this.cmDisenoMatARMDIS;
            this.arm_gcArmados.Location = new System.Drawing.Point(0, 3);
            this.arm_gcArmados.MainView = this.arm_gvArmados;
            this.arm_gcArmados.Name = "arm_gcArmados";
            this.arm_gcArmados.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dis_riseAnchoTFinal,
            this.dis_ribeAltoTFinal,
            this.dis_risePorcentajePliegoEXT});
            this.arm_gcArmados.Size = new System.Drawing.Size(838, 236);
            this.arm_gcArmados.TabIndex = 0;
            this.arm_gcArmados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.arm_gvArmados});
            // 
            // cmDisenoMatARMDIS
            // 
            this.cmDisenoMatARMDIS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAgregaMATARMDIS,
            this.mnuCalculaDISARM,
            this.mnuVerGraficaDISARM,
            this.mnuQuitarMATARMDIS});
            this.cmDisenoMatARMDIS.Name = "cmMaterialARMDIS";
            this.cmDisenoMatARMDIS.Size = new System.Drawing.Size(220, 92);
            // 
            // mnuAgregaMATARMDIS
            // 
            this.mnuAgregaMATARMDIS.Name = "mnuAgregaMATARMDIS";
            this.mnuAgregaMATARMDIS.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuAgregaMATARMDIS.Size = new System.Drawing.Size(219, 22);
            this.mnuAgregaMATARMDIS.Text = "Agregar Material";
            this.mnuAgregaMATARMDIS.Click += new System.EventHandler(this.mnuAgregaMATARMDIS_Click);
            // 
            // mnuCalculaDISARM
            // 
            this.mnuCalculaDISARM.Name = "mnuCalculaDISARM";
            this.mnuCalculaDISARM.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.mnuCalculaDISARM.Size = new System.Drawing.Size(219, 22);
            this.mnuCalculaDISARM.Text = "Calcular valores";
            this.mnuCalculaDISARM.Click += new System.EventHandler(this.mnuCalculaDISARM_Click);
            // 
            // mnuVerGraficaDISARM
            // 
            this.mnuVerGraficaDISARM.Name = "mnuVerGraficaDISARM";
            this.mnuVerGraficaDISARM.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.mnuVerGraficaDISARM.Size = new System.Drawing.Size(219, 22);
            this.mnuVerGraficaDISARM.Text = "Ver Gráfica";
            this.mnuVerGraficaDISARM.Click += new System.EventHandler(this.mnuVerGraficaDISARM_Click);
            // 
            // mnuQuitarMATARMDIS
            // 
            this.mnuQuitarMATARMDIS.Name = "mnuQuitarMATARMDIS";
            this.mnuQuitarMATARMDIS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.mnuQuitarMATARMDIS.Size = new System.Drawing.Size(219, 22);
            this.mnuQuitarMATARMDIS.Text = "Eliminar Material";
            this.mnuQuitarMATARMDIS.Click += new System.EventHandler(this.mnuQuitarMATARMDIS_Click);
            // 
            // arm_gvArmados
            // 
            this.arm_gvArmados.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.bandaPliegoMP,
            this.bandaPliegoIMP,
            this.bandaPliego,
            this.gridBand6,
            this.bandaTrabajoFinal});
            this.arm_gvArmados.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.arm_gcColSeleccionAUT,
            this.arm_gcColGrupo,
            this.arm_gcColMaterial,
            this.arm_gcColAnchoTrabajoF,
            this.arm_gcColAltoTrabajoF,
            this.arm_gcColNumPaginas,
            this.arm_gcColPaginasXtrabajo,
            this.arm_gcColPliegoMPAncho,
            this.arm_gcColPliegoMPAlto,
            this.arm_gcColArmadoAncho,
            this.arm_gcColArmadoAlto,
            this.arm_gcColTamanosXpliego,
            this.arm_gcColImpXtamano,
            this.arm_gcColPliegoCantidad,
            this.arm_gcColPliegoEXTPorcentaje,
            this.arm_gcColPliegoExtra,
            this.arm_gcColUndCotiza,
            this.arm_gcColPlaca,
            this.arm_gcColTotalLinea});
            this.arm_gvArmados.GridControl = this.arm_gcArmados;
            this.arm_gvArmados.Name = "arm_gvArmados";
            this.arm_gvArmados.OptionsFilter.AllowFilterEditor = false;
            this.arm_gvArmados.OptionsView.ColumnAutoWidth = false;
            this.arm_gvArmados.OptionsView.ShowFooter = true;
            this.arm_gvArmados.OptionsView.ShowGroupPanel = false;
            this.arm_gvArmados.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.dis_bgvArmados_CellValueChanged);
            // 
            // bandaPliegoMP
            // 
            this.bandaPliegoMP.AppearanceHeader.Options.UseTextOptions = true;
            this.bandaPliegoMP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandaPliegoMP.Caption = "Mat. Prima";
            this.bandaPliegoMP.Columns.Add(this.arm_gcColSeleccionAUT);
            this.bandaPliegoMP.Columns.Add(this.arm_gcColGrupo);
            this.bandaPliegoMP.Columns.Add(this.arm_gcColMaterial);
            this.bandaPliegoMP.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.bandaPliegoMP.Name = "bandaPliegoMP";
            this.bandaPliegoMP.OptionsBand.AllowMove = false;
            this.bandaPliegoMP.VisibleIndex = 0;
            this.bandaPliegoMP.Width = 376;
            // 
            // arm_gcColSeleccionAUT
            // 
            this.arm_gcColSeleccionAUT.Caption = "AUT";
            this.arm_gcColSeleccionAUT.FieldName = "AUT";
            this.arm_gcColSeleccionAUT.Name = "arm_gcColSeleccionAUT";
            this.arm_gcColSeleccionAUT.OptionsColumn.AllowEdit = false;
            this.arm_gcColSeleccionAUT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColSeleccionAUT.OptionsColumn.AllowIncrementalSearch = false;
            this.arm_gcColSeleccionAUT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColSeleccionAUT.OptionsColumn.AllowMove = false;
            this.arm_gcColSeleccionAUT.OptionsColumn.AllowShowHide = false;
            this.arm_gcColSeleccionAUT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColSeleccionAUT.OptionsColumn.ReadOnly = true;
            this.arm_gcColSeleccionAUT.OptionsFilter.AllowAutoFilter = false;
            this.arm_gcColSeleccionAUT.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColSeleccionAUT.Visible = true;
            this.arm_gcColSeleccionAUT.Width = 38;
            // 
            // arm_gcColGrupo
            // 
            this.arm_gcColGrupo.Caption = "Grupo";
            this.arm_gcColGrupo.FieldName = "Talla";
            this.arm_gcColGrupo.Name = "arm_gcColGrupo";
            this.arm_gcColGrupo.OptionsColumn.AllowEdit = false;
            this.arm_gcColGrupo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColGrupo.OptionsColumn.AllowIncrementalSearch = false;
            this.arm_gcColGrupo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColGrupo.OptionsColumn.AllowMove = false;
            this.arm_gcColGrupo.OptionsColumn.AllowShowHide = false;
            this.arm_gcColGrupo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColGrupo.OptionsColumn.ReadOnly = true;
            this.arm_gcColGrupo.Visible = true;
            this.arm_gcColGrupo.Width = 113;
            // 
            // arm_gcColMaterial
            // 
            this.arm_gcColMaterial.Caption = "Material";
            this.arm_gcColMaterial.FieldName = "Material";
            this.arm_gcColMaterial.Name = "arm_gcColMaterial";
            this.arm_gcColMaterial.OptionsColumn.AllowEdit = false;
            this.arm_gcColMaterial.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColMaterial.OptionsColumn.AllowIncrementalSearch = false;
            this.arm_gcColMaterial.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColMaterial.OptionsColumn.AllowMove = false;
            this.arm_gcColMaterial.OptionsColumn.AllowShowHide = false;
            this.arm_gcColMaterial.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColMaterial.OptionsColumn.ReadOnly = true;
            this.arm_gcColMaterial.Visible = true;
            this.arm_gcColMaterial.Width = 225;
            // 
            // bandaPliegoIMP
            // 
            this.bandaPliegoIMP.AppearanceHeader.Options.UseTextOptions = true;
            this.bandaPliegoIMP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandaPliegoIMP.Caption = "Armados";
            this.bandaPliegoIMP.Columns.Add(this.arm_gcColPlaca);
            this.bandaPliegoIMP.Columns.Add(this.arm_gcColArmadoAncho);
            this.bandaPliegoIMP.Columns.Add(this.arm_gcColArmadoAlto);
            this.bandaPliegoIMP.Columns.Add(this.arm_gcColImpXtamano);
            this.bandaPliegoIMP.Name = "bandaPliegoIMP";
            this.bandaPliegoIMP.OptionsBand.AllowMove = false;
            this.bandaPliegoIMP.VisibleIndex = 1;
            this.bandaPliegoIMP.Width = 264;
            // 
            // arm_gcColPlaca
            // 
            this.arm_gcColPlaca.Caption = "Máquina";
            this.arm_gcColPlaca.FieldName = "Placa";
            this.arm_gcColPlaca.Name = "arm_gcColPlaca";
            this.arm_gcColPlaca.OptionsColumn.AllowEdit = false;
            this.arm_gcColPlaca.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColPlaca.OptionsColumn.AllowIncrementalSearch = false;
            this.arm_gcColPlaca.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColPlaca.OptionsColumn.AllowMove = false;
            this.arm_gcColPlaca.OptionsColumn.AllowShowHide = false;
            this.arm_gcColPlaca.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColPlaca.OptionsColumn.ReadOnly = true;
            this.arm_gcColPlaca.OptionsFilter.AllowAutoFilter = false;
            this.arm_gcColPlaca.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColPlaca.Visible = true;
            // 
            // arm_gcColArmadoAncho
            // 
            this.arm_gcColArmadoAncho.Caption = "Ancho";
            this.arm_gcColArmadoAncho.DisplayFormat.FormatString = "N2";
            this.arm_gcColArmadoAncho.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.arm_gcColArmadoAncho.FieldName = "TamanoAncho";
            this.arm_gcColArmadoAncho.Name = "arm_gcColArmadoAncho";
            this.arm_gcColArmadoAncho.OptionsColumn.AllowEdit = false;
            this.arm_gcColArmadoAncho.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColArmadoAncho.OptionsColumn.AllowIncrementalSearch = false;
            this.arm_gcColArmadoAncho.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColArmadoAncho.OptionsColumn.AllowMove = false;
            this.arm_gcColArmadoAncho.OptionsColumn.AllowShowHide = false;
            this.arm_gcColArmadoAncho.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColArmadoAncho.OptionsColumn.ReadOnly = true;
            this.arm_gcColArmadoAncho.Visible = true;
            this.arm_gcColArmadoAncho.Width = 53;
            // 
            // arm_gcColArmadoAlto
            // 
            this.arm_gcColArmadoAlto.Caption = "Alto";
            this.arm_gcColArmadoAlto.DisplayFormat.FormatString = "N2";
            this.arm_gcColArmadoAlto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.arm_gcColArmadoAlto.FieldName = "TamanoAlto";
            this.arm_gcColArmadoAlto.Name = "arm_gcColArmadoAlto";
            this.arm_gcColArmadoAlto.OptionsColumn.AllowEdit = false;
            this.arm_gcColArmadoAlto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColArmadoAlto.OptionsColumn.AllowIncrementalSearch = false;
            this.arm_gcColArmadoAlto.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColArmadoAlto.OptionsColumn.AllowMove = false;
            this.arm_gcColArmadoAlto.OptionsColumn.AllowShowHide = false;
            this.arm_gcColArmadoAlto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColArmadoAlto.OptionsColumn.ReadOnly = true;
            this.arm_gcColArmadoAlto.Visible = true;
            this.arm_gcColArmadoAlto.Width = 55;
            // 
            // arm_gcColImpXtamano
            // 
            this.arm_gcColImpXtamano.Caption = "Trab X Tam";
            this.arm_gcColImpXtamano.DisplayFormat.FormatString = "N0";
            this.arm_gcColImpXtamano.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.arm_gcColImpXtamano.FieldName = "TrabajosXtamano";
            this.arm_gcColImpXtamano.Name = "arm_gcColImpXtamano";
            this.arm_gcColImpXtamano.OptionsColumn.AllowEdit = false;
            this.arm_gcColImpXtamano.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColImpXtamano.OptionsColumn.AllowIncrementalSearch = false;
            this.arm_gcColImpXtamano.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColImpXtamano.OptionsColumn.AllowMove = false;
            this.arm_gcColImpXtamano.OptionsColumn.AllowShowHide = false;
            this.arm_gcColImpXtamano.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColImpXtamano.OptionsColumn.ReadOnly = true;
            this.arm_gcColImpXtamano.Visible = true;
            this.arm_gcColImpXtamano.Width = 81;
            // 
            // bandaPliego
            // 
            this.bandaPliego.AppearanceHeader.Options.UseTextOptions = true;
            this.bandaPliego.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandaPliego.Caption = "Pliegos";
            this.bandaPliego.Columns.Add(this.arm_gcColPliegoMPAncho);
            this.bandaPliego.Columns.Add(this.arm_gcColPliegoMPAlto);
            this.bandaPliego.Columns.Add(this.arm_gcColTamanosXpliego);
            this.bandaPliego.Columns.Add(this.arm_gcColPliegoCantidad);
            this.bandaPliego.Columns.Add(this.arm_gcColPliegoEXTPorcentaje);
            this.bandaPliego.Columns.Add(this.arm_gcColPliegoExtra);
            this.bandaPliego.Columns.Add(this.arm_gcColUndCotiza);
            this.bandaPliego.Name = "bandaPliego";
            this.bandaPliego.OptionsBand.AllowMove = false;
            this.bandaPliego.VisibleIndex = 2;
            this.bandaPliego.Width = 438;
            // 
            // arm_gcColPliegoMPAncho
            // 
            this.arm_gcColPliegoMPAncho.Caption = "Ancho";
            this.arm_gcColPliegoMPAncho.DisplayFormat.FormatString = "N2";
            this.arm_gcColPliegoMPAncho.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.arm_gcColPliegoMPAncho.FieldName = "PliegoAncho";
            this.arm_gcColPliegoMPAncho.Name = "arm_gcColPliegoMPAncho";
            this.arm_gcColPliegoMPAncho.OptionsColumn.AllowEdit = false;
            this.arm_gcColPliegoMPAncho.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColPliegoMPAncho.OptionsColumn.AllowIncrementalSearch = false;
            this.arm_gcColPliegoMPAncho.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColPliegoMPAncho.OptionsColumn.AllowMove = false;
            this.arm_gcColPliegoMPAncho.OptionsColumn.AllowShowHide = false;
            this.arm_gcColPliegoMPAncho.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColPliegoMPAncho.OptionsColumn.ReadOnly = true;
            this.arm_gcColPliegoMPAncho.Visible = true;
            this.arm_gcColPliegoMPAncho.Width = 51;
            // 
            // arm_gcColPliegoMPAlto
            // 
            this.arm_gcColPliegoMPAlto.Caption = "Alto";
            this.arm_gcColPliegoMPAlto.DisplayFormat.FormatString = "N2";
            this.arm_gcColPliegoMPAlto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.arm_gcColPliegoMPAlto.FieldName = "PliegoAlto";
            this.arm_gcColPliegoMPAlto.Name = "arm_gcColPliegoMPAlto";
            this.arm_gcColPliegoMPAlto.OptionsColumn.AllowEdit = false;
            this.arm_gcColPliegoMPAlto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColPliegoMPAlto.OptionsColumn.AllowIncrementalSearch = false;
            this.arm_gcColPliegoMPAlto.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColPliegoMPAlto.OptionsColumn.AllowMove = false;
            this.arm_gcColPliegoMPAlto.OptionsColumn.AllowShowHide = false;
            this.arm_gcColPliegoMPAlto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColPliegoMPAlto.OptionsColumn.ReadOnly = true;
            this.arm_gcColPliegoMPAlto.Visible = true;
            this.arm_gcColPliegoMPAlto.Width = 55;
            // 
            // arm_gcColTamanosXpliego
            // 
            this.arm_gcColTamanosXpliego.Caption = "Tam X Plie";
            this.arm_gcColTamanosXpliego.DisplayFormat.FormatString = "N0";
            this.arm_gcColTamanosXpliego.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.arm_gcColTamanosXpliego.FieldName = "TamanosXpliego";
            this.arm_gcColTamanosXpliego.Name = "arm_gcColTamanosXpliego";
            this.arm_gcColTamanosXpliego.OptionsColumn.AllowEdit = false;
            this.arm_gcColTamanosXpliego.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColTamanosXpliego.OptionsColumn.AllowIncrementalSearch = false;
            this.arm_gcColTamanosXpliego.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColTamanosXpliego.OptionsColumn.AllowMove = false;
            this.arm_gcColTamanosXpliego.OptionsColumn.AllowShowHide = false;
            this.arm_gcColTamanosXpliego.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColTamanosXpliego.OptionsColumn.ReadOnly = true;
            this.arm_gcColTamanosXpliego.Visible = true;
            this.arm_gcColTamanosXpliego.Width = 65;
            // 
            // arm_gcColPliegoCantidad
            // 
            this.arm_gcColPliegoCantidad.Caption = "Cant";
            this.arm_gcColPliegoCantidad.DisplayFormat.FormatString = "N0";
            this.arm_gcColPliegoCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.arm_gcColPliegoCantidad.FieldName = "PliegoCantidad";
            this.arm_gcColPliegoCantidad.Name = "arm_gcColPliegoCantidad";
            this.arm_gcColPliegoCantidad.OptionsColumn.AllowEdit = false;
            this.arm_gcColPliegoCantidad.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColPliegoCantidad.OptionsColumn.AllowIncrementalSearch = false;
            this.arm_gcColPliegoCantidad.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColPliegoCantidad.OptionsColumn.AllowMove = false;
            this.arm_gcColPliegoCantidad.OptionsColumn.AllowShowHide = false;
            this.arm_gcColPliegoCantidad.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColPliegoCantidad.OptionsColumn.ReadOnly = true;
            this.arm_gcColPliegoCantidad.Visible = true;
            this.arm_gcColPliegoCantidad.Width = 50;
            // 
            // arm_gcColPliegoEXTPorcentaje
            // 
            this.arm_gcColPliegoEXTPorcentaje.Caption = "Extra %";
            this.arm_gcColPliegoEXTPorcentaje.ColumnEdit = this.dis_risePorcentajePliegoEXT;
            this.arm_gcColPliegoEXTPorcentaje.FieldName = "PorcentajeEXT";
            this.arm_gcColPliegoEXTPorcentaje.Name = "arm_gcColPliegoEXTPorcentaje";
            this.arm_gcColPliegoEXTPorcentaje.Visible = true;
            // 
            // dis_risePorcentajePliegoEXT
            // 
            this.dis_risePorcentajePliegoEXT.AutoHeight = false;
            this.dis_risePorcentajePliegoEXT.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dis_risePorcentajePliegoEXT.DisplayFormat.FormatString = "N0";
            this.dis_risePorcentajePliegoEXT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_risePorcentajePliegoEXT.EditFormat.FormatString = "N0";
            this.dis_risePorcentajePliegoEXT.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_risePorcentajePliegoEXT.Mask.EditMask = "N0";
            this.dis_risePorcentajePliegoEXT.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.dis_risePorcentajePliegoEXT.Name = "dis_risePorcentajePliegoEXT";
            // 
            // arm_gcColPliegoExtra
            // 
            this.arm_gcColPliegoExtra.Caption = "Extra Nro";
            this.arm_gcColPliegoExtra.DisplayFormat.FormatString = "N0";
            this.arm_gcColPliegoExtra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.arm_gcColPliegoExtra.FieldName = "Extra";
            this.arm_gcColPliegoExtra.Name = "arm_gcColPliegoExtra";
            this.arm_gcColPliegoExtra.OptionsColumn.AllowEdit = false;
            this.arm_gcColPliegoExtra.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColPliegoExtra.OptionsColumn.AllowIncrementalSearch = false;
            this.arm_gcColPliegoExtra.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColPliegoExtra.OptionsColumn.AllowMove = false;
            this.arm_gcColPliegoExtra.OptionsColumn.AllowShowHide = false;
            this.arm_gcColPliegoExtra.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColPliegoExtra.Visible = true;
            this.arm_gcColPliegoExtra.Width = 62;
            // 
            // arm_gcColUndCotiza
            // 
            this.arm_gcColUndCotiza.Caption = "Cotizadas";
            this.arm_gcColUndCotiza.DisplayFormat.FormatString = "N0";
            this.arm_gcColUndCotiza.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.arm_gcColUndCotiza.FieldName = "PliegoCotizados";
            this.arm_gcColUndCotiza.Name = "arm_gcColUndCotiza";
            this.arm_gcColUndCotiza.OptionsColumn.AllowEdit = false;
            this.arm_gcColUndCotiza.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColUndCotiza.OptionsColumn.AllowIncrementalSearch = false;
            this.arm_gcColUndCotiza.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColUndCotiza.OptionsColumn.AllowMove = false;
            this.arm_gcColUndCotiza.OptionsColumn.AllowShowHide = false;
            this.arm_gcColUndCotiza.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColUndCotiza.OptionsColumn.ReadOnly = true;
            this.arm_gcColUndCotiza.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PliegoCotizados", "{0:N2}")});
            this.arm_gcColUndCotiza.Visible = true;
            this.arm_gcColUndCotiza.Width = 80;
            // 
            // gridBand6
            // 
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.Visible = false;
            this.gridBand6.VisibleIndex = -1;
            // 
            // bandaTrabajoFinal
            // 
            this.bandaTrabajoFinal.Caption = "Trabajo Final";
            this.bandaTrabajoFinal.Columns.Add(this.arm_gcColAnchoTrabajoF);
            this.bandaTrabajoFinal.Columns.Add(this.arm_gcColAltoTrabajoF);
            this.bandaTrabajoFinal.Columns.Add(this.arm_gcColNumPaginas);
            this.bandaTrabajoFinal.Columns.Add(this.arm_gcColPaginasXtrabajo);
            this.bandaTrabajoFinal.Columns.Add(this.arm_gcColTotalLinea);
            this.bandaTrabajoFinal.Name = "bandaTrabajoFinal";
            this.bandaTrabajoFinal.VisibleIndex = 3;
            this.bandaTrabajoFinal.Width = 368;
            // 
            // arm_gcColAnchoTrabajoF
            // 
            this.arm_gcColAnchoTrabajoF.Caption = "Ancho";
            this.arm_gcColAnchoTrabajoF.ColumnEdit = this.dis_riseAnchoTFinal;
            this.arm_gcColAnchoTrabajoF.FieldName = "TrabajoAncho";
            this.arm_gcColAnchoTrabajoF.Name = "arm_gcColAnchoTrabajoF";
            this.arm_gcColAnchoTrabajoF.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColAnchoTrabajoF.OptionsColumn.AllowIncrementalSearch = false;
            this.arm_gcColAnchoTrabajoF.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColAnchoTrabajoF.OptionsColumn.AllowMove = false;
            this.arm_gcColAnchoTrabajoF.OptionsColumn.AllowShowHide = false;
            this.arm_gcColAnchoTrabajoF.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColAnchoTrabajoF.Visible = true;
            this.arm_gcColAnchoTrabajoF.Width = 69;
            // 
            // dis_riseAnchoTFinal
            // 
            this.dis_riseAnchoTFinal.AutoHeight = false;
            this.dis_riseAnchoTFinal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dis_riseAnchoTFinal.DisplayFormat.FormatString = "N2";
            this.dis_riseAnchoTFinal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_riseAnchoTFinal.EditFormat.FormatString = "N2";
            this.dis_riseAnchoTFinal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_riseAnchoTFinal.Mask.EditMask = "N2";
            this.dis_riseAnchoTFinal.MaxValue = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.dis_riseAnchoTFinal.MinValue = new decimal(new int[] {
            3,
            0,
            0,
            131072});
            this.dis_riseAnchoTFinal.Name = "dis_riseAnchoTFinal";
            // 
            // arm_gcColAltoTrabajoF
            // 
            this.arm_gcColAltoTrabajoF.Caption = "Alto";
            this.arm_gcColAltoTrabajoF.ColumnEdit = this.dis_ribeAltoTFinal;
            this.arm_gcColAltoTrabajoF.FieldName = "TrabajoAlto";
            this.arm_gcColAltoTrabajoF.Name = "arm_gcColAltoTrabajoF";
            this.arm_gcColAltoTrabajoF.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColAltoTrabajoF.OptionsColumn.AllowIncrementalSearch = false;
            this.arm_gcColAltoTrabajoF.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColAltoTrabajoF.OptionsColumn.AllowMove = false;
            this.arm_gcColAltoTrabajoF.OptionsColumn.AllowShowHide = false;
            this.arm_gcColAltoTrabajoF.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColAltoTrabajoF.Visible = true;
            this.arm_gcColAltoTrabajoF.Width = 74;
            // 
            // dis_ribeAltoTFinal
            // 
            this.dis_ribeAltoTFinal.AutoHeight = false;
            this.dis_ribeAltoTFinal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dis_ribeAltoTFinal.DisplayFormat.FormatString = "N2";
            this.dis_ribeAltoTFinal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_ribeAltoTFinal.EditFormat.FormatString = "N2";
            this.dis_ribeAltoTFinal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_ribeAltoTFinal.Mask.EditMask = "N2";
            this.dis_ribeAltoTFinal.MaxValue = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.dis_ribeAltoTFinal.MinValue = new decimal(new int[] {
            3,
            0,
            0,
            131072});
            this.dis_ribeAltoTFinal.Name = "dis_ribeAltoTFinal";
            // 
            // arm_gcColNumPaginas
            // 
            this.arm_gcColNumPaginas.Caption = "Num. Páginas";
            this.arm_gcColNumPaginas.DisplayFormat.FormatString = "N0";
            this.arm_gcColNumPaginas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.arm_gcColNumPaginas.FieldName = "NumPaginas";
            this.arm_gcColNumPaginas.Name = "arm_gcColNumPaginas";
            this.arm_gcColNumPaginas.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColNumPaginas.OptionsColumn.AllowIncrementalSearch = false;
            this.arm_gcColNumPaginas.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColNumPaginas.OptionsColumn.AllowMove = false;
            this.arm_gcColNumPaginas.OptionsColumn.AllowShowHide = false;
            this.arm_gcColNumPaginas.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColNumPaginas.Visible = true;
            // 
            // arm_gcColPaginasXtrabajo
            // 
            this.arm_gcColPaginasXtrabajo.Caption = "Pag X Trab";
            this.arm_gcColPaginasXtrabajo.DisplayFormat.FormatString = "N0";
            this.arm_gcColPaginasXtrabajo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.arm_gcColPaginasXtrabajo.FieldName = "PaginasXtrabajo";
            this.arm_gcColPaginasXtrabajo.Name = "arm_gcColPaginasXtrabajo";
            this.arm_gcColPaginasXtrabajo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColPaginasXtrabajo.OptionsColumn.AllowIncrementalSearch = false;
            this.arm_gcColPaginasXtrabajo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColPaginasXtrabajo.OptionsColumn.AllowMove = false;
            this.arm_gcColPaginasXtrabajo.OptionsColumn.AllowShowHide = false;
            this.arm_gcColPaginasXtrabajo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColPaginasXtrabajo.Visible = true;
            // 
            // arm_gcColTotalLinea
            // 
            this.arm_gcColTotalLinea.Caption = "Total";
            this.arm_gcColTotalLinea.DisplayFormat.FormatString = "N2";
            this.arm_gcColTotalLinea.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.arm_gcColTotalLinea.FieldName = "TotalLinea";
            this.arm_gcColTotalLinea.Name = "arm_gcColTotalLinea";
            this.arm_gcColTotalLinea.OptionsColumn.AllowEdit = false;
            this.arm_gcColTotalLinea.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColTotalLinea.OptionsColumn.AllowIncrementalSearch = false;
            this.arm_gcColTotalLinea.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColTotalLinea.OptionsColumn.AllowMove = false;
            this.arm_gcColTotalLinea.OptionsColumn.AllowShowHide = false;
            this.arm_gcColTotalLinea.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.arm_gcColTotalLinea.OptionsColumn.ReadOnly = true;
            this.arm_gcColTotalLinea.OptionsFilter.AllowAutoFilter = false;
            this.arm_gcColTotalLinea.OptionsFilter.AllowFilter = false;
            this.arm_gcColTotalLinea.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalLinea", "{0:N2}")});
            this.arm_gcColTotalLinea.Visible = true;
            // 
            // dis_xtpColores
            // 
            this.dis_xtpColores.Controls.Add(this.labelControl18);
            this.dis_xtpColores.Controls.Add(this.labelControl17);
            this.dis_xtpColores.Controls.Add(this.labelControl16);
            this.dis_xtpColores.Controls.Add(this.dis_seGramosPantone);
            this.dis_xtpColores.Controls.Add(this.dis_seGramosMetalizado);
            this.dis_xtpColores.Controls.Add(this.dis_seGramosColor);
            this.dis_xtpColores.Controls.Add(this.col_gcColores);
            this.dis_xtpColores.Name = "dis_xtpColores";
            this.dis_xtpColores.Size = new System.Drawing.Size(844, 242);
            this.dis_xtpColores.Text = "Colores";
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(644, 221);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(83, 13);
            this.labelControl18.TabIndex = 7;
            this.labelControl18.Text = "Gramos Pantone:";
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(314, 220);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(94, 13);
            this.labelControl17.TabIndex = 6;
            this.labelControl17.Text = "Gramos Metalizado:";
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(7, 220);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(68, 13);
            this.labelControl16.TabIndex = 5;
            this.labelControl16.Text = "Gramos Color:";
            // 
            // dis_seGramosPantone
            // 
            this.dis_seGramosPantone.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dis_seGramosPantone.Location = new System.Drawing.Point(738, 217);
            this.dis_seGramosPantone.Name = "dis_seGramosPantone";
            this.dis_seGramosPantone.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dis_seGramosPantone.Properties.Appearance.Options.UseBackColor = true;
            this.dis_seGramosPantone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dis_seGramosPantone.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dis_seGramosPantone.Properties.DisplayFormat.FormatString = "N2";
            this.dis_seGramosPantone.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_seGramosPantone.Properties.EditFormat.FormatString = "N2";
            this.dis_seGramosPantone.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_seGramosPantone.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dis_seGramosPantone.Properties.Mask.EditMask = "N2";
            this.dis_seGramosPantone.Properties.MaxValue = new decimal(new int[] {
            1410065407,
            2,
            0,
            131072});
            this.dis_seGramosPantone.Properties.ReadOnly = true;
            this.dis_seGramosPantone.Size = new System.Drawing.Size(100, 20);
            this.dis_seGramosPantone.TabIndex = 3;
            // 
            // dis_seGramosMetalizado
            // 
            this.dis_seGramosMetalizado.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dis_seGramosMetalizado.Location = new System.Drawing.Point(425, 217);
            this.dis_seGramosMetalizado.Name = "dis_seGramosMetalizado";
            this.dis_seGramosMetalizado.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dis_seGramosMetalizado.Properties.Appearance.Options.UseBackColor = true;
            this.dis_seGramosMetalizado.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dis_seGramosMetalizado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dis_seGramosMetalizado.Properties.DisplayFormat.FormatString = "N2";
            this.dis_seGramosMetalizado.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_seGramosMetalizado.Properties.EditFormat.FormatString = "N2";
            this.dis_seGramosMetalizado.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_seGramosMetalizado.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dis_seGramosMetalizado.Properties.Mask.EditMask = "N2";
            this.dis_seGramosMetalizado.Properties.MaxValue = new decimal(new int[] {
            1410065407,
            2,
            0,
            131072});
            this.dis_seGramosMetalizado.Properties.ReadOnly = true;
            this.dis_seGramosMetalizado.Size = new System.Drawing.Size(100, 20);
            this.dis_seGramosMetalizado.TabIndex = 2;
            // 
            // dis_seGramosColor
            // 
            this.dis_seGramosColor.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dis_seGramosColor.Location = new System.Drawing.Point(90, 217);
            this.dis_seGramosColor.Name = "dis_seGramosColor";
            this.dis_seGramosColor.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dis_seGramosColor.Properties.Appearance.Options.UseBackColor = true;
            this.dis_seGramosColor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dis_seGramosColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dis_seGramosColor.Properties.DisplayFormat.FormatString = "N2";
            this.dis_seGramosColor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_seGramosColor.Properties.EditFormat.FormatString = "N2";
            this.dis_seGramosColor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_seGramosColor.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dis_seGramosColor.Properties.Mask.EditMask = "N2";
            this.dis_seGramosColor.Properties.MaxValue = new decimal(new int[] {
            1410065407,
            2,
            0,
            131072});
            this.dis_seGramosColor.Properties.ReadOnly = true;
            this.dis_seGramosColor.Size = new System.Drawing.Size(100, 20);
            this.dis_seGramosColor.TabIndex = 1;
            // 
            // col_gcColores
            // 
            this.col_gcColores.ContextMenuStrip = this.cmDisenoColor;
            this.col_gcColores.Location = new System.Drawing.Point(3, 3);
            this.col_gcColores.MainView = this.col_gvColores;
            this.col_gcColores.Name = "col_gcColores";
            this.col_gcColores.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dis_rilueTipoColor,
            this.dis_rilueCobertura,
            this.dis_rilueLadoImpresion});
            this.col_gcColores.Size = new System.Drawing.Size(835, 207);
            this.col_gcColores.TabIndex = 0;
            this.col_gcColores.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.col_gvColores});
            // 
            // cmDisenoColor
            // 
            this.cmDisenoColor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAgregaRegistro,
            this.mnuEliminaRegDisenoColor});
            this.cmDisenoColor.Name = "cmDisenoColor";
            this.cmDisenoColor.Size = new System.Drawing.Size(220, 48);
            // 
            // mnuAgregaRegistro
            // 
            this.mnuAgregaRegistro.Name = "mnuAgregaRegistro";
            this.mnuAgregaRegistro.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuAgregaRegistro.Size = new System.Drawing.Size(219, 22);
            this.mnuAgregaRegistro.Text = "Agregar Registro";
            this.mnuAgregaRegistro.Click += new System.EventHandler(this.mnuAgregaRegistro_Click);
            // 
            // mnuEliminaRegDisenoColor
            // 
            this.mnuEliminaRegDisenoColor.Name = "mnuEliminaRegDisenoColor";
            this.mnuEliminaRegDisenoColor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.mnuEliminaRegDisenoColor.Size = new System.Drawing.Size(219, 22);
            this.mnuEliminaRegDisenoColor.Text = "Eliminar Registro";
            this.mnuEliminaRegDisenoColor.Click += new System.EventHandler(this.mnuEliminaRegDisenoColor_Click);
            // 
            // col_gvColores
            // 
            this.col_gvColores.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_gcColMaterialC,
            this.col_gcColArea,
            this.col_gcColLado,
            this.col_gcColTipoColor,
            this.col_gcColCostoGramoColor,
            this.col_gcColCobertura,
            this.col_gcColGramos,
            this.col_gcColNumPaginasC,
            this.col_gcColTotGramos,
            this.col_gcColTotLinea,
            this.col_gcColDetallePAG});
            this.col_gvColores.GridControl = this.col_gcColores;
            this.col_gvColores.Name = "col_gvColores";
            this.col_gvColores.OptionsView.ColumnAutoWidth = false;
            this.col_gvColores.OptionsView.ShowGroupPanel = false;
            // 
            // col_gcColMaterialC
            // 
            this.col_gcColMaterialC.Caption = "Material";
            this.col_gcColMaterialC.FieldName = "Material";
            this.col_gcColMaterialC.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.col_gcColMaterialC.Name = "col_gcColMaterialC";
            this.col_gcColMaterialC.OptionsColumn.AllowEdit = false;
            this.col_gcColMaterialC.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColMaterialC.OptionsColumn.AllowIncrementalSearch = false;
            this.col_gcColMaterialC.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColMaterialC.OptionsColumn.AllowMove = false;
            this.col_gcColMaterialC.OptionsColumn.AllowShowHide = false;
            this.col_gcColMaterialC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColMaterialC.OptionsColumn.ReadOnly = true;
            this.col_gcColMaterialC.OptionsFilter.AllowAutoFilter = false;
            this.col_gcColMaterialC.OptionsFilter.AllowFilter = false;
            this.col_gcColMaterialC.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColMaterialC.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.col_gcColMaterialC.ToolTip = "Material al que está asignando el color";
            this.col_gcColMaterialC.Visible = true;
            this.col_gcColMaterialC.VisibleIndex = 0;
            this.col_gcColMaterialC.Width = 200;
            // 
            // col_gcColArea
            // 
            this.col_gcColArea.Caption = "Area cm2";
            this.col_gcColArea.DisplayFormat.FormatString = "N2";
            this.col_gcColArea.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_gcColArea.FieldName = "Area";
            this.col_gcColArea.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.col_gcColArea.Name = "col_gcColArea";
            this.col_gcColArea.OptionsColumn.AllowEdit = false;
            this.col_gcColArea.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColArea.OptionsColumn.AllowIncrementalSearch = false;
            this.col_gcColArea.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColArea.OptionsColumn.AllowMove = false;
            this.col_gcColArea.OptionsColumn.AllowShowHide = false;
            this.col_gcColArea.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColArea.OptionsColumn.ReadOnly = true;
            this.col_gcColArea.OptionsFilter.AllowAutoFilter = false;
            this.col_gcColArea.OptionsFilter.AllowFilter = false;
            this.col_gcColArea.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColArea.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.col_gcColArea.ToolTip = "Area de impresión. (Default=Area del trabajo final)";
            this.col_gcColArea.Visible = true;
            this.col_gcColArea.VisibleIndex = 1;
            this.col_gcColArea.Width = 60;
            // 
            // col_gcColLado
            // 
            this.col_gcColLado.Caption = "Lado";
            this.col_gcColLado.ColumnEdit = this.dis_rilueLadoImpresion;
            this.col_gcColLado.FieldName = "LadoImpresion";
            this.col_gcColLado.Name = "col_gcColLado";
            this.col_gcColLado.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColLado.OptionsColumn.AllowIncrementalSearch = false;
            this.col_gcColLado.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColLado.OptionsColumn.AllowMove = false;
            this.col_gcColLado.OptionsColumn.AllowShowHide = false;
            this.col_gcColLado.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColLado.OptionsFilter.AllowAutoFilter = false;
            this.col_gcColLado.OptionsFilter.AllowFilter = false;
            this.col_gcColLado.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColLado.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.col_gcColLado.ToolTip = "Lados de impresion (Tiro, Retiro, Tiro Y Retiro[Cuando los dos lados tienen la mi" +
    "sma textura])";
            this.col_gcColLado.Visible = true;
            this.col_gcColLado.VisibleIndex = 2;
            this.col_gcColLado.Width = 100;
            // 
            // dis_rilueLadoImpresion
            // 
            this.dis_rilueLadoImpresion.AutoHeight = false;
            this.dis_rilueLadoImpresion.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dis_rilueLadoImpresion.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Lado")});
            this.dis_rilueLadoImpresion.DisplayMember = "Descripcion";
            this.dis_rilueLadoImpresion.Name = "dis_rilueLadoImpresion";
            this.dis_rilueLadoImpresion.NullText = "";
            this.dis_rilueLadoImpresion.ValueMember = "Codigo";
            // 
            // col_gcColTipoColor
            // 
            this.col_gcColTipoColor.Caption = "Color";
            this.col_gcColTipoColor.ColumnEdit = this.dis_rilueTipoColor;
            this.col_gcColTipoColor.FieldName = "Color";
            this.col_gcColTipoColor.Name = "col_gcColTipoColor";
            this.col_gcColTipoColor.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColTipoColor.OptionsColumn.AllowIncrementalSearch = false;
            this.col_gcColTipoColor.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColTipoColor.OptionsColumn.AllowMove = false;
            this.col_gcColTipoColor.OptionsColumn.AllowShowHide = false;
            this.col_gcColTipoColor.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColTipoColor.OptionsFilter.AllowAutoFilter = false;
            this.col_gcColTipoColor.OptionsFilter.AllowFilter = false;
            this.col_gcColTipoColor.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColTipoColor.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.col_gcColTipoColor.ToolTip = "Tipo de color que va a utilizar";
            this.col_gcColTipoColor.Visible = true;
            this.col_gcColTipoColor.VisibleIndex = 3;
            this.col_gcColTipoColor.Width = 100;
            // 
            // dis_rilueTipoColor
            // 
            this.dis_rilueTipoColor.AutoHeight = false;
            this.dis_rilueTipoColor.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dis_rilueTipoColor.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Color")});
            this.dis_rilueTipoColor.DisplayMember = "Descripcion";
            this.dis_rilueTipoColor.Name = "dis_rilueTipoColor";
            this.dis_rilueTipoColor.NullText = "";
            this.dis_rilueTipoColor.ValueMember = "Codigo";
            this.dis_rilueTipoColor.EditValueChanged += new System.EventHandler(this.dis_rilueColorPlancha_EditValueChanged);
            // 
            // col_gcColCostoGramoColor
            // 
            this.col_gcColCostoGramoColor.Caption = "Costo";
            this.col_gcColCostoGramoColor.DisplayFormat.FormatString = "e3";
            this.col_gcColCostoGramoColor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_gcColCostoGramoColor.FieldName = "CostoGramo";
            this.col_gcColCostoGramoColor.Name = "col_gcColCostoGramoColor";
            this.col_gcColCostoGramoColor.OptionsColumn.AllowEdit = false;
            this.col_gcColCostoGramoColor.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColCostoGramoColor.OptionsColumn.AllowIncrementalSearch = false;
            this.col_gcColCostoGramoColor.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColCostoGramoColor.OptionsColumn.AllowMove = false;
            this.col_gcColCostoGramoColor.OptionsColumn.AllowShowHide = false;
            this.col_gcColCostoGramoColor.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColCostoGramoColor.OptionsColumn.ReadOnly = true;
            this.col_gcColCostoGramoColor.OptionsFilter.AllowAutoFilter = false;
            this.col_gcColCostoGramoColor.OptionsFilter.AllowFilter = false;
            this.col_gcColCostoGramoColor.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColCostoGramoColor.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.col_gcColCostoGramoColor.ToolTip = "Costo aproximado de cada gramo en funcion del color";
            this.col_gcColCostoGramoColor.Visible = true;
            this.col_gcColCostoGramoColor.VisibleIndex = 4;
            this.col_gcColCostoGramoColor.Width = 72;
            // 
            // col_gcColCobertura
            // 
            this.col_gcColCobertura.Caption = "Cob %";
            this.col_gcColCobertura.ColumnEdit = this.dis_rilueCobertura;
            this.col_gcColCobertura.FieldName = "Cobertura";
            this.col_gcColCobertura.Name = "col_gcColCobertura";
            this.col_gcColCobertura.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColCobertura.OptionsColumn.AllowIncrementalSearch = false;
            this.col_gcColCobertura.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColCobertura.OptionsColumn.AllowMove = false;
            this.col_gcColCobertura.OptionsColumn.AllowShowHide = false;
            this.col_gcColCobertura.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColCobertura.OptionsFilter.AllowAutoFilter = false;
            this.col_gcColCobertura.OptionsFilter.AllowFilter = false;
            this.col_gcColCobertura.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColCobertura.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.col_gcColCobertura.ToolTip = "Porcentaje de cobertura de la página";
            this.col_gcColCobertura.Visible = true;
            this.col_gcColCobertura.VisibleIndex = 5;
            this.col_gcColCobertura.Width = 55;
            // 
            // dis_rilueCobertura
            // 
            this.dis_rilueCobertura.AutoHeight = false;
            this.dis_rilueCobertura.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dis_rilueCobertura.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Cobertura")});
            this.dis_rilueCobertura.DisplayMember = "Descripcion";
            this.dis_rilueCobertura.Name = "dis_rilueCobertura";
            this.dis_rilueCobertura.NullText = "";
            this.dis_rilueCobertura.ValueMember = "Codigo";
            this.dis_rilueCobertura.EditValueChanged += new System.EventHandler(this.dis_rilueCobertura_EditValueChanged);
            // 
            // col_gcColGramos
            // 
            this.col_gcColGramos.Caption = "Gr X cm2";
            this.col_gcColGramos.DisplayFormat.FormatString = "N2";
            this.col_gcColGramos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_gcColGramos.FieldName = "GramosXcm2";
            this.col_gcColGramos.Name = "col_gcColGramos";
            this.col_gcColGramos.OptionsColumn.AllowEdit = false;
            this.col_gcColGramos.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColGramos.OptionsColumn.AllowIncrementalSearch = false;
            this.col_gcColGramos.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColGramos.OptionsColumn.AllowMove = false;
            this.col_gcColGramos.OptionsColumn.AllowShowHide = false;
            this.col_gcColGramos.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColGramos.OptionsColumn.ReadOnly = true;
            this.col_gcColGramos.OptionsFilter.AllowAutoFilter = false;
            this.col_gcColGramos.OptionsFilter.AllowFilter = false;
            this.col_gcColGramos.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColGramos.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.col_gcColGramos.ToolTip = "Recupera de la BD en función de la cobertura";
            this.col_gcColGramos.Visible = true;
            this.col_gcColGramos.VisibleIndex = 6;
            this.col_gcColGramos.Width = 54;
            // 
            // col_gcColNumPaginasC
            // 
            this.col_gcColNumPaginasC.Caption = "Paginas";
            this.col_gcColNumPaginasC.DisplayFormat.FormatString = "N0";
            this.col_gcColNumPaginasC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_gcColNumPaginasC.FieldName = "NumPaginas";
            this.col_gcColNumPaginasC.Name = "col_gcColNumPaginasC";
            this.col_gcColNumPaginasC.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColNumPaginasC.OptionsColumn.AllowIncrementalSearch = false;
            this.col_gcColNumPaginasC.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColNumPaginasC.OptionsColumn.AllowMove = false;
            this.col_gcColNumPaginasC.OptionsColumn.AllowShowHide = false;
            this.col_gcColNumPaginasC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColNumPaginasC.OptionsFilter.AllowAutoFilter = false;
            this.col_gcColNumPaginasC.OptionsFilter.AllowFilter = false;
            this.col_gcColNumPaginasC.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColNumPaginasC.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.col_gcColNumPaginasC.ToolTip = "Número de páginas de cada trabajo. (Default=1)";
            this.col_gcColNumPaginasC.Visible = true;
            this.col_gcColNumPaginasC.VisibleIndex = 7;
            this.col_gcColNumPaginasC.Width = 60;
            // 
            // col_gcColTotGramos
            // 
            this.col_gcColTotGramos.Caption = "Total GR";
            this.col_gcColTotGramos.DisplayFormat.FormatString = "N2";
            this.col_gcColTotGramos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_gcColTotGramos.FieldName = "TotalGramos";
            this.col_gcColTotGramos.Name = "col_gcColTotGramos";
            this.col_gcColTotGramos.OptionsColumn.AllowEdit = false;
            this.col_gcColTotGramos.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColTotGramos.OptionsColumn.AllowIncrementalSearch = false;
            this.col_gcColTotGramos.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColTotGramos.OptionsColumn.AllowMove = false;
            this.col_gcColTotGramos.OptionsColumn.AllowShowHide = false;
            this.col_gcColTotGramos.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColTotGramos.OptionsColumn.ReadOnly = true;
            this.col_gcColTotGramos.OptionsFilter.AllowAutoFilter = false;
            this.col_gcColTotGramos.OptionsFilter.AllowFilter = false;
            this.col_gcColTotGramos.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColTotGramos.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.col_gcColTotGramos.ToolTip = "Area*NumPaginas*Gramos";
            this.col_gcColTotGramos.Visible = true;
            this.col_gcColTotGramos.VisibleIndex = 8;
            // 
            // col_gcColTotLinea
            // 
            this.col_gcColTotLinea.Caption = "Total $";
            this.col_gcColTotLinea.DisplayFormat.FormatString = "e3";
            this.col_gcColTotLinea.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_gcColTotLinea.FieldName = "TotalLinea";
            this.col_gcColTotLinea.Name = "col_gcColTotLinea";
            this.col_gcColTotLinea.OptionsColumn.AllowEdit = false;
            this.col_gcColTotLinea.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColTotLinea.OptionsColumn.AllowIncrementalSearch = false;
            this.col_gcColTotLinea.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColTotLinea.OptionsColumn.AllowMove = false;
            this.col_gcColTotLinea.OptionsColumn.AllowShowHide = false;
            this.col_gcColTotLinea.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColTotLinea.OptionsColumn.ReadOnly = true;
            this.col_gcColTotLinea.OptionsFilter.AllowAutoFilter = false;
            this.col_gcColTotLinea.OptionsFilter.AllowFilter = false;
            this.col_gcColTotLinea.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColTotLinea.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.col_gcColTotLinea.ToolTip = "TotalGramos*CostoGramo*Tiraje";
            this.col_gcColTotLinea.Visible = true;
            this.col_gcColTotLinea.VisibleIndex = 9;
            // 
            // col_gcColDetallePAG
            // 
            this.col_gcColDetallePAG.Caption = "Detalle PAG";
            this.col_gcColDetallePAG.FieldName = "DetallePag";
            this.col_gcColDetallePAG.Name = "col_gcColDetallePAG";
            this.col_gcColDetallePAG.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColDetallePAG.OptionsColumn.AllowIncrementalSearch = false;
            this.col_gcColDetallePAG.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColDetallePAG.OptionsColumn.AllowMove = false;
            this.col_gcColDetallePAG.OptionsColumn.AllowShowHide = false;
            this.col_gcColDetallePAG.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColDetallePAG.OptionsFilter.AllowAutoFilter = false;
            this.col_gcColDetallePAG.OptionsFilter.AllowFilter = false;
            this.col_gcColDetallePAG.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.col_gcColDetallePAG.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.col_gcColDetallePAG.Visible = true;
            this.col_gcColDetallePAG.VisibleIndex = 10;
            this.col_gcColDetallePAG.Width = 150;
            // 
            // dis_xtpPlacas
            // 
            this.dis_xtpPlacas.Controls.Add(this.pla_gcPlacas);
            this.dis_xtpPlacas.Name = "dis_xtpPlacas";
            this.dis_xtpPlacas.Size = new System.Drawing.Size(844, 242);
            this.dis_xtpPlacas.Text = "Placas";
            // 
            // pla_gcPlacas
            // 
            this.pla_gcPlacas.Location = new System.Drawing.Point(7, 4);
            this.pla_gcPlacas.MainView = this.pla_gvPlacas;
            this.pla_gcPlacas.Name = "pla_gcPlacas";
            this.pla_gcPlacas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dis_rilueLadoImpresionP,
            this.dis_riseNumColores});
            this.pla_gcPlacas.Size = new System.Drawing.Size(834, 235);
            this.pla_gcPlacas.TabIndex = 0;
            this.pla_gcPlacas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.pla_gvPlacas});
            // 
            // pla_gvPlacas
            // 
            this.pla_gvPlacas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.pla_gcColMaterialP,
            this.pla_gcColPlacaP,
            this.pla_gcColLadoP,
            this.pla_gcColNumColoresP,
            this.pla_gcColNumPaginasP,
            this.pla_gcColPaginasXplaca,
            this.pla_gcColPlacasMIN,
            this.pla_gcColNumPlacasP,
            this.pla_gcColCostoPlaca,
            this.pla_gcTotalLineaP});
            this.pla_gvPlacas.GridControl = this.pla_gcPlacas;
            this.pla_gvPlacas.Name = "pla_gvPlacas";
            this.pla_gvPlacas.OptionsView.ShowFooter = true;
            this.pla_gvPlacas.OptionsView.ShowGroupPanel = false;
            this.pla_gvPlacas.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.dis_gvPlacas_CellValueChanged);
            // 
            // pla_gcColMaterialP
            // 
            this.pla_gcColMaterialP.Caption = "Material";
            this.pla_gcColMaterialP.FieldName = "Material";
            this.pla_gcColMaterialP.Name = "pla_gcColMaterialP";
            this.pla_gcColMaterialP.OptionsColumn.AllowEdit = false;
            this.pla_gcColMaterialP.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColMaterialP.OptionsColumn.AllowIncrementalSearch = false;
            this.pla_gcColMaterialP.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColMaterialP.OptionsColumn.AllowMove = false;
            this.pla_gcColMaterialP.OptionsColumn.AllowShowHide = false;
            this.pla_gcColMaterialP.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColMaterialP.OptionsColumn.ReadOnly = true;
            this.pla_gcColMaterialP.OptionsFilter.AllowAutoFilter = false;
            this.pla_gcColMaterialP.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColMaterialP.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColMaterialP.ToolTip = "Material para el cual va hacer utilizada la placa";
            this.pla_gcColMaterialP.Visible = true;
            this.pla_gcColMaterialP.VisibleIndex = 0;
            this.pla_gcColMaterialP.Width = 158;
            // 
            // pla_gcColPlacaP
            // 
            this.pla_gcColPlacaP.Caption = "Máquina";
            this.pla_gcColPlacaP.FieldName = "Placa";
            this.pla_gcColPlacaP.Name = "pla_gcColPlacaP";
            this.pla_gcColPlacaP.OptionsColumn.AllowEdit = false;
            this.pla_gcColPlacaP.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColPlacaP.OptionsColumn.AllowIncrementalSearch = false;
            this.pla_gcColPlacaP.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColPlacaP.OptionsColumn.AllowMove = false;
            this.pla_gcColPlacaP.OptionsColumn.AllowShowHide = false;
            this.pla_gcColPlacaP.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColPlacaP.OptionsColumn.ReadOnly = true;
            this.pla_gcColPlacaP.OptionsFilter.AllowAutoFilter = false;
            this.pla_gcColPlacaP.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColPlacaP.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColPlacaP.ToolTip = "Placa que se va a utilizar";
            this.pla_gcColPlacaP.Visible = true;
            this.pla_gcColPlacaP.VisibleIndex = 1;
            this.pla_gcColPlacaP.Width = 67;
            // 
            // pla_gcColLadoP
            // 
            this.pla_gcColLadoP.Caption = "Lado";
            this.pla_gcColLadoP.ColumnEdit = this.dis_rilueLadoImpresionP;
            this.pla_gcColLadoP.FieldName = "LadoPlaca";
            this.pla_gcColLadoP.Name = "pla_gcColLadoP";
            this.pla_gcColLadoP.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColLadoP.OptionsColumn.AllowIncrementalSearch = false;
            this.pla_gcColLadoP.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColLadoP.OptionsColumn.AllowMove = false;
            this.pla_gcColLadoP.OptionsColumn.AllowShowHide = false;
            this.pla_gcColLadoP.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColLadoP.OptionsFilter.AllowAutoFilter = false;
            this.pla_gcColLadoP.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColLadoP.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColLadoP.ToolTip = "Lado de impresión de la placa";
            this.pla_gcColLadoP.Visible = true;
            this.pla_gcColLadoP.VisibleIndex = 2;
            this.pla_gcColLadoP.Width = 109;
            // 
            // dis_rilueLadoImpresionP
            // 
            this.dis_rilueLadoImpresionP.AutoHeight = false;
            this.dis_rilueLadoImpresionP.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dis_rilueLadoImpresionP.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Lado")});
            this.dis_rilueLadoImpresionP.DisplayMember = "Descripcion";
            this.dis_rilueLadoImpresionP.Name = "dis_rilueLadoImpresionP";
            this.dis_rilueLadoImpresionP.NullText = "";
            this.dis_rilueLadoImpresionP.ValueMember = "Codigo";
            // 
            // pla_gcColNumColoresP
            // 
            this.pla_gcColNumColoresP.AppearanceCell.Options.UseTextOptions = true;
            this.pla_gcColNumColoresP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.pla_gcColNumColoresP.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.pla_gcColNumColoresP.Caption = "N° Colores";
            this.pla_gcColNumColoresP.ColumnEdit = this.dis_riseNumColores;
            this.pla_gcColNumColoresP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pla_gcColNumColoresP.FieldName = "NumColores";
            this.pla_gcColNumColoresP.Name = "pla_gcColNumColoresP";
            this.pla_gcColNumColoresP.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColNumColoresP.OptionsColumn.AllowIncrementalSearch = false;
            this.pla_gcColNumColoresP.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColNumColoresP.OptionsColumn.AllowMove = false;
            this.pla_gcColNumColoresP.OptionsColumn.AllowShowHide = false;
            this.pla_gcColNumColoresP.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColNumColoresP.OptionsFilter.AllowAutoFilter = false;
            this.pla_gcColNumColoresP.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColNumColoresP.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColNumColoresP.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NumColores", "{0:N2}")});
            this.pla_gcColNumColoresP.ToolTip = "Número de colores a utilizar (Valor entre 1-8)";
            this.pla_gcColNumColoresP.Visible = true;
            this.pla_gcColNumColoresP.VisibleIndex = 3;
            this.pla_gcColNumColoresP.Width = 79;
            // 
            // dis_riseNumColores
            // 
            this.dis_riseNumColores.AutoHeight = false;
            this.dis_riseNumColores.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dis_riseNumColores.MaxLength = 2;
            this.dis_riseNumColores.MaxValue = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.dis_riseNumColores.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dis_riseNumColores.Name = "dis_riseNumColores";
            // 
            // pla_gcColNumPaginasP
            // 
            this.pla_gcColNumPaginasP.Caption = "Páginas";
            this.pla_gcColNumPaginasP.FieldName = "NumPaginas";
            this.pla_gcColNumPaginasP.Name = "pla_gcColNumPaginasP";
            this.pla_gcColNumPaginasP.OptionsColumn.AllowEdit = false;
            this.pla_gcColNumPaginasP.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColNumPaginasP.OptionsColumn.AllowIncrementalSearch = false;
            this.pla_gcColNumPaginasP.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColNumPaginasP.OptionsColumn.AllowMove = false;
            this.pla_gcColNumPaginasP.OptionsColumn.AllowShowHide = false;
            this.pla_gcColNumPaginasP.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColNumPaginasP.OptionsColumn.ReadOnly = true;
            this.pla_gcColNumPaginasP.OptionsFilter.AllowAutoFilter = false;
            this.pla_gcColNumPaginasP.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColNumPaginasP.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColNumPaginasP.ToolTip = "Número de paginas a imprimir. (Recupera de la fila de los armados)";
            this.pla_gcColNumPaginasP.Visible = true;
            this.pla_gcColNumPaginasP.VisibleIndex = 4;
            // 
            // pla_gcColPaginasXplaca
            // 
            this.pla_gcColPaginasXplaca.Caption = "Pag X Placa";
            this.pla_gcColPaginasXplaca.FieldName = "PaginasXplaca";
            this.pla_gcColPaginasXplaca.Name = "pla_gcColPaginasXplaca";
            this.pla_gcColPaginasXplaca.OptionsColumn.AllowEdit = false;
            this.pla_gcColPaginasXplaca.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColPaginasXplaca.OptionsColumn.AllowIncrementalSearch = false;
            this.pla_gcColPaginasXplaca.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColPaginasXplaca.OptionsColumn.AllowMove = false;
            this.pla_gcColPaginasXplaca.OptionsColumn.AllowShowHide = false;
            this.pla_gcColPaginasXplaca.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColPaginasXplaca.OptionsColumn.ReadOnly = true;
            this.pla_gcColPaginasXplaca.OptionsFilter.AllowAutoFilter = false;
            this.pla_gcColPaginasXplaca.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColPaginasXplaca.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColPaginasXplaca.ToolTip = "Número de páginas que se imprimen en una placa";
            this.pla_gcColPaginasXplaca.Visible = true;
            this.pla_gcColPaginasXplaca.VisibleIndex = 5;
            this.pla_gcColPaginasXplaca.Width = 84;
            // 
            // pla_gcColPlacasMIN
            // 
            this.pla_gcColPlacasMIN.Caption = "Placas MIN";
            this.pla_gcColPlacasMIN.FieldName = "NumPlacasMIN";
            this.pla_gcColPlacasMIN.Name = "pla_gcColPlacasMIN";
            this.pla_gcColPlacasMIN.OptionsColumn.AllowEdit = false;
            this.pla_gcColPlacasMIN.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColPlacasMIN.OptionsColumn.AllowIncrementalSearch = false;
            this.pla_gcColPlacasMIN.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColPlacasMIN.OptionsColumn.AllowMove = false;
            this.pla_gcColPlacasMIN.OptionsColumn.AllowShowHide = false;
            this.pla_gcColPlacasMIN.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColPlacasMIN.OptionsColumn.ReadOnly = true;
            this.pla_gcColPlacasMIN.OptionsFilter.AllowAutoFilter = false;
            this.pla_gcColPlacasMIN.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColPlacasMIN.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColPlacasMIN.ToolTip = "Mínimo de placas sugerido por sistema (NroPlacas/PáginasXplaca)";
            this.pla_gcColPlacasMIN.Visible = true;
            this.pla_gcColPlacasMIN.VisibleIndex = 6;
            // 
            // pla_gcColNumPlacasP
            // 
            this.pla_gcColNumPlacasP.Caption = "N° Placas";
            this.pla_gcColNumPlacasP.FieldName = "NumPlacas";
            this.pla_gcColNumPlacasP.Name = "pla_gcColNumPlacasP";
            this.pla_gcColNumPlacasP.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColNumPlacasP.OptionsColumn.AllowIncrementalSearch = false;
            this.pla_gcColNumPlacasP.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColNumPlacasP.OptionsColumn.AllowMove = false;
            this.pla_gcColNumPlacasP.OptionsColumn.AllowShowHide = false;
            this.pla_gcColNumPlacasP.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColNumPlacasP.OptionsFilter.AllowAutoFilter = false;
            this.pla_gcColNumPlacasP.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColNumPlacasP.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColNumPlacasP.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NumPlacas", "{0:N2}")});
            this.pla_gcColNumPlacasP.ToolTip = "Número de placas registradas por el usuario (Mayor o igual al mínimo de placas su" +
    "gerido)";
            this.pla_gcColNumPlacasP.Visible = true;
            this.pla_gcColNumPlacasP.VisibleIndex = 7;
            this.pla_gcColNumPlacasP.Width = 77;
            // 
            // pla_gcColCostoPlaca
            // 
            this.pla_gcColCostoPlaca.Caption = "Costo";
            this.pla_gcColCostoPlaca.DisplayFormat.FormatString = "N2";
            this.pla_gcColCostoPlaca.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pla_gcColCostoPlaca.FieldName = "CostoPlaca";
            this.pla_gcColCostoPlaca.Name = "pla_gcColCostoPlaca";
            this.pla_gcColCostoPlaca.OptionsColumn.AllowEdit = false;
            this.pla_gcColCostoPlaca.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColCostoPlaca.OptionsColumn.AllowIncrementalSearch = false;
            this.pla_gcColCostoPlaca.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColCostoPlaca.OptionsColumn.AllowMove = false;
            this.pla_gcColCostoPlaca.OptionsColumn.AllowShowHide = false;
            this.pla_gcColCostoPlaca.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColCostoPlaca.OptionsColumn.ReadOnly = true;
            this.pla_gcColCostoPlaca.OptionsFilter.AllowAutoFilter = false;
            this.pla_gcColCostoPlaca.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColCostoPlaca.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcColCostoPlaca.ToolTip = "Costo aproximado de la placa viene de la BD";
            this.pla_gcColCostoPlaca.Visible = true;
            this.pla_gcColCostoPlaca.VisibleIndex = 8;
            // 
            // pla_gcTotalLineaP
            // 
            this.pla_gcTotalLineaP.Caption = "Total";
            this.pla_gcTotalLineaP.DisplayFormat.FormatString = "N2";
            this.pla_gcTotalLineaP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pla_gcTotalLineaP.FieldName = "TotalLinea";
            this.pla_gcTotalLineaP.Name = "pla_gcTotalLineaP";
            this.pla_gcTotalLineaP.OptionsColumn.AllowEdit = false;
            this.pla_gcTotalLineaP.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcTotalLineaP.OptionsColumn.AllowIncrementalSearch = false;
            this.pla_gcTotalLineaP.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcTotalLineaP.OptionsColumn.AllowMove = false;
            this.pla_gcTotalLineaP.OptionsColumn.AllowShowHide = false;
            this.pla_gcTotalLineaP.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcTotalLineaP.OptionsColumn.ReadOnly = true;
            this.pla_gcTotalLineaP.OptionsFilter.AllowAutoFilter = false;
            this.pla_gcTotalLineaP.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcTotalLineaP.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.pla_gcTotalLineaP.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalLinea", "{0:N2}")});
            this.pla_gcTotalLineaP.ToolTip = "NumeroColores*NumeroPlacas*CostoPlaca";
            this.pla_gcTotalLineaP.Visible = true;
            this.pla_gcTotalLineaP.VisibleIndex = 9;
            this.pla_gcTotalLineaP.Width = 92;
            // 
            // dis_xtpTroquel
            // 
            this.dis_xtpTroquel.Controls.Add(this.tro_gcTrqouel);
            this.dis_xtpTroquel.Name = "dis_xtpTroquel";
            this.dis_xtpTroquel.Size = new System.Drawing.Size(844, 242);
            this.dis_xtpTroquel.Text = "Troquel";
            // 
            // tro_gcTrqouel
            // 
            this.tro_gcTrqouel.ContextMenuStrip = this.cmDisenoTroquel;
            this.tro_gcTrqouel.Location = new System.Drawing.Point(7, 4);
            this.tro_gcTrqouel.MainView = this.tro_gvTroquel;
            this.tro_gcTrqouel.Name = "tro_gcTrqouel";
            this.tro_gcTrqouel.Size = new System.Drawing.Size(834, 235);
            this.tro_gcTrqouel.TabIndex = 0;
            this.tro_gcTrqouel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tro_gvTroquel});
            // 
            // cmDisenoTroquel
            // 
            this.cmDisenoTroquel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAgregaRegTroquel,
            this.mnuEliminaRegTroquel});
            this.cmDisenoTroquel.Name = "cmDisenoTroquel";
            this.cmDisenoTroquel.Size = new System.Drawing.Size(220, 48);
            // 
            // mnuAgregaRegTroquel
            // 
            this.mnuAgregaRegTroquel.Name = "mnuAgregaRegTroquel";
            this.mnuAgregaRegTroquel.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuAgregaRegTroquel.Size = new System.Drawing.Size(219, 22);
            this.mnuAgregaRegTroquel.Text = "Agregar Registro";
            this.mnuAgregaRegTroquel.Click += new System.EventHandler(this.mnuAgregaRegTroquel_Click);
            // 
            // mnuEliminaRegTroquel
            // 
            this.mnuEliminaRegTroquel.Name = "mnuEliminaRegTroquel";
            this.mnuEliminaRegTroquel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.mnuEliminaRegTroquel.Size = new System.Drawing.Size(219, 22);
            this.mnuEliminaRegTroquel.Text = "Eliminar Registro";
            this.mnuEliminaRegTroquel.Click += new System.EventHandler(this.mnuEliminaRegTroquel_Click);
            // 
            // tro_gvTroquel
            // 
            this.tro_gvTroquel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.tro_gcColMaterialT,
            this.tro_gcColLongitud,
            this.tro_gcColNumCortesT,
            this.tro_gcColCostoCorteT,
            this.tro_gcColTotaLineaT});
            this.tro_gvTroquel.GridControl = this.tro_gcTrqouel;
            this.tro_gvTroquel.Name = "tro_gvTroquel";
            this.tro_gvTroquel.OptionsView.ShowFooter = true;
            this.tro_gvTroquel.OptionsView.ShowGroupPanel = false;
            // 
            // tro_gcColMaterialT
            // 
            this.tro_gcColMaterialT.Caption = "Material";
            this.tro_gcColMaterialT.FieldName = "Material";
            this.tro_gcColMaterialT.Name = "tro_gcColMaterialT";
            this.tro_gcColMaterialT.OptionsColumn.AllowEdit = false;
            this.tro_gcColMaterialT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColMaterialT.OptionsColumn.AllowIncrementalSearch = false;
            this.tro_gcColMaterialT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColMaterialT.OptionsColumn.AllowMove = false;
            this.tro_gcColMaterialT.OptionsColumn.AllowShowHide = false;
            this.tro_gcColMaterialT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColMaterialT.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColMaterialT.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColMaterialT.OptionsColumn.ReadOnly = true;
            this.tro_gcColMaterialT.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColMaterialT.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColMaterialT.ToolTip = "Material al cual se va a aplicar el corte (Viene de los armados)";
            this.tro_gcColMaterialT.Visible = true;
            this.tro_gcColMaterialT.VisibleIndex = 0;
            // 
            // tro_gcColLongitud
            // 
            this.tro_gcColLongitud.Caption = "Longitud";
            this.tro_gcColLongitud.DisplayFormat.FormatString = "N2";
            this.tro_gcColLongitud.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tro_gcColLongitud.FieldName = "Longitud";
            this.tro_gcColLongitud.Name = "tro_gcColLongitud";
            this.tro_gcColLongitud.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColLongitud.OptionsColumn.AllowIncrementalSearch = false;
            this.tro_gcColLongitud.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColLongitud.OptionsColumn.AllowMove = false;
            this.tro_gcColLongitud.OptionsColumn.AllowShowHide = false;
            this.tro_gcColLongitud.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColLongitud.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColLongitud.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColLongitud.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColLongitud.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColLongitud.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Longitud", "{0:N2}")});
            this.tro_gcColLongitud.ToolTip = "Suma de todas las longitudes de los cortes que se van a aplicar al material";
            this.tro_gcColLongitud.Visible = true;
            this.tro_gcColLongitud.VisibleIndex = 1;
            // 
            // tro_gcColNumCortesT
            // 
            this.tro_gcColNumCortesT.Caption = "Cortes";
            this.tro_gcColNumCortesT.FieldName = "NumCortes";
            this.tro_gcColNumCortesT.Name = "tro_gcColNumCortesT";
            this.tro_gcColNumCortesT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColNumCortesT.OptionsColumn.AllowIncrementalSearch = false;
            this.tro_gcColNumCortesT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColNumCortesT.OptionsColumn.AllowMove = false;
            this.tro_gcColNumCortesT.OptionsColumn.AllowShowHide = false;
            this.tro_gcColNumCortesT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColNumCortesT.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColNumCortesT.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColNumCortesT.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColNumCortesT.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColNumCortesT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NumCortes", "{0:N2}")});
            this.tro_gcColNumCortesT.ToolTip = "Número de cortes que se van a realizar";
            this.tro_gcColNumCortesT.Visible = true;
            this.tro_gcColNumCortesT.VisibleIndex = 2;
            // 
            // tro_gcColCostoCorteT
            // 
            this.tro_gcColCostoCorteT.Caption = "Costo";
            this.tro_gcColCostoCorteT.DisplayFormat.FormatString = "N2";
            this.tro_gcColCostoCorteT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tro_gcColCostoCorteT.FieldName = "CostoCorte";
            this.tro_gcColCostoCorteT.Name = "tro_gcColCostoCorteT";
            this.tro_gcColCostoCorteT.OptionsColumn.AllowEdit = false;
            this.tro_gcColCostoCorteT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColCostoCorteT.OptionsColumn.AllowIncrementalSearch = false;
            this.tro_gcColCostoCorteT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColCostoCorteT.OptionsColumn.AllowMove = false;
            this.tro_gcColCostoCorteT.OptionsColumn.AllowShowHide = false;
            this.tro_gcColCostoCorteT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColCostoCorteT.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColCostoCorteT.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColCostoCorteT.OptionsColumn.ReadOnly = true;
            this.tro_gcColCostoCorteT.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColCostoCorteT.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColCostoCorteT.ToolTip = "Costo aproximado de cada corte (Viene de la Base de datos)";
            this.tro_gcColCostoCorteT.Visible = true;
            this.tro_gcColCostoCorteT.VisibleIndex = 3;
            // 
            // tro_gcColTotaLineaT
            // 
            this.tro_gcColTotaLineaT.Caption = "Total";
            this.tro_gcColTotaLineaT.DisplayFormat.FormatString = "N2";
            this.tro_gcColTotaLineaT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tro_gcColTotaLineaT.FieldName = "TotalLinea";
            this.tro_gcColTotaLineaT.Name = "tro_gcColTotaLineaT";
            this.tro_gcColTotaLineaT.OptionsColumn.AllowEdit = false;
            this.tro_gcColTotaLineaT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColTotaLineaT.OptionsColumn.AllowIncrementalSearch = false;
            this.tro_gcColTotaLineaT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColTotaLineaT.OptionsColumn.AllowMove = false;
            this.tro_gcColTotaLineaT.OptionsColumn.AllowShowHide = false;
            this.tro_gcColTotaLineaT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColTotaLineaT.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColTotaLineaT.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColTotaLineaT.OptionsColumn.ReadOnly = true;
            this.tro_gcColTotaLineaT.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColTotaLineaT.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.tro_gcColTotaLineaT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalLinea", "{0:N2}")});
            this.tro_gcColTotaLineaT.ToolTip = "Longitud*NumCortes*CostoCorte";
            this.tro_gcColTotaLineaT.Visible = true;
            this.tro_gcColTotaLineaT.VisibleIndex = 4;
            // 
            // dis_xtpAcabados
            // 
            this.dis_xtpAcabados.Controls.Add(this.aca_gcAcabados);
            this.dis_xtpAcabados.Name = "dis_xtpAcabados";
            this.dis_xtpAcabados.Size = new System.Drawing.Size(844, 242);
            this.dis_xtpAcabados.Text = "Acabados";
            // 
            // aca_gcAcabados
            // 
            this.aca_gcAcabados.ContextMenuStrip = this.cmDisenoAcabado;
            this.aca_gcAcabados.Location = new System.Drawing.Point(7, 4);
            this.aca_gcAcabados.MainView = this.aca_gvAcabados;
            this.aca_gcAcabados.Name = "aca_gcAcabados";
            this.aca_gcAcabados.Size = new System.Drawing.Size(834, 235);
            this.aca_gcAcabados.TabIndex = 0;
            this.aca_gcAcabados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.aca_gvAcabados});
            // 
            // cmDisenoAcabado
            // 
            this.cmDisenoAcabado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dis_mnuAgregaRegistro,
            this.mnuAgregaAcabado,
            this.dis_mnuEliminaRegistro});
            this.cmDisenoAcabado.Name = "cmDisenoAcabado";
            this.cmDisenoAcabado.Size = new System.Drawing.Size(220, 70);
            // 
            // dis_mnuAgregaRegistro
            // 
            this.dis_mnuAgregaRegistro.Name = "dis_mnuAgregaRegistro";
            this.dis_mnuAgregaRegistro.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.dis_mnuAgregaRegistro.Size = new System.Drawing.Size(219, 22);
            this.dis_mnuAgregaRegistro.Text = "Agregar Registro";
            this.dis_mnuAgregaRegistro.Click += new System.EventHandler(this.dis_mnuAgregaRegistro_Click);
            // 
            // mnuAgregaAcabado
            // 
            this.mnuAgregaAcabado.Name = "mnuAgregaAcabado";
            this.mnuAgregaAcabado.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.mnuAgregaAcabado.Size = new System.Drawing.Size(219, 22);
            this.mnuAgregaAcabado.Text = "Agrega Acabado";
            this.mnuAgregaAcabado.Click += new System.EventHandler(this.mnuAgregaAcabado_Click);
            // 
            // dis_mnuEliminaRegistro
            // 
            this.dis_mnuEliminaRegistro.Name = "dis_mnuEliminaRegistro";
            this.dis_mnuEliminaRegistro.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.dis_mnuEliminaRegistro.Size = new System.Drawing.Size(219, 22);
            this.dis_mnuEliminaRegistro.Text = "Eliminar Registro";
            this.dis_mnuEliminaRegistro.Click += new System.EventHandler(this.dis_mnuEliminaRegistro_Click);
            // 
            // aca_gvAcabados
            // 
            this.aca_gvAcabados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.aca_gcColMaterialA,
            this.aca_gcColAreaA,
            this.aca_gcColAcabadoA,
            this.aca_gcColMatAcabado,
            this.aca_gcColCostoA,
            this.aca_gcColAplicaA,
            this.aca_gcColTotalLineaA});
            this.aca_gvAcabados.GridControl = this.aca_gcAcabados;
            this.aca_gvAcabados.Name = "aca_gvAcabados";
            this.aca_gvAcabados.OptionsView.ShowFooter = true;
            this.aca_gvAcabados.OptionsView.ShowGroupPanel = false;
            // 
            // aca_gcColMaterialA
            // 
            this.aca_gcColMaterialA.Caption = "Material Armado";
            this.aca_gcColMaterialA.FieldName = "Material";
            this.aca_gcColMaterialA.Name = "aca_gcColMaterialA";
            this.aca_gcColMaterialA.OptionsColumn.AllowEdit = false;
            this.aca_gcColMaterialA.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColMaterialA.OptionsColumn.AllowIncrementalSearch = false;
            this.aca_gcColMaterialA.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColMaterialA.OptionsColumn.AllowMove = false;
            this.aca_gcColMaterialA.OptionsColumn.AllowShowHide = false;
            this.aca_gcColMaterialA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColMaterialA.Visible = true;
            this.aca_gcColMaterialA.VisibleIndex = 0;
            this.aca_gcColMaterialA.Width = 181;
            // 
            // aca_gcColAreaA
            // 
            this.aca_gcColAreaA.Caption = "Area";
            this.aca_gcColAreaA.DisplayFormat.FormatString = "N2";
            this.aca_gcColAreaA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.aca_gcColAreaA.FieldName = "Area";
            this.aca_gcColAreaA.Name = "aca_gcColAreaA";
            this.aca_gcColAreaA.OptionsColumn.AllowEdit = false;
            this.aca_gcColAreaA.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColAreaA.OptionsColumn.AllowIncrementalSearch = false;
            this.aca_gcColAreaA.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColAreaA.OptionsColumn.AllowMove = false;
            this.aca_gcColAreaA.OptionsColumn.AllowShowHide = false;
            this.aca_gcColAreaA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColAreaA.Visible = true;
            this.aca_gcColAreaA.VisibleIndex = 1;
            this.aca_gcColAreaA.Width = 69;
            // 
            // aca_gcColAcabadoA
            // 
            this.aca_gcColAcabadoA.Caption = "Acabado";
            this.aca_gcColAcabadoA.FieldName = "Acabado";
            this.aca_gcColAcabadoA.Name = "aca_gcColAcabadoA";
            this.aca_gcColAcabadoA.OptionsColumn.AllowEdit = false;
            this.aca_gcColAcabadoA.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColAcabadoA.OptionsColumn.AllowIncrementalSearch = false;
            this.aca_gcColAcabadoA.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColAcabadoA.OptionsColumn.AllowMove = false;
            this.aca_gcColAcabadoA.OptionsColumn.AllowShowHide = false;
            this.aca_gcColAcabadoA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColAcabadoA.Visible = true;
            this.aca_gcColAcabadoA.VisibleIndex = 2;
            this.aca_gcColAcabadoA.Width = 131;
            // 
            // aca_gcColMatAcabado
            // 
            this.aca_gcColMatAcabado.Caption = "Material Acabado";
            this.aca_gcColMatAcabado.FieldName = "AcabadoMaterial";
            this.aca_gcColMatAcabado.Name = "aca_gcColMatAcabado";
            this.aca_gcColMatAcabado.OptionsColumn.AllowEdit = false;
            this.aca_gcColMatAcabado.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColMatAcabado.OptionsColumn.AllowIncrementalSearch = false;
            this.aca_gcColMatAcabado.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColMatAcabado.OptionsColumn.AllowMove = false;
            this.aca_gcColMatAcabado.OptionsColumn.AllowShowHide = false;
            this.aca_gcColMatAcabado.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColMatAcabado.OptionsFilter.AllowAutoFilter = false;
            this.aca_gcColMatAcabado.Visible = true;
            this.aca_gcColMatAcabado.VisibleIndex = 3;
            this.aca_gcColMatAcabado.Width = 205;
            // 
            // aca_gcColCostoA
            // 
            this.aca_gcColCostoA.Caption = "Costo";
            this.aca_gcColCostoA.DisplayFormat.FormatString = "N2";
            this.aca_gcColCostoA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.aca_gcColCostoA.FieldName = "Costo";
            this.aca_gcColCostoA.Name = "aca_gcColCostoA";
            this.aca_gcColCostoA.OptionsColumn.AllowEdit = false;
            this.aca_gcColCostoA.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColCostoA.OptionsColumn.AllowIncrementalSearch = false;
            this.aca_gcColCostoA.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColCostoA.OptionsColumn.AllowMove = false;
            this.aca_gcColCostoA.OptionsColumn.AllowShowHide = false;
            this.aca_gcColCostoA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColCostoA.Visible = true;
            this.aca_gcColCostoA.VisibleIndex = 5;
            this.aca_gcColCostoA.Width = 64;
            // 
            // aca_gcColAplicaA
            // 
            this.aca_gcColAplicaA.Caption = "Aplica";
            this.aca_gcColAplicaA.FieldName = "areaAplica";
            this.aca_gcColAplicaA.Name = "aca_gcColAplicaA";
            this.aca_gcColAplicaA.OptionsColumn.AllowEdit = false;
            this.aca_gcColAplicaA.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColAplicaA.OptionsColumn.AllowIncrementalSearch = false;
            this.aca_gcColAplicaA.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColAplicaA.OptionsColumn.AllowMove = false;
            this.aca_gcColAplicaA.OptionsColumn.AllowShowHide = false;
            this.aca_gcColAplicaA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColAplicaA.Visible = true;
            this.aca_gcColAplicaA.VisibleIndex = 4;
            this.aca_gcColAplicaA.Width = 60;
            // 
            // aca_gcColTotalLineaA
            // 
            this.aca_gcColTotalLineaA.Caption = "Total";
            this.aca_gcColTotalLineaA.DisplayFormat.FormatString = "N2";
            this.aca_gcColTotalLineaA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.aca_gcColTotalLineaA.FieldName = "TotalLinea";
            this.aca_gcColTotalLineaA.Name = "aca_gcColTotalLineaA";
            this.aca_gcColTotalLineaA.OptionsColumn.AllowEdit = false;
            this.aca_gcColTotalLineaA.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColTotalLineaA.OptionsColumn.AllowIncrementalSearch = false;
            this.aca_gcColTotalLineaA.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColTotalLineaA.OptionsColumn.AllowMove = false;
            this.aca_gcColTotalLineaA.OptionsColumn.AllowShowHide = false;
            this.aca_gcColTotalLineaA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColTotalLineaA.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalLinea", "{0:N2}")});
            this.aca_gcColTotalLineaA.Visible = true;
            this.aca_gcColTotalLineaA.VisibleIndex = 6;
            this.aca_gcColTotalLineaA.Width = 106;
            // 
            // dis_xtpAccesorios
            // 
            this.dis_xtpAccesorios.Controls.Add(this.acce_gcAccesorios);
            this.dis_xtpAccesorios.Name = "dis_xtpAccesorios";
            this.dis_xtpAccesorios.Size = new System.Drawing.Size(844, 242);
            this.dis_xtpAccesorios.Text = "Accesorios";
            // 
            // acce_gcAccesorios
            // 
            this.acce_gcAccesorios.ContextMenuStrip = this.cmDisenoAccesorios;
            this.acce_gcAccesorios.Location = new System.Drawing.Point(7, 4);
            this.acce_gcAccesorios.MainView = this.acce_gvAccesorios;
            this.acce_gcAccesorios.Name = "acce_gcAccesorios";
            this.acce_gcAccesorios.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dis_riseCantAccesorio});
            this.acce_gcAccesorios.Size = new System.Drawing.Size(834, 235);
            this.acce_gcAccesorios.TabIndex = 0;
            this.acce_gcAccesorios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.acce_gvAccesorios});
            // 
            // cmDisenoAccesorios
            // 
            this.cmDisenoAccesorios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAgregaAccesorio,
            this.mnuEliminaAccesorio});
            this.cmDisenoAccesorios.Name = "cmDisenoAccesorios";
            this.cmDisenoAccesorios.Size = new System.Drawing.Size(220, 48);
            // 
            // mnuAgregaAccesorio
            // 
            this.mnuAgregaAccesorio.Name = "mnuAgregaAccesorio";
            this.mnuAgregaAccesorio.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuAgregaAccesorio.Size = new System.Drawing.Size(219, 22);
            this.mnuAgregaAccesorio.Text = "Agregar Accesorios";
            this.mnuAgregaAccesorio.Click += new System.EventHandler(this.mnuAgregaAccesorio_Click);
            // 
            // mnuEliminaAccesorio
            // 
            this.mnuEliminaAccesorio.Name = "mnuEliminaAccesorio";
            this.mnuEliminaAccesorio.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.mnuEliminaAccesorio.Size = new System.Drawing.Size(219, 22);
            this.mnuEliminaAccesorio.Text = "Eliminar Registro";
            this.mnuEliminaAccesorio.Click += new System.EventHandler(this.mnuEliminaAccesorio_Click);
            // 
            // acce_gvAccesorios
            // 
            this.acce_gvAccesorios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.acce_gcColMaterialS,
            this.acce_gcColTirajeS,
            this.acce_gcColCantidadS,
            this.acce_gcColCostoS,
            this.acce_gcColTotalLineaS});
            this.acce_gvAccesorios.GridControl = this.acce_gcAccesorios;
            this.acce_gvAccesorios.Name = "acce_gvAccesorios";
            this.acce_gvAccesorios.OptionsView.ShowFooter = true;
            this.acce_gvAccesorios.OptionsView.ShowGroupPanel = false;
            // 
            // acce_gcColMaterialS
            // 
            this.acce_gcColMaterialS.Caption = "Descripción";
            this.acce_gcColMaterialS.FieldName = "Material";
            this.acce_gcColMaterialS.Name = "acce_gcColMaterialS";
            this.acce_gcColMaterialS.OptionsColumn.AllowEdit = false;
            this.acce_gcColMaterialS.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.acce_gcColMaterialS.OptionsColumn.AllowIncrementalSearch = false;
            this.acce_gcColMaterialS.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.acce_gcColMaterialS.OptionsColumn.AllowMove = false;
            this.acce_gcColMaterialS.OptionsColumn.AllowShowHide = false;
            this.acce_gcColMaterialS.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.acce_gcColMaterialS.OptionsColumn.ReadOnly = true;
            this.acce_gcColMaterialS.OptionsFilter.AllowAutoFilter = false;
            this.acce_gcColMaterialS.ToolTip = "Descripción del accesorio";
            this.acce_gcColMaterialS.Visible = true;
            this.acce_gcColMaterialS.VisibleIndex = 0;
            this.acce_gcColMaterialS.Width = 436;
            // 
            // acce_gcColTirajeS
            // 
            this.acce_gcColTirajeS.Caption = "Tiraje";
            this.acce_gcColTirajeS.DisplayFormat.FormatString = "N0";
            this.acce_gcColTirajeS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.acce_gcColTirajeS.FieldName = "Tiraje";
            this.acce_gcColTirajeS.Name = "acce_gcColTirajeS";
            this.acce_gcColTirajeS.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.acce_gcColTirajeS.OptionsColumn.AllowIncrementalSearch = false;
            this.acce_gcColTirajeS.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.acce_gcColTirajeS.OptionsColumn.AllowMove = false;
            this.acce_gcColTirajeS.OptionsColumn.AllowShowHide = false;
            this.acce_gcColTirajeS.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.acce_gcColTirajeS.OptionsFilter.AllowAutoFilter = false;
            this.acce_gcColTirajeS.ToolTip = "Cantidad de items que se va a producir";
            this.acce_gcColTirajeS.Visible = true;
            this.acce_gcColTirajeS.VisibleIndex = 1;
            this.acce_gcColTirajeS.Width = 138;
            // 
            // acce_gcColCantidadS
            // 
            this.acce_gcColCantidadS.Caption = "Cantidad";
            this.acce_gcColCantidadS.ColumnEdit = this.dis_riseCantAccesorio;
            this.acce_gcColCantidadS.DisplayFormat.FormatString = "N2";
            this.acce_gcColCantidadS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.acce_gcColCantidadS.FieldName = "Cantidad";
            this.acce_gcColCantidadS.Name = "acce_gcColCantidadS";
            this.acce_gcColCantidadS.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.acce_gcColCantidadS.OptionsColumn.AllowIncrementalSearch = false;
            this.acce_gcColCantidadS.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.acce_gcColCantidadS.OptionsColumn.AllowMove = false;
            this.acce_gcColCantidadS.OptionsColumn.AllowShowHide = false;
            this.acce_gcColCantidadS.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.acce_gcColCantidadS.OptionsFilter.AllowAutoFilter = false;
            this.acce_gcColCantidadS.ToolTip = "Cantidad necesaria";
            this.acce_gcColCantidadS.Visible = true;
            this.acce_gcColCantidadS.VisibleIndex = 2;
            this.acce_gcColCantidadS.Width = 158;
            // 
            // dis_riseCantAccesorio
            // 
            this.dis_riseCantAccesorio.AutoHeight = false;
            this.dis_riseCantAccesorio.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dis_riseCantAccesorio.DisplayFormat.FormatString = "N2";
            this.dis_riseCantAccesorio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_riseCantAccesorio.EditFormat.FormatString = "N2";
            this.dis_riseCantAccesorio.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_riseCantAccesorio.Mask.EditMask = "N2";
            this.dis_riseCantAccesorio.MaxValue = new decimal(new int[] {
            1215752191,
            23,
            0,
            131072});
            this.dis_riseCantAccesorio.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.dis_riseCantAccesorio.Name = "dis_riseCantAccesorio";
            // 
            // acce_gcColCostoS
            // 
            this.acce_gcColCostoS.Caption = "Costo";
            this.acce_gcColCostoS.DisplayFormat.FormatString = "e3";
            this.acce_gcColCostoS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.acce_gcColCostoS.FieldName = "Costo";
            this.acce_gcColCostoS.Name = "acce_gcColCostoS";
            this.acce_gcColCostoS.OptionsColumn.AllowEdit = false;
            this.acce_gcColCostoS.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.acce_gcColCostoS.OptionsColumn.AllowIncrementalSearch = false;
            this.acce_gcColCostoS.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.acce_gcColCostoS.OptionsColumn.AllowMove = false;
            this.acce_gcColCostoS.OptionsColumn.AllowShowHide = false;
            this.acce_gcColCostoS.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.acce_gcColCostoS.OptionsColumn.ReadOnly = true;
            this.acce_gcColCostoS.OptionsFilter.AllowAutoFilter = false;
            this.acce_gcColCostoS.ToolTip = "Costo del accesorio";
            this.acce_gcColCostoS.Visible = true;
            this.acce_gcColCostoS.VisibleIndex = 3;
            this.acce_gcColCostoS.Width = 166;
            // 
            // acce_gcColTotalLineaS
            // 
            this.acce_gcColTotalLineaS.Caption = "Total";
            this.acce_gcColTotalLineaS.DisplayFormat.FormatString = "N2";
            this.acce_gcColTotalLineaS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.acce_gcColTotalLineaS.FieldName = "TotalLinea";
            this.acce_gcColTotalLineaS.Name = "acce_gcColTotalLineaS";
            this.acce_gcColTotalLineaS.OptionsColumn.AllowEdit = false;
            this.acce_gcColTotalLineaS.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.acce_gcColTotalLineaS.OptionsColumn.AllowIncrementalSearch = false;
            this.acce_gcColTotalLineaS.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.acce_gcColTotalLineaS.OptionsColumn.AllowMove = false;
            this.acce_gcColTotalLineaS.OptionsColumn.AllowShowHide = false;
            this.acce_gcColTotalLineaS.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.acce_gcColTotalLineaS.OptionsColumn.ReadOnly = true;
            this.acce_gcColTotalLineaS.OptionsFilter.AllowAutoFilter = false;
            this.acce_gcColTotalLineaS.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalLinea", "{0:N2}")});
            this.acce_gcColTotalLineaS.ToolTip = "Tiraje*Cantidad*Costo";
            this.acce_gcColTotalLineaS.Visible = true;
            this.acce_gcColTotalLineaS.VisibleIndex = 4;
            this.acce_gcColTotalLineaS.Width = 180;
            // 
            // dis_xtpProcesos
            // 
            this.dis_xtpProcesos.Controls.Add(this.proc_gcProcesos);
            this.dis_xtpProcesos.Name = "dis_xtpProcesos";
            this.dis_xtpProcesos.Size = new System.Drawing.Size(844, 242);
            this.dis_xtpProcesos.Text = "Procesos";
            // 
            // proc_gcProcesos
            // 
            this.proc_gcProcesos.ContextMenuStrip = this.cmDisenoProcesos;
            this.proc_gcProcesos.Location = new System.Drawing.Point(3, 3);
            this.proc_gcProcesos.MainView = this.proc_gvProcesos;
            this.proc_gcProcesos.Name = "proc_gcProcesos";
            this.proc_gcProcesos.Size = new System.Drawing.Size(838, 239);
            this.proc_gcProcesos.TabIndex = 0;
            this.proc_gcProcesos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.proc_gvProcesos});
            // 
            // cmDisenoProcesos
            // 
            this.cmDisenoProcesos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAgregaProceso,
            this.mnuQuitarProceso});
            this.cmDisenoProcesos.Name = "contextMenuStrip3";
            this.cmDisenoProcesos.Size = new System.Drawing.Size(219, 48);
            // 
            // mnuAgregaProceso
            // 
            this.mnuAgregaProceso.Name = "mnuAgregaProceso";
            this.mnuAgregaProceso.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuAgregaProceso.Size = new System.Drawing.Size(218, 22);
            this.mnuAgregaProceso.Text = "Agrega Proceso";
            this.mnuAgregaProceso.Click += new System.EventHandler(this.mnuAgregaProceso_Click);
            // 
            // mnuQuitarProceso
            // 
            this.mnuQuitarProceso.Name = "mnuQuitarProceso";
            this.mnuQuitarProceso.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.mnuQuitarProceso.Size = new System.Drawing.Size(218, 22);
            this.mnuQuitarProceso.Text = "Eliminar Proceso";
            this.mnuQuitarProceso.Click += new System.EventHandler(this.mnuQuitarProceso_Click);
            // 
            // proc_gvProcesos
            // 
            this.proc_gvProcesos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.proc_gcColMaquina,
            this.proc_gcColCosto,
            this.proc_gcColMinutos,
            this.proc_gcColTotal});
            this.proc_gvProcesos.GridControl = this.proc_gcProcesos;
            this.proc_gvProcesos.Name = "proc_gvProcesos";
            this.proc_gvProcesos.OptionsView.ShowGroupPanel = false;
            // 
            // proc_gcColMaquina
            // 
            this.proc_gcColMaquina.Caption = "Máquina";
            this.proc_gcColMaquina.FieldName = "Maquina";
            this.proc_gcColMaquina.Name = "proc_gcColMaquina";
            this.proc_gcColMaquina.OptionsColumn.AllowEdit = false;
            this.proc_gcColMaquina.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.proc_gcColMaquina.OptionsColumn.AllowIncrementalSearch = false;
            this.proc_gcColMaquina.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.proc_gcColMaquina.OptionsColumn.AllowMove = false;
            this.proc_gcColMaquina.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.proc_gcColMaquina.OptionsColumn.ReadOnly = true;
            this.proc_gcColMaquina.Visible = true;
            this.proc_gcColMaquina.VisibleIndex = 0;
            this.proc_gcColMaquina.Width = 330;
            // 
            // proc_gcColCosto
            // 
            this.proc_gcColCosto.Caption = "Costo";
            this.proc_gcColCosto.DisplayFormat.FormatString = "N2";
            this.proc_gcColCosto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.proc_gcColCosto.FieldName = "Costo";
            this.proc_gcColCosto.Name = "proc_gcColCosto";
            this.proc_gcColCosto.OptionsColumn.AllowEdit = false;
            this.proc_gcColCosto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.proc_gcColCosto.OptionsColumn.AllowIncrementalSearch = false;
            this.proc_gcColCosto.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.proc_gcColCosto.OptionsColumn.AllowMove = false;
            this.proc_gcColCosto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.proc_gcColCosto.OptionsColumn.ReadOnly = true;
            this.proc_gcColCosto.Visible = true;
            this.proc_gcColCosto.VisibleIndex = 1;
            this.proc_gcColCosto.Width = 145;
            // 
            // proc_gcColMinutos
            // 
            this.proc_gcColMinutos.Caption = "Minutos";
            this.proc_gcColMinutos.DisplayFormat.FormatString = "N0";
            this.proc_gcColMinutos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.proc_gcColMinutos.FieldName = "Minutos";
            this.proc_gcColMinutos.Name = "proc_gcColMinutos";
            this.proc_gcColMinutos.OptionsColumn.AllowEdit = false;
            this.proc_gcColMinutos.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.proc_gcColMinutos.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.proc_gcColMinutos.OptionsColumn.AllowMove = false;
            this.proc_gcColMinutos.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.proc_gcColMinutos.Visible = true;
            this.proc_gcColMinutos.VisibleIndex = 2;
            this.proc_gcColMinutos.Width = 193;
            // 
            // proc_gcColTotal
            // 
            this.proc_gcColTotal.Caption = "Total";
            this.proc_gcColTotal.DisplayFormat.FormatString = "N2";
            this.proc_gcColTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.proc_gcColTotal.FieldName = "TotalLinea";
            this.proc_gcColTotal.Name = "proc_gcColTotal";
            this.proc_gcColTotal.OptionsColumn.AllowEdit = false;
            this.proc_gcColTotal.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.proc_gcColTotal.OptionsColumn.AllowIncrementalSearch = false;
            this.proc_gcColTotal.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.proc_gcColTotal.OptionsColumn.AllowMove = false;
            this.proc_gcColTotal.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.proc_gcColTotal.OptionsColumn.ReadOnly = true;
            this.proc_gcColTotal.Visible = true;
            this.proc_gcColTotal.VisibleIndex = 3;
            this.proc_gcColTotal.Width = 164;
            // 
            // dis_xtpProcesosIMP
            // 
            this.dis_xtpProcesosIMP.Controls.Add(this.procimp_gcProcesoIMP);
            this.dis_xtpProcesosIMP.Name = "dis_xtpProcesosIMP";
            this.dis_xtpProcesosIMP.Size = new System.Drawing.Size(844, 242);
            this.dis_xtpProcesosIMP.Text = "Procesos Impresión";
            // 
            // procimp_gcProcesoIMP
            // 
            this.procimp_gcProcesoIMP.Location = new System.Drawing.Point(3, 3);
            this.procimp_gcProcesoIMP.MainView = this.procimp_bgvProcesoIMP;
            this.procimp_gcProcesoIMP.Name = "procimp_gcProcesoIMP";
            this.procimp_gcProcesoIMP.Size = new System.Drawing.Size(838, 236);
            this.procimp_gcProcesoIMP.TabIndex = 0;
            this.procimp_gcProcesoIMP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.procimp_bgvProcesoIMP});
            // 
            // procimp_bgvProcesoIMP
            // 
            this.procimp_bgvProcesoIMP.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.dis_bandaMaterial,
            this.dis_bandaImpresion,
            this.dis_bandaPuestaPunto,
            this.dis_bandaTotal});
            this.procimp_bgvProcesoIMP.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.procimp_gcColTallaI,
            this.procimp_gcColMaterialI,
            this.procimp_gcColPlacaI,
            this.procimp_gcColNumColoresI,
            this.procimp_gcColCostoXminuto,
            this.procimp_gcColPliegosXminuto,
            this.procimp_gcColNumPliegos,
            this.procimp_gcColMinImpresion,
            this.procimp_gcColCostoXminutoPP,
            this.procimp_gcColMinutosPP,
            this.procimp_gcColTotalLineaI});
            this.procimp_bgvProcesoIMP.GridControl = this.procimp_gcProcesoIMP;
            this.procimp_bgvProcesoIMP.Name = "procimp_bgvProcesoIMP";
            this.procimp_bgvProcesoIMP.OptionsView.ColumnAutoWidth = false;
            this.procimp_bgvProcesoIMP.OptionsView.ShowFooter = true;
            this.procimp_bgvProcesoIMP.OptionsView.ShowGroupPanel = false;
            // 
            // dis_bandaMaterial
            // 
            this.dis_bandaMaterial.Columns.Add(this.procimp_gcColTallaI);
            this.dis_bandaMaterial.Columns.Add(this.procimp_gcColMaterialI);
            this.dis_bandaMaterial.Columns.Add(this.procimp_gcColNumColoresI);
            this.dis_bandaMaterial.Columns.Add(this.procimp_gcColPlacaI);
            this.dis_bandaMaterial.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.dis_bandaMaterial.Name = "dis_bandaMaterial";
            this.dis_bandaMaterial.OptionsBand.AllowHotTrack = false;
            this.dis_bandaMaterial.OptionsBand.AllowMove = false;
            this.dis_bandaMaterial.OptionsBand.AllowPress = false;
            this.dis_bandaMaterial.VisibleIndex = 0;
            this.dis_bandaMaterial.Width = 380;
            // 
            // procimp_gcColTallaI
            // 
            this.procimp_gcColTallaI.Caption = "Grupo";
            this.procimp_gcColTallaI.FieldName = "Talla";
            this.procimp_gcColTallaI.Name = "procimp_gcColTallaI";
            this.procimp_gcColTallaI.OptionsColumn.AllowEdit = false;
            this.procimp_gcColTallaI.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColTallaI.OptionsColumn.AllowIncrementalSearch = false;
            this.procimp_gcColTallaI.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColTallaI.OptionsColumn.AllowMove = false;
            this.procimp_gcColTallaI.OptionsColumn.AllowShowHide = false;
            this.procimp_gcColTallaI.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColTallaI.OptionsColumn.ReadOnly = true;
            this.procimp_gcColTallaI.OptionsFilter.AllowAutoFilter = false;
            this.procimp_gcColTallaI.Visible = true;
            this.procimp_gcColTallaI.Width = 100;
            // 
            // procimp_gcColMaterialI
            // 
            this.procimp_gcColMaterialI.Caption = "Material";
            this.procimp_gcColMaterialI.FieldName = "Material";
            this.procimp_gcColMaterialI.Name = "procimp_gcColMaterialI";
            this.procimp_gcColMaterialI.OptionsColumn.AllowEdit = false;
            this.procimp_gcColMaterialI.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColMaterialI.OptionsColumn.AllowIncrementalSearch = false;
            this.procimp_gcColMaterialI.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColMaterialI.OptionsColumn.AllowMove = false;
            this.procimp_gcColMaterialI.OptionsColumn.AllowShowHide = false;
            this.procimp_gcColMaterialI.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColMaterialI.OptionsColumn.ReadOnly = true;
            this.procimp_gcColMaterialI.OptionsFilter.AllowAutoFilter = false;
            this.procimp_gcColMaterialI.Visible = true;
            this.procimp_gcColMaterialI.Width = 150;
            // 
            // procimp_gcColNumColoresI
            // 
            this.procimp_gcColNumColoresI.Caption = "Colores";
            this.procimp_gcColNumColoresI.DisplayFormat.FormatString = "N0";
            this.procimp_gcColNumColoresI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.procimp_gcColNumColoresI.FieldName = "NumColores";
            this.procimp_gcColNumColoresI.Name = "procimp_gcColNumColoresI";
            this.procimp_gcColNumColoresI.OptionsColumn.AllowEdit = false;
            this.procimp_gcColNumColoresI.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColNumColoresI.OptionsColumn.AllowIncrementalSearch = false;
            this.procimp_gcColNumColoresI.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColNumColoresI.OptionsColumn.AllowMove = false;
            this.procimp_gcColNumColoresI.OptionsColumn.AllowShowHide = false;
            this.procimp_gcColNumColoresI.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColNumColoresI.OptionsColumn.ReadOnly = true;
            this.procimp_gcColNumColoresI.OptionsFilter.AllowAutoFilter = false;
            this.procimp_gcColNumColoresI.Visible = true;
            this.procimp_gcColNumColoresI.Width = 70;
            // 
            // procimp_gcColPlacaI
            // 
            this.procimp_gcColPlacaI.Caption = "Placa";
            this.procimp_gcColPlacaI.FieldName = "Placa";
            this.procimp_gcColPlacaI.Name = "procimp_gcColPlacaI";
            this.procimp_gcColPlacaI.OptionsColumn.AllowEdit = false;
            this.procimp_gcColPlacaI.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColPlacaI.OptionsColumn.AllowIncrementalSearch = false;
            this.procimp_gcColPlacaI.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColPlacaI.OptionsColumn.AllowMove = false;
            this.procimp_gcColPlacaI.OptionsColumn.AllowShowHide = false;
            this.procimp_gcColPlacaI.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColPlacaI.OptionsColumn.ReadOnly = true;
            this.procimp_gcColPlacaI.Visible = true;
            this.procimp_gcColPlacaI.Width = 60;
            // 
            // dis_bandaImpresion
            // 
            this.dis_bandaImpresion.Caption = "Proceso de Impresión";
            this.dis_bandaImpresion.Columns.Add(this.procimp_gcColCostoXminuto);
            this.dis_bandaImpresion.Columns.Add(this.procimp_gcColMinImpresion);
            this.dis_bandaImpresion.Columns.Add(this.procimp_gcColPliegosXminuto);
            this.dis_bandaImpresion.Columns.Add(this.procimp_gcColNumPliegos);
            this.dis_bandaImpresion.Name = "dis_bandaImpresion";
            this.dis_bandaImpresion.OptionsBand.AllowMove = false;
            this.dis_bandaImpresion.OptionsBand.AllowPress = false;
            this.dis_bandaImpresion.VisibleIndex = 1;
            this.dis_bandaImpresion.Width = 270;
            // 
            // procimp_gcColCostoXminuto
            // 
            this.procimp_gcColCostoXminuto.Caption = "Costo Min";
            this.procimp_gcColCostoXminuto.DisplayFormat.FormatString = "e3";
            this.procimp_gcColCostoXminuto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.procimp_gcColCostoXminuto.FieldName = "CostoMinIMP";
            this.procimp_gcColCostoXminuto.Name = "procimp_gcColCostoXminuto";
            this.procimp_gcColCostoXminuto.OptionsColumn.AllowEdit = false;
            this.procimp_gcColCostoXminuto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColCostoXminuto.OptionsColumn.AllowIncrementalSearch = false;
            this.procimp_gcColCostoXminuto.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColCostoXminuto.OptionsColumn.AllowMove = false;
            this.procimp_gcColCostoXminuto.OptionsColumn.AllowShowHide = false;
            this.procimp_gcColCostoXminuto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColCostoXminuto.OptionsColumn.ReadOnly = true;
            this.procimp_gcColCostoXminuto.OptionsFilter.AllowAutoFilter = false;
            this.procimp_gcColCostoXminuto.Visible = true;
            this.procimp_gcColCostoXminuto.Width = 70;
            // 
            // procimp_gcColMinImpresion
            // 
            this.procimp_gcColMinImpresion.Caption = "MIN";
            this.procimp_gcColMinImpresion.DisplayFormat.FormatString = "N0";
            this.procimp_gcColMinImpresion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.procimp_gcColMinImpresion.FieldName = "NumMinIMP";
            this.procimp_gcColMinImpresion.Name = "procimp_gcColMinImpresion";
            this.procimp_gcColMinImpresion.OptionsColumn.AllowEdit = false;
            this.procimp_gcColMinImpresion.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColMinImpresion.OptionsColumn.AllowIncrementalSearch = false;
            this.procimp_gcColMinImpresion.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColMinImpresion.OptionsColumn.AllowMove = false;
            this.procimp_gcColMinImpresion.OptionsColumn.AllowShowHide = false;
            this.procimp_gcColMinImpresion.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColMinImpresion.OptionsColumn.ReadOnly = true;
            this.procimp_gcColMinImpresion.OptionsFilter.AllowAutoFilter = false;
            this.procimp_gcColMinImpresion.Visible = true;
            this.procimp_gcColMinImpresion.Width = 60;
            // 
            // procimp_gcColPliegosXminuto
            // 
            this.procimp_gcColPliegosXminuto.Caption = "Pliego X min";
            this.procimp_gcColPliegosXminuto.DisplayFormat.FormatString = "N0";
            this.procimp_gcColPliegosXminuto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.procimp_gcColPliegosXminuto.FieldName = "PliegosXmin";
            this.procimp_gcColPliegosXminuto.Name = "procimp_gcColPliegosXminuto";
            this.procimp_gcColPliegosXminuto.OptionsColumn.AllowEdit = false;
            this.procimp_gcColPliegosXminuto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColPliegosXminuto.OptionsColumn.AllowIncrementalSearch = false;
            this.procimp_gcColPliegosXminuto.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColPliegosXminuto.OptionsColumn.AllowMove = false;
            this.procimp_gcColPliegosXminuto.OptionsColumn.AllowShowHide = false;
            this.procimp_gcColPliegosXminuto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColPliegosXminuto.OptionsColumn.ReadOnly = true;
            this.procimp_gcColPliegosXminuto.OptionsFilter.AllowAutoFilter = false;
            this.procimp_gcColPliegosXminuto.Visible = true;
            this.procimp_gcColPliegosXminuto.Width = 70;
            // 
            // procimp_gcColNumPliegos
            // 
            this.procimp_gcColNumPliegos.Caption = "Pliegos #";
            this.procimp_gcColNumPliegos.DisplayFormat.FormatString = "N0";
            this.procimp_gcColNumPliegos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.procimp_gcColNumPliegos.FieldName = "NumPliegos";
            this.procimp_gcColNumPliegos.Name = "procimp_gcColNumPliegos";
            this.procimp_gcColNumPliegos.OptionsColumn.AllowEdit = false;
            this.procimp_gcColNumPliegos.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColNumPliegos.OptionsColumn.AllowIncrementalSearch = false;
            this.procimp_gcColNumPliegos.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColNumPliegos.OptionsColumn.AllowMove = false;
            this.procimp_gcColNumPliegos.OptionsColumn.AllowShowHide = false;
            this.procimp_gcColNumPliegos.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColNumPliegos.OptionsColumn.ReadOnly = true;
            this.procimp_gcColNumPliegos.OptionsFilter.AllowAutoFilter = false;
            this.procimp_gcColNumPliegos.Visible = true;
            this.procimp_gcColNumPliegos.Width = 70;
            // 
            // dis_bandaPuestaPunto
            // 
            this.dis_bandaPuestaPunto.Caption = "Prepara Máquina";
            this.dis_bandaPuestaPunto.Columns.Add(this.procimp_gcColCostoXminutoPP);
            this.dis_bandaPuestaPunto.Columns.Add(this.procimp_gcColMinutosPP);
            this.dis_bandaPuestaPunto.Name = "dis_bandaPuestaPunto";
            this.dis_bandaPuestaPunto.OptionsBand.AllowMove = false;
            this.dis_bandaPuestaPunto.OptionsBand.AllowPress = false;
            this.dis_bandaPuestaPunto.VisibleIndex = 2;
            this.dis_bandaPuestaPunto.Width = 130;
            // 
            // procimp_gcColCostoXminutoPP
            // 
            this.procimp_gcColCostoXminutoPP.Caption = "Costo Min";
            this.procimp_gcColCostoXminutoPP.DisplayFormat.FormatString = "e3";
            this.procimp_gcColCostoXminutoPP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.procimp_gcColCostoXminutoPP.FieldName = "CostoXminPP";
            this.procimp_gcColCostoXminutoPP.Name = "procimp_gcColCostoXminutoPP";
            this.procimp_gcColCostoXminutoPP.OptionsColumn.AllowEdit = false;
            this.procimp_gcColCostoXminutoPP.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColCostoXminutoPP.OptionsColumn.AllowIncrementalSearch = false;
            this.procimp_gcColCostoXminutoPP.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColCostoXminutoPP.OptionsColumn.AllowMove = false;
            this.procimp_gcColCostoXminutoPP.OptionsColumn.AllowShowHide = false;
            this.procimp_gcColCostoXminutoPP.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColCostoXminutoPP.OptionsColumn.ReadOnly = true;
            this.procimp_gcColCostoXminutoPP.OptionsFilter.AllowAutoFilter = false;
            this.procimp_gcColCostoXminutoPP.Visible = true;
            this.procimp_gcColCostoXminutoPP.Width = 70;
            // 
            // procimp_gcColMinutosPP
            // 
            this.procimp_gcColMinutosPP.Caption = "MIN";
            this.procimp_gcColMinutosPP.DisplayFormat.FormatString = "N0";
            this.procimp_gcColMinutosPP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.procimp_gcColMinutosPP.FieldName = "MinutosPP";
            this.procimp_gcColMinutosPP.Name = "procimp_gcColMinutosPP";
            this.procimp_gcColMinutosPP.OptionsColumn.AllowEdit = false;
            this.procimp_gcColMinutosPP.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColMinutosPP.OptionsColumn.AllowIncrementalSearch = false;
            this.procimp_gcColMinutosPP.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColMinutosPP.OptionsColumn.AllowMove = false;
            this.procimp_gcColMinutosPP.OptionsColumn.AllowShowHide = false;
            this.procimp_gcColMinutosPP.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColMinutosPP.OptionsColumn.ReadOnly = true;
            this.procimp_gcColMinutosPP.OptionsFilter.AllowAutoFilter = false;
            this.procimp_gcColMinutosPP.Visible = true;
            this.procimp_gcColMinutosPP.Width = 60;
            // 
            // dis_bandaTotal
            // 
            this.dis_bandaTotal.Columns.Add(this.procimp_gcColTotalLineaI);
            this.dis_bandaTotal.Name = "dis_bandaTotal";
            this.dis_bandaTotal.OptionsBand.AllowHotTrack = false;
            this.dis_bandaTotal.OptionsBand.AllowMove = false;
            this.dis_bandaTotal.OptionsBand.AllowPress = false;
            this.dis_bandaTotal.VisibleIndex = 3;
            this.dis_bandaTotal.Width = 80;
            // 
            // procimp_gcColTotalLineaI
            // 
            this.procimp_gcColTotalLineaI.Caption = "Total";
            this.procimp_gcColTotalLineaI.DisplayFormat.FormatString = "N2";
            this.procimp_gcColTotalLineaI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.procimp_gcColTotalLineaI.FieldName = "TotalLinea";
            this.procimp_gcColTotalLineaI.Name = "procimp_gcColTotalLineaI";
            this.procimp_gcColTotalLineaI.OptionsColumn.AllowEdit = false;
            this.procimp_gcColTotalLineaI.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColTotalLineaI.OptionsColumn.AllowIncrementalSearch = false;
            this.procimp_gcColTotalLineaI.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColTotalLineaI.OptionsColumn.AllowMove = false;
            this.procimp_gcColTotalLineaI.OptionsColumn.AllowShowHide = false;
            this.procimp_gcColTotalLineaI.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.procimp_gcColTotalLineaI.OptionsColumn.ReadOnly = true;
            this.procimp_gcColTotalLineaI.OptionsFilter.AllowAutoFilter = false;
            this.procimp_gcColTotalLineaI.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalLinea", "{0:N2}")});
            this.procimp_gcColTotalLineaI.Visible = true;
            this.procimp_gcColTotalLineaI.Width = 80;
            // 
            // dis_xtpMaterialCLI
            // 
            this.dis_xtpMaterialCLI.Controls.Add(this.mcli_gcMaterialCLI);
            this.dis_xtpMaterialCLI.Name = "dis_xtpMaterialCLI";
            this.dis_xtpMaterialCLI.Size = new System.Drawing.Size(844, 242);
            this.dis_xtpMaterialCLI.Text = "Materiales Cliente";
            // 
            // mcli_gcMaterialCLI
            // 
            this.mcli_gcMaterialCLI.ContextMenuStrip = this.cmClienteMAT;
            this.mcli_gcMaterialCLI.Location = new System.Drawing.Point(7, 3);
            this.mcli_gcMaterialCLI.MainView = this.mcli_gvMaterialCLI;
            this.mcli_gcMaterialCLI.Name = "mcli_gcMaterialCLI";
            this.mcli_gcMaterialCLI.Size = new System.Drawing.Size(834, 236);
            this.mcli_gcMaterialCLI.TabIndex = 1;
            this.mcli_gcMaterialCLI.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.mcli_gvMaterialCLI});
            // 
            // cmClienteMAT
            // 
            this.cmClienteMAT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAgregaMATCLI,
            this.mnuQuitaMATCLI});
            this.cmClienteMAT.Name = "contextMenuStrip1";
            this.cmClienteMAT.Size = new System.Drawing.Size(220, 48);
            // 
            // mnuAgregaMATCLI
            // 
            this.mnuAgregaMATCLI.Name = "mnuAgregaMATCLI";
            this.mnuAgregaMATCLI.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuAgregaMATCLI.Size = new System.Drawing.Size(219, 22);
            this.mnuAgregaMATCLI.Text = "Agrega Material";
            this.mnuAgregaMATCLI.Click += new System.EventHandler(this.mnuAgregaMATCLI_Click);
            // 
            // mnuQuitaMATCLI
            // 
            this.mnuQuitaMATCLI.Name = "mnuQuitaMATCLI";
            this.mnuQuitaMATCLI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.mnuQuitaMATCLI.Size = new System.Drawing.Size(219, 22);
            this.mnuQuitaMATCLI.Text = "Eliminar Material";
            this.mnuQuitaMATCLI.Click += new System.EventHandler(this.mnuQuitaMATCLI_Click);
            // 
            // mcli_gvMaterialCLI
            // 
            this.mcli_gvMaterialCLI.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.mcli_gcColMaterialCLI,
            this.mcli_gcColCantidadCLI});
            this.mcli_gvMaterialCLI.GridControl = this.mcli_gcMaterialCLI;
            this.mcli_gvMaterialCLI.Name = "mcli_gvMaterialCLI";
            this.mcli_gvMaterialCLI.OptionsView.ShowGroupPanel = false;
            // 
            // mcli_gcColMaterialCLI
            // 
            this.mcli_gcColMaterialCLI.Caption = "Material";
            this.mcli_gcColMaterialCLI.FieldName = "Material";
            this.mcli_gcColMaterialCLI.Name = "mcli_gcColMaterialCLI";
            this.mcli_gcColMaterialCLI.OptionsColumn.AllowEdit = false;
            this.mcli_gcColMaterialCLI.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.mcli_gcColMaterialCLI.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.mcli_gcColMaterialCLI.OptionsColumn.AllowMove = false;
            this.mcli_gcColMaterialCLI.OptionsColumn.AllowShowHide = false;
            this.mcli_gcColMaterialCLI.OptionsColumn.ReadOnly = true;
            this.mcli_gcColMaterialCLI.Visible = true;
            this.mcli_gcColMaterialCLI.VisibleIndex = 0;
            this.mcli_gcColMaterialCLI.Width = 536;
            // 
            // mcli_gcColCantidadCLI
            // 
            this.mcli_gcColCantidadCLI.Caption = "Cantidad";
            this.mcli_gcColCantidadCLI.FieldName = "Cantidad";
            this.mcli_gcColCantidadCLI.Name = "mcli_gcColCantidadCLI";
            this.mcli_gcColCantidadCLI.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.mcli_gcColCantidadCLI.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.mcli_gcColCantidadCLI.OptionsColumn.AllowMove = false;
            this.mcli_gcColCantidadCLI.OptionsColumn.AllowShowHide = false;
            this.mcli_gcColCantidadCLI.Visible = true;
            this.mcli_gcColCantidadCLI.VisibleIndex = 1;
            this.mcli_gcColCantidadCLI.Width = 220;
            // 
            // xtpBlocks
            // 
            this.xtpBlocks.Controls.Add(this.blo_seJuegos);
            this.xtpBlocks.Controls.Add(this.blo_seTermina);
            this.xtpBlocks.Controls.Add(this.blo_seInicia);
            this.xtpBlocks.Controls.Add(this.blo_gcCopias);
            this.xtpBlocks.Controls.Add(this.labelControl29);
            this.xtpBlocks.Controls.Add(this.labelControl28);
            this.xtpBlocks.Controls.Add(this.labelControl27);
            this.xtpBlocks.Controls.Add(this.blo_txtSerie);
            this.xtpBlocks.Controls.Add(this.blo_lueTipoEmblocado);
            this.xtpBlocks.Controls.Add(this.labelControl26);
            this.xtpBlocks.Controls.Add(this.labelControl25);
            this.xtpBlocks.Name = "xtpBlocks";
            this.xtpBlocks.Size = new System.Drawing.Size(859, 313);
            this.xtpBlocks.Text = "Blocks";
            // 
            // blo_seJuegos
            // 
            this.blo_seJuegos.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.blo_seJuegos.Location = new System.Drawing.Point(353, 30);
            this.blo_seJuegos.Name = "blo_seJuegos";
            this.blo_seJuegos.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.blo_seJuegos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.blo_seJuegos.Properties.MaxValue = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.blo_seJuegos.Size = new System.Drawing.Size(79, 20);
            this.blo_seJuegos.TabIndex = 21;
            // 
            // blo_seTermina
            // 
            this.blo_seTermina.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.blo_seTermina.Location = new System.Drawing.Point(353, 8);
            this.blo_seTermina.Name = "blo_seTermina";
            this.blo_seTermina.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.blo_seTermina.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.blo_seTermina.Properties.MaxValue = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.blo_seTermina.Size = new System.Drawing.Size(78, 20);
            this.blo_seTermina.TabIndex = 20;
            // 
            // blo_seInicia
            // 
            this.blo_seInicia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.blo_seInicia.Location = new System.Drawing.Point(205, 8);
            this.blo_seInicia.Name = "blo_seInicia";
            this.blo_seInicia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.blo_seInicia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.blo_seInicia.Properties.MaxValue = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.blo_seInicia.Size = new System.Drawing.Size(78, 20);
            this.blo_seInicia.TabIndex = 19;
            // 
            // blo_gcCopias
            // 
            this.blo_gcCopias.ContextMenuStrip = this.cmBlock;
            this.blo_gcCopias.Location = new System.Drawing.Point(14, 56);
            this.blo_gcCopias.MainView = this.blo_gvCopias;
            this.blo_gcCopias.Name = "blo_gcCopias";
            this.blo_gcCopias.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.blo_rilueColorCopia});
            this.blo_gcCopias.Size = new System.Drawing.Size(417, 134);
            this.blo_gcCopias.TabIndex = 18;
            this.blo_gcCopias.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.blo_gvCopias});
            // 
            // cmBlock
            // 
            this.cmBlock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEliminaRegBlock});
            this.cmBlock.Name = "cmBlock";
            this.cmBlock.Size = new System.Drawing.Size(220, 26);
            // 
            // mnuEliminaRegBlock
            // 
            this.mnuEliminaRegBlock.Name = "mnuEliminaRegBlock";
            this.mnuEliminaRegBlock.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.mnuEliminaRegBlock.Size = new System.Drawing.Size(219, 22);
            this.mnuEliminaRegBlock.Text = "Eliminar Registro";
            this.mnuEliminaRegBlock.Click += new System.EventHandler(this.mnuEliminaRegBlock_Click);
            // 
            // blo_gvCopias
            // 
            this.blo_gvCopias.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.blo_gcColSecuencial,
            this.blo_gcColColor});
            this.blo_gvCopias.GridControl = this.blo_gcCopias;
            this.blo_gvCopias.Name = "blo_gvCopias";
            this.blo_gvCopias.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.blo_gvCopias.OptionsView.ShowGroupPanel = false;
            // 
            // blo_gcColSecuencial
            // 
            this.blo_gcColSecuencial.Caption = "Nro";
            this.blo_gcColSecuencial.FieldName = "Secuencial";
            this.blo_gcColSecuencial.Name = "blo_gcColSecuencial";
            this.blo_gcColSecuencial.OptionsColumn.AllowEdit = false;
            this.blo_gcColSecuencial.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.blo_gcColSecuencial.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.blo_gcColSecuencial.OptionsColumn.AllowMove = false;
            this.blo_gcColSecuencial.OptionsColumn.ReadOnly = true;
            this.blo_gcColSecuencial.Visible = true;
            this.blo_gcColSecuencial.VisibleIndex = 0;
            this.blo_gcColSecuencial.Width = 69;
            // 
            // blo_gcColColor
            // 
            this.blo_gcColColor.Caption = "Color";
            this.blo_gcColColor.ColumnEdit = this.blo_rilueColorCopia;
            this.blo_gcColColor.FieldName = "Color";
            this.blo_gcColColor.Name = "blo_gcColColor";
            this.blo_gcColColor.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.blo_gcColColor.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.blo_gcColColor.OptionsColumn.AllowMove = false;
            this.blo_gcColColor.Visible = true;
            this.blo_gcColColor.VisibleIndex = 1;
            this.blo_gcColColor.Width = 313;
            // 
            // blo_rilueColorCopia
            // 
            this.blo_rilueColorCopia.AutoHeight = false;
            this.blo_rilueColorCopia.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.blo_rilueColorCopia.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Color")});
            this.blo_rilueColorCopia.DisplayMember = "Descripcion";
            this.blo_rilueColorCopia.Name = "blo_rilueColorCopia";
            this.blo_rilueColorCopia.NullText = "";
            this.blo_rilueColorCopia.ValueMember = "Codigo";
            // 
            // labelControl29
            // 
            this.labelControl29.Location = new System.Drawing.Point(293, 11);
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Size = new System.Drawing.Size(42, 13);
            this.labelControl29.TabIndex = 16;
            this.labelControl29.Text = "Termina:";
            // 
            // labelControl28
            // 
            this.labelControl28.Location = new System.Drawing.Point(166, 11);
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Size = new System.Drawing.Size(29, 13);
            this.labelControl28.TabIndex = 15;
            this.labelControl28.Text = "Inicia:";
            // 
            // labelControl27
            // 
            this.labelControl27.Location = new System.Drawing.Point(14, 11);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(28, 13);
            this.labelControl27.TabIndex = 14;
            this.labelControl27.Text = "Serie:";
            // 
            // blo_txtSerie
            // 
            this.blo_txtSerie.EditValue = "";
            this.blo_txtSerie.Location = new System.Drawing.Point(95, 8);
            this.blo_txtSerie.Name = "blo_txtSerie";
            this.blo_txtSerie.Properties.Appearance.Options.UseTextOptions = true;
            this.blo_txtSerie.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.blo_txtSerie.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.blo_txtSerie.Properties.MaxLength = 6;
            this.blo_txtSerie.Size = new System.Drawing.Size(61, 20);
            this.blo_txtSerie.TabIndex = 6;
            this.blo_txtSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._SoloNumeros);
            // 
            // blo_lueTipoEmblocado
            // 
            this.blo_lueTipoEmblocado.Location = new System.Drawing.Point(95, 30);
            this.blo_lueTipoEmblocado.Name = "blo_lueTipoEmblocado";
            this.blo_lueTipoEmblocado.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.blo_lueTipoEmblocado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.blo_lueTipoEmblocado.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Emblocado")});
            this.blo_lueTipoEmblocado.Properties.DisplayMember = "Descripcion";
            this.blo_lueTipoEmblocado.Properties.NullText = "";
            this.blo_lueTipoEmblocado.Properties.ValueMember = "Codigo";
            this.blo_lueTipoEmblocado.Size = new System.Drawing.Size(188, 20);
            this.blo_lueTipoEmblocado.TabIndex = 5;
            // 
            // labelControl26
            // 
            this.labelControl26.Location = new System.Drawing.Point(14, 33);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(55, 13);
            this.labelControl26.TabIndex = 4;
            this.labelControl26.Text = "Emblocado:";
            // 
            // labelControl25
            // 
            this.labelControl25.Location = new System.Drawing.Point(293, 33);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(33, 13);
            this.labelControl25.TabIndex = 3;
            this.labelControl25.Text = "Juego:";
            // 
            // seTiraje
            // 
            this.seTiraje.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seTiraje.Location = new System.Drawing.Point(367, 72);
            this.seTiraje.Name = "seTiraje";
            this.seTiraje.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.seTiraje.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seTiraje.Properties.MaxValue = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.seTiraje.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seTiraje.Size = new System.Drawing.Size(79, 20);
            this.seTiraje.TabIndex = 78;
            this.seTiraje.EditValueChanged += new System.EventHandler(this.seTiraje_EditValueChanged);
            // 
            // seAlto
            // 
            this.seAlto.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.seAlto.Location = new System.Drawing.Point(228, 72);
            this.seAlto.Name = "seAlto";
            this.seAlto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.seAlto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seAlto.Properties.DisplayFormat.FormatString = "N2";
            this.seAlto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seAlto.Properties.EditFormat.FormatString = "N2";
            this.seAlto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seAlto.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seAlto.Properties.Mask.EditMask = "N2";
            this.seAlto.Properties.MaxValue = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.seAlto.Properties.MinValue = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.seAlto.Size = new System.Drawing.Size(79, 20);
            this.seAlto.TabIndex = 7;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(605, 30);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(58, 13);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "Fec. Cotiza:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 30);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Cliente:";
            // 
            // seAncho
            // 
            this.seAncho.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.seAncho.Location = new System.Drawing.Point(104, 72);
            this.seAncho.Name = "seAncho";
            this.seAncho.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.seAncho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seAncho.Properties.DisplayFormat.FormatString = "N2";
            this.seAncho.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seAncho.Properties.EditFormat.FormatString = "N2";
            this.seAncho.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seAncho.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seAncho.Properties.Mask.EditMask = "N2";
            this.seAncho.Properties.MaxValue = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.seAncho.Properties.MinValue = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.seAncho.Size = new System.Drawing.Size(79, 20);
            this.seAncho.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(292, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "CIRUC:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Cotización:";
            // 
            // chkEstadoREG
            // 
            this.chkEstadoREG.Location = new System.Drawing.Point(825, 5);
            this.chkEstadoREG.Name = "chkEstadoREG";
            this.chkEstadoREG.Properties.Caption = "Activo";
            this.chkEstadoREG.Properties.ReadOnly = true;
            this.chkEstadoREG.Size = new System.Drawing.Size(54, 19);
            this.chkEstadoREG.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(21, 75);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(34, 13);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Ancho:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(21, 52);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Artículo:";
            // 
            // deFechaCOT
            // 
            this.deFechaCOT.EditValue = null;
            this.deFechaCOT.Location = new System.Drawing.Point(677, 27);
            this.deFechaCOT.Name = "deFechaCOT";
            this.deFechaCOT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.deFechaCOT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaCOT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaCOT.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.deFechaCOT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.deFechaCOT.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.deFechaCOT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.deFechaCOT.Properties.Mask.EditMask = "yyyy-MM-dd HH:mm";
            this.deFechaCOT.Properties.NullDate = "";
            this.deFechaCOT.Properties.ReadOnly = true;
            this.deFechaCOT.Size = new System.Drawing.Size(202, 20);
            this.deFechaCOT.TabIndex = 4;
            // 
            // txtCIRUCCLI
            // 
            this.txtCIRUCCLI.EditValue = "";
            this.txtCIRUCCLI.Location = new System.Drawing.Point(339, 5);
            this.txtCIRUCCLI.Name = "txtCIRUCCLI";
            this.txtCIRUCCLI.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCIRUCCLI.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCIRUCCLI.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtCIRUCCLI.Properties.MaxLength = 13;
            this.txtCIRUCCLI.Properties.ReadOnly = true;
            this.txtCIRUCCLI.Size = new System.Drawing.Size(107, 20);
            this.txtCIRUCCLI.TabIndex = 2;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(199, 75);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(23, 13);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "Alto:";
            // 
            // beNombreCLI
            // 
            this.beNombreCLI.Location = new System.Drawing.Point(104, 27);
            this.beNombreCLI.Name = "beNombreCLI";
            this.beNombreCLI.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.beNombreCLI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beNombreCLI.Properties.ReadOnly = true;
            this.beNombreCLI.Size = new System.Drawing.Size(342, 20);
            this.beNombreCLI.TabIndex = 1;
            this.beNombreCLI.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beNombreCLI_ButtonClick);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(605, 52);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(66, 13);
            this.labelControl8.TabIndex = 72;
            this.labelControl8.Text = "Fec. Entrega:";
            // 
            // beNumeroCOT
            // 
            this.beNumeroCOT.EditValue = "";
            this.beNumeroCOT.Location = new System.Drawing.Point(104, 5);
            this.beNumeroCOT.Name = "beNumeroCOT";
            this.beNumeroCOT.Properties.Appearance.Options.UseTextOptions = true;
            this.beNumeroCOT.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.beNumeroCOT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.beNumeroCOT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beNumeroCOT.Properties.MaxLength = 9;
            this.beNumeroCOT.Properties.ReadOnly = true;
            this.beNumeroCOT.Size = new System.Drawing.Size(79, 20);
            this.beNumeroCOT.TabIndex = 0;
            this.beNumeroCOT.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beNumeroCOT_ButtonClick);
            // 
            // deFechaENT
            // 
            this.deFechaENT.EditValue = null;
            this.deFechaENT.Location = new System.Drawing.Point(677, 49);
            this.deFechaENT.Name = "deFechaENT";
            this.deFechaENT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.deFechaENT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaENT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaENT.Properties.DisplayFormat.FormatString = "dddd dd MMMM yyyy HH:mm";
            this.deFechaENT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.deFechaENT.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.deFechaENT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.deFechaENT.Properties.Mask.EditMask = "yyyy-MM-dd HH:mm";
            this.deFechaENT.Size = new System.Drawing.Size(203, 20);
            this.deFechaENT.TabIndex = 71;
            // 
            // beArticulo
            // 
            this.beArticulo.Location = new System.Drawing.Point(104, 49);
            this.beArticulo.Name = "beArticulo";
            this.beArticulo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.beArticulo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beArticulo.Size = new System.Drawing.Size(342, 20);
            this.beArticulo.TabIndex = 70;
            this.beArticulo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beArticulo_ButtonClick);
            // 
            // ctlCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barraStandar);
            this.Name = "ctlCotizacion";
            this.Size = new System.Drawing.Size(926, 496);
            this.Load += new System.EventHandler(this.ctlCotizacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtcPestanas)).EndInit();
            this.xtcPestanas.ResumeLayout(false);
            this.xtpDatosCLI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cli_gcDestinos)).EndInit();
            this.cmClienteSUC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cli_gvDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cli_gcContactos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cli_gvContactos)).EndInit();
            this.xtpResumen.ResumeLayout(false);
            this.xtpResumen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tot_gcTotales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tot_gvTotales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLineaPRD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEplCotizador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beEplVendedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSubgrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGrupo.Properties)).EndInit();
            this.xtpDiseno.ResumeLayout(false);
            this.xtpDiseno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_lueComponente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcDiseno)).EndInit();
            this.xtcDiseno.ResumeLayout(false);
            this.dis_xtpGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dis_gpGraficasH)).EndInit();
            this.dis_gpGraficasH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gen_gcGraficasH)).EndInit();
            this.cmDisenoGeneralGH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gen_gvGraficasH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_gpOriginales)).EndInit();
            this.dis_gpOriginales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gen_gcOriginales)).EndInit();
            this.cmDisenoGeneralORI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gen_gvOriginales)).EndInit();
            this.dis_xtpArmados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.arm_gcArmados)).EndInit();
            this.cmDisenoMatARMDIS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.arm_gvArmados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_risePorcentajePliegoEXT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_riseAnchoTFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_ribeAltoTFinal)).EndInit();
            this.dis_xtpColores.ResumeLayout(false);
            this.dis_xtpColores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_seGramosPantone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_seGramosMetalizado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_seGramosColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_gcColores)).EndInit();
            this.cmDisenoColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.col_gvColores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_rilueLadoImpresion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_rilueTipoColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_rilueCobertura)).EndInit();
            this.dis_xtpPlacas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pla_gcPlacas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pla_gvPlacas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_rilueLadoImpresionP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_riseNumColores)).EndInit();
            this.dis_xtpTroquel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tro_gcTrqouel)).EndInit();
            this.cmDisenoTroquel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tro_gvTroquel)).EndInit();
            this.dis_xtpAcabados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aca_gcAcabados)).EndInit();
            this.cmDisenoAcabado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aca_gvAcabados)).EndInit();
            this.dis_xtpAccesorios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.acce_gcAccesorios)).EndInit();
            this.cmDisenoAccesorios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.acce_gvAccesorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_riseCantAccesorio)).EndInit();
            this.dis_xtpProcesos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proc_gcProcesos)).EndInit();
            this.cmDisenoProcesos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proc_gvProcesos)).EndInit();
            this.dis_xtpProcesosIMP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.procimp_gcProcesoIMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procimp_bgvProcesoIMP)).EndInit();
            this.dis_xtpMaterialCLI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mcli_gcMaterialCLI)).EndInit();
            this.cmClienteMAT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mcli_gvMaterialCLI)).EndInit();
            this.xtpBlocks.ResumeLayout(false);
            this.xtpBlocks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blo_seJuegos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_seTermina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_seInicia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_gcCopias)).EndInit();
            this.cmBlock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.blo_gvCopias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_rilueColorCopia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_txtSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_lueTipoEmblocado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTiraje.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAlto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAncho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstadoREG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaCOT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaCOT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCIRUCCLI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beNombreCLI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beNumeroCOT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaENT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaENT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beArticulo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dllStandardTool.StandardTool barraStandar;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SpinEdit seAlto;
        private DevExpress.XtraEditors.SpinEdit seAncho;
        private DevExpress.XtraEditors.CheckEdit chkEstadoREG;
        private DevExpress.XtraEditors.DateEdit deFechaCOT;
        private DevExpress.XtraEditors.TextEdit txtCIRUCCLI;
        private DevExpress.XtraEditors.ButtonEdit beNombreCLI;
        private DevExpress.XtraEditors.ButtonEdit beNumeroCOT;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lueSubgrupo;
        private DevExpress.XtraEditors.LookUpEdit lueGrupo;
        private DevExpress.XtraEditors.LookUpEdit lueLineaPRD;
        private DevExpress.XtraTab.XtraTabControl xtcPestanas;
        private DevExpress.XtraTab.XtraTabPage xtpDatosCLI;
        private DevExpress.XtraGrid.GridControl cli_gcDestinos;
        private DevExpress.XtraGrid.Views.Grid.GridView cli_gvDestino;
        private DevExpress.XtraGrid.Columns.GridColumn cli_gcColSecuencial;
        private DevExpress.XtraGrid.Columns.GridColumn cli_gcColCodCiudad;
        private DevExpress.XtraGrid.Columns.GridColumn cli_gcColDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn cli_gcColCantidad;
        private DevExpress.XtraGrid.GridControl cli_gcContactos;
        private DevExpress.XtraGrid.Views.Grid.GridView cli_gvContactos;
        private DevExpress.XtraGrid.Columns.GridColumn gcColContacto;
        private DevExpress.XtraGrid.Columns.GridColumn gcColNumero;
        private DevExpress.XtraTab.XtraTabPage xtpBlocks;
        private DevExpress.XtraEditors.LabelControl labelControl29;
        private DevExpress.XtraEditors.LabelControl labelControl28;
        private DevExpress.XtraEditors.LabelControl labelControl27;
        private DevExpress.XtraEditors.TextEdit blo_txtSerie;
        private DevExpress.XtraEditors.LookUpEdit blo_lueTipoEmblocado;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraTab.XtraTabPage xtpDiseno;
        private DevExpress.XtraTab.XtraTabControl xtcDiseno;
        private DevExpress.XtraTab.XtraTabPage dis_xtpArmados;
        private DevExpress.XtraGrid.GridControl arm_gcArmados;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.ButtonEdit beArticulo;
        private DevExpress.XtraGrid.GridControl blo_gcCopias;
        private DevExpress.XtraGrid.Views.Grid.GridView blo_gvCopias;
        private DevExpress.XtraGrid.Columns.GridColumn blo_gcColSecuencial;
        private DevExpress.XtraGrid.Columns.GridColumn blo_gcColColor;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView arm_gvArmados;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn arm_gcColMaterial;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn arm_gcColArmadoAncho;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn arm_gcColArmadoAlto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn arm_gcColPliegoMPAncho;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn arm_gcColPliegoMPAlto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn arm_gcColPliegoCantidad;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn arm_gcColPliegoExtra;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn arm_gcColUndCotiza;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn arm_gcColAltoTrabajoF;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn arm_gcColAnchoTrabajoF;
        private System.Windows.Forms.ContextMenuStrip cmClienteSUC;
        private System.Windows.Forms.ToolStripMenuItem mnuAgregarDestino;
        private System.Windows.Forms.ToolStripMenuItem mnuQuitarDestino;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtEplCotizador;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.ButtonEdit beEplVendedor;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.DateEdit deFechaENT;
        private DevExpress.XtraEditors.LabelControl lblEstadoCOT;
        private DevExpress.XtraTab.XtraTabPage dis_xtpColores;
        private DevExpress.XtraGrid.GridControl col_gcColores;
        private DevExpress.XtraGrid.Views.Grid.GridView col_gvColores;
        private DevExpress.XtraGrid.Columns.GridColumn col_gcColTipoColor;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit dis_rilueTipoColor;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit dis_rilueCobertura;
        private DevExpress.XtraGrid.GridControl proc_gcProcesos;
        private DevExpress.XtraGrid.Views.Grid.GridView proc_gvProcesos;
        private DevExpress.XtraGrid.Columns.GridColumn proc_gcColMaquina;
        private DevExpress.XtraGrid.Columns.GridColumn proc_gcColCosto;
        private DevExpress.XtraGrid.Columns.GridColumn proc_gcColTotal;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit blo_rilueColorCopia;
        private System.Windows.Forms.ContextMenuStrip cmClienteMAT;
        private System.Windows.Forms.ToolStripMenuItem mnuAgregaMATCLI;
        private System.Windows.Forms.ToolStripMenuItem mnuQuitaMATCLI;
        private System.Windows.Forms.ContextMenuStrip cmDisenoMatARMDIS;
        private System.Windows.Forms.ContextMenuStrip cmDisenoProcesos;
        private System.Windows.Forms.ToolStripMenuItem mnuAgregaMATARMDIS;
        private System.Windows.Forms.ToolStripMenuItem mnuQuitarMATARMDIS;
        private System.Windows.Forms.ToolStripMenuItem mnuAgregaProceso;
        private System.Windows.Forms.ToolStripMenuItem mnuQuitarProceso;
        private System.Windows.Forms.ContextMenuStrip cmBlock;
        private System.Windows.Forms.ToolStripMenuItem mnuEliminaRegBlock;
        private System.Windows.Forms.ContextMenuStrip cmDisenoColor;
        private System.Windows.Forms.ToolStripMenuItem mnuEliminaRegDisenoColor;
        private DevExpress.XtraEditors.SpinEdit blo_seJuegos;
        private DevExpress.XtraEditors.SpinEdit blo_seTermina;
        private DevExpress.XtraEditors.SpinEdit blo_seInicia;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.SpinEdit seTiraje;
        private DevExpress.XtraGrid.Columns.GridColumn proc_gcColMinutos;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn arm_gcColGrupo;
        private System.Windows.Forms.ToolStripMenuItem mnuCalculaDISARM;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn arm_gcColTamanosXpliego;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn arm_gcColImpXtamano;
        private DevExpress.XtraTab.XtraTabPage xtpResumen;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LookUpEdit dis_lueComponente;
        private DevExpress.XtraGrid.GridControl mcli_gcMaterialCLI;
        private DevExpress.XtraGrid.Views.Grid.GridView mcli_gvMaterialCLI;
        private DevExpress.XtraGrid.Columns.GridColumn mcli_gcColMaterialCLI;
        private DevExpress.XtraGrid.Columns.GridColumn mcli_gcColCantidadCLI;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn arm_gcColNumPaginas;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn arm_gcColPaginasXtrabajo;
        private System.Windows.Forms.ToolStripMenuItem mnuVerGraficaDISARM;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit dis_riseAnchoTFinal;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit dis_ribeAltoTFinal;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn arm_gcColPliegoEXTPorcentaje;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit dis_risePorcentajePliegoEXT;
        private DevExpress.XtraGrid.Columns.GridColumn col_gcColCobertura;
        private DevExpress.XtraGrid.Columns.GridColumn col_gcColGramos;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn arm_gcColPlaca;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn arm_gcColSeleccionAUT;
        private DevExpress.XtraGrid.Columns.GridColumn col_gcColMaterialC;
        private DevExpress.XtraGrid.Columns.GridColumn col_gcColArea;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandaPliegoMP;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandaPliegoIMP;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandaPliego;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandaTrabajoFinal;
        private DevExpress.XtraGrid.Columns.GridColumn col_gcColTotGramos;
        private DevExpress.XtraGrid.Columns.GridColumn col_gcColCostoGramoColor;
        private DevExpress.XtraGrid.Columns.GridColumn col_gcColDetallePAG;
        private DevExpress.XtraGrid.Columns.GridColumn col_gcColLado;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit dis_rilueLadoImpresion;
        private System.Windows.Forms.ToolStripMenuItem mnuAgregaRegistro;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.SpinEdit dis_seGramosPantone;
        private DevExpress.XtraEditors.SpinEdit dis_seGramosMetalizado;
        private DevExpress.XtraEditors.SpinEdit dis_seGramosColor;
        private DevExpress.XtraGrid.Columns.GridColumn col_gcColNumPaginasC;
        private DevExpress.XtraTab.XtraTabPage dis_xtpPlacas;
        private DevExpress.XtraGrid.GridControl pla_gcPlacas;
        private DevExpress.XtraGrid.Views.Grid.GridView pla_gvPlacas;
        private DevExpress.XtraGrid.Columns.GridColumn pla_gcColMaterialP;
        private DevExpress.XtraGrid.Columns.GridColumn pla_gcColPlacaP;
        private DevExpress.XtraGrid.Columns.GridColumn pla_gcColLadoP;
        private DevExpress.XtraGrid.Columns.GridColumn pla_gcColNumColoresP;
        private DevExpress.XtraGrid.Columns.GridColumn pla_gcColCostoPlaca;
        private DevExpress.XtraGrid.Columns.GridColumn pla_gcTotalLineaP;
        private DevExpress.XtraTab.XtraTabPage dis_xtpTroquel;
        private DevExpress.XtraGrid.GridControl tro_gcTrqouel;
        private DevExpress.XtraGrid.Views.Grid.GridView tro_gvTroquel;
        private DevExpress.XtraGrid.Columns.GridColumn tro_gcColMaterialT;
        private DevExpress.XtraGrid.Columns.GridColumn tro_gcColLongitud;
        private DevExpress.XtraGrid.Columns.GridColumn tro_gcColNumCortesT;
        private DevExpress.XtraGrid.Columns.GridColumn tro_gcColCostoCorteT;
        private DevExpress.XtraGrid.Columns.GridColumn tro_gcColTotaLineaT;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit dis_rilueLadoImpresionP;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit dis_riseNumColores;
        private DevExpress.XtraGrid.Columns.GridColumn col_gcColTotLinea;
        private DevExpress.XtraGrid.Columns.GridColumn pla_gcColNumPlacasP;
        private DevExpress.XtraGrid.Columns.GridColumn pla_gcColNumPaginasP;
        private DevExpress.XtraGrid.Columns.GridColumn pla_gcColPaginasXplaca;
        private DevExpress.XtraGrid.Columns.GridColumn pla_gcColPlacasMIN;
        private System.Windows.Forms.ContextMenuStrip cmDisenoTroquel;
        private System.Windows.Forms.ToolStripMenuItem mnuAgregaRegTroquel;
        private System.Windows.Forms.ToolStripMenuItem mnuEliminaRegTroquel;
        private DevExpress.XtraTab.XtraTabPage dis_xtpAcabados;
        private DevExpress.XtraTab.XtraTabPage dis_xtpProcesos;
        private DevExpress.XtraTab.XtraTabPage dis_xtpProcesosIMP;
        private DevExpress.XtraGrid.GridControl aca_gcAcabados;
        private DevExpress.XtraGrid.Views.Grid.GridView aca_gvAcabados;
        private DevExpress.XtraGrid.Columns.GridColumn aca_gcColMaterialA;
        private DevExpress.XtraGrid.Columns.GridColumn aca_gcColAreaA;
        private DevExpress.XtraGrid.Columns.GridColumn aca_gcColAcabadoA;
        private DevExpress.XtraGrid.Columns.GridColumn aca_gcColCostoA;
        private DevExpress.XtraGrid.Columns.GridColumn aca_gcColAplicaA;
        private DevExpress.XtraGrid.Columns.GridColumn aca_gcColTotalLineaA;
        private System.Windows.Forms.ContextMenuStrip cmDisenoAcabado;
        private System.Windows.Forms.ToolStripMenuItem dis_mnuAgregaRegistro;
        private System.Windows.Forms.ToolStripMenuItem dis_mnuEliminaRegistro;
        private System.Windows.Forms.ToolStripMenuItem mnuAgregaAcabado;
        private DevExpress.XtraGrid.Columns.GridColumn aca_gcColMatAcabado;
        private DevExpress.XtraGrid.GridControl procimp_gcProcesoIMP;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView procimp_bgvProcesoIMP;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn procimp_gcColTallaI;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn procimp_gcColMaterialI;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn procimp_gcColNumColoresI;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn procimp_gcColCostoXminuto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn procimp_gcColMinImpresion;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn procimp_gcColPliegosXminuto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn procimp_gcColNumPliegos;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn procimp_gcColCostoXminutoPP;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn procimp_gcColMinutosPP;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn procimp_gcColTotalLineaI;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn procimp_gcColPlacaI;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand dis_bandaMaterial;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand dis_bandaImpresion;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand dis_bandaPuestaPunto;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand dis_bandaTotal;
        private DevExpress.XtraTab.XtraTabPage dis_xtpAccesorios;
        private DevExpress.XtraGrid.GridControl acce_gcAccesorios;
        private DevExpress.XtraGrid.Views.Grid.GridView acce_gvAccesorios;
        private DevExpress.XtraGrid.Columns.GridColumn acce_gcColMaterialS;
        private DevExpress.XtraGrid.Columns.GridColumn acce_gcColCantidadS;
        private DevExpress.XtraGrid.Columns.GridColumn acce_gcColCostoS;
        private DevExpress.XtraGrid.Columns.GridColumn acce_gcColTotalLineaS;
        private DevExpress.XtraGrid.Columns.GridColumn acce_gcColTirajeS;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit dis_riseCantAccesorio;
        private System.Windows.Forms.ContextMenuStrip cmDisenoAccesorios;
        private System.Windows.Forms.ToolStripMenuItem mnuAgregaAccesorio;
        private System.Windows.Forms.ToolStripMenuItem mnuEliminaAccesorio;
        private DevExpress.XtraGrid.GridControl tot_gcTotales;
        private DevExpress.XtraGrid.Views.Grid.GridView tot_gvTotales;
        private DevExpress.XtraGrid.Columns.GridColumn tot_gcColDescripcionT;
        private DevExpress.XtraGrid.Columns.GridColumn tot_gcColArmadosT;
        private DevExpress.XtraGrid.Columns.GridColumn tot_gcColoresT;
        private DevExpress.XtraGrid.Columns.GridColumn tot_gcPlacasT;
        private DevExpress.XtraGrid.Columns.GridColumn tot_gcColTotalLinealT;
        private DevExpress.XtraGrid.Columns.GridColumn tot_gcColTroquelT;
        private DevExpress.XtraGrid.Columns.GridColumn tot_gcColAccesorioT;
        private DevExpress.XtraGrid.Columns.GridColumn tot_gcColProcesoIMPT;
        private DevExpress.XtraGrid.Columns.GridColumn tot_gcColAcabadosT;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn arm_gcColTotalLinea;
        private DevExpress.XtraTab.XtraTabPage dis_xtpGeneral;
        private DevExpress.XtraTab.XtraTabPage dis_xtpMaterialCLI;
        private DevExpress.XtraEditors.GroupControl dis_gpGraficasH;
        private DevExpress.XtraGrid.GridControl gen_gcGraficasH;
        private DevExpress.XtraGrid.Views.Grid.GridView gen_gvGraficasH;
        private DevExpress.XtraEditors.GroupControl dis_gpOriginales;
        private DevExpress.XtraGrid.GridControl gen_gcOriginales;
        private DevExpress.XtraGrid.Views.Grid.GridView gen_gvOriginales;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColDescripcionGH;
        private DevExpress.XtraGrid.Columns.GridColumn gen_gcColDescripcionORI;
        private System.Windows.Forms.ContextMenuStrip cmDisenoGeneralGH;
        private System.Windows.Forms.ContextMenuStrip cmDisenoGeneralORI;
        private System.Windows.Forms.ToolStripMenuItem mnuAgregaRegistroGH;
        private System.Windows.Forms.ToolStripMenuItem mnuEliminaRegistroGH;
        private System.Windows.Forms.ToolStripMenuItem mnuAgregaRegistroORI;
        private System.Windows.Forms.ToolStripMenuItem mnuEliminaRegistroORI;
    }
}
