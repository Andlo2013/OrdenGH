namespace Ordenes.Controles
{
    partial class ctlOrden
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
            this.labelControl87 = new DevExpress.XtraEditors.LabelControl();
            this.txtItemORD = new DevExpress.XtraEditors.TextEdit();
            this.xtcResumen = new DevExpress.XtraTab.XtraTabControl();
            this.xtpAcabados = new DevExpress.XtraTab.XtraTabPage();
            this.gcAcabados = new DevExpress.XtraGrid.GridControl();
            this.cmAcabados = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAgregaAcabado = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuitaAcabado = new System.Windows.Forms.ToolStripMenuItem();
            this.gvAcabados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcColTipoAcabado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcColLadoUno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riceUnLado = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gcColLadoDos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riceDosLados = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gcColPáginas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcColNumerosPAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtpTotales = new DevExpress.XtraTab.XtraTabPage();
            this.seSaldo = new DevExpress.XtraEditors.SpinEdit();
            this.seAbono = new DevExpress.XtraEditors.SpinEdit();
            this.seTotal = new DevExpress.XtraEditors.SpinEdit();
            this.seIVA = new DevExpress.XtraEditors.SpinEdit();
            this.seSubtotal = new DevExpress.XtraEditors.SpinEdit();
            this.sePrecioUNI = new DevExpress.XtraEditors.SpinEdit();
            this.seCantidad = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl43 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl48 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl74 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl77 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl73 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl76 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl75 = new DevExpress.XtraEditors.LabelControl();
            this.xtpObservaciones = new DevExpress.XtraTab.XtraTabPage();
            this.meObservacionesORD = new DevExpress.XtraEditors.MemoEdit();
            this.xtcPestanas = new DevExpress.XtraTab.XtraTabControl();
            this.xtpGeneral = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.gen_lueColorRetiro = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl79 = new DevExpress.XtraEditors.LabelControl();
            this.gen_txtOrdenTroquel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl78 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gen_txtAlto = new DevExpress.XtraEditors.TextEdit();
            this.gen_txtAncho = new DevExpress.XtraEditors.TextEdit();
            this.gen_lueTipoTrabajo = new DevExpress.XtraEditors.LookUpEdit();
            this.gen_lueTrabajo = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl32 = new DevExpress.XtraEditors.LabelControl();
            this.gen_lueTroquel = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.gen_txtPantones = new DevExpress.XtraEditors.TextEdit();
            this.gen_lueColorTiro = new DevExpress.XtraEditors.LookUpEdit();
            this.gen_lueTamano = new DevExpress.XtraEditors.LookUpEdit();
            this.gen_txtTiraje = new DevExpress.XtraEditors.TextEdit();
            this.xtpOrden = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.deFechaCOT = new DevExpress.XtraEditors.DateEdit();
            this.labelControl88 = new DevExpress.XtraEditors.LabelControl();
            this.deFechaINI = new DevExpress.XtraEditors.DateEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.deFechaFAC = new DevExpress.XtraEditors.DateEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.deFechaPP = new DevExpress.XtraEditors.DateEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.deFechaENT = new DevExpress.XtraEditors.DateEdit();
            this.xtpDatosCLI = new DevExpress.XtraTab.XtraTabPage();
            this.cli_gcDestinos = new DevExpress.XtraGrid.GridControl();
            this.cmSucursalCLI = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAgregarDestino = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuitarDestino = new System.Windows.Forms.ToolStripMenuItem();
            this.cli_gvDestino = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cli_gcColSecuencial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cli_gcColCodCiudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cli_gcColDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cli_gcColCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcContactos = new DevExpress.XtraGrid.GridControl();
            this.gvContactos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcColContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcColNumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtNombreCLI = new DevExpress.XtraEditors.TextEdit();
            this.beBuscaCLI = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.xtpBlocks = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl41 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl40 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl39 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl38 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl37 = new DevExpress.XtraEditors.LabelControl();
            this.blo_txtPantones = new DevExpress.XtraEditors.TextEdit();
            this.blo_lueColor = new DevExpress.XtraEditors.LookUpEdit();
            this.blo_txtTiraje = new DevExpress.XtraEditors.TextEdit();
            this.blo_txtOrdenTroquel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl34 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl33 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl31 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.blo_txtAlto = new DevExpress.XtraEditors.TextEdit();
            this.blo_txtAncho = new DevExpress.XtraEditors.TextEdit();
            this.blo_lueTamano = new DevExpress.XtraEditors.LookUpEdit();
            this.blo_lueTroquel = new DevExpress.XtraEditors.LookUpEdit();
            this.blo_lueAcabado = new DevExpress.XtraEditors.LookUpEdit();
            this.blo_txtTermina = new DevExpress.XtraEditors.TextEdit();
            this.blo_txtInicia = new DevExpress.XtraEditors.TextEdit();
            this.blo_txtSerie = new DevExpress.XtraEditors.TextEdit();
            this.blo_lueTipoEmblocado = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.blo_txtJuegos = new DevExpress.XtraEditors.TextEdit();
            this.blo_lueNumCopias = new DevExpress.XtraEditors.LookUpEdit();
            this.xtpLibros = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lib_lueForma = new DevExpress.XtraEditors.LookUpEdit();
            this.xtcLibrosDET = new DevExpress.XtraTab.XtraTabControl();
            this.xtpLibroENC = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl57 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl56 = new DevExpress.XtraEditors.LabelControl();
            this.lib_gcColoresENC = new DevExpress.XtraGrid.GridControl();
            this.lib_gvColoresENC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lib_gcColColorENC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilue_gridColorENC = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lib_gcColPaginasENC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl42 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl80 = new DevExpress.XtraEditors.LabelControl();
            this.lib_txtAltoENC = new DevExpress.XtraEditors.TextEdit();
            this.lib_txtAnchoENC = new DevExpress.XtraEditors.TextEdit();
            this.lib_TipoTrabajoENC = new DevExpress.XtraEditors.LookUpEdit();
            this.lib_lueTamanoENC = new DevExpress.XtraEditors.LookUpEdit();
            this.lib_txtNumPaginasENC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl47 = new DevExpress.XtraEditors.LabelControl();
            this.xtpLibroPOR = new DevExpress.XtraTab.XtraTabPage();
            this.lib_txtColorPantonePOR = new DevExpress.XtraEditors.TextEdit();
            this.labelControl55 = new DevExpress.XtraEditors.LabelControl();
            this.lib_beMaterialCubiertaPOR = new DevExpress.XtraEditors.ButtonEdit();
            this.lib_beMaterialGuardaPOR = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl54 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl53 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl51 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl50 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl49 = new DevExpress.XtraEditors.LabelControl();
            this.lib_lueRetiroCubiertaPOR = new DevExpress.XtraEditors.LookUpEdit();
            this.lib_lueRetiroGuardaPOR = new DevExpress.XtraEditors.LookUpEdit();
            this.lib_lueRetiroColorPOR = new DevExpress.XtraEditors.LookUpEdit();
            this.lib_lueTiroCubiertaPOR = new DevExpress.XtraEditors.LookUpEdit();
            this.lib_lueTiroGuardaPOR = new DevExpress.XtraEditors.LookUpEdit();
            this.lib_lueTiroColorPOR = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl46 = new DevExpress.XtraEditors.LabelControl();
            this.lib_txtOrdenPOR = new DevExpress.XtraEditors.TextEdit();
            this.lib_lueTroquelPOR = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl52 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl44 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl45 = new DevExpress.XtraEditors.LabelControl();
            this.lib_txtAltoPOR = new DevExpress.XtraEditors.TextEdit();
            this.lib_txtAnchoPOR = new DevExpress.XtraEditors.TextEdit();
            this.labelControl63 = new DevExpress.XtraEditors.LabelControl();
            this.lib_lueTamanoPOR = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl72 = new DevExpress.XtraEditors.LabelControl();
            this.lib_lueTipoLibro = new DevExpress.XtraEditors.LookUpEdit();
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
            this.xtpDiseno = new DevExpress.XtraTab.XtraTabPage();
            this.xtcDiseno = new DevExpress.XtraTab.XtraTabControl();
            this.dis_xtpGeneral = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl86 = new DevExpress.XtraEditors.LabelControl();
            this.dis_btnActualiza = new DevExpress.XtraEditors.SimpleButton();
            this.gbCTP = new DevExpress.XtraEditors.GroupControl();
            this.dis_chklCTP = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.dis_txtDisenador = new DevExpress.XtraEditors.TextEdit();
            this.gbOrginales = new DevExpress.XtraEditors.GroupControl();
            this.dis_chklOriginales = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.dis_btnTerminar = new DevExpress.XtraEditors.SimpleButton();
            this.gbGraficas = new DevExpress.XtraEditors.GroupControl();
            this.dis_chklGraficasH = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.dis_btnIniciar = new DevExpress.XtraEditors.SimpleButton();
            this.dis_deFechaINI = new DevExpress.XtraEditors.DateEdit();
            this.dis_deFechaFIN = new DevExpress.XtraEditors.DateEdit();
            this.labelControl84 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl85 = new DevExpress.XtraEditors.LabelControl();
            this.dis_xtpArmados = new DevExpress.XtraTab.XtraTabPage();
            this.dis_gcArmados = new DevExpress.XtraGrid.GridControl();
            this.dis_gvArmados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dis_gcColTrabajo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_rilueSeccionARM = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.dis_gcColTamano = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcColAncho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcColAlto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcColMaquina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_xtpMaterialCLI = new DevExpress.XtraTab.XtraTabPage();
            this.dis_gcMaterialCLI = new DevExpress.XtraGrid.GridControl();
            this.cmMaterialCLI = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAgregaMaterialCLI = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuitaMaterialCLI = new System.Windows.Forms.ToolStripMenuItem();
            this.dis_gvMaterialCLI = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dis_gcColMaterialCLI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dis_gcColCantidadCLI = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.xtpControlPRD = new DevExpress.XtraTab.XtraTabPage();
            this.prd_gcDetalle = new DevExpress.XtraGrid.GridControl();
            this.prd_gvDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.prd_gcColEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.prd_gcColFecInicia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.prd_gcColFecTermina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.prd_gcColObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.prd_lueProceso = new DevExpress.XtraEditors.LookUpEdit();
            this.xtpTerminaTercero = new DevExpress.XtraTab.XtraTabPage();
            this.xtpDespachoCLI = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.rdgTipoOFF = new DevExpress.XtraEditors.RadioGroup();
            this.chkEstadoORD = new DevExpress.XtraEditors.CheckEdit();
            this.txtCodigoORD = new DevExpress.XtraEditors.TextEdit();
            this.txtNumeroCOT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.beOrden = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemORD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcResumen)).BeginInit();
            this.xtcResumen.SuspendLayout();
            this.xtpAcabados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAcabados)).BeginInit();
            this.cmAcabados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvAcabados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceUnLado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceDosLados)).BeginInit();
            this.xtpTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seSaldo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAbono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seIVA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSubtotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePrecioUNI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seCantidad.Properties)).BeginInit();
            this.xtpObservaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meObservacionesORD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcPestanas)).BeginInit();
            this.xtcPestanas.SuspendLayout();
            this.xtpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gen_lueColorRetiro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gen_txtOrdenTroquel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gen_txtAlto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gen_txtAncho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gen_lueTipoTrabajo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gen_lueTrabajo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gen_lueTroquel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gen_txtPantones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gen_lueColorTiro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gen_lueTamano.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gen_txtTiraje.Properties)).BeginInit();
            this.xtpOrden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaCOT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaCOT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaINI.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaINI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFAC.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFAC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaPP.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaPP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaENT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaENT.Properties)).BeginInit();
            this.xtpDatosCLI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cli_gcDestinos)).BeginInit();
            this.cmSucursalCLI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cli_gvDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcContactos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvContactos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCLI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beBuscaCLI.Properties)).BeginInit();
            this.xtpBlocks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blo_txtPantones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_lueColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_txtTiraje.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_txtOrdenTroquel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_txtAlto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_txtAncho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_lueTamano.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_lueTroquel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_lueAcabado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_txtTermina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_txtInicia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_txtSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_lueTipoEmblocado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_txtJuegos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_lueNumCopias.Properties)).BeginInit();
            this.xtpLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lib_lueForma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcLibrosDET)).BeginInit();
            this.xtcLibrosDET.SuspendLayout();
            this.xtpLibroENC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lib_gcColoresENC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_gvColoresENC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilue_gridColorENC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_txtAltoENC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_txtAnchoENC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_TipoTrabajoENC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_lueTamanoENC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_txtNumPaginasENC.Properties)).BeginInit();
            this.xtpLibroPOR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lib_txtColorPantonePOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_beMaterialCubiertaPOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_beMaterialGuardaPOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_lueRetiroCubiertaPOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_lueRetiroGuardaPOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_lueRetiroColorPOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_lueTiroCubiertaPOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_lueTiroGuardaPOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_lueTiroColorPOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_txtOrdenPOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_lueTroquelPOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_txtAltoPOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_txtAnchoPOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_lueTamanoPOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_lueTipoLibro.Properties)).BeginInit();
            this.xtpMateriales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.em_gcDetalleEGR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.em_gvDetalleEGR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.em_rilueSeccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.em_ribeBuscaMAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.em_rilueMaquina)).BeginInit();
            this.xtpDiseno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtcDiseno)).BeginInit();
            this.xtcDiseno.SuspendLayout();
            this.dis_xtpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbCTP)).BeginInit();
            this.gbCTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_chklCTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_txtDisenador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbOrginales)).BeginInit();
            this.gbOrginales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_chklOriginales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbGraficas)).BeginInit();
            this.gbGraficas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_chklGraficasH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_deFechaINI.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_deFechaINI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_deFechaFIN.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_deFechaFIN.Properties)).BeginInit();
            this.dis_xtpArmados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_gcArmados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_gvArmados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_rilueSeccionARM)).BeginInit();
            this.dis_xtpMaterialCLI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_gcMaterialCLI)).BeginInit();
            this.cmMaterialCLI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dis_gvMaterialCLI)).BeginInit();
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
            this.xtpControlPRD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prd_gcDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prd_gvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prd_lueProceso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgTipoOFF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstadoORD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoORD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroCOT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beOrden.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraStandar
            // 
            this.barraStandar.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraStandar.Location = new System.Drawing.Point(0, 0);
            this.barraStandar.Name = "barraStandar";
            this.barraStandar.Size = new System.Drawing.Size(834, 24);
            this.barraStandar.TabIndex = 0;
            this.barraStandar.onNew += new dllStandardTool.StandardTool.delegateNew(this.barraStandar_onNew);
            this.barraStandar.onSave += new dllStandardTool.StandardTool.delegateSave(this.barraStandar_onSave);
            this.barraStandar.onEdit += new dllStandardTool.StandardTool.delegateEdit(this.barraStandar_onEdit);
            this.barraStandar.onDelete += new dllStandardTool.StandardTool.delegateDelete(this.barraStandar_onDelete);
            this.barraStandar.onUndo += new dllStandardTool.StandardTool.delegateUndo(this.barraStandar_onUndo);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelControl87);
            this.panel1.Controls.Add(this.txtItemORD);
            this.panel1.Controls.Add(this.xtcResumen);
            this.panel1.Controls.Add(this.xtcPestanas);
            this.panel1.Controls.Add(this.labelControl13);
            this.panel1.Controls.Add(this.rdgTipoOFF);
            this.panel1.Controls.Add(this.chkEstadoORD);
            this.panel1.Controls.Add(this.txtCodigoORD);
            this.panel1.Controls.Add(this.txtNumeroCOT);
            this.panel1.Controls.Add(this.labelControl9);
            this.panel1.Controls.Add(this.labelControl8);
            this.panel1.Controls.Add(this.beOrden);
            this.panel1.Location = new System.Drawing.Point(3, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 453);
            this.panel1.TabIndex = 1;
            // 
            // labelControl87
            // 
            this.labelControl87.Location = new System.Drawing.Point(11, 29);
            this.labelControl87.Name = "labelControl87";
            this.labelControl87.Size = new System.Drawing.Size(26, 13);
            this.labelControl87.TabIndex = 23;
            this.labelControl87.Text = "Item:";
            // 
            // txtItemORD
            // 
            this.txtItemORD.Location = new System.Drawing.Point(85, 26);
            this.txtItemORD.Name = "txtItemORD";
            this.txtItemORD.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtItemORD.Properties.MaxLength = 150;
            this.txtItemORD.Properties.ReadOnly = true;
            this.txtItemORD.Size = new System.Drawing.Size(382, 20);
            this.txtItemORD.TabIndex = 22;
            // 
            // xtcResumen
            // 
            this.xtcResumen.Location = new System.Drawing.Point(7, 312);
            this.xtcResumen.Name = "xtcResumen";
            this.xtcResumen.SelectedTabPage = this.xtpAcabados;
            this.xtcResumen.Size = new System.Drawing.Size(799, 138);
            this.xtcResumen.TabIndex = 21;
            this.xtcResumen.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpAcabados,
            this.xtpTotales,
            this.xtpObservaciones});
            // 
            // xtpAcabados
            // 
            this.xtpAcabados.Controls.Add(this.gcAcabados);
            this.xtpAcabados.Name = "xtpAcabados";
            this.xtpAcabados.Size = new System.Drawing.Size(793, 110);
            this.xtpAcabados.Text = "Acabados";
            // 
            // gcAcabados
            // 
            this.gcAcabados.ContextMenuStrip = this.cmAcabados;
            this.gcAcabados.Location = new System.Drawing.Point(3, 3);
            this.gcAcabados.MainView = this.gvAcabados;
            this.gcAcabados.Name = "gcAcabados";
            this.gcAcabados.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riceUnLado,
            this.riceDosLados});
            this.gcAcabados.Size = new System.Drawing.Size(787, 104);
            this.gcAcabados.TabIndex = 0;
            this.gcAcabados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAcabados});
            // 
            // cmAcabados
            // 
            this.cmAcabados.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAgregaAcabado,
            this.mnuQuitaAcabado});
            this.cmAcabados.Name = "cmAcabados";
            this.cmAcabados.Size = new System.Drawing.Size(167, 48);
            // 
            // mnuAgregaAcabado
            // 
            this.mnuAgregaAcabado.Name = "mnuAgregaAcabado";
            this.mnuAgregaAcabado.Size = new System.Drawing.Size(166, 22);
            this.mnuAgregaAcabado.Text = "Agregar Acabado";
            this.mnuAgregaAcabado.Click += new System.EventHandler(this.mnuAgregaAcabado_Click);
            // 
            // mnuQuitaAcabado
            // 
            this.mnuQuitaAcabado.Name = "mnuQuitaAcabado";
            this.mnuQuitaAcabado.Size = new System.Drawing.Size(166, 22);
            this.mnuQuitaAcabado.Text = "Quitar Acabado";
            this.mnuQuitaAcabado.Click += new System.EventHandler(this.mnuQuitaAcabado_Click);
            // 
            // gvAcabados
            // 
            this.gvAcabados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcColTipoAcabado,
            this.gcColLadoUno,
            this.gcColLadoDos,
            this.gcColPáginas,
            this.gcColNumerosPAG});
            this.gvAcabados.GridControl = this.gcAcabados;
            this.gvAcabados.Name = "gvAcabados";
            this.gvAcabados.OptionsView.ShowGroupPanel = false;
            // 
            // gcColTipoAcabado
            // 
            this.gcColTipoAcabado.Caption = "Acabado";
            this.gcColTipoAcabado.FieldName = "Acabado";
            this.gcColTipoAcabado.Name = "gcColTipoAcabado";
            this.gcColTipoAcabado.OptionsColumn.AllowEdit = false;
            this.gcColTipoAcabado.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gcColTipoAcabado.OptionsColumn.AllowIncrementalSearch = false;
            this.gcColTipoAcabado.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gcColTipoAcabado.OptionsColumn.AllowMove = false;
            this.gcColTipoAcabado.Visible = true;
            this.gcColTipoAcabado.VisibleIndex = 0;
            this.gcColTipoAcabado.Width = 217;
            // 
            // gcColLadoUno
            // 
            this.gcColLadoUno.Caption = "1 Lado";
            this.gcColLadoUno.ColumnEdit = this.riceUnLado;
            this.gcColLadoUno.FieldName = "UnLado";
            this.gcColLadoUno.Name = "gcColLadoUno";
            this.gcColLadoUno.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gcColLadoUno.OptionsColumn.AllowIncrementalSearch = false;
            this.gcColLadoUno.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gcColLadoUno.OptionsColumn.AllowMove = false;
            this.gcColLadoUno.Visible = true;
            this.gcColLadoUno.VisibleIndex = 1;
            this.gcColLadoUno.Width = 82;
            // 
            // riceUnLado
            // 
            this.riceUnLado.AutoHeight = false;
            this.riceUnLado.Name = "riceUnLado";
            this.riceUnLado.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // gcColLadoDos
            // 
            this.gcColLadoDos.Caption = "2 Lados";
            this.gcColLadoDos.ColumnEdit = this.riceDosLados;
            this.gcColLadoDos.FieldName = "DosLados";
            this.gcColLadoDos.Name = "gcColLadoDos";
            this.gcColLadoDos.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gcColLadoDos.OptionsColumn.AllowIncrementalSearch = false;
            this.gcColLadoDos.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gcColLadoDos.OptionsColumn.AllowMove = false;
            this.gcColLadoDos.Visible = true;
            this.gcColLadoDos.VisibleIndex = 2;
            this.gcColLadoDos.Width = 93;
            // 
            // riceDosLados
            // 
            this.riceDosLados.AutoHeight = false;
            this.riceDosLados.Name = "riceDosLados";
            this.riceDosLados.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // gcColPáginas
            // 
            this.gcColPáginas.Caption = "Páginas";
            this.gcColPáginas.FieldName = "Paginas";
            this.gcColPáginas.Name = "gcColPáginas";
            this.gcColPáginas.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gcColPáginas.OptionsColumn.AllowIncrementalSearch = false;
            this.gcColPáginas.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gcColPáginas.OptionsColumn.AllowMove = false;
            this.gcColPáginas.Visible = true;
            this.gcColPáginas.VisibleIndex = 3;
            this.gcColPáginas.Width = 153;
            // 
            // gcColNumerosPAG
            // 
            this.gcColNumerosPAG.Caption = "Nros. Página";
            this.gcColNumerosPAG.FieldName = "NumPaginas";
            this.gcColNumerosPAG.Name = "gcColNumerosPAG";
            this.gcColNumerosPAG.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gcColNumerosPAG.OptionsColumn.AllowIncrementalSearch = false;
            this.gcColNumerosPAG.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gcColNumerosPAG.OptionsColumn.AllowMove = false;
            this.gcColNumerosPAG.Visible = true;
            this.gcColNumerosPAG.VisibleIndex = 4;
            this.gcColNumerosPAG.Width = 224;
            // 
            // xtpTotales
            // 
            this.xtpTotales.Controls.Add(this.seSaldo);
            this.xtpTotales.Controls.Add(this.seAbono);
            this.xtpTotales.Controls.Add(this.seTotal);
            this.xtpTotales.Controls.Add(this.seIVA);
            this.xtpTotales.Controls.Add(this.seSubtotal);
            this.xtpTotales.Controls.Add(this.sePrecioUNI);
            this.xtpTotales.Controls.Add(this.seCantidad);
            this.xtpTotales.Controls.Add(this.labelControl43);
            this.xtpTotales.Controls.Add(this.labelControl48);
            this.xtpTotales.Controls.Add(this.labelControl74);
            this.xtpTotales.Controls.Add(this.labelControl77);
            this.xtpTotales.Controls.Add(this.labelControl73);
            this.xtpTotales.Controls.Add(this.labelControl76);
            this.xtpTotales.Controls.Add(this.labelControl75);
            this.xtpTotales.Name = "xtpTotales";
            this.xtpTotales.Size = new System.Drawing.Size(793, 110);
            this.xtpTotales.Text = "Totales";
            // 
            // seSaldo
            // 
            this.seSaldo.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seSaldo.Location = new System.Drawing.Point(686, 73);
            this.seSaldo.Name = "seSaldo";
            this.seSaldo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.seSaldo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seSaldo.Properties.DisplayFormat.FormatString = "N2";
            this.seSaldo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seSaldo.Properties.EditFormat.FormatString = "N2";
            this.seSaldo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seSaldo.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seSaldo.Properties.Mask.EditMask = "N2";
            this.seSaldo.Properties.ReadOnly = true;
            this.seSaldo.Size = new System.Drawing.Size(100, 20);
            this.seSaldo.TabIndex = 41;
            // 
            // seAbono
            // 
            this.seAbono.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seAbono.Location = new System.Drawing.Point(686, 50);
            this.seAbono.Name = "seAbono";
            this.seAbono.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.seAbono.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seAbono.Properties.DisplayFormat.FormatString = "N2";
            this.seAbono.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seAbono.Properties.EditFormat.FormatString = "N2";
            this.seAbono.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seAbono.Properties.Mask.EditMask = "N2";
            this.seAbono.Size = new System.Drawing.Size(100, 20);
            this.seAbono.TabIndex = 40;
            // 
            // seTotal
            // 
            this.seTotal.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seTotal.Location = new System.Drawing.Point(686, 28);
            this.seTotal.Name = "seTotal";
            this.seTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.seTotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seTotal.Properties.DisplayFormat.FormatString = "N2";
            this.seTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seTotal.Properties.EditFormat.FormatString = "N2";
            this.seTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seTotal.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seTotal.Properties.Mask.EditMask = "N2";
            this.seTotal.Properties.ReadOnly = true;
            this.seTotal.Size = new System.Drawing.Size(100, 20);
            this.seTotal.TabIndex = 39;
            // 
            // seIVA
            // 
            this.seIVA.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seIVA.Location = new System.Drawing.Point(529, 28);
            this.seIVA.Name = "seIVA";
            this.seIVA.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.seIVA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seIVA.Properties.DisplayFormat.FormatString = "N2";
            this.seIVA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seIVA.Properties.EditFormat.FormatString = "N2";
            this.seIVA.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seIVA.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seIVA.Properties.Mask.EditMask = "N2";
            this.seIVA.Properties.ReadOnly = true;
            this.seIVA.Size = new System.Drawing.Size(62, 20);
            this.seIVA.TabIndex = 38;
            // 
            // seSubtotal
            // 
            this.seSubtotal.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seSubtotal.Location = new System.Drawing.Point(423, 27);
            this.seSubtotal.Name = "seSubtotal";
            this.seSubtotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.seSubtotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seSubtotal.Properties.DisplayFormat.FormatString = "N2";
            this.seSubtotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seSubtotal.Properties.EditFormat.FormatString = "N2";
            this.seSubtotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seSubtotal.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seSubtotal.Properties.Mask.EditMask = "N2";
            this.seSubtotal.Properties.ReadOnly = true;
            this.seSubtotal.Size = new System.Drawing.Size(89, 20);
            this.seSubtotal.TabIndex = 37;
            // 
            // sePrecioUNI
            // 
            this.sePrecioUNI.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sePrecioUNI.Location = new System.Drawing.Point(317, 27);
            this.sePrecioUNI.Name = "sePrecioUNI";
            this.sePrecioUNI.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.sePrecioUNI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sePrecioUNI.Properties.DisplayFormat.FormatString = "N2";
            this.sePrecioUNI.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sePrecioUNI.Properties.EditFormat.FormatString = "N2";
            this.sePrecioUNI.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sePrecioUNI.Properties.Mask.EditMask = "N2";
            this.sePrecioUNI.Size = new System.Drawing.Size(89, 20);
            this.sePrecioUNI.TabIndex = 36;
            // 
            // seCantidad
            // 
            this.seCantidad.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seCantidad.Location = new System.Drawing.Point(225, 28);
            this.seCantidad.Name = "seCantidad";
            this.seCantidad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.seCantidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seCantidad.Properties.DisplayFormat.FormatString = "N0";
            this.seCantidad.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seCantidad.Properties.EditFormat.FormatString = "N0";
            this.seCantidad.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seCantidad.Properties.Mask.EditMask = "N0";
            this.seCantidad.Size = new System.Drawing.Size(75, 20);
            this.seCantidad.TabIndex = 35;
            // 
            // labelControl43
            // 
            this.labelControl43.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl43.Location = new System.Drawing.Point(621, 79);
            this.labelControl43.Name = "labelControl43";
            this.labelControl43.Size = new System.Drawing.Size(42, 14);
            this.labelControl43.TabIndex = 28;
            this.labelControl43.Text = "SALDO";
            // 
            // labelControl48
            // 
            this.labelControl48.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl48.Location = new System.Drawing.Point(621, 53);
            this.labelControl48.Name = "labelControl48";
            this.labelControl48.Size = new System.Drawing.Size(43, 14);
            this.labelControl48.TabIndex = 29;
            this.labelControl48.Text = "ABONO";
            // 
            // labelControl74
            // 
            this.labelControl74.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl74.Location = new System.Drawing.Point(568, 8);
            this.labelControl74.Name = "labelControl74";
            this.labelControl74.Size = new System.Drawing.Size(23, 14);
            this.labelControl74.TabIndex = 31;
            this.labelControl74.Text = "IVA";
            // 
            // labelControl77
            // 
            this.labelControl77.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl77.Location = new System.Drawing.Point(236, 8);
            this.labelControl77.Name = "labelControl77";
            this.labelControl77.Size = new System.Drawing.Size(64, 14);
            this.labelControl77.TabIndex = 34;
            this.labelControl77.Text = "CANTIDAD";
            // 
            // labelControl73
            // 
            this.labelControl73.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl73.Location = new System.Drawing.Point(621, 30);
            this.labelControl73.Name = "labelControl73";
            this.labelControl73.Size = new System.Drawing.Size(39, 14);
            this.labelControl73.TabIndex = 30;
            this.labelControl73.Text = "TOTAL";
            // 
            // labelControl76
            // 
            this.labelControl76.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl76.Location = new System.Drawing.Point(330, 8);
            this.labelControl76.Name = "labelControl76";
            this.labelControl76.Size = new System.Drawing.Size(76, 14);
            this.labelControl76.TabIndex = 33;
            this.labelControl76.Text = "P. UNITARIO";
            // 
            // labelControl75
            // 
            this.labelControl75.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl75.Location = new System.Drawing.Point(449, 8);
            this.labelControl75.Name = "labelControl75";
            this.labelControl75.Size = new System.Drawing.Size(63, 14);
            this.labelControl75.TabIndex = 32;
            this.labelControl75.Text = "SUBTOTAL";
            // 
            // xtpObservaciones
            // 
            this.xtpObservaciones.Controls.Add(this.meObservacionesORD);
            this.xtpObservaciones.Name = "xtpObservaciones";
            this.xtpObservaciones.Size = new System.Drawing.Size(793, 110);
            this.xtpObservaciones.Text = "Observaciones";
            // 
            // meObservacionesORD
            // 
            this.meObservacionesORD.Location = new System.Drawing.Point(3, 3);
            this.meObservacionesORD.Name = "meObservacionesORD";
            this.meObservacionesORD.Size = new System.Drawing.Size(787, 104);
            this.meObservacionesORD.TabIndex = 0;
            // 
            // xtcPestanas
            // 
            this.xtcPestanas.Location = new System.Drawing.Point(7, 52);
            this.xtcPestanas.Name = "xtcPestanas";
            this.xtcPestanas.SelectedTabPage = this.xtpGeneral;
            this.xtcPestanas.Size = new System.Drawing.Size(808, 254);
            this.xtcPestanas.TabIndex = 20;
            this.xtcPestanas.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpOrden,
            this.xtpDatosCLI,
            this.xtpGeneral,
            this.xtpBlocks,
            this.xtpLibros,
            this.xtpMateriales,
            this.xtpDiseno,
            this.xtpServiciosEXT,
            this.xtpControlPRD,
            this.xtpTerminaTercero,
            this.xtpDespachoCLI});
            // 
            // xtpGeneral
            // 
            this.xtpGeneral.Controls.Add(this.labelControl23);
            this.xtpGeneral.Controls.Add(this.gen_lueColorRetiro);
            this.xtpGeneral.Controls.Add(this.labelControl79);
            this.xtpGeneral.Controls.Add(this.gen_txtOrdenTroquel);
            this.xtpGeneral.Controls.Add(this.labelControl78);
            this.xtpGeneral.Controls.Add(this.labelControl3);
            this.xtpGeneral.Controls.Add(this.gen_txtAlto);
            this.xtpGeneral.Controls.Add(this.gen_txtAncho);
            this.xtpGeneral.Controls.Add(this.gen_lueTipoTrabajo);
            this.xtpGeneral.Controls.Add(this.gen_lueTrabajo);
            this.xtpGeneral.Controls.Add(this.labelControl16);
            this.xtpGeneral.Controls.Add(this.labelControl15);
            this.xtpGeneral.Controls.Add(this.labelControl32);
            this.xtpGeneral.Controls.Add(this.gen_lueTroquel);
            this.xtpGeneral.Controls.Add(this.labelControl20);
            this.xtpGeneral.Controls.Add(this.labelControl19);
            this.xtpGeneral.Controls.Add(this.labelControl18);
            this.xtpGeneral.Controls.Add(this.labelControl17);
            this.xtpGeneral.Controls.Add(this.gen_txtPantones);
            this.xtpGeneral.Controls.Add(this.gen_lueColorTiro);
            this.xtpGeneral.Controls.Add(this.gen_lueTamano);
            this.xtpGeneral.Controls.Add(this.gen_txtTiraje);
            this.xtpGeneral.Name = "xtpGeneral";
            this.xtpGeneral.Size = new System.Drawing.Size(802, 226);
            this.xtpGeneral.Text = "Trabajos Generales";
            // 
            // labelControl23
            // 
            this.labelControl23.Location = new System.Drawing.Point(523, 99);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(61, 13);
            this.labelControl23.TabIndex = 68;
            this.labelControl23.Text = "Color Retiro:";
            // 
            // gen_lueColorRetiro
            // 
            this.gen_lueColorRetiro.Location = new System.Drawing.Point(600, 96);
            this.gen_lueColorRetiro.Name = "gen_lueColorRetiro";
            this.gen_lueColorRetiro.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gen_lueColorRetiro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gen_lueColorRetiro.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Color")});
            this.gen_lueColorRetiro.Properties.DisplayMember = "Descripcion";
            this.gen_lueColorRetiro.Properties.NullText = "";
            this.gen_lueColorRetiro.Properties.ValueMember = "Codigo";
            this.gen_lueColorRetiro.Size = new System.Drawing.Size(142, 20);
            this.gen_lueColorRetiro.TabIndex = 67;
            // 
            // labelControl79
            // 
            this.labelControl79.Location = new System.Drawing.Point(523, 55);
            this.labelControl79.Name = "labelControl79";
            this.labelControl79.Size = new System.Drawing.Size(34, 13);
            this.labelControl79.TabIndex = 66;
            this.labelControl79.Text = "Orden:";
            // 
            // gen_txtOrdenTroquel
            // 
            this.gen_txtOrdenTroquel.Location = new System.Drawing.Point(600, 52);
            this.gen_txtOrdenTroquel.Name = "gen_txtOrdenTroquel";
            this.gen_txtOrdenTroquel.Properties.Appearance.Options.UseTextOptions = true;
            this.gen_txtOrdenTroquel.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gen_txtOrdenTroquel.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gen_txtOrdenTroquel.Properties.MaxLength = 8;
            this.gen_txtOrdenTroquel.Size = new System.Drawing.Size(142, 20);
            this.gen_txtOrdenTroquel.TabIndex = 65;
            // 
            // labelControl78
            // 
            this.labelControl78.Location = new System.Drawing.Point(208, 99);
            this.labelControl78.Name = "labelControl78";
            this.labelControl78.Size = new System.Drawing.Size(23, 13);
            this.labelControl78.TabIndex = 63;
            this.labelControl78.Text = "Alto:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 97);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 62;
            this.labelControl3.Text = "Ancho:";
            // 
            // gen_txtAlto
            // 
            this.gen_txtAlto.EditValue = "";
            this.gen_txtAlto.Location = new System.Drawing.Point(238, 96);
            this.gen_txtAlto.Name = "gen_txtAlto";
            this.gen_txtAlto.Properties.Appearance.Options.UseTextOptions = true;
            this.gen_txtAlto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gen_txtAlto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gen_txtAlto.Properties.MaxLength = 8;
            this.gen_txtAlto.Size = new System.Drawing.Size(66, 20);
            this.gen_txtAlto.TabIndex = 61;
            // 
            // gen_txtAncho
            // 
            this.gen_txtAncho.Location = new System.Drawing.Point(108, 96);
            this.gen_txtAncho.Name = "gen_txtAncho";
            this.gen_txtAncho.Properties.Appearance.Options.UseTextOptions = true;
            this.gen_txtAncho.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gen_txtAncho.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gen_txtAncho.Properties.MaxLength = 8;
            this.gen_txtAncho.Size = new System.Drawing.Size(66, 20);
            this.gen_txtAncho.TabIndex = 60;
            // 
            // gen_lueTipoTrabajo
            // 
            this.gen_lueTipoTrabajo.Location = new System.Drawing.Point(108, 51);
            this.gen_lueTipoTrabajo.Name = "gen_lueTipoTrabajo";
            this.gen_lueTipoTrabajo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gen_lueTipoTrabajo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gen_lueTipoTrabajo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Tipo Trabajo")});
            this.gen_lueTipoTrabajo.Properties.DisplayMember = "Descripcion";
            this.gen_lueTipoTrabajo.Properties.NullText = "";
            this.gen_lueTipoTrabajo.Properties.ValueMember = "Codigo";
            this.gen_lueTipoTrabajo.Size = new System.Drawing.Size(372, 20);
            this.gen_lueTipoTrabajo.TabIndex = 59;
            // 
            // gen_lueTrabajo
            // 
            this.gen_lueTrabajo.Location = new System.Drawing.Point(108, 29);
            this.gen_lueTrabajo.Name = "gen_lueTrabajo";
            this.gen_lueTrabajo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gen_lueTrabajo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gen_lueTrabajo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Trabajo")});
            this.gen_lueTrabajo.Properties.DisplayMember = "Descripcion";
            this.gen_lueTrabajo.Properties.NullText = "";
            this.gen_lueTrabajo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.gen_lueTrabajo.Properties.ValueMember = "Codigo";
            this.gen_lueTrabajo.Size = new System.Drawing.Size(196, 20);
            this.gen_lueTrabajo.TabIndex = 58;
            this.gen_lueTrabajo.EditValueChanged += new System.EventHandler(this.gen_lueTrabajo_EditValueChanged);
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(17, 54);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(77, 13);
            this.labelControl16.TabIndex = 8;
            this.labelControl16.Text = "Tipo de trabajo:";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(17, 32);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(41, 13);
            this.labelControl15.TabIndex = 7;
            this.labelControl15.Text = "Trabajo:";
            // 
            // labelControl32
            // 
            this.labelControl32.Location = new System.Drawing.Point(523, 32);
            this.labelControl32.Name = "labelControl32";
            this.labelControl32.Size = new System.Drawing.Size(40, 13);
            this.labelControl32.TabIndex = 38;
            this.labelControl32.Text = "Troquel:";
            // 
            // gen_lueTroquel
            // 
            this.gen_lueTroquel.Location = new System.Drawing.Point(600, 29);
            this.gen_lueTroquel.Name = "gen_lueTroquel";
            this.gen_lueTroquel.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gen_lueTroquel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gen_lueTroquel.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Troquel")});
            this.gen_lueTroquel.Properties.DisplayMember = "Descripcion";
            this.gen_lueTroquel.Properties.NullText = "";
            this.gen_lueTroquel.Properties.ValueMember = "Codigo";
            this.gen_lueTroquel.Size = new System.Drawing.Size(142, 20);
            this.gen_lueTroquel.TabIndex = 29;
            // 
            // labelControl20
            // 
            this.labelControl20.Location = new System.Drawing.Point(523, 121);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(49, 13);
            this.labelControl20.TabIndex = 12;
            this.labelControl20.Text = "Pantones:";
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(523, 77);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(50, 13);
            this.labelControl19.TabIndex = 11;
            this.labelControl19.Text = "Color Tiro:";
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(366, 32);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(31, 13);
            this.labelControl18.TabIndex = 10;
            this.labelControl18.Text = "Tiraje:";
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(17, 76);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(42, 13);
            this.labelControl17.TabIndex = 9;
            this.labelControl17.Text = "Tamaño:";
            // 
            // gen_txtPantones
            // 
            this.gen_txtPantones.Location = new System.Drawing.Point(600, 118);
            this.gen_txtPantones.Name = "gen_txtPantones";
            this.gen_txtPantones.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gen_txtPantones.Size = new System.Drawing.Size(142, 20);
            this.gen_txtPantones.TabIndex = 6;
            // 
            // gen_lueColorTiro
            // 
            this.gen_lueColorTiro.Location = new System.Drawing.Point(600, 74);
            this.gen_lueColorTiro.Name = "gen_lueColorTiro";
            this.gen_lueColorTiro.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gen_lueColorTiro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gen_lueColorTiro.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Color")});
            this.gen_lueColorTiro.Properties.DisplayMember = "Descripcion";
            this.gen_lueColorTiro.Properties.NullText = "";
            this.gen_lueColorTiro.Properties.ValueMember = "Codigo";
            this.gen_lueColorTiro.Size = new System.Drawing.Size(142, 20);
            this.gen_lueColorTiro.TabIndex = 5;
            // 
            // gen_lueTamano
            // 
            this.gen_lueTamano.Location = new System.Drawing.Point(108, 73);
            this.gen_lueTamano.Name = "gen_lueTamano";
            this.gen_lueTamano.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gen_lueTamano.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gen_lueTamano.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Tamaño")});
            this.gen_lueTamano.Properties.DisplayMember = "Descripcion";
            this.gen_lueTamano.Properties.NullText = "";
            this.gen_lueTamano.Properties.ValueMember = "Codigo";
            this.gen_lueTamano.Size = new System.Drawing.Size(196, 20);
            this.gen_lueTamano.TabIndex = 4;
            // 
            // gen_txtTiraje
            // 
            this.gen_txtTiraje.EditValue = "";
            this.gen_txtTiraje.Location = new System.Drawing.Point(403, 29);
            this.gen_txtTiraje.Name = "gen_txtTiraje";
            this.gen_txtTiraje.Properties.Appearance.Options.UseTextOptions = true;
            this.gen_txtTiraje.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gen_txtTiraje.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gen_txtTiraje.Properties.MaxLength = 8;
            this.gen_txtTiraje.Size = new System.Drawing.Size(77, 20);
            this.gen_txtTiraje.TabIndex = 1;
            // 
            // xtpOrden
            // 
            this.xtpOrden.Controls.Add(this.groupControl1);
            this.xtpOrden.Name = "xtpOrden";
            this.xtpOrden.Size = new System.Drawing.Size(802, 226);
            this.xtpOrden.Text = "Orden";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(5, 23);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(85, 13);
            this.labelControl5.TabIndex = 21;
            this.labelControl5.Text = "Fecha Cotización:";
            // 
            // deFechaCOT
            // 
            this.deFechaCOT.EditValue = null;
            this.deFechaCOT.Location = new System.Drawing.Point(126, 23);
            this.deFechaCOT.Name = "deFechaCOT";
            this.deFechaCOT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.deFechaCOT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaCOT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaCOT.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.deFechaCOT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.deFechaCOT.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.deFechaCOT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.deFechaCOT.Properties.Mask.EditMask = "yyyy-MM-dd HH:mm:ss";
            this.deFechaCOT.Size = new System.Drawing.Size(187, 20);
            this.deFechaCOT.TabIndex = 20;
            // 
            // labelControl88
            // 
            this.labelControl88.Location = new System.Drawing.Point(5, 48);
            this.labelControl88.Name = "labelControl88";
            this.labelControl88.Size = new System.Drawing.Size(61, 13);
            this.labelControl88.TabIndex = 19;
            this.labelControl88.Text = "Fecha Inicia:";
            // 
            // deFechaINI
            // 
            this.deFechaINI.EditValue = null;
            this.deFechaINI.Location = new System.Drawing.Point(126, 45);
            this.deFechaINI.Name = "deFechaINI";
            this.deFechaINI.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.deFechaINI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaINI.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaINI.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.deFechaINI.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.deFechaINI.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.deFechaINI.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.deFechaINI.Properties.Mask.EditMask = "yyyy-MM-dd HH:mm:ss";
            this.deFechaINI.Size = new System.Drawing.Size(187, 20);
            this.deFechaINI.TabIndex = 18;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(5, 70);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(73, 13);
            this.labelControl12.TabIndex = 17;
            this.labelControl12.Text = "Fecha Factura:";
            // 
            // deFechaFAC
            // 
            this.deFechaFAC.EditValue = null;
            this.deFechaFAC.Location = new System.Drawing.Point(126, 67);
            this.deFechaFAC.Name = "deFechaFAC";
            this.deFechaFAC.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.deFechaFAC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaFAC.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaFAC.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.deFechaFAC.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.deFechaFAC.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.deFechaFAC.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.deFechaFAC.Properties.Mask.EditMask = "yyyy-MM-dd HH:mm:ss";
            this.deFechaFAC.Size = new System.Drawing.Size(187, 20);
            this.deFechaFAC.TabIndex = 12;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(363, 26);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(81, 13);
            this.labelControl10.TabIndex = 15;
            this.labelControl10.Text = "Fecha Prepensa:";
            // 
            // deFechaPP
            // 
            this.deFechaPP.EditValue = null;
            this.deFechaPP.Location = new System.Drawing.Point(476, 23);
            this.deFechaPP.Name = "deFechaPP";
            this.deFechaPP.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.deFechaPP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaPP.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaPP.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.deFechaPP.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.deFechaPP.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.deFechaPP.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.deFechaPP.Properties.Mask.EditMask = "yyyy-MM-dd HH:mm:ss";
            this.deFechaPP.Size = new System.Drawing.Size(187, 20);
            this.deFechaPP.TabIndex = 10;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(363, 48);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(74, 13);
            this.labelControl11.TabIndex = 16;
            this.labelControl11.Text = "Fecha Entrega:";
            // 
            // deFechaENT
            // 
            this.deFechaENT.EditValue = null;
            this.deFechaENT.Location = new System.Drawing.Point(476, 45);
            this.deFechaENT.Name = "deFechaENT";
            this.deFechaENT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.deFechaENT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaENT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaENT.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.deFechaENT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.deFechaENT.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.deFechaENT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.deFechaENT.Properties.Mask.EditMask = "yyyy-MM-dd HH:mm:ss";
            this.deFechaENT.Size = new System.Drawing.Size(187, 20);
            this.deFechaENT.TabIndex = 11;
            // 
            // xtpDatosCLI
            // 
            this.xtpDatosCLI.Controls.Add(this.cli_gcDestinos);
            this.xtpDatosCLI.Controls.Add(this.gcContactos);
            this.xtpDatosCLI.Controls.Add(this.txtNombreCLI);
            this.xtpDatosCLI.Controls.Add(this.beBuscaCLI);
            this.xtpDatosCLI.Controls.Add(this.labelControl1);
            this.xtpDatosCLI.Controls.Add(this.labelControl2);
            this.xtpDatosCLI.Name = "xtpDatosCLI";
            this.xtpDatosCLI.Size = new System.Drawing.Size(802, 226);
            this.xtpDatosCLI.Text = "Cliente";
            // 
            // cli_gcDestinos
            // 
            this.cli_gcDestinos.ContextMenuStrip = this.cmSucursalCLI;
            this.cli_gcDestinos.Location = new System.Drawing.Point(18, 34);
            this.cli_gcDestinos.MainView = this.cli_gvDestino;
            this.cli_gcDestinos.Name = "cli_gcDestinos";
            this.cli_gcDestinos.Size = new System.Drawing.Size(772, 98);
            this.cli_gcDestinos.TabIndex = 18;
            this.cli_gcDestinos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cli_gvDestino});
            // 
            // cmSucursalCLI
            // 
            this.cmSucursalCLI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAgregarDestino,
            this.mnuQuitarDestino});
            this.cmSucursalCLI.Name = "cmSucursalCLI";
            this.cmSucursalCLI.Size = new System.Drawing.Size(228, 48);
            // 
            // mnuAgregarDestino
            // 
            this.mnuAgregarDestino.Name = "mnuAgregarDestino";
            this.mnuAgregarDestino.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuAgregarDestino.Size = new System.Drawing.Size(227, 22);
            this.mnuAgregarDestino.Text = "Agregar Destino";
            this.mnuAgregarDestino.Click += new System.EventHandler(this.mnuAgregarDestino_Click);
            // 
            // mnuQuitarDestino
            // 
            this.mnuQuitarDestino.Name = "mnuQuitarDestino";
            this.mnuQuitarDestino.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.mnuQuitarDestino.Size = new System.Drawing.Size(227, 22);
            this.mnuQuitarDestino.Text = "Quitar Destino";
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
            this.cli_gcColCantidad.Visible = true;
            this.cli_gcColCantidad.VisibleIndex = 3;
            this.cli_gcColCantidad.Width = 156;
            // 
            // gcContactos
            // 
            this.gcContactos.Location = new System.Drawing.Point(18, 138);
            this.gcContactos.MainView = this.gvContactos;
            this.gcContactos.Name = "gcContactos";
            this.gcContactos.Size = new System.Drawing.Size(772, 85);
            this.gcContactos.TabIndex = 17;
            this.gcContactos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvContactos});
            // 
            // gvContactos
            // 
            this.gvContactos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcColContacto,
            this.gcColNumero});
            this.gvContactos.GridControl = this.gcContactos;
            this.gvContactos.Name = "gvContactos";
            this.gvContactos.OptionsView.ShowGroupPanel = false;
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
            // txtNombreCLI
            // 
            this.txtNombreCLI.Location = new System.Drawing.Point(432, 8);
            this.txtNombreCLI.Name = "txtNombreCLI";
            this.txtNombreCLI.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtNombreCLI.Properties.ReadOnly = true;
            this.txtNombreCLI.Size = new System.Drawing.Size(358, 20);
            this.txtNombreCLI.TabIndex = 1;
            // 
            // beBuscaCLI
            // 
            this.beBuscaCLI.Location = new System.Drawing.Point(112, 8);
            this.beBuscaCLI.Name = "beBuscaCLI";
            this.beBuscaCLI.Properties.Appearance.Options.UseTextOptions = true;
            this.beBuscaCLI.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.beBuscaCLI.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.beBuscaCLI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beBuscaCLI.Properties.MaxLength = 8;
            this.beBuscaCLI.Properties.ReadOnly = true;
            this.beBuscaCLI.Size = new System.Drawing.Size(88, 20);
            this.beBuscaCLI.TabIndex = 2;
            this.beBuscaCLI.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beBuscaCLI_ButtonClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Código:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(385, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Nombre:";
            // 
            // xtpBlocks
            // 
            this.xtpBlocks.Controls.Add(this.labelControl41);
            this.xtpBlocks.Controls.Add(this.labelControl40);
            this.xtpBlocks.Controls.Add(this.labelControl39);
            this.xtpBlocks.Controls.Add(this.labelControl38);
            this.xtpBlocks.Controls.Add(this.labelControl37);
            this.xtpBlocks.Controls.Add(this.blo_txtPantones);
            this.xtpBlocks.Controls.Add(this.blo_lueColor);
            this.xtpBlocks.Controls.Add(this.blo_txtTiraje);
            this.xtpBlocks.Controls.Add(this.blo_txtOrdenTroquel);
            this.xtpBlocks.Controls.Add(this.labelControl34);
            this.xtpBlocks.Controls.Add(this.labelControl33);
            this.xtpBlocks.Controls.Add(this.labelControl31);
            this.xtpBlocks.Controls.Add(this.labelControl30);
            this.xtpBlocks.Controls.Add(this.labelControl29);
            this.xtpBlocks.Controls.Add(this.labelControl28);
            this.xtpBlocks.Controls.Add(this.labelControl27);
            this.xtpBlocks.Controls.Add(this.blo_txtAlto);
            this.xtpBlocks.Controls.Add(this.blo_txtAncho);
            this.xtpBlocks.Controls.Add(this.blo_lueTamano);
            this.xtpBlocks.Controls.Add(this.blo_lueTroquel);
            this.xtpBlocks.Controls.Add(this.blo_lueAcabado);
            this.xtpBlocks.Controls.Add(this.blo_txtTermina);
            this.xtpBlocks.Controls.Add(this.blo_txtInicia);
            this.xtpBlocks.Controls.Add(this.blo_txtSerie);
            this.xtpBlocks.Controls.Add(this.blo_lueTipoEmblocado);
            this.xtpBlocks.Controls.Add(this.labelControl26);
            this.xtpBlocks.Controls.Add(this.labelControl25);
            this.xtpBlocks.Controls.Add(this.labelControl24);
            this.xtpBlocks.Controls.Add(this.blo_txtJuegos);
            this.xtpBlocks.Controls.Add(this.blo_lueNumCopias);
            this.xtpBlocks.Name = "xtpBlocks";
            this.xtpBlocks.Size = new System.Drawing.Size(802, 226);
            this.xtpBlocks.Text = "Blocks";
            // 
            // labelControl41
            // 
            this.labelControl41.Location = new System.Drawing.Point(609, 72);
            this.labelControl41.Name = "labelControl41";
            this.labelControl41.Size = new System.Drawing.Size(49, 13);
            this.labelControl41.TabIndex = 33;
            this.labelControl41.Text = "Pantones:";
            // 
            // labelControl40
            // 
            this.labelControl40.Location = new System.Drawing.Point(425, 72);
            this.labelControl40.Name = "labelControl40";
            this.labelControl40.Size = new System.Drawing.Size(29, 13);
            this.labelControl40.TabIndex = 32;
            this.labelControl40.Text = "Color:";
            // 
            // labelControl39
            // 
            this.labelControl39.Location = new System.Drawing.Point(609, 49);
            this.labelControl39.Name = "labelControl39";
            this.labelControl39.Size = new System.Drawing.Size(34, 13);
            this.labelControl39.TabIndex = 31;
            this.labelControl39.Text = "Orden:";
            // 
            // labelControl38
            // 
            this.labelControl38.Location = new System.Drawing.Point(425, 49);
            this.labelControl38.Name = "labelControl38";
            this.labelControl38.Size = new System.Drawing.Size(40, 13);
            this.labelControl38.TabIndex = 30;
            this.labelControl38.Text = "Troquel:";
            // 
            // labelControl37
            // 
            this.labelControl37.Location = new System.Drawing.Point(425, 27);
            this.labelControl37.Name = "labelControl37";
            this.labelControl37.Size = new System.Drawing.Size(31, 13);
            this.labelControl37.TabIndex = 29;
            this.labelControl37.Text = "Tiraje:";
            // 
            // blo_txtPantones
            // 
            this.blo_txtPantones.Location = new System.Drawing.Point(664, 69);
            this.blo_txtPantones.Name = "blo_txtPantones";
            this.blo_txtPantones.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.blo_txtPantones.Size = new System.Drawing.Size(108, 20);
            this.blo_txtPantones.TabIndex = 26;
            // 
            // blo_lueColor
            // 
            this.blo_lueColor.Location = new System.Drawing.Point(491, 69);
            this.blo_lueColor.Name = "blo_lueColor";
            this.blo_lueColor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.blo_lueColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.blo_lueColor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Color")});
            this.blo_lueColor.Properties.DisplayMember = "Descripcion";
            this.blo_lueColor.Properties.NullText = "";
            this.blo_lueColor.Properties.ValueMember = "Codigo";
            this.blo_lueColor.Size = new System.Drawing.Size(108, 20);
            this.blo_lueColor.TabIndex = 25;
            // 
            // blo_txtTiraje
            // 
            this.blo_txtTiraje.Location = new System.Drawing.Point(491, 24);
            this.blo_txtTiraje.Name = "blo_txtTiraje";
            this.blo_txtTiraje.Properties.Appearance.Options.UseTextOptions = true;
            this.blo_txtTiraje.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.blo_txtTiraje.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.blo_txtTiraje.Size = new System.Drawing.Size(108, 20);
            this.blo_txtTiraje.TabIndex = 24;
            // 
            // blo_txtOrdenTroquel
            // 
            this.blo_txtOrdenTroquel.Location = new System.Drawing.Point(664, 46);
            this.blo_txtOrdenTroquel.Name = "blo_txtOrdenTroquel";
            this.blo_txtOrdenTroquel.Properties.Appearance.Options.UseTextOptions = true;
            this.blo_txtOrdenTroquel.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.blo_txtOrdenTroquel.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.blo_txtOrdenTroquel.Size = new System.Drawing.Size(108, 20);
            this.blo_txtOrdenTroquel.TabIndex = 23;
            // 
            // labelControl34
            // 
            this.labelControl34.Location = new System.Drawing.Point(170, 139);
            this.labelControl34.Name = "labelControl34";
            this.labelControl34.Size = new System.Drawing.Size(23, 13);
            this.labelControl34.TabIndex = 20;
            this.labelControl34.Text = "Alto:";
            // 
            // labelControl33
            // 
            this.labelControl33.Location = new System.Drawing.Point(18, 139);
            this.labelControl33.Name = "labelControl33";
            this.labelControl33.Size = new System.Drawing.Size(34, 13);
            this.labelControl33.TabIndex = 19;
            this.labelControl33.Text = "Ancho:";
            // 
            // labelControl31
            // 
            this.labelControl31.Location = new System.Drawing.Point(18, 116);
            this.labelControl31.Name = "labelControl31";
            this.labelControl31.Size = new System.Drawing.Size(42, 13);
            this.labelControl31.TabIndex = 18;
            this.labelControl31.Text = "Tamaño:";
            // 
            // labelControl30
            // 
            this.labelControl30.Location = new System.Drawing.Point(18, 94);
            this.labelControl30.Name = "labelControl30";
            this.labelControl30.Size = new System.Drawing.Size(51, 13);
            this.labelControl30.TabIndex = 17;
            this.labelControl30.Text = "Acabados:";
            // 
            // labelControl29
            // 
            this.labelControl29.Location = new System.Drawing.Point(294, 72);
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Size = new System.Drawing.Size(42, 13);
            this.labelControl29.TabIndex = 16;
            this.labelControl29.Text = "Termina:";
            // 
            // labelControl28
            // 
            this.labelControl28.Location = new System.Drawing.Point(170, 72);
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Size = new System.Drawing.Size(29, 13);
            this.labelControl28.TabIndex = 15;
            this.labelControl28.Text = "Inicia:";
            // 
            // labelControl27
            // 
            this.labelControl27.Location = new System.Drawing.Point(18, 72);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(28, 13);
            this.labelControl27.TabIndex = 14;
            this.labelControl27.Text = "Serie:";
            // 
            // blo_txtAlto
            // 
            this.blo_txtAlto.Location = new System.Drawing.Point(208, 135);
            this.blo_txtAlto.Name = "blo_txtAlto";
            this.blo_txtAlto.Properties.Appearance.Options.UseTextOptions = true;
            this.blo_txtAlto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.blo_txtAlto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.blo_txtAlto.Size = new System.Drawing.Size(72, 20);
            this.blo_txtAlto.TabIndex = 13;
            // 
            // blo_txtAncho
            // 
            this.blo_txtAncho.Location = new System.Drawing.Point(99, 135);
            this.blo_txtAncho.Name = "blo_txtAncho";
            this.blo_txtAncho.Properties.Appearance.Options.UseTextOptions = true;
            this.blo_txtAncho.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.blo_txtAncho.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.blo_txtAncho.Size = new System.Drawing.Size(64, 20);
            this.blo_txtAncho.TabIndex = 12;
            // 
            // blo_lueTamano
            // 
            this.blo_lueTamano.Location = new System.Drawing.Point(99, 113);
            this.blo_lueTamano.Name = "blo_lueTamano";
            this.blo_lueTamano.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.blo_lueTamano.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.blo_lueTamano.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Tamaño")});
            this.blo_lueTamano.Properties.DisplayMember = "Descripcion";
            this.blo_lueTamano.Properties.NullText = "";
            this.blo_lueTamano.Properties.ValueMember = "Codigo";
            this.blo_lueTamano.Size = new System.Drawing.Size(181, 20);
            this.blo_lueTamano.TabIndex = 11;
            // 
            // blo_lueTroquel
            // 
            this.blo_lueTroquel.Location = new System.Drawing.Point(491, 46);
            this.blo_lueTroquel.Name = "blo_lueTroquel";
            this.blo_lueTroquel.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.blo_lueTroquel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.blo_lueTroquel.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Troquel")});
            this.blo_lueTroquel.Properties.DisplayMember = "Descripcion";
            this.blo_lueTroquel.Properties.NullText = "";
            this.blo_lueTroquel.Properties.ValueMember = "Codigo";
            this.blo_lueTroquel.Size = new System.Drawing.Size(108, 20);
            this.blo_lueTroquel.TabIndex = 10;
            // 
            // blo_lueAcabado
            // 
            this.blo_lueAcabado.Location = new System.Drawing.Point(99, 91);
            this.blo_lueAcabado.Name = "blo_lueAcabado";
            this.blo_lueAcabado.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.blo_lueAcabado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.blo_lueAcabado.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Acabados")});
            this.blo_lueAcabado.Properties.DisplayMember = "Descripcion";
            this.blo_lueAcabado.Properties.NullText = "";
            this.blo_lueAcabado.Properties.ValueMember = "Codigo";
            this.blo_lueAcabado.Size = new System.Drawing.Size(304, 20);
            this.blo_lueAcabado.TabIndex = 9;
            // 
            // blo_txtTermina
            // 
            this.blo_txtTermina.Location = new System.Drawing.Point(342, 69);
            this.blo_txtTermina.Name = "blo_txtTermina";
            this.blo_txtTermina.Properties.Appearance.Options.UseTextOptions = true;
            this.blo_txtTermina.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.blo_txtTermina.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.blo_txtTermina.Size = new System.Drawing.Size(61, 20);
            this.blo_txtTermina.TabIndex = 8;
            // 
            // blo_txtInicia
            // 
            this.blo_txtInicia.EditValue = "";
            this.blo_txtInicia.Location = new System.Drawing.Point(208, 69);
            this.blo_txtInicia.Name = "blo_txtInicia";
            this.blo_txtInicia.Properties.Appearance.Options.UseTextOptions = true;
            this.blo_txtInicia.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.blo_txtInicia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.blo_txtInicia.Size = new System.Drawing.Size(61, 20);
            this.blo_txtInicia.TabIndex = 7;
            // 
            // blo_txtSerie
            // 
            this.blo_txtSerie.Location = new System.Drawing.Point(99, 69);
            this.blo_txtSerie.Name = "blo_txtSerie";
            this.blo_txtSerie.Properties.Appearance.Options.UseTextOptions = true;
            this.blo_txtSerie.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.blo_txtSerie.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.blo_txtSerie.Size = new System.Drawing.Size(61, 20);
            this.blo_txtSerie.TabIndex = 6;
            // 
            // blo_lueTipoEmblocado
            // 
            this.blo_lueTipoEmblocado.Location = new System.Drawing.Point(99, 46);
            this.blo_lueTipoEmblocado.Name = "blo_lueTipoEmblocado";
            this.blo_lueTipoEmblocado.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.blo_lueTipoEmblocado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.blo_lueTipoEmblocado.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Emblocado")});
            this.blo_lueTipoEmblocado.Properties.DisplayMember = "Descripcion";
            this.blo_lueTipoEmblocado.Properties.NullText = "";
            this.blo_lueTipoEmblocado.Properties.ValueMember = "Codigo";
            this.blo_lueTipoEmblocado.Size = new System.Drawing.Size(304, 20);
            this.blo_lueTipoEmblocado.TabIndex = 5;
            // 
            // labelControl26
            // 
            this.labelControl26.Location = new System.Drawing.Point(18, 49);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(55, 13);
            this.labelControl26.TabIndex = 4;
            this.labelControl26.Text = "Emblocado:";
            // 
            // labelControl25
            // 
            this.labelControl25.Location = new System.Drawing.Point(294, 27);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(33, 13);
            this.labelControl25.TabIndex = 3;
            this.labelControl25.Text = "Juego:";
            // 
            // labelControl24
            // 
            this.labelControl24.Location = new System.Drawing.Point(18, 27);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(60, 13);
            this.labelControl24.TabIndex = 2;
            this.labelControl24.Text = "Nro. Copias:";
            // 
            // blo_txtJuegos
            // 
            this.blo_txtJuegos.Location = new System.Drawing.Point(342, 24);
            this.blo_txtJuegos.Name = "blo_txtJuegos";
            this.blo_txtJuegos.Properties.Appearance.Options.UseTextOptions = true;
            this.blo_txtJuegos.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.blo_txtJuegos.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.blo_txtJuegos.Size = new System.Drawing.Size(61, 20);
            this.blo_txtJuegos.TabIndex = 1;
            // 
            // blo_lueNumCopias
            // 
            this.blo_lueNumCopias.Location = new System.Drawing.Point(99, 24);
            this.blo_lueNumCopias.Name = "blo_lueNumCopias";
            this.blo_lueNumCopias.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.blo_lueNumCopias.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.blo_lueNumCopias.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Copias")});
            this.blo_lueNumCopias.Properties.DisplayMember = "Descripcion";
            this.blo_lueNumCopias.Properties.NullText = "";
            this.blo_lueNumCopias.Properties.ValueMember = "Codigo";
            this.blo_lueNumCopias.Size = new System.Drawing.Size(128, 20);
            this.blo_lueNumCopias.TabIndex = 0;
            // 
            // xtpLibros
            // 
            this.xtpLibros.Controls.Add(this.labelControl4);
            this.xtpLibros.Controls.Add(this.lib_lueForma);
            this.xtpLibros.Controls.Add(this.xtcLibrosDET);
            this.xtpLibros.Controls.Add(this.labelControl72);
            this.xtpLibros.Controls.Add(this.lib_lueTipoLibro);
            this.xtpLibros.Name = "xtpLibros";
            this.xtpLibros.Size = new System.Drawing.Size(802, 226);
            this.xtpLibros.Text = "Libros";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(490, 9);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 13);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Forma:";
            // 
            // lib_lueForma
            // 
            this.lib_lueForma.Location = new System.Drawing.Point(530, 6);
            this.lib_lueForma.Name = "lib_lueForma";
            this.lib_lueForma.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lib_lueForma.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lib_lueForma.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Tipo trabajo")});
            this.lib_lueForma.Properties.DisplayMember = "Descripcion";
            this.lib_lueForma.Properties.NullText = "";
            this.lib_lueForma.Properties.ValueMember = "Codigo";
            this.lib_lueForma.Size = new System.Drawing.Size(249, 20);
            this.lib_lueForma.TabIndex = 19;
            // 
            // xtcLibrosDET
            // 
            this.xtcLibrosDET.Location = new System.Drawing.Point(6, 31);
            this.xtcLibrosDET.Name = "xtcLibrosDET";
            this.xtcLibrosDET.SelectedTabPage = this.xtpLibroENC;
            this.xtcLibrosDET.Size = new System.Drawing.Size(793, 188);
            this.xtcLibrosDET.TabIndex = 18;
            this.xtcLibrosDET.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpLibroENC,
            this.xtpLibroPOR});
            // 
            // xtpLibroENC
            // 
            this.xtpLibroENC.Controls.Add(this.labelControl57);
            this.xtpLibroENC.Controls.Add(this.labelControl56);
            this.xtpLibroENC.Controls.Add(this.lib_gcColoresENC);
            this.xtpLibroENC.Controls.Add(this.labelControl42);
            this.xtpLibroENC.Controls.Add(this.labelControl80);
            this.xtpLibroENC.Controls.Add(this.lib_txtAltoENC);
            this.xtpLibroENC.Controls.Add(this.lib_txtAnchoENC);
            this.xtpLibroENC.Controls.Add(this.lib_TipoTrabajoENC);
            this.xtpLibroENC.Controls.Add(this.lib_lueTamanoENC);
            this.xtpLibroENC.Controls.Add(this.lib_txtNumPaginasENC);
            this.xtpLibroENC.Controls.Add(this.labelControl47);
            this.xtpLibroENC.Name = "xtpLibroENC";
            this.xtpLibroENC.Size = new System.Drawing.Size(787, 160);
            this.xtpLibroENC.Text = "Encuadernado";
            // 
            // labelControl57
            // 
            this.labelControl57.Location = new System.Drawing.Point(13, 44);
            this.labelControl57.Name = "labelControl57";
            this.labelControl57.Size = new System.Drawing.Size(42, 13);
            this.labelControl57.TabIndex = 29;
            this.labelControl57.Text = "Tamaño:";
            // 
            // labelControl56
            // 
            this.labelControl56.Location = new System.Drawing.Point(13, 22);
            this.labelControl56.Name = "labelControl56";
            this.labelControl56.Size = new System.Drawing.Size(64, 13);
            this.labelControl56.TabIndex = 28;
            this.labelControl56.Text = "Tipo Trabajo:";
            // 
            // lib_gcColoresENC
            // 
            this.lib_gcColoresENC.Location = new System.Drawing.Point(364, 19);
            this.lib_gcColoresENC.MainView = this.lib_gvColoresENC;
            this.lib_gcColoresENC.Name = "lib_gcColoresENC";
            this.lib_gcColoresENC.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rilue_gridColorENC});
            this.lib_gcColoresENC.Size = new System.Drawing.Size(408, 110);
            this.lib_gcColoresENC.TabIndex = 27;
            this.lib_gcColoresENC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.lib_gvColoresENC});
            // 
            // lib_gvColoresENC
            // 
            this.lib_gvColoresENC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.lib_gcColColorENC,
            this.lib_gcColPaginasENC});
            this.lib_gvColoresENC.GridControl = this.lib_gcColoresENC;
            this.lib_gvColoresENC.Name = "lib_gvColoresENC";
            this.lib_gvColoresENC.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.lib_gvColoresENC.OptionsView.ShowGroupPanel = false;
            // 
            // lib_gcColColorENC
            // 
            this.lib_gcColColorENC.Caption = "Color";
            this.lib_gcColColorENC.ColumnEdit = this.rilue_gridColorENC;
            this.lib_gcColColorENC.FieldName = "Codigo";
            this.lib_gcColColorENC.Name = "lib_gcColColorENC";
            this.lib_gcColColorENC.Visible = true;
            this.lib_gcColColorENC.VisibleIndex = 0;
            this.lib_gcColColorENC.Width = 94;
            // 
            // rilue_gridColorENC
            // 
            this.rilue_gridColorENC.AutoHeight = false;
            this.rilue_gridColorENC.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilue_gridColorENC.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Color")});
            this.rilue_gridColorENC.DisplayMember = "Descripcion";
            this.rilue_gridColorENC.Name = "rilue_gridColorENC";
            this.rilue_gridColorENC.NullText = "";
            this.rilue_gridColorENC.ValueMember = "Codigo";
            // 
            // lib_gcColPaginasENC
            // 
            this.lib_gcColPaginasENC.Caption = "Páginas";
            this.lib_gcColPaginasENC.FieldName = "Paginas";
            this.lib_gcColPaginasENC.Name = "lib_gcColPaginasENC";
            this.lib_gcColPaginasENC.Visible = true;
            this.lib_gcColPaginasENC.VisibleIndex = 1;
            this.lib_gcColPaginasENC.Width = 248;
            // 
            // labelControl42
            // 
            this.labelControl42.Location = new System.Drawing.Point(207, 67);
            this.labelControl42.Name = "labelControl42";
            this.labelControl42.Size = new System.Drawing.Size(23, 13);
            this.labelControl42.TabIndex = 24;
            this.labelControl42.Text = "Alto:";
            // 
            // labelControl80
            // 
            this.labelControl80.Location = new System.Drawing.Point(13, 67);
            this.labelControl80.Name = "labelControl80";
            this.labelControl80.Size = new System.Drawing.Size(34, 13);
            this.labelControl80.TabIndex = 23;
            this.labelControl80.Text = "Ancho:";
            // 
            // lib_txtAltoENC
            // 
            this.lib_txtAltoENC.Location = new System.Drawing.Point(266, 64);
            this.lib_txtAltoENC.Name = "lib_txtAltoENC";
            this.lib_txtAltoENC.Properties.Appearance.Options.UseTextOptions = true;
            this.lib_txtAltoENC.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lib_txtAltoENC.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lib_txtAltoENC.Size = new System.Drawing.Size(72, 20);
            this.lib_txtAltoENC.TabIndex = 22;
            // 
            // lib_txtAnchoENC
            // 
            this.lib_txtAnchoENC.Location = new System.Drawing.Point(96, 64);
            this.lib_txtAnchoENC.Name = "lib_txtAnchoENC";
            this.lib_txtAnchoENC.Properties.Appearance.Options.UseTextOptions = true;
            this.lib_txtAnchoENC.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lib_txtAnchoENC.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lib_txtAnchoENC.Size = new System.Drawing.Size(64, 20);
            this.lib_txtAnchoENC.TabIndex = 21;
            // 
            // lib_TipoTrabajoENC
            // 
            this.lib_TipoTrabajoENC.Location = new System.Drawing.Point(96, 19);
            this.lib_TipoTrabajoENC.Name = "lib_TipoTrabajoENC";
            this.lib_TipoTrabajoENC.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lib_TipoTrabajoENC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lib_TipoTrabajoENC.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Encuadernado")});
            this.lib_TipoTrabajoENC.Properties.DisplayMember = "Descripcion";
            this.lib_TipoTrabajoENC.Properties.NullText = "";
            this.lib_TipoTrabajoENC.Properties.ValueMember = "Codigo";
            this.lib_TipoTrabajoENC.Size = new System.Drawing.Size(242, 20);
            this.lib_TipoTrabajoENC.TabIndex = 2;
            // 
            // lib_lueTamanoENC
            // 
            this.lib_lueTamanoENC.Location = new System.Drawing.Point(96, 41);
            this.lib_lueTamanoENC.Name = "lib_lueTamanoENC";
            this.lib_lueTamanoENC.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lib_lueTamanoENC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lib_lueTamanoENC.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Tamaño")});
            this.lib_lueTamanoENC.Properties.DisplayMember = "Descripcion";
            this.lib_lueTamanoENC.Properties.NullText = "";
            this.lib_lueTamanoENC.Properties.ValueMember = "Codigo";
            this.lib_lueTamanoENC.Size = new System.Drawing.Size(242, 20);
            this.lib_lueTamanoENC.TabIndex = 1;
            // 
            // lib_txtNumPaginasENC
            // 
            this.lib_txtNumPaginasENC.Location = new System.Drawing.Point(96, 89);
            this.lib_txtNumPaginasENC.Name = "lib_txtNumPaginasENC";
            this.lib_txtNumPaginasENC.Properties.Appearance.Options.UseTextOptions = true;
            this.lib_txtNumPaginasENC.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lib_txtNumPaginasENC.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lib_txtNumPaginasENC.Properties.MaxLength = 10;
            this.lib_txtNumPaginasENC.Size = new System.Drawing.Size(63, 20);
            this.lib_txtNumPaginasENC.TabIndex = 3;
            // 
            // labelControl47
            // 
            this.labelControl47.Location = new System.Drawing.Point(13, 92);
            this.labelControl47.Name = "labelControl47";
            this.labelControl47.Size = new System.Drawing.Size(65, 13);
            this.labelControl47.TabIndex = 17;
            this.labelControl47.Text = "Nro. Páginas:";
            // 
            // xtpLibroPOR
            // 
            this.xtpLibroPOR.Controls.Add(this.lib_txtColorPantonePOR);
            this.xtpLibroPOR.Controls.Add(this.labelControl55);
            this.xtpLibroPOR.Controls.Add(this.lib_beMaterialCubiertaPOR);
            this.xtpLibroPOR.Controls.Add(this.lib_beMaterialGuardaPOR);
            this.xtpLibroPOR.Controls.Add(this.labelControl54);
            this.xtpLibroPOR.Controls.Add(this.labelControl53);
            this.xtpLibroPOR.Controls.Add(this.labelControl51);
            this.xtpLibroPOR.Controls.Add(this.labelControl50);
            this.xtpLibroPOR.Controls.Add(this.labelControl49);
            this.xtpLibroPOR.Controls.Add(this.lib_lueRetiroCubiertaPOR);
            this.xtpLibroPOR.Controls.Add(this.lib_lueRetiroGuardaPOR);
            this.xtpLibroPOR.Controls.Add(this.lib_lueRetiroColorPOR);
            this.xtpLibroPOR.Controls.Add(this.lib_lueTiroCubiertaPOR);
            this.xtpLibroPOR.Controls.Add(this.lib_lueTiroGuardaPOR);
            this.xtpLibroPOR.Controls.Add(this.lib_lueTiroColorPOR);
            this.xtpLibroPOR.Controls.Add(this.labelControl46);
            this.xtpLibroPOR.Controls.Add(this.lib_txtOrdenPOR);
            this.xtpLibroPOR.Controls.Add(this.lib_lueTroquelPOR);
            this.xtpLibroPOR.Controls.Add(this.labelControl52);
            this.xtpLibroPOR.Controls.Add(this.labelControl44);
            this.xtpLibroPOR.Controls.Add(this.labelControl45);
            this.xtpLibroPOR.Controls.Add(this.lib_txtAltoPOR);
            this.xtpLibroPOR.Controls.Add(this.lib_txtAnchoPOR);
            this.xtpLibroPOR.Controls.Add(this.labelControl63);
            this.xtpLibroPOR.Controls.Add(this.lib_lueTamanoPOR);
            this.xtpLibroPOR.Name = "xtpLibroPOR";
            this.xtpLibroPOR.Size = new System.Drawing.Size(787, 160);
            this.xtpLibroPOR.Text = "Portada";
            // 
            // lib_txtColorPantonePOR
            // 
            this.lib_txtColorPantonePOR.EditValue = "";
            this.lib_txtColorPantonePOR.Location = new System.Drawing.Point(274, 73);
            this.lib_txtColorPantonePOR.Name = "lib_txtColorPantonePOR";
            this.lib_txtColorPantonePOR.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lib_txtColorPantonePOR.Size = new System.Drawing.Size(255, 20);
            this.lib_txtColorPantonePOR.TabIndex = 91;
            // 
            // labelControl55
            // 
            this.labelControl55.Location = new System.Drawing.Point(383, 57);
            this.labelControl55.Name = "labelControl55";
            this.labelControl55.Size = new System.Drawing.Size(82, 13);
            this.labelControl55.TabIndex = 90;
            this.labelControl55.Text = "Material/Pantone";
            // 
            // lib_beMaterialCubiertaPOR
            // 
            this.lib_beMaterialCubiertaPOR.Location = new System.Drawing.Point(274, 118);
            this.lib_beMaterialCubiertaPOR.Name = "lib_beMaterialCubiertaPOR";
            this.lib_beMaterialCubiertaPOR.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lib_beMaterialCubiertaPOR.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.lib_beMaterialCubiertaPOR.Size = new System.Drawing.Size(255, 20);
            this.lib_beMaterialCubiertaPOR.TabIndex = 89;
            this.lib_beMaterialCubiertaPOR.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.lib_beMaterialCubiertaPOR_ButtonClick);
            // 
            // lib_beMaterialGuardaPOR
            // 
            this.lib_beMaterialGuardaPOR.EditValue = "";
            this.lib_beMaterialGuardaPOR.Location = new System.Drawing.Point(274, 95);
            this.lib_beMaterialGuardaPOR.Name = "lib_beMaterialGuardaPOR";
            this.lib_beMaterialGuardaPOR.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lib_beMaterialGuardaPOR.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.lib_beMaterialGuardaPOR.Size = new System.Drawing.Size(255, 20);
            this.lib_beMaterialGuardaPOR.TabIndex = 88;
            this.lib_beMaterialGuardaPOR.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.lib_beMaterialGuardaPOR_ButtonClick);
            // 
            // labelControl54
            // 
            this.labelControl54.Location = new System.Drawing.Point(234, 57);
            this.labelControl54.Name = "labelControl54";
            this.labelControl54.Size = new System.Drawing.Size(29, 13);
            this.labelControl54.TabIndex = 86;
            this.labelControl54.Text = "Retiro";
            // 
            // labelControl53
            // 
            this.labelControl53.Location = new System.Drawing.Point(137, 57);
            this.labelControl53.Name = "labelControl53";
            this.labelControl53.Size = new System.Drawing.Size(18, 13);
            this.labelControl53.TabIndex = 85;
            this.labelControl53.Text = "Tiro";
            // 
            // labelControl51
            // 
            this.labelControl51.Location = new System.Drawing.Point(8, 121);
            this.labelControl51.Name = "labelControl51";
            this.labelControl51.Size = new System.Drawing.Size(45, 13);
            this.labelControl51.TabIndex = 84;
            this.labelControl51.Text = "Cubierta:";
            // 
            // labelControl50
            // 
            this.labelControl50.Location = new System.Drawing.Point(8, 98);
            this.labelControl50.Name = "labelControl50";
            this.labelControl50.Size = new System.Drawing.Size(39, 13);
            this.labelControl50.TabIndex = 83;
            this.labelControl50.Text = "Guarda:";
            // 
            // labelControl49
            // 
            this.labelControl49.Location = new System.Drawing.Point(8, 76);
            this.labelControl49.Name = "labelControl49";
            this.labelControl49.Size = new System.Drawing.Size(29, 13);
            this.labelControl49.TabIndex = 82;
            this.labelControl49.Text = "Color:";
            // 
            // lib_lueRetiroCubiertaPOR
            // 
            this.lib_lueRetiroCubiertaPOR.Location = new System.Drawing.Point(168, 118);
            this.lib_lueRetiroCubiertaPOR.Name = "lib_lueRetiroCubiertaPOR";
            this.lib_lueRetiroCubiertaPOR.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lib_lueRetiroCubiertaPOR.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lib_lueRetiroCubiertaPOR.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Color")});
            this.lib_lueRetiroCubiertaPOR.Properties.NullText = "";
            this.lib_lueRetiroCubiertaPOR.Size = new System.Drawing.Size(100, 20);
            this.lib_lueRetiroCubiertaPOR.TabIndex = 81;
            // 
            // lib_lueRetiroGuardaPOR
            // 
            this.lib_lueRetiroGuardaPOR.Location = new System.Drawing.Point(168, 95);
            this.lib_lueRetiroGuardaPOR.Name = "lib_lueRetiroGuardaPOR";
            this.lib_lueRetiroGuardaPOR.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lib_lueRetiroGuardaPOR.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lib_lueRetiroGuardaPOR.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Color")});
            this.lib_lueRetiroGuardaPOR.Properties.NullText = "";
            this.lib_lueRetiroGuardaPOR.Size = new System.Drawing.Size(100, 20);
            this.lib_lueRetiroGuardaPOR.TabIndex = 80;
            // 
            // lib_lueRetiroColorPOR
            // 
            this.lib_lueRetiroColorPOR.Location = new System.Drawing.Point(168, 73);
            this.lib_lueRetiroColorPOR.Name = "lib_lueRetiroColorPOR";
            this.lib_lueRetiroColorPOR.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lib_lueRetiroColorPOR.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lib_lueRetiroColorPOR.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Color")});
            this.lib_lueRetiroColorPOR.Properties.NullText = "";
            this.lib_lueRetiroColorPOR.Size = new System.Drawing.Size(100, 20);
            this.lib_lueRetiroColorPOR.TabIndex = 79;
            // 
            // lib_lueTiroCubiertaPOR
            // 
            this.lib_lueTiroCubiertaPOR.Location = new System.Drawing.Point(59, 118);
            this.lib_lueTiroCubiertaPOR.Name = "lib_lueTiroCubiertaPOR";
            this.lib_lueTiroCubiertaPOR.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lib_lueTiroCubiertaPOR.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lib_lueTiroCubiertaPOR.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Color")});
            this.lib_lueTiroCubiertaPOR.Properties.NullText = "";
            this.lib_lueTiroCubiertaPOR.Size = new System.Drawing.Size(100, 20);
            this.lib_lueTiroCubiertaPOR.TabIndex = 78;
            // 
            // lib_lueTiroGuardaPOR
            // 
            this.lib_lueTiroGuardaPOR.Location = new System.Drawing.Point(59, 95);
            this.lib_lueTiroGuardaPOR.Name = "lib_lueTiroGuardaPOR";
            this.lib_lueTiroGuardaPOR.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lib_lueTiroGuardaPOR.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lib_lueTiroGuardaPOR.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Color")});
            this.lib_lueTiroGuardaPOR.Properties.NullText = "";
            this.lib_lueTiroGuardaPOR.Size = new System.Drawing.Size(100, 20);
            this.lib_lueTiroGuardaPOR.TabIndex = 77;
            // 
            // lib_lueTiroColorPOR
            // 
            this.lib_lueTiroColorPOR.Location = new System.Drawing.Point(59, 73);
            this.lib_lueTiroColorPOR.Name = "lib_lueTiroColorPOR";
            this.lib_lueTiroColorPOR.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lib_lueTiroColorPOR.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lib_lueTiroColorPOR.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Color")});
            this.lib_lueTiroColorPOR.Properties.NullText = "";
            this.lib_lueTiroColorPOR.Size = new System.Drawing.Size(100, 20);
            this.lib_lueTiroColorPOR.TabIndex = 76;
            // 
            // labelControl46
            // 
            this.labelControl46.Location = new System.Drawing.Point(620, 29);
            this.labelControl46.Name = "labelControl46";
            this.labelControl46.Size = new System.Drawing.Size(34, 13);
            this.labelControl46.TabIndex = 75;
            this.labelControl46.Text = "Orden:";
            // 
            // lib_txtOrdenPOR
            // 
            this.lib_txtOrdenPOR.Location = new System.Drawing.Point(685, 26);
            this.lib_txtOrdenPOR.Name = "lib_txtOrdenPOR";
            this.lib_txtOrdenPOR.Properties.Appearance.Options.UseTextOptions = true;
            this.lib_txtOrdenPOR.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lib_txtOrdenPOR.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lib_txtOrdenPOR.Size = new System.Drawing.Size(89, 20);
            this.lib_txtOrdenPOR.TabIndex = 74;
            // 
            // lib_lueTroquelPOR
            // 
            this.lib_lueTroquelPOR.Location = new System.Drawing.Point(685, 3);
            this.lib_lueTroquelPOR.Name = "lib_lueTroquelPOR";
            this.lib_lueTroquelPOR.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lib_lueTroquelPOR.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lib_lueTroquelPOR.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Troquel")});
            this.lib_lueTroquelPOR.Properties.DisplayMember = "Descripcion";
            this.lib_lueTroquelPOR.Properties.NullText = "";
            this.lib_lueTroquelPOR.Properties.ValueMember = "Codigo";
            this.lib_lueTroquelPOR.Size = new System.Drawing.Size(89, 20);
            this.lib_lueTroquelPOR.TabIndex = 72;
            // 
            // labelControl52
            // 
            this.labelControl52.Location = new System.Drawing.Point(620, 6);
            this.labelControl52.Name = "labelControl52";
            this.labelControl52.Size = new System.Drawing.Size(40, 13);
            this.labelControl52.TabIndex = 73;
            this.labelControl52.Text = "Troquel:";
            // 
            // labelControl44
            // 
            this.labelControl44.Location = new System.Drawing.Point(166, 29);
            this.labelControl44.Name = "labelControl44";
            this.labelControl44.Size = new System.Drawing.Size(23, 13);
            this.labelControl44.TabIndex = 67;
            this.labelControl44.Text = "Alto:";
            // 
            // labelControl45
            // 
            this.labelControl45.Location = new System.Drawing.Point(8, 29);
            this.labelControl45.Name = "labelControl45";
            this.labelControl45.Size = new System.Drawing.Size(34, 13);
            this.labelControl45.TabIndex = 66;
            this.labelControl45.Text = "Ancho:";
            // 
            // lib_txtAltoPOR
            // 
            this.lib_txtAltoPOR.Location = new System.Drawing.Point(195, 26);
            this.lib_txtAltoPOR.Name = "lib_txtAltoPOR";
            this.lib_txtAltoPOR.Properties.Appearance.Options.UseTextOptions = true;
            this.lib_txtAltoPOR.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lib_txtAltoPOR.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lib_txtAltoPOR.Size = new System.Drawing.Size(72, 20);
            this.lib_txtAltoPOR.TabIndex = 65;
            // 
            // lib_txtAnchoPOR
            // 
            this.lib_txtAnchoPOR.Location = new System.Drawing.Point(66, 26);
            this.lib_txtAnchoPOR.Name = "lib_txtAnchoPOR";
            this.lib_txtAnchoPOR.Properties.Appearance.Options.UseTextOptions = true;
            this.lib_txtAnchoPOR.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lib_txtAnchoPOR.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lib_txtAnchoPOR.Size = new System.Drawing.Size(64, 20);
            this.lib_txtAnchoPOR.TabIndex = 64;
            // 
            // labelControl63
            // 
            this.labelControl63.Location = new System.Drawing.Point(8, 6);
            this.labelControl63.Name = "labelControl63";
            this.labelControl63.Size = new System.Drawing.Size(42, 13);
            this.labelControl63.TabIndex = 63;
            this.labelControl63.Text = "Tamaño:";
            // 
            // lib_lueTamanoPOR
            // 
            this.lib_lueTamanoPOR.Location = new System.Drawing.Point(66, 3);
            this.lib_lueTamanoPOR.Name = "lib_lueTamanoPOR";
            this.lib_lueTamanoPOR.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lib_lueTamanoPOR.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lib_lueTamanoPOR.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Tamaño")});
            this.lib_lueTamanoPOR.Properties.DisplayMember = "Descripcion";
            this.lib_lueTamanoPOR.Properties.NullText = "";
            this.lib_lueTamanoPOR.Properties.ValueMember = "Codigo";
            this.lib_lueTamanoPOR.Size = new System.Drawing.Size(202, 20);
            this.lib_lueTamanoPOR.TabIndex = 11;
            // 
            // labelControl72
            // 
            this.labelControl72.Location = new System.Drawing.Point(6, 9);
            this.labelControl72.Name = "labelControl72";
            this.labelControl72.Size = new System.Drawing.Size(62, 13);
            this.labelControl72.TabIndex = 17;
            this.labelControl72.Text = "Tipo de libro:";
            // 
            // lib_lueTipoLibro
            // 
            this.lib_lueTipoLibro.Location = new System.Drawing.Point(96, 6);
            this.lib_lueTipoLibro.Name = "lib_lueTipoLibro";
            this.lib_lueTipoLibro.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lib_lueTipoLibro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lib_lueTipoLibro.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Tipo trabajo")});
            this.lib_lueTipoLibro.Properties.DisplayMember = "Descripcion";
            this.lib_lueTipoLibro.Properties.NullText = "";
            this.lib_lueTipoLibro.Properties.ValueMember = "Codigo";
            this.lib_lueTipoLibro.Size = new System.Drawing.Size(249, 20);
            this.lib_lueTipoLibro.TabIndex = 16;
            // 
            // xtpMateriales
            // 
            this.xtpMateriales.Controls.Add(this.em_gcDetalleEGR);
            this.xtpMateriales.Name = "xtpMateriales";
            this.xtpMateriales.Size = new System.Drawing.Size(802, 226);
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
            this.em_ribeBuscaMAT.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.dis_ribeBuscaMAT_ButtonClick);
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
            // xtpDiseno
            // 
            this.xtpDiseno.Controls.Add(this.xtcDiseno);
            this.xtpDiseno.Name = "xtpDiseno";
            this.xtpDiseno.Size = new System.Drawing.Size(802, 226);
            this.xtpDiseno.Text = "Diseño";
            // 
            // xtcDiseno
            // 
            this.xtcDiseno.Location = new System.Drawing.Point(9, 3);
            this.xtcDiseno.Name = "xtcDiseno";
            this.xtcDiseno.SelectedTabPage = this.dis_xtpGeneral;
            this.xtcDiseno.Size = new System.Drawing.Size(787, 220);
            this.xtcDiseno.TabIndex = 31;
            this.xtcDiseno.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.dis_xtpGeneral,
            this.dis_xtpArmados,
            this.dis_xtpMaterialCLI});
            // 
            // dis_xtpGeneral
            // 
            this.dis_xtpGeneral.Controls.Add(this.labelControl86);
            this.dis_xtpGeneral.Controls.Add(this.dis_btnActualiza);
            this.dis_xtpGeneral.Controls.Add(this.gbCTP);
            this.dis_xtpGeneral.Controls.Add(this.dis_txtDisenador);
            this.dis_xtpGeneral.Controls.Add(this.gbOrginales);
            this.dis_xtpGeneral.Controls.Add(this.dis_btnTerminar);
            this.dis_xtpGeneral.Controls.Add(this.gbGraficas);
            this.dis_xtpGeneral.Controls.Add(this.dis_btnIniciar);
            this.dis_xtpGeneral.Controls.Add(this.dis_deFechaINI);
            this.dis_xtpGeneral.Controls.Add(this.dis_deFechaFIN);
            this.dis_xtpGeneral.Controls.Add(this.labelControl84);
            this.dis_xtpGeneral.Controls.Add(this.labelControl85);
            this.dis_xtpGeneral.Name = "dis_xtpGeneral";
            this.dis_xtpGeneral.Size = new System.Drawing.Size(781, 192);
            this.dis_xtpGeneral.Text = "General";
            // 
            // labelControl86
            // 
            this.labelControl86.Location = new System.Drawing.Point(12, 10);
            this.labelControl86.Name = "labelControl86";
            this.labelControl86.Size = new System.Drawing.Size(52, 13);
            this.labelControl86.TabIndex = 23;
            this.labelControl86.Text = "Diseñador:";
            // 
            // dis_btnActualiza
            // 
            this.dis_btnActualiza.Location = new System.Drawing.Point(663, 3);
            this.dis_btnActualiza.Name = "dis_btnActualiza";
            this.dis_btnActualiza.Size = new System.Drawing.Size(115, 52);
            this.dis_btnActualiza.TabIndex = 24;
            this.dis_btnActualiza.Text = "ACTUALIZAR";
            // 
            // gbCTP
            // 
            this.gbCTP.Controls.Add(this.dis_chklCTP);
            this.gbCTP.Location = new System.Drawing.Point(538, 63);
            this.gbCTP.Name = "gbCTP";
            this.gbCTP.Size = new System.Drawing.Size(200, 126);
            this.gbCTP.TabIndex = 30;
            this.gbCTP.Text = "Entrega con";
            // 
            // dis_chklCTP
            // 
            this.dis_chklCTP.DisplayMember = "Descripcion";
            this.dis_chklCTP.Location = new System.Drawing.Point(9, 23);
            this.dis_chklCTP.MultiColumn = true;
            this.dis_chklCTP.Name = "dis_chklCTP";
            this.dis_chklCTP.Size = new System.Drawing.Size(180, 93);
            this.dis_chklCTP.TabIndex = 27;
            this.dis_chklCTP.ValueMember = "Codigo";
            // 
            // dis_txtDisenador
            // 
            this.dis_txtDisenador.Location = new System.Drawing.Point(89, 7);
            this.dis_txtDisenador.Name = "dis_txtDisenador";
            this.dis_txtDisenador.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dis_txtDisenador.Properties.ReadOnly = true;
            this.dis_txtDisenador.Size = new System.Drawing.Size(452, 20);
            this.dis_txtDisenador.TabIndex = 15;
            // 
            // gbOrginales
            // 
            this.gbOrginales.Controls.Add(this.dis_chklOriginales);
            this.gbOrginales.Location = new System.Drawing.Point(294, 63);
            this.gbOrginales.Name = "gbOrginales";
            this.gbOrginales.Size = new System.Drawing.Size(200, 126);
            this.gbOrginales.TabIndex = 28;
            this.gbOrginales.Text = "Originales";
            // 
            // dis_chklOriginales
            // 
            this.dis_chklOriginales.DisplayMember = "Descripcion";
            this.dis_chklOriginales.Location = new System.Drawing.Point(5, 23);
            this.dis_chklOriginales.MultiColumn = true;
            this.dis_chklOriginales.Name = "dis_chklOriginales";
            this.dis_chklOriginales.Size = new System.Drawing.Size(180, 93);
            this.dis_chklOriginales.TabIndex = 25;
            this.dis_chklOriginales.ValueMember = "Codigo";
            // 
            // dis_btnTerminar
            // 
            this.dis_btnTerminar.Location = new System.Drawing.Point(555, 32);
            this.dis_btnTerminar.Name = "dis_btnTerminar";
            this.dis_btnTerminar.Size = new System.Drawing.Size(98, 23);
            this.dis_btnTerminar.TabIndex = 20;
            this.dis_btnTerminar.Text = "TERMINAR";
            // 
            // gbGraficas
            // 
            this.gbGraficas.Controls.Add(this.dis_chklGraficasH);
            this.gbGraficas.Location = new System.Drawing.Point(50, 63);
            this.gbGraficas.Name = "gbGraficas";
            this.gbGraficas.Size = new System.Drawing.Size(200, 126);
            this.gbGraficas.TabIndex = 29;
            this.gbGraficas.Text = "Gráficas Hernández";
            // 
            // dis_chklGraficasH
            // 
            this.dis_chklGraficasH.DisplayMember = "Descripcion";
            this.dis_chklGraficasH.Location = new System.Drawing.Point(5, 23);
            this.dis_chklGraficasH.MultiColumn = true;
            this.dis_chklGraficasH.Name = "dis_chklGraficasH";
            this.dis_chklGraficasH.Size = new System.Drawing.Size(180, 93);
            this.dis_chklGraficasH.TabIndex = 26;
            this.dis_chklGraficasH.ValueMember = "Codigo";
            // 
            // dis_btnIniciar
            // 
            this.dis_btnIniciar.Location = new System.Drawing.Point(555, 5);
            this.dis_btnIniciar.Name = "dis_btnIniciar";
            this.dis_btnIniciar.Size = new System.Drawing.Size(98, 23);
            this.dis_btnIniciar.TabIndex = 19;
            this.dis_btnIniciar.Text = "INICIAR";
            // 
            // dis_deFechaINI
            // 
            this.dis_deFechaINI.EditValue = null;
            this.dis_deFechaINI.Location = new System.Drawing.Point(89, 29);
            this.dis_deFechaINI.Name = "dis_deFechaINI";
            this.dis_deFechaINI.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dis_deFechaINI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dis_deFechaINI.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dis_deFechaINI.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dis_deFechaINI.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dis_deFechaINI.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dis_deFechaINI.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dis_deFechaINI.Properties.Mask.EditMask = "yyyy-MM-dd HH:mm:ss";
            this.dis_deFechaINI.Properties.ReadOnly = true;
            this.dis_deFechaINI.Size = new System.Drawing.Size(176, 20);
            this.dis_deFechaINI.TabIndex = 13;
            // 
            // dis_deFechaFIN
            // 
            this.dis_deFechaFIN.EditValue = null;
            this.dis_deFechaFIN.Location = new System.Drawing.Point(365, 29);
            this.dis_deFechaFIN.Name = "dis_deFechaFIN";
            this.dis_deFechaFIN.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dis_deFechaFIN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dis_deFechaFIN.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dis_deFechaFIN.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dis_deFechaFIN.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dis_deFechaFIN.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dis_deFechaFIN.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dis_deFechaFIN.Properties.Mask.EditMask = "yyyy-MM-dd HH:mm:ss";
            this.dis_deFechaFIN.Properties.ReadOnly = true;
            this.dis_deFechaFIN.Size = new System.Drawing.Size(176, 20);
            this.dis_deFechaFIN.TabIndex = 14;
            // 
            // labelControl84
            // 
            this.labelControl84.Location = new System.Drawing.Point(12, 32);
            this.labelControl84.Name = "labelControl84";
            this.labelControl84.Size = new System.Drawing.Size(61, 13);
            this.labelControl84.TabIndex = 21;
            this.labelControl84.Text = "Fecha Inicia:";
            // 
            // labelControl85
            // 
            this.labelControl85.Location = new System.Drawing.Point(285, 32);
            this.labelControl85.Name = "labelControl85";
            this.labelControl85.Size = new System.Drawing.Size(74, 13);
            this.labelControl85.TabIndex = 22;
            this.labelControl85.Text = "Fecha Termina:";
            // 
            // dis_xtpArmados
            // 
            this.dis_xtpArmados.Controls.Add(this.dis_gcArmados);
            this.dis_xtpArmados.Name = "dis_xtpArmados";
            this.dis_xtpArmados.Size = new System.Drawing.Size(781, 192);
            this.dis_xtpArmados.Text = "Armados";
            // 
            // dis_gcArmados
            // 
            this.dis_gcArmados.Location = new System.Drawing.Point(3, 5);
            this.dis_gcArmados.MainView = this.dis_gvArmados;
            this.dis_gcArmados.Name = "dis_gcArmados";
            this.dis_gcArmados.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dis_rilueSeccionARM});
            this.dis_gcArmados.Size = new System.Drawing.Size(775, 184);
            this.dis_gcArmados.TabIndex = 0;
            this.dis_gcArmados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dis_gvArmados});
            // 
            // dis_gvArmados
            // 
            this.dis_gvArmados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.dis_gcColTrabajo,
            this.dis_gcColTamano,
            this.dis_gcColAncho,
            this.dis_gcColAlto,
            this.dis_gcColMaquina});
            this.dis_gvArmados.GridControl = this.dis_gcArmados;
            this.dis_gvArmados.Name = "dis_gvArmados";
            this.dis_gvArmados.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.dis_gvArmados.OptionsView.ShowGroupPanel = false;
            // 
            // dis_gcColTrabajo
            // 
            this.dis_gcColTrabajo.Caption = "Trabajo";
            this.dis_gcColTrabajo.ColumnEdit = this.dis_rilueSeccionARM;
            this.dis_gcColTrabajo.FieldName = "CmbSeccion";
            this.dis_gcColTrabajo.Name = "dis_gcColTrabajo";
            this.dis_gcColTrabajo.Visible = true;
            this.dis_gcColTrabajo.VisibleIndex = 0;
            // 
            // dis_rilueSeccionARM
            // 
            this.dis_rilueSeccionARM.AutoHeight = false;
            this.dis_rilueSeccionARM.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dis_rilueSeccionARM.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Sección")});
            this.dis_rilueSeccionARM.DisplayMember = "Descripcion";
            this.dis_rilueSeccionARM.Name = "dis_rilueSeccionARM";
            this.dis_rilueSeccionARM.NullText = "";
            this.dis_rilueSeccionARM.ValueMember = "Codigo";
            // 
            // dis_gcColTamano
            // 
            this.dis_gcColTamano.Caption = "Tamaño";
            this.dis_gcColTamano.FieldName = "Tamano";
            this.dis_gcColTamano.Name = "dis_gcColTamano";
            this.dis_gcColTamano.Visible = true;
            this.dis_gcColTamano.VisibleIndex = 1;
            // 
            // dis_gcColAncho
            // 
            this.dis_gcColAncho.Caption = "Ancho";
            this.dis_gcColAncho.FieldName = "Ancho";
            this.dis_gcColAncho.Name = "dis_gcColAncho";
            this.dis_gcColAncho.Visible = true;
            this.dis_gcColAncho.VisibleIndex = 2;
            // 
            // dis_gcColAlto
            // 
            this.dis_gcColAlto.Caption = "Alto";
            this.dis_gcColAlto.FieldName = "Alto";
            this.dis_gcColAlto.Name = "dis_gcColAlto";
            this.dis_gcColAlto.Visible = true;
            this.dis_gcColAlto.VisibleIndex = 3;
            // 
            // dis_gcColMaquina
            // 
            this.dis_gcColMaquina.Caption = "Máquina";
            this.dis_gcColMaquina.FieldName = "Máquina";
            this.dis_gcColMaquina.Name = "dis_gcColMaquina";
            this.dis_gcColMaquina.Visible = true;
            this.dis_gcColMaquina.VisibleIndex = 4;
            // 
            // dis_xtpMaterialCLI
            // 
            this.dis_xtpMaterialCLI.Controls.Add(this.dis_gcMaterialCLI);
            this.dis_xtpMaterialCLI.Name = "dis_xtpMaterialCLI";
            this.dis_xtpMaterialCLI.Size = new System.Drawing.Size(781, 192);
            this.dis_xtpMaterialCLI.Text = "Materiales Cliente";
            // 
            // dis_gcMaterialCLI
            // 
            this.dis_gcMaterialCLI.ContextMenuStrip = this.cmMaterialCLI;
            this.dis_gcMaterialCLI.Location = new System.Drawing.Point(4, 4);
            this.dis_gcMaterialCLI.MainView = this.dis_gvMaterialCLI;
            this.dis_gcMaterialCLI.Name = "dis_gcMaterialCLI";
            this.dis_gcMaterialCLI.Size = new System.Drawing.Size(774, 185);
            this.dis_gcMaterialCLI.TabIndex = 0;
            this.dis_gcMaterialCLI.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dis_gvMaterialCLI});
            // 
            // cmMaterialCLI
            // 
            this.cmMaterialCLI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAgregaMaterialCLI,
            this.mnuQuitaMaterialCLI});
            this.cmMaterialCLI.Name = "cmMaterialCLI";
            this.cmMaterialCLI.Size = new System.Drawing.Size(231, 48);
            // 
            // mnuAgregaMaterialCLI
            // 
            this.mnuAgregaMaterialCLI.Name = "mnuAgregaMaterialCLI";
            this.mnuAgregaMaterialCLI.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuAgregaMaterialCLI.Size = new System.Drawing.Size(230, 22);
            this.mnuAgregaMaterialCLI.Text = "Agregar Material";
            this.mnuAgregaMaterialCLI.Click += new System.EventHandler(this.mnuAgregaMaterialCLI_Click);
            // 
            // mnuQuitaMaterialCLI
            // 
            this.mnuQuitaMaterialCLI.Name = "mnuQuitaMaterialCLI";
            this.mnuQuitaMaterialCLI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.mnuQuitaMaterialCLI.Size = new System.Drawing.Size(230, 22);
            this.mnuQuitaMaterialCLI.Text = "Quitar Material";
            this.mnuQuitaMaterialCLI.Click += new System.EventHandler(this.mnuQuitaMaterialCLI_Click);
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
            this.dis_gcColMaterialCLI.Visible = true;
            this.dis_gcColMaterialCLI.VisibleIndex = 0;
            // 
            // dis_gcColCantidadCLI
            // 
            this.dis_gcColCantidadCLI.Caption = "Cantidad";
            this.dis_gcColCantidadCLI.FieldName = "Cantidad";
            this.dis_gcColCantidadCLI.Name = "dis_gcColCantidadCLI";
            this.dis_gcColCantidadCLI.Visible = true;
            this.dis_gcColCantidadCLI.VisibleIndex = 1;
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
            this.xtpServiciosEXT.Size = new System.Drawing.Size(802, 226);
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
            // xtpControlPRD
            // 
            this.xtpControlPRD.Controls.Add(this.prd_gcDetalle);
            this.xtpControlPRD.Controls.Add(this.labelControl6);
            this.xtpControlPRD.Controls.Add(this.prd_lueProceso);
            this.xtpControlPRD.Name = "xtpControlPRD";
            this.xtpControlPRD.Size = new System.Drawing.Size(802, 226);
            this.xtpControlPRD.Text = "Control Producción";
            // 
            // prd_gcDetalle
            // 
            this.prd_gcDetalle.Location = new System.Drawing.Point(6, 32);
            this.prd_gcDetalle.MainView = this.prd_gvDetalle;
            this.prd_gcDetalle.Name = "prd_gcDetalle";
            this.prd_gcDetalle.Size = new System.Drawing.Size(784, 191);
            this.prd_gcDetalle.TabIndex = 2;
            this.prd_gcDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.prd_gvDetalle});
            // 
            // prd_gvDetalle
            // 
            this.prd_gvDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.prd_gcColEmpleado,
            this.prd_gcColFecInicia,
            this.prd_gcColFecTermina,
            this.prd_gcColObservacion});
            this.prd_gvDetalle.GridControl = this.prd_gcDetalle;
            this.prd_gvDetalle.Name = "prd_gvDetalle";
            this.prd_gvDetalle.OptionsView.ShowGroupPanel = false;
            // 
            // prd_gcColEmpleado
            // 
            this.prd_gcColEmpleado.Caption = "Encargado";
            this.prd_gcColEmpleado.FieldName = "Encargado";
            this.prd_gcColEmpleado.Name = "prd_gcColEmpleado";
            this.prd_gcColEmpleado.OptionsColumn.AllowEdit = false;
            this.prd_gcColEmpleado.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.prd_gcColEmpleado.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.prd_gcColEmpleado.OptionsColumn.AllowMove = false;
            this.prd_gcColEmpleado.OptionsColumn.ReadOnly = true;
            this.prd_gcColEmpleado.Visible = true;
            this.prd_gcColEmpleado.VisibleIndex = 0;
            this.prd_gcColEmpleado.Width = 328;
            // 
            // prd_gcColFecInicia
            // 
            this.prd_gcColFecInicia.Caption = "Inicia";
            this.prd_gcColFecInicia.FieldName = "FecInicia";
            this.prd_gcColFecInicia.Name = "prd_gcColFecInicia";
            this.prd_gcColFecInicia.OptionsColumn.AllowEdit = false;
            this.prd_gcColFecInicia.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.prd_gcColFecInicia.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.prd_gcColFecInicia.OptionsColumn.AllowMove = false;
            this.prd_gcColFecInicia.OptionsColumn.ReadOnly = true;
            this.prd_gcColFecInicia.Visible = true;
            this.prd_gcColFecInicia.VisibleIndex = 1;
            this.prd_gcColFecInicia.Width = 204;
            // 
            // prd_gcColFecTermina
            // 
            this.prd_gcColFecTermina.Caption = "Termina";
            this.prd_gcColFecTermina.FieldName = "FecTermina";
            this.prd_gcColFecTermina.Name = "prd_gcColFecTermina";
            this.prd_gcColFecTermina.OptionsColumn.AllowEdit = false;
            this.prd_gcColFecTermina.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.prd_gcColFecTermina.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.prd_gcColFecTermina.OptionsColumn.AllowMove = false;
            this.prd_gcColFecTermina.OptionsColumn.ReadOnly = true;
            this.prd_gcColFecTermina.Visible = true;
            this.prd_gcColFecTermina.VisibleIndex = 2;
            this.prd_gcColFecTermina.Width = 195;
            // 
            // prd_gcColObservacion
            // 
            this.prd_gcColObservacion.Caption = "Observacion";
            this.prd_gcColObservacion.FieldName = "ObsLinea";
            this.prd_gcColObservacion.Name = "prd_gcColObservacion";
            this.prd_gcColObservacion.OptionsColumn.AllowEdit = false;
            this.prd_gcColObservacion.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.prd_gcColObservacion.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.prd_gcColObservacion.OptionsColumn.AllowMove = false;
            this.prd_gcColObservacion.OptionsColumn.ReadOnly = true;
            this.prd_gcColObservacion.Visible = true;
            this.prd_gcColObservacion.VisibleIndex = 3;
            this.prd_gcColObservacion.Width = 585;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(18, 9);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(42, 13);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Proceso:";
            // 
            // prd_lueProceso
            // 
            this.prd_lueProceso.Location = new System.Drawing.Point(77, 6);
            this.prd_lueProceso.Name = "prd_lueProceso";
            this.prd_lueProceso.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.prd_lueProceso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.prd_lueProceso.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayText", "Proceso")});
            this.prd_lueProceso.Properties.DisplayMember = "Descripcion";
            this.prd_lueProceso.Properties.NullText = "";
            this.prd_lueProceso.Properties.ValueMember = "Codigo";
            this.prd_lueProceso.Size = new System.Drawing.Size(175, 20);
            this.prd_lueProceso.TabIndex = 0;
            this.prd_lueProceso.EditValueChanged += new System.EventHandler(this.prd_lueProceso_EditValueChanged);
            // 
            // xtpTerminaTercero
            // 
            this.xtpTerminaTercero.Name = "xtpTerminaTercero";
            this.xtpTerminaTercero.Size = new System.Drawing.Size(802, 226);
            this.xtpTerminaTercero.Text = "Terciarizado";
            // 
            // xtpDespachoCLI
            // 
            this.xtpDespachoCLI.Name = "xtpDespachoCLI";
            this.xtpDespachoCLI.Size = new System.Drawing.Size(802, 226);
            this.xtpDespachoCLI.Text = "Despacho";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(718, 29);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(15, 13);
            this.labelControl13.TabIndex = 19;
            this.labelControl13.Text = "ID:";
            // 
            // rdgTipoOFF
            // 
            this.rdgTipoOFF.Location = new System.Drawing.Point(573, 3);
            this.rdgTipoOFF.Name = "rdgTipoOFF";
            this.rdgTipoOFF.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.rdgTipoOFF.Properties.Columns = 1;
            this.rdgTipoOFF.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("OFF", "Offset"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("DIG", "Digital")});
            this.rdgTipoOFF.Size = new System.Drawing.Size(84, 43);
            this.rdgTipoOFF.TabIndex = 18;
            // 
            // chkEstadoORD
            // 
            this.chkEstadoORD.Location = new System.Drawing.Point(748, 3);
            this.chkEstadoORD.Name = "chkEstadoORD";
            this.chkEstadoORD.Properties.Caption = "Activo";
            this.chkEstadoORD.Properties.ReadOnly = true;
            this.chkEstadoORD.Size = new System.Drawing.Size(58, 19);
            this.chkEstadoORD.TabIndex = 14;
            // 
            // txtCodigoORD
            // 
            this.txtCodigoORD.EditValue = "";
            this.txtCodigoORD.Location = new System.Drawing.Point(748, 26);
            this.txtCodigoORD.Name = "txtCodigoORD";
            this.txtCodigoORD.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodigoORD.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCodigoORD.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtCodigoORD.Properties.MaxLength = 8;
            this.txtCodigoORD.Properties.ReadOnly = true;
            this.txtCodigoORD.Size = new System.Drawing.Size(53, 20);
            this.txtCodigoORD.TabIndex = 13;
            // 
            // txtNumeroCOT
            // 
            this.txtNumeroCOT.Location = new System.Drawing.Point(344, 4);
            this.txtNumeroCOT.Name = "txtNumeroCOT";
            this.txtNumeroCOT.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNumeroCOT.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtNumeroCOT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtNumeroCOT.Properties.MaxLength = 10;
            this.txtNumeroCOT.Size = new System.Drawing.Size(123, 20);
            this.txtNumeroCOT.TabIndex = 9;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(273, 8);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(53, 13);
            this.labelControl9.TabIndex = 8;
            this.labelControl9.Text = "Cotización:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(10, 7);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(58, 13);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Nro. Órden:";
            // 
            // beOrden
            // 
            this.beOrden.Location = new System.Drawing.Point(85, 4);
            this.beOrden.Name = "beOrden";
            this.beOrden.Properties.Appearance.Options.UseTextOptions = true;
            this.beOrden.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.beOrden.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.beOrden.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beOrden.Properties.MaxLength = 8;
            this.beOrden.Size = new System.Drawing.Size(123, 20);
            this.beOrden.TabIndex = 0;
            this.beOrden.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beOrden_ButtonClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.deFechaCOT);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.deFechaPP);
            this.groupControl1.Controls.Add(this.deFechaENT);
            this.groupControl1.Controls.Add(this.labelControl88);
            this.groupControl1.Controls.Add(this.deFechaFAC);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.deFechaINI);
            this.groupControl1.Location = new System.Drawing.Point(20, 31);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(693, 99);
            this.groupControl1.TabIndex = 22;
            this.groupControl1.Text = "Fechas";
            // 
            // ctlOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barraStandar);
            this.Name = "ctlOrden";
            this.Size = new System.Drawing.Size(834, 488);
            this.Load += new System.EventHandler(this.ctlOrden_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemORD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcResumen)).EndInit();
            this.xtcResumen.ResumeLayout(false);
            this.xtpAcabados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcAcabados)).EndInit();
            this.cmAcabados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvAcabados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceUnLado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceDosLados)).EndInit();
            this.xtpTotales.ResumeLayout(false);
            this.xtpTotales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seSaldo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAbono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seIVA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSubtotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePrecioUNI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seCantidad.Properties)).EndInit();
            this.xtpObservaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meObservacionesORD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcPestanas)).EndInit();
            this.xtcPestanas.ResumeLayout(false);
            this.xtpGeneral.ResumeLayout(false);
            this.xtpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gen_lueColorRetiro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gen_txtOrdenTroquel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gen_txtAlto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gen_txtAncho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gen_lueTipoTrabajo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gen_lueTrabajo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gen_lueTroquel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gen_txtPantones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gen_lueColorTiro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gen_lueTamano.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gen_txtTiraje.Properties)).EndInit();
            this.xtpOrden.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deFechaCOT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaCOT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaINI.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaINI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFAC.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFAC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaPP.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaPP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaENT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaENT.Properties)).EndInit();
            this.xtpDatosCLI.ResumeLayout(false);
            this.xtpDatosCLI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cli_gcDestinos)).EndInit();
            this.cmSucursalCLI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cli_gvDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcContactos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvContactos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCLI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beBuscaCLI.Properties)).EndInit();
            this.xtpBlocks.ResumeLayout(false);
            this.xtpBlocks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blo_txtPantones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_lueColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_txtTiraje.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_txtOrdenTroquel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_txtAlto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_txtAncho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_lueTamano.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_lueTroquel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_lueAcabado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_txtTermina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_txtInicia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_txtSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_lueTipoEmblocado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_txtJuegos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blo_lueNumCopias.Properties)).EndInit();
            this.xtpLibros.ResumeLayout(false);
            this.xtpLibros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lib_lueForma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcLibrosDET)).EndInit();
            this.xtcLibrosDET.ResumeLayout(false);
            this.xtpLibroENC.ResumeLayout(false);
            this.xtpLibroENC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lib_gcColoresENC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_gvColoresENC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilue_gridColorENC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_txtAltoENC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_txtAnchoENC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_TipoTrabajoENC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_lueTamanoENC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_txtNumPaginasENC.Properties)).EndInit();
            this.xtpLibroPOR.ResumeLayout(false);
            this.xtpLibroPOR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lib_txtColorPantonePOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_beMaterialCubiertaPOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_beMaterialGuardaPOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_lueRetiroCubiertaPOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_lueRetiroGuardaPOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_lueRetiroColorPOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_lueTiroCubiertaPOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_lueTiroGuardaPOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_lueTiroColorPOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_txtOrdenPOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_lueTroquelPOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_txtAltoPOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_txtAnchoPOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_lueTamanoPOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_lueTipoLibro.Properties)).EndInit();
            this.xtpMateriales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.em_gcDetalleEGR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.em_gvDetalleEGR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.em_rilueSeccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.em_ribeBuscaMAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.em_rilueMaquina)).EndInit();
            this.xtpDiseno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtcDiseno)).EndInit();
            this.xtcDiseno.ResumeLayout(false);
            this.dis_xtpGeneral.ResumeLayout(false);
            this.dis_xtpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbCTP)).EndInit();
            this.gbCTP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dis_chklCTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_txtDisenador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbOrginales)).EndInit();
            this.gbOrginales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dis_chklOriginales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbGraficas)).EndInit();
            this.gbGraficas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dis_chklGraficasH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_deFechaINI.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_deFechaINI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_deFechaFIN.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_deFechaFIN.Properties)).EndInit();
            this.dis_xtpArmados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dis_gcArmados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_gvArmados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dis_rilueSeccionARM)).EndInit();
            this.dis_xtpMaterialCLI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dis_gcMaterialCLI)).EndInit();
            this.cmMaterialCLI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dis_gvMaterialCLI)).EndInit();
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
            this.xtpControlPRD.ResumeLayout(false);
            this.xtpControlPRD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prd_gcDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prd_gvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prd_lueProceso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgTipoOFF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstadoORD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoORD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroCOT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beOrden.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private dllStandardTool.StandardTool barraStandar;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.RadioGroup rdgTipoOFF;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.CheckEdit chkEstadoORD;
        private DevExpress.XtraEditors.TextEdit txtCodigoORD;
        private DevExpress.XtraEditors.DateEdit deFechaFAC;
        private DevExpress.XtraEditors.DateEdit deFechaENT;
        private DevExpress.XtraEditors.DateEdit deFechaPP;
        private DevExpress.XtraEditors.TextEdit txtNumeroCOT;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit beBuscaCLI;
        private DevExpress.XtraEditors.TextEdit txtNombreCLI;
        private DevExpress.XtraEditors.ButtonEdit beOrden;
        private DevExpress.XtraTab.XtraTabControl xtcPestanas;
        private DevExpress.XtraTab.XtraTabPage xtpGeneral;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.TextEdit gen_txtPantones;
        private DevExpress.XtraEditors.LookUpEdit gen_lueColorTiro;
        private DevExpress.XtraEditors.LookUpEdit gen_lueTamano;
        private DevExpress.XtraEditors.TextEdit gen_txtTiraje;
        private DevExpress.XtraTab.XtraTabPage xtpLibros;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.LabelControl labelControl32;
        private DevExpress.XtraEditors.LookUpEdit gen_lueTroquel;
        private DevExpress.XtraEditors.LabelControl labelControl63;
        private DevExpress.XtraEditors.LookUpEdit lib_lueTamanoPOR;
        private DevExpress.XtraEditors.LabelControl labelControl47;
        private DevExpress.XtraEditors.LookUpEdit lib_lueTamanoENC;
        private DevExpress.XtraEditors.LookUpEdit lib_TipoTrabajoENC;
        private DevExpress.XtraEditors.TextEdit lib_txtNumPaginasENC;
        private DevExpress.XtraEditors.LabelControl labelControl52;
        private DevExpress.XtraEditors.LookUpEdit lib_lueTroquelPOR;
        private DevExpress.XtraEditors.LabelControl labelControl72;
        private DevExpress.XtraEditors.LookUpEdit lib_lueTipoLibro;
        private DevExpress.XtraTab.XtraTabPage xtpMateriales;
        private DevExpress.XtraGrid.GridControl em_gcDetalleEGR;
        private DevExpress.XtraGrid.Views.Grid.GridView em_gvDetalleEGR;
        private DevExpress.XtraGrid.Columns.GridColumn em_gcColSeccion;
        private DevExpress.XtraGrid.Columns.GridColumn em_gcColMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn em_gcColCantPliego;
        private DevExpress.XtraGrid.Columns.GridColumn em_gcColExtras;
        private DevExpress.XtraGrid.Columns.GridColumn em_gcColCantTamano;
        private DevExpress.XtraGrid.Columns.GridColumn em_gcColAncho;
        private DevExpress.XtraGrid.Columns.GridColumn em_gcColAlto;
        private DevExpress.XtraGrid.Columns.GridColumn em_gcColPlacasMQ;
        private DevExpress.XtraGrid.Columns.GridColumn em_gcColCntPlacas;
        private DevExpress.XtraEditors.LabelControl labelControl77;
        private DevExpress.XtraEditors.LabelControl labelControl76;
        private DevExpress.XtraEditors.LabelControl labelControl75;
        private DevExpress.XtraEditors.LabelControl labelControl74;
        private DevExpress.XtraEditors.LabelControl labelControl73;
        private DevExpress.XtraEditors.LabelControl labelControl43;
        private DevExpress.XtraTab.XtraTabPage xtpDatosCLI;
        private DevExpress.XtraTab.XtraTabPage xtpServiciosEXT;
        private DevExpress.XtraEditors.LabelControl labelControl48;
        private DevExpress.XtraTab.XtraTabPage xtpBlocks;
        private DevExpress.XtraGrid.GridControl gcContactos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvContactos;
        private DevExpress.XtraEditors.TextEdit gen_txtAlto;
        private DevExpress.XtraEditors.TextEdit gen_txtAncho;
        private DevExpress.XtraEditors.LookUpEdit gen_lueTipoTrabajo;
        private DevExpress.XtraEditors.LookUpEdit gen_lueTrabajo;
        private DevExpress.XtraEditors.LabelControl labelControl78;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl79;
        private DevExpress.XtraEditors.TextEdit gen_txtOrdenTroquel;
        private DevExpress.XtraEditors.LookUpEdit gen_lueColorRetiro;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.LabelControl labelControl41;
        private DevExpress.XtraEditors.LabelControl labelControl40;
        private DevExpress.XtraEditors.LabelControl labelControl39;
        private DevExpress.XtraEditors.LabelControl labelControl38;
        private DevExpress.XtraEditors.LabelControl labelControl37;
        private DevExpress.XtraEditors.TextEdit blo_txtPantones;
        private DevExpress.XtraEditors.LookUpEdit blo_lueColor;
        private DevExpress.XtraEditors.TextEdit blo_txtTiraje;
        private DevExpress.XtraEditors.TextEdit blo_txtOrdenTroquel;
        private DevExpress.XtraEditors.LabelControl labelControl34;
        private DevExpress.XtraEditors.LabelControl labelControl33;
        private DevExpress.XtraEditors.LabelControl labelControl31;
        private DevExpress.XtraEditors.LabelControl labelControl30;
        private DevExpress.XtraEditors.LabelControl labelControl29;
        private DevExpress.XtraEditors.LabelControl labelControl28;
        private DevExpress.XtraEditors.LabelControl labelControl27;
        private DevExpress.XtraEditors.TextEdit blo_txtAlto;
        private DevExpress.XtraEditors.TextEdit blo_txtAncho;
        private DevExpress.XtraEditors.LookUpEdit blo_lueTamano;
        private DevExpress.XtraEditors.LookUpEdit blo_lueTroquel;
        private DevExpress.XtraEditors.LookUpEdit blo_lueAcabado;
        private DevExpress.XtraEditors.TextEdit blo_txtTermina;
        private DevExpress.XtraEditors.TextEdit blo_txtInicia;
        private DevExpress.XtraEditors.TextEdit blo_txtSerie;
        private DevExpress.XtraEditors.LookUpEdit blo_lueTipoEmblocado;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraEditors.TextEdit blo_txtJuegos;
        private DevExpress.XtraEditors.LookUpEdit blo_lueNumCopias;
        private DevExpress.XtraTab.XtraTabControl xtcLibrosDET;
        private DevExpress.XtraTab.XtraTabPage xtpLibroENC;
        private DevExpress.XtraTab.XtraTabPage xtpLibroPOR;
        private DevExpress.XtraGrid.GridControl lib_gcColoresENC;
        private DevExpress.XtraGrid.Views.Grid.GridView lib_gvColoresENC;
        private DevExpress.XtraGrid.Columns.GridColumn lib_gcColColorENC;
        private DevExpress.XtraGrid.Columns.GridColumn lib_gcColPaginasENC;
        private DevExpress.XtraEditors.LabelControl labelControl42;
        private DevExpress.XtraEditors.LabelControl labelControl80;
        private DevExpress.XtraEditors.TextEdit lib_txtAltoENC;
        private DevExpress.XtraEditors.TextEdit lib_txtAnchoENC;
        private DevExpress.XtraEditors.TextEdit lib_txtColorPantonePOR;
        private DevExpress.XtraEditors.ButtonEdit lib_beMaterialCubiertaPOR;
        private DevExpress.XtraEditors.ButtonEdit lib_beMaterialGuardaPOR;
        private DevExpress.XtraEditors.LookUpEdit lib_lueRetiroCubiertaPOR;
        private DevExpress.XtraEditors.LookUpEdit lib_lueRetiroGuardaPOR;
        private DevExpress.XtraEditors.LookUpEdit lib_lueRetiroColorPOR;
        private DevExpress.XtraEditors.LookUpEdit lib_lueTiroCubiertaPOR;
        private DevExpress.XtraEditors.LookUpEdit lib_lueTiroGuardaPOR;
        private DevExpress.XtraEditors.LookUpEdit lib_lueTiroColorPOR;
        private DevExpress.XtraEditors.TextEdit lib_txtOrdenPOR;
        private DevExpress.XtraEditors.TextEdit lib_txtAltoPOR;
        private DevExpress.XtraEditors.TextEdit lib_txtAnchoPOR;
        private DevExpress.XtraEditors.LabelControl labelControl45;
        private DevExpress.XtraEditors.LabelControl labelControl44;
        private DevExpress.XtraEditors.LabelControl labelControl46;
        private DevExpress.XtraEditors.LabelControl labelControl49;
        private DevExpress.XtraEditors.LabelControl labelControl50;
        private DevExpress.XtraEditors.LabelControl labelControl51;
        private DevExpress.XtraEditors.LabelControl labelControl53;
        private DevExpress.XtraEditors.LabelControl labelControl54;
        private DevExpress.XtraEditors.LabelControl labelControl55;
        private DevExpress.XtraEditors.LabelControl labelControl56;
        private DevExpress.XtraEditors.LabelControl labelControl57;
        private DevExpress.XtraTab.XtraTabControl xtcResumen;
        private DevExpress.XtraTab.XtraTabPage xtpTotales;
        private DevExpress.XtraTab.XtraTabPage xtpObservaciones;
        private DevExpress.XtraEditors.MemoEdit meObservacionesORD;
        private DevExpress.XtraTab.XtraTabPage xtpAcabados;
        private DevExpress.XtraGrid.GridControl gcAcabados;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAcabados;
        private DevExpress.XtraGrid.Columns.GridColumn gcColTipoAcabado;
        private DevExpress.XtraGrid.Columns.GridColumn gcColLadoUno;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceUnLado;
        private DevExpress.XtraGrid.Columns.GridColumn gcColLadoDos;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceDosLados;
        private DevExpress.XtraGrid.Columns.GridColumn gcColPáginas;
        private DevExpress.XtraGrid.Columns.GridColumn gcColNumerosPAG;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit lib_lueForma;
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
        private DevExpress.XtraTab.XtraTabPage xtpDespachoCLI;
        private System.Windows.Forms.ContextMenuStrip cmAcabados;
        private System.Windows.Forms.ToolStripMenuItem mnuAgregaAcabado;
        private System.Windows.Forms.ToolStripMenuItem mnuQuitaAcabado;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilue_gridColorENC;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit em_rilueSeccion;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit em_rilueMaquina;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit em_ribeBuscaMAT;
        private DevExpress.XtraEditors.SpinEdit seSaldo;
        private DevExpress.XtraEditors.SpinEdit seAbono;
        private DevExpress.XtraEditors.SpinEdit seTotal;
        private DevExpress.XtraEditors.SpinEdit seIVA;
        private DevExpress.XtraEditors.SpinEdit seSubtotal;
        private DevExpress.XtraEditors.SpinEdit sePrecioUNI;
        private DevExpress.XtraEditors.SpinEdit seCantidad;
        private DevExpress.XtraEditors.LabelControl labelControl87;
        private DevExpress.XtraEditors.TextEdit txtItemORD;
        private DevExpress.XtraTab.XtraTabPage xtpOrden;
        private DevExpress.XtraEditors.LabelControl labelControl88;
        private DevExpress.XtraEditors.DateEdit deFechaINI;
        private DevExpress.XtraEditors.SpinEdit sext_sePlastificadoPRE;
        private DevExpress.XtraEditors.SpinEdit sext_seSeguroPRE;
        private DevExpress.XtraEditors.SpinEdit sext_seTransportePRE;
        private DevExpress.XtraEditors.SpinEdit sext_seTermoselladoPRE;
        private DevExpress.XtraEditors.SpinEdit sext_seReservadoPRE;
        private DevExpress.XtraEditors.SpinEdit sext_seCocidoPRE;
        private DevExpress.XtraEditors.SpinEdit sext_seClishePRE;
        private DevExpress.XtraEditors.SpinEdit sext_seTroquelPRE;
        private DevExpress.XtraEditors.SpinEdit sext_sePeliculaPRE;
        private DevExpress.XtraEditors.CheckEdit sext_chkMetalico;
        private DevExpress.XtraEditors.CheckEdit sext_chkResina;
        private DevExpress.XtraGrid.Columns.GridColumn gcColContacto;
        private DevExpress.XtraGrid.Columns.GridColumn gcColNumero;
        private DevExpress.XtraTab.XtraTabPage xtpDiseno;
        private DevExpress.XtraEditors.DateEdit dis_deFechaINI;
        private DevExpress.XtraEditors.DateEdit dis_deFechaFIN;
        private DevExpress.XtraEditors.TextEdit dis_txtDisenador;
        private DevExpress.XtraEditors.SimpleButton dis_btnIniciar;
        private DevExpress.XtraEditors.SimpleButton dis_btnTerminar;
        private DevExpress.XtraEditors.LabelControl labelControl84;
        private DevExpress.XtraEditors.LabelControl labelControl85;
        private DevExpress.XtraEditors.LabelControl labelControl86;
        private DevExpress.XtraEditors.SimpleButton dis_btnActualiza;
        private DevExpress.XtraGrid.GridControl cli_gcDestinos;
        private DevExpress.XtraGrid.Views.Grid.GridView cli_gvDestino;
        private DevExpress.XtraGrid.Columns.GridColumn cli_gcColSecuencial;
        private DevExpress.XtraGrid.Columns.GridColumn cli_gcColCodCiudad;
        private DevExpress.XtraGrid.Columns.GridColumn cli_gcColDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn cli_gcColCantidad;
        private DevExpress.XtraTab.XtraTabControl xtcDiseno;
        private DevExpress.XtraTab.XtraTabPage dis_xtpGeneral;
        private DevExpress.XtraEditors.GroupControl gbCTP;
        private DevExpress.XtraEditors.CheckedListBoxControl dis_chklCTP;
        private DevExpress.XtraEditors.GroupControl gbOrginales;
        private DevExpress.XtraEditors.CheckedListBoxControl dis_chklOriginales;
        private DevExpress.XtraEditors.GroupControl gbGraficas;
        private DevExpress.XtraEditors.CheckedListBoxControl dis_chklGraficasH;
        private DevExpress.XtraTab.XtraTabPage dis_xtpArmados;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColTrabajo;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColTamano;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColAncho;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColAlto;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColMaquina;
        private DevExpress.XtraGrid.Views.Grid.GridView dis_gvArmados;
        private DevExpress.XtraGrid.GridControl dis_gcArmados;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit deFechaCOT;
        private DevExpress.XtraTab.XtraTabPage dis_xtpMaterialCLI;
        private DevExpress.XtraGrid.GridControl dis_gcMaterialCLI;
        private DevExpress.XtraGrid.Views.Grid.GridView dis_gvMaterialCLI;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColMaterialCLI;
        private DevExpress.XtraGrid.Columns.GridColumn dis_gcColCantidadCLI;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit dis_rilueSeccionARM;
        private System.Windows.Forms.ContextMenuStrip cmSucursalCLI;
        private System.Windows.Forms.ToolStripMenuItem mnuAgregarDestino;
        private System.Windows.Forms.ToolStripMenuItem mnuQuitarDestino;
        private System.Windows.Forms.ContextMenuStrip cmMaterialCLI;
        private System.Windows.Forms.ToolStripMenuItem mnuAgregaMaterialCLI;
        private System.Windows.Forms.ToolStripMenuItem mnuQuitaMaterialCLI;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit prd_lueProceso;
        private DevExpress.XtraGrid.GridControl prd_gcDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView prd_gvDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn prd_gcColEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn prd_gcColFecInicia;
        private DevExpress.XtraGrid.Columns.GridColumn prd_gcColFecTermina;
        private DevExpress.XtraGrid.Columns.GridColumn prd_gcColObservacion;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}
