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
            this.xtpDiseno = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.dis_lueComponente = new DevExpress.XtraEditors.LookUpEdit();
            this.xtcDiseno = new DevExpress.XtraTab.XtraTabControl();
            this.dis_xtpArmados = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.dis_seTotalCostoPapel = new DevExpress.XtraEditors.SpinEdit();
            this.dis_gcArmados = new DevExpress.XtraGrid.GridControl();
            this.cmDisenoMatARMDIS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAgregaMATARMDIS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCalculaDISARM = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVerGraficaDISARM = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuitarMATARMDIS = new System.Windows.Forms.ToolStripMenuItem();
            this.dis_bgvArmados = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.bandaPliegoMP = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.dis_gcColSeleccionAUT = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_gcColGrupo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_gcColMaterial = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandaPliegoIMP = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.dis_gcColPlaca = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_gcColArmadoAncho = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_gcColArmadoAlto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_gcColImpXtamano = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandaPliego = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.dis_gcColPliegoMPAncho = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_gcColPliegoMPAlto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_gcColTamanosXpliego = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_gcColPliegoCantidad = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_gcPliegoEXTPorcentaje = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_risePorcentajePliegoEXT = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.dis_gcColPliegoExtra = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_gcColUndCotiza = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandaTrabajoFinal = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.dis_gcColAnchoTrabajoF = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_riseAnchoTFinal = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.dis_gcColAltoTrabajoF = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_ribeAltoTFinal = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.dis_gcColNumPaginas = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_gcColPaginasXtrabajo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_xtpColores = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.dis_seTotalCostoTinta = new DevExpress.XtraEditors.SpinEdit();
            this.dis_seGramosPantone = new DevExpress.XtraEditors.SpinEdit();
            this.dis_seGramosMetalizado = new DevExpress.XtraEditors.SpinEdit();
            this.dis_seGramosColor = new DevExpress.XtraEditors.SpinEdit();
            this.dis_gcColores = new DevExpress.XtraGrid.GridControl();
            this.cmDisenoColor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAgregaRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEliminaRegDisenoColor = new System.Windows.Forms.ToolStripMenuItem();
            this.dis_gvColores = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dis_gcColMaterialC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcColArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcColLado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_rilueLadoImpresion = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.dis_gcColTipoColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_rilueTipoColor = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.dis_gcColCostoGramoColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcColCobertura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_rilueCobertura = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.dis_gcColGramos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcColNumPaginasC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcColTotGramos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcColTotLinea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcColDetallePAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_xtpPlacas = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.dis_seTotalPlacas = new DevExpress.XtraEditors.SpinEdit();
            this.dis_seNumPlacas = new DevExpress.XtraEditors.SpinEdit();
            this.dis_gcPlacas = new DevExpress.XtraGrid.GridControl();
            this.dis_gvPlacas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dis_gcColMaterialP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcColPlacaP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcColLadoP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_rilueLadoImpresionP = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.dis_gcColNumColoresP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_riseNumColores = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.dis_gcColNumPaginasP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcColPaginasXplaca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcColPlacasMIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcColNumPlacasP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcColCostoPlaca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcTotalLineaP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_xtpTroquel = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.dis_seCortesTOT = new DevExpress.XtraEditors.SpinEdit();
            this.dis_seCorteLONG = new DevExpress.XtraEditors.SpinEdit();
            this.dis_gcTrqouel = new DevExpress.XtraGrid.GridControl();
            this.cmDisenoTroquel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAgregaRegTroquel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEliminaRegTroquel = new System.Windows.Forms.ToolStripMenuItem();
            this.dis_gvTroquel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dis_gcColMaterialT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcColLongitud = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcColNumCortesT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcColCostoCorteT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcColTotaLineaT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_xtpAcabados = new DevExpress.XtraTab.XtraTabPage();
            this.dis_gcAcabados = new DevExpress.XtraGrid.GridControl();
            this.cmDisenoAcabado = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dis_mnuAgregaRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAgregaAcabado = new System.Windows.Forms.ToolStripMenuItem();
            this.dis_mnuEliminaRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.dis_gvAcabados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dis_gcMaterialA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcAreaA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcAcabadoA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcColAcabadoMAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcCostoA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcAplicaA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcTotalLineaA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_xtpAccesorios = new DevExpress.XtraTab.XtraTabPage();
            this.dis_gcAccesorios = new DevExpress.XtraGrid.GridControl();
            this.dis_gvAccesorios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dis_gcColMaterialS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcColTirajeS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcColCantidadS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_riseCantAccesorio = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.dis_gcColCostoS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcColTotalLineaS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_xtpProcesos = new DevExpress.XtraTab.XtraTabPage();
            this.gc_Procesos = new DevExpress.XtraGrid.GridControl();
            this.cmProcesos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAgregaProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuitarProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.gvProcesos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.proc_gcColMaquina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.proc_gcColCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.proc_gcColCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.proc_gcColTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_xtpProcesosIMP = new DevExpress.XtraTab.XtraTabPage();
            this.dis_gcProcesoIMP = new DevExpress.XtraGrid.GridControl();
            this.dis_bgvProcesoIMP = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.dis_bandaMaterial = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.dis_gcColTallaI = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_gcColMaterialI = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_gcColNumColoresI = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_gcColPlacaI = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_bandaImpresion = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.dis_gcColCostoXminuto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_gcColMinImpresion = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_gcColPliegosXminuto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_gcColNumPliegos = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_bandaPuestaPunto = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.dis_gcColCostoXminutoPP = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_gcColMinutosPP = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dis_bandaTotal = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.dis_gcColTotalLineaI = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.xtpControlPRD = new DevExpress.XtraTab.XtraTabPage();
            this.xtpServiciosEXT = new DevExpress.XtraTab.XtraTabPage();
            this.sext_chkMetalico = new DevExpress.XtraEditors.CheckEdit();
            this.sext_chkResina = new DevExpress.XtraEditors.CheckEdit();
            this.sext_sePlastificadoPRE = new DevExpress.XtraEditors.SpinEdit();
            this.sext_seSeguroPRE = new DevExpress.XtraEditors.SpinEdit();
            this.sext_seTransportePRE = new DevExpress.XtraEditors.SpinEdit();
            this.sext_seTermoselladoPRE = new DevExpress.XtraEditors.SpinEdit();
            this.sext_seReservadoPRE = new DevExpress.XtraEditors.SpinEdit();
            this.sext_seCocidoPRE = new DevExpress.XtraEditors.SpinEdit();
            this.sext_seClishePRE = new DevExpress.XtraEditors.SpinEdit();
            this.sext_seTroquelPRE = new DevExpress.XtraEditors.SpinEdit();
            this.sext_sePeliculaPRE = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl83 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl82 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl81 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl71 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl70 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl69 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl68 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl67 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl66 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl62 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl61 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl60 = new DevExpress.XtraEditors.LabelControl();
            this.sext_txtClishe = new DevExpress.XtraEditors.TextEdit();
            this.sext_txtTroquel = new DevExpress.XtraEditors.TextEdit();
            this.sext_txtPelicula = new DevExpress.XtraEditors.TextEdit();
            this.xtpTerminaTercero = new DevExpress.XtraTab.XtraTabPage();
            this.xtpMateriales = new DevExpress.XtraTab.XtraTabPage();
            this.em_gcDetalleEGR = new DevExpress.XtraGrid.GridControl();
            this.em_gvDetalleEGR = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.em_gcColSeccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.em_rilueSeccion = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.em_gcColMaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.em_ribeBuscaMAT = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.em_gcColCantPliego = new DevExpress.XtraGrid.Columns.GridColumn();
            this.em_gcColExtras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.em_gcColCantTamano = new DevExpress.XtraGrid.Columns.GridColumn();
            this.em_gcColAncho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.em_gcColAlto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.em_gcColPlacasMQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.em_rilueMaquina = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.em_gcColCntPlacas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtpOtros = new DevExpress.XtraTab.XtraTabPage();
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
            this.xtpDisenoGEN = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gbGraficas = new DevExpress.XtraEditors.GroupControl();
            this.dis_chklGraficasH = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.gbOrginales = new DevExpress.XtraEditors.GroupControl();
            this.dis_chklOriginales = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.dis_gcMaterialCLI = new DevExpress.XtraGrid.GridControl();
            this.cmClienteMAT = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAgregaMATCLI = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuitaMATCLI = new System.Windows.Forms.ToolStripMenuItem();
            this.dis_gvMaterialCLI = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dis_gcColMaterialCLI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcColCantidadCLI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.seTiraje = new DevExpress.XtraEditors.SpinEdit();
            this.seAlto = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.seAncho = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chkEstadoCOT = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.deFechaCOT = new DevExpress.XtraEditors.DateEdit();
            this.txtCIRUCCLI = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombreCLI = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.beNumeroCOT = new DevExpress.XtraEditors.ButtonEdit();
            this.deFechaENT = new DevExpress.XtraEditors.DateEdit();
            this.beArticulo = new DevExpress.XtraEditors.ButtonEdit();
            this.cmDisenoAccesorios = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAgregaAccesorio = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEliminaAccesorio = new System.Windows.Forms.ToolStripMenuItem();
            this.pgf_CostoComponente = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pgfArmados = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pgfColores = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pgfPlacas = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pgfTroquel = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pgfComponente = new DevExpress.XtraPivotGrid.PivotGridField();
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
            this.xtpDiseno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_lueComponente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcDiseno)).BeginInit();
            this.xtcDiseno.SuspendLayout();
            this.dis_xtpArmados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_seTotalCostoPapel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_gcArmados)).BeginInit();
            this.cmDisenoMatARMDIS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_bgvArmados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_risePorcentajePliegoEXT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_riseAnchoTFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_ribeAltoTFinal)).BeginInit();
            this.dis_xtpColores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_seTotalCostoTinta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_seGramosPantone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_seGramosMetalizado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_seGramosColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_gcColores)).BeginInit();
            this.cmDisenoColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_gvColores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_rilueLadoImpresion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_rilueTipoColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_rilueCobertura)).BeginInit();
            this.dis_xtpPlacas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_seTotalPlacas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_seNumPlacas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_gcPlacas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_gvPlacas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_rilueLadoImpresionP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_riseNumColores)).BeginInit();
            this.dis_xtpTroquel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_seCortesTOT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_seCorteLONG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_gcTrqouel)).BeginInit();
            this.cmDisenoTroquel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_gvTroquel)).BeginInit();
            this.dis_xtpAcabados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_gcAcabados)).BeginInit();
            this.cmDisenoAcabado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_gvAcabados)).BeginInit();
            this.dis_xtpAccesorios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_gcAccesorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_gvAccesorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_riseCantAccesorio)).BeginInit();
            this.dis_xtpProcesos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Procesos)).BeginInit();
            this.cmProcesos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProcesos)).BeginInit();
            this.dis_xtpProcesosIMP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_gcProcesoIMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_bgvProcesoIMP)).BeginInit();
            this.xtpServiciosEXT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sext_chkMetalico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sext_chkResina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sext_sePlastificadoPRE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sext_seSeguroPRE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sext_seTransportePRE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sext_seTermoselladoPRE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sext_seReservadoPRE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sext_seCocidoPRE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sext_seClishePRE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sext_seTroquelPRE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sext_sePeliculaPRE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sext_txtClishe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sext_txtTroquel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sext_txtPelicula.Properties)).BeginInit();
            this.xtpMateriales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.em_gcDetalleEGR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.em_gvDetalleEGR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.em_rilueSeccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.em_ribeBuscaMAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.em_rilueMaquina)).BeginInit();
            this.xtpOtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueLineaPRD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEplCotizador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beEplVendedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSubgrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGrupo.Properties)).BeginInit();
            this.xtpDisenoGEN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbGraficas)).BeginInit();
            this.gbGraficas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_chklGraficasH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbOrginales)).BeginInit();
            this.gbOrginales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_chklOriginales)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_gcMaterialCLI)).BeginInit();
            this.cmClienteMAT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_gvMaterialCLI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTiraje.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAlto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAncho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstadoCOT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaCOT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaCOT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCIRUCCLI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCLI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beNumeroCOT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaENT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaENT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beArticulo.Properties)).BeginInit();
            this.cmDisenoAccesorios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgf_CostoComponente)).BeginInit();
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
            this.panel1.Controls.Add(this.chkEstadoCOT);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.deFechaCOT);
            this.panel1.Controls.Add(this.txtCIRUCCLI);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.txtNombreCLI);
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
            this.lblEstadoCOT.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblEstadoCOT.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblEstadoCOT.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblEstadoCOT.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblEstadoCOT.Location = new System.Drawing.Point(452, 5);
            this.lblEstadoCOT.Name = "lblEstadoCOT";
            this.lblEstadoCOT.Size = new System.Drawing.Size(209, 42);
            this.lblEstadoCOT.TabIndex = 72;
            this.lblEstadoCOT.Text = "Estado:";
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
            this.xtpBlocks,
            this.xtpDiseno,
            this.xtpControlPRD,
            this.xtpServiciosEXT,
            this.xtpTerminaTercero,
            this.xtpMateriales,
            this.xtpOtros,
            this.xtpDisenoGEN});
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
            this.xtcDiseno.SelectedTabPage = this.dis_xtpArmados;
            this.xtcDiseno.Size = new System.Drawing.Size(850, 270);
            this.xtcDiseno.TabIndex = 31;
            this.xtcDiseno.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.dis_xtpArmados,
            this.dis_xtpColores,
            this.dis_xtpPlacas,
            this.dis_xtpTroquel,
            this.dis_xtpAcabados,
            this.dis_xtpAccesorios,
            this.dis_xtpProcesos,
            this.dis_xtpProcesosIMP});
            // 
            // dis_xtpArmados
            // 
            this.dis_xtpArmados.Controls.Add(this.labelControl20);
            this.dis_xtpArmados.Controls.Add(this.dis_seTotalCostoPapel);
            this.dis_xtpArmados.Controls.Add(this.dis_gcArmados);
            this.dis_xtpArmados.Name = "dis_xtpArmados";
            this.dis_xtpArmados.Size = new System.Drawing.Size(844, 242);
            this.dis_xtpArmados.Text = "Armados";
            // 
            // labelControl20
            // 
            this.labelControl20.Location = new System.Drawing.Point(698, 219);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(28, 13);
            this.labelControl20.TabIndex = 2;
            this.labelControl20.Text = "Total:";
            // 
            // dis_seTotalCostoPapel
            // 
            this.dis_seTotalCostoPapel.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dis_seTotalCostoPapel.Location = new System.Drawing.Point(738, 216);
            this.dis_seTotalCostoPapel.Name = "dis_seTotalCostoPapel";
            this.dis_seTotalCostoPapel.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dis_seTotalCostoPapel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dis_seTotalCostoPapel.Properties.DisplayFormat.FormatString = "N2";
            this.dis_seTotalCostoPapel.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_seTotalCostoPapel.Properties.EditFormat.FormatString = "N2";
            this.dis_seTotalCostoPapel.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_seTotalCostoPapel.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dis_seTotalCostoPapel.Properties.MaxValue = new decimal(new int[] {
            999999999,
            0,
            0,
            131072});
            this.dis_seTotalCostoPapel.Properties.ReadOnly = true;
            this.dis_seTotalCostoPapel.Size = new System.Drawing.Size(100, 20);
            this.dis_seTotalCostoPapel.TabIndex = 1;
            // 
            // dis_gcArmados
            // 
            this.dis_gcArmados.ContextMenuStrip = this.cmDisenoMatARMDIS;
            this.dis_gcArmados.Location = new System.Drawing.Point(0, 3);
            this.dis_gcArmados.MainView = this.dis_bgvArmados;
            this.dis_gcArmados.Name = "dis_gcArmados";
            this.dis_gcArmados.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dis_riseAnchoTFinal,
            this.dis_ribeAltoTFinal,
            this.dis_risePorcentajePliegoEXT});
            this.dis_gcArmados.Size = new System.Drawing.Size(838, 207);
            this.dis_gcArmados.TabIndex = 0;
            this.dis_gcArmados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dis_bgvArmados});
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
            // dis_bgvArmados
            // 
            this.dis_bgvArmados.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.bandaPliegoMP,
            this.bandaPliegoIMP,
            this.bandaPliego,
            this.gridBand6,
            this.bandaTrabajoFinal});
            this.dis_bgvArmados.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.dis_gcColSeleccionAUT,
            this.dis_gcColGrupo,
            this.dis_gcColMaterial,
            this.dis_gcColAnchoTrabajoF,
            this.dis_gcColAltoTrabajoF,
            this.dis_gcColNumPaginas,
            this.dis_gcColPaginasXtrabajo,
            this.dis_gcColPliegoMPAncho,
            this.dis_gcColPliegoMPAlto,
            this.dis_gcColArmadoAncho,
            this.dis_gcColArmadoAlto,
            this.dis_gcColTamanosXpliego,
            this.dis_gcColImpXtamano,
            this.dis_gcColPliegoCantidad,
            this.dis_gcPliegoEXTPorcentaje,
            this.dis_gcColPliegoExtra,
            this.dis_gcColUndCotiza,
            this.dis_gcColPlaca});
            this.dis_bgvArmados.GridControl = this.dis_gcArmados;
            this.dis_bgvArmados.Name = "dis_bgvArmados";
            this.dis_bgvArmados.OptionsFilter.AllowFilterEditor = false;
            this.dis_bgvArmados.OptionsView.ColumnAutoWidth = false;
            this.dis_bgvArmados.OptionsView.ShowGroupPanel = false;
            this.dis_bgvArmados.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.dis_bgvArmados_CellValueChanged);
            // 
            // bandaPliegoMP
            // 
            this.bandaPliegoMP.AppearanceHeader.Options.UseTextOptions = true;
            this.bandaPliegoMP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandaPliegoMP.Caption = "Mat. Prima";
            this.bandaPliegoMP.Columns.Add(this.dis_gcColSeleccionAUT);
            this.bandaPliegoMP.Columns.Add(this.dis_gcColGrupo);
            this.bandaPliegoMP.Columns.Add(this.dis_gcColMaterial);
            this.bandaPliegoMP.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.bandaPliegoMP.Name = "bandaPliegoMP";
            this.bandaPliegoMP.OptionsBand.AllowMove = false;
            this.bandaPliegoMP.VisibleIndex = 0;
            this.bandaPliegoMP.Width = 376;
            // 
            // dis_gcColSeleccionAUT
            // 
            this.dis_gcColSeleccionAUT.Caption = "AUT";
            this.dis_gcColSeleccionAUT.FieldName = "AUT";
            this.dis_gcColSeleccionAUT.Name = "dis_gcColSeleccionAUT";
            this.dis_gcColSeleccionAUT.OptionsColumn.AllowEdit = false;
            this.dis_gcColSeleccionAUT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColSeleccionAUT.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColSeleccionAUT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColSeleccionAUT.OptionsColumn.AllowMove = false;
            this.dis_gcColSeleccionAUT.OptionsColumn.AllowShowHide = false;
            this.dis_gcColSeleccionAUT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColSeleccionAUT.OptionsColumn.ReadOnly = true;
            this.dis_gcColSeleccionAUT.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColSeleccionAUT.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColSeleccionAUT.Visible = true;
            this.dis_gcColSeleccionAUT.Width = 38;
            // 
            // dis_gcColGrupo
            // 
            this.dis_gcColGrupo.Caption = "Grupo";
            this.dis_gcColGrupo.FieldName = "Talla";
            this.dis_gcColGrupo.Name = "dis_gcColGrupo";
            this.dis_gcColGrupo.OptionsColumn.AllowEdit = false;
            this.dis_gcColGrupo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColGrupo.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColGrupo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColGrupo.OptionsColumn.AllowMove = false;
            this.dis_gcColGrupo.OptionsColumn.AllowShowHide = false;
            this.dis_gcColGrupo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColGrupo.OptionsColumn.ReadOnly = true;
            this.dis_gcColGrupo.Visible = true;
            this.dis_gcColGrupo.Width = 113;
            // 
            // dis_gcColMaterial
            // 
            this.dis_gcColMaterial.Caption = "Material";
            this.dis_gcColMaterial.FieldName = "Material";
            this.dis_gcColMaterial.Name = "dis_gcColMaterial";
            this.dis_gcColMaterial.OptionsColumn.AllowEdit = false;
            this.dis_gcColMaterial.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMaterial.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColMaterial.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMaterial.OptionsColumn.AllowMove = false;
            this.dis_gcColMaterial.OptionsColumn.AllowShowHide = false;
            this.dis_gcColMaterial.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMaterial.OptionsColumn.ReadOnly = true;
            this.dis_gcColMaterial.Visible = true;
            this.dis_gcColMaterial.Width = 225;
            // 
            // bandaPliegoIMP
            // 
            this.bandaPliegoIMP.AppearanceHeader.Options.UseTextOptions = true;
            this.bandaPliegoIMP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandaPliegoIMP.Caption = "Armados";
            this.bandaPliegoIMP.Columns.Add(this.dis_gcColPlaca);
            this.bandaPliegoIMP.Columns.Add(this.dis_gcColArmadoAncho);
            this.bandaPliegoIMP.Columns.Add(this.dis_gcColArmadoAlto);
            this.bandaPliegoIMP.Columns.Add(this.dis_gcColImpXtamano);
            this.bandaPliegoIMP.Name = "bandaPliegoIMP";
            this.bandaPliegoIMP.OptionsBand.AllowMove = false;
            this.bandaPliegoIMP.VisibleIndex = 1;
            this.bandaPliegoIMP.Width = 264;
            // 
            // dis_gcColPlaca
            // 
            this.dis_gcColPlaca.Caption = "Máquina";
            this.dis_gcColPlaca.FieldName = "Placa";
            this.dis_gcColPlaca.Name = "dis_gcColPlaca";
            this.dis_gcColPlaca.OptionsColumn.AllowEdit = false;
            this.dis_gcColPlaca.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPlaca.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColPlaca.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPlaca.OptionsColumn.AllowMove = false;
            this.dis_gcColPlaca.OptionsColumn.AllowShowHide = false;
            this.dis_gcColPlaca.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPlaca.OptionsColumn.ReadOnly = true;
            this.dis_gcColPlaca.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColPlaca.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPlaca.Visible = true;
            // 
            // dis_gcColArmadoAncho
            // 
            this.dis_gcColArmadoAncho.Caption = "Ancho";
            this.dis_gcColArmadoAncho.DisplayFormat.FormatString = "N2";
            this.dis_gcColArmadoAncho.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dis_gcColArmadoAncho.FieldName = "TamanoAncho";
            this.dis_gcColArmadoAncho.Name = "dis_gcColArmadoAncho";
            this.dis_gcColArmadoAncho.OptionsColumn.AllowEdit = false;
            this.dis_gcColArmadoAncho.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColArmadoAncho.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColArmadoAncho.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColArmadoAncho.OptionsColumn.AllowMove = false;
            this.dis_gcColArmadoAncho.OptionsColumn.AllowShowHide = false;
            this.dis_gcColArmadoAncho.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColArmadoAncho.OptionsColumn.ReadOnly = true;
            this.dis_gcColArmadoAncho.Visible = true;
            this.dis_gcColArmadoAncho.Width = 53;
            // 
            // dis_gcColArmadoAlto
            // 
            this.dis_gcColArmadoAlto.Caption = "Alto";
            this.dis_gcColArmadoAlto.DisplayFormat.FormatString = "N2";
            this.dis_gcColArmadoAlto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dis_gcColArmadoAlto.FieldName = "TamanoAlto";
            this.dis_gcColArmadoAlto.Name = "dis_gcColArmadoAlto";
            this.dis_gcColArmadoAlto.OptionsColumn.AllowEdit = false;
            this.dis_gcColArmadoAlto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColArmadoAlto.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColArmadoAlto.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColArmadoAlto.OptionsColumn.AllowMove = false;
            this.dis_gcColArmadoAlto.OptionsColumn.AllowShowHide = false;
            this.dis_gcColArmadoAlto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColArmadoAlto.OptionsColumn.ReadOnly = true;
            this.dis_gcColArmadoAlto.Visible = true;
            this.dis_gcColArmadoAlto.Width = 55;
            // 
            // dis_gcColImpXtamano
            // 
            this.dis_gcColImpXtamano.Caption = "Trab X Tam";
            this.dis_gcColImpXtamano.DisplayFormat.FormatString = "N0";
            this.dis_gcColImpXtamano.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcColImpXtamano.FieldName = "TrabajosXtamano";
            this.dis_gcColImpXtamano.Name = "dis_gcColImpXtamano";
            this.dis_gcColImpXtamano.OptionsColumn.AllowEdit = false;
            this.dis_gcColImpXtamano.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColImpXtamano.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColImpXtamano.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColImpXtamano.OptionsColumn.AllowMove = false;
            this.dis_gcColImpXtamano.OptionsColumn.AllowShowHide = false;
            this.dis_gcColImpXtamano.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColImpXtamano.OptionsColumn.ReadOnly = true;
            this.dis_gcColImpXtamano.Visible = true;
            this.dis_gcColImpXtamano.Width = 81;
            // 
            // bandaPliego
            // 
            this.bandaPliego.AppearanceHeader.Options.UseTextOptions = true;
            this.bandaPliego.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandaPliego.Caption = "Pliegos";
            this.bandaPliego.Columns.Add(this.dis_gcColPliegoMPAncho);
            this.bandaPliego.Columns.Add(this.dis_gcColPliegoMPAlto);
            this.bandaPliego.Columns.Add(this.dis_gcColTamanosXpliego);
            this.bandaPliego.Columns.Add(this.dis_gcColPliegoCantidad);
            this.bandaPliego.Columns.Add(this.dis_gcPliegoEXTPorcentaje);
            this.bandaPliego.Columns.Add(this.dis_gcColPliegoExtra);
            this.bandaPliego.Columns.Add(this.dis_gcColUndCotiza);
            this.bandaPliego.Name = "bandaPliego";
            this.bandaPliego.OptionsBand.AllowMove = false;
            this.bandaPliego.VisibleIndex = 2;
            this.bandaPliego.Width = 438;
            // 
            // dis_gcColPliegoMPAncho
            // 
            this.dis_gcColPliegoMPAncho.Caption = "Ancho";
            this.dis_gcColPliegoMPAncho.DisplayFormat.FormatString = "N2";
            this.dis_gcColPliegoMPAncho.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dis_gcColPliegoMPAncho.FieldName = "PliegoAncho";
            this.dis_gcColPliegoMPAncho.Name = "dis_gcColPliegoMPAncho";
            this.dis_gcColPliegoMPAncho.OptionsColumn.AllowEdit = false;
            this.dis_gcColPliegoMPAncho.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPliegoMPAncho.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColPliegoMPAncho.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPliegoMPAncho.OptionsColumn.AllowMove = false;
            this.dis_gcColPliegoMPAncho.OptionsColumn.AllowShowHide = false;
            this.dis_gcColPliegoMPAncho.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPliegoMPAncho.OptionsColumn.ReadOnly = true;
            this.dis_gcColPliegoMPAncho.Visible = true;
            this.dis_gcColPliegoMPAncho.Width = 51;
            // 
            // dis_gcColPliegoMPAlto
            // 
            this.dis_gcColPliegoMPAlto.Caption = "Alto";
            this.dis_gcColPliegoMPAlto.DisplayFormat.FormatString = "N2";
            this.dis_gcColPliegoMPAlto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dis_gcColPliegoMPAlto.FieldName = "PliegoAlto";
            this.dis_gcColPliegoMPAlto.Name = "dis_gcColPliegoMPAlto";
            this.dis_gcColPliegoMPAlto.OptionsColumn.AllowEdit = false;
            this.dis_gcColPliegoMPAlto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPliegoMPAlto.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColPliegoMPAlto.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPliegoMPAlto.OptionsColumn.AllowMove = false;
            this.dis_gcColPliegoMPAlto.OptionsColumn.AllowShowHide = false;
            this.dis_gcColPliegoMPAlto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPliegoMPAlto.OptionsColumn.ReadOnly = true;
            this.dis_gcColPliegoMPAlto.Visible = true;
            this.dis_gcColPliegoMPAlto.Width = 55;
            // 
            // dis_gcColTamanosXpliego
            // 
            this.dis_gcColTamanosXpliego.Caption = "Tam X Plie";
            this.dis_gcColTamanosXpliego.DisplayFormat.FormatString = "N0";
            this.dis_gcColTamanosXpliego.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcColTamanosXpliego.FieldName = "TamanosXpliego";
            this.dis_gcColTamanosXpliego.Name = "dis_gcColTamanosXpliego";
            this.dis_gcColTamanosXpliego.OptionsColumn.AllowEdit = false;
            this.dis_gcColTamanosXpliego.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTamanosXpliego.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColTamanosXpliego.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTamanosXpliego.OptionsColumn.AllowMove = false;
            this.dis_gcColTamanosXpliego.OptionsColumn.AllowShowHide = false;
            this.dis_gcColTamanosXpliego.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTamanosXpliego.OptionsColumn.ReadOnly = true;
            this.dis_gcColTamanosXpliego.Visible = true;
            this.dis_gcColTamanosXpliego.Width = 65;
            // 
            // dis_gcColPliegoCantidad
            // 
            this.dis_gcColPliegoCantidad.Caption = "Cant";
            this.dis_gcColPliegoCantidad.DisplayFormat.FormatString = "N0";
            this.dis_gcColPliegoCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcColPliegoCantidad.FieldName = "PliegoCantidad";
            this.dis_gcColPliegoCantidad.Name = "dis_gcColPliegoCantidad";
            this.dis_gcColPliegoCantidad.OptionsColumn.AllowEdit = false;
            this.dis_gcColPliegoCantidad.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPliegoCantidad.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColPliegoCantidad.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPliegoCantidad.OptionsColumn.AllowMove = false;
            this.dis_gcColPliegoCantidad.OptionsColumn.AllowShowHide = false;
            this.dis_gcColPliegoCantidad.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPliegoCantidad.OptionsColumn.ReadOnly = true;
            this.dis_gcColPliegoCantidad.Visible = true;
            this.dis_gcColPliegoCantidad.Width = 50;
            // 
            // dis_gcPliegoEXTPorcentaje
            // 
            this.dis_gcPliegoEXTPorcentaje.Caption = "Extra %";
            this.dis_gcPliegoEXTPorcentaje.ColumnEdit = this.dis_risePorcentajePliegoEXT;
            this.dis_gcPliegoEXTPorcentaje.FieldName = "PorcentajeEXT";
            this.dis_gcPliegoEXTPorcentaje.Name = "dis_gcPliegoEXTPorcentaje";
            this.dis_gcPliegoEXTPorcentaje.Visible = true;
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
            // dis_gcColPliegoExtra
            // 
            this.dis_gcColPliegoExtra.Caption = "Extra Nro";
            this.dis_gcColPliegoExtra.DisplayFormat.FormatString = "N0";
            this.dis_gcColPliegoExtra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcColPliegoExtra.FieldName = "Extra";
            this.dis_gcColPliegoExtra.Name = "dis_gcColPliegoExtra";
            this.dis_gcColPliegoExtra.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPliegoExtra.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColPliegoExtra.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPliegoExtra.OptionsColumn.AllowMove = false;
            this.dis_gcColPliegoExtra.OptionsColumn.AllowShowHide = false;
            this.dis_gcColPliegoExtra.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPliegoExtra.Visible = true;
            this.dis_gcColPliegoExtra.Width = 62;
            // 
            // dis_gcColUndCotiza
            // 
            this.dis_gcColUndCotiza.Caption = "Cotizadas";
            this.dis_gcColUndCotiza.DisplayFormat.FormatString = "N0";
            this.dis_gcColUndCotiza.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcColUndCotiza.FieldName = "PliegoCotizados";
            this.dis_gcColUndCotiza.Name = "dis_gcColUndCotiza";
            this.dis_gcColUndCotiza.OptionsColumn.AllowEdit = false;
            this.dis_gcColUndCotiza.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColUndCotiza.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColUndCotiza.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColUndCotiza.OptionsColumn.AllowMove = false;
            this.dis_gcColUndCotiza.OptionsColumn.AllowShowHide = false;
            this.dis_gcColUndCotiza.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColUndCotiza.OptionsColumn.ReadOnly = true;
            this.dis_gcColUndCotiza.Visible = true;
            this.dis_gcColUndCotiza.Width = 80;
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
            this.bandaTrabajoFinal.Columns.Add(this.dis_gcColAnchoTrabajoF);
            this.bandaTrabajoFinal.Columns.Add(this.dis_gcColAltoTrabajoF);
            this.bandaTrabajoFinal.Columns.Add(this.dis_gcColNumPaginas);
            this.bandaTrabajoFinal.Columns.Add(this.dis_gcColPaginasXtrabajo);
            this.bandaTrabajoFinal.Name = "bandaTrabajoFinal";
            this.bandaTrabajoFinal.VisibleIndex = 3;
            this.bandaTrabajoFinal.Width = 293;
            // 
            // dis_gcColAnchoTrabajoF
            // 
            this.dis_gcColAnchoTrabajoF.Caption = "Ancho";
            this.dis_gcColAnchoTrabajoF.ColumnEdit = this.dis_riseAnchoTFinal;
            this.dis_gcColAnchoTrabajoF.FieldName = "TrabajoAncho";
            this.dis_gcColAnchoTrabajoF.Name = "dis_gcColAnchoTrabajoF";
            this.dis_gcColAnchoTrabajoF.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColAnchoTrabajoF.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColAnchoTrabajoF.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColAnchoTrabajoF.OptionsColumn.AllowMove = false;
            this.dis_gcColAnchoTrabajoF.OptionsColumn.AllowShowHide = false;
            this.dis_gcColAnchoTrabajoF.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColAnchoTrabajoF.Visible = true;
            this.dis_gcColAnchoTrabajoF.Width = 69;
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
            // dis_gcColAltoTrabajoF
            // 
            this.dis_gcColAltoTrabajoF.Caption = "Alto";
            this.dis_gcColAltoTrabajoF.ColumnEdit = this.dis_ribeAltoTFinal;
            this.dis_gcColAltoTrabajoF.FieldName = "TrabajoAlto";
            this.dis_gcColAltoTrabajoF.Name = "dis_gcColAltoTrabajoF";
            this.dis_gcColAltoTrabajoF.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColAltoTrabajoF.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColAltoTrabajoF.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColAltoTrabajoF.OptionsColumn.AllowMove = false;
            this.dis_gcColAltoTrabajoF.OptionsColumn.AllowShowHide = false;
            this.dis_gcColAltoTrabajoF.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColAltoTrabajoF.Visible = true;
            this.dis_gcColAltoTrabajoF.Width = 74;
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
            // dis_gcColNumPaginas
            // 
            this.dis_gcColNumPaginas.Caption = "Num. Páginas";
            this.dis_gcColNumPaginas.DisplayFormat.FormatString = "N0";
            this.dis_gcColNumPaginas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcColNumPaginas.FieldName = "NumPaginas";
            this.dis_gcColNumPaginas.Name = "dis_gcColNumPaginas";
            this.dis_gcColNumPaginas.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumPaginas.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColNumPaginas.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumPaginas.OptionsColumn.AllowMove = false;
            this.dis_gcColNumPaginas.OptionsColumn.AllowShowHide = false;
            this.dis_gcColNumPaginas.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumPaginas.Visible = true;
            // 
            // dis_gcColPaginasXtrabajo
            // 
            this.dis_gcColPaginasXtrabajo.Caption = "Pag X Trab";
            this.dis_gcColPaginasXtrabajo.DisplayFormat.FormatString = "N0";
            this.dis_gcColPaginasXtrabajo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcColPaginasXtrabajo.FieldName = "PaginasXtrabajo";
            this.dis_gcColPaginasXtrabajo.Name = "dis_gcColPaginasXtrabajo";
            this.dis_gcColPaginasXtrabajo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPaginasXtrabajo.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColPaginasXtrabajo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPaginasXtrabajo.OptionsColumn.AllowMove = false;
            this.dis_gcColPaginasXtrabajo.OptionsColumn.AllowShowHide = false;
            this.dis_gcColPaginasXtrabajo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPaginasXtrabajo.Visible = true;
            // 
            // dis_xtpColores
            // 
            this.dis_xtpColores.Controls.Add(this.labelControl19);
            this.dis_xtpColores.Controls.Add(this.labelControl18);
            this.dis_xtpColores.Controls.Add(this.labelControl17);
            this.dis_xtpColores.Controls.Add(this.labelControl16);
            this.dis_xtpColores.Controls.Add(this.dis_seTotalCostoTinta);
            this.dis_xtpColores.Controls.Add(this.dis_seGramosPantone);
            this.dis_xtpColores.Controls.Add(this.dis_seGramosMetalizado);
            this.dis_xtpColores.Controls.Add(this.dis_seGramosColor);
            this.dis_xtpColores.Controls.Add(this.dis_gcColores);
            this.dis_xtpColores.Name = "dis_xtpColores";
            this.dis_xtpColores.Size = new System.Drawing.Size(844, 242);
            this.dis_xtpColores.Text = "Colores";
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(709, 219);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(28, 13);
            this.labelControl19.TabIndex = 8;
            this.labelControl19.Text = "Total:";
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(453, 220);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(83, 13);
            this.labelControl18.TabIndex = 7;
            this.labelControl18.Text = "Gramos Pantone:";
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(214, 220);
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
            // dis_seTotalCostoTinta
            // 
            this.dis_seTotalCostoTinta.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dis_seTotalCostoTinta.Location = new System.Drawing.Point(744, 216);
            this.dis_seTotalCostoTinta.Name = "dis_seTotalCostoTinta";
            this.dis_seTotalCostoTinta.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dis_seTotalCostoTinta.Properties.Appearance.Options.UseBackColor = true;
            this.dis_seTotalCostoTinta.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dis_seTotalCostoTinta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dis_seTotalCostoTinta.Properties.DisplayFormat.FormatString = "N2";
            this.dis_seTotalCostoTinta.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_seTotalCostoTinta.Properties.EditFormat.FormatString = "N2";
            this.dis_seTotalCostoTinta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_seTotalCostoTinta.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dis_seTotalCostoTinta.Properties.MaxValue = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.dis_seTotalCostoTinta.Properties.ReadOnly = true;
            this.dis_seTotalCostoTinta.Size = new System.Drawing.Size(94, 20);
            this.dis_seTotalCostoTinta.TabIndex = 4;
            // 
            // dis_seGramosPantone
            // 
            this.dis_seGramosPantone.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dis_seGramosPantone.Location = new System.Drawing.Point(547, 216);
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
            this.dis_seGramosMetalizado.Location = new System.Drawing.Point(325, 217);
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
            // dis_gcColores
            // 
            this.dis_gcColores.ContextMenuStrip = this.cmDisenoColor;
            this.dis_gcColores.Location = new System.Drawing.Point(3, 3);
            this.dis_gcColores.MainView = this.dis_gvColores;
            this.dis_gcColores.Name = "dis_gcColores";
            this.dis_gcColores.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dis_rilueTipoColor,
            this.dis_rilueCobertura,
            this.dis_rilueLadoImpresion});
            this.dis_gcColores.Size = new System.Drawing.Size(835, 207);
            this.dis_gcColores.TabIndex = 0;
            this.dis_gcColores.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dis_gvColores});
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
            // dis_gvColores
            // 
            this.dis_gvColores.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.dis_gcColMaterialC,
            this.dis_gcColArea,
            this.dis_gcColLado,
            this.dis_gcColTipoColor,
            this.dis_gcColCostoGramoColor,
            this.dis_gcColCobertura,
            this.dis_gcColGramos,
            this.dis_gcColNumPaginasC,
            this.dis_gcColTotGramos,
            this.dis_gcColTotLinea,
            this.dis_gcColDetallePAG});
            this.dis_gvColores.GridControl = this.dis_gcColores;
            this.dis_gvColores.Name = "dis_gvColores";
            this.dis_gvColores.OptionsView.ColumnAutoWidth = false;
            this.dis_gvColores.OptionsView.ShowGroupPanel = false;
            // 
            // dis_gcColMaterialC
            // 
            this.dis_gcColMaterialC.Caption = "Material";
            this.dis_gcColMaterialC.FieldName = "Material";
            this.dis_gcColMaterialC.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.dis_gcColMaterialC.Name = "dis_gcColMaterialC";
            this.dis_gcColMaterialC.OptionsColumn.AllowEdit = false;
            this.dis_gcColMaterialC.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMaterialC.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColMaterialC.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMaterialC.OptionsColumn.AllowMove = false;
            this.dis_gcColMaterialC.OptionsColumn.AllowShowHide = false;
            this.dis_gcColMaterialC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMaterialC.OptionsColumn.ReadOnly = true;
            this.dis_gcColMaterialC.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColMaterialC.OptionsFilter.AllowFilter = false;
            this.dis_gcColMaterialC.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMaterialC.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.dis_gcColMaterialC.ToolTip = "Material al que está asignando el color";
            this.dis_gcColMaterialC.Visible = true;
            this.dis_gcColMaterialC.VisibleIndex = 0;
            this.dis_gcColMaterialC.Width = 200;
            // 
            // dis_gcColArea
            // 
            this.dis_gcColArea.Caption = "Area cm2";
            this.dis_gcColArea.DisplayFormat.FormatString = "N2";
            this.dis_gcColArea.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcColArea.FieldName = "Area";
            this.dis_gcColArea.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.dis_gcColArea.Name = "dis_gcColArea";
            this.dis_gcColArea.OptionsColumn.AllowEdit = false;
            this.dis_gcColArea.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColArea.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColArea.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColArea.OptionsColumn.AllowMove = false;
            this.dis_gcColArea.OptionsColumn.AllowShowHide = false;
            this.dis_gcColArea.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColArea.OptionsColumn.ReadOnly = true;
            this.dis_gcColArea.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColArea.OptionsFilter.AllowFilter = false;
            this.dis_gcColArea.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColArea.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.dis_gcColArea.ToolTip = "Area de impresión. (Default=Area del trabajo final)";
            this.dis_gcColArea.Visible = true;
            this.dis_gcColArea.VisibleIndex = 1;
            this.dis_gcColArea.Width = 60;
            // 
            // dis_gcColLado
            // 
            this.dis_gcColLado.Caption = "Lado";
            this.dis_gcColLado.ColumnEdit = this.dis_rilueLadoImpresion;
            this.dis_gcColLado.FieldName = "LadoImpresion";
            this.dis_gcColLado.Name = "dis_gcColLado";
            this.dis_gcColLado.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColLado.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColLado.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColLado.OptionsColumn.AllowMove = false;
            this.dis_gcColLado.OptionsColumn.AllowShowHide = false;
            this.dis_gcColLado.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColLado.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColLado.OptionsFilter.AllowFilter = false;
            this.dis_gcColLado.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColLado.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.dis_gcColLado.ToolTip = "Lados de impresion (Tiro, Retiro, Tiro Y Retiro[Cuando los dos lados tienen la mi" +
    "sma textura])";
            this.dis_gcColLado.Visible = true;
            this.dis_gcColLado.VisibleIndex = 2;
            this.dis_gcColLado.Width = 100;
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
            // dis_gcColTipoColor
            // 
            this.dis_gcColTipoColor.Caption = "Color";
            this.dis_gcColTipoColor.ColumnEdit = this.dis_rilueTipoColor;
            this.dis_gcColTipoColor.FieldName = "Color";
            this.dis_gcColTipoColor.Name = "dis_gcColTipoColor";
            this.dis_gcColTipoColor.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTipoColor.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColTipoColor.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTipoColor.OptionsColumn.AllowMove = false;
            this.dis_gcColTipoColor.OptionsColumn.AllowShowHide = false;
            this.dis_gcColTipoColor.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTipoColor.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColTipoColor.OptionsFilter.AllowFilter = false;
            this.dis_gcColTipoColor.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTipoColor.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.dis_gcColTipoColor.ToolTip = "Tipo de color que va a utilizar";
            this.dis_gcColTipoColor.Visible = true;
            this.dis_gcColTipoColor.VisibleIndex = 3;
            this.dis_gcColTipoColor.Width = 100;
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
            // dis_gcColCostoGramoColor
            // 
            this.dis_gcColCostoGramoColor.Caption = "Costo";
            this.dis_gcColCostoGramoColor.DisplayFormat.FormatString = "e3";
            this.dis_gcColCostoGramoColor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcColCostoGramoColor.FieldName = "CostoGramo";
            this.dis_gcColCostoGramoColor.Name = "dis_gcColCostoGramoColor";
            this.dis_gcColCostoGramoColor.OptionsColumn.AllowEdit = false;
            this.dis_gcColCostoGramoColor.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCostoGramoColor.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColCostoGramoColor.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCostoGramoColor.OptionsColumn.AllowMove = false;
            this.dis_gcColCostoGramoColor.OptionsColumn.AllowShowHide = false;
            this.dis_gcColCostoGramoColor.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCostoGramoColor.OptionsColumn.ReadOnly = true;
            this.dis_gcColCostoGramoColor.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColCostoGramoColor.OptionsFilter.AllowFilter = false;
            this.dis_gcColCostoGramoColor.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCostoGramoColor.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.dis_gcColCostoGramoColor.ToolTip = "Costo aproximado de cada gramo en funcion del color";
            this.dis_gcColCostoGramoColor.Visible = true;
            this.dis_gcColCostoGramoColor.VisibleIndex = 4;
            this.dis_gcColCostoGramoColor.Width = 72;
            // 
            // dis_gcColCobertura
            // 
            this.dis_gcColCobertura.Caption = "Cob %";
            this.dis_gcColCobertura.ColumnEdit = this.dis_rilueCobertura;
            this.dis_gcColCobertura.FieldName = "Cobertura";
            this.dis_gcColCobertura.Name = "dis_gcColCobertura";
            this.dis_gcColCobertura.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCobertura.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColCobertura.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCobertura.OptionsColumn.AllowMove = false;
            this.dis_gcColCobertura.OptionsColumn.AllowShowHide = false;
            this.dis_gcColCobertura.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCobertura.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColCobertura.OptionsFilter.AllowFilter = false;
            this.dis_gcColCobertura.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCobertura.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.dis_gcColCobertura.ToolTip = "Porcentaje de cobertura de la página";
            this.dis_gcColCobertura.Visible = true;
            this.dis_gcColCobertura.VisibleIndex = 5;
            this.dis_gcColCobertura.Width = 55;
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
            // dis_gcColGramos
            // 
            this.dis_gcColGramos.Caption = "Gr X cm2";
            this.dis_gcColGramos.DisplayFormat.FormatString = "N2";
            this.dis_gcColGramos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcColGramos.FieldName = "GramosXcm2";
            this.dis_gcColGramos.Name = "dis_gcColGramos";
            this.dis_gcColGramos.OptionsColumn.AllowEdit = false;
            this.dis_gcColGramos.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColGramos.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColGramos.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColGramos.OptionsColumn.AllowMove = false;
            this.dis_gcColGramos.OptionsColumn.AllowShowHide = false;
            this.dis_gcColGramos.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColGramos.OptionsColumn.ReadOnly = true;
            this.dis_gcColGramos.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColGramos.OptionsFilter.AllowFilter = false;
            this.dis_gcColGramos.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColGramos.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.dis_gcColGramos.ToolTip = "Recupera de la BD en función de la cobertura";
            this.dis_gcColGramos.Visible = true;
            this.dis_gcColGramos.VisibleIndex = 6;
            this.dis_gcColGramos.Width = 54;
            // 
            // dis_gcColNumPaginasC
            // 
            this.dis_gcColNumPaginasC.Caption = "Paginas";
            this.dis_gcColNumPaginasC.DisplayFormat.FormatString = "N0";
            this.dis_gcColNumPaginasC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcColNumPaginasC.FieldName = "NumPaginas";
            this.dis_gcColNumPaginasC.Name = "dis_gcColNumPaginasC";
            this.dis_gcColNumPaginasC.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumPaginasC.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColNumPaginasC.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumPaginasC.OptionsColumn.AllowMove = false;
            this.dis_gcColNumPaginasC.OptionsColumn.AllowShowHide = false;
            this.dis_gcColNumPaginasC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumPaginasC.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColNumPaginasC.OptionsFilter.AllowFilter = false;
            this.dis_gcColNumPaginasC.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumPaginasC.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.dis_gcColNumPaginasC.ToolTip = "Número de páginas de cada trabajo. (Default=1)";
            this.dis_gcColNumPaginasC.Visible = true;
            this.dis_gcColNumPaginasC.VisibleIndex = 7;
            this.dis_gcColNumPaginasC.Width = 60;
            // 
            // dis_gcColTotGramos
            // 
            this.dis_gcColTotGramos.Caption = "Total GR";
            this.dis_gcColTotGramos.DisplayFormat.FormatString = "N2";
            this.dis_gcColTotGramos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcColTotGramos.FieldName = "TotalGramos";
            this.dis_gcColTotGramos.Name = "dis_gcColTotGramos";
            this.dis_gcColTotGramos.OptionsColumn.AllowEdit = false;
            this.dis_gcColTotGramos.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTotGramos.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColTotGramos.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTotGramos.OptionsColumn.AllowMove = false;
            this.dis_gcColTotGramos.OptionsColumn.AllowShowHide = false;
            this.dis_gcColTotGramos.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTotGramos.OptionsColumn.ReadOnly = true;
            this.dis_gcColTotGramos.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColTotGramos.OptionsFilter.AllowFilter = false;
            this.dis_gcColTotGramos.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTotGramos.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.dis_gcColTotGramos.ToolTip = "Area*NumPaginas*Gramos";
            this.dis_gcColTotGramos.Visible = true;
            this.dis_gcColTotGramos.VisibleIndex = 8;
            // 
            // dis_gcColTotLinea
            // 
            this.dis_gcColTotLinea.Caption = "Total $";
            this.dis_gcColTotLinea.DisplayFormat.FormatString = "N2";
            this.dis_gcColTotLinea.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcColTotLinea.FieldName = "TotalLinea";
            this.dis_gcColTotLinea.Name = "dis_gcColTotLinea";
            this.dis_gcColTotLinea.OptionsColumn.AllowEdit = false;
            this.dis_gcColTotLinea.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTotLinea.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColTotLinea.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTotLinea.OptionsColumn.AllowMove = false;
            this.dis_gcColTotLinea.OptionsColumn.AllowShowHide = false;
            this.dis_gcColTotLinea.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTotLinea.OptionsColumn.ReadOnly = true;
            this.dis_gcColTotLinea.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColTotLinea.OptionsFilter.AllowFilter = false;
            this.dis_gcColTotLinea.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTotLinea.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.dis_gcColTotLinea.ToolTip = "TotalGramos*CostoGramo*Tiraje";
            this.dis_gcColTotLinea.Visible = true;
            this.dis_gcColTotLinea.VisibleIndex = 9;
            // 
            // dis_gcColDetallePAG
            // 
            this.dis_gcColDetallePAG.Caption = "Detalle PAG";
            this.dis_gcColDetallePAG.FieldName = "DetallePag";
            this.dis_gcColDetallePAG.Name = "dis_gcColDetallePAG";
            this.dis_gcColDetallePAG.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColDetallePAG.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColDetallePAG.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColDetallePAG.OptionsColumn.AllowMove = false;
            this.dis_gcColDetallePAG.OptionsColumn.AllowShowHide = false;
            this.dis_gcColDetallePAG.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColDetallePAG.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColDetallePAG.OptionsFilter.AllowFilter = false;
            this.dis_gcColDetallePAG.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColDetallePAG.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.dis_gcColDetallePAG.Visible = true;
            this.dis_gcColDetallePAG.VisibleIndex = 10;
            this.dis_gcColDetallePAG.Width = 150;
            // 
            // dis_xtpPlacas
            // 
            this.dis_xtpPlacas.Controls.Add(this.labelControl22);
            this.dis_xtpPlacas.Controls.Add(this.labelControl21);
            this.dis_xtpPlacas.Controls.Add(this.dis_seTotalPlacas);
            this.dis_xtpPlacas.Controls.Add(this.dis_seNumPlacas);
            this.dis_xtpPlacas.Controls.Add(this.dis_gcPlacas);
            this.dis_xtpPlacas.Name = "dis_xtpPlacas";
            this.dis_xtpPlacas.Size = new System.Drawing.Size(844, 242);
            this.dis_xtpPlacas.Text = "Placas";
            // 
            // labelControl22
            // 
            this.labelControl22.Location = new System.Drawing.Point(698, 219);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(28, 13);
            this.labelControl22.TabIndex = 4;
            this.labelControl22.Text = "Total:";
            // 
            // labelControl21
            // 
            this.labelControl21.Location = new System.Drawing.Point(475, 219);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(58, 13);
            this.labelControl21.TabIndex = 3;
            this.labelControl21.Text = "Nro. Placas:";
            // 
            // dis_seTotalPlacas
            // 
            this.dis_seTotalPlacas.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dis_seTotalPlacas.Location = new System.Drawing.Point(741, 216);
            this.dis_seTotalPlacas.Name = "dis_seTotalPlacas";
            this.dis_seTotalPlacas.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dis_seTotalPlacas.Properties.Appearance.Options.UseBackColor = true;
            this.dis_seTotalPlacas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dis_seTotalPlacas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dis_seTotalPlacas.Properties.DisplayFormat.FormatString = "N2";
            this.dis_seTotalPlacas.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_seTotalPlacas.Properties.EditFormat.FormatString = "N2";
            this.dis_seTotalPlacas.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_seTotalPlacas.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dis_seTotalPlacas.Properties.Mask.EditMask = "N2";
            this.dis_seTotalPlacas.Properties.MaxValue = new decimal(new int[] {
            999999999,
            0,
            0,
            131072});
            this.dis_seTotalPlacas.Properties.ReadOnly = true;
            this.dis_seTotalPlacas.Size = new System.Drawing.Size(100, 20);
            this.dis_seTotalPlacas.TabIndex = 2;
            // 
            // dis_seNumPlacas
            // 
            this.dis_seNumPlacas.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dis_seNumPlacas.Location = new System.Drawing.Point(550, 216);
            this.dis_seNumPlacas.Name = "dis_seNumPlacas";
            this.dis_seNumPlacas.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dis_seNumPlacas.Properties.Appearance.Options.UseBackColor = true;
            this.dis_seNumPlacas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dis_seNumPlacas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dis_seNumPlacas.Properties.DisplayFormat.FormatString = "N2";
            this.dis_seNumPlacas.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_seNumPlacas.Properties.EditFormat.FormatString = "N2";
            this.dis_seNumPlacas.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_seNumPlacas.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dis_seNumPlacas.Properties.Mask.EditMask = "N2";
            this.dis_seNumPlacas.Properties.MaxValue = new decimal(new int[] {
            999999999,
            0,
            0,
            131072});
            this.dis_seNumPlacas.Properties.ReadOnly = true;
            this.dis_seNumPlacas.Size = new System.Drawing.Size(100, 20);
            this.dis_seNumPlacas.TabIndex = 1;
            // 
            // dis_gcPlacas
            // 
            this.dis_gcPlacas.Location = new System.Drawing.Point(7, 4);
            this.dis_gcPlacas.MainView = this.dis_gvPlacas;
            this.dis_gcPlacas.Name = "dis_gcPlacas";
            this.dis_gcPlacas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dis_rilueLadoImpresionP,
            this.dis_riseNumColores});
            this.dis_gcPlacas.Size = new System.Drawing.Size(834, 207);
            this.dis_gcPlacas.TabIndex = 0;
            this.dis_gcPlacas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dis_gvPlacas});
            // 
            // dis_gvPlacas
            // 
            this.dis_gvPlacas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.dis_gcColMaterialP,
            this.dis_gcColPlacaP,
            this.dis_gcColLadoP,
            this.dis_gcColNumColoresP,
            this.dis_gcColNumPaginasP,
            this.dis_gcColPaginasXplaca,
            this.dis_gcColPlacasMIN,
            this.dis_gcColNumPlacasP,
            this.dis_gcColCostoPlaca,
            this.dis_gcTotalLineaP});
            this.dis_gvPlacas.GridControl = this.dis_gcPlacas;
            this.dis_gvPlacas.Name = "dis_gvPlacas";
            this.dis_gvPlacas.OptionsView.ShowGroupPanel = false;
            this.dis_gvPlacas.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.dis_gvPlacas_CellValueChanged);
            // 
            // dis_gcColMaterialP
            // 
            this.dis_gcColMaterialP.Caption = "Material";
            this.dis_gcColMaterialP.FieldName = "Material";
            this.dis_gcColMaterialP.Name = "dis_gcColMaterialP";
            this.dis_gcColMaterialP.OptionsColumn.AllowEdit = false;
            this.dis_gcColMaterialP.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMaterialP.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColMaterialP.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMaterialP.OptionsColumn.AllowMove = false;
            this.dis_gcColMaterialP.OptionsColumn.AllowShowHide = false;
            this.dis_gcColMaterialP.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMaterialP.OptionsColumn.ReadOnly = true;
            this.dis_gcColMaterialP.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColMaterialP.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMaterialP.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMaterialP.ToolTip = "Material para el cual va hacer utilizada la placa";
            this.dis_gcColMaterialP.Visible = true;
            this.dis_gcColMaterialP.VisibleIndex = 0;
            this.dis_gcColMaterialP.Width = 158;
            // 
            // dis_gcColPlacaP
            // 
            this.dis_gcColPlacaP.Caption = "Máquina";
            this.dis_gcColPlacaP.FieldName = "Placa";
            this.dis_gcColPlacaP.Name = "dis_gcColPlacaP";
            this.dis_gcColPlacaP.OptionsColumn.AllowEdit = false;
            this.dis_gcColPlacaP.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPlacaP.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColPlacaP.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPlacaP.OptionsColumn.AllowMove = false;
            this.dis_gcColPlacaP.OptionsColumn.AllowShowHide = false;
            this.dis_gcColPlacaP.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPlacaP.OptionsColumn.ReadOnly = true;
            this.dis_gcColPlacaP.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColPlacaP.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPlacaP.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPlacaP.ToolTip = "Placa que se va a utilizar";
            this.dis_gcColPlacaP.Visible = true;
            this.dis_gcColPlacaP.VisibleIndex = 1;
            this.dis_gcColPlacaP.Width = 67;
            // 
            // dis_gcColLadoP
            // 
            this.dis_gcColLadoP.Caption = "Lado";
            this.dis_gcColLadoP.ColumnEdit = this.dis_rilueLadoImpresionP;
            this.dis_gcColLadoP.FieldName = "LadoPlaca";
            this.dis_gcColLadoP.Name = "dis_gcColLadoP";
            this.dis_gcColLadoP.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColLadoP.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColLadoP.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColLadoP.OptionsColumn.AllowMove = false;
            this.dis_gcColLadoP.OptionsColumn.AllowShowHide = false;
            this.dis_gcColLadoP.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColLadoP.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColLadoP.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColLadoP.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColLadoP.ToolTip = "Lado de impresión de la placa";
            this.dis_gcColLadoP.Visible = true;
            this.dis_gcColLadoP.VisibleIndex = 2;
            this.dis_gcColLadoP.Width = 109;
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
            // dis_gcColNumColoresP
            // 
            this.dis_gcColNumColoresP.AppearanceCell.Options.UseTextOptions = true;
            this.dis_gcColNumColoresP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.dis_gcColNumColoresP.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.dis_gcColNumColoresP.Caption = "N° Colores";
            this.dis_gcColNumColoresP.ColumnEdit = this.dis_riseNumColores;
            this.dis_gcColNumColoresP.DisplayFormat.FormatString = "N0";
            this.dis_gcColNumColoresP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcColNumColoresP.FieldName = "NumColores";
            this.dis_gcColNumColoresP.Name = "dis_gcColNumColoresP";
            this.dis_gcColNumColoresP.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumColoresP.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColNumColoresP.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumColoresP.OptionsColumn.AllowMove = false;
            this.dis_gcColNumColoresP.OptionsColumn.AllowShowHide = false;
            this.dis_gcColNumColoresP.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumColoresP.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColNumColoresP.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumColoresP.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumColoresP.ToolTip = "Número de colores a utilizar (Valor entre 1-8)";
            this.dis_gcColNumColoresP.Visible = true;
            this.dis_gcColNumColoresP.VisibleIndex = 3;
            this.dis_gcColNumColoresP.Width = 79;
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
            // dis_gcColNumPaginasP
            // 
            this.dis_gcColNumPaginasP.Caption = "Páginas";
            this.dis_gcColNumPaginasP.FieldName = "NumPaginas";
            this.dis_gcColNumPaginasP.Name = "dis_gcColNumPaginasP";
            this.dis_gcColNumPaginasP.OptionsColumn.AllowEdit = false;
            this.dis_gcColNumPaginasP.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumPaginasP.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColNumPaginasP.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumPaginasP.OptionsColumn.AllowMove = false;
            this.dis_gcColNumPaginasP.OptionsColumn.AllowShowHide = false;
            this.dis_gcColNumPaginasP.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumPaginasP.OptionsColumn.ReadOnly = true;
            this.dis_gcColNumPaginasP.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColNumPaginasP.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumPaginasP.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumPaginasP.ToolTip = "Número de paginas a imprimir. (Recupera de la fila de los armados)";
            this.dis_gcColNumPaginasP.Visible = true;
            this.dis_gcColNumPaginasP.VisibleIndex = 4;
            // 
            // dis_gcColPaginasXplaca
            // 
            this.dis_gcColPaginasXplaca.Caption = "Pag X Placa";
            this.dis_gcColPaginasXplaca.FieldName = "PaginasXplaca";
            this.dis_gcColPaginasXplaca.Name = "dis_gcColPaginasXplaca";
            this.dis_gcColPaginasXplaca.OptionsColumn.AllowEdit = false;
            this.dis_gcColPaginasXplaca.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPaginasXplaca.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColPaginasXplaca.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPaginasXplaca.OptionsColumn.AllowMove = false;
            this.dis_gcColPaginasXplaca.OptionsColumn.AllowShowHide = false;
            this.dis_gcColPaginasXplaca.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPaginasXplaca.OptionsColumn.ReadOnly = true;
            this.dis_gcColPaginasXplaca.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColPaginasXplaca.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPaginasXplaca.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPaginasXplaca.ToolTip = "Número de páginas que se imprimen en una placa";
            this.dis_gcColPaginasXplaca.Visible = true;
            this.dis_gcColPaginasXplaca.VisibleIndex = 5;
            this.dis_gcColPaginasXplaca.Width = 84;
            // 
            // dis_gcColPlacasMIN
            // 
            this.dis_gcColPlacasMIN.Caption = "Placas MIN";
            this.dis_gcColPlacasMIN.FieldName = "NumPlacasMIN";
            this.dis_gcColPlacasMIN.Name = "dis_gcColPlacasMIN";
            this.dis_gcColPlacasMIN.OptionsColumn.AllowEdit = false;
            this.dis_gcColPlacasMIN.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPlacasMIN.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColPlacasMIN.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPlacasMIN.OptionsColumn.AllowMove = false;
            this.dis_gcColPlacasMIN.OptionsColumn.AllowShowHide = false;
            this.dis_gcColPlacasMIN.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPlacasMIN.OptionsColumn.ReadOnly = true;
            this.dis_gcColPlacasMIN.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColPlacasMIN.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPlacasMIN.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPlacasMIN.ToolTip = "Mínimo de placas sugerido por sistema (NroPlacas/PáginasXplaca)";
            this.dis_gcColPlacasMIN.Visible = true;
            this.dis_gcColPlacasMIN.VisibleIndex = 6;
            // 
            // dis_gcColNumPlacasP
            // 
            this.dis_gcColNumPlacasP.Caption = "N° Placas";
            this.dis_gcColNumPlacasP.FieldName = "NumPlacas";
            this.dis_gcColNumPlacasP.Name = "dis_gcColNumPlacasP";
            this.dis_gcColNumPlacasP.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumPlacasP.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColNumPlacasP.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumPlacasP.OptionsColumn.AllowMove = false;
            this.dis_gcColNumPlacasP.OptionsColumn.AllowShowHide = false;
            this.dis_gcColNumPlacasP.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumPlacasP.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColNumPlacasP.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumPlacasP.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumPlacasP.ToolTip = "Número de placas registradas por el usuario (Mayor o igual al mínimo de placas su" +
    "gerido)";
            this.dis_gcColNumPlacasP.Visible = true;
            this.dis_gcColNumPlacasP.VisibleIndex = 7;
            this.dis_gcColNumPlacasP.Width = 77;
            // 
            // dis_gcColCostoPlaca
            // 
            this.dis_gcColCostoPlaca.Caption = "Costo";
            this.dis_gcColCostoPlaca.DisplayFormat.FormatString = "N2";
            this.dis_gcColCostoPlaca.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcColCostoPlaca.FieldName = "CostoPlaca";
            this.dis_gcColCostoPlaca.Name = "dis_gcColCostoPlaca";
            this.dis_gcColCostoPlaca.OptionsColumn.AllowEdit = false;
            this.dis_gcColCostoPlaca.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCostoPlaca.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColCostoPlaca.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCostoPlaca.OptionsColumn.AllowMove = false;
            this.dis_gcColCostoPlaca.OptionsColumn.AllowShowHide = false;
            this.dis_gcColCostoPlaca.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCostoPlaca.OptionsColumn.ReadOnly = true;
            this.dis_gcColCostoPlaca.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColCostoPlaca.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCostoPlaca.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCostoPlaca.ToolTip = "Costo aproximado de la placa viene de la BD";
            this.dis_gcColCostoPlaca.Visible = true;
            this.dis_gcColCostoPlaca.VisibleIndex = 8;
            // 
            // dis_gcTotalLineaP
            // 
            this.dis_gcTotalLineaP.Caption = "Total";
            this.dis_gcTotalLineaP.DisplayFormat.FormatString = "N2";
            this.dis_gcTotalLineaP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcTotalLineaP.FieldName = "TotalLinea";
            this.dis_gcTotalLineaP.Name = "dis_gcTotalLineaP";
            this.dis_gcTotalLineaP.OptionsColumn.AllowEdit = false;
            this.dis_gcTotalLineaP.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcTotalLineaP.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcTotalLineaP.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcTotalLineaP.OptionsColumn.AllowMove = false;
            this.dis_gcTotalLineaP.OptionsColumn.AllowShowHide = false;
            this.dis_gcTotalLineaP.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcTotalLineaP.OptionsColumn.ReadOnly = true;
            this.dis_gcTotalLineaP.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcTotalLineaP.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcTotalLineaP.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcTotalLineaP.ToolTip = "NumeroColores*NumeroPlacas*CostoPlaca";
            this.dis_gcTotalLineaP.Visible = true;
            this.dis_gcTotalLineaP.VisibleIndex = 9;
            this.dis_gcTotalLineaP.Width = 92;
            // 
            // dis_xtpTroquel
            // 
            this.dis_xtpTroquel.Controls.Add(this.labelControl24);
            this.dis_xtpTroquel.Controls.Add(this.labelControl23);
            this.dis_xtpTroquel.Controls.Add(this.dis_seCortesTOT);
            this.dis_xtpTroquel.Controls.Add(this.dis_seCorteLONG);
            this.dis_xtpTroquel.Controls.Add(this.dis_gcTrqouel);
            this.dis_xtpTroquel.Name = "dis_xtpTroquel";
            this.dis_xtpTroquel.Size = new System.Drawing.Size(844, 242);
            this.dis_xtpTroquel.Text = "Troquel";
            // 
            // labelControl24
            // 
            this.labelControl24.Location = new System.Drawing.Point(691, 219);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(28, 13);
            this.labelControl24.TabIndex = 4;
            this.labelControl24.Text = "Total:";
            // 
            // labelControl23
            // 
            this.labelControl23.Location = new System.Drawing.Point(494, 219);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(47, 13);
            this.labelControl23.TabIndex = 3;
            this.labelControl23.Text = "Corte cm:";
            // 
            // dis_seCortesTOT
            // 
            this.dis_seCortesTOT.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dis_seCortesTOT.Location = new System.Drawing.Point(730, 216);
            this.dis_seCortesTOT.Name = "dis_seCortesTOT";
            this.dis_seCortesTOT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dis_seCortesTOT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dis_seCortesTOT.Properties.DisplayFormat.FormatString = "N2";
            this.dis_seCortesTOT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_seCortesTOT.Properties.EditFormat.FormatString = "N2";
            this.dis_seCortesTOT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_seCortesTOT.Properties.Mask.EditMask = "N2";
            this.dis_seCortesTOT.Size = new System.Drawing.Size(100, 20);
            this.dis_seCortesTOT.TabIndex = 2;
            // 
            // dis_seCorteLONG
            // 
            this.dis_seCorteLONG.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dis_seCorteLONG.Location = new System.Drawing.Point(547, 216);
            this.dis_seCorteLONG.Name = "dis_seCorteLONG";
            this.dis_seCorteLONG.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dis_seCorteLONG.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dis_seCorteLONG.Properties.DisplayFormat.FormatString = "N2";
            this.dis_seCorteLONG.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_seCorteLONG.Properties.EditFormat.FormatString = "N2";
            this.dis_seCorteLONG.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_seCorteLONG.Properties.Mask.EditMask = "N2";
            this.dis_seCorteLONG.Size = new System.Drawing.Size(100, 20);
            this.dis_seCorteLONG.TabIndex = 1;
            // 
            // dis_gcTrqouel
            // 
            this.dis_gcTrqouel.ContextMenuStrip = this.cmDisenoTroquel;
            this.dis_gcTrqouel.Location = new System.Drawing.Point(7, 4);
            this.dis_gcTrqouel.MainView = this.dis_gvTroquel;
            this.dis_gcTrqouel.Name = "dis_gcTrqouel";
            this.dis_gcTrqouel.Size = new System.Drawing.Size(834, 200);
            this.dis_gcTrqouel.TabIndex = 0;
            this.dis_gcTrqouel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dis_gvTroquel});
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
            // dis_gvTroquel
            // 
            this.dis_gvTroquel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.dis_gcColMaterialT,
            this.dis_gcColLongitud,
            this.dis_gcColNumCortesT,
            this.dis_gcColCostoCorteT,
            this.dis_gcColTotaLineaT});
            this.dis_gvTroquel.GridControl = this.dis_gcTrqouel;
            this.dis_gvTroquel.Name = "dis_gvTroquel";
            this.dis_gvTroquel.OptionsView.ShowGroupPanel = false;
            // 
            // dis_gcColMaterialT
            // 
            this.dis_gcColMaterialT.Caption = "Material";
            this.dis_gcColMaterialT.FieldName = "Material";
            this.dis_gcColMaterialT.Name = "dis_gcColMaterialT";
            this.dis_gcColMaterialT.OptionsColumn.AllowEdit = false;
            this.dis_gcColMaterialT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMaterialT.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColMaterialT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMaterialT.OptionsColumn.AllowMove = false;
            this.dis_gcColMaterialT.OptionsColumn.AllowShowHide = false;
            this.dis_gcColMaterialT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMaterialT.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMaterialT.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMaterialT.OptionsColumn.ReadOnly = true;
            this.dis_gcColMaterialT.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMaterialT.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMaterialT.ToolTip = "Material al cual se va a aplicar el corte (Viene de los armados)";
            this.dis_gcColMaterialT.Visible = true;
            this.dis_gcColMaterialT.VisibleIndex = 0;
            // 
            // dis_gcColLongitud
            // 
            this.dis_gcColLongitud.Caption = "Longitud";
            this.dis_gcColLongitud.DisplayFormat.FormatString = "N2";
            this.dis_gcColLongitud.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcColLongitud.FieldName = "Longitud";
            this.dis_gcColLongitud.Name = "dis_gcColLongitud";
            this.dis_gcColLongitud.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColLongitud.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColLongitud.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColLongitud.OptionsColumn.AllowMove = false;
            this.dis_gcColLongitud.OptionsColumn.AllowShowHide = false;
            this.dis_gcColLongitud.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColLongitud.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColLongitud.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColLongitud.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColLongitud.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColLongitud.ToolTip = "Suma de todas las longitudes de los cortes que se van a aplicar al material";
            this.dis_gcColLongitud.Visible = true;
            this.dis_gcColLongitud.VisibleIndex = 1;
            // 
            // dis_gcColNumCortesT
            // 
            this.dis_gcColNumCortesT.Caption = "Cortes";
            this.dis_gcColNumCortesT.FieldName = "NumCortes";
            this.dis_gcColNumCortesT.Name = "dis_gcColNumCortesT";
            this.dis_gcColNumCortesT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumCortesT.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColNumCortesT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumCortesT.OptionsColumn.AllowMove = false;
            this.dis_gcColNumCortesT.OptionsColumn.AllowShowHide = false;
            this.dis_gcColNumCortesT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumCortesT.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumCortesT.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumCortesT.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumCortesT.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumCortesT.ToolTip = "Número de cortes que se van a realizar";
            this.dis_gcColNumCortesT.Visible = true;
            this.dis_gcColNumCortesT.VisibleIndex = 2;
            // 
            // dis_gcColCostoCorteT
            // 
            this.dis_gcColCostoCorteT.Caption = "Costo";
            this.dis_gcColCostoCorteT.DisplayFormat.FormatString = "N2";
            this.dis_gcColCostoCorteT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcColCostoCorteT.FieldName = "CostoCorte";
            this.dis_gcColCostoCorteT.Name = "dis_gcColCostoCorteT";
            this.dis_gcColCostoCorteT.OptionsColumn.AllowEdit = false;
            this.dis_gcColCostoCorteT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCostoCorteT.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColCostoCorteT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCostoCorteT.OptionsColumn.AllowMove = false;
            this.dis_gcColCostoCorteT.OptionsColumn.AllowShowHide = false;
            this.dis_gcColCostoCorteT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCostoCorteT.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCostoCorteT.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCostoCorteT.OptionsColumn.ReadOnly = true;
            this.dis_gcColCostoCorteT.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCostoCorteT.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCostoCorteT.ToolTip = "Costo aproximado de cada corte (Viene de la Base de datos)";
            this.dis_gcColCostoCorteT.Visible = true;
            this.dis_gcColCostoCorteT.VisibleIndex = 3;
            // 
            // dis_gcColTotaLineaT
            // 
            this.dis_gcColTotaLineaT.Caption = "Total";
            this.dis_gcColTotaLineaT.DisplayFormat.FormatString = "N2";
            this.dis_gcColTotaLineaT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcColTotaLineaT.FieldName = "TotalLinea";
            this.dis_gcColTotaLineaT.Name = "dis_gcColTotaLineaT";
            this.dis_gcColTotaLineaT.OptionsColumn.AllowEdit = false;
            this.dis_gcColTotaLineaT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTotaLineaT.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColTotaLineaT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTotaLineaT.OptionsColumn.AllowMove = false;
            this.dis_gcColTotaLineaT.OptionsColumn.AllowShowHide = false;
            this.dis_gcColTotaLineaT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTotaLineaT.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTotaLineaT.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTotaLineaT.OptionsColumn.ReadOnly = true;
            this.dis_gcColTotaLineaT.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTotaLineaT.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTotaLineaT.ToolTip = "Longitud*NumCortes*CostoCorte";
            this.dis_gcColTotaLineaT.Visible = true;
            this.dis_gcColTotaLineaT.VisibleIndex = 4;
            // 
            // dis_xtpAcabados
            // 
            this.dis_xtpAcabados.Controls.Add(this.dis_gcAcabados);
            this.dis_xtpAcabados.Name = "dis_xtpAcabados";
            this.dis_xtpAcabados.Size = new System.Drawing.Size(844, 242);
            this.dis_xtpAcabados.Text = "Acabados";
            // 
            // dis_gcAcabados
            // 
            this.dis_gcAcabados.ContextMenuStrip = this.cmDisenoAcabado;
            this.dis_gcAcabados.Location = new System.Drawing.Point(7, 4);
            this.dis_gcAcabados.MainView = this.dis_gvAcabados;
            this.dis_gcAcabados.Name = "dis_gcAcabados";
            this.dis_gcAcabados.Size = new System.Drawing.Size(834, 235);
            this.dis_gcAcabados.TabIndex = 0;
            this.dis_gcAcabados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dis_gvAcabados});
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
            // dis_gvAcabados
            // 
            this.dis_gvAcabados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.dis_gcMaterialA,
            this.dis_gcAreaA,
            this.dis_gcAcabadoA,
            this.dis_gcColAcabadoMAT,
            this.dis_gcCostoA,
            this.dis_gcAplicaA,
            this.dis_gcTotalLineaA});
            this.dis_gvAcabados.GridControl = this.dis_gcAcabados;
            this.dis_gvAcabados.Name = "dis_gvAcabados";
            this.dis_gvAcabados.OptionsView.ShowGroupPanel = false;
            // 
            // dis_gcMaterialA
            // 
            this.dis_gcMaterialA.Caption = "Material Armado";
            this.dis_gcMaterialA.FieldName = "Material";
            this.dis_gcMaterialA.Name = "dis_gcMaterialA";
            this.dis_gcMaterialA.OptionsColumn.AllowEdit = false;
            this.dis_gcMaterialA.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcMaterialA.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcMaterialA.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcMaterialA.OptionsColumn.AllowMove = false;
            this.dis_gcMaterialA.OptionsColumn.AllowShowHide = false;
            this.dis_gcMaterialA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcMaterialA.Visible = true;
            this.dis_gcMaterialA.VisibleIndex = 0;
            this.dis_gcMaterialA.Width = 181;
            // 
            // dis_gcAreaA
            // 
            this.dis_gcAreaA.Caption = "Area";
            this.dis_gcAreaA.DisplayFormat.FormatString = "N2";
            this.dis_gcAreaA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcAreaA.FieldName = "Area";
            this.dis_gcAreaA.Name = "dis_gcAreaA";
            this.dis_gcAreaA.OptionsColumn.AllowEdit = false;
            this.dis_gcAreaA.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcAreaA.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcAreaA.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcAreaA.OptionsColumn.AllowMove = false;
            this.dis_gcAreaA.OptionsColumn.AllowShowHide = false;
            this.dis_gcAreaA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcAreaA.Visible = true;
            this.dis_gcAreaA.VisibleIndex = 1;
            this.dis_gcAreaA.Width = 69;
            // 
            // dis_gcAcabadoA
            // 
            this.dis_gcAcabadoA.Caption = "Acabado";
            this.dis_gcAcabadoA.FieldName = "Acabado";
            this.dis_gcAcabadoA.Name = "dis_gcAcabadoA";
            this.dis_gcAcabadoA.OptionsColumn.AllowEdit = false;
            this.dis_gcAcabadoA.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcAcabadoA.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcAcabadoA.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcAcabadoA.OptionsColumn.AllowMove = false;
            this.dis_gcAcabadoA.OptionsColumn.AllowShowHide = false;
            this.dis_gcAcabadoA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcAcabadoA.Visible = true;
            this.dis_gcAcabadoA.VisibleIndex = 2;
            this.dis_gcAcabadoA.Width = 131;
            // 
            // dis_gcColAcabadoMAT
            // 
            this.dis_gcColAcabadoMAT.Caption = "Material Acabado";
            this.dis_gcColAcabadoMAT.FieldName = "AcabadoMaterial";
            this.dis_gcColAcabadoMAT.Name = "dis_gcColAcabadoMAT";
            this.dis_gcColAcabadoMAT.OptionsColumn.AllowEdit = false;
            this.dis_gcColAcabadoMAT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColAcabadoMAT.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColAcabadoMAT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColAcabadoMAT.OptionsColumn.AllowMove = false;
            this.dis_gcColAcabadoMAT.OptionsColumn.AllowShowHide = false;
            this.dis_gcColAcabadoMAT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColAcabadoMAT.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColAcabadoMAT.Visible = true;
            this.dis_gcColAcabadoMAT.VisibleIndex = 3;
            this.dis_gcColAcabadoMAT.Width = 205;
            // 
            // dis_gcCostoA
            // 
            this.dis_gcCostoA.Caption = "Costo";
            this.dis_gcCostoA.DisplayFormat.FormatString = "N2";
            this.dis_gcCostoA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcCostoA.FieldName = "Costo";
            this.dis_gcCostoA.Name = "dis_gcCostoA";
            this.dis_gcCostoA.OptionsColumn.AllowEdit = false;
            this.dis_gcCostoA.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcCostoA.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcCostoA.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcCostoA.OptionsColumn.AllowMove = false;
            this.dis_gcCostoA.OptionsColumn.AllowShowHide = false;
            this.dis_gcCostoA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcCostoA.Visible = true;
            this.dis_gcCostoA.VisibleIndex = 5;
            this.dis_gcCostoA.Width = 64;
            // 
            // dis_gcAplicaA
            // 
            this.dis_gcAplicaA.Caption = "Aplica";
            this.dis_gcAplicaA.FieldName = "areaAplica";
            this.dis_gcAplicaA.Name = "dis_gcAplicaA";
            this.dis_gcAplicaA.OptionsColumn.AllowEdit = false;
            this.dis_gcAplicaA.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcAplicaA.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcAplicaA.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcAplicaA.OptionsColumn.AllowMove = false;
            this.dis_gcAplicaA.OptionsColumn.AllowShowHide = false;
            this.dis_gcAplicaA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcAplicaA.Visible = true;
            this.dis_gcAplicaA.VisibleIndex = 4;
            this.dis_gcAplicaA.Width = 60;
            // 
            // dis_gcTotalLineaA
            // 
            this.dis_gcTotalLineaA.Caption = "Total";
            this.dis_gcTotalLineaA.DisplayFormat.FormatString = "N2";
            this.dis_gcTotalLineaA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcTotalLineaA.FieldName = "TotalLinea";
            this.dis_gcTotalLineaA.Name = "dis_gcTotalLineaA";
            this.dis_gcTotalLineaA.OptionsColumn.AllowEdit = false;
            this.dis_gcTotalLineaA.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcTotalLineaA.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcTotalLineaA.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcTotalLineaA.OptionsColumn.AllowMove = false;
            this.dis_gcTotalLineaA.OptionsColumn.AllowShowHide = false;
            this.dis_gcTotalLineaA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcTotalLineaA.Visible = true;
            this.dis_gcTotalLineaA.VisibleIndex = 6;
            this.dis_gcTotalLineaA.Width = 106;
            // 
            // dis_xtpAccesorios
            // 
            this.dis_xtpAccesorios.Controls.Add(this.dis_gcAccesorios);
            this.dis_xtpAccesorios.Name = "dis_xtpAccesorios";
            this.dis_xtpAccesorios.Size = new System.Drawing.Size(844, 242);
            this.dis_xtpAccesorios.Text = "Accesorios";
            // 
            // dis_gcAccesorios
            // 
            this.dis_gcAccesorios.ContextMenuStrip = this.cmDisenoAccesorios;
            this.dis_gcAccesorios.Location = new System.Drawing.Point(7, 4);
            this.dis_gcAccesorios.MainView = this.dis_gvAccesorios;
            this.dis_gcAccesorios.Name = "dis_gcAccesorios";
            this.dis_gcAccesorios.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dis_riseCantAccesorio});
            this.dis_gcAccesorios.Size = new System.Drawing.Size(834, 235);
            this.dis_gcAccesorios.TabIndex = 0;
            this.dis_gcAccesorios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dis_gvAccesorios});
            // 
            // dis_gvAccesorios
            // 
            this.dis_gvAccesorios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.dis_gcColMaterialS,
            this.dis_gcColTirajeS,
            this.dis_gcColCantidadS,
            this.dis_gcColCostoS,
            this.dis_gcColTotalLineaS});
            this.dis_gvAccesorios.GridControl = this.dis_gcAccesorios;
            this.dis_gvAccesorios.Name = "dis_gvAccesorios";
            this.dis_gvAccesorios.OptionsView.ShowGroupPanel = false;
            // 
            // dis_gcColMaterialS
            // 
            this.dis_gcColMaterialS.Caption = "Descripción";
            this.dis_gcColMaterialS.FieldName = "Material";
            this.dis_gcColMaterialS.Name = "dis_gcColMaterialS";
            this.dis_gcColMaterialS.OptionsColumn.AllowEdit = false;
            this.dis_gcColMaterialS.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMaterialS.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColMaterialS.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMaterialS.OptionsColumn.AllowMove = false;
            this.dis_gcColMaterialS.OptionsColumn.AllowShowHide = false;
            this.dis_gcColMaterialS.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMaterialS.OptionsColumn.ReadOnly = true;
            this.dis_gcColMaterialS.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColMaterialS.ToolTip = "Descripción del accesorio";
            this.dis_gcColMaterialS.Visible = true;
            this.dis_gcColMaterialS.VisibleIndex = 0;
            this.dis_gcColMaterialS.Width = 436;
            // 
            // dis_gcColTirajeS
            // 
            this.dis_gcColTirajeS.Caption = "Tiraje";
            this.dis_gcColTirajeS.DisplayFormat.FormatString = "N0";
            this.dis_gcColTirajeS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcColTirajeS.FieldName = "Tiraje";
            this.dis_gcColTirajeS.Name = "dis_gcColTirajeS";
            this.dis_gcColTirajeS.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTirajeS.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColTirajeS.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTirajeS.OptionsColumn.AllowMove = false;
            this.dis_gcColTirajeS.OptionsColumn.AllowShowHide = false;
            this.dis_gcColTirajeS.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTirajeS.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColTirajeS.ToolTip = "Cantidad de items que se va a producir";
            this.dis_gcColTirajeS.Visible = true;
            this.dis_gcColTirajeS.VisibleIndex = 1;
            this.dis_gcColTirajeS.Width = 138;
            // 
            // dis_gcColCantidadS
            // 
            this.dis_gcColCantidadS.Caption = "Cantidad";
            this.dis_gcColCantidadS.ColumnEdit = this.dis_riseCantAccesorio;
            this.dis_gcColCantidadS.DisplayFormat.FormatString = "N2";
            this.dis_gcColCantidadS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcColCantidadS.FieldName = "Cantidad";
            this.dis_gcColCantidadS.Name = "dis_gcColCantidadS";
            this.dis_gcColCantidadS.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCantidadS.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColCantidadS.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCantidadS.OptionsColumn.AllowMove = false;
            this.dis_gcColCantidadS.OptionsColumn.AllowShowHide = false;
            this.dis_gcColCantidadS.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCantidadS.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColCantidadS.ToolTip = "Cantidad necesaria";
            this.dis_gcColCantidadS.Visible = true;
            this.dis_gcColCantidadS.VisibleIndex = 2;
            this.dis_gcColCantidadS.Width = 158;
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
            // dis_gcColCostoS
            // 
            this.dis_gcColCostoS.Caption = "Costo";
            this.dis_gcColCostoS.DisplayFormat.FormatString = "e3";
            this.dis_gcColCostoS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcColCostoS.FieldName = "Costo";
            this.dis_gcColCostoS.Name = "dis_gcColCostoS";
            this.dis_gcColCostoS.OptionsColumn.AllowEdit = false;
            this.dis_gcColCostoS.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCostoS.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColCostoS.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCostoS.OptionsColumn.AllowMove = false;
            this.dis_gcColCostoS.OptionsColumn.AllowShowHide = false;
            this.dis_gcColCostoS.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCostoS.OptionsColumn.ReadOnly = true;
            this.dis_gcColCostoS.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColCostoS.ToolTip = "Costo del accesorio";
            this.dis_gcColCostoS.Visible = true;
            this.dis_gcColCostoS.VisibleIndex = 3;
            this.dis_gcColCostoS.Width = 166;
            // 
            // dis_gcColTotalLineaS
            // 
            this.dis_gcColTotalLineaS.Caption = "Total";
            this.dis_gcColTotalLineaS.DisplayFormat.FormatString = "N2";
            this.dis_gcColTotalLineaS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcColTotalLineaS.FieldName = "TotalLinea";
            this.dis_gcColTotalLineaS.Name = "dis_gcColTotalLineaS";
            this.dis_gcColTotalLineaS.OptionsColumn.AllowEdit = false;
            this.dis_gcColTotalLineaS.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTotalLineaS.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColTotalLineaS.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTotalLineaS.OptionsColumn.AllowMove = false;
            this.dis_gcColTotalLineaS.OptionsColumn.AllowShowHide = false;
            this.dis_gcColTotalLineaS.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTotalLineaS.OptionsColumn.ReadOnly = true;
            this.dis_gcColTotalLineaS.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColTotalLineaS.ToolTip = "Tiraje*Cantidad*Costo";
            this.dis_gcColTotalLineaS.Visible = true;
            this.dis_gcColTotalLineaS.VisibleIndex = 4;
            this.dis_gcColTotalLineaS.Width = 180;
            // 
            // dis_xtpProcesos
            // 
            this.dis_xtpProcesos.Controls.Add(this.gc_Procesos);
            this.dis_xtpProcesos.Name = "dis_xtpProcesos";
            this.dis_xtpProcesos.Size = new System.Drawing.Size(844, 242);
            this.dis_xtpProcesos.Text = "Procesos";
            // 
            // gc_Procesos
            // 
            this.gc_Procesos.ContextMenuStrip = this.cmProcesos;
            this.gc_Procesos.Location = new System.Drawing.Point(3, 3);
            this.gc_Procesos.MainView = this.gvProcesos;
            this.gc_Procesos.Name = "gc_Procesos";
            this.gc_Procesos.Size = new System.Drawing.Size(838, 239);
            this.gc_Procesos.TabIndex = 0;
            this.gc_Procesos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProcesos});
            // 
            // cmProcesos
            // 
            this.cmProcesos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAgregaProceso,
            this.mnuQuitarProceso});
            this.cmProcesos.Name = "contextMenuStrip3";
            this.cmProcesos.Size = new System.Drawing.Size(219, 48);
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
            // gvProcesos
            // 
            this.gvProcesos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.proc_gcColMaquina,
            this.proc_gcColCosto,
            this.proc_gcColCantidad,
            this.proc_gcColTotal});
            this.gvProcesos.GridControl = this.gc_Procesos;
            this.gvProcesos.Name = "gvProcesos";
            this.gvProcesos.OptionsView.ShowGroupPanel = false;
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
            // proc_gcColCantidad
            // 
            this.proc_gcColCantidad.Caption = "Cantidad";
            this.proc_gcColCantidad.DisplayFormat.FormatString = "N2";
            this.proc_gcColCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.proc_gcColCantidad.FieldName = "Cantidad";
            this.proc_gcColCantidad.Name = "proc_gcColCantidad";
            this.proc_gcColCantidad.OptionsColumn.AllowEdit = false;
            this.proc_gcColCantidad.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.proc_gcColCantidad.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.proc_gcColCantidad.OptionsColumn.AllowMove = false;
            this.proc_gcColCantidad.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.proc_gcColCantidad.OptionsColumn.ReadOnly = true;
            this.proc_gcColCantidad.Visible = true;
            this.proc_gcColCantidad.VisibleIndex = 2;
            this.proc_gcColCantidad.Width = 193;
            // 
            // proc_gcColTotal
            // 
            this.proc_gcColTotal.Caption = "Total";
            this.proc_gcColTotal.DisplayFormat.FormatString = "N2";
            this.proc_gcColTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.proc_gcColTotal.FieldName = "Total";
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
            this.dis_xtpProcesosIMP.Controls.Add(this.dis_gcProcesoIMP);
            this.dis_xtpProcesosIMP.Name = "dis_xtpProcesosIMP";
            this.dis_xtpProcesosIMP.Size = new System.Drawing.Size(844, 242);
            this.dis_xtpProcesosIMP.Text = "Procesos Impresión";
            // 
            // dis_gcProcesoIMP
            // 
            this.dis_gcProcesoIMP.Location = new System.Drawing.Point(3, 3);
            this.dis_gcProcesoIMP.MainView = this.dis_bgvProcesoIMP;
            this.dis_gcProcesoIMP.Name = "dis_gcProcesoIMP";
            this.dis_gcProcesoIMP.Size = new System.Drawing.Size(838, 236);
            this.dis_gcProcesoIMP.TabIndex = 0;
            this.dis_gcProcesoIMP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dis_bgvProcesoIMP});
            // 
            // dis_bgvProcesoIMP
            // 
            this.dis_bgvProcesoIMP.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.dis_bandaMaterial,
            this.dis_bandaImpresion,
            this.dis_bandaPuestaPunto,
            this.dis_bandaTotal});
            this.dis_bgvProcesoIMP.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.dis_gcColTallaI,
            this.dis_gcColMaterialI,
            this.dis_gcColPlacaI,
            this.dis_gcColNumColoresI,
            this.dis_gcColCostoXminuto,
            this.dis_gcColPliegosXminuto,
            this.dis_gcColNumPliegos,
            this.dis_gcColMinImpresion,
            this.dis_gcColCostoXminutoPP,
            this.dis_gcColMinutosPP,
            this.dis_gcColTotalLineaI});
            this.dis_bgvProcesoIMP.GridControl = this.dis_gcProcesoIMP;
            this.dis_bgvProcesoIMP.Name = "dis_bgvProcesoIMP";
            this.dis_bgvProcesoIMP.OptionsView.ColumnAutoWidth = false;
            this.dis_bgvProcesoIMP.OptionsView.ShowGroupPanel = false;
            // 
            // dis_bandaMaterial
            // 
            this.dis_bandaMaterial.Columns.Add(this.dis_gcColTallaI);
            this.dis_bandaMaterial.Columns.Add(this.dis_gcColMaterialI);
            this.dis_bandaMaterial.Columns.Add(this.dis_gcColNumColoresI);
            this.dis_bandaMaterial.Columns.Add(this.dis_gcColPlacaI);
            this.dis_bandaMaterial.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.dis_bandaMaterial.Name = "dis_bandaMaterial";
            this.dis_bandaMaterial.OptionsBand.AllowHotTrack = false;
            this.dis_bandaMaterial.OptionsBand.AllowMove = false;
            this.dis_bandaMaterial.OptionsBand.AllowPress = false;
            this.dis_bandaMaterial.VisibleIndex = 0;
            this.dis_bandaMaterial.Width = 380;
            // 
            // dis_gcColTallaI
            // 
            this.dis_gcColTallaI.Caption = "Grupo";
            this.dis_gcColTallaI.FieldName = "Talla";
            this.dis_gcColTallaI.Name = "dis_gcColTallaI";
            this.dis_gcColTallaI.OptionsColumn.AllowEdit = false;
            this.dis_gcColTallaI.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTallaI.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColTallaI.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTallaI.OptionsColumn.AllowMove = false;
            this.dis_gcColTallaI.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTallaI.OptionsColumn.ReadOnly = true;
            this.dis_gcColTallaI.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColTallaI.Visible = true;
            this.dis_gcColTallaI.Width = 100;
            // 
            // dis_gcColMaterialI
            // 
            this.dis_gcColMaterialI.Caption = "Material";
            this.dis_gcColMaterialI.FieldName = "Material";
            this.dis_gcColMaterialI.Name = "dis_gcColMaterialI";
            this.dis_gcColMaterialI.OptionsColumn.AllowEdit = false;
            this.dis_gcColMaterialI.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMaterialI.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColMaterialI.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMaterialI.OptionsColumn.AllowMove = false;
            this.dis_gcColMaterialI.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMaterialI.OptionsColumn.ReadOnly = true;
            this.dis_gcColMaterialI.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColMaterialI.Visible = true;
            this.dis_gcColMaterialI.Width = 150;
            // 
            // dis_gcColNumColoresI
            // 
            this.dis_gcColNumColoresI.Caption = "Colores";
            this.dis_gcColNumColoresI.DisplayFormat.FormatString = "N0";
            this.dis_gcColNumColoresI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcColNumColoresI.FieldName = "NumColores";
            this.dis_gcColNumColoresI.Name = "dis_gcColNumColoresI";
            this.dis_gcColNumColoresI.OptionsColumn.AllowEdit = false;
            this.dis_gcColNumColoresI.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumColoresI.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColNumColoresI.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumColoresI.OptionsColumn.AllowMove = false;
            this.dis_gcColNumColoresI.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumColoresI.OptionsColumn.ReadOnly = true;
            this.dis_gcColNumColoresI.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColNumColoresI.Visible = true;
            this.dis_gcColNumColoresI.Width = 70;
            // 
            // dis_gcColPlacaI
            // 
            this.dis_gcColPlacaI.Caption = "Placa";
            this.dis_gcColPlacaI.FieldName = "Placa";
            this.dis_gcColPlacaI.Name = "dis_gcColPlacaI";
            this.dis_gcColPlacaI.Visible = true;
            this.dis_gcColPlacaI.Width = 60;
            // 
            // dis_bandaImpresion
            // 
            this.dis_bandaImpresion.Caption = "Proceso de Impresión";
            this.dis_bandaImpresion.Columns.Add(this.dis_gcColCostoXminuto);
            this.dis_bandaImpresion.Columns.Add(this.dis_gcColMinImpresion);
            this.dis_bandaImpresion.Columns.Add(this.dis_gcColPliegosXminuto);
            this.dis_bandaImpresion.Columns.Add(this.dis_gcColNumPliegos);
            this.dis_bandaImpresion.Name = "dis_bandaImpresion";
            this.dis_bandaImpresion.OptionsBand.AllowMove = false;
            this.dis_bandaImpresion.OptionsBand.AllowPress = false;
            this.dis_bandaImpresion.VisibleIndex = 1;
            this.dis_bandaImpresion.Width = 270;
            // 
            // dis_gcColCostoXminuto
            // 
            this.dis_gcColCostoXminuto.Caption = "Costo Min";
            this.dis_gcColCostoXminuto.DisplayFormat.FormatString = "e3";
            this.dis_gcColCostoXminuto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcColCostoXminuto.FieldName = "CostoMinIMP";
            this.dis_gcColCostoXminuto.Name = "dis_gcColCostoXminuto";
            this.dis_gcColCostoXminuto.OptionsColumn.AllowEdit = false;
            this.dis_gcColCostoXminuto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCostoXminuto.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColCostoXminuto.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCostoXminuto.OptionsColumn.AllowMove = false;
            this.dis_gcColCostoXminuto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCostoXminuto.OptionsColumn.ReadOnly = true;
            this.dis_gcColCostoXminuto.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColCostoXminuto.Visible = true;
            this.dis_gcColCostoXminuto.Width = 70;
            // 
            // dis_gcColMinImpresion
            // 
            this.dis_gcColMinImpresion.Caption = "MIN";
            this.dis_gcColMinImpresion.DisplayFormat.FormatString = "N0";
            this.dis_gcColMinImpresion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcColMinImpresion.FieldName = "NumMinIMP";
            this.dis_gcColMinImpresion.Name = "dis_gcColMinImpresion";
            this.dis_gcColMinImpresion.OptionsColumn.AllowEdit = false;
            this.dis_gcColMinImpresion.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMinImpresion.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColMinImpresion.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMinImpresion.OptionsColumn.AllowMove = false;
            this.dis_gcColMinImpresion.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMinImpresion.OptionsColumn.ReadOnly = true;
            this.dis_gcColMinImpresion.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColMinImpresion.Visible = true;
            this.dis_gcColMinImpresion.Width = 60;
            // 
            // dis_gcColPliegosXminuto
            // 
            this.dis_gcColPliegosXminuto.Caption = "Pliego X min";
            this.dis_gcColPliegosXminuto.DisplayFormat.FormatString = "N0";
            this.dis_gcColPliegosXminuto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcColPliegosXminuto.FieldName = "PliegosXmin";
            this.dis_gcColPliegosXminuto.Name = "dis_gcColPliegosXminuto";
            this.dis_gcColPliegosXminuto.OptionsColumn.AllowEdit = false;
            this.dis_gcColPliegosXminuto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPliegosXminuto.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColPliegosXminuto.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPliegosXminuto.OptionsColumn.AllowMove = false;
            this.dis_gcColPliegosXminuto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColPliegosXminuto.OptionsColumn.ReadOnly = true;
            this.dis_gcColPliegosXminuto.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColPliegosXminuto.Visible = true;
            this.dis_gcColPliegosXminuto.Width = 70;
            // 
            // dis_gcColNumPliegos
            // 
            this.dis_gcColNumPliegos.Caption = "Pliegos #";
            this.dis_gcColNumPliegos.DisplayFormat.FormatString = "N0";
            this.dis_gcColNumPliegos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcColNumPliegos.FieldName = "NumPliegos";
            this.dis_gcColNumPliegos.Name = "dis_gcColNumPliegos";
            this.dis_gcColNumPliegos.OptionsColumn.AllowEdit = false;
            this.dis_gcColNumPliegos.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumPliegos.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColNumPliegos.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumPliegos.OptionsColumn.AllowMove = false;
            this.dis_gcColNumPliegos.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColNumPliegos.OptionsColumn.ReadOnly = true;
            this.dis_gcColNumPliegos.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColNumPliegos.Visible = true;
            this.dis_gcColNumPliegos.Width = 70;
            // 
            // dis_bandaPuestaPunto
            // 
            this.dis_bandaPuestaPunto.Caption = "Prepara Máquina";
            this.dis_bandaPuestaPunto.Columns.Add(this.dis_gcColCostoXminutoPP);
            this.dis_bandaPuestaPunto.Columns.Add(this.dis_gcColMinutosPP);
            this.dis_bandaPuestaPunto.Name = "dis_bandaPuestaPunto";
            this.dis_bandaPuestaPunto.OptionsBand.AllowMove = false;
            this.dis_bandaPuestaPunto.OptionsBand.AllowPress = false;
            this.dis_bandaPuestaPunto.VisibleIndex = 2;
            this.dis_bandaPuestaPunto.Width = 130;
            // 
            // dis_gcColCostoXminutoPP
            // 
            this.dis_gcColCostoXminutoPP.Caption = "Costo Min";
            this.dis_gcColCostoXminutoPP.DisplayFormat.FormatString = "e3";
            this.dis_gcColCostoXminutoPP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcColCostoXminutoPP.FieldName = "CostoXminPP";
            this.dis_gcColCostoXminutoPP.Name = "dis_gcColCostoXminutoPP";
            this.dis_gcColCostoXminutoPP.OptionsColumn.AllowEdit = false;
            this.dis_gcColCostoXminutoPP.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCostoXminutoPP.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColCostoXminutoPP.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCostoXminutoPP.OptionsColumn.AllowMove = false;
            this.dis_gcColCostoXminutoPP.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCostoXminutoPP.OptionsColumn.ReadOnly = true;
            this.dis_gcColCostoXminutoPP.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColCostoXminutoPP.Visible = true;
            this.dis_gcColCostoXminutoPP.Width = 70;
            // 
            // dis_gcColMinutosPP
            // 
            this.dis_gcColMinutosPP.Caption = "MIN";
            this.dis_gcColMinutosPP.DisplayFormat.FormatString = "N0";
            this.dis_gcColMinutosPP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcColMinutosPP.FieldName = "MinutosPP";
            this.dis_gcColMinutosPP.Name = "dis_gcColMinutosPP";
            this.dis_gcColMinutosPP.OptionsColumn.AllowEdit = false;
            this.dis_gcColMinutosPP.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMinutosPP.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColMinutosPP.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMinutosPP.OptionsColumn.AllowMove = false;
            this.dis_gcColMinutosPP.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMinutosPP.OptionsColumn.ReadOnly = true;
            this.dis_gcColMinutosPP.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColMinutosPP.Visible = true;
            this.dis_gcColMinutosPP.Width = 60;
            // 
            // dis_bandaTotal
            // 
            this.dis_bandaTotal.Columns.Add(this.dis_gcColTotalLineaI);
            this.dis_bandaTotal.Name = "dis_bandaTotal";
            this.dis_bandaTotal.OptionsBand.AllowHotTrack = false;
            this.dis_bandaTotal.OptionsBand.AllowMove = false;
            this.dis_bandaTotal.OptionsBand.AllowPress = false;
            this.dis_bandaTotal.VisibleIndex = 3;
            this.dis_bandaTotal.Width = 80;
            // 
            // dis_gcColTotalLineaI
            // 
            this.dis_gcColTotalLineaI.Caption = "Total";
            this.dis_gcColTotalLineaI.DisplayFormat.FormatString = "N2";
            this.dis_gcColTotalLineaI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dis_gcColTotalLineaI.FieldName = "TotalLinea";
            this.dis_gcColTotalLineaI.Name = "dis_gcColTotalLineaI";
            this.dis_gcColTotalLineaI.OptionsColumn.AllowEdit = false;
            this.dis_gcColTotalLineaI.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTotalLineaI.OptionsColumn.AllowIncrementalSearch = false;
            this.dis_gcColTotalLineaI.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTotalLineaI.OptionsColumn.AllowMove = false;
            this.dis_gcColTotalLineaI.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColTotalLineaI.OptionsColumn.ReadOnly = true;
            this.dis_gcColTotalLineaI.OptionsFilter.AllowAutoFilter = false;
            this.dis_gcColTotalLineaI.Visible = true;
            this.dis_gcColTotalLineaI.Width = 80;
            // 
            // xtpControlPRD
            // 
            this.xtpControlPRD.Name = "xtpControlPRD";
            this.xtpControlPRD.Size = new System.Drawing.Size(859, 313);
            this.xtpControlPRD.Text = "Procesos";
            // 
            // xtpServiciosEXT
            // 
            this.xtpServiciosEXT.Controls.Add(this.sext_chkMetalico);
            this.xtpServiciosEXT.Controls.Add(this.sext_chkResina);
            this.xtpServiciosEXT.Controls.Add(this.sext_sePlastificadoPRE);
            this.xtpServiciosEXT.Controls.Add(this.sext_seSeguroPRE);
            this.xtpServiciosEXT.Controls.Add(this.sext_seTransportePRE);
            this.xtpServiciosEXT.Controls.Add(this.sext_seTermoselladoPRE);
            this.xtpServiciosEXT.Controls.Add(this.sext_seReservadoPRE);
            this.xtpServiciosEXT.Controls.Add(this.sext_seCocidoPRE);
            this.xtpServiciosEXT.Controls.Add(this.sext_seClishePRE);
            this.xtpServiciosEXT.Controls.Add(this.sext_seTroquelPRE);
            this.xtpServiciosEXT.Controls.Add(this.sext_sePeliculaPRE);
            this.xtpServiciosEXT.Controls.Add(this.labelControl83);
            this.xtpServiciosEXT.Controls.Add(this.labelControl82);
            this.xtpServiciosEXT.Controls.Add(this.labelControl81);
            this.xtpServiciosEXT.Controls.Add(this.labelControl71);
            this.xtpServiciosEXT.Controls.Add(this.labelControl70);
            this.xtpServiciosEXT.Controls.Add(this.labelControl69);
            this.xtpServiciosEXT.Controls.Add(this.labelControl68);
            this.xtpServiciosEXT.Controls.Add(this.labelControl67);
            this.xtpServiciosEXT.Controls.Add(this.labelControl66);
            this.xtpServiciosEXT.Controls.Add(this.labelControl62);
            this.xtpServiciosEXT.Controls.Add(this.labelControl61);
            this.xtpServiciosEXT.Controls.Add(this.labelControl60);
            this.xtpServiciosEXT.Controls.Add(this.sext_txtClishe);
            this.xtpServiciosEXT.Controls.Add(this.sext_txtTroquel);
            this.xtpServiciosEXT.Controls.Add(this.sext_txtPelicula);
            this.xtpServiciosEXT.Name = "xtpServiciosEXT";
            this.xtpServiciosEXT.Size = new System.Drawing.Size(859, 313);
            this.xtpServiciosEXT.Text = "Serv. Externos";
            // 
            // sext_chkMetalico
            // 
            this.sext_chkMetalico.Location = new System.Drawing.Point(77, 146);
            this.sext_chkMetalico.Name = "sext_chkMetalico";
            this.sext_chkMetalico.Properties.Caption = "Metálico";
            this.sext_chkMetalico.Size = new System.Drawing.Size(75, 19);
            this.sext_chkMetalico.TabIndex = 34;
            // 
            // sext_chkResina
            // 
            this.sext_chkResina.Location = new System.Drawing.Point(78, 120);
            this.sext_chkResina.Name = "sext_chkResina";
            this.sext_chkResina.Properties.Caption = "Resina";
            this.sext_chkResina.Size = new System.Drawing.Size(75, 19);
            this.sext_chkResina.TabIndex = 33;
            // 
            // sext_sePlastificadoPRE
            // 
            this.sext_sePlastificadoPRE.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sext_sePlastificadoPRE.Location = new System.Drawing.Point(599, 74);
            this.sext_sePlastificadoPRE.Name = "sext_sePlastificadoPRE";
            this.sext_sePlastificadoPRE.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.sext_sePlastificadoPRE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sext_sePlastificadoPRE.Properties.DisplayFormat.FormatString = "N2";
            this.sext_sePlastificadoPRE.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sext_sePlastificadoPRE.Properties.EditFormat.FormatString = "N2";
            this.sext_sePlastificadoPRE.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sext_sePlastificadoPRE.Properties.Mask.EditMask = "N2";
            this.sext_sePlastificadoPRE.Size = new System.Drawing.Size(100, 20);
            this.sext_sePlastificadoPRE.TabIndex = 32;
            // 
            // sext_seSeguroPRE
            // 
            this.sext_seSeguroPRE.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sext_seSeguroPRE.Location = new System.Drawing.Point(599, 46);
            this.sext_seSeguroPRE.Name = "sext_seSeguroPRE";
            this.sext_seSeguroPRE.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.sext_seSeguroPRE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sext_seSeguroPRE.Properties.DisplayFormat.FormatString = "N2";
            this.sext_seSeguroPRE.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sext_seSeguroPRE.Properties.EditFormat.FormatString = "N2";
            this.sext_seSeguroPRE.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sext_seSeguroPRE.Properties.Mask.EditMask = "N2";
            this.sext_seSeguroPRE.Size = new System.Drawing.Size(100, 20);
            this.sext_seSeguroPRE.TabIndex = 31;
            // 
            // sext_seTransportePRE
            // 
            this.sext_seTransportePRE.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sext_seTransportePRE.Location = new System.Drawing.Point(599, 20);
            this.sext_seTransportePRE.Name = "sext_seTransportePRE";
            this.sext_seTransportePRE.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.sext_seTransportePRE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sext_seTransportePRE.Properties.DisplayFormat.FormatString = "N2";
            this.sext_seTransportePRE.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sext_seTransportePRE.Properties.EditFormat.FormatString = "N2";
            this.sext_seTransportePRE.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sext_seTransportePRE.Properties.Mask.EditMask = "N2";
            this.sext_seTransportePRE.Size = new System.Drawing.Size(100, 20);
            this.sext_seTransportePRE.TabIndex = 30;
            // 
            // sext_seTermoselladoPRE
            // 
            this.sext_seTermoselladoPRE.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sext_seTermoselladoPRE.Location = new System.Drawing.Point(400, 74);
            this.sext_seTermoselladoPRE.Name = "sext_seTermoselladoPRE";
            this.sext_seTermoselladoPRE.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.sext_seTermoselladoPRE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sext_seTermoselladoPRE.Properties.DisplayFormat.FormatString = "N2";
            this.sext_seTermoselladoPRE.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sext_seTermoselladoPRE.Properties.EditFormat.FormatString = "N2";
            this.sext_seTermoselladoPRE.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sext_seTermoselladoPRE.Properties.Mask.EditMask = "N2";
            this.sext_seTermoselladoPRE.Size = new System.Drawing.Size(100, 20);
            this.sext_seTermoselladoPRE.TabIndex = 29;
            // 
            // sext_seReservadoPRE
            // 
            this.sext_seReservadoPRE.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sext_seReservadoPRE.Location = new System.Drawing.Point(400, 46);
            this.sext_seReservadoPRE.Name = "sext_seReservadoPRE";
            this.sext_seReservadoPRE.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.sext_seReservadoPRE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sext_seReservadoPRE.Properties.DisplayFormat.FormatString = "N2";
            this.sext_seReservadoPRE.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sext_seReservadoPRE.Properties.EditFormat.FormatString = "N2";
            this.sext_seReservadoPRE.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sext_seReservadoPRE.Properties.Mask.EditMask = "N2";
            this.sext_seReservadoPRE.Size = new System.Drawing.Size(100, 20);
            this.sext_seReservadoPRE.TabIndex = 28;
            // 
            // sext_seCocidoPRE
            // 
            this.sext_seCocidoPRE.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sext_seCocidoPRE.Location = new System.Drawing.Point(400, 20);
            this.sext_seCocidoPRE.Name = "sext_seCocidoPRE";
            this.sext_seCocidoPRE.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.sext_seCocidoPRE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sext_seCocidoPRE.Properties.DisplayFormat.FormatString = "N2";
            this.sext_seCocidoPRE.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sext_seCocidoPRE.Properties.EditFormat.FormatString = "N2";
            this.sext_seCocidoPRE.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sext_seCocidoPRE.Properties.Mask.EditMask = "N2";
            this.sext_seCocidoPRE.Size = new System.Drawing.Size(100, 20);
            this.sext_seCocidoPRE.TabIndex = 27;
            // 
            // sext_seClishePRE
            // 
            this.sext_seClishePRE.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sext_seClishePRE.Location = new System.Drawing.Point(210, 74);
            this.sext_seClishePRE.Name = "sext_seClishePRE";
            this.sext_seClishePRE.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.sext_seClishePRE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sext_seClishePRE.Properties.DisplayFormat.FormatString = "N2";
            this.sext_seClishePRE.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sext_seClishePRE.Properties.EditFormat.FormatString = "N2";
            this.sext_seClishePRE.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sext_seClishePRE.Properties.Mask.EditMask = "N2";
            this.sext_seClishePRE.Size = new System.Drawing.Size(100, 20);
            this.sext_seClishePRE.TabIndex = 26;
            // 
            // sext_seTroquelPRE
            // 
            this.sext_seTroquelPRE.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sext_seTroquelPRE.Location = new System.Drawing.Point(210, 47);
            this.sext_seTroquelPRE.Name = "sext_seTroquelPRE";
            this.sext_seTroquelPRE.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.sext_seTroquelPRE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sext_seTroquelPRE.Properties.DisplayFormat.FormatString = "N2";
            this.sext_seTroquelPRE.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sext_seTroquelPRE.Properties.EditFormat.FormatString = "N2";
            this.sext_seTroquelPRE.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sext_seTroquelPRE.Properties.Mask.EditMask = "N2";
            this.sext_seTroquelPRE.Size = new System.Drawing.Size(100, 20);
            this.sext_seTroquelPRE.TabIndex = 25;
            // 
            // sext_sePeliculaPRE
            // 
            this.sext_sePeliculaPRE.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sext_sePeliculaPRE.Location = new System.Drawing.Point(210, 20);
            this.sext_sePeliculaPRE.Name = "sext_sePeliculaPRE";
            this.sext_sePeliculaPRE.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.sext_sePeliculaPRE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sext_sePeliculaPRE.Properties.DisplayFormat.FormatString = "N2";
            this.sext_sePeliculaPRE.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sext_sePeliculaPRE.Properties.EditFormat.FormatString = "N2";
            this.sext_sePeliculaPRE.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sext_sePeliculaPRE.Properties.Mask.EditMask = "N2";
            this.sext_sePeliculaPRE.Size = new System.Drawing.Size(100, 20);
            this.sext_sePeliculaPRE.TabIndex = 24;
            // 
            // labelControl83
            // 
            this.labelControl83.Location = new System.Drawing.Point(518, 75);
            this.labelControl83.Name = "labelControl83";
            this.labelControl83.Size = new System.Drawing.Size(58, 13);
            this.labelControl83.TabIndex = 23;
            this.labelControl83.Text = "Plastificado:";
            // 
            // labelControl82
            // 
            this.labelControl82.Location = new System.Drawing.Point(518, 49);
            this.labelControl82.Name = "labelControl82";
            this.labelControl82.Size = new System.Drawing.Size(67, 13);
            this.labelControl82.TabIndex = 22;
            this.labelControl82.Text = "Valija/Seguro:";
            // 
            // labelControl81
            // 
            this.labelControl81.Location = new System.Drawing.Point(518, 23);
            this.labelControl81.Name = "labelControl81";
            this.labelControl81.Size = new System.Drawing.Size(57, 13);
            this.labelControl81.TabIndex = 21;
            this.labelControl81.Text = "Transporte:";
            // 
            // labelControl71
            // 
            this.labelControl71.Location = new System.Drawing.Point(319, 75);
            this.labelControl71.Name = "labelControl71";
            this.labelControl71.Size = new System.Drawing.Size(67, 13);
            this.labelControl71.TabIndex = 20;
            this.labelControl71.Text = "Termosellado:";
            // 
            // labelControl70
            // 
            this.labelControl70.Location = new System.Drawing.Point(319, 49);
            this.labelControl70.Name = "labelControl70";
            this.labelControl70.Size = new System.Drawing.Size(56, 13);
            this.labelControl70.TabIndex = 19;
            this.labelControl70.Text = "Reservado:";
            // 
            // labelControl69
            // 
            this.labelControl69.Location = new System.Drawing.Point(319, 23);
            this.labelControl69.Name = "labelControl69";
            this.labelControl69.Size = new System.Drawing.Size(36, 13);
            this.labelControl69.TabIndex = 18;
            this.labelControl69.Text = "Cocido:";
            // 
            // labelControl68
            // 
            this.labelControl68.Location = new System.Drawing.Point(194, 75);
            this.labelControl68.Name = "labelControl68";
            this.labelControl68.Size = new System.Drawing.Size(10, 13);
            this.labelControl68.TabIndex = 17;
            this.labelControl68.Text = "$:";
            // 
            // labelControl67
            // 
            this.labelControl67.Location = new System.Drawing.Point(194, 49);
            this.labelControl67.Name = "labelControl67";
            this.labelControl67.Size = new System.Drawing.Size(10, 13);
            this.labelControl67.TabIndex = 16;
            this.labelControl67.Text = "$:";
            // 
            // labelControl66
            // 
            this.labelControl66.Location = new System.Drawing.Point(194, 23);
            this.labelControl66.Name = "labelControl66";
            this.labelControl66.Size = new System.Drawing.Size(10, 13);
            this.labelControl66.TabIndex = 15;
            this.labelControl66.Text = "$:";
            // 
            // labelControl62
            // 
            this.labelControl62.Location = new System.Drawing.Point(18, 75);
            this.labelControl62.Name = "labelControl62";
            this.labelControl62.Size = new System.Drawing.Size(32, 13);
            this.labelControl62.TabIndex = 14;
            this.labelControl62.Text = "Clishé:";
            // 
            // labelControl61
            // 
            this.labelControl61.Location = new System.Drawing.Point(17, 49);
            this.labelControl61.Name = "labelControl61";
            this.labelControl61.Size = new System.Drawing.Size(40, 13);
            this.labelControl61.TabIndex = 13;
            this.labelControl61.Text = "Troquel:";
            // 
            // labelControl60
            // 
            this.labelControl60.Location = new System.Drawing.Point(18, 23);
            this.labelControl60.Name = "labelControl60";
            this.labelControl60.Size = new System.Drawing.Size(39, 13);
            this.labelControl60.TabIndex = 12;
            this.labelControl60.Text = "Película:";
            // 
            // sext_txtClishe
            // 
            this.sext_txtClishe.Location = new System.Drawing.Point(78, 72);
            this.sext_txtClishe.Name = "sext_txtClishe";
            this.sext_txtClishe.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.sext_txtClishe.Size = new System.Drawing.Size(100, 20);
            this.sext_txtClishe.TabIndex = 2;
            // 
            // sext_txtTroquel
            // 
            this.sext_txtTroquel.Location = new System.Drawing.Point(78, 46);
            this.sext_txtTroquel.Name = "sext_txtTroquel";
            this.sext_txtTroquel.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.sext_txtTroquel.Size = new System.Drawing.Size(100, 20);
            this.sext_txtTroquel.TabIndex = 1;
            // 
            // sext_txtPelicula
            // 
            this.sext_txtPelicula.Location = new System.Drawing.Point(78, 20);
            this.sext_txtPelicula.Name = "sext_txtPelicula";
            this.sext_txtPelicula.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.sext_txtPelicula.Size = new System.Drawing.Size(100, 20);
            this.sext_txtPelicula.TabIndex = 0;
            // 
            // xtpTerminaTercero
            // 
            this.xtpTerminaTercero.Name = "xtpTerminaTercero";
            this.xtpTerminaTercero.Size = new System.Drawing.Size(859, 313);
            this.xtpTerminaTercero.Text = "Tercerizado";
            // 
            // xtpMateriales
            // 
            this.xtpMateriales.Controls.Add(this.em_gcDetalleEGR);
            this.xtpMateriales.Name = "xtpMateriales";
            this.xtpMateriales.Size = new System.Drawing.Size(859, 313);
            this.xtpMateriales.Text = "Materiales";
            // 
            // em_gcDetalleEGR
            // 
            this.em_gcDetalleEGR.Location = new System.Drawing.Point(3, 3);
            this.em_gcDetalleEGR.MainView = this.em_gvDetalleEGR;
            this.em_gcDetalleEGR.Name = "em_gcDetalleEGR";
            this.em_gcDetalleEGR.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.em_rilueSeccion,
            this.em_rilueMaquina,
            this.em_ribeBuscaMAT});
            this.em_gcDetalleEGR.Size = new System.Drawing.Size(796, 220);
            this.em_gcDetalleEGR.TabIndex = 0;
            this.em_gcDetalleEGR.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.em_gvDetalleEGR});
            // 
            // em_gvDetalleEGR
            // 
            this.em_gvDetalleEGR.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.em_gcColSeccion,
            this.em_gcColMaterial,
            this.em_gcColCantPliego,
            this.em_gcColExtras,
            this.em_gcColCantTamano,
            this.em_gcColAncho,
            this.em_gcColAlto,
            this.em_gcColPlacasMQ,
            this.em_gcColCntPlacas});
            this.em_gvDetalleEGR.GridControl = this.em_gcDetalleEGR;
            this.em_gvDetalleEGR.Name = "em_gvDetalleEGR";
            this.em_gvDetalleEGR.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.em_gvDetalleEGR.OptionsView.ShowGroupPanel = false;
            // 
            // em_gcColSeccion
            // 
            this.em_gcColSeccion.Caption = "Trabajo";
            this.em_gcColSeccion.ColumnEdit = this.em_rilueSeccion;
            this.em_gcColSeccion.FieldName = "CodigoSEC";
            this.em_gcColSeccion.Name = "em_gcColSeccion";
            this.em_gcColSeccion.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.em_gcColSeccion.OptionsColumn.AllowIncrementalSearch = false;
            this.em_gcColSeccion.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.em_gcColSeccion.OptionsColumn.AllowMove = false;
            this.em_gcColSeccion.OptionsColumn.AllowShowHide = false;
            this.em_gcColSeccion.Visible = true;
            this.em_gcColSeccion.VisibleIndex = 0;
            this.em_gcColSeccion.Width = 154;
            // 
            // em_rilueSeccion
            // 
            this.em_rilueSeccion.AutoHeight = false;
            this.em_rilueSeccion.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.em_rilueSeccion.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Sección")});
            this.em_rilueSeccion.DisplayMember = "Descripcion";
            this.em_rilueSeccion.Name = "em_rilueSeccion";
            this.em_rilueSeccion.NullText = "";
            this.em_rilueSeccion.ValueMember = "Codigo";
            // 
            // em_gcColMaterial
            // 
            this.em_gcColMaterial.Caption = "Material";
            this.em_gcColMaterial.ColumnEdit = this.em_ribeBuscaMAT;
            this.em_gcColMaterial.FieldName = "Material";
            this.em_gcColMaterial.Name = "em_gcColMaterial";
            this.em_gcColMaterial.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.em_gcColMaterial.OptionsColumn.AllowIncrementalSearch = false;
            this.em_gcColMaterial.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.em_gcColMaterial.OptionsColumn.AllowMove = false;
            this.em_gcColMaterial.OptionsColumn.AllowShowHide = false;
            this.em_gcColMaterial.OptionsColumn.ReadOnly = true;
            this.em_gcColMaterial.Visible = true;
            this.em_gcColMaterial.VisibleIndex = 1;
            this.em_gcColMaterial.Width = 222;
            // 
            // em_ribeBuscaMAT
            // 
            this.em_ribeBuscaMAT.AutoHeight = false;
            this.em_ribeBuscaMAT.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.em_ribeBuscaMAT.Name = "em_ribeBuscaMAT";
            // 
            // em_gcColCantPliego
            // 
            this.em_gcColCantPliego.Caption = "Pliegos";
            this.em_gcColCantPliego.FieldName = "CntPliego";
            this.em_gcColCantPliego.Name = "em_gcColCantPliego";
            this.em_gcColCantPliego.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.em_gcColCantPliego.OptionsColumn.AllowIncrementalSearch = false;
            this.em_gcColCantPliego.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.em_gcColCantPliego.OptionsColumn.AllowMove = false;
            this.em_gcColCantPliego.OptionsColumn.AllowShowHide = false;
            this.em_gcColCantPliego.Visible = true;
            this.em_gcColCantPliego.VisibleIndex = 2;
            this.em_gcColCantPliego.Width = 102;
            // 
            // em_gcColExtras
            // 
            this.em_gcColExtras.Caption = "Extras";
            this.em_gcColExtras.FieldName = "CntExtra";
            this.em_gcColExtras.Name = "em_gcColExtras";
            this.em_gcColExtras.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.em_gcColExtras.OptionsColumn.AllowIncrementalSearch = false;
            this.em_gcColExtras.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.em_gcColExtras.OptionsColumn.AllowMove = false;
            this.em_gcColExtras.OptionsColumn.AllowShowHide = false;
            this.em_gcColExtras.Visible = true;
            this.em_gcColExtras.VisibleIndex = 3;
            this.em_gcColExtras.Width = 87;
            // 
            // em_gcColCantTamano
            // 
            this.em_gcColCantTamano.Caption = "Tamaños";
            this.em_gcColCantTamano.FieldName = "CntTamano";
            this.em_gcColCantTamano.Name = "em_gcColCantTamano";
            this.em_gcColCantTamano.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.em_gcColCantTamano.OptionsColumn.AllowIncrementalSearch = false;
            this.em_gcColCantTamano.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.em_gcColCantTamano.OptionsColumn.AllowMove = false;
            this.em_gcColCantTamano.OptionsColumn.AllowShowHide = false;
            this.em_gcColCantTamano.Visible = true;
            this.em_gcColCantTamano.VisibleIndex = 4;
            this.em_gcColCantTamano.Width = 193;
            // 
            // em_gcColAncho
            // 
            this.em_gcColAncho.Caption = "Ancho";
            this.em_gcColAncho.FieldName = "Ancho";
            this.em_gcColAncho.Name = "em_gcColAncho";
            this.em_gcColAncho.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.em_gcColAncho.OptionsColumn.AllowIncrementalSearch = false;
            this.em_gcColAncho.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.em_gcColAncho.OptionsColumn.AllowMove = false;
            this.em_gcColAncho.OptionsColumn.AllowShowHide = false;
            this.em_gcColAncho.Visible = true;
            this.em_gcColAncho.VisibleIndex = 5;
            this.em_gcColAncho.Width = 105;
            // 
            // em_gcColAlto
            // 
            this.em_gcColAlto.Caption = "Alto";
            this.em_gcColAlto.FieldName = "Alto";
            this.em_gcColAlto.Name = "em_gcColAlto";
            this.em_gcColAlto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.em_gcColAlto.OptionsColumn.AllowIncrementalSearch = false;
            this.em_gcColAlto.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.em_gcColAlto.OptionsColumn.AllowMove = false;
            this.em_gcColAlto.OptionsColumn.AllowShowHide = false;
            this.em_gcColAlto.Visible = true;
            this.em_gcColAlto.VisibleIndex = 6;
            this.em_gcColAlto.Width = 103;
            // 
            // em_gcColPlacasMQ
            // 
            this.em_gcColPlacasMQ.Caption = "Máquina";
            this.em_gcColPlacasMQ.ColumnEdit = this.em_rilueMaquina;
            this.em_gcColPlacasMQ.FieldName = "CodigoMAQ";
            this.em_gcColPlacasMQ.Name = "em_gcColPlacasMQ";
            this.em_gcColPlacasMQ.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.em_gcColPlacasMQ.OptionsColumn.AllowIncrementalSearch = false;
            this.em_gcColPlacasMQ.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.em_gcColPlacasMQ.OptionsColumn.AllowMove = false;
            this.em_gcColPlacasMQ.OptionsColumn.AllowShowHide = false;
            this.em_gcColPlacasMQ.Visible = true;
            this.em_gcColPlacasMQ.VisibleIndex = 7;
            this.em_gcColPlacasMQ.Width = 156;
            // 
            // em_rilueMaquina
            // 
            this.em_rilueMaquina.AutoHeight = false;
            this.em_rilueMaquina.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.em_rilueMaquina.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Máquina")});
            this.em_rilueMaquina.DisplayMember = "Descripcion";
            this.em_rilueMaquina.Name = "em_rilueMaquina";
            this.em_rilueMaquina.NullText = "";
            this.em_rilueMaquina.ValueMember = "Codigo";
            // 
            // em_gcColCntPlacas
            // 
            this.em_gcColCntPlacas.Caption = "Cantidad";
            this.em_gcColCntPlacas.FieldName = "CntPlaca";
            this.em_gcColCntPlacas.Name = "em_gcColCntPlacas";
            this.em_gcColCntPlacas.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.em_gcColCntPlacas.OptionsColumn.AllowIncrementalSearch = false;
            this.em_gcColCntPlacas.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.em_gcColCntPlacas.OptionsColumn.AllowMove = false;
            this.em_gcColCntPlacas.OptionsColumn.AllowShowHide = false;
            this.em_gcColCntPlacas.Visible = true;
            this.em_gcColCntPlacas.VisibleIndex = 8;
            this.em_gcColCntPlacas.Width = 190;
            // 
            // xtpOtros
            // 
            this.xtpOtros.Controls.Add(this.pgf_CostoComponente);
            this.xtpOtros.Controls.Add(this.lueLineaPRD);
            this.xtpOtros.Controls.Add(this.labelControl13);
            this.xtpOtros.Controls.Add(this.txtEplCotizador);
            this.xtpOtros.Controls.Add(this.labelControl12);
            this.xtpOtros.Controls.Add(this.beEplVendedor);
            this.xtpOtros.Controls.Add(this.labelControl9);
            this.xtpOtros.Controls.Add(this.labelControl10);
            this.xtpOtros.Controls.Add(this.lueSubgrupo);
            this.xtpOtros.Controls.Add(this.labelControl11);
            this.xtpOtros.Controls.Add(this.lueGrupo);
            this.xtpOtros.Name = "xtpOtros";
            this.xtpOtros.Size = new System.Drawing.Size(859, 313);
            this.xtpOtros.Text = "Otros";
            // 
            // lueLineaPRD
            // 
            this.lueLineaPRD.Location = new System.Drawing.Point(573, 18);
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
            this.labelControl13.Location = new System.Drawing.Point(470, 87);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(50, 13);
            this.labelControl13.TabIndex = 76;
            this.labelControl13.Text = "Cotizador:";
            // 
            // txtEplCotizador
            // 
            this.txtEplCotizador.Location = new System.Drawing.Point(573, 84);
            this.txtEplCotizador.Name = "txtEplCotizador";
            this.txtEplCotizador.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtEplCotizador.Properties.MaxLength = 50;
            this.txtEplCotizador.Properties.ReadOnly = true;
            this.txtEplCotizador.Size = new System.Drawing.Size(257, 20);
            this.txtEplCotizador.TabIndex = 75;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(470, 117);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(50, 13);
            this.labelControl12.TabIndex = 74;
            this.labelControl12.Text = "Vendedor:";
            // 
            // beEplVendedor
            // 
            this.beEplVendedor.Location = new System.Drawing.Point(573, 110);
            this.beEplVendedor.Name = "beEplVendedor";
            this.beEplVendedor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.beEplVendedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beEplVendedor.Properties.MaxLength = 50;
            this.beEplVendedor.Properties.ReadOnly = true;
            this.beEplVendedor.Size = new System.Drawing.Size(103, 20);
            this.beEplVendedor.TabIndex = 73;
            this.beEplVendedor.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beEplVendedor_ButtonClick);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(470, 21);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(84, 13);
            this.labelControl9.TabIndex = 67;
            this.labelControl9.Text = "Línea Producción:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(470, 43);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(33, 13);
            this.labelControl10.TabIndex = 68;
            this.labelControl10.Text = "Grupo:";
            // 
            // lueSubgrupo
            // 
            this.lueSubgrupo.Location = new System.Drawing.Point(573, 62);
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
            this.labelControl11.Location = new System.Drawing.Point(470, 65);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(50, 13);
            this.labelControl11.TabIndex = 69;
            this.labelControl11.Text = "Subgrupo:";
            // 
            // lueGrupo
            // 
            this.lueGrupo.Location = new System.Drawing.Point(573, 40);
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
            // xtpDisenoGEN
            // 
            this.xtpDisenoGEN.Controls.Add(this.xtraTabControl1);
            this.xtpDisenoGEN.Name = "xtpDisenoGEN";
            this.xtpDisenoGEN.Size = new System.Drawing.Size(859, 313);
            this.xtpDisenoGEN.Text = "Diseno General";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(3, 10);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(853, 300);
            this.xtraTabControl1.TabIndex = 32;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gbGraficas);
            this.xtraTabPage1.Controls.Add(this.gbOrginales);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(847, 272);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // gbGraficas
            // 
            this.gbGraficas.Controls.Add(this.dis_chklGraficasH);
            this.gbGraficas.Location = new System.Drawing.Point(8, 17);
            this.gbGraficas.Name = "gbGraficas";
            this.gbGraficas.Size = new System.Drawing.Size(200, 126);
            this.gbGraficas.TabIndex = 31;
            this.gbGraficas.Text = "Gráficas Hernández";
            // 
            // dis_chklGraficasH
            // 
            this.dis_chklGraficasH.Cursor = System.Windows.Forms.Cursors.Default;
            this.dis_chklGraficasH.DisplayMember = "Descripcion";
            this.dis_chklGraficasH.Location = new System.Drawing.Point(5, 23);
            this.dis_chklGraficasH.MultiColumn = true;
            this.dis_chklGraficasH.Name = "dis_chklGraficasH";
            this.dis_chklGraficasH.Size = new System.Drawing.Size(180, 93);
            this.dis_chklGraficasH.TabIndex = 26;
            this.dis_chklGraficasH.ValueMember = "Codigo";
            // 
            // gbOrginales
            // 
            this.gbOrginales.Controls.Add(this.dis_chklOriginales);
            this.gbOrginales.Location = new System.Drawing.Point(232, 17);
            this.gbOrginales.Name = "gbOrginales";
            this.gbOrginales.Size = new System.Drawing.Size(200, 126);
            this.gbOrginales.TabIndex = 30;
            this.gbOrginales.Text = "Originales";
            // 
            // dis_chklOriginales
            // 
            this.dis_chklOriginales.Cursor = System.Windows.Forms.Cursors.Default;
            this.dis_chklOriginales.DisplayMember = "Descripcion";
            this.dis_chklOriginales.Location = new System.Drawing.Point(5, 23);
            this.dis_chklOriginales.MultiColumn = true;
            this.dis_chklOriginales.Name = "dis_chklOriginales";
            this.dis_chklOriginales.Size = new System.Drawing.Size(180, 93);
            this.dis_chklOriginales.TabIndex = 25;
            this.dis_chklOriginales.ValueMember = "Codigo";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.dis_gcMaterialCLI);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(847, 272);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // dis_gcMaterialCLI
            // 
            this.dis_gcMaterialCLI.ContextMenuStrip = this.cmClienteMAT;
            this.dis_gcMaterialCLI.Location = new System.Drawing.Point(7, 3);
            this.dis_gcMaterialCLI.MainView = this.dis_gvMaterialCLI;
            this.dis_gcMaterialCLI.Name = "dis_gcMaterialCLI";
            this.dis_gcMaterialCLI.Size = new System.Drawing.Size(774, 266);
            this.dis_gcMaterialCLI.TabIndex = 1;
            this.dis_gcMaterialCLI.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dis_gvMaterialCLI});
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
            // dis_gvMaterialCLI
            // 
            this.dis_gvMaterialCLI.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.dis_gcColMaterialCLI,
            this.dis_gcColCantidadCLI});
            this.dis_gvMaterialCLI.GridControl = this.dis_gcMaterialCLI;
            this.dis_gvMaterialCLI.Name = "dis_gvMaterialCLI";
            this.dis_gvMaterialCLI.OptionsView.ShowGroupPanel = false;
            // 
            // dis_gcColMaterialCLI
            // 
            this.dis_gcColMaterialCLI.Caption = "Material";
            this.dis_gcColMaterialCLI.FieldName = "Material";
            this.dis_gcColMaterialCLI.Name = "dis_gcColMaterialCLI";
            this.dis_gcColMaterialCLI.OptionsColumn.AllowEdit = false;
            this.dis_gcColMaterialCLI.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMaterialCLI.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColMaterialCLI.OptionsColumn.AllowMove = false;
            this.dis_gcColMaterialCLI.OptionsColumn.ReadOnly = true;
            this.dis_gcColMaterialCLI.Visible = true;
            this.dis_gcColMaterialCLI.VisibleIndex = 0;
            this.dis_gcColMaterialCLI.Width = 536;
            // 
            // dis_gcColCantidadCLI
            // 
            this.dis_gcColCantidadCLI.Caption = "Cantidad";
            this.dis_gcColCantidadCLI.FieldName = "Cantidad";
            this.dis_gcColCantidadCLI.Name = "dis_gcColCantidadCLI";
            this.dis_gcColCantidadCLI.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCantidadCLI.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.dis_gcColCantidadCLI.OptionsColumn.AllowMove = false;
            this.dis_gcColCantidadCLI.OptionsColumn.ReadOnly = true;
            this.dis_gcColCantidadCLI.Visible = true;
            this.dis_gcColCantidadCLI.VisibleIndex = 1;
            this.dis_gcColCantidadCLI.Width = 220;
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
            this.labelControl7.Location = new System.Drawing.Point(705, 30);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(33, 13);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "Fecha:";
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
            // chkEstadoCOT
            // 
            this.chkEstadoCOT.Location = new System.Drawing.Point(825, 5);
            this.chkEstadoCOT.Name = "chkEstadoCOT";
            this.chkEstadoCOT.Properties.Caption = "Activo";
            this.chkEstadoCOT.Properties.ReadOnly = true;
            this.chkEstadoCOT.Size = new System.Drawing.Size(54, 19);
            this.chkEstadoCOT.TabIndex = 5;
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
            this.deFechaCOT.Location = new System.Drawing.Point(744, 27);
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
            this.deFechaCOT.Size = new System.Drawing.Size(135, 20);
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
            // txtNombreCLI
            // 
            this.txtNombreCLI.Location = new System.Drawing.Point(104, 27);
            this.txtNombreCLI.Name = "txtNombreCLI";
            this.txtNombreCLI.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtNombreCLI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtNombreCLI.Properties.ReadOnly = true;
            this.txtNombreCLI.Size = new System.Drawing.Size(342, 20);
            this.txtNombreCLI.TabIndex = 1;
            this.txtNombreCLI.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtNombreCLI_ButtonClick);
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
            // pgf_CostoComponente
            // 
            this.pgf_CostoComponente.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pgfArmados,
            this.pgfColores,
            this.pgfPlacas,
            this.pgfTroquel,
            this.pgfComponente});
            this.pgf_CostoComponente.Location = new System.Drawing.Point(11, 3);
            this.pgf_CostoComponente.Name = "pgf_CostoComponente";
            this.pgf_CostoComponente.OptionsView.ShowColumnGrandTotalHeader = false;
            this.pgf_CostoComponente.Size = new System.Drawing.Size(665, 278);
            this.pgf_CostoComponente.TabIndex = 77;
            // 
            // pgfArmados
            // 
            this.pgfArmados.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pgfArmados.AreaIndex = 0;
            this.pgfArmados.Caption = "Armados";
            this.pgfArmados.FieldName = "Armados";
            this.pgfArmados.Name = "pgfArmados";
            // 
            // pgfColores
            // 
            this.pgfColores.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pgfColores.AreaIndex = 1;
            this.pgfColores.Caption = "Colores";
            this.pgfColores.FieldName = "Colores";
            this.pgfColores.Name = "pgfColores";
            this.pgfColores.TopValueType = DevExpress.XtraPivotGrid.PivotTopValueType.Sum;
            // 
            // pgfPlacas
            // 
            this.pgfPlacas.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pgfPlacas.AreaIndex = 2;
            this.pgfPlacas.Caption = "Placas";
            this.pgfPlacas.FieldName = "Placas";
            this.pgfPlacas.Name = "pgfPlacas";
            // 
            // pgfTroquel
            // 
            this.pgfTroquel.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pgfTroquel.AreaIndex = 3;
            this.pgfTroquel.Caption = "Troquel";
            this.pgfTroquel.FieldName = "Troquel";
            this.pgfTroquel.Name = "pgfTroquel";
            // 
            // pgfComponente
            // 
            this.pgfComponente.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pgfComponente.AreaIndex = 0;
            this.pgfComponente.FieldName = "Componente";
            this.pgfComponente.Name = "pgfComponente";
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
            this.xtpDiseno.ResumeLayout(false);
            this.xtpDiseno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_lueComponente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcDiseno)).EndInit();
            this.xtcDiseno.ResumeLayout(false);
            this.dis_xtpArmados.ResumeLayout(false);
            this.dis_xtpArmados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_seTotalCostoPapel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_gcArmados)).EndInit();
            this.cmDisenoMatARMDIS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dis_bgvArmados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_risePorcentajePliegoEXT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_riseAnchoTFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_ribeAltoTFinal)).EndInit();
            this.dis_xtpColores.ResumeLayout(false);
            this.dis_xtpColores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_seTotalCostoTinta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_seGramosPantone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_seGramosMetalizado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_seGramosColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_gcColores)).EndInit();
            this.cmDisenoColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dis_gvColores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_rilueLadoImpresion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_rilueTipoColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_rilueCobertura)).EndInit();
            this.dis_xtpPlacas.ResumeLayout(false);
            this.dis_xtpPlacas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_seTotalPlacas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_seNumPlacas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_gcPlacas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_gvPlacas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_rilueLadoImpresionP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_riseNumColores)).EndInit();
            this.dis_xtpTroquel.ResumeLayout(false);
            this.dis_xtpTroquel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_seCortesTOT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_seCorteLONG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_gcTrqouel)).EndInit();
            this.cmDisenoTroquel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dis_gvTroquel)).EndInit();
            this.dis_xtpAcabados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dis_gcAcabados)).EndInit();
            this.cmDisenoAcabado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dis_gvAcabados)).EndInit();
            this.dis_xtpAccesorios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dis_gcAccesorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_gvAccesorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_riseCantAccesorio)).EndInit();
            this.dis_xtpProcesos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Procesos)).EndInit();
            this.cmProcesos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvProcesos)).EndInit();
            this.dis_xtpProcesosIMP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dis_gcProcesoIMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_bgvProcesoIMP)).EndInit();
            this.xtpServiciosEXT.ResumeLayout(false);
            this.xtpServiciosEXT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sext_chkMetalico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sext_chkResina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sext_sePlastificadoPRE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sext_seSeguroPRE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sext_seTransportePRE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sext_seTermoselladoPRE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sext_seReservadoPRE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sext_seCocidoPRE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sext_seClishePRE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sext_seTroquelPRE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sext_sePeliculaPRE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sext_txtClishe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sext_txtTroquel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sext_txtPelicula.Properties)).EndInit();
            this.xtpMateriales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.em_gcDetalleEGR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.em_gvDetalleEGR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.em_rilueSeccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.em_ribeBuscaMAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.em_rilueMaquina)).EndInit();
            this.xtpOtros.ResumeLayout(false);
            this.xtpOtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueLineaPRD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEplCotizador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beEplVendedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSubgrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGrupo.Properties)).EndInit();
            this.xtpDisenoGEN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbGraficas)).EndInit();
            this.gbGraficas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dis_chklGraficasH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbOrginales)).EndInit();
            this.gbOrginales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dis_chklOriginales)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dis_gcMaterialCLI)).EndInit();
            this.cmClienteMAT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dis_gvMaterialCLI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTiraje.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAlto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAncho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstadoCOT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaCOT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaCOT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCIRUCCLI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCLI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beNumeroCOT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaENT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaENT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beArticulo.Properties)).EndInit();
            this.cmDisenoAccesorios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pgf_CostoComponente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dllStandardTool.StandardTool barraStandar;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SpinEdit seAlto;
        private DevExpress.XtraEditors.SpinEdit seAncho;
        private DevExpress.XtraEditors.CheckEdit chkEstadoCOT;
        private DevExpress.XtraEditors.DateEdit deFechaCOT;
        private DevExpress.XtraEditors.TextEdit txtCIRUCCLI;
        private DevExpress.XtraEditors.ButtonEdit txtNombreCLI;
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
        private DevExpress.XtraTab.XtraTabPage xtpMateriales;
        private DevExpress.XtraGrid.GridControl em_gcDetalleEGR;
        private DevExpress.XtraGrid.Views.Grid.GridView em_gvDetalleEGR;
        private DevExpress.XtraGrid.Columns.GridColumn em_gcColSeccion;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit em_rilueSeccion;
        private DevExpress.XtraGrid.Columns.GridColumn em_gcColMaterial;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit em_ribeBuscaMAT;
        private DevExpress.XtraGrid.Columns.GridColumn em_gcColCantPliego;
        private DevExpress.XtraGrid.Columns.GridColumn em_gcColExtras;
        private DevExpress.XtraGrid.Columns.GridColumn em_gcColCantTamano;
        private DevExpress.XtraGrid.Columns.GridColumn em_gcColAncho;
        private DevExpress.XtraGrid.Columns.GridColumn em_gcColAlto;
        private DevExpress.XtraGrid.Columns.GridColumn em_gcColPlacasMQ;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit em_rilueMaquina;
        private DevExpress.XtraGrid.Columns.GridColumn em_gcColCntPlacas;
        private DevExpress.XtraTab.XtraTabPage xtpDiseno;
        private DevExpress.XtraTab.XtraTabControl xtcDiseno;
        private DevExpress.XtraTab.XtraTabPage dis_xtpArmados;
        private DevExpress.XtraGrid.GridControl dis_gcArmados;
        private DevExpress.XtraTab.XtraTabPage xtpServiciosEXT;
        private DevExpress.XtraEditors.CheckEdit sext_chkMetalico;
        private DevExpress.XtraEditors.CheckEdit sext_chkResina;
        private DevExpress.XtraEditors.SpinEdit sext_sePlastificadoPRE;
        private DevExpress.XtraEditors.SpinEdit sext_seSeguroPRE;
        private DevExpress.XtraEditors.SpinEdit sext_seTransportePRE;
        private DevExpress.XtraEditors.SpinEdit sext_seTermoselladoPRE;
        private DevExpress.XtraEditors.SpinEdit sext_seReservadoPRE;
        private DevExpress.XtraEditors.SpinEdit sext_seCocidoPRE;
        private DevExpress.XtraEditors.SpinEdit sext_seClishePRE;
        private DevExpress.XtraEditors.SpinEdit sext_seTroquelPRE;
        private DevExpress.XtraEditors.SpinEdit sext_sePeliculaPRE;
        private DevExpress.XtraEditors.LabelControl labelControl83;
        private DevExpress.XtraEditors.LabelControl labelControl82;
        private DevExpress.XtraEditors.LabelControl labelControl81;
        private DevExpress.XtraEditors.LabelControl labelControl71;
        private DevExpress.XtraEditors.LabelControl labelControl70;
        private DevExpress.XtraEditors.LabelControl labelControl69;
        private DevExpress.XtraEditors.LabelControl labelControl68;
        private DevExpress.XtraEditors.LabelControl labelControl67;
        private DevExpress.XtraEditors.LabelControl labelControl66;
        private DevExpress.XtraEditors.LabelControl labelControl62;
        private DevExpress.XtraEditors.LabelControl labelControl61;
        private DevExpress.XtraEditors.LabelControl labelControl60;
        private DevExpress.XtraEditors.TextEdit sext_txtClishe;
        private DevExpress.XtraEditors.TextEdit sext_txtTroquel;
        private DevExpress.XtraEditors.TextEdit sext_txtPelicula;
        private DevExpress.XtraTab.XtraTabPage xtpControlPRD;
        private DevExpress.XtraTab.XtraTabPage xtpTerminaTercero;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.ButtonEdit beArticulo;
        private DevExpress.XtraGrid.GridControl blo_gcCopias;
        private DevExpress.XtraGrid.Views.Grid.GridView blo_gvCopias;
        private DevExpress.XtraGrid.Columns.GridColumn blo_gcColSecuencial;
        private DevExpress.XtraGrid.Columns.GridColumn blo_gcColColor;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView dis_bgvArmados;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn dis_gcColMaterial;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn dis_gcColArmadoAncho;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn dis_gcColArmadoAlto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn dis_gcColPliegoMPAncho;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn dis_gcColPliegoMPAlto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn dis_gcColPliegoCantidad;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn dis_gcColPliegoExtra;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn dis_gcColUndCotiza;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn dis_gcColAltoTrabajoF;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn dis_gcColAnchoTrabajoF;
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
        private DevExpress.XtraGrid.GridControl dis_gcColores;
        private DevExpress.XtraGrid.Views.Grid.GridView dis_gvColores;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColTipoColor;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit dis_rilueTipoColor;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit dis_rilueCobertura;
        private DevExpress.XtraGrid.GridControl gc_Procesos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProcesos;
        private DevExpress.XtraGrid.Columns.GridColumn proc_gcColMaquina;
        private DevExpress.XtraGrid.Columns.GridColumn proc_gcColCosto;
        private DevExpress.XtraGrid.Columns.GridColumn proc_gcColTotal;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit blo_rilueColorCopia;
        private System.Windows.Forms.ContextMenuStrip cmClienteMAT;
        private System.Windows.Forms.ToolStripMenuItem mnuAgregaMATCLI;
        private System.Windows.Forms.ToolStripMenuItem mnuQuitaMATCLI;
        private System.Windows.Forms.ContextMenuStrip cmDisenoMatARMDIS;
        private System.Windows.Forms.ContextMenuStrip cmProcesos;
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
        private DevExpress.XtraGrid.Columns.GridColumn proc_gcColCantidad;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn dis_gcColGrupo;
        private System.Windows.Forms.ToolStripMenuItem mnuCalculaDISARM;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn dis_gcColTamanosXpliego;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn dis_gcColImpXtamano;
        private DevExpress.XtraTab.XtraTabPage xtpOtros;
        private DevExpress.XtraTab.XtraTabPage xtpDisenoGEN;
        private DevExpress.XtraEditors.GroupControl gbOrginales;
        private DevExpress.XtraEditors.CheckedListBoxControl dis_chklOriginales;
        private DevExpress.XtraEditors.GroupControl gbGraficas;
        private DevExpress.XtraEditors.CheckedListBoxControl dis_chklGraficasH;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LookUpEdit dis_lueComponente;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl dis_gcMaterialCLI;
        private DevExpress.XtraGrid.Views.Grid.GridView dis_gvMaterialCLI;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColMaterialCLI;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColCantidadCLI;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn dis_gcColNumPaginas;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn dis_gcColPaginasXtrabajo;
        private System.Windows.Forms.ToolStripMenuItem mnuVerGraficaDISARM;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit dis_riseAnchoTFinal;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit dis_ribeAltoTFinal;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn dis_gcPliegoEXTPorcentaje;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit dis_risePorcentajePliegoEXT;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColCobertura;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColGramos;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn dis_gcColPlaca;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn dis_gcColSeleccionAUT;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColMaterialC;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColArea;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandaPliegoMP;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandaPliegoIMP;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandaPliego;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandaTrabajoFinal;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColTotGramos;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColCostoGramoColor;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColDetallePAG;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColLado;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit dis_rilueLadoImpresion;
        private System.Windows.Forms.ToolStripMenuItem mnuAgregaRegistro;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.SpinEdit dis_seTotalCostoTinta;
        private DevExpress.XtraEditors.SpinEdit dis_seGramosPantone;
        private DevExpress.XtraEditors.SpinEdit dis_seGramosMetalizado;
        private DevExpress.XtraEditors.SpinEdit dis_seGramosColor;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColNumPaginasC;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.SpinEdit dis_seTotalCostoPapel;
        private DevExpress.XtraTab.XtraTabPage dis_xtpPlacas;
        private DevExpress.XtraGrid.GridControl dis_gcPlacas;
        private DevExpress.XtraGrid.Views.Grid.GridView dis_gvPlacas;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColMaterialP;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColPlacaP;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColLadoP;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColNumColoresP;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColCostoPlaca;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcTotalLineaP;
        private DevExpress.XtraTab.XtraTabPage dis_xtpTroquel;
        private DevExpress.XtraGrid.GridControl dis_gcTrqouel;
        private DevExpress.XtraGrid.Views.Grid.GridView dis_gvTroquel;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColMaterialT;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColLongitud;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColNumCortesT;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColCostoCorteT;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColTotaLineaT;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit dis_rilueLadoImpresionP;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit dis_riseNumColores;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColTotLinea;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColNumPlacasP;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColNumPaginasP;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColPaginasXplaca;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColPlacasMIN;
        private System.Windows.Forms.ContextMenuStrip cmDisenoTroquel;
        private System.Windows.Forms.ToolStripMenuItem mnuAgregaRegTroquel;
        private System.Windows.Forms.ToolStripMenuItem mnuEliminaRegTroquel;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.SpinEdit dis_seTotalPlacas;
        private DevExpress.XtraEditors.SpinEdit dis_seNumPlacas;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.SpinEdit dis_seCortesTOT;
        private DevExpress.XtraEditors.SpinEdit dis_seCorteLONG;
        private DevExpress.XtraTab.XtraTabPage dis_xtpAcabados;
        private DevExpress.XtraTab.XtraTabPage dis_xtpProcesos;
        private DevExpress.XtraTab.XtraTabPage dis_xtpProcesosIMP;
        private DevExpress.XtraGrid.GridControl dis_gcAcabados;
        private DevExpress.XtraGrid.Views.Grid.GridView dis_gvAcabados;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcMaterialA;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcAreaA;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcAcabadoA;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcCostoA;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcAplicaA;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcTotalLineaA;
        private System.Windows.Forms.ContextMenuStrip cmDisenoAcabado;
        private System.Windows.Forms.ToolStripMenuItem dis_mnuAgregaRegistro;
        private System.Windows.Forms.ToolStripMenuItem dis_mnuEliminaRegistro;
        private System.Windows.Forms.ToolStripMenuItem mnuAgregaAcabado;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColAcabadoMAT;
        private DevExpress.XtraGrid.GridControl dis_gcProcesoIMP;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView dis_bgvProcesoIMP;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn dis_gcColTallaI;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn dis_gcColMaterialI;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn dis_gcColNumColoresI;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn dis_gcColCostoXminuto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn dis_gcColMinImpresion;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn dis_gcColPliegosXminuto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn dis_gcColNumPliegos;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn dis_gcColCostoXminutoPP;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn dis_gcColMinutosPP;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn dis_gcColTotalLineaI;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn dis_gcColPlacaI;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand dis_bandaMaterial;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand dis_bandaImpresion;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand dis_bandaPuestaPunto;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand dis_bandaTotal;
        private DevExpress.XtraTab.XtraTabPage dis_xtpAccesorios;
        private DevExpress.XtraGrid.GridControl dis_gcAccesorios;
        private DevExpress.XtraGrid.Views.Grid.GridView dis_gvAccesorios;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColMaterialS;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColCantidadS;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColCostoS;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColTotalLineaS;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColTirajeS;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit dis_riseCantAccesorio;
        private System.Windows.Forms.ContextMenuStrip cmDisenoAccesorios;
        private System.Windows.Forms.ToolStripMenuItem mnuAgregaAccesorio;
        private System.Windows.Forms.ToolStripMenuItem mnuEliminaAccesorio;
        private DevExpress.XtraPivotGrid.PivotGridControl pgf_CostoComponente;
        private DevExpress.XtraPivotGrid.PivotGridField pgfArmados;
        private DevExpress.XtraPivotGrid.PivotGridField pgfColores;
        private DevExpress.XtraPivotGrid.PivotGridField pgfPlacas;
        private DevExpress.XtraPivotGrid.PivotGridField pgfTroquel;
        private DevExpress.XtraPivotGrid.PivotGridField pgfComponente;
    }
}
