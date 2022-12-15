namespace SistemaUTN
{
    partial class frm_IngresarNotaCorrelativa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_IngresarNotaCorrelativa));
            this.pct_Fondo = new System.Windows.Forms.PictureBox();
            this.lbl_Parciales = new System.Windows.Forms.Label();
            this.lst_ParcialesDisponibles = new System.Windows.Forms.ListBox();
            this.lbl_TipoDeParcial = new System.Windows.Forms.Label();
            this.txt_TipoDeParcial = new System.Windows.Forms.TextBox();
            this.lbl_Correlativa = new System.Windows.Forms.Label();
            this.txt_Correlativa = new System.Windows.Forms.TextBox();
            this.lbl_NotaParcial = new System.Windows.Forms.Label();
            this.txt_Nota = new System.Windows.Forms.TextBox();
            this.btn_IngresarNota = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_Fondo
            // 
            this.pct_Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pct_Fondo.Image")));
            this.pct_Fondo.Location = new System.Drawing.Point(0, 0);
            this.pct_Fondo.Name = "pct_Fondo";
            this.pct_Fondo.Size = new System.Drawing.Size(965, 483);
            this.pct_Fondo.TabIndex = 0;
            this.pct_Fondo.TabStop = false;
            // 
            // lbl_Parciales
            // 
            this.lbl_Parciales.AutoSize = true;
            this.lbl_Parciales.Location = new System.Drawing.Point(236, 19);
            this.lbl_Parciales.Name = "lbl_Parciales";
            this.lbl_Parciales.Size = new System.Drawing.Size(146, 20);
            this.lbl_Parciales.TabIndex = 3;
            this.lbl_Parciales.Text = "Parciales disponibles";
            // 
            // lst_ParcialesDisponibles
            // 
            this.lst_ParcialesDisponibles.FormattingEnabled = true;
            this.lst_ParcialesDisponibles.ItemHeight = 20;
            this.lst_ParcialesDisponibles.Location = new System.Drawing.Point(12, 42);
            this.lst_ParcialesDisponibles.Name = "lst_ParcialesDisponibles";
            this.lst_ParcialesDisponibles.Size = new System.Drawing.Size(593, 424);
            this.lst_ParcialesDisponibles.TabIndex = 4;
            this.lst_ParcialesDisponibles.DoubleClick += new System.EventHandler(this.lst_ParcialesDisponibles_DoubleClick);
            // 
            // lbl_TipoDeParcial
            // 
            this.lbl_TipoDeParcial.AutoSize = true;
            this.lbl_TipoDeParcial.Location = new System.Drawing.Point(723, 112);
            this.lbl_TipoDeParcial.Name = "lbl_TipoDeParcial";
            this.lbl_TipoDeParcial.Size = new System.Drawing.Size(101, 20);
            this.lbl_TipoDeParcial.TabIndex = 5;
            this.lbl_TipoDeParcial.Text = "TipoDeParcial";
            // 
            // txt_TipoDeParcial
            // 
            this.txt_TipoDeParcial.Location = new System.Drawing.Point(664, 135);
            this.txt_TipoDeParcial.Name = "txt_TipoDeParcial";
            this.txt_TipoDeParcial.ReadOnly = true;
            this.txt_TipoDeParcial.Size = new System.Drawing.Size(227, 27);
            this.txt_TipoDeParcial.TabIndex = 6;
            // 
            // lbl_Correlativa
            // 
            this.lbl_Correlativa.AutoSize = true;
            this.lbl_Correlativa.Location = new System.Drawing.Point(723, 192);
            this.lbl_Correlativa.Name = "lbl_Correlativa";
            this.lbl_Correlativa.Size = new System.Drawing.Size(81, 20);
            this.lbl_Correlativa.TabIndex = 7;
            this.lbl_Correlativa.Text = "Correlativa";
            // 
            // txt_Correlativa
            // 
            this.txt_Correlativa.Location = new System.Drawing.Point(664, 215);
            this.txt_Correlativa.Name = "txt_Correlativa";
            this.txt_Correlativa.ReadOnly = true;
            this.txt_Correlativa.Size = new System.Drawing.Size(227, 27);
            this.txt_Correlativa.TabIndex = 8;
            // 
            // lbl_NotaParcial
            // 
            this.lbl_NotaParcial.AutoSize = true;
            this.lbl_NotaParcial.Location = new System.Drawing.Point(749, 263);
            this.lbl_NotaParcial.Name = "lbl_NotaParcial";
            this.lbl_NotaParcial.Size = new System.Drawing.Size(42, 20);
            this.lbl_NotaParcial.TabIndex = 9;
            this.lbl_NotaParcial.Text = "Nota";
            // 
            // txt_Nota
            // 
            this.txt_Nota.Location = new System.Drawing.Point(664, 286);
            this.txt_Nota.Name = "txt_Nota";
            this.txt_Nota.Size = new System.Drawing.Size(227, 27);
            this.txt_Nota.TabIndex = 10;
            // 
            // btn_IngresarNota
            // 
            this.btn_IngresarNota.BackColor = System.Drawing.Color.Tan;
            this.btn_IngresarNota.FlatAppearance.BorderSize = 0;
            this.btn_IngresarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IngresarNota.Location = new System.Drawing.Point(664, 319);
            this.btn_IngresarNota.Name = "btn_IngresarNota";
            this.btn_IngresarNota.Size = new System.Drawing.Size(227, 29);
            this.btn_IngresarNota.TabIndex = 11;
            this.btn_IngresarNota.Text = "Ingresar nota";
            this.btn_IngresarNota.UseVisualStyleBackColor = false;
            this.btn_IngresarNota.Click += new System.EventHandler(this.btn_IngresarNota_Click);
            // 
            // frm_IngresarNotaCorrelativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 480);
            this.Controls.Add(this.btn_IngresarNota);
            this.Controls.Add(this.txt_Nota);
            this.Controls.Add(this.lbl_NotaParcial);
            this.Controls.Add(this.txt_Correlativa);
            this.Controls.Add(this.lbl_Correlativa);
            this.Controls.Add(this.txt_TipoDeParcial);
            this.Controls.Add(this.lbl_TipoDeParcial);
            this.Controls.Add(this.lst_ParcialesDisponibles);
            this.Controls.Add(this.lbl_Parciales);
            this.Controls.Add(this.pct_Fondo);
            this.Name = "frm_IngresarNotaCorrelativa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar nota";
            this.Load += new System.EventHandler(this.frm_IngresarNotaCorrelativa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pct_Fondo;
        private Label lbl_Parciales;
        private ListBox lst_ParcialesDisponibles;
        private Label lbl_TipoDeParcial;
        private TextBox txt_TipoDeParcial;
        private Label lbl_Correlativa;
        private TextBox txt_Correlativa;
        private Label lbl_NotaParcial;
        private TextBox txt_Nota;
        private Button btn_IngresarNota;
    }
}