namespace SistemaUTN
{
    partial class frm_CalcularAlumnosPorProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CalcularAlumnosPorProfesor));
            this.pct_Fondo = new System.Windows.Forms.PictureBox();
            this.lst_MateriasAsignadas = new System.Windows.Forms.ListBox();
            this.lst_AlumnosInscriptosAMaterias = new System.Windows.Forms.ListBox();
            this.lst_CorrelativasAsignadas = new System.Windows.Forms.ListBox();
            this.lst_AlumnosInscriptosACorrelativas = new System.Windows.Forms.ListBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.lbl_MateriasAsignadas = new System.Windows.Forms.Label();
            this.lbl_AlumnosInscriptosAMateria = new System.Windows.Forms.Label();
            this.lbl_CorrelativasAsignadas = new System.Windows.Forms.Label();
            this.lbl_AlumnosInscriptosACorrelativa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_Fondo
            // 
            this.pct_Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pct_Fondo.Image")));
            this.pct_Fondo.Location = new System.Drawing.Point(-1, 1);
            this.pct_Fondo.Name = "pct_Fondo";
            this.pct_Fondo.Size = new System.Drawing.Size(906, 647);
            this.pct_Fondo.TabIndex = 0;
            this.pct_Fondo.TabStop = false;
            // 
            // lst_MateriasAsignadas
            // 
            this.lst_MateriasAsignadas.FormattingEnabled = true;
            this.lst_MateriasAsignadas.ItemHeight = 20;
            this.lst_MateriasAsignadas.Location = new System.Drawing.Point(12, 47);
            this.lst_MateriasAsignadas.Name = "lst_MateriasAsignadas";
            this.lst_MateriasAsignadas.Size = new System.Drawing.Size(429, 244);
            this.lst_MateriasAsignadas.TabIndex = 3;
            // 
            // lst_AlumnosInscriptosAMaterias
            // 
            this.lst_AlumnosInscriptosAMaterias.FormattingEnabled = true;
            this.lst_AlumnosInscriptosAMaterias.ItemHeight = 20;
            this.lst_AlumnosInscriptosAMaterias.Location = new System.Drawing.Point(447, 47);
            this.lst_AlumnosInscriptosAMaterias.Name = "lst_AlumnosInscriptosAMaterias";
            this.lst_AlumnosInscriptosAMaterias.Size = new System.Drawing.Size(429, 244);
            this.lst_AlumnosInscriptosAMaterias.TabIndex = 4;
            // 
            // lst_CorrelativasAsignadas
            // 
            this.lst_CorrelativasAsignadas.FormattingEnabled = true;
            this.lst_CorrelativasAsignadas.ItemHeight = 20;
            this.lst_CorrelativasAsignadas.Location = new System.Drawing.Point(12, 332);
            this.lst_CorrelativasAsignadas.Name = "lst_CorrelativasAsignadas";
            this.lst_CorrelativasAsignadas.Size = new System.Drawing.Size(429, 244);
            this.lst_CorrelativasAsignadas.TabIndex = 5;
            // 
            // lst_AlumnosInscriptosACorrelativas
            // 
            this.lst_AlumnosInscriptosACorrelativas.FormattingEnabled = true;
            this.lst_AlumnosInscriptosACorrelativas.ItemHeight = 20;
            this.lst_AlumnosInscriptosACorrelativas.Location = new System.Drawing.Point(447, 332);
            this.lst_AlumnosInscriptosACorrelativas.Name = "lst_AlumnosInscriptosACorrelativas";
            this.lst_AlumnosInscriptosACorrelativas.Size = new System.Drawing.Size(429, 244);
            this.lst_AlumnosInscriptosACorrelativas.TabIndex = 6;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(355, 602);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(190, 29);
            this.btn_Calcular.TabIndex = 7;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // lbl_MateriasAsignadas
            // 
            this.lbl_MateriasAsignadas.AutoSize = true;
            this.lbl_MateriasAsignadas.Location = new System.Drawing.Point(145, 24);
            this.lbl_MateriasAsignadas.Name = "lbl_MateriasAsignadas";
            this.lbl_MateriasAsignadas.Size = new System.Drawing.Size(136, 20);
            this.lbl_MateriasAsignadas.TabIndex = 8;
            this.lbl_MateriasAsignadas.Text = "Materias asignadas";
            // 
            // lbl_AlumnosInscriptosAMateria
            // 
            this.lbl_AlumnosInscriptosAMateria.AutoSize = true;
            this.lbl_AlumnosInscriptosAMateria.Location = new System.Drawing.Point(600, 24);
            this.lbl_AlumnosInscriptosAMateria.Name = "lbl_AlumnosInscriptosAMateria";
            this.lbl_AlumnosInscriptosAMateria.Size = new System.Drawing.Size(134, 20);
            this.lbl_AlumnosInscriptosAMateria.TabIndex = 9;
            this.lbl_AlumnosInscriptosAMateria.Text = "Alumnos inscriptos";
            // 
            // lbl_CorrelativasAsignadas
            // 
            this.lbl_CorrelativasAsignadas.AutoSize = true;
            this.lbl_CorrelativasAsignadas.Location = new System.Drawing.Point(145, 309);
            this.lbl_CorrelativasAsignadas.Name = "lbl_CorrelativasAsignadas";
            this.lbl_CorrelativasAsignadas.Size = new System.Drawing.Size(157, 20);
            this.lbl_CorrelativasAsignadas.TabIndex = 10;
            this.lbl_CorrelativasAsignadas.Text = "Correlativas asignadas";
            // 
            // lbl_AlumnosInscriptosACorrelativa
            // 
            this.lbl_AlumnosInscriptosACorrelativa.AutoSize = true;
            this.lbl_AlumnosInscriptosACorrelativa.Location = new System.Drawing.Point(600, 309);
            this.lbl_AlumnosInscriptosACorrelativa.Name = "lbl_AlumnosInscriptosACorrelativa";
            this.lbl_AlumnosInscriptosACorrelativa.Size = new System.Drawing.Size(226, 20);
            this.lbl_AlumnosInscriptosACorrelativa.TabIndex = 11;
            this.lbl_AlumnosInscriptosACorrelativa.Text = "Alumnos inscriptos a correlativas";
            // 
            // frm_CalcularAlumnosPorProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 643);
            this.Controls.Add(this.lbl_AlumnosInscriptosACorrelativa);
            this.Controls.Add(this.lbl_CorrelativasAsignadas);
            this.Controls.Add(this.lbl_AlumnosInscriptosAMateria);
            this.Controls.Add(this.lbl_MateriasAsignadas);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.lst_AlumnosInscriptosACorrelativas);
            this.Controls.Add(this.lst_CorrelativasAsignadas);
            this.Controls.Add(this.lst_AlumnosInscriptosAMaterias);
            this.Controls.Add(this.lst_MateriasAsignadas);
            this.Controls.Add(this.pct_Fondo);
            this.Name = "frm_CalcularAlumnosPorProfesor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular alumnos";
            this.Load += new System.EventHandler(this.frm_CalcularAlumnosPorProfesor_Load);
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
        private Button btn_Calcular;
        private Label lbl_MateriasAsignadas;
        private Label lbl_AlumnosInscriptosAMateria;
        private Label lbl_CorrelativasAsignadas;
        private Label lbl_AlumnosInscriptosACorrelativa;
    }
}