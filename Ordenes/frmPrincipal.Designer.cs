namespace Ordenes
{
    partial class frmPrincipal
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rpCotizaciones = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgTransacciones = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiCotizaciones = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEstadoCOT = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTablasREF = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlMenu
            // 
            this.ribbonControlMenu.ExpandCollapseItem.Id = 0;
            this.ribbonControlMenu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiCotizaciones,
            this.bbiEstadoCOT,
            this.bbiTablasREF});
            this.ribbonControlMenu.MaxItemId = 16;
            this.ribbonControlMenu.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpCotizaciones});
            // 
            // rpCotizaciones
            // 
            this.rpCotizaciones.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgTransacciones});
            this.rpCotizaciones.Name = "rpCotizaciones";
            this.rpCotizaciones.Text = "Cotizaciones";
            // 
            // rpgTransacciones
            // 
            this.rpgTransacciones.ItemLinks.Add(this.bbiCotizaciones);
            this.rpgTransacciones.ItemLinks.Add(this.bbiEstadoCOT);
            this.rpgTransacciones.ItemLinks.Add(this.bbiTablasREF);
            this.rpgTransacciones.Name = "rpgTransacciones";
            this.rpgTransacciones.Text = "ribbonPageGroup1";
            // 
            // bbiCotizaciones
            // 
            this.bbiCotizaciones.Caption = "Cotizaciones";
            this.bbiCotizaciones.Id = 13;
            this.bbiCotizaciones.Name = "bbiCotizaciones";
            this.bbiCotizaciones.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCotizaciones_ItemClick);
            // 
            // bbiEstadoCOT
            // 
            this.bbiEstadoCOT.Caption = "Procesar Cotización";
            this.bbiEstadoCOT.Id = 14;
            this.bbiEstadoCOT.Name = "bbiEstadoCOT";
            this.bbiEstadoCOT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEstadoCOT_ItemClick);
            // 
            // bbiTablasREF
            // 
            this.bbiTablasREF.Caption = "Tablas de Referencia";
            this.bbiTablasREF.Id = 15;
            this.bbiTablasREF.Name = "bbiTablasREF";
            this.bbiTablasREF.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTablasREF_ItemClick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 493);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gráficas Hernández - Cotizador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarButtonItem bbiCotizaciones;
        private DevExpress.XtraBars.BarButtonItem bbiEstadoCOT;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpCotizaciones;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgTransacciones;
        private DevExpress.XtraBars.BarButtonItem bbiTablasREF;
    }
}