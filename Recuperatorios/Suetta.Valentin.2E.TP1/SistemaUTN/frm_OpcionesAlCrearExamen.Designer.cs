namespace SistemaUTN
{
    partial class frm_OpcionesAlCrearExamen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_OpcionesAlCrearExamen));
            this.pct_Fondo = new System.Windows.Forms.PictureBox();
            this.btn_CrearExamenMateria = new System.Windows.Forms.Button();
            this.btn_CrearExamenCorrelativa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_Fondo
            // 
            this.pct_Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pct_Fondo.Image")));
            this.pct_Fondo.Location = new System.Drawing.Point(0, 0);
            this.pct_Fondo.Name = "pct_Fondo";
            this.pct_Fondo.Size = new System.Drawing.Size(362, 207);
            this.pct_Fondo.TabIndex = 0;
            this.pct_Fondo.TabStop = false;
            // 
            // btn_CrearExamenMateria
            // 
            this.btn_CrearExamenMateria.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_CrearExamenMateria.FlatAppearance.BorderSize = 0;
            this.btn_CrearExamenMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CrearExamenMateria.Location = new System.Drawing.Point(65, 52);
            this.btn_CrearExamenMateria.Name = "btn_CrearExamenMateria";
            this.btn_CrearExamenMateria.Size = new System.Drawing.Size(221, 29);
            this.btn_CrearExamenMateria.TabIndex = 1;
            this.btn_CrearExamenMateria.Text = "Crear examen para materia";
            this.btn_CrearExamenMateria.UseVisualStyleBackColor = false;
            this.btn_CrearExamenMateria.Click += new System.EventHandler(this.btn_CrearExamenMateria_Click);
            // 
            // btn_CrearExamenCorrelativa
            // 
            this.btn_CrearExamenCorrelativa.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_CrearExamenCorrelativa.FlatAppearance.BorderSize = 0;
            this.btn_CrearExamenCorrelativa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CrearExamenCorrelativa.Location = new System.Drawing.Point(65, 114);
            this.btn_CrearExamenCorrelativa.Name = "btn_CrearExamenCorrelativa";
            this.btn_CrearExamenCorrelativa.Size = new System.Drawing.Size(221, 29);
            this.btn_CrearExamenCorrelativa.TabIndex = 2;
            this.btn_CrearExamenCorrelativa.Text = "Crear examen para correlativa";
            this.btn_CrearExamenCorrelativa.UseVisualStyleBackColor = false;
            this.btn_CrearExamenCorrelativa.Click += new System.EventHandler(this.btn_CrearExamenCorrelativa_Click);
            // 
            // frm_OpcionesAlCrearExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 205);
            this.Controls.Add(this.btn_CrearExamenCorrelativa);
            this.Controls.Add(this.btn_CrearExamenMateria);
            this.Controls.Add(this.pct_Fondo);
            this.MaximizeBox = false;
            this.Name = "frm_OpcionesAlCrearExamen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opciones";
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pct_Fondo;
        private Button btn_CrearExamenMateria;
        private Button btn_CrearExamenCorrelativa;
    }
}