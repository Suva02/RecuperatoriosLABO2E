namespace SistemaUTN
{
    partial class frm_ModificarEstadoCorrelativa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ModificarEstadoCorrelativa));
            this.pct_Fondo = new System.Windows.Forms.PictureBox();
            this.lbl_Condicion = new System.Windows.Forms.Label();
            this.txt_NuevaCondicion = new System.Windows.Forms.TextBox();
            this.btn_ModificarEstado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_Fondo
            // 
            this.pct_Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pct_Fondo.Image")));
            this.pct_Fondo.Location = new System.Drawing.Point(0, -1);
            this.pct_Fondo.Name = "pct_Fondo";
            this.pct_Fondo.Size = new System.Drawing.Size(230, 205);
            this.pct_Fondo.TabIndex = 0;
            this.pct_Fondo.TabStop = false;
            // 
            // lbl_Condicion
            // 
            this.lbl_Condicion.AutoSize = true;
            this.lbl_Condicion.Location = new System.Drawing.Point(75, 48);
            this.lbl_Condicion.Name = "lbl_Condicion";
            this.lbl_Condicion.Size = new System.Drawing.Size(76, 20);
            this.lbl_Condicion.TabIndex = 2;
            this.lbl_Condicion.Text = "Condicion";
            // 
            // txt_NuevaCondicion
            // 
            this.txt_NuevaCondicion.Location = new System.Drawing.Point(37, 88);
            this.txt_NuevaCondicion.Name = "txt_NuevaCondicion";
            this.txt_NuevaCondicion.Size = new System.Drawing.Size(154, 27);
            this.txt_NuevaCondicion.TabIndex = 3;
            // 
            // btn_ModificarEstado
            // 
            this.btn_ModificarEstado.AutoEllipsis = true;
            this.btn_ModificarEstado.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_ModificarEstado.FlatAppearance.BorderSize = 0;
            this.btn_ModificarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModificarEstado.Location = new System.Drawing.Point(37, 121);
            this.btn_ModificarEstado.Name = "btn_ModificarEstado";
            this.btn_ModificarEstado.Size = new System.Drawing.Size(154, 31);
            this.btn_ModificarEstado.TabIndex = 4;
            this.btn_ModificarEstado.Text = "Modificar";
            this.btn_ModificarEstado.UseVisualStyleBackColor = false;
            this.btn_ModificarEstado.Click += new System.EventHandler(this.btn_ModificarEstado_Click);
            // 
            // frm_ModificarEstadoCorrelativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 203);
            this.Controls.Add(this.btn_ModificarEstado);
            this.Controls.Add(this.txt_NuevaCondicion);
            this.Controls.Add(this.lbl_Condicion);
            this.Controls.Add(this.pct_Fondo);
            this.MaximizeBox = false;
            this.Name = "frm_ModificarEstadoCorrelativa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estado";
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pct_Fondo;
        private Label lbl_Condicion;
        private TextBox txt_NuevaCondicion;
        private Button btn_ModificarEstado;
    }
}