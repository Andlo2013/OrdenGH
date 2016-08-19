namespace Ordenes
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rpOrdenes = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgOrdenes = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiOrden = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDiseno = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlMenu
            // 
            this.ribbonControlMenu.ExpandCollapseItem.Id = 0;
            this.ribbonControlMenu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiOrden,
            this.bbiDiseno});
            this.ribbonControlMenu.MaxItemId = 15;
            this.ribbonControlMenu.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpOrdenes});
            // 
            // rpOrdenes
            // 
            this.rpOrdenes.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgOrdenes});
            this.rpOrdenes.Name = "rpOrdenes";
            this.rpOrdenes.Text = "Ordenes";
            // 
            // rpgOrdenes
            // 
            this.rpgOrdenes.ItemLinks.Add(this.bbiOrden);
            this.rpgOrdenes.ItemLinks.Add(this.bbiDiseno);
            this.rpgOrdenes.Name = "rpgOrdenes";
            this.rpgOrdenes.Text = "Ordenes";
            // 
            // bbiOrden
            // 
            this.bbiOrden.Caption = "Ordenes";
            this.bbiOrden.Id = 13;
            this.bbiOrden.Name = "bbiOrden";
            this.bbiOrden.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiOrden_ItemClick);
            // 
            // bbiDiseno
            // 
            this.bbiDiseno.Caption = "Diseño";
            this.bbiDiseno.Id = 14;
            this.bbiDiseno.Name = "bbiDiseno";
            this.bbiDiseno.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDiseno_ItemClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(896, 493);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarButtonItem bbiOrden;
        private DevExpress.XtraBars.BarButtonItem bbiDiseno;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpOrdenes;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgOrdenes;
    }
}

