namespace SistemaUTN
{
    partial class frm_SeleccionarAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SeleccionarAlumno));
            this.pct_Fondo = new System.Windows.Forms.PictureBox();
            this.lst_ListadoDeAlumnos = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_Fondo
            // 
            this.pct_Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pct_Fondo.Image")));
            this.pct_Fondo.Location = new System.Drawing.Point(-2, 0);
            this.pct_Fondo.Name = "pct_Fondo";
            this.pct_Fondo.Size = new System.Drawing.Size(805, 456);
            this.pct_Fondo.TabIndex = 0;
            this.pct_Fondo.TabStop = false;
            // 
            // lst_ListadoDeAlumnos
            // 
            this.lst_ListadoDeAlumnos.FormattingEnabled = true;
            this.lst_ListadoDeAlumnos.ItemHeight = 20;
            this.lst_ListadoDeAlumnos.Location = new System.Drawing.Point(12, 12);
            this.lst_ListadoDeAlumnos.Name = "lst_ListadoDeAlumnos";
            this.lst_ListadoDeAlumnos.Size = new System.Drawing.Size(776, 424);
            this.lst_ListadoDeAlumnos.TabIndex = 1;
            this.lst_ListadoDeAlumnos.DoubleClick += new System.EventHandler(this.lst_ListadoDeAlumnos_DoubleClick);
            // 
            // frm_SeleccionarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst_ListadoDeAlumnos);
            this.Controls.Add(this.pct_Fondo);
            this.Name = "frm_SeleccionarAlumno";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar alumno";
            this.Load += new System.EventHandler(this.frm_SeleccionarAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pct_Fondo;
        private ListBox lst_ListadoDeAlumnos;
    }
}