namespace SistemaUTN
{
    partial class frm_SeleccionarProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SeleccionarProfesor));
            this.pct_Fondo = new System.Windows.Forms.PictureBox();
            this.lbl_SeleccionarProfesor = new System.Windows.Forms.Label();
            this.lst_Profesores = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_Fondo
            // 
            this.pct_Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pct_Fondo.Image")));
            this.pct_Fondo.Location = new System.Drawing.Point(0, 0);
            this.pct_Fondo.Name = "pct_Fondo";
            this.pct_Fondo.Size = new System.Drawing.Size(805, 455);
            this.pct_Fondo.TabIndex = 0;
            this.pct_Fondo.TabStop = false;
            // 
            // lbl_SeleccionarProfesor
            // 
            this.lbl_SeleccionarProfesor.AutoSize = true;
            this.lbl_SeleccionarProfesor.Location = new System.Drawing.Point(321, 26);
            this.lbl_SeleccionarProfesor.Name = "lbl_SeleccionarProfesor";
            this.lbl_SeleccionarProfesor.Size = new System.Drawing.Size(160, 20);
            this.lbl_SeleccionarProfesor.TabIndex = 3;
            this.lbl_SeleccionarProfesor.Text = "Seleccione un profesor";
            // 
            // lst_Profesores
            // 
            this.lst_Profesores.FormattingEnabled = true;
            this.lst_Profesores.ItemHeight = 20;
            this.lst_Profesores.Location = new System.Drawing.Point(12, 59);
            this.lst_Profesores.Name = "lst_Profesores";
            this.lst_Profesores.Size = new System.Drawing.Size(776, 364);
            this.lst_Profesores.TabIndex = 4;
            this.lst_Profesores.DoubleClick += new System.EventHandler(this.lst_Profesores_DoubleClick);
            // 
            // frm_SeleccionarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst_Profesores);
            this.Controls.Add(this.lbl_SeleccionarProfesor);
            this.Controls.Add(this.pct_Fondo);
            this.Name = "frm_SeleccionarProfesor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar profesor";
            this.Load += new System.EventHandler(this.frm_SeleccionarProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pct_Fondo;
        private Label lbl_SeleccionarProfesor;
        private ListBox lst_Profesores;
    }
}