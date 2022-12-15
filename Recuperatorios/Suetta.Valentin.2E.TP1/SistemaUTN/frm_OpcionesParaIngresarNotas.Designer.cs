namespace SistemaUTN
{
    partial class frm_OpcionesParaIngresarNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_OpcionesParaIngresarNotas));
            this.pct_Fondo = new System.Windows.Forms.PictureBox();
            this.btn_IngresarNotasMaterias = new System.Windows.Forms.Button();
            this.btn_IngresarNotasCorrelativas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_Fondo
            // 
            this.pct_Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pct_Fondo.Image")));
            this.pct_Fondo.Location = new System.Drawing.Point(-2, 0);
            this.pct_Fondo.Name = "pct_Fondo";
            this.pct_Fondo.Size = new System.Drawing.Size(494, 304);
            this.pct_Fondo.TabIndex = 0;
            this.pct_Fondo.TabStop = false;
            // 
            // btn_IngresarNotasMaterias
            // 
            this.btn_IngresarNotasMaterias.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_IngresarNotasMaterias.FlatAppearance.BorderSize = 0;
            this.btn_IngresarNotasMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IngresarNotasMaterias.Location = new System.Drawing.Point(121, 84);
            this.btn_IngresarNotasMaterias.Name = "btn_IngresarNotasMaterias";
            this.btn_IngresarNotasMaterias.Size = new System.Drawing.Size(236, 29);
            this.btn_IngresarNotasMaterias.TabIndex = 1;
            this.btn_IngresarNotasMaterias.Text = "Ingresar notas en materias";
            this.btn_IngresarNotasMaterias.UseVisualStyleBackColor = false;
            this.btn_IngresarNotasMaterias.Click += new System.EventHandler(this.btn_IngresarNotasMaterias_Click);
            // 
            // btn_IngresarNotasCorrelativas
            // 
            this.btn_IngresarNotasCorrelativas.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_IngresarNotasCorrelativas.FlatAppearance.BorderSize = 0;
            this.btn_IngresarNotasCorrelativas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IngresarNotasCorrelativas.Location = new System.Drawing.Point(121, 163);
            this.btn_IngresarNotasCorrelativas.Name = "btn_IngresarNotasCorrelativas";
            this.btn_IngresarNotasCorrelativas.Size = new System.Drawing.Size(236, 29);
            this.btn_IngresarNotasCorrelativas.TabIndex = 2;
            this.btn_IngresarNotasCorrelativas.Text = "Ingresar notas en correlativas";
            this.btn_IngresarNotasCorrelativas.UseVisualStyleBackColor = false;
            this.btn_IngresarNotasCorrelativas.Click += new System.EventHandler(this.btn_IngresarNotasCorrelativas_Click);
            // 
            // frm_OpcionesParaIngresarNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 300);
            this.Controls.Add(this.btn_IngresarNotasCorrelativas);
            this.Controls.Add(this.btn_IngresarNotasMaterias);
            this.Controls.Add(this.pct_Fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_OpcionesParaIngresarNotas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opciones";
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pct_Fondo;
        private Button btn_IngresarNotasMaterias;
        private Button btn_IngresarNotasCorrelativas;
    }
}