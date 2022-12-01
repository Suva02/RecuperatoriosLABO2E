namespace SistemaUTN
{
    partial class frm_OpcionesMateriaAsignarProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_OpcionesMateriaAsignarProfesor));
            this.pct_Fondo = new System.Windows.Forms.PictureBox();
            this.btn_AsignarProfeAMateria = new System.Windows.Forms.Button();
            this.btn_AsignarProfesorACorrelativa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_Fondo
            // 
            this.pct_Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pct_Fondo.Image")));
            this.pct_Fondo.Location = new System.Drawing.Point(0, 0);
            this.pct_Fondo.Name = "pct_Fondo";
            this.pct_Fondo.Size = new System.Drawing.Size(404, 214);
            this.pct_Fondo.TabIndex = 0;
            this.pct_Fondo.TabStop = false;
            // 
            // btn_AsignarProfeAMateria
            // 
            this.btn_AsignarProfeAMateria.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_AsignarProfeAMateria.FlatAppearance.BorderSize = 0;
            this.btn_AsignarProfeAMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AsignarProfeAMateria.Location = new System.Drawing.Point(106, 40);
            this.btn_AsignarProfeAMateria.Name = "btn_AsignarProfeAMateria";
            this.btn_AsignarProfeAMateria.Size = new System.Drawing.Size(185, 29);
            this.btn_AsignarProfeAMateria.TabIndex = 1;
            this.btn_AsignarProfeAMateria.Text = "Asignar a materias";
            this.btn_AsignarProfeAMateria.UseVisualStyleBackColor = false;
            this.btn_AsignarProfeAMateria.Click += new System.EventHandler(this.btn_AsignarProfeAMateria_Click);
            // 
            // btn_AsignarProfesorACorrelativa
            // 
            this.btn_AsignarProfesorACorrelativa.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_AsignarProfesorACorrelativa.FlatAppearance.BorderSize = 0;
            this.btn_AsignarProfesorACorrelativa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AsignarProfesorACorrelativa.Location = new System.Drawing.Point(106, 120);
            this.btn_AsignarProfesorACorrelativa.Name = "btn_AsignarProfesorACorrelativa";
            this.btn_AsignarProfesorACorrelativa.Size = new System.Drawing.Size(185, 29);
            this.btn_AsignarProfesorACorrelativa.TabIndex = 2;
            this.btn_AsignarProfesorACorrelativa.Text = "Asignar a correlativas";
            this.btn_AsignarProfesorACorrelativa.UseVisualStyleBackColor = false;
            this.btn_AsignarProfesorACorrelativa.Click += new System.EventHandler(this.btn_AsignarProfesorACorrelativa_Click);
            // 
            // frm_OpcionesMateriaAsignarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 213);
            this.Controls.Add(this.btn_AsignarProfesorACorrelativa);
            this.Controls.Add(this.btn_AsignarProfeAMateria);
            this.Controls.Add(this.pct_Fondo);
            this.MaximizeBox = false;
            this.Name = "frm_OpcionesMateriaAsignarProfesor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opciones";
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pct_Fondo;
        private Button btn_AsignarProfeAMateria;
        private Button btn_AsignarProfesorACorrelativa;
    }
}