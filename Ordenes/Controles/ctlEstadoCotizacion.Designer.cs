namespace Ordenes.Controles
{
    partial class ctlEstadoCotizacion
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barraStandar = new dllStandardTool.StandardTool();
            this.paGeneral = new System.Windows.Forms.Panel();
            this.gbObservaciones = new System.Windows.Forms.GroupBox();
            this.meObservaciones = new DevExpress.XtraEditors.MemoEdit();
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRechazar = new DevExpress.XtraEditors.SimpleButton();
            this.lueMotivoRechaza = new DevExpress.XtraEditors.LookUpEdit();
            this.btnArpobar = new DevExpress.XtraEditors.SimpleButton();
            this.lblTotalREG = new DevExpress.XtraEditors.LabelControl();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.btnCargaDET = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.chkPorEstado = new DevExpress.XtraEditors.CheckEdit();
            this.chkPorCliente = new DevExpress.XtraEditors.CheckEdit();
            this.lueEstado = new DevExpress.XtraEditors.LookUpEdit();
            this.beCliente = new DevExpress.XtraEditors.ButtonEdit();
            this.deFechaHasta = new DevExpress.XtraEditors.DateEdit();
            this.deFechaDesde = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gc_ListaCotizaciones = new DevExpress.XtraGrid.GridControl();
            this.cmOpcionesCOT = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAprobar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRechazar = new System.Windows.Forms.ToolStripMenuItem();
            this.gv_ListaCotizaciones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcColSeleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rice_chkSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gcColEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcColNumCotiza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcColFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcColCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcColArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcColTiraje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcColPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.paGeneral.SuspendLayout();
            this.gbObservaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meObservaciones.Properties)).BeginInit();
            this.gbAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueMotivoRechaza.Properties)).BeginInit();
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkPorEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPorCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_ListaCotizaciones)).BeginInit();
            this.cmOpcionesCOT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ListaCotizaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rice_chkSeleccionar)).BeginInit();
            this.SuspendLayout();
            // 
            // barraStandar
            // 
            this.barraStandar.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraStandar.Location = new System.Drawing.Point(0, 0);
            this.barraStandar.Name = "barraStandar";
            this.barraStandar.Size = new System.Drawing.Size(840, 24);
            this.barraStandar.TabIndex = 3;
            // 
            // paGeneral
            // 
            this.paGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paGeneral.Controls.Add(this.gbObservaciones);
            this.paGeneral.Controls.Add(this.gbAcciones);
            this.paGeneral.Controls.Add(this.lblTotalREG);
            this.paGeneral.Controls.Add(this.gbFiltros);
            this.paGeneral.Controls.Add(this.gc_ListaCotizaciones);
            this.paGeneral.Location = new System.Drawing.Point(3, 30);
            this.paGeneral.Name = "paGeneral";
            this.paGeneral.Size = new System.Drawing.Size(834, 416);
            this.paGeneral.TabIndex = 4;
            // 
            // gbObservaciones
            // 
            this.gbObservaciones.Controls.Add(this.meObservaciones);
            this.gbObservaciones.Location = new System.Drawing.Point(4, 328);
            this.gbObservaciones.Name = "gbObservaciones";
            this.gbObservaciones.Size = new System.Drawing.Size(477, 83);
            this.gbObservaciones.TabIndex = 7;
            this.gbObservaciones.TabStop = false;
            this.gbObservaciones.Text = "Observaciones";
            // 
            // meObservaciones
            // 
            this.meObservaciones.Location = new System.Drawing.Point(6, 19);
            this.meObservaciones.Name = "meObservaciones";
            this.meObservaciones.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.meObservaciones.Size = new System.Drawing.Size(465, 58);
            this.meObservaciones.TabIndex = 6;
            // 
            // gbAcciones
            // 
            this.gbAcciones.Controls.Add(this.label1);
            this.gbAcciones.Controls.Add(this.btnRechazar);
            this.gbAcciones.Controls.Add(this.lueMotivoRechaza);
            this.gbAcciones.Controls.Add(this.btnArpobar);
            this.gbAcciones.Location = new System.Drawing.Point(487, 328);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Size = new System.Drawing.Size(342, 83);
            this.gbAcciones.TabIndex = 3;
            this.gbAcciones.TabStop = false;
            this.gbAcciones.Text = "Acciones:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Motivo Rechaza:";
            // 
            // btnRechazar
            // 
            this.btnRechazar.Location = new System.Drawing.Point(234, 54);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(102, 23);
            this.btnRechazar.TabIndex = 5;
            this.btnRechazar.Text = "&Rechazada";
            this.btnRechazar.Click += new System.EventHandler(this.btnRechazar_Click);
            // 
            // lueMotivoRechaza
            // 
            this.lueMotivoRechaza.Location = new System.Drawing.Point(109, 28);
            this.lueMotivoRechaza.Name = "lueMotivoRechaza";
            this.lueMotivoRechaza.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lueMotivoRechaza.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMotivoRechaza.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Rechazada por:")});
            this.lueMotivoRechaza.Properties.NullText = "";
            this.lueMotivoRechaza.Size = new System.Drawing.Size(227, 20);
            this.lueMotivoRechaza.TabIndex = 0;
            // 
            // btnArpobar
            // 
            this.btnArpobar.Location = new System.Drawing.Point(109, 54);
            this.btnArpobar.Name = "btnArpobar";
            this.btnArpobar.Size = new System.Drawing.Size(119, 23);
            this.btnArpobar.TabIndex = 4;
            this.btnArpobar.Text = "&Aprobada";
            this.btnArpobar.Click += new System.EventHandler(this.btnArpobar_Click);
            // 
            // lblTotalREG
            // 
            this.lblTotalREG.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalREG.Appearance.Options.UseFont = true;
            this.lblTotalREG.Appearance.Options.UseTextOptions = true;
            this.lblTotalREG.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblTotalREG.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTotalREG.Location = new System.Drawing.Point(658, 309);
            this.lblTotalREG.Name = "lblTotalREG";
            this.lblTotalREG.Size = new System.Drawing.Size(165, 18);
            this.lblTotalREG.TabIndex = 2;
            this.lblTotalREG.Text = "Total Registros: 000";
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.btnCargaDET);
            this.gbFiltros.Controls.Add(this.labelControl4);
            this.gbFiltros.Controls.Add(this.labelControl3);
            this.gbFiltros.Controls.Add(this.chkPorEstado);
            this.gbFiltros.Controls.Add(this.chkPorCliente);
            this.gbFiltros.Controls.Add(this.lueEstado);
            this.gbFiltros.Controls.Add(this.beCliente);
            this.gbFiltros.Controls.Add(this.deFechaHasta);
            this.gbFiltros.Controls.Add(this.deFechaDesde);
            this.gbFiltros.Controls.Add(this.labelControl2);
            this.gbFiltros.Controls.Add(this.labelControl1);
            this.gbFiltros.Location = new System.Drawing.Point(4, 4);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(825, 77);
            this.gbFiltros.TabIndex = 1;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtrado por:";
            // 
            // btnCargaDET
            // 
            this.btnCargaDET.Location = new System.Drawing.Point(717, 27);
            this.btnCargaDET.Name = "btnCargaDET";
            this.btnCargaDET.Size = new System.Drawing.Size(102, 40);
            this.btnCargaDET.TabIndex = 11;
            this.btnCargaDET.Text = "Consultar";
            this.btnCargaDET.Click += new System.EventHandler(this.btnCargaDET_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(331, 51);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Estado:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(331, 29);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Cliente:";
            // 
            // chkPorEstado
            // 
            this.chkPorEstado.Location = new System.Drawing.Point(654, 48);
            this.chkPorEstado.Name = "chkPorEstado";
            this.chkPorEstado.Properties.Caption = "";
            this.chkPorEstado.Size = new System.Drawing.Size(22, 19);
            this.chkPorEstado.TabIndex = 8;
            // 
            // chkPorCliente
            // 
            this.chkPorCliente.Location = new System.Drawing.Point(654, 27);
            this.chkPorCliente.Name = "chkPorCliente";
            this.chkPorCliente.Properties.Caption = "";
            this.chkPorCliente.Size = new System.Drawing.Size(22, 19);
            this.chkPorCliente.TabIndex = 7;
            // 
            // lueEstado
            // 
            this.lueEstado.Location = new System.Drawing.Point(386, 48);
            this.lueEstado.Name = "lueEstado";
            this.lueEstado.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lueEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEstado.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Estado")});
            this.lueEstado.Properties.NullText = "";
            this.lueEstado.Size = new System.Drawing.Size(262, 20);
            this.lueEstado.TabIndex = 5;
            // 
            // beCliente
            // 
            this.beCliente.Location = new System.Drawing.Point(386, 26);
            this.beCliente.Name = "beCliente";
            this.beCliente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.beCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beCliente.Properties.ReadOnly = true;
            this.beCliente.Size = new System.Drawing.Size(262, 20);
            this.beCliente.TabIndex = 4;
            this.beCliente.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beCliente_ButtonClick);
            // 
            // deFechaHasta
            // 
            this.deFechaHasta.EditValue = null;
            this.deFechaHasta.Location = new System.Drawing.Point(73, 47);
            this.deFechaHasta.Name = "deFechaHasta";
            this.deFechaHasta.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.deFechaHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaHasta.Properties.DisplayFormat.FormatString = "dddd d \'de\' MMMM \'de\' yyyy";
            this.deFechaHasta.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.deFechaHasta.Properties.EditFormat.FormatString = "dddd d \'de\' MMMM \'de\' yyyy";
            this.deFechaHasta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.deFechaHasta.Properties.Mask.EditMask = "dddd d \'de\' MMMM \'de\' yyyy";
            this.deFechaHasta.Size = new System.Drawing.Size(234, 20);
            this.deFechaHasta.TabIndex = 3;
            // 
            // deFechaDesde
            // 
            this.deFechaDesde.EditValue = null;
            this.deFechaDesde.Location = new System.Drawing.Point(73, 25);
            this.deFechaDesde.Name = "deFechaDesde";
            this.deFechaDesde.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.deFechaDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaDesde.Properties.DisplayFormat.FormatString = "dddd d \'de\' MMMM \'de\' yyyy";
            this.deFechaDesde.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.deFechaDesde.Properties.EditFormat.FormatString = "dddd d \'de\' MMMM \'de\' yyyy";
            this.deFechaDesde.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.deFechaDesde.Properties.Mask.EditMask = "dddd d \'de\' MMMM \'de\' yyyy";
            this.deFechaDesde.Size = new System.Drawing.Size(234, 20);
            this.deFechaDesde.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Hasta:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Desde:";
            // 
            // gc_ListaCotizaciones
            // 
            this.gc_ListaCotizaciones.ContextMenuStrip = this.cmOpcionesCOT;
            this.gc_ListaCotizaciones.Location = new System.Drawing.Point(3, 87);
            this.gc_ListaCotizaciones.MainView = this.gv_ListaCotizaciones;
            this.gc_ListaCotizaciones.Name = "gc_ListaCotizaciones";
            this.gc_ListaCotizaciones.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rice_chkSeleccionar});
            this.gc_ListaCotizaciones.Size = new System.Drawing.Size(826, 221);
            this.gc_ListaCotizaciones.TabIndex = 0;
            this.gc_ListaCotizaciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_ListaCotizaciones});
            // 
            // cmOpcionesCOT
            // 
            this.cmOpcionesCOT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAprobar,
            this.mnuRechazar});
            this.cmOpcionesCOT.Name = "cmOpcionesCOT";
            this.cmOpcionesCOT.Size = new System.Drawing.Size(163, 48);
            // 
            // mnuAprobar
            // 
            this.mnuAprobar.Name = "mnuAprobar";
            this.mnuAprobar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuAprobar.Size = new System.Drawing.Size(162, 22);
            this.mnuAprobar.Text = "Aprobar";
            // 
            // mnuRechazar
            // 
            this.mnuRechazar.Name = "mnuRechazar";
            this.mnuRechazar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mnuRechazar.Size = new System.Drawing.Size(162, 22);
            this.mnuRechazar.Text = "Rechazar";
            // 
            // gv_ListaCotizaciones
            // 
            this.gv_ListaCotizaciones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcColSeleccionar,
            this.gcColEstado,
            this.gcColNumCotiza,
            this.gcColFecha,
            this.gcColCliente,
            this.gcColArticulo,
            this.gcColTiraje,
            this.gcColPrecio});
            this.gv_ListaCotizaciones.GridControl = this.gc_ListaCotizaciones;
            this.gv_ListaCotizaciones.Name = "gv_ListaCotizaciones";
            this.gv_ListaCotizaciones.OptionsView.ColumnAutoWidth = false;
            this.gv_ListaCotizaciones.OptionsView.ShowGroupPanel = false;
            // 
            // gcColSeleccionar
            // 
            this.gcColSeleccionar.Caption = "SEL";
            this.gcColSeleccionar.ColumnEdit = this.rice_chkSeleccionar;
            this.gcColSeleccionar.FieldName = "Seleccionar";
            this.gcColSeleccionar.Name = "gcColSeleccionar";
            this.gcColSeleccionar.Visible = true;
            this.gcColSeleccionar.VisibleIndex = 0;
            this.gcColSeleccionar.Width = 40;
            // 
            // rice_chkSeleccionar
            // 
            this.rice_chkSeleccionar.AutoHeight = false;
            this.rice_chkSeleccionar.Name = "rice_chkSeleccionar";
            this.rice_chkSeleccionar.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // gcColEstado
            // 
            this.gcColEstado.Caption = "Estado";
            this.gcColEstado.FieldName = "NomEstadoCOT";
            this.gcColEstado.Name = "gcColEstado";
            this.gcColEstado.OptionsColumn.AllowEdit = false;
            this.gcColEstado.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gcColEstado.OptionsColumn.AllowIncrementalSearch = false;
            this.gcColEstado.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gcColEstado.OptionsColumn.AllowMove = false;
            this.gcColEstado.OptionsColumn.AllowShowHide = false;
            this.gcColEstado.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gcColEstado.OptionsColumn.ReadOnly = true;
            this.gcColEstado.OptionsFilter.AllowAutoFilter = false;
            this.gcColEstado.Visible = true;
            this.gcColEstado.VisibleIndex = 1;
            this.gcColEstado.Width = 120;
            // 
            // gcColNumCotiza
            // 
            this.gcColNumCotiza.Caption = "Nro";
            this.gcColNumCotiza.FieldName = "NumCotiza";
            this.gcColNumCotiza.Name = "gcColNumCotiza";
            this.gcColNumCotiza.OptionsColumn.AllowEdit = false;
            this.gcColNumCotiza.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gcColNumCotiza.OptionsColumn.AllowIncrementalSearch = false;
            this.gcColNumCotiza.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gcColNumCotiza.OptionsColumn.AllowMove = false;
            this.gcColNumCotiza.OptionsColumn.AllowShowHide = false;
            this.gcColNumCotiza.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gcColNumCotiza.OptionsColumn.ReadOnly = true;
            this.gcColNumCotiza.OptionsFilter.AllowAutoFilter = false;
            this.gcColNumCotiza.Visible = true;
            this.gcColNumCotiza.VisibleIndex = 2;
            this.gcColNumCotiza.Width = 50;
            // 
            // gcColFecha
            // 
            this.gcColFecha.Caption = "Fecha";
            this.gcColFecha.FieldName = "FecCotiza";
            this.gcColFecha.Name = "gcColFecha";
            this.gcColFecha.OptionsColumn.AllowEdit = false;
            this.gcColFecha.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gcColFecha.OptionsColumn.AllowIncrementalSearch = false;
            this.gcColFecha.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gcColFecha.OptionsColumn.AllowMove = false;
            this.gcColFecha.OptionsColumn.AllowShowHide = false;
            this.gcColFecha.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gcColFecha.OptionsColumn.ReadOnly = true;
            this.gcColFecha.OptionsFilter.AllowAutoFilter = false;
            this.gcColFecha.Visible = true;
            this.gcColFecha.VisibleIndex = 3;
            // 
            // gcColCliente
            // 
            this.gcColCliente.Caption = "Cliente";
            this.gcColCliente.FieldName = "Cliente";
            this.gcColCliente.Name = "gcColCliente";
            this.gcColCliente.OptionsColumn.AllowEdit = false;
            this.gcColCliente.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gcColCliente.OptionsColumn.AllowIncrementalSearch = false;
            this.gcColCliente.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gcColCliente.OptionsColumn.AllowMove = false;
            this.gcColCliente.OptionsColumn.AllowShowHide = false;
            this.gcColCliente.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gcColCliente.OptionsColumn.ReadOnly = true;
            this.gcColCliente.OptionsFilter.AllowAutoFilter = false;
            this.gcColCliente.Visible = true;
            this.gcColCliente.VisibleIndex = 4;
            this.gcColCliente.Width = 180;
            // 
            // gcColArticulo
            // 
            this.gcColArticulo.Caption = "Artículo";
            this.gcColArticulo.FieldName = "Articulo";
            this.gcColArticulo.Name = "gcColArticulo";
            this.gcColArticulo.OptionsColumn.AllowEdit = false;
            this.gcColArticulo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gcColArticulo.OptionsColumn.AllowIncrementalSearch = false;
            this.gcColArticulo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gcColArticulo.OptionsColumn.AllowMove = false;
            this.gcColArticulo.OptionsColumn.AllowShowHide = false;
            this.gcColArticulo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gcColArticulo.OptionsColumn.ReadOnly = true;
            this.gcColArticulo.OptionsFilter.AllowAutoFilter = false;
            this.gcColArticulo.Visible = true;
            this.gcColArticulo.VisibleIndex = 5;
            this.gcColArticulo.Width = 180;
            // 
            // gcColTiraje
            // 
            this.gcColTiraje.Caption = "Tiraje";
            this.gcColTiraje.FieldName = "Tiraje";
            this.gcColTiraje.Name = "gcColTiraje";
            this.gcColTiraje.OptionsColumn.AllowEdit = false;
            this.gcColTiraje.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gcColTiraje.OptionsColumn.AllowIncrementalSearch = false;
            this.gcColTiraje.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gcColTiraje.OptionsColumn.AllowMove = false;
            this.gcColTiraje.OptionsColumn.AllowShowHide = false;
            this.gcColTiraje.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gcColTiraje.OptionsColumn.ReadOnly = true;
            this.gcColTiraje.OptionsFilter.AllowAutoFilter = false;
            this.gcColTiraje.Visible = true;
            this.gcColTiraje.VisibleIndex = 6;
            this.gcColTiraje.Width = 60;
            // 
            // gcColPrecio
            // 
            this.gcColPrecio.Caption = "Precio";
            this.gcColPrecio.DisplayFormat.FormatString = "N2";
            this.gcColPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gcColPrecio.FieldName = "TotalCotiza";
            this.gcColPrecio.Name = "gcColPrecio";
            this.gcColPrecio.OptionsColumn.AllowEdit = false;
            this.gcColPrecio.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gcColPrecio.OptionsColumn.AllowIncrementalSearch = false;
            this.gcColPrecio.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gcColPrecio.OptionsColumn.AllowMove = false;
            this.gcColPrecio.OptionsColumn.AllowShowHide = false;
            this.gcColPrecio.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gcColPrecio.OptionsColumn.ReadOnly = true;
            this.gcColPrecio.OptionsFilter.AllowAutoFilter = false;
            this.gcColPrecio.Visible = true;
            this.gcColPrecio.VisibleIndex = 7;
            this.gcColPrecio.Width = 90;
            // 
            // ctlEstadoCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.paGeneral);
            this.Controls.Add(this.barraStandar);
            this.Name = "ctlEstadoCotizacion";
            this.Size = new System.Drawing.Size(840, 449);
            this.Load += new System.EventHandler(this.ctlEstadoCotizacion_Load);
            this.paGeneral.ResumeLayout(false);
            this.gbObservaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meObservaciones.Properties)).EndInit();
            this.gbAcciones.ResumeLayout(false);
            this.gbAcciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueMotivoRechaza.Properties)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkPorEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPorCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_ListaCotizaciones)).EndInit();
            this.cmOpcionesCOT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_ListaCotizaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rice_chkSeleccionar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dllStandardTool.StandardTool barraStandar;
        private System.Windows.Forms.Panel paGeneral;
        private DevExpress.XtraGrid.GridControl gc_ListaCotizaciones;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_ListaCotizaciones;
        private DevExpress.XtraGrid.Columns.GridColumn gcColNumCotiza;
        private DevExpress.XtraGrid.Columns.GridColumn gcColCliente;
        private DevExpress.XtraGrid.Columns.GridColumn gcColFecha;
        private DevExpress.XtraGrid.Columns.GridColumn gcColPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn gcColArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn gcColTiraje;
        private DevExpress.XtraGrid.Columns.GridColumn gcColSeleccionar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit rice_chkSeleccionar;
        private DevExpress.XtraGrid.Columns.GridColumn gcColEstado;
        private DevExpress.XtraEditors.LabelControl lblTotalREG;
        private System.Windows.Forms.GroupBox gbFiltros;
        private DevExpress.XtraEditors.SimpleButton btnCargaDET;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit chkPorEstado;
        private DevExpress.XtraEditors.CheckEdit chkPorCliente;
        private DevExpress.XtraEditors.LookUpEdit lueEstado;
        private DevExpress.XtraEditors.ButtonEdit beCliente;
        private DevExpress.XtraEditors.DateEdit deFechaHasta;
        private DevExpress.XtraEditors.DateEdit deFechaDesde;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ContextMenuStrip cmOpcionesCOT;
        private System.Windows.Forms.ToolStripMenuItem mnuAprobar;
        private System.Windows.Forms.ToolStripMenuItem mnuRechazar;
        private System.Windows.Forms.GroupBox gbAcciones;
        private DevExpress.XtraEditors.MemoEdit meObservaciones;
        private DevExpress.XtraEditors.SimpleButton btnRechazar;
        private DevExpress.XtraEditors.LookUpEdit lueMotivoRechaza;
        private DevExpress.XtraEditors.SimpleButton btnArpobar;
        private System.Windows.Forms.GroupBox gbObservaciones;
        private System.Windows.Forms.Label label1;
    }
}
