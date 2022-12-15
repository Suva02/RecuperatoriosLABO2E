namespace SistemaUTN
{
    partial class frm_CalcularNotaPromedio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CalcularNotaPromedio));
            this.pct_Fondo = new System.Windows.Forms.PictureBox();
            this.lst_Materias = new System.Windows.Forms.ListBox();
            this.lst_Correlativas = new System.Windows.Forms.ListBox();
            this.lbl_SeleccionarMateria = new System.Windows.Forms.Label();
            this.lbl_SeleccionarCorrelativa = new System.Windows.Forms.Label();
            this.btn_CalcularMateria = new System.Windows.Forms.Button();
            this.btn_CalcularNotaEnCorrelativa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_Fondo
            // 
            this.pct_Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pct_Fondo.Image")));
            this.pct_Fondo.Location = new System.Drawing.Point(-1, -1);
            this.pct_Fondo.Name = "pct_Fondo";
            this.pct_Fondo.Size = new System.Drawing.Size(803, 498);
            this.pct_Fondo.TabIndex = 0;
            this.pct_Fondo.TabStop = false;
            // 
            // lst_Materias
            // 
            this.lst_Materias.FormattingEnabled = true;
            this.lst_Materias.ItemHeight = 20;
            this.lst_Materias.Location = new System.Drawing.Point(12, 37);
            this.lst_Materias.Name = "lst_Materias";
            this.lst_Materias.Size = new System.Drawing.Size(749, 184);
            this.lst_Materias.TabIndex = 1;
            this.lst_Materias.DoubleClick += new System.EventHandler(this.lst_Materias_DoubleClick);
            // 
            // lst_Correlativas
            // 
            this.lst_Correlativas.FormattingEnabled = true;
            this.lst_Correlativas.ItemHeight = 20;
            this.lst_Correlativas.Location = new System.Drawing.Point(12, 254);
            this.lst_Correlativas.Name = "lst_Correlativas";
            this.lst_Correlativas.Size = new System.Drawing.Size(749, 184);
            this.lst_Correlativas.TabIndex = 2;
            this.lst_Correlativas.DoubleClick += new System.EventHandler(this.lst_Correlativas_DoubleClick);
            // 
            // lbl_SeleccionarMateria
            // 
            this.lbl_SeleccionarMateria.AutoSize = true;
            this.lbl_SeleccionarMateria.Location = new System.Drawing.Point(316, 14);
            this.lbl_SeleccionarMateria.Name = "lbl_SeleccionarMateria";
            this.lbl_SeleccionarMateria.Size = new System.Drawing.Size(163, 20);
            this.lbl_SeleccionarMateria.TabIndex = 3;
            this.lbl_SeleccionarMateria.Text = "Seleccione una materia";
            // 
            // lbl_SeleccionarCorrelativa
            // 
            this.lbl_SeleccionarCorrelativa.AutoSize = true;
            this.lbl_SeleccionarCorrelativa.Location = new System.Drawing.Point(316, 231);
            this.lbl_SeleccionarCorrelativa.Name = "lbl_SeleccionarCorrelativa";
            this.lbl_SeleccionarCorrelativa.Size = new System.Drawing.Size(182, 20);
            this.lbl_SeleccionarCorrelativa.TabIndex = 4;
            this.lbl_SeleccionarCorrelativa.Text = "Seleccione una correlativa";
            // 
            // btn_CalcularMateria
            // 
            this.btn_CalcularMateria.Location = new System.Drawing.Point(157, 453);
            this.btn_CalcularMateria.Name = "btn_CalcularMateria";
            this.btn_CalcularMateria.Size = new System.Drawing.Size(204, 29);
            this.btn_CalcularMateria.TabIndex = 5;
            this.btn_CalcularMateria.Text = "Calcular nota en materia";
            this.btn_CalcularMateria.UseVisualStyleBackColor = true;
            this.btn_CalcularMateria.Click += new System.EventHandler(this.btn_CalcularMateria_Click);
            // 
            // btn_CalcularNotaEnCorrelativa
            // 
            this.btn_CalcularNotaEnCorrelativa.Location = new System.Drawing.Point(441, 453);
            this.btn_CalcularNotaEnCorrelativa.Name = "btn_CalcularNotaEnCorrelativa";
            this.btn_CalcularNotaEnCorrelativa.Size = new System.Drawing.Size(205, 29);
            this.btn_CalcularNotaEnCorrelativa.TabIndex = 6;
            this.btn_CalcularNotaEnCorrelativa.Text = "Calcular nota en correlativa";
            this.btn_CalcularNotaEnCorrelativa.UseVisualStyleBackColor = true;
            this.btn_CalcularNotaEnCorrelativa.Click += new System.EventHandler(this.btn_CalcularNotaEnCorrelativa_Click);
            // 
            // frm_CalcularNotaPromedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.btn_CalcularNotaEnCorrelativa);
            this.Controls.Add(this.btn_CalcularMateria);
            this.Controls.Add(this.lbl_SeleccionarCorrelativa);
            this.Controls.Add(this.lbl_SeleccionarMateria);
            this.Controls.Add(this.lst_Correlativas);
            this.Controls.Add(this.lst_Materias);
            this.Controls.Add(this.pct_Fondo);
            this.Name = "frm_CalcularNotaPromedio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular nota";
            this.Load += new System.EventHandler(this.frm_CalcularNotaPromedio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pct_Fondo;
        private ListBox lst_Materias;
        private ListBox lst_Correlativas;
        private Label lbl_SeleccionarMateria;
        private Label lbl_SeleccionarCorrelativa;
        private Button btn_CalcularMateria;
        private Button btn_CalcularNotaEnCorrelativa;
    }
}