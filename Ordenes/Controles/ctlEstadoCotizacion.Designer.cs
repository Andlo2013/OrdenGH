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
            this.barraStandar = new dllStandardTool.StandardTool();
            this.paGeneral = new System.Windows.Forms.Panel();
            this.gc_ListaCotizaciones = new DevExpress.XtraGrid.GridControl();
            this.gv_ListaCotizaciones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcColNumCotiza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcColFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcColCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcColArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcColPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcColTiraje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcColEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcColSeleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rice_chkSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.paGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_ListaCotizaciones)).BeginInit();
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
            this.paGeneral.Controls.Add(this.gc_ListaCotizaciones);
            this.paGeneral.Location = new System.Drawing.Point(3, 30);
            this.paGeneral.Name = "paGeneral";
            this.paGeneral.Size = new System.Drawing.Size(834, 367);
            this.paGeneral.TabIndex = 4;
            // 
            // gc_ListaCotizaciones
            // 
            this.gc_ListaCotizaciones.Location = new System.Drawing.Point(3, 87);
            this.gc_ListaCotizaciones.MainView = this.gv_ListaCotizaciones;
            this.gc_ListaCotizaciones.Name = "gc_ListaCotizaciones";
            this.gc_ListaCotizaciones.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rice_chkSeleccionar});
            this.gc_ListaCotizaciones.Size = new System.Drawing.Size(826, 275);
            this.gc_ListaCotizaciones.TabIndex = 0;
            this.gc_ListaCotizaciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_ListaCotizaciones});
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
            this.gcColNumCotiza.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
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
            this.gcColFecha.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
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
            this.gcColCliente.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
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
            this.gcColArticulo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gcColArticulo.OptionsColumn.ReadOnly = true;
            this.gcColArticulo.OptionsFilter.AllowAutoFilter = false;
            this.gcColArticulo.Visible = true;
            this.gcColArticulo.VisibleIndex = 5;
            this.gcColArticulo.Width = 180;
            // 
            // gcColPrecio
            // 
            this.gcColPrecio.Caption = "Precio";
            this.gcColPrecio.FieldName = "TotalCotiza";
            this.gcColPrecio.Name = "gcColPrecio";
            this.gcColPrecio.OptionsColumn.AllowEdit = false;
            this.gcColPrecio.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gcColPrecio.OptionsColumn.AllowIncrementalSearch = false;
            this.gcColPrecio.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gcColPrecio.OptionsColumn.AllowMove = false;
            this.gcColPrecio.OptionsColumn.AllowShowHide = false;
            this.gcColPrecio.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gcColPrecio.OptionsColumn.ReadOnly = true;
            this.gcColPrecio.OptionsFilter.AllowAutoFilter = false;
            this.gcColPrecio.Visible = true;
            this.gcColPrecio.VisibleIndex = 7;
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
            this.gcColTiraje.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gcColTiraje.OptionsColumn.ReadOnly = true;
            this.gcColTiraje.OptionsFilter.AllowAutoFilter = false;
            this.gcColTiraje.Visible = true;
            this.gcColTiraje.VisibleIndex = 6;
            // 
            // gcColEstado
            // 
            this.gcColEstado.Caption = "Estado";
            this.gcColEstado.FieldName = "EstadoCOT";
            this.gcColEstado.Name = "gcColEstado";
            this.gcColEstado.OptionsColumn.AllowEdit = false;
            this.gcColEstado.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gcColEstado.OptionsColumn.AllowIncrementalSearch = false;
            this.gcColEstado.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gcColEstado.OptionsColumn.AllowMove = false;
            this.gcColEstado.OptionsColumn.AllowShowHide = false;
            this.gcColEstado.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gcColEstado.OptionsColumn.ReadOnly = true;
            this.gcColEstado.OptionsFilter.AllowAutoFilter = false;
            this.gcColEstado.Visible = true;
            this.gcColEstado.VisibleIndex = 1;
            this.gcColEstado.Width = 120;
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
            // ctlEstadoCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.paGeneral);
            this.Controls.Add(this.barraStandar);
            this.Name = "ctlEstadoCotizacion";
            this.Size = new System.Drawing.Size(840, 400);
            this.Load += new System.EventHandler(this.ctlEstadoCotizacion_Load);
            this.paGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_ListaCotizaciones)).EndInit();
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
    }
}
