namespace SistemaUTN
{
    partial class frm_AlumnosInscriptos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AlumnosInscriptos));
            this.pct_Fondo = new System.Windows.Forms.PictureBox();
            this.lst_ListadoDeInscripcionesMaterias = new System.Windows.Forms.ListBox();
            this.lst_ListadoDeInscripcionesCorrelativas = new System.Windows.Forms.ListBox();
            this.lbl_InscripcionesAMaterias = new System.Windows.Forms.Label();
            this.lbl_InscripcionesACorrelativas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_Fondo
            // 
            this.pct_Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pct_Fondo.Image")));
            this.pct_Fondo.Location = new System.Drawing.Point(-4, 1);
            this.pct_Fondo.Name = "pct_Fondo";
            this.pct_Fondo.Size = new System.Drawing.Size(1542, 484);
            this.pct_Fondo.TabIndex = 0;
            this.pct_Fondo.TabStop = false;
            // 
            // lst_ListadoDeInscripcionesMaterias
            // 
            this.lst_ListadoDeInscripcionesMaterias.FormattingEnabled = true;
            this.lst_ListadoDeInscripcionesMaterias.ItemHeight = 20;
            this.lst_ListadoDeInscripcionesMaterias.Location = new System.Drawing.Point(12, 51);
            this.lst_ListadoDeInscripcionesMaterias.Name = "lst_ListadoDeInscripcionesMaterias";
            this.lst_ListadoDeInscripcionesMaterias.Size = new System.Drawing.Size(739, 424);
            this.lst_ListadoDeInscripcionesMaterias.TabIndex = 1;
            this.lst_ListadoDeInscripcionesMaterias.DoubleClick += new System.EventHandler(this.lst_ListadoDeInscripcionesMaterias_DoubleClick);
            // 
            // lst_ListadoDeInscripcionesCorrelativas
            // 
            this.lst_ListadoDeInscripcionesCorrelativas.FormattingEnabled = true;
            this.lst_ListadoDeInscripcionesCorrelativas.ItemHeight = 20;
            this.lst_ListadoDeInscripcionesCorrelativas.Location = new System.Drawing.Point(779, 51);
            this.lst_ListadoDeInscripcionesCorrelativas.Name = "lst_ListadoDeInscripcionesCorrelativas";
            this.lst_ListadoDeInscripcionesCorrelativas.Size = new System.Drawing.Size(739, 424);
            this.lst_ListadoDeInscripcionesCorrelativas.TabIndex = 2;
            this.lst_ListadoDeInscripcionesCorrelativas.DoubleClick += new System.EventHandler(this.lst_ListadoDeInscripcionesCorrelativas_DoubleClick);
            // 
            // lbl_InscripcionesAMaterias
            // 
            this.lbl_InscripcionesAMaterias.AutoSize = true;
            this.lbl_InscripcionesAMaterias.Location = new System.Drawing.Point(303, 18);
            this.lbl_InscripcionesAMaterias.Name = "lbl_InscripcionesAMaterias";
            this.lbl_InscripcionesAMaterias.Size = new System.Drawing.Size(167, 20);
            this.lbl_InscripcionesAMaterias.TabIndex = 3;
            this.lbl_InscripcionesAMaterias.Text = "Inscripciones a materias";
            // 
            // lbl_InscripcionesACorrelativas
            // 
            this.lbl_InscripcionesACorrelativas.AutoSize = true;
            this.lbl_InscripcionesACorrelativas.Location = new System.Drawing.Point(1072, 18);
            this.lbl_InscripcionesACorrelativas.Name = "lbl_InscripcionesACorrelativas";
            this.lbl_InscripcionesACorrelativas.Size = new System.Drawing.Size(186, 20);
            this.lbl_InscripcionesACorrelativas.TabIndex = 4;
            this.lbl_InscripcionesACorrelativas.Text = "Inscripciones a correlativas";
            // 
            // frm_AlumnosInscriptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1532, 481);
            this.Controls.Add(this.lbl_InscripcionesACorrelativas);
            this.Controls.Add(this.lbl_InscripcionesAMaterias);
            this.Controls.Add(this.lst_ListadoDeInscripcionesCorrelativas);
            this.Controls.Add(this.lst_ListadoDeInscripcionesMaterias);
            this.Controls.Add(this.pct_Fondo);
            this.MaximizeBox = false;
            this.Name = "frm_AlumnosInscriptos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnos inscriptos";
            this.Load += new System.EventHandler(this.frm_AlumnosInscriptos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pct_Fondo;
        private ListBox lst_ListadoDeInscripcionesMaterias;
        private ListBox lst_ListadoDeInscripcionesCorrelativas;
        private Label lbl_InscripcionesAMaterias;
        private Label lbl_InscripcionesACorrelativas;
    }
}