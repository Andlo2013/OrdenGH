namespace Ordenes.Formularios
{
    partial class frmCortes
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
            this.paSoporte = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new DevExpress.XtraEditors.SimpleButton();
            this.seAnchoMAT = new DevExpress.XtraEditors.SpinEdit();
            this.seAltoMAT = new DevExpress.XtraEditors.SpinEdit();
            this.seAnchoCOR = new DevExpress.XtraEditors.SpinEdit();
            this.seAltoCOR = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.seAltoRES = new DevExpress.XtraEditors.SpinEdit();
            this.seAnchoRES = new DevExpress.XtraEditors.SpinEdit();
            this.seDesperdicio = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seAnchoMAT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAltoMAT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAnchoCOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAltoCOR.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seAltoRES.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAnchoRES.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDesperdicio.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // paSoporte
            // 
            this.paSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paSoporte.Location = new System.Drawing.Point(6, 19);
            this.paSoporte.Name = "paSoporte";
            this.paSoporte.Size = new System.Drawing.Size(200, 200);
            this.paSoporte.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.paSoporte);
            this.groupBox1.Location = new System.Drawing.Point(340, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 232);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Papel o soporte de impresión";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(187, 49);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(119, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // seAnchoMAT
            // 
            this.seAnchoMAT.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seAnchoMAT.Location = new System.Drawing.Point(59, 28);
            this.seAnchoMAT.Name = "seAnchoMAT";
            this.seAnchoMAT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.seAnchoMAT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seAnchoMAT.Properties.DisplayFormat.FormatString = "N2";
            this.seAnchoMAT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seAnchoMAT.Properties.EditFormat.FormatString = "N2";
            this.seAnchoMAT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seAnchoMAT.Properties.Mask.EditMask = "N2";
            this.seAnchoMAT.Properties.MaxValue = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.seAnchoMAT.Size = new System.Drawing.Size(87, 20);
            this.seAnchoMAT.TabIndex = 5;
            // 
            // seAltoMAT
            // 
            this.seAltoMAT.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seAltoMAT.Location = new System.Drawing.Point(219, 28);
            this.seAltoMAT.Name = "seAltoMAT";
            this.seAltoMAT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.seAltoMAT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seAltoMAT.Properties.DisplayFormat.FormatString = "N2";
            this.seAltoMAT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seAltoMAT.Properties.EditFormat.FormatString = "N2";
            this.seAltoMAT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seAltoMAT.Properties.Mask.EditMask = "N2";
            this.seAltoMAT.Properties.MaxValue = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.seAltoMAT.Size = new System.Drawing.Size(87, 20);
            this.seAltoMAT.TabIndex = 6;
            // 
            // seAnchoCOR
            // 
            this.seAnchoCOR.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seAnchoCOR.Location = new System.Drawing.Point(59, 19);
            this.seAnchoCOR.Name = "seAnchoCOR";
            this.seAnchoCOR.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.seAnchoCOR.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seAnchoCOR.Properties.DisplayFormat.FormatString = "N2";
            this.seAnchoCOR.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seAnchoCOR.Properties.EditFormat.FormatString = "N2";
            this.seAnchoCOR.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seAnchoCOR.Properties.Mask.EditMask = "N2";
            this.seAnchoCOR.Properties.MaxValue = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.seAnchoCOR.Size = new System.Drawing.Size(87, 20);
            this.seAnchoCOR.TabIndex = 7;
            // 
            // seAltoCOR
            // 
            this.seAltoCOR.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seAltoCOR.Location = new System.Drawing.Point(219, 19);
            this.seAltoCOR.Name = "seAltoCOR";
            this.seAltoCOR.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.seAltoCOR.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seAltoCOR.Properties.DisplayFormat.FormatString = "N2";
            this.seAltoCOR.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seAltoCOR.Properties.EditFormat.FormatString = "N2";
            this.seAltoCOR.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seAltoCOR.Properties.Mask.EditMask = "N2";
            this.seAltoCOR.Properties.MaxValue = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.seAltoCOR.Size = new System.Drawing.Size(87, 20);
            this.seAltoCOR.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Ancho:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(187, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Alto :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 22);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Ancho:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(187, 22);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(23, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Alto:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.seAnchoMAT);
            this.groupBox2.Controls.Add(this.labelControl2);
            this.groupBox2.Controls.Add(this.seAltoMAT);
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Location = new System.Drawing.Point(13, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 64);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Material";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.seAnchoCOR);
            this.groupBox3.Controls.Add(this.labelControl3);
            this.groupBox3.Controls.Add(this.labelControl4);
            this.groupBox3.Controls.Add(this.seAltoCOR);
            this.groupBox3.Location = new System.Drawing.Point(12, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 54);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Corte";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelControl8);
            this.groupBox4.Controls.Add(this.labelControl7);
            this.groupBox4.Controls.Add(this.seDesperdicio);
            this.groupBox4.Controls.Add(this.labelControl6);
            this.groupBox4.Controls.Add(this.labelControl5);
            this.groupBox4.Controls.Add(this.seAltoRES);
            this.groupBox4.Controls.Add(this.btnCalcular);
            this.groupBox4.Controls.Add(this.seAnchoRES);
            this.groupBox4.Location = new System.Drawing.Point(12, 153);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(312, 78);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultado:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(187, 26);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(23, 13);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "Alto:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(6, 28);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(34, 13);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Ancho:";
            // 
            // seAltoRES
            // 
            this.seAltoRES.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seAltoRES.Location = new System.Drawing.Point(219, 23);
            this.seAltoRES.Name = "seAltoRES";
            this.seAltoRES.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.seAltoRES.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seAltoRES.Properties.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.seAltoRES.Properties.Appearance.Options.UseBackColor = true;
            this.seAltoRES.Properties.Appearance.Options.UseFont = true;
            this.seAltoRES.Properties.Appearance.Options.UseForeColor = true;
            this.seAltoRES.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.seAltoRES.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seAltoRES.Properties.DisplayFormat.FormatString = "N2";
            this.seAltoRES.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seAltoRES.Properties.EditFormat.FormatString = "N2";
            this.seAltoRES.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seAltoRES.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seAltoRES.Properties.Mask.EditMask = "N2";
            this.seAltoRES.Properties.ReadOnly = true;
            this.seAltoRES.Size = new System.Drawing.Size(87, 20);
            this.seAltoRES.TabIndex = 1;
            // 
            // seAnchoRES
            // 
            this.seAnchoRES.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seAnchoRES.Location = new System.Drawing.Point(59, 23);
            this.seAnchoRES.Name = "seAnchoRES";
            this.seAnchoRES.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.seAnchoRES.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seAnchoRES.Properties.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.seAnchoRES.Properties.Appearance.Options.UseBackColor = true;
            this.seAnchoRES.Properties.Appearance.Options.UseFont = true;
            this.seAnchoRES.Properties.Appearance.Options.UseForeColor = true;
            this.seAnchoRES.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.seAnchoRES.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seAnchoRES.Properties.DisplayFormat.FormatString = "N2";
            this.seAnchoRES.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seAnchoRES.Properties.EditFormat.FormatString = "N2";
            this.seAnchoRES.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seAnchoRES.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seAnchoRES.Properties.Mask.EditMask = "N2";
            this.seAnchoRES.Properties.ReadOnly = true;
            this.seAnchoRES.Size = new System.Drawing.Size(87, 20);
            this.seAnchoRES.TabIndex = 0;
            // 
            // seDesperdicio
            // 
            this.seDesperdicio.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seDesperdicio.Location = new System.Drawing.Point(59, 50);
            this.seDesperdicio.Name = "seDesperdicio";
            this.seDesperdicio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.seDesperdicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seDesperdicio.Properties.DisplayFormat.FormatString = "N2";
            this.seDesperdicio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seDesperdicio.Properties.EditFormat.FormatString = "N2";
            this.seDesperdicio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seDesperdicio.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seDesperdicio.Properties.Mask.EditMask = "N2";
            this.seDesperdicio.Properties.MaxValue = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.seDesperdicio.Properties.ReadOnly = true;
            this.seDesperdicio.Size = new System.Drawing.Size(87, 20);
            this.seDesperdicio.TabIndex = 5;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(7, 53);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(40, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Pérdida:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(154, 54);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(19, 13);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "cm2";
            // 
            // frmCortes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 251);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCortes";
            this.Text = "Cortes";
            this.Load += new System.EventHandler(this.frmCortes_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seAnchoMAT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAltoMAT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAnchoCOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAltoCOR.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seAltoRES.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAnchoRES.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDesperdicio.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paSoporte;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnCalcular;
        private DevExpress.XtraEditors.SpinEdit seAnchoMAT;
        private DevExpress.XtraEditors.SpinEdit seAltoMAT;
        private DevExpress.XtraEditors.SpinEdit seAnchoCOR;
        private DevExpress.XtraEditors.SpinEdit seAltoCOR;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SpinEdit seAltoRES;
        private DevExpress.XtraEditors.SpinEdit seAnchoRES;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SpinEdit seDesperdicio;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}