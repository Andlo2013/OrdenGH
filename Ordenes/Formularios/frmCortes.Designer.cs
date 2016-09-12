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
            this.btnCalcular = new DevExpress.XtraEditors.SimpleButton();
            this.sePliegoAncho = new DevExpress.XtraEditors.SpinEdit();
            this.sePliegoAlto = new DevExpress.XtraEditors.SpinEdit();
            this.seTamanoAncho = new DevExpress.XtraEditors.SpinEdit();
            this.seTamanoAlto = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.seTotalPliegos = new DevExpress.XtraEditors.SpinEdit();
            this.seTamanosXpliego = new DevExpress.XtraEditors.SpinEdit();
            this.seTrabajosXtamano = new DevExpress.XtraEditors.SpinEdit();
            this.beGrupoMAT = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.seTiraje = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.sePaginasXtamano = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.seAltoUsuario = new DevExpress.XtraEditors.SpinEdit();
            this.seAnchoUsuario = new DevExpress.XtraEditors.SpinEdit();
            this.seTrabajoAlto = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.seTrabajoAncho = new DevExpress.XtraEditors.SpinEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.sePliegoAncho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePliegoAlto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTamanoAncho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTamanoAlto.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seTotalPliegos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTamanosXpliego.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTrabajosXtamano.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beGrupoMAT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTiraje.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePaginasXtamano.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAltoUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAnchoUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTrabajoAlto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTrabajoAncho.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paSoporte
            // 
            this.paSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paSoporte.Location = new System.Drawing.Point(331, 36);
            this.paSoporte.Name = "paSoporte";
            this.paSoporte.Size = new System.Drawing.Size(370, 250);
            this.paSoporte.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCalcular.Appearance.Options.UseFont = true;
            this.btnCalcular.Appearance.Options.UseForeColor = true;
            this.btnCalcular.Location = new System.Drawing.Point(192, 255);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(124, 24);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // sePliegoAncho
            // 
            this.sePliegoAncho.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sePliegoAncho.Location = new System.Drawing.Point(66, 188);
            this.sePliegoAncho.Name = "sePliegoAncho";
            this.sePliegoAncho.Properties.Appearance.BackColor = System.Drawing.Color.Tan;
            this.sePliegoAncho.Properties.Appearance.Options.UseBackColor = true;
            this.sePliegoAncho.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.sePliegoAncho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sePliegoAncho.Properties.DisplayFormat.FormatString = "N2";
            this.sePliegoAncho.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sePliegoAncho.Properties.EditFormat.FormatString = "N2";
            this.sePliegoAncho.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sePliegoAncho.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sePliegoAncho.Properties.Mask.EditMask = "N2";
            this.sePliegoAncho.Properties.MaxValue = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.sePliegoAncho.Properties.ReadOnly = true;
            this.sePliegoAncho.Size = new System.Drawing.Size(77, 20);
            this.sePliegoAncho.TabIndex = 0;
            // 
            // sePliegoAlto
            // 
            this.sePliegoAlto.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sePliegoAlto.Location = new System.Drawing.Point(151, 188);
            this.sePliegoAlto.Name = "sePliegoAlto";
            this.sePliegoAlto.Properties.Appearance.BackColor = System.Drawing.Color.Tan;
            this.sePliegoAlto.Properties.Appearance.Options.UseBackColor = true;
            this.sePliegoAlto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.sePliegoAlto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sePliegoAlto.Properties.DisplayFormat.FormatString = "N2";
            this.sePliegoAlto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sePliegoAlto.Properties.EditFormat.FormatString = "N2";
            this.sePliegoAlto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sePliegoAlto.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sePliegoAlto.Properties.Mask.EditMask = "N2";
            this.sePliegoAlto.Properties.MaxValue = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.sePliegoAlto.Properties.ReadOnly = true;
            this.sePliegoAlto.Size = new System.Drawing.Size(77, 20);
            this.sePliegoAlto.TabIndex = 1;
            // 
            // seTamanoAncho
            // 
            this.seTamanoAncho.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seTamanoAncho.Location = new System.Drawing.Point(66, 167);
            this.seTamanoAncho.Name = "seTamanoAncho";
            this.seTamanoAncho.Properties.Appearance.BackColor = System.Drawing.Color.SeaGreen;
            this.seTamanoAncho.Properties.Appearance.Options.UseBackColor = true;
            this.seTamanoAncho.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.seTamanoAncho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seTamanoAncho.Properties.DisplayFormat.FormatString = "N2";
            this.seTamanoAncho.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seTamanoAncho.Properties.EditFormat.FormatString = "N2";
            this.seTamanoAncho.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seTamanoAncho.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seTamanoAncho.Properties.Mask.EditMask = "N2";
            this.seTamanoAncho.Properties.MaxValue = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.seTamanoAncho.Properties.ReadOnly = true;
            this.seTamanoAncho.Size = new System.Drawing.Size(77, 20);
            this.seTamanoAncho.TabIndex = 2;
            // 
            // seTamanoAlto
            // 
            this.seTamanoAlto.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seTamanoAlto.Location = new System.Drawing.Point(151, 167);
            this.seTamanoAlto.Name = "seTamanoAlto";
            this.seTamanoAlto.Properties.Appearance.BackColor = System.Drawing.Color.SeaGreen;
            this.seTamanoAlto.Properties.Appearance.Options.UseBackColor = true;
            this.seTamanoAlto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.seTamanoAlto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seTamanoAlto.Properties.DisplayFormat.FormatString = "N2";
            this.seTamanoAlto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seTamanoAlto.Properties.EditFormat.FormatString = "N2";
            this.seTamanoAlto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seTamanoAlto.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seTamanoAlto.Properties.Mask.EditMask = "N2";
            this.seTamanoAlto.Properties.MaxValue = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.seTamanoAlto.Properties.ReadOnly = true;
            this.seTamanoAlto.Size = new System.Drawing.Size(77, 20);
            this.seTamanoAlto.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(66, 95);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Ancho";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(151, 95);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(19, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Alto";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelControl5);
            this.groupBox3.Controls.Add(this.labelControl8);
            this.groupBox3.Controls.Add(this.seTotalPliegos);
            this.groupBox3.Controls.Add(this.seTamanosXpliego);
            this.groupBox3.Controls.Add(this.seTrabajosXtamano);
            this.groupBox3.Controls.Add(this.beGrupoMAT);
            this.groupBox3.Controls.Add(this.labelControl1);
            this.groupBox3.Controls.Add(this.sePliegoAncho);
            this.groupBox3.Controls.Add(this.sePliegoAlto);
            this.groupBox3.Controls.Add(this.seTiraje);
            this.groupBox3.Controls.Add(this.labelControl13);
            this.groupBox3.Controls.Add(this.labelControl12);
            this.groupBox3.Controls.Add(this.btnCalcular);
            this.groupBox3.Controls.Add(this.sePaginasXtamano);
            this.groupBox3.Controls.Add(this.labelControl11);
            this.groupBox3.Controls.Add(this.seAltoUsuario);
            this.groupBox3.Controls.Add(this.seAnchoUsuario);
            this.groupBox3.Controls.Add(this.seTrabajoAlto);
            this.groupBox3.Controls.Add(this.labelControl10);
            this.groupBox3.Controls.Add(this.labelControl9);
            this.groupBox3.Controls.Add(this.seTrabajoAncho);
            this.groupBox3.Controls.Add(this.seTamanoAncho);
            this.groupBox3.Controls.Add(this.labelControl3);
            this.groupBox3.Controls.Add(this.labelControl4);
            this.groupBox3.Controls.Add(this.seTamanoAlto);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 285);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tamaño";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl5.Location = new System.Drawing.Point(80, 231);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(106, 16);
            this.labelControl5.TabIndex = 30;
            this.labelControl5.Text = "Total de pliegos:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(11, 20);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(89, 13);
            this.labelControl8.TabIndex = 29;
            this.labelControl8.Text = "Grupo de material:";
            // 
            // seTotalPliegos
            // 
            this.seTotalPliegos.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seTotalPliegos.Location = new System.Drawing.Point(192, 229);
            this.seTotalPliegos.Name = "seTotalPliegos";
            this.seTotalPliegos.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.seTotalPliegos.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seTotalPliegos.Properties.Appearance.Options.UseBackColor = true;
            this.seTotalPliegos.Properties.Appearance.Options.UseFont = true;
            this.seTotalPliegos.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.seTotalPliegos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seTotalPliegos.Size = new System.Drawing.Size(124, 20);
            this.seTotalPliegos.TabIndex = 28;
            // 
            // seTamanosXpliego
            // 
            this.seTamanosXpliego.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seTamanosXpliego.Location = new System.Drawing.Point(239, 167);
            this.seTamanosXpliego.Name = "seTamanosXpliego";
            this.seTamanosXpliego.Properties.Appearance.BackColor = System.Drawing.Color.SeaGreen;
            this.seTamanosXpliego.Properties.Appearance.Options.UseBackColor = true;
            this.seTamanosXpliego.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.seTamanosXpliego.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seTamanosXpliego.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seTamanosXpliego.Properties.ReadOnly = true;
            this.seTamanosXpliego.Size = new System.Drawing.Size(77, 20);
            this.seTamanosXpliego.TabIndex = 27;
            // 
            // seTrabajosXtamano
            // 
            this.seTrabajosXtamano.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seTrabajosXtamano.Location = new System.Drawing.Point(239, 145);
            this.seTrabajosXtamano.Name = "seTrabajosXtamano";
            this.seTrabajosXtamano.Properties.Appearance.BackColor = System.Drawing.Color.CadetBlue;
            this.seTrabajosXtamano.Properties.Appearance.Options.UseBackColor = true;
            this.seTrabajosXtamano.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.seTrabajosXtamano.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seTrabajosXtamano.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seTrabajosXtamano.Properties.ReadOnly = true;
            this.seTrabajosXtamano.Size = new System.Drawing.Size(77, 20);
            this.seTrabajosXtamano.TabIndex = 26;
            // 
            // beGrupoMAT
            // 
            this.beGrupoMAT.Location = new System.Drawing.Point(11, 38);
            this.beGrupoMAT.Name = "beGrupoMAT";
            this.beGrupoMAT.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.beGrupoMAT.Properties.Appearance.Options.UseBackColor = true;
            this.beGrupoMAT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.beGrupoMAT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beGrupoMAT.Properties.ReadOnly = true;
            this.beGrupoMAT.Size = new System.Drawing.Size(305, 20);
            this.beGrupoMAT.TabIndex = 25;
            this.beGrupoMAT.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beGrupoMAT_ButtonClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelControl1.Location = new System.Drawing.Point(7, 191);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 14);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Pliego:";
            // 
            // seTiraje
            // 
            this.seTiraje.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seTiraje.Location = new System.Drawing.Point(66, 63);
            this.seTiraje.Name = "seTiraje";
            this.seTiraje.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.seTiraje.Properties.Appearance.Options.UseBackColor = true;
            this.seTiraje.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.seTiraje.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seTiraje.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seTiraje.Properties.MaxValue = new decimal(new int[] {
            99999998,
            0,
            0,
            0});
            this.seTiraje.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seTiraje.Properties.ReadOnly = true;
            this.seTiraje.Size = new System.Drawing.Size(77, 20);
            this.seTiraje.TabIndex = 8;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(11, 66);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(31, 13);
            this.labelControl13.TabIndex = 23;
            this.labelControl13.Text = "Tiraje:";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(158, 66);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(75, 13);
            this.labelControl12.TabIndex = 21;
            this.labelControl12.Text = "Pag. X Trabajo:";
            // 
            // sePaginasXtamano
            // 
            this.sePaginasXtamano.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sePaginasXtamano.Location = new System.Drawing.Point(239, 64);
            this.sePaginasXtamano.Name = "sePaginasXtamano";
            this.sePaginasXtamano.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.sePaginasXtamano.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sePaginasXtamano.Properties.MaxValue = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.sePaginasXtamano.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sePaginasXtamano.Size = new System.Drawing.Size(77, 20);
            this.sePaginasXtamano.TabIndex = 9;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(11, 117);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(43, 13);
            this.labelControl11.TabIndex = 19;
            this.labelControl11.Text = "Medidas:";
            // 
            // seAltoUsuario
            // 
            this.seAltoUsuario.EditValue = new decimal(new int[] {
            3,
            0,
            0,
            131072});
            this.seAltoUsuario.Location = new System.Drawing.Point(151, 114);
            this.seAltoUsuario.Name = "seAltoUsuario";
            this.seAltoUsuario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.seAltoUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seAltoUsuario.Properties.DisplayFormat.FormatString = "N2";
            this.seAltoUsuario.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seAltoUsuario.Properties.EditFormat.FormatString = "N2";
            this.seAltoUsuario.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seAltoUsuario.Properties.Mask.EditMask = "N2";
            this.seAltoUsuario.Properties.MaxValue = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.seAltoUsuario.Properties.MinValue = new decimal(new int[] {
            3,
            0,
            0,
            131072});
            this.seAltoUsuario.Size = new System.Drawing.Size(77, 20);
            this.seAltoUsuario.TabIndex = 7;
            // 
            // seAnchoUsuario
            // 
            this.seAnchoUsuario.EditValue = new decimal(new int[] {
            3,
            0,
            0,
            131072});
            this.seAnchoUsuario.Location = new System.Drawing.Point(66, 114);
            this.seAnchoUsuario.Name = "seAnchoUsuario";
            this.seAnchoUsuario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.seAnchoUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seAnchoUsuario.Properties.DisplayFormat.FormatString = "N2";
            this.seAnchoUsuario.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seAnchoUsuario.Properties.EditFormat.FormatString = "N2";
            this.seAnchoUsuario.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seAnchoUsuario.Properties.Mask.EditMask = "N2";
            this.seAnchoUsuario.Properties.MaxValue = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.seAnchoUsuario.Properties.MinValue = new decimal(new int[] {
            3,
            0,
            0,
            131072});
            this.seAnchoUsuario.Size = new System.Drawing.Size(77, 20);
            this.seAnchoUsuario.TabIndex = 6;
            // 
            // seTrabajoAlto
            // 
            this.seTrabajoAlto.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seTrabajoAlto.Location = new System.Drawing.Point(151, 145);
            this.seTrabajoAlto.Name = "seTrabajoAlto";
            this.seTrabajoAlto.Properties.Appearance.BackColor = System.Drawing.Color.CadetBlue;
            this.seTrabajoAlto.Properties.Appearance.Options.UseBackColor = true;
            this.seTrabajoAlto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.seTrabajoAlto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seTrabajoAlto.Properties.DisplayFormat.FormatString = "N2";
            this.seTrabajoAlto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seTrabajoAlto.Properties.EditFormat.FormatString = "N2";
            this.seTrabajoAlto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seTrabajoAlto.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seTrabajoAlto.Properties.Mask.EditMask = "N2";
            this.seTrabajoAlto.Properties.MaxValue = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.seTrabajoAlto.Properties.ReadOnly = true;
            this.seTrabajoAlto.Size = new System.Drawing.Size(77, 20);
            this.seTrabajoAlto.TabIndex = 5;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.labelControl10.Location = new System.Drawing.Point(7, 148);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(50, 14);
            this.labelControl10.TabIndex = 15;
            this.labelControl10.Text = "Trabajo:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl9.Location = new System.Drawing.Point(7, 170);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(52, 14);
            this.labelControl9.TabIndex = 14;
            this.labelControl9.Text = "Tamaño:";
            // 
            // seTrabajoAncho
            // 
            this.seTrabajoAncho.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seTrabajoAncho.Location = new System.Drawing.Point(66, 145);
            this.seTrabajoAncho.Name = "seTrabajoAncho";
            this.seTrabajoAncho.Properties.Appearance.BackColor = System.Drawing.Color.CadetBlue;
            this.seTrabajoAncho.Properties.Appearance.Options.UseBackColor = true;
            this.seTrabajoAncho.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.seTrabajoAncho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seTrabajoAncho.Properties.DisplayFormat.FormatString = "N2";
            this.seTrabajoAncho.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seTrabajoAncho.Properties.EditFormat.FormatString = "N2";
            this.seTrabajoAncho.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seTrabajoAncho.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seTrabajoAncho.Properties.Mask.EditMask = "N2";
            this.seTrabajoAncho.Properties.MaxValue = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.seTrabajoAncho.Properties.ReadOnly = true;
            this.seTrabajoAncho.Size = new System.Drawing.Size(77, 20);
            this.seTrabajoAncho.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.paSoporte);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 296);
            this.panel1.TabIndex = 16;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(335, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(215, 18);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Area de trabajo 1.80m X 1.20m ";
            // 
            // frmCortes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(716, 306);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmCortes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cortes";
            this.Load += new System.EventHandler(this.frmCortes_Load);
            this.Shown += new System.EventHandler(this.frmCortes_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.sePliegoAncho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePliegoAlto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTamanoAncho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTamanoAlto.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seTotalPliegos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTamanosXpliego.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTrabajosXtamano.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beGrupoMAT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTiraje.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePaginasXtamano.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAltoUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAnchoUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTrabajoAlto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTrabajoAncho.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paSoporte;
        private DevExpress.XtraEditors.SimpleButton btnCalcular;
        private DevExpress.XtraEditors.SpinEdit sePliegoAncho;
        private DevExpress.XtraEditors.SpinEdit sePliegoAlto;
        private DevExpress.XtraEditors.SpinEdit seTamanoAncho;
        private DevExpress.XtraEditors.SpinEdit seTamanoAlto;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.SpinEdit sePaginasXtamano;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.SpinEdit seAltoUsuario;
        private DevExpress.XtraEditors.SpinEdit seAnchoUsuario;
        private DevExpress.XtraEditors.SpinEdit seTrabajoAlto;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SpinEdit seTrabajoAncho;
        private DevExpress.XtraEditors.SpinEdit seTiraje;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit seTotalPliegos;
        private DevExpress.XtraEditors.SpinEdit seTamanosXpliego;
        private DevExpress.XtraEditors.SpinEdit seTrabajosXtamano;
        private DevExpress.XtraEditors.ButtonEdit beGrupoMAT;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}