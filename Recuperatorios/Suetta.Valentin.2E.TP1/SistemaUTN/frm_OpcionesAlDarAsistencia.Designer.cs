namespace SistemaUTN
{
    partial class frm_OpcionesAlDarAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_OpcionesAlDarAsistencia));
            this.pct_Fondo = new System.Windows.Forms.PictureBox();
            this.btn_AsistenciaEnMateria = new System.Windows.Forms.Button();
            this.btn_DarAsistenciaCorrelativa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_Fondo
            // 
            this.pct_Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pct_Fondo.Image")));
            this.pct_Fondo.Location = new System.Drawing.Point(-3, -1);
            this.pct_Fondo.Name = "pct_Fondo";
            this.pct_Fondo.Size = new System.Drawing.Size(369, 219);
            this.pct_Fondo.TabIndex = 0;
            this.pct_Fondo.TabStop = false;
            // 
            // btn_AsistenciaEnMateria
            // 
            this.btn_AsistenciaEnMateria.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_AsistenciaEnMateria.FlatAppearance.BorderSize = 0;
            this.btn_AsistenciaEnMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AsistenciaEnMateria.Location = new System.Drawing.Point(69, 56);
            this.btn_AsistenciaEnMateria.Name = "btn_AsistenciaEnMateria";
            this.btn_AsistenciaEnMateria.Size = new System.Drawing.Size(216, 29);
            this.btn_AsistenciaEnMateria.TabIndex = 1;
            this.btn_AsistenciaEnMateria.Text = "Dar asistencia en materia";
            this.btn_AsistenciaEnMateria.UseVisualStyleBackColor = false;
            this.btn_AsistenciaEnMateria.Click += new System.EventHandler(this.btn_AsistenciaEnMateria_Click);
            // 
            // btn_DarAsistenciaCorrelativa
            // 
            this.btn_DarAsistenciaCorrelativa.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_DarAsistenciaCorrelativa.FlatAppearance.BorderSize = 0;
            this.btn_DarAsistenciaCorrelativa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DarAsistenciaCorrelativa.Location = new System.Drawing.Point(69, 127);
            this.btn_DarAsistenciaCorrelativa.Name = "btn_DarAsistenciaCorrelativa";
            this.btn_DarAsistenciaCorrelativa.Size = new System.Drawing.Size(216, 29);
            this.btn_DarAsistenciaCorrelativa.TabIndex = 2;
            this.btn_DarAsistenciaCorrelativa.Text = "Dar asistencia en correlativa";
            this.btn_DarAsistenciaCorrelativa.UseVisualStyleBackColor = false;
            this.btn_DarAsistenciaCorrelativa.Click += new System.EventHandler(this.btn_DarAsistenciaCorrelativa_Click);
            // 
            // frm_OpcionesAlDarAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 217);
            this.Controls.Add(this.btn_DarAsistenciaCorrelativa);
            this.Controls.Add(this.btn_AsistenciaEnMateria);
            this.Controls.Add(this.pct_Fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_OpcionesAlDarAsistencia";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opciones";
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pct_Fondo;
        private Button btn_AsistenciaEnMateria;
        private Button btn_DarAsistenciaCorrelativa;
    }
}