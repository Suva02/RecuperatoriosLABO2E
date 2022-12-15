namespace SistemaUTN
{
    partial class frm_AsignarProfesorACorrelativa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AsignarProfesorACorrelativa));
            this.pct_Fondo = new System.Windows.Forms.PictureBox();
            this.lst_ListadoDeCorrelativas = new System.Windows.Forms.ListBox();
            this.lst_ListadoDeProfesoresDisponibles = new System.Windows.Forms.ListBox();
            this.lbl_ListadoDeCorrelativas = new System.Windows.Forms.Label();
            this.lbl_ProfesoresDisponibles = new System.Windows.Forms.Label();
            this.lbl_CorrelativaSeleccionada = new System.Windows.Forms.Label();
            this.txt_CorrelativaSeleccionada = new System.Windows.Forms.TextBox();
            this.lbl_ProfesorSeleccionado = new System.Windows.Forms.Label();
            this.txt_ProfesorSeleccionado = new System.Windows.Forms.TextBox();
            this.btn_Asignar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_Fondo
            // 
            this.pct_Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pct_Fondo.Image")));
            this.pct_Fondo.Location = new System.Drawing.Point(0, 0);
            this.pct_Fondo.Name = "pct_Fondo";
            this.pct_Fondo.Size = new System.Drawing.Size(936, 468);
            this.pct_Fondo.TabIndex = 0;
            this.pct_Fondo.TabStop = false;
            // 
            // lst_ListadoDeCorrelativas
            // 
            this.lst_ListadoDeCorrelativas.FormattingEnabled = true;
            this.lst_ListadoDeCorrelativas.ItemHeight = 20;
            this.lst_ListadoDeCorrelativas.Location = new System.Drawing.Point(25, 51);
            this.lst_ListadoDeCorrelativas.Name = "lst_ListadoDeCorrelativas";
            this.lst_ListadoDeCorrelativas.Size = new System.Drawing.Size(335, 404);
            this.lst_ListadoDeCorrelativas.TabIndex = 2;
            this.lst_ListadoDeCorrelativas.DoubleClick += new System.EventHandler(this.lst_ListadoDeCorrelativas_DoubleClick);
            // 
            // lst_ListadoDeProfesoresDisponibles
            // 
            this.lst_ListadoDeProfesoresDisponibles.FormattingEnabled = true;
            this.lst_ListadoDeProfesoresDisponibles.ItemHeight = 20;
            this.lst_ListadoDeProfesoresDisponibles.Location = new System.Drawing.Point(572, 51);
            this.lst_ListadoDeProfesoresDisponibles.Name = "lst_ListadoDeProfesoresDisponibles";
            this.lst_ListadoDeProfesoresDisponibles.Size = new System.Drawing.Size(335, 404);
            this.lst_ListadoDeProfesoresDisponibles.TabIndex = 3;
            this.lst_ListadoDeProfesoresDisponibles.DoubleClick += new System.EventHandler(this.lst_ListadoDeProfesoresDisponibles_DoubleClick);
            // 
            // lbl_ListadoDeCorrelativas
            // 
            this.lbl_ListadoDeCorrelativas.AutoSize = true;
            this.lbl_ListadoDeCorrelativas.Location = new System.Drawing.Point(143, 28);
            this.lbl_ListadoDeCorrelativas.Name = "lbl_ListadoDeCorrelativas";
            this.lbl_ListadoDeCorrelativas.Size = new System.Drawing.Size(87, 20);
            this.lbl_ListadoDeCorrelativas.TabIndex = 5;
            this.lbl_ListadoDeCorrelativas.Text = "Correlativas";
            this.lbl_ListadoDeCorrelativas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ProfesoresDisponibles
            // 
            this.lbl_ProfesoresDisponibles.AutoSize = true;
            this.lbl_ProfesoresDisponibles.Location = new System.Drawing.Point(705, 28);
            this.lbl_ProfesoresDisponibles.Name = "lbl_ProfesoresDisponibles";
            this.lbl_ProfesoresDisponibles.Size = new System.Drawing.Size(78, 20);
            this.lbl_ProfesoresDisponibles.TabIndex = 6;
            this.lbl_ProfesoresDisponibles.Text = "Profesores";
            // 
            // lbl_CorrelativaSeleccionada
            // 
            this.lbl_CorrelativaSeleccionada.AutoSize = true;
            this.lbl_CorrelativaSeleccionada.Location = new System.Drawing.Point(383, 156);
            this.lbl_CorrelativaSeleccionada.Name = "lbl_CorrelativaSeleccionada";
            this.lbl_CorrelativaSeleccionada.Size = new System.Drawing.Size(171, 20);
            this.lbl_CorrelativaSeleccionada.TabIndex = 8;
            this.lbl_CorrelativaSeleccionada.Text = "Correlativa seleccionada";
            // 
            // txt_CorrelativaSeleccionada
            // 
            this.txt_CorrelativaSeleccionada.Location = new System.Drawing.Point(376, 179);
            this.txt_CorrelativaSeleccionada.Name = "txt_CorrelativaSeleccionada";
            this.txt_CorrelativaSeleccionada.ReadOnly = true;
            this.txt_CorrelativaSeleccionada.Size = new System.Drawing.Size(178, 27);
            this.txt_CorrelativaSeleccionada.TabIndex = 9;
            // 
            // lbl_ProfesorSeleccionado
            // 
            this.lbl_ProfesorSeleccionado.AutoSize = true;
            this.lbl_ProfesorSeleccionado.Location = new System.Drawing.Point(390, 223);
            this.lbl_ProfesorSeleccionado.Name = "lbl_ProfesorSeleccionado";
            this.lbl_ProfesorSeleccionado.Size = new System.Drawing.Size(155, 20);
            this.lbl_ProfesorSeleccionado.TabIndex = 10;
            this.lbl_ProfesorSeleccionado.Text = "Profesor seleccionado";
            // 
            // txt_ProfesorSeleccionado
            // 
            this.txt_ProfesorSeleccionado.Location = new System.Drawing.Point(376, 246);
            this.txt_ProfesorSeleccionado.Name = "txt_ProfesorSeleccionado";
            this.txt_ProfesorSeleccionado.ReadOnly = true;
            this.txt_ProfesorSeleccionado.Size = new System.Drawing.Size(178, 27);
            this.txt_ProfesorSeleccionado.TabIndex = 11;
            // 
            // btn_Asignar
            // 
            this.btn_Asignar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Asignar.FlatAppearance.BorderSize = 0;
            this.btn_Asignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Asignar.Location = new System.Drawing.Point(376, 279);
            this.btn_Asignar.Name = "btn_Asignar";
            this.btn_Asignar.Size = new System.Drawing.Size(178, 29);
            this.btn_Asignar.TabIndex = 12;
            this.btn_Asignar.Text = "Asignar";
            this.btn_Asignar.UseVisualStyleBackColor = false;
            this.btn_Asignar.Click += new System.EventHandler(this.btn_Asignar_Click);
            // 
            // frm_AsignarProfesorACorrelativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 467);
            this.Controls.Add(this.btn_Asignar);
            this.Controls.Add(this.txt_ProfesorSeleccionado);
            this.Controls.Add(this.lbl_ProfesorSeleccionado);
            this.Controls.Add(this.txt_CorrelativaSeleccionada);
            this.Controls.Add(this.lbl_CorrelativaSeleccionada);
            this.Controls.Add(this.lbl_ProfesoresDisponibles);
            this.Controls.Add(this.lbl_ListadoDeCorrelativas);
            this.Controls.Add(this.lst_ListadoDeProfesoresDisponibles);
            this.Controls.Add(this.lst_ListadoDeCorrelativas);
            this.Controls.Add(this.pct_Fondo);
            this.MaximizeBox = false;
            this.Name = "frm_AsignarProfesorACorrelativa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar profesor a correlativa";
            this.Load += new System.EventHandler(this.frm_AsignarProfesorACorrelativa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pct_Fondo;
        private ListBox lst_ListadoDeCorrelativas;
        private ListBox lst_ListadoDeProfesoresDisponibles;
        private Label lbl_ListadoDeCorrelativas;
        private Label lbl_ProfesoresDisponibles;
        private Label lbl_CorrelativaSeleccionada;
        private TextBox txt_CorrelativaSeleccionada;
        private Label lbl_ProfesorSeleccionado;
        private TextBox txt_ProfesorSeleccionado;
        private Button btn_Asignar;
    }
}