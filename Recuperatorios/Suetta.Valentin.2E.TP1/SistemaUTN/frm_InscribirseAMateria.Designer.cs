namespace SistemaUTN
{
    partial class frm_InscribirseAMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_InscribirseAMateria));
            this.pct_ImagenFondo = new System.Windows.Forms.PictureBox();
            this.lst_MateriasDisponibles = new System.Windows.Forms.ListBox();
            this.lst_CorrelativasDisponibles = new System.Windows.Forms.ListBox();
            this.lbl_Materias = new System.Windows.Forms.Label();
            this.lbl_CorrelativasDisponibles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pct_ImagenFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_ImagenFondo
            // 
            this.pct_ImagenFondo.BackColor = System.Drawing.Color.Transparent;
            this.pct_ImagenFondo.Image = ((System.Drawing.Image)(resources.GetObject("pct_ImagenFondo.Image")));
            this.pct_ImagenFondo.Location = new System.Drawing.Point(0, 0);
            this.pct_ImagenFondo.Name = "pct_ImagenFondo";
            this.pct_ImagenFondo.Size = new System.Drawing.Size(1080, 521);
            this.pct_ImagenFondo.TabIndex = 0;
            this.pct_ImagenFondo.TabStop = false;
            // 
            // lst_MateriasDisponibles
            // 
            this.lst_MateriasDisponibles.FormattingEnabled = true;
            this.lst_MateriasDisponibles.ItemHeight = 20;
            this.lst_MateriasDisponibles.Location = new System.Drawing.Point(5, 44);
            this.lst_MateriasDisponibles.Name = "lst_MateriasDisponibles";
            this.lst_MateriasDisponibles.Size = new System.Drawing.Size(513, 464);
            this.lst_MateriasDisponibles.TabIndex = 1;
            this.lst_MateriasDisponibles.DoubleClick += new System.EventHandler(this.lst_MateriasDisponibles_DoubleClick);
            // 
            // lst_CorrelativasDisponibles
            // 
            this.lst_CorrelativasDisponibles.FormattingEnabled = true;
            this.lst_CorrelativasDisponibles.ItemHeight = 20;
            this.lst_CorrelativasDisponibles.Location = new System.Drawing.Point(524, 44);
            this.lst_CorrelativasDisponibles.Name = "lst_CorrelativasDisponibles";
            this.lst_CorrelativasDisponibles.Size = new System.Drawing.Size(548, 464);
            this.lst_CorrelativasDisponibles.TabIndex = 2;
            // 
            // lbl_Materias
            // 
            this.lbl_Materias.AutoSize = true;
            this.lbl_Materias.Location = new System.Drawing.Point(178, 9);
            this.lbl_Materias.Name = "lbl_Materias";
            this.lbl_Materias.Size = new System.Drawing.Size(146, 20);
            this.lbl_Materias.TabIndex = 3;
            this.lbl_Materias.Text = "Materias disponibles";
            // 
            // lbl_CorrelativasDisponibles
            // 
            this.lbl_CorrelativasDisponibles.AutoSize = true;
            this.lbl_CorrelativasDisponibles.Location = new System.Drawing.Point(708, 9);
            this.lbl_CorrelativasDisponibles.Name = "lbl_CorrelativasDisponibles";
            this.lbl_CorrelativasDisponibles.Size = new System.Drawing.Size(167, 20);
            this.lbl_CorrelativasDisponibles.TabIndex = 4;
            this.lbl_CorrelativasDisponibles.Text = "Correlativas disponibles";
            // 
            // frm_InscribirseAMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 520);
            this.Controls.Add(this.lbl_CorrelativasDisponibles);
            this.Controls.Add(this.lbl_Materias);
            this.Controls.Add(this.lst_CorrelativasDisponibles);
            this.Controls.Add(this.lst_MateriasDisponibles);
            this.Controls.Add(this.pct_ImagenFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_InscribirseAMateria";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscribirse a materia";
            this.Load += new System.EventHandler(this.frm_InscribirseAMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct_ImagenFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pct_ImagenFondo;
        private ListBox lst_MateriasDisponibles;
        private ListBox lst_CorrelativasDisponibles;
        private Label lbl_Materias;
        private Label lbl_CorrelativasDisponibles;
    }
}