namespace SistemaUTN
{
    partial class frm_OpcionesEstadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_OpcionesEstadisticas));
            this.pct_Fondo = new System.Windows.Forms.PictureBox();
            this.btn_CalcularAlumnosDeProfesor = new System.Windows.Forms.Button();
            this.btn_CalcularNotaPromedioDeAlumno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_Fondo
            // 
            this.pct_Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pct_Fondo.Image")));
            this.pct_Fondo.Location = new System.Drawing.Point(-3, -1);
            this.pct_Fondo.Name = "pct_Fondo";
            this.pct_Fondo.Size = new System.Drawing.Size(604, 333);
            this.pct_Fondo.TabIndex = 0;
            this.pct_Fondo.TabStop = false;
            // 
            // btn_CalcularAlumnosDeProfesor
            // 
            this.btn_CalcularAlumnosDeProfesor.Location = new System.Drawing.Point(131, 103);
            this.btn_CalcularAlumnosDeProfesor.Name = "btn_CalcularAlumnosDeProfesor";
            this.btn_CalcularAlumnosDeProfesor.Size = new System.Drawing.Size(304, 29);
            this.btn_CalcularAlumnosDeProfesor.TabIndex = 1;
            this.btn_CalcularAlumnosDeProfesor.Text = "Calcular alumnos de profesores";
            this.btn_CalcularAlumnosDeProfesor.UseVisualStyleBackColor = true;
            this.btn_CalcularAlumnosDeProfesor.Click += new System.EventHandler(this.btn_CalcularAlumnosDeProfesor_Click);
            // 
            // btn_CalcularNotaPromedioDeAlumno
            // 
            this.btn_CalcularNotaPromedioDeAlumno.Location = new System.Drawing.Point(131, 163);
            this.btn_CalcularNotaPromedioDeAlumno.Name = "btn_CalcularNotaPromedioDeAlumno";
            this.btn_CalcularNotaPromedioDeAlumno.Size = new System.Drawing.Size(304, 29);
            this.btn_CalcularNotaPromedioDeAlumno.TabIndex = 2;
            this.btn_CalcularNotaPromedioDeAlumno.Text = "Calcular nota promedio del alumno";
            this.btn_CalcularNotaPromedioDeAlumno.UseVisualStyleBackColor = true;
            this.btn_CalcularNotaPromedioDeAlumno.Click += new System.EventHandler(this.btn_CalcularNotaPromedioDeAlumno_Click);
            // 
            // frm_OpcionesEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 322);
            this.Controls.Add(this.btn_CalcularNotaPromedioDeAlumno);
            this.Controls.Add(this.btn_CalcularAlumnosDeProfesor);
            this.Controls.Add(this.pct_Fondo);
            this.Name = "frm_OpcionesEstadisticas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opciones";
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pct_Fondo;
        private Button btn_CalcularAlumnosDeProfesor;
        private Button btn_CalcularNotaPromedioDeAlumno;
    }
}