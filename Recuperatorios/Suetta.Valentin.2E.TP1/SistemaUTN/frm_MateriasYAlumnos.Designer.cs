namespace SistemaUTN
{
    partial class frm_MateriasYAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MateriasYAlumnos));
            this.pct_Fondo = new System.Windows.Forms.PictureBox();
            this.lst_MateriasAsignadas = new System.Windows.Forms.ListBox();
            this.lst_AlumnosInscriptosAMaterias = new System.Windows.Forms.ListBox();
            this.lst_CorrelativasAsignadas = new System.Windows.Forms.ListBox();
            this.lst_AlumnosInscriptosACorrelativas = new System.Windows.Forms.ListBox();
            this.lbl_MateriasAsignadas = new System.Windows.Forms.Label();
            this.lbl_CorrelativasAsignadas = new System.Windows.Forms.Label();
            this.lbl_AlumnosACargo = new System.Windows.Forms.Label();
            this.lbl_AlumnosCorrelativaACargo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_Fondo
            // 
            this.pct_Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pct_Fondo.Image")));
            this.pct_Fondo.Location = new System.Drawing.Point(0, -4);
            this.pct_Fondo.Name = "pct_Fondo";
            this.pct_Fondo.Size = new System.Drawing.Size(972, 605);
            this.pct_Fondo.TabIndex = 0;
            this.pct_Fondo.TabStop = false;
            // 
            // lst_MateriasAsignadas
            // 
            this.lst_MateriasAsignadas.FormattingEnabled = true;
            this.lst_MateriasAsignadas.ItemHeight = 20;
            this.lst_MateriasAsignadas.Location = new System.Drawing.Point(29, 45);
            this.lst_MateriasAsignadas.Name = "lst_MateriasAsignadas";
            this.lst_MateriasAsignadas.Size = new System.Drawing.Size(429, 244);
            this.lst_MateriasAsignadas.TabIndex = 1;
            // 
            // lst_AlumnosInscriptosAMaterias
            // 
            this.lst_AlumnosInscriptosAMaterias.FormattingEnabled = true;
            this.lst_AlumnosInscriptosAMaterias.ItemHeight = 20;
            this.lst_AlumnosInscriptosAMaterias.Location = new System.Drawing.Point(501, 45);
            this.lst_AlumnosInscriptosAMaterias.Name = "lst_AlumnosInscriptosAMaterias";
            this.lst_AlumnosInscriptosAMaterias.Size = new System.Drawing.Size(429, 244);
            this.lst_AlumnosInscriptosAMaterias.TabIndex = 2;
            // 
            // lst_CorrelativasAsignadas
            // 
            this.lst_CorrelativasAsignadas.FormattingEnabled = true;
            this.lst_CorrelativasAsignadas.ItemHeight = 20;
            this.lst_CorrelativasAsignadas.Location = new System.Drawing.Point(29, 330);
            this.lst_CorrelativasAsignadas.Name = "lst_CorrelativasAsignadas";
            this.lst_CorrelativasAsignadas.Size = new System.Drawing.Size(429, 244);
            this.lst_CorrelativasAsignadas.TabIndex = 3;
            // 
            // lst_AlumnosInscriptosACorrelativas
            // 
            this.lst_AlumnosInscriptosACorrelativas.FormattingEnabled = true;
            this.lst_AlumnosInscriptosACorrelativas.ItemHeight = 20;
            this.lst_AlumnosInscriptosACorrelativas.Location = new System.Drawing.Point(501, 330);
            this.lst_AlumnosInscriptosACorrelativas.Name = "lst_AlumnosInscriptosACorrelativas";
            this.lst_AlumnosInscriptosACorrelativas.Size = new System.Drawing.Size(429, 244);
            this.lst_AlumnosInscriptosACorrelativas.TabIndex = 4;
            // 
            // lbl_MateriasAsignadas
            // 
            this.lbl_MateriasAsignadas.AutoSize = true;
            this.lbl_MateriasAsignadas.Location = new System.Drawing.Point(187, 22);
            this.lbl_MateriasAsignadas.Name = "lbl_MateriasAsignadas";
            this.lbl_MateriasAsignadas.Size = new System.Drawing.Size(136, 20);
            this.lbl_MateriasAsignadas.TabIndex = 5;
            this.lbl_MateriasAsignadas.Text = "Materias asignadas";
            // 
            // lbl_CorrelativasAsignadas
            // 
            this.lbl_CorrelativasAsignadas.AutoSize = true;
            this.lbl_CorrelativasAsignadas.Location = new System.Drawing.Point(178, 307);
            this.lbl_CorrelativasAsignadas.Name = "lbl_CorrelativasAsignadas";
            this.lbl_CorrelativasAsignadas.Size = new System.Drawing.Size(157, 20);
            this.lbl_CorrelativasAsignadas.TabIndex = 6;
            this.lbl_CorrelativasAsignadas.Text = "Correlativas asignadas";
            // 
            // lbl_AlumnosACargo
            // 
            this.lbl_AlumnosACargo.AutoSize = true;
            this.lbl_AlumnosACargo.Location = new System.Drawing.Point(663, 22);
            this.lbl_AlumnosACargo.Name = "lbl_AlumnosACargo";
            this.lbl_AlumnosACargo.Size = new System.Drawing.Size(121, 20);
            this.lbl_AlumnosACargo.TabIndex = 7;
            this.lbl_AlumnosACargo.Text = "Alumnos a cargo";
            // 
            // lbl_AlumnosCorrelativaACargo
            // 
            this.lbl_AlumnosCorrelativaACargo.AutoSize = true;
            this.lbl_AlumnosCorrelativaACargo.Location = new System.Drawing.Point(663, 307);
            this.lbl_AlumnosCorrelativaACargo.Name = "lbl_AlumnosCorrelativaACargo";
            this.lbl_AlumnosCorrelativaACargo.Size = new System.Drawing.Size(121, 20);
            this.lbl_AlumnosCorrelativaACargo.TabIndex = 8;
            this.lbl_AlumnosCorrelativaACargo.Text = "Alumnos a cargo";
            // 
            // frm_MateriasYAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 598);
            this.Controls.Add(this.lbl_AlumnosCorrelativaACargo);
            this.Controls.Add(this.lbl_AlumnosACargo);
            this.Controls.Add(this.lbl_CorrelativasAsignadas);
            this.Controls.Add(this.lbl_MateriasAsignadas);
            this.Controls.Add(this.lst_AlumnosInscriptosACorrelativas);
            this.Controls.Add(this.lst_CorrelativasAsignadas);
            this.Controls.Add(this.lst_AlumnosInscriptosAMaterias);
            this.Controls.Add(this.lst_MateriasAsignadas);
            this.Controls.Add(this.pct_Fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_MateriasYAlumnos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materias y alumnos a cargo";
            this.Load += new System.EventHandler(this.frm_MateriasYAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pct_Fondo;
        private ListBox lst_MateriasAsignadas;
        private ListBox lst_AlumnosInscriptosAMaterias;
        private ListBox lst_CorrelativasAsignadas;
        private ListBox lst_AlumnosInscriptosACorrelativas;
        private Label lbl_MateriasAsignadas;
        private Label lbl_CorrelativasAsignadas;
        private Label lbl_AlumnosACargo;
        private Label lbl_AlumnosCorrelativaACargo;
    }
}