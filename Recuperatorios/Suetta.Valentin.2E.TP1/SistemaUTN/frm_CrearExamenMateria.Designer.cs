namespace SistemaUTN
{
    partial class frm_CrearExamenMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CrearExamenMateria));
            this.pct_Fondo = new System.Windows.Forms.PictureBox();
            this.lst_ListadoDeMaterias = new System.Windows.Forms.ListBox();
            this.lst_ListadoDeAlumnos = new System.Windows.Forms.ListBox();
            this.txt_MateriaSeleccionada = new System.Windows.Forms.TextBox();
            this.txt_AlumnoSeleccionado = new System.Windows.Forms.TextBox();
            this.lbl_MateriaSeleccionada = new System.Windows.Forms.Label();
            this.lbl_AlumnoSeleccionado = new System.Windows.Forms.Label();
            this.lbl_TipoDeParcial = new System.Windows.Forms.Label();
            this.txt_TipoDeParcial = new System.Windows.Forms.TextBox();
            this.lbl_FechaDeParcial = new System.Windows.Forms.Label();
            this.txt_FechaExamen = new System.Windows.Forms.TextBox();
            this.txt_NotaDeAlumno = new System.Windows.Forms.TextBox();
            this.lbl_NotaDeAlumno = new System.Windows.Forms.Label();
            this.btn_CrearExamen = new System.Windows.Forms.Button();
            this.lbl_Materias = new System.Windows.Forms.Label();
            this.lbl_Alumnos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_Fondo
            // 
            this.pct_Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pct_Fondo.Image")));
            this.pct_Fondo.Location = new System.Drawing.Point(-2, -2);
            this.pct_Fondo.Name = "pct_Fondo";
            this.pct_Fondo.Size = new System.Drawing.Size(957, 471);
            this.pct_Fondo.TabIndex = 0;
            this.pct_Fondo.TabStop = false;
            // 
            // lst_ListadoDeMaterias
            // 
            this.lst_ListadoDeMaterias.FormattingEnabled = true;
            this.lst_ListadoDeMaterias.ItemHeight = 20;
            this.lst_ListadoDeMaterias.Location = new System.Drawing.Point(32, 34);
            this.lst_ListadoDeMaterias.Name = "lst_ListadoDeMaterias";
            this.lst_ListadoDeMaterias.Size = new System.Drawing.Size(317, 404);
            this.lst_ListadoDeMaterias.TabIndex = 1;
            this.lst_ListadoDeMaterias.DoubleClick += new System.EventHandler(this.lst_ListadoDeMaterias_DoubleClick);
            // 
            // lst_ListadoDeAlumnos
            // 
            this.lst_ListadoDeAlumnos.FormattingEnabled = true;
            this.lst_ListadoDeAlumnos.ItemHeight = 20;
            this.lst_ListadoDeAlumnos.Location = new System.Drawing.Point(605, 34);
            this.lst_ListadoDeAlumnos.Name = "lst_ListadoDeAlumnos";
            this.lst_ListadoDeAlumnos.Size = new System.Drawing.Size(317, 404);
            this.lst_ListadoDeAlumnos.TabIndex = 2;
            this.lst_ListadoDeAlumnos.DoubleClick += new System.EventHandler(this.lst_ListadoDeAlumnos_DoubleClick);
            // 
            // txt_MateriaSeleccionada
            // 
            this.txt_MateriaSeleccionada.Location = new System.Drawing.Point(379, 57);
            this.txt_MateriaSeleccionada.Name = "txt_MateriaSeleccionada";
            this.txt_MateriaSeleccionada.ReadOnly = true;
            this.txt_MateriaSeleccionada.Size = new System.Drawing.Size(192, 27);
            this.txt_MateriaSeleccionada.TabIndex = 3;
            // 
            // txt_AlumnoSeleccionado
            // 
            this.txt_AlumnoSeleccionado.Location = new System.Drawing.Point(379, 120);
            this.txt_AlumnoSeleccionado.Name = "txt_AlumnoSeleccionado";
            this.txt_AlumnoSeleccionado.ReadOnly = true;
            this.txt_AlumnoSeleccionado.Size = new System.Drawing.Size(192, 27);
            this.txt_AlumnoSeleccionado.TabIndex = 4;
            // 
            // lbl_MateriaSeleccionada
            // 
            this.lbl_MateriaSeleccionada.AutoSize = true;
            this.lbl_MateriaSeleccionada.Location = new System.Drawing.Point(402, 34);
            this.lbl_MateriaSeleccionada.Name = "lbl_MateriaSeleccionada";
            this.lbl_MateriaSeleccionada.Size = new System.Drawing.Size(150, 20);
            this.lbl_MateriaSeleccionada.TabIndex = 5;
            this.lbl_MateriaSeleccionada.Text = "Materia seleccionada";
            // 
            // lbl_AlumnoSeleccionado
            // 
            this.lbl_AlumnoSeleccionado.AutoSize = true;
            this.lbl_AlumnoSeleccionado.Location = new System.Drawing.Point(400, 97);
            this.lbl_AlumnoSeleccionado.Name = "lbl_AlumnoSeleccionado";
            this.lbl_AlumnoSeleccionado.Size = new System.Drawing.Size(152, 20);
            this.lbl_AlumnoSeleccionado.TabIndex = 6;
            this.lbl_AlumnoSeleccionado.Text = "Alumno seleccionado";
            // 
            // lbl_TipoDeParcial
            // 
            this.lbl_TipoDeParcial.AutoSize = true;
            this.lbl_TipoDeParcial.Location = new System.Drawing.Point(419, 161);
            this.lbl_TipoDeParcial.Name = "lbl_TipoDeParcial";
            this.lbl_TipoDeParcial.Size = new System.Drawing.Size(109, 20);
            this.lbl_TipoDeParcial.TabIndex = 7;
            this.lbl_TipoDeParcial.Text = "Tipo de parcial";
            // 
            // txt_TipoDeParcial
            // 
            this.txt_TipoDeParcial.Location = new System.Drawing.Point(379, 184);
            this.txt_TipoDeParcial.Name = "txt_TipoDeParcial";
            this.txt_TipoDeParcial.PlaceholderText = "primer/segundo parcial";
            this.txt_TipoDeParcial.Size = new System.Drawing.Size(192, 27);
            this.txt_TipoDeParcial.TabIndex = 8;
            // 
            // lbl_FechaDeParcial
            // 
            this.lbl_FechaDeParcial.AutoSize = true;
            this.lbl_FechaDeParcial.Location = new System.Drawing.Point(411, 223);
            this.lbl_FechaDeParcial.Name = "lbl_FechaDeParcial";
            this.lbl_FechaDeParcial.Size = new System.Drawing.Size(117, 20);
            this.lbl_FechaDeParcial.TabIndex = 9;
            this.lbl_FechaDeParcial.Text = "Fecha de parcial";
            // 
            // txt_FechaExamen
            // 
            this.txt_FechaExamen.Location = new System.Drawing.Point(379, 246);
            this.txt_FechaExamen.Name = "txt_FechaExamen";
            this.txt_FechaExamen.PlaceholderText = "YYYY/MM/DD";
            this.txt_FechaExamen.Size = new System.Drawing.Size(192, 27);
            this.txt_FechaExamen.TabIndex = 10;
            // 
            // txt_NotaDeAlumno
            // 
            this.txt_NotaDeAlumno.Location = new System.Drawing.Point(379, 321);
            this.txt_NotaDeAlumno.Name = "txt_NotaDeAlumno";
            this.txt_NotaDeAlumno.Size = new System.Drawing.Size(192, 27);
            this.txt_NotaDeAlumno.TabIndex = 13;
            // 
            // lbl_NotaDeAlumno
            // 
            this.lbl_NotaDeAlumno.AutoSize = true;
            this.lbl_NotaDeAlumno.Location = new System.Drawing.Point(411, 298);
            this.lbl_NotaDeAlumno.Name = "lbl_NotaDeAlumno";
            this.lbl_NotaDeAlumno.Size = new System.Drawing.Size(121, 20);
            this.lbl_NotaDeAlumno.TabIndex = 14;
            this.lbl_NotaDeAlumno.Text = "Nota del alumno";
            // 
            // btn_CrearExamen
            // 
            this.btn_CrearExamen.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_CrearExamen.FlatAppearance.BorderSize = 0;
            this.btn_CrearExamen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CrearExamen.Location = new System.Drawing.Point(379, 409);
            this.btn_CrearExamen.Name = "btn_CrearExamen";
            this.btn_CrearExamen.Size = new System.Drawing.Size(192, 29);
            this.btn_CrearExamen.TabIndex = 15;
            this.btn_CrearExamen.Text = "Crear examen";
            this.btn_CrearExamen.UseVisualStyleBackColor = false;
            this.btn_CrearExamen.Click += new System.EventHandler(this.btn_CrearExamen_Click);
            // 
            // lbl_Materias
            // 
            this.lbl_Materias.AutoSize = true;
            this.lbl_Materias.Location = new System.Drawing.Point(139, 11);
            this.lbl_Materias.Name = "lbl_Materias";
            this.lbl_Materias.Size = new System.Drawing.Size(66, 20);
            this.lbl_Materias.TabIndex = 21;
            this.lbl_Materias.Text = "Materias";
            // 
            // lbl_Alumnos
            // 
            this.lbl_Alumnos.AutoSize = true;
            this.lbl_Alumnos.Location = new System.Drawing.Point(737, 9);
            this.lbl_Alumnos.Name = "lbl_Alumnos";
            this.lbl_Alumnos.Size = new System.Drawing.Size(67, 20);
            this.lbl_Alumnos.TabIndex = 22;
            this.lbl_Alumnos.Text = "Alumnos";
            // 
            // frm_CrearExamenMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 467);
            this.Controls.Add(this.lbl_Alumnos);
            this.Controls.Add(this.lbl_Materias);
            this.Controls.Add(this.btn_CrearExamen);
            this.Controls.Add(this.lbl_NotaDeAlumno);
            this.Controls.Add(this.txt_NotaDeAlumno);
            this.Controls.Add(this.txt_FechaExamen);
            this.Controls.Add(this.lbl_FechaDeParcial);
            this.Controls.Add(this.txt_TipoDeParcial);
            this.Controls.Add(this.lbl_TipoDeParcial);
            this.Controls.Add(this.lbl_AlumnoSeleccionado);
            this.Controls.Add(this.lbl_MateriaSeleccionada);
            this.Controls.Add(this.txt_AlumnoSeleccionado);
            this.Controls.Add(this.txt_MateriaSeleccionada);
            this.Controls.Add(this.lst_ListadoDeAlumnos);
            this.Controls.Add(this.lst_ListadoDeMaterias);
            this.Controls.Add(this.pct_Fondo);
            this.MaximizeBox = false;
            this.Name = "frm_CrearExamenMateria";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear examen";
            this.Load += new System.EventHandler(this.frm_CrearExamenMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pct_Fondo;
        private ListBox lst_ListadoDeMaterias;
        private ListBox lst_ListadoDeAlumnos;
        private TextBox txt_MateriaSeleccionada;
        private TextBox txt_AlumnoSeleccionado;
        private Label lbl_MateriaSeleccionada;
        private Label lbl_AlumnoSeleccionado;
        private Label lbl_TipoDeParcial;
        private TextBox txt_TipoDeParcial;
        private Label lbl_FechaDeParcial;
        private TextBox txt_FechaExamen;
        private TextBox txt_NotaDeAlumno;
        private Label lbl_NotaDeAlumno;
        private Button btn_CrearExamen;
        private Label lbl_Materias;
        private Label lbl_Alumnos;
    }
}