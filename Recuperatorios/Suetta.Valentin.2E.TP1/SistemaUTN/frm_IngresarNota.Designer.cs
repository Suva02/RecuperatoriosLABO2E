namespace SistemaUTN
{
    partial class frm_IngresarNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_IngresarNota));
            this.pct_Fondo = new System.Windows.Forms.PictureBox();
            this.lst_ParcialesDisponibles = new System.Windows.Forms.ListBox();
            this.lbl_Parciales = new System.Windows.Forms.Label();
            this.lbl_TipoDeParcial = new System.Windows.Forms.Label();
            this.txt_TipoDeParcial = new System.Windows.Forms.TextBox();
            this.lbl_lblMateria = new System.Windows.Forms.Label();
            this.txt_Materia = new System.Windows.Forms.TextBox();
            this.lbl_NotaParcial = new System.Windows.Forms.Label();
            this.txt_Nota = new System.Windows.Forms.TextBox();
            this.btn_IngresarNota = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_Fondo
            // 
            this.pct_Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pct_Fondo.Image")));
            this.pct_Fondo.Location = new System.Drawing.Point(-3, -1);
            this.pct_Fondo.Name = "pct_Fondo";
            this.pct_Fondo.Size = new System.Drawing.Size(967, 483);
            this.pct_Fondo.TabIndex = 0;
            this.pct_Fondo.TabStop = false;
            // 
            // lst_ParcialesDisponibles
            // 
            this.lst_ParcialesDisponibles.FormattingEnabled = true;
            this.lst_ParcialesDisponibles.ItemHeight = 20;
            this.lst_ParcialesDisponibles.Location = new System.Drawing.Point(12, 44);
            this.lst_ParcialesDisponibles.Name = "lst_ParcialesDisponibles";
            this.lst_ParcialesDisponibles.Size = new System.Drawing.Size(593, 424);
            this.lst_ParcialesDisponibles.TabIndex = 1;
            this.lst_ParcialesDisponibles.DoubleClick += new System.EventHandler(this.lst_ParcialesDisponibles_DoubleClick);
            // 
            // lbl_Parciales
            // 
            this.lbl_Parciales.AutoSize = true;
            this.lbl_Parciales.Location = new System.Drawing.Point(234, 21);
            this.lbl_Parciales.Name = "lbl_Parciales";
            this.lbl_Parciales.Size = new System.Drawing.Size(146, 20);
            this.lbl_Parciales.TabIndex = 2;
            this.lbl_Parciales.Text = "Parciales disponibles";
            // 
            // lbl_TipoDeParcial
            // 
            this.lbl_TipoDeParcial.AutoSize = true;
            this.lbl_TipoDeParcial.Location = new System.Drawing.Point(737, 91);
            this.lbl_TipoDeParcial.Name = "lbl_TipoDeParcial";
            this.lbl_TipoDeParcial.Size = new System.Drawing.Size(101, 20);
            this.lbl_TipoDeParcial.TabIndex = 3;
            this.lbl_TipoDeParcial.Text = "TipoDeParcial";
            // 
            // txt_TipoDeParcial
            // 
            this.txt_TipoDeParcial.Location = new System.Drawing.Point(668, 114);
            this.txt_TipoDeParcial.Name = "txt_TipoDeParcial";
            this.txt_TipoDeParcial.ReadOnly = true;
            this.txt_TipoDeParcial.Size = new System.Drawing.Size(227, 27);
            this.txt_TipoDeParcial.TabIndex = 4;
            // 
            // lbl_lblMateria
            // 
            this.lbl_lblMateria.AutoSize = true;
            this.lbl_lblMateria.Location = new System.Drawing.Point(747, 177);
            this.lbl_lblMateria.Name = "lbl_lblMateria";
            this.lbl_lblMateria.Size = new System.Drawing.Size(60, 20);
            this.lbl_lblMateria.TabIndex = 5;
            this.lbl_lblMateria.Text = "Materia";
            // 
            // txt_Materia
            // 
            this.txt_Materia.Location = new System.Drawing.Point(668, 200);
            this.txt_Materia.Name = "txt_Materia";
            this.txt_Materia.ReadOnly = true;
            this.txt_Materia.Size = new System.Drawing.Size(227, 27);
            this.txt_Materia.TabIndex = 6;
            // 
            // lbl_NotaParcial
            // 
            this.lbl_NotaParcial.AutoSize = true;
            this.lbl_NotaParcial.Location = new System.Drawing.Point(765, 257);
            this.lbl_NotaParcial.Name = "lbl_NotaParcial";
            this.lbl_NotaParcial.Size = new System.Drawing.Size(42, 20);
            this.lbl_NotaParcial.TabIndex = 7;
            this.lbl_NotaParcial.Text = "Nota";
            // 
            // txt_Nota
            // 
            this.txt_Nota.Location = new System.Drawing.Point(668, 280);
            this.txt_Nota.Name = "txt_Nota";
            this.txt_Nota.Size = new System.Drawing.Size(227, 27);
            this.txt_Nota.TabIndex = 8;
            // 
            // btn_IngresarNota
            // 
            this.btn_IngresarNota.BackColor = System.Drawing.Color.Tan;
            this.btn_IngresarNota.FlatAppearance.BorderSize = 0;
            this.btn_IngresarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IngresarNota.Location = new System.Drawing.Point(668, 313);
            this.btn_IngresarNota.Name = "btn_IngresarNota";
            this.btn_IngresarNota.Size = new System.Drawing.Size(227, 29);
            this.btn_IngresarNota.TabIndex = 9;
            this.btn_IngresarNota.Text = "Ingresar nota";
            this.btn_IngresarNota.UseVisualStyleBackColor = false;
            this.btn_IngresarNota.Click += new System.EventHandler(this.btn_IngresarNota_Click);
            // 
            // frm_IngresarNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 480);
            this.Controls.Add(this.btn_IngresarNota);
            this.Controls.Add(this.txt_Nota);
            this.Controls.Add(this.lbl_NotaParcial);
            this.Controls.Add(this.txt_Materia);
            this.Controls.Add(this.lbl_lblMateria);
            this.Controls.Add(this.txt_TipoDeParcial);
            this.Controls.Add(this.lbl_TipoDeParcial);
            this.Controls.Add(this.lbl_Parciales);
            this.Controls.Add(this.lst_ParcialesDisponibles);
            this.Controls.Add(this.pct_Fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_IngresarNota";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar notas";
            this.Load += new System.EventHandler(this.frm_IngresarNota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pct_Fondo;
        private ListBox lst_ParcialesDisponibles;
        private Label lbl_Parciales;
        private Label lbl_TipoDeParcial;
        private TextBox txt_TipoDeParcial;
        private Label lbl_lblMateria;
        private TextBox txt_Materia;
        private Label lbl_NotaParcial;
        private TextBox txt_Nota;
        private Button btn_IngresarNota;
    }
}