namespace SistemaUTN
{
    partial class frm_CrearExamenCorrelativa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CrearExamenCorrelativa));
            this.pct_Fondo = new System.Windows.Forms.PictureBox();
            this.lst_ListadoDeCorrelativas = new System.Windows.Forms.ListBox();
            this.lst_ListadoDeAlumnos = new System.Windows.Forms.ListBox();
            this.lbl_CorrelativaSeleccionada = new System.Windows.Forms.Label();
            this.txt_MateriaSeleccionada = new System.Windows.Forms.TextBox();
            this.lbl_AlumnoSeleccionado = new System.Windows.Forms.Label();
            this.txt_AlumnoSeleccionado = new System.Windows.Forms.TextBox();
            this.lbl_TipoDeParcial = new System.Windows.Forms.Label();
            this.txt_TipoDeParcial = new System.Windows.Forms.TextBox();
            this.lbl_FechaDeParcial = new System.Windows.Forms.Label();
            this.txt_FechaExamen = new System.Windows.Forms.TextBox();
            this.lbl_NotaDeAlumno = new System.Windows.Forms.Label();
            this.txt_NotaDeAlumno = new System.Windows.Forms.TextBox();
            this.btn_CrearExamen = new System.Windows.Forms.Button();
            this.lbl_Alumnos = new System.Windows.Forms.Label();
            this.lbl_Correlativas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_Fondo
            // 
            this.pct_Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pct_Fondo.Image")));
            this.pct_Fondo.Location = new System.Drawing.Point(-3, -3);
            this.pct_Fondo.Name = "pct_Fondo";
            this.pct_Fondo.Size = new System.Drawing.Size(957, 473);
            this.pct_Fondo.TabIndex = 0;
            this.pct_Fondo.TabStop = false;
            // 
            // lst_ListadoDeCorrelativas
            // 
            this.lst_ListadoDeCorrelativas.FormattingEnabled = true;
            this.lst_ListadoDeCorrelativas.ItemHeight = 20;
            this.lst_ListadoDeCorrelativas.Location = new System.Drawing.Point(23, 33);
            this.lst_ListadoDeCorrelativas.Name = "lst_ListadoDeCorrelativas";
            this.lst_ListadoDeCorrelativas.Size = new System.Drawing.Size(317, 404);
            this.lst_ListadoDeCorrelativas.TabIndex = 2;
            this.lst_ListadoDeCorrelativas.DoubleClick += new System.EventHandler(this.lst_ListadoDeCorrelativas_DoubleClick);
            // 
            // lst_ListadoDeAlumnos
            // 
            this.lst_ListadoDeAlumnos.FormattingEnabled = true;
            this.lst_ListadoDeAlumnos.ItemHeight = 20;
            this.lst_ListadoDeAlumnos.Location = new System.Drawing.Point(603, 33);
            this.lst_ListadoDeAlumnos.Name = "lst_ListadoDeAlumnos";
            this.lst_ListadoDeAlumnos.Size = new System.Drawing.Size(317, 404);
            this.lst_ListadoDeAlumnos.TabIndex = 3;
            this.lst_ListadoDeAlumnos.DoubleClick += new System.EventHandler(this.lst_ListadoDeAlumnos_DoubleClick);
            // 
            // lbl_CorrelativaSeleccionada
            // 
            this.lbl_CorrelativaSeleccionada.AutoSize = true;
            this.lbl_CorrelativaSeleccionada.Location = new System.Drawing.Point(395, 33);
            this.lbl_CorrelativaSeleccionada.Name = "lbl_CorrelativaSeleccionada";
            this.lbl_CorrelativaSeleccionada.Size = new System.Drawing.Size(171, 20);
            this.lbl_CorrelativaSeleccionada.TabIndex = 6;
            this.lbl_CorrelativaSeleccionada.Text = "Correlativa seleccionada";
            // 
            // txt_MateriaSeleccionada
            // 
            this.txt_MateriaSeleccionada.Location = new System.Drawing.Point(379, 56);
            this.txt_MateriaSeleccionada.Name = "txt_MateriaSeleccionada";
            this.txt_MateriaSeleccionada.ReadOnly = true;
            this.txt_MateriaSeleccionada.Size = new System.Drawing.Size(192, 27);
            this.txt_MateriaSeleccionada.TabIndex = 7;
            // 
            // lbl_AlumnoSeleccionado
            // 
            this.lbl_AlumnoSeleccionado.AutoSize = true;
            this.lbl_AlumnoSeleccionado.Location = new System.Drawing.Point(395, 101);
            this.lbl_AlumnoSeleccionado.Name = "lbl_AlumnoSeleccionado";
            this.lbl_AlumnoSeleccionado.Size = new System.Drawing.Size(152, 20);
            this.lbl_AlumnoSeleccionado.TabIndex = 8;
            this.lbl_AlumnoSeleccionado.Text = "Alumno seleccionado";
            // 
            // txt_AlumnoSeleccionado
            // 
            this.txt_AlumnoSeleccionado.Location = new System.Drawing.Point(379, 124);
            this.txt_AlumnoSeleccionado.Name = "txt_AlumnoSeleccionado";
            this.txt_AlumnoSeleccionado.ReadOnly = true;
            this.txt_AlumnoSeleccionado.Size = new System.Drawing.Size(192, 27);
            this.txt_AlumnoSeleccionado.TabIndex = 9;
            // 
            // lbl_TipoDeParcial
            // 
            this.lbl_TipoDeParcial.AutoSize = true;
            this.lbl_TipoDeParcial.Location = new System.Drawing.Point(415, 166);
            this.lbl_TipoDeParcial.Name = "lbl_TipoDeParcial";
            this.lbl_TipoDeParcial.Size = new System.Drawing.Size(109, 20);
            this.lbl_TipoDeParcial.TabIndex = 10;
            this.lbl_TipoDeParcial.Text = "Tipo de parcial";
            // 
            // txt_TipoDeParcial
            // 
            this.txt_TipoDeParcial.Location = new System.Drawing.Point(379, 189);
            this.txt_TipoDeParcial.Name = "txt_TipoDeParcial";
            this.txt_TipoDeParcial.PlaceholderText = "primer/segundo parcial";
            this.txt_TipoDeParcial.Size = new System.Drawing.Size(192, 27);
            this.txt_TipoDeParcial.TabIndex = 11;
            // 
            // lbl_FechaDeParcial
            // 
            this.lbl_FechaDeParcial.AutoSize = true;
            this.lbl_FechaDeParcial.Location = new System.Drawing.Point(407, 233);
            this.lbl_FechaDeParcial.Name = "lbl_FechaDeParcial";
            this.lbl_FechaDeParcial.Size = new System.Drawing.Size(117, 20);
            this.lbl_FechaDeParcial.TabIndex = 12;
            this.lbl_FechaDeParcial.Text = "Fecha de parcial";
            // 
            // txt_FechaExamen
            // 
            this.txt_FechaExamen.Location = new System.Drawing.Point(379, 256);
            this.txt_FechaExamen.Name = "txt_FechaExamen";
            this.txt_FechaExamen.PlaceholderText = "YYYY/MM/DD";
            this.txt_FechaExamen.Size = new System.Drawing.Size(192, 27);
            this.txt_FechaExamen.TabIndex = 13;
            // 
            // lbl_NotaDeAlumno
            // 
            this.lbl_NotaDeAlumno.AutoSize = true;
            this.lbl_NotaDeAlumno.Location = new System.Drawing.Point(407, 299);
            this.lbl_NotaDeAlumno.Name = "lbl_NotaDeAlumno";
            this.lbl_NotaDeAlumno.Size = new System.Drawing.Size(121, 20);
            this.lbl_NotaDeAlumno.TabIndex = 16;
            this.lbl_NotaDeAlumno.Text = "Nota del alumno";
            // 
            // txt_NotaDeAlumno
            // 
            this.txt_NotaDeAlumno.Location = new System.Drawing.Point(379, 322);
            this.txt_NotaDeAlumno.Name = "txt_NotaDeAlumno";
            this.txt_NotaDeAlumno.Size = new System.Drawing.Size(192, 27);
            this.txt_NotaDeAlumno.TabIndex = 17;
            // 
            // btn_CrearExamen
            // 
            this.btn_CrearExamen.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_CrearExamen.FlatAppearance.BorderSize = 0;
            this.btn_CrearExamen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CrearExamen.Location = new System.Drawing.Point(379, 408);
            this.btn_CrearExamen.Name = "btn_CrearExamen";
            this.btn_CrearExamen.Size = new System.Drawing.Size(192, 29);
            this.btn_CrearExamen.TabIndex = 18;
            this.btn_CrearExamen.Text = "Crear examen";
            this.btn_CrearExamen.UseVisualStyleBackColor = false;
            this.btn_CrearExamen.Click += new System.EventHandler(this.btn_CrearExamen_Click);
            // 
            // lbl_Alumnos
            // 
            this.lbl_Alumnos.AutoSize = true;
            this.lbl_Alumnos.Location = new System.Drawing.Point(733, 10);
            this.lbl_Alumnos.Name = "lbl_Alumnos";
            this.lbl_Alumnos.Size = new System.Drawing.Size(67, 20);
            this.lbl_Alumnos.TabIndex = 19;
            this.lbl_Alumnos.Text = "Alumnos";
            // 
            // lbl_Correlativas
            // 
            this.lbl_Correlativas.AutoSize = true;
            this.lbl_Correlativas.Location = new System.Drawing.Point(120, 10);
            this.lbl_Correlativas.Name = "lbl_Correlativas";
            this.lbl_Correlativas.Size = new System.Drawing.Size(87, 20);
            this.lbl_Correlativas.TabIndex = 20;
            this.lbl_Correlativas.Text = "Correlativas";
            // 
            // frm_CrearExamenCorrelativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 467);
            this.Controls.Add(this.lbl_Correlativas);
            this.Controls.Add(this.lbl_Alumnos);
            this.Controls.Add(this.btn_CrearExamen);
            this.Controls.Add(this.txt_NotaDeAlumno);
            this.Controls.Add(this.lbl_NotaDeAlumno);
            this.Controls.Add(this.txt_FechaExamen);
            this.Controls.Add(this.lbl_FechaDeParcial);
            this.Controls.Add(this.txt_TipoDeParcial);
            this.Controls.Add(this.lbl_TipoDeParcial);
            this.Controls.Add(this.txt_AlumnoSeleccionado);
            this.Controls.Add(this.lbl_AlumnoSeleccionado);
            this.Controls.Add(this.txt_MateriaSeleccionada);
            this.Controls.Add(this.lbl_CorrelativaSeleccionada);
            this.Controls.Add(this.lst_ListadoDeAlumnos);
            this.Controls.Add(this.lst_ListadoDeCorrelativas);
            this.Controls.Add(this.pct_Fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_CrearExamenCorrelativa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear examen";
            this.Load += new System.EventHandler(this.frm_CrearExamenCorrelativa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pct_Fondo;
        private ListBox lst_ListadoDeCorrelativas;
        private ListBox lst_ListadoDeAlumnos;
        private Label lbl_CorrelativaSeleccionada;
        private TextBox txt_MateriaSeleccionada;
        private Label lbl_AlumnoSeleccionado;
        private TextBox txt_AlumnoSeleccionado;
        private Label lbl_TipoDeParcial;
        private TextBox txt_TipoDeParcial;
        private Label lbl_FechaDeParcial;
        private TextBox txt_FechaExamen;
        private Label lbl_NotaDeAlumno;
        private TextBox txt_NotaDeAlumno;
        private Button btn_CrearExamen;
        private Label lbl_Alumnos;
        private Label lbl_Correlativas;
    }
}