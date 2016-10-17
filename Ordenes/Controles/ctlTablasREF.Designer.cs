namespace Ordenes.Controles
{
    partial class ctlTablasREF
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
            this.tcPrincipal = new System.Windows.Forms.TabControl();
            this.tpAcabados = new System.Windows.Forms.TabPage();
            this.aca_btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.aca_gcAcabados = new DevExpress.XtraGrid.GridControl();
            this.aca_cmOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aca_mnuEliminaAcabado = new System.Windows.Forms.ToolStripMenuItem();
            this.aca_gvAcabados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.aca_gcColDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.aca_gcColAplicaA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.aca_rilueAreaAplica = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.aca_gcColCodTalla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.aca_rilueCodTalla = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.aca_gcColCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.aca_gcColEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tpCobertura = new System.Windows.Forms.TabPage();
            this.cob_btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.cob_gcCobertura = new DevExpress.XtraGrid.GridControl();
            this.cob_gvCobertura = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cob_gcColDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cob_gcColGramos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cob_gcColEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cob_cmOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cob_mnuEliminaCobertura = new System.Windows.Forms.ToolStripMenuItem();
            this.tcPrincipal.SuspendLayout();
            this.tpAcabados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aca_gcAcabados)).BeginInit();
            this.aca_cmOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aca_gvAcabados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aca_rilueAreaAplica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aca_rilueCodTalla)).BeginInit();
            this.tpCobertura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cob_gcCobertura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cob_gvCobertura)).BeginInit();
            this.panel1.SuspendLayout();
            this.cob_cmOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Controls.Add(this.tpAcabados);
            this.tcPrincipal.Controls.Add(this.tpCobertura);
            this.tcPrincipal.Location = new System.Drawing.Point(3, 3);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(757, 390);
            this.tcPrincipal.TabIndex = 0;
            // 
            // tpAcabados
            // 
            this.tpAcabados.Controls.Add(this.aca_btnGuardar);
            this.tpAcabados.Controls.Add(this.aca_gcAcabados);
            this.tpAcabados.Location = new System.Drawing.Point(4, 22);
            this.tpAcabados.Name = "tpAcabados";
            this.tpAcabados.Padding = new System.Windows.Forms.Padding(3);
            this.tpAcabados.Size = new System.Drawing.Size(749, 364);
            this.tpAcabados.TabIndex = 0;
            this.tpAcabados.Text = "Acabados";
            this.tpAcabados.UseVisualStyleBackColor = true;
            // 
            // aca_btnGuardar
            // 
            this.aca_btnGuardar.Location = new System.Drawing.Point(615, 329);
            this.aca_btnGuardar.Name = "aca_btnGuardar";
            this.aca_btnGuardar.Size = new System.Drawing.Size(128, 23);
            this.aca_btnGuardar.TabIndex = 1;
            this.aca_btnGuardar.Text = "Guardar";
            this.aca_btnGuardar.Click += new System.EventHandler(this.aca_btnGuardar_Click);
            // 
            // aca_gcAcabados
            // 
            this.aca_gcAcabados.ContextMenuStrip = this.aca_cmOpciones;
            this.aca_gcAcabados.Location = new System.Drawing.Point(4, 7);
            this.aca_gcAcabados.MainView = this.aca_gvAcabados;
            this.aca_gcAcabados.Name = "aca_gcAcabados";
            this.aca_gcAcabados.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.aca_rilueCodTalla,
            this.aca_rilueAreaAplica});
            this.aca_gcAcabados.Size = new System.Drawing.Size(739, 316);
            this.aca_gcAcabados.TabIndex = 0;
            this.aca_gcAcabados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.aca_gvAcabados});
            // 
            // aca_cmOpciones
            // 
            this.aca_cmOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aca_mnuEliminaAcabado});
            this.aca_cmOpciones.Name = "aca_cmOpciones";
            this.aca_cmOpciones.Size = new System.Drawing.Size(224, 26);
            // 
            // aca_mnuEliminaAcabado
            // 
            this.aca_mnuEliminaAcabado.Name = "aca_mnuEliminaAcabado";
            this.aca_mnuEliminaAcabado.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.aca_mnuEliminaAcabado.Size = new System.Drawing.Size(223, 22);
            this.aca_mnuEliminaAcabado.Text = "Eliminar Acabado";
            this.aca_mnuEliminaAcabado.Click += new System.EventHandler(this.aca_mnuEliminaAcabado_Click);
            // 
            // aca_gvAcabados
            // 
            this.aca_gvAcabados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.aca_gcColDescripcion,
            this.aca_gcColAplicaA,
            this.aca_gcColCodTalla,
            this.aca_gcColCosto,
            this.aca_gcColEstado});
            this.aca_gvAcabados.GridControl = this.aca_gcAcabados;
            this.aca_gvAcabados.Name = "aca_gvAcabados";
            this.aca_gvAcabados.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.aca_gvAcabados.OptionsView.ShowGroupPanel = false;
            this.aca_gvAcabados.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.aca_gvAcabados_CellValueChanged);
            // 
            // aca_gcColDescripcion
            // 
            this.aca_gcColDescripcion.Caption = "Descripción";
            this.aca_gcColDescripcion.FieldName = "Descripcion";
            this.aca_gcColDescripcion.Name = "aca_gcColDescripcion";
            this.aca_gcColDescripcion.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColDescripcion.OptionsColumn.AllowIncrementalSearch = false;
            this.aca_gcColDescripcion.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColDescripcion.OptionsColumn.AllowMove = false;
            this.aca_gcColDescripcion.OptionsColumn.AllowShowHide = false;
            this.aca_gcColDescripcion.Visible = true;
            this.aca_gcColDescripcion.VisibleIndex = 0;
            this.aca_gcColDescripcion.Width = 285;
            // 
            // aca_gcColAplicaA
            // 
            this.aca_gcColAplicaA.Caption = "Area Aplica";
            this.aca_gcColAplicaA.ColumnEdit = this.aca_rilueAreaAplica;
            this.aca_gcColAplicaA.FieldName = "AplicaA";
            this.aca_gcColAplicaA.Name = "aca_gcColAplicaA";
            this.aca_gcColAplicaA.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColAplicaA.OptionsColumn.AllowIncrementalSearch = false;
            this.aca_gcColAplicaA.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColAplicaA.OptionsColumn.AllowMove = false;
            this.aca_gcColAplicaA.OptionsColumn.AllowShowHide = false;
            this.aca_gcColAplicaA.Visible = true;
            this.aca_gcColAplicaA.VisibleIndex = 1;
            this.aca_gcColAplicaA.Width = 108;
            // 
            // aca_rilueAreaAplica
            // 
            this.aca_rilueAreaAplica.AutoHeight = false;
            this.aca_rilueAreaAplica.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.aca_rilueAreaAplica.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Area")});
            this.aca_rilueAreaAplica.Name = "aca_rilueAreaAplica";
            this.aca_rilueAreaAplica.NullText = "";
            // 
            // aca_gcColCodTalla
            // 
            this.aca_gcColCodTalla.Caption = "Grupo";
            this.aca_gcColCodTalla.ColumnEdit = this.aca_rilueCodTalla;
            this.aca_gcColCodTalla.FieldName = "CodTalla";
            this.aca_gcColCodTalla.Name = "aca_gcColCodTalla";
            this.aca_gcColCodTalla.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColCodTalla.OptionsColumn.AllowIncrementalSearch = false;
            this.aca_gcColCodTalla.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColCodTalla.OptionsColumn.AllowMove = false;
            this.aca_gcColCodTalla.OptionsColumn.AllowShowHide = false;
            this.aca_gcColCodTalla.Visible = true;
            this.aca_gcColCodTalla.VisibleIndex = 2;
            this.aca_gcColCodTalla.Width = 177;
            // 
            // aca_rilueCodTalla
            // 
            this.aca_rilueCodTalla.AutoHeight = false;
            this.aca_rilueCodTalla.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.aca_rilueCodTalla.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Grupo")});
            this.aca_rilueCodTalla.Name = "aca_rilueCodTalla";
            this.aca_rilueCodTalla.NullText = "";
            // 
            // aca_gcColCosto
            // 
            this.aca_gcColCosto.Caption = "Costo";
            this.aca_gcColCosto.FieldName = "Costo";
            this.aca_gcColCosto.Name = "aca_gcColCosto";
            this.aca_gcColCosto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColCosto.OptionsColumn.AllowIncrementalSearch = false;
            this.aca_gcColCosto.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColCosto.OptionsColumn.AllowMove = false;
            this.aca_gcColCosto.OptionsColumn.AllowShowHide = false;
            this.aca_gcColCosto.Visible = true;
            this.aca_gcColCosto.VisibleIndex = 3;
            this.aca_gcColCosto.Width = 97;
            // 
            // aca_gcColEstado
            // 
            this.aca_gcColEstado.Caption = "EST";
            this.aca_gcColEstado.FieldName = "Estado";
            this.aca_gcColEstado.Name = "aca_gcColEstado";
            this.aca_gcColEstado.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColEstado.OptionsColumn.AllowIncrementalSearch = false;
            this.aca_gcColEstado.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.aca_gcColEstado.OptionsColumn.AllowMove = false;
            this.aca_gcColEstado.OptionsColumn.AllowShowHide = false;
            this.aca_gcColEstado.Visible = true;
            this.aca_gcColEstado.VisibleIndex = 4;
            this.aca_gcColEstado.Width = 54;
            // 
            // tpCobertura
            // 
            this.tpCobertura.Controls.Add(this.cob_btnGuardar);
            this.tpCobertura.Controls.Add(this.cob_gcCobertura);
            this.tpCobertura.Location = new System.Drawing.Point(4, 22);
            this.tpCobertura.Name = "tpCobertura";
            this.tpCobertura.Padding = new System.Windows.Forms.Padding(3);
            this.tpCobertura.Size = new System.Drawing.Size(749, 364);
            this.tpCobertura.TabIndex = 1;
            this.tpCobertura.Text = "Cobertura";
            this.tpCobertura.UseVisualStyleBackColor = true;
            // 
            // cob_btnGuardar
            // 
            this.cob_btnGuardar.Location = new System.Drawing.Point(638, 335);
            this.cob_btnGuardar.Name = "cob_btnGuardar";
            this.cob_btnGuardar.Size = new System.Drawing.Size(105, 23);
            this.cob_btnGuardar.TabIndex = 1;
            this.cob_btnGuardar.Text = "Guardar";
            this.cob_btnGuardar.Click += new System.EventHandler(this.cob_btnGuardar_Click);
            // 
            // cob_gcCobertura
            // 
            this.cob_gcCobertura.ContextMenuStrip = this.cob_cmOpciones;
            this.cob_gcCobertura.Location = new System.Drawing.Point(7, 7);
            this.cob_gcCobertura.MainView = this.cob_gvCobertura;
            this.cob_gcCobertura.Name = "cob_gcCobertura";
            this.cob_gcCobertura.Size = new System.Drawing.Size(736, 315);
            this.cob_gcCobertura.TabIndex = 0;
            this.cob_gcCobertura.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cob_gvCobertura});
            // 
            // cob_gvCobertura
            // 
            this.cob_gvCobertura.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cob_gcColDescripcion,
            this.cob_gcColGramos,
            this.cob_gcColEstado});
            this.cob_gvCobertura.GridControl = this.cob_gcCobertura;
            this.cob_gvCobertura.Name = "cob_gvCobertura";
            this.cob_gvCobertura.OptionsView.ShowGroupPanel = false;
            this.cob_gvCobertura.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.cob_gvCobertura_CellValueChanged);
            // 
            // cob_gcColDescripcion
            // 
            this.cob_gcColDescripcion.Caption = "Descripción";
            this.cob_gcColDescripcion.FieldName = "Descripcion";
            this.cob_gcColDescripcion.Name = "cob_gcColDescripcion";
            this.cob_gcColDescripcion.Visible = true;
            this.cob_gcColDescripcion.VisibleIndex = 0;
            // 
            // cob_gcColGramos
            // 
            this.cob_gcColGramos.Caption = "Gramos";
            this.cob_gcColGramos.FieldName = "Gramos";
            this.cob_gcColGramos.Name = "cob_gcColGramos";
            this.cob_gcColGramos.Visible = true;
            this.cob_gcColGramos.VisibleIndex = 1;
            // 
            // cob_gcColEstado
            // 
            this.cob_gcColEstado.Caption = "Estado";
            this.cob_gcColEstado.FieldName = "Estado";
            this.cob_gcColEstado.Name = "cob_gcColEstado";
            this.cob_gcColEstado.Visible = true;
            this.cob_gcColEstado.VisibleIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tcPrincipal);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 396);
            this.panel1.TabIndex = 1;
            // 
            // cob_cmOpciones
            // 
            this.cob_cmOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cob_mnuEliminaCobertura});
            this.cob_cmOpciones.Name = "cob_cmOpciones";
            this.cob_cmOpciones.Size = new System.Drawing.Size(230, 48);
            // 
            // cob_mnuEliminaCobertura
            // 
            this.cob_mnuEliminaCobertura.Name = "cob_mnuEliminaCobertura";
            this.cob_mnuEliminaCobertura.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.cob_mnuEliminaCobertura.Size = new System.Drawing.Size(229, 22);
            this.cob_mnuEliminaCobertura.Text = "Eliminar Cobertura";
            this.cob_mnuEliminaCobertura.Click += new System.EventHandler(this.cob_mnuEliminaCobertura_Click);
            // 
            // ctlTablasREF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ctlTablasREF";
            this.Size = new System.Drawing.Size(771, 402);
            this.Load += new System.EventHandler(this.ctlTablasREF_Load);
            this.tcPrincipal.ResumeLayout(false);
            this.tpAcabados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aca_gcAcabados)).EndInit();
            this.aca_cmOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aca_gvAcabados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aca_rilueAreaAplica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aca_rilueCodTalla)).EndInit();
            this.tpCobertura.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cob_gcCobertura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cob_gvCobertura)).EndInit();
            this.panel1.ResumeLayout(false);
            this.cob_cmOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcPrincipal;
        private System.Windows.Forms.TabPage tpAcabados;
        private System.Windows.Forms.TabPage tpCobertura;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl aca_gcAcabados;
        private DevExpress.XtraGrid.Views.Grid.GridView aca_gvAcabados;
        private DevExpress.XtraGrid.Columns.GridColumn aca_gcColDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn aca_gcColAplicaA;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit aca_rilueAreaAplica;
        private DevExpress.XtraGrid.Columns.GridColumn aca_gcColCodTalla;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit aca_rilueCodTalla;
        private DevExpress.XtraGrid.Columns.GridColumn aca_gcColCosto;
        private DevExpress.XtraGrid.Columns.GridColumn aca_gcColEstado;
        private DevExpress.XtraEditors.SimpleButton aca_btnGuardar;
        private System.Windows.Forms.ContextMenuStrip aca_cmOpciones;
        private System.Windows.Forms.ToolStripMenuItem aca_mnuEliminaAcabado;
        private DevExpress.XtraEditors.SimpleButton cob_btnGuardar;
        private DevExpress.XtraGrid.GridControl cob_gcCobertura;
        private DevExpress.XtraGrid.Views.Grid.GridView cob_gvCobertura;
        private DevExpress.XtraGrid.Columns.GridColumn cob_gcColDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn cob_gcColGramos;
        private DevExpress.XtraGrid.Columns.GridColumn cob_gcColEstado;
        private System.Windows.Forms.ContextMenuStrip cob_cmOpciones;
        private System.Windows.Forms.ToolStripMenuItem cob_mnuEliminaCobertura;
    }
}
