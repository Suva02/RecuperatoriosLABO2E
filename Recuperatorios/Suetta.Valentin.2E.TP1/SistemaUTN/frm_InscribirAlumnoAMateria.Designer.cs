namespace SistemaUTN
{
    partial class frm_InscribirAlumnoAMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_InscribirAlumnoAMateria));
            this.pct_Fondo = new System.Windows.Forms.PictureBox();
            this.lst_MateriasDisponibles = new System.Windows.Forms.ListBox();
            this.lst_CorrelativasDisponibles = new System.Windows.Forms.ListBox();
            this.lbl_Materias = new System.Windows.Forms.Label();
            this.lbl_CorrelativasDisponibles = new System.Windows.Forms.Label();
            this.lst_AlumnosDisponibles = new System.Windows.Forms.ListBox();
            this.lbl_Alumnos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_Fondo
            // 
            this.pct_Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pct_Fondo.Image")));
            this.pct_Fondo.Location = new System.Drawing.Point(0, 0);
            this.pct_Fondo.Name = "pct_Fondo";
            this.pct_Fondo.Size = new System.Drawing.Size(1103, 692);
            this.pct_Fondo.TabIndex = 0;
            this.pct_Fondo.TabStop = false;
            // 
            // lst_MateriasDisponibles
            // 
            this.lst_MateriasDisponibles.FormattingEnabled = true;
            this.lst_MateriasDisponibles.ItemHeight = 20;
            this.lst_MateriasDisponibles.Location = new System.Drawing.Point(12, 335);
            this.lst_MateriasDisponibles.Name = "lst_MateriasDisponibles";
            this.lst_MateriasDisponibles.Size = new System.Drawing.Size(513, 344);
            this.lst_MateriasDisponibles.TabIndex = 2;
            this.lst_MateriasDisponibles.DoubleClick += new System.EventHandler(this.lst_MateriasDisponibles_DoubleClick);
            // 
            // lst_CorrelativasDisponibles
            // 
            this.lst_CorrelativasDisponibles.FormattingEnabled = true;
            this.lst_CorrelativasDisponibles.ItemHeight = 20;
            this.lst_CorrelativasDisponibles.Location = new System.Drawing.Point(531, 335);
            this.lst_CorrelativasDisponibles.Name = "lst_CorrelativasDisponibles";
            this.lst_CorrelativasDisponibles.Size = new System.Drawing.Size(548, 344);
            this.lst_CorrelativasDisponibles.TabIndex = 3;
            // 
            // lbl_Materias
            // 
            this.lbl_Materias.AutoSize = true;
            this.lbl_Materias.Location = new System.Drawing.Point(164, 301);
            this.lbl_Materias.Name = "lbl_Materias";
            this.lbl_Materias.Size = new System.Drawing.Size(146, 20);
            this.lbl_Materias.TabIndex = 4;
            this.lbl_Materias.Text = "Materias disponibles";
            // 
            // lbl_CorrelativasDisponibles
            // 
            this.lbl_CorrelativasDisponibles.AutoSize = true;
            this.lbl_CorrelativasDisponibles.Location = new System.Drawing.Point(713, 301);
            this.lbl_CorrelativasDisponibles.Name = "lbl_CorrelativasDisponibles";
            this.lbl_CorrelativasDisponibles.Size = new System.Drawing.Size(167, 20);
            this.lbl_CorrelativasDisponibles.TabIndex = 5;
            this.lbl_CorrelativasDisponibles.Text = "Correlativas disponibles";
            // 
            // lst_AlumnosDisponibles
            // 
            this.lst_AlumnosDisponibles.FormattingEnabled = true;
            this.lst_AlumnosDisponibles.ItemHeight = 20;
            this.lst_AlumnosDisponibles.Location = new System.Drawing.Point(12, 42);
            this.lst_AlumnosDisponibles.Name = "lst_AlumnosDisponibles";
            this.lst_AlumnosDisponibles.Size = new System.Drawing.Size(1067, 244);
            this.lst_AlumnosDisponibles.TabIndex = 6;
            this.lst_AlumnosDisponibles.DoubleClick += new System.EventHandler(this.lst_AlumnosDisponibles_DoubleClick);
            // 
            // lbl_Alumnos
            // 
            this.lbl_Alumnos.AutoSize = true;
            this.lbl_Alumnos.Location = new System.Drawing.Point(502, 19);
            this.lbl_Alumnos.Name = "lbl_Alumnos";
            this.lbl_Alumnos.Size = new System.Drawing.Size(67, 20);
            this.lbl_Alumnos.TabIndex = 7;
            this.lbl_Alumnos.Text = "Alumnos";
            // 
            // frm_InscribirAlumnoAMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 691);
            this.Controls.Add(this.lbl_Alumnos);
            this.Controls.Add(this.lst_AlumnosDisponibles);
            this.Controls.Add(this.lbl_CorrelativasDisponibles);
            this.Controls.Add(this.lbl_Materias);
            this.Controls.Add(this.lst_CorrelativasDisponibles);
            this.Controls.Add(this.lst_MateriasDisponibles);
            this.Controls.Add(this.pct_Fondo);
            this.MaximizeBox = false;
            this.Name = "frm_InscribirAlumnoAMateria";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscribir alumno";
            this.Load += new System.EventHandler(this.frm_InscribirAlumnoAMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pct_Fondo;
        private ListBox lst_MateriasDisponibles;
        private ListBox lst_CorrelativasDisponibles;
        private Label lbl_Materias;
        private Label lbl_CorrelativasDisponibles;
        private ListBox lst_AlumnosDisponibles;
        private Label lbl_Alumnos;
    }
}