namespace SistemaUTN
{
    partial class frm_AsistenciaEnCorrelativa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AsistenciaEnCorrelativa));
            this.pct_Fondo = new System.Windows.Forms.PictureBox();
            this.lst_InscripcionesACorrelativas = new System.Windows.Forms.ListBox();
            this.lbl_Correlativa = new System.Windows.Forms.Label();
            this.txt_NombreMateria = new System.Windows.Forms.TextBox();
            this.lbl_Asistencia = new System.Windows.Forms.Label();
            this.txt_AsistenciaIngresada = new System.Windows.Forms.TextBox();
            this.btn_DarAsistencia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_Fondo
            // 
            this.pct_Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pct_Fondo.Image")));
            this.pct_Fondo.Location = new System.Drawing.Point(-2, -4);
            this.pct_Fondo.Name = "pct_Fondo";
            this.pct_Fondo.Size = new System.Drawing.Size(1170, 304);
            this.pct_Fondo.TabIndex = 1;
            this.pct_Fondo.TabStop = false;
            // 
            // lst_InscripcionesACorrelativas
            // 
            this.lst_InscripcionesACorrelativas.FormattingEnabled = true;
            this.lst_InscripcionesACorrelativas.ItemHeight = 20;
            this.lst_InscripcionesACorrelativas.Location = new System.Drawing.Point(12, 20);
            this.lst_InscripcionesACorrelativas.Name = "lst_InscripcionesACorrelativas";
            this.lst_InscripcionesACorrelativas.Size = new System.Drawing.Size(795, 264);
            this.lst_InscripcionesACorrelativas.TabIndex = 2;
            this.lst_InscripcionesACorrelativas.DoubleClick += new System.EventHandler(this.lst_InscripcionesACorrelativas_DoubleClick);
            // 
            // lbl_Correlativa
            // 
            this.lbl_Correlativa.AutoSize = true;
            this.lbl_Correlativa.Location = new System.Drawing.Point(838, 45);
            this.lbl_Correlativa.Name = "lbl_Correlativa";
            this.lbl_Correlativa.Size = new System.Drawing.Size(81, 20);
            this.lbl_Correlativa.TabIndex = 3;
            this.lbl_Correlativa.Text = "Correlativa";
            // 
            // txt_NombreMateria
            // 
            this.txt_NombreMateria.Location = new System.Drawing.Point(931, 42);
            this.txt_NombreMateria.Name = "txt_NombreMateria";
            this.txt_NombreMateria.ReadOnly = true;
            this.txt_NombreMateria.Size = new System.Drawing.Size(208, 27);
            this.txt_NombreMateria.TabIndex = 4;
            // 
            // lbl_Asistencia
            // 
            this.lbl_Asistencia.AutoSize = true;
            this.lbl_Asistencia.Location = new System.Drawing.Point(838, 115);
            this.lbl_Asistencia.Name = "lbl_Asistencia";
            this.lbl_Asistencia.Size = new System.Drawing.Size(75, 20);
            this.lbl_Asistencia.TabIndex = 5;
            this.lbl_Asistencia.Text = "Asistencia";
            // 
            // txt_AsistenciaIngresada
            // 
            this.txt_AsistenciaIngresada.Location = new System.Drawing.Point(931, 108);
            this.txt_AsistenciaIngresada.Name = "txt_AsistenciaIngresada";
            this.txt_AsistenciaIngresada.PlaceholderText = "Presente/Ausente";
            this.txt_AsistenciaIngresada.Size = new System.Drawing.Size(208, 27);
            this.txt_AsistenciaIngresada.TabIndex = 6;
            // 
            // btn_DarAsistencia
            // 
            this.btn_DarAsistencia.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_DarAsistencia.FlatAppearance.BorderSize = 0;
            this.btn_DarAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DarAsistencia.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DarAsistencia.Location = new System.Drawing.Point(838, 159);
            this.btn_DarAsistencia.Name = "btn_DarAsistencia";
            this.btn_DarAsistencia.Size = new System.Drawing.Size(302, 29);
            this.btn_DarAsistencia.TabIndex = 7;
            this.btn_DarAsistencia.Text = "Dar asistencia";
            this.btn_DarAsistencia.UseVisualStyleBackColor = false;
            this.btn_DarAsistencia.Click += new System.EventHandler(this.btn_DarAsistencia_Click);
            // 
            // frm_AsistenciaEnCorrelativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 296);
            this.Controls.Add(this.btn_DarAsistencia);
            this.Controls.Add(this.txt_AsistenciaIngresada);
            this.Controls.Add(this.lbl_Asistencia);
            this.Controls.Add(this.txt_NombreMateria);
            this.Controls.Add(this.lbl_Correlativa);
            this.Controls.Add(this.lst_InscripcionesACorrelativas);
            this.Controls.Add(this.pct_Fondo);
            this.Name = "frm_AsistenciaEnCorrelativa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistencia";
            this.Load += new System.EventHandler(this.frm_AsistenciaEnCorrelativa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pct_Fondo;
        private ListBox lst_InscripcionesACorrelativas;
        private Label lbl_Correlativa;
        private TextBox txt_NombreMateria;
        private Label lbl_Asistencia;
        private TextBox txt_AsistenciaIngresada;
        private Button btn_DarAsistencia;
    }
}