namespace SistemaUTN
{
    partial class frm_AsistenciaEnMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AsistenciaEnMateria));
            this.pct_Fondo = new System.Windows.Forms.PictureBox();
            this.lst_InscripcionesAMaterias = new System.Windows.Forms.ListBox();
            this.lbl_Materia = new System.Windows.Forms.Label();
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
            this.pct_Fondo.Location = new System.Drawing.Point(-3, -2);
            this.pct_Fondo.Name = "pct_Fondo";
            this.pct_Fondo.Size = new System.Drawing.Size(805, 304);
            this.pct_Fondo.TabIndex = 0;
            this.pct_Fondo.TabStop = false;
            // 
            // lst_InscripcionesAMaterias
            // 
            this.lst_InscripcionesAMaterias.FormattingEnabled = true;
            this.lst_InscripcionesAMaterias.ItemHeight = 20;
            this.lst_InscripcionesAMaterias.Location = new System.Drawing.Point(12, 12);
            this.lst_InscripcionesAMaterias.Name = "lst_InscripcionesAMaterias";
            this.lst_InscripcionesAMaterias.Size = new System.Drawing.Size(466, 264);
            this.lst_InscripcionesAMaterias.TabIndex = 1;
            this.lst_InscripcionesAMaterias.DoubleClick += new System.EventHandler(this.lst_InscripcionesAMaterias_DoubleClick);
            // 
            // lbl_Materia
            // 
            this.lbl_Materia.AutoSize = true;
            this.lbl_Materia.Location = new System.Drawing.Point(498, 42);
            this.lbl_Materia.Name = "lbl_Materia";
            this.lbl_Materia.Size = new System.Drawing.Size(60, 20);
            this.lbl_Materia.TabIndex = 2;
            this.lbl_Materia.Text = "Materia";
            // 
            // txt_NombreMateria
            // 
            this.txt_NombreMateria.Location = new System.Drawing.Point(580, 42);
            this.txt_NombreMateria.Name = "txt_NombreMateria";
            this.txt_NombreMateria.ReadOnly = true;
            this.txt_NombreMateria.Size = new System.Drawing.Size(208, 27);
            this.txt_NombreMateria.TabIndex = 3;
            // 
            // lbl_Asistencia
            // 
            this.lbl_Asistencia.AutoSize = true;
            this.lbl_Asistencia.Location = new System.Drawing.Point(498, 119);
            this.lbl_Asistencia.Name = "lbl_Asistencia";
            this.lbl_Asistencia.Size = new System.Drawing.Size(75, 20);
            this.lbl_Asistencia.TabIndex = 4;
            this.lbl_Asistencia.Text = "Asistencia";
            // 
            // txt_AsistenciaIngresada
            // 
            this.txt_AsistenciaIngresada.Location = new System.Drawing.Point(580, 119);
            this.txt_AsistenciaIngresada.Name = "txt_AsistenciaIngresada";
            this.txt_AsistenciaIngresada.PlaceholderText = "Presente/Ausente";
            this.txt_AsistenciaIngresada.Size = new System.Drawing.Size(208, 27);
            this.txt_AsistenciaIngresada.TabIndex = 5;
            // 
            // btn_DarAsistencia
            // 
            this.btn_DarAsistencia.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_DarAsistencia.FlatAppearance.BorderSize = 0;
            this.btn_DarAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DarAsistencia.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DarAsistencia.Location = new System.Drawing.Point(498, 190);
            this.btn_DarAsistencia.Name = "btn_DarAsistencia";
            this.btn_DarAsistencia.Size = new System.Drawing.Size(290, 29);
            this.btn_DarAsistencia.TabIndex = 6;
            this.btn_DarAsistencia.Text = "Dar asistencia";
            this.btn_DarAsistencia.UseVisualStyleBackColor = false;
            this.btn_DarAsistencia.Click += new System.EventHandler(this.btn_DarAsistencia_Click);
            // 
            // frm_AsistenciaEnMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 296);
            this.Controls.Add(this.btn_DarAsistencia);
            this.Controls.Add(this.txt_AsistenciaIngresada);
            this.Controls.Add(this.lbl_Asistencia);
            this.Controls.Add(this.txt_NombreMateria);
            this.Controls.Add(this.lbl_Materia);
            this.Controls.Add(this.lst_InscripcionesAMaterias);
            this.Controls.Add(this.pct_Fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_AsistenciaEnMateria";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistencia";
            this.Load += new System.EventHandler(this.frm_AsistenciaEnMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pct_Fondo;
        private ListBox lst_InscripcionesAMaterias;
        private Label lbl_Materia;
        private TextBox txt_NombreMateria;
        private Label lbl_Asistencia;
        private TextBox txt_AsistenciaIngresada;
        private Button btn_DarAsistencia;
    }
}