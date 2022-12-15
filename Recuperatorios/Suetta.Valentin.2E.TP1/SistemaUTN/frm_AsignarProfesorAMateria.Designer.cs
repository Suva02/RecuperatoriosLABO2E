namespace SistemaUTN
{
    partial class frm_AsignarProfesorAMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AsignarProfesorAMateria));
            this.pct_Fondo = new System.Windows.Forms.PictureBox();
            this.lst_ListadoDeMaterias = new System.Windows.Forms.ListBox();
            this.lst_ListadoDeProfesoresDisponibles = new System.Windows.Forms.ListBox();
            this.lbl_ProfesoresDisponibles = new System.Windows.Forms.Label();
            this.lbl_ListadoDeMaterias = new System.Windows.Forms.Label();
            this.txt_MateriaSeleccionada = new System.Windows.Forms.TextBox();
            this.txt_ProfesorSeleccionado = new System.Windows.Forms.TextBox();
            this.lbl_MateriaSeleccionada = new System.Windows.Forms.Label();
            this.lbl_ProfesorSeleccionado = new System.Windows.Forms.Label();
            this.btn_Asignar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_Fondo
            // 
            this.pct_Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pct_Fondo.Image")));
            this.pct_Fondo.Location = new System.Drawing.Point(0, -1);
            this.pct_Fondo.Name = "pct_Fondo";
            this.pct_Fondo.Size = new System.Drawing.Size(940, 473);
            this.pct_Fondo.TabIndex = 0;
            this.pct_Fondo.TabStop = false;
            // 
            // lst_ListadoDeMaterias
            // 
            this.lst_ListadoDeMaterias.FormattingEnabled = true;
            this.lst_ListadoDeMaterias.ItemHeight = 20;
            this.lst_ListadoDeMaterias.Location = new System.Drawing.Point(12, 49);
            this.lst_ListadoDeMaterias.Name = "lst_ListadoDeMaterias";
            this.lst_ListadoDeMaterias.Size = new System.Drawing.Size(335, 404);
            this.lst_ListadoDeMaterias.TabIndex = 1;
            this.lst_ListadoDeMaterias.DoubleClick += new System.EventHandler(this.lst_ListadoDeMaterias_DoubleClick);
            // 
            // lst_ListadoDeProfesoresDisponibles
            // 
            this.lst_ListadoDeProfesoresDisponibles.FormattingEnabled = true;
            this.lst_ListadoDeProfesoresDisponibles.ItemHeight = 20;
            this.lst_ListadoDeProfesoresDisponibles.Location = new System.Drawing.Point(584, 49);
            this.lst_ListadoDeProfesoresDisponibles.Name = "lst_ListadoDeProfesoresDisponibles";
            this.lst_ListadoDeProfesoresDisponibles.Size = new System.Drawing.Size(335, 404);
            this.lst_ListadoDeProfesoresDisponibles.TabIndex = 2;
            this.lst_ListadoDeProfesoresDisponibles.DoubleClick += new System.EventHandler(this.lst_ListadoDeProfesoresDisponibles_DoubleClick);
            // 
            // lbl_ProfesoresDisponibles
            // 
            this.lbl_ProfesoresDisponibles.AutoSize = true;
            this.lbl_ProfesoresDisponibles.Location = new System.Drawing.Point(712, 26);
            this.lbl_ProfesoresDisponibles.Name = "lbl_ProfesoresDisponibles";
            this.lbl_ProfesoresDisponibles.Size = new System.Drawing.Size(78, 20);
            this.lbl_ProfesoresDisponibles.TabIndex = 3;
            this.lbl_ProfesoresDisponibles.Text = "Profesores";
            // 
            // lbl_ListadoDeMaterias
            // 
            this.lbl_ListadoDeMaterias.AutoSize = true;
            this.lbl_ListadoDeMaterias.Location = new System.Drawing.Point(135, 26);
            this.lbl_ListadoDeMaterias.Name = "lbl_ListadoDeMaterias";
            this.lbl_ListadoDeMaterias.Size = new System.Drawing.Size(66, 20);
            this.lbl_ListadoDeMaterias.TabIndex = 4;
            this.lbl_ListadoDeMaterias.Text = "Materias";
            this.lbl_ListadoDeMaterias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_MateriaSeleccionada
            // 
            this.txt_MateriaSeleccionada.Location = new System.Drawing.Point(380, 151);
            this.txt_MateriaSeleccionada.Name = "txt_MateriaSeleccionada";
            this.txt_MateriaSeleccionada.ReadOnly = true;
            this.txt_MateriaSeleccionada.Size = new System.Drawing.Size(178, 27);
            this.txt_MateriaSeleccionada.TabIndex = 5;
            // 
            // txt_ProfesorSeleccionado
            // 
            this.txt_ProfesorSeleccionado.Location = new System.Drawing.Point(380, 236);
            this.txt_ProfesorSeleccionado.Name = "txt_ProfesorSeleccionado";
            this.txt_ProfesorSeleccionado.ReadOnly = true;
            this.txt_ProfesorSeleccionado.Size = new System.Drawing.Size(178, 27);
            this.txt_ProfesorSeleccionado.TabIndex = 6;
            // 
            // lbl_MateriaSeleccionada
            // 
            this.lbl_MateriaSeleccionada.AutoSize = true;
            this.lbl_MateriaSeleccionada.Location = new System.Drawing.Point(398, 128);
            this.lbl_MateriaSeleccionada.Name = "lbl_MateriaSeleccionada";
            this.lbl_MateriaSeleccionada.Size = new System.Drawing.Size(150, 20);
            this.lbl_MateriaSeleccionada.TabIndex = 7;
            this.lbl_MateriaSeleccionada.Text = "Materia seleccionada";
            // 
            // lbl_ProfesorSeleccionado
            // 
            this.lbl_ProfesorSeleccionado.AutoSize = true;
            this.lbl_ProfesorSeleccionado.Location = new System.Drawing.Point(393, 213);
            this.lbl_ProfesorSeleccionado.Name = "lbl_ProfesorSeleccionado";
            this.lbl_ProfesorSeleccionado.Size = new System.Drawing.Size(155, 20);
            this.lbl_ProfesorSeleccionado.TabIndex = 8;
            this.lbl_ProfesorSeleccionado.Text = "Profesor seleccionado";
            // 
            // btn_Asignar
            // 
            this.btn_Asignar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Asignar.FlatAppearance.BorderSize = 0;
            this.btn_Asignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Asignar.Location = new System.Drawing.Point(380, 269);
            this.btn_Asignar.Name = "btn_Asignar";
            this.btn_Asignar.Size = new System.Drawing.Size(178, 29);
            this.btn_Asignar.TabIndex = 9;
            this.btn_Asignar.Text = "Asignar";
            this.btn_Asignar.UseVisualStyleBackColor = false;
            this.btn_Asignar.Click += new System.EventHandler(this.btn_Asignar_Click);
            // 
            // frm_AsignarProfesorAMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 467);
            this.Controls.Add(this.btn_Asignar);
            this.Controls.Add(this.lbl_ProfesorSeleccionado);
            this.Controls.Add(this.lbl_MateriaSeleccionada);
            this.Controls.Add(this.txt_ProfesorSeleccionado);
            this.Controls.Add(this.txt_MateriaSeleccionada);
            this.Controls.Add(this.lbl_ListadoDeMaterias);
            this.Controls.Add(this.lbl_ProfesoresDisponibles);
            this.Controls.Add(this.lst_ListadoDeProfesoresDisponibles);
            this.Controls.Add(this.lst_ListadoDeMaterias);
            this.Controls.Add(this.pct_Fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_AsignarProfesorAMateria";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar profesor";
            this.Load += new System.EventHandler(this.frm_AsignarProfesorAMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pct_Fondo;
        private ListBox lst_ListadoDeMaterias;
        private ListBox lst_ListadoDeProfesoresDisponibles;
        private Label lbl_ProfesoresDisponibles;
        private Label lbl_ListadoDeMaterias;
        private TextBox txt_MateriaSeleccionada;
        private TextBox txt_ProfesorSeleccionado;
        private Label lbl_MateriaSeleccionada;
        private Label lbl_ProfesorSeleccionado;
        private Button btn_Asignar;
    }
}