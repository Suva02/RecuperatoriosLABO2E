namespace SistemaUTN
{
    partial class frm_ImportarAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ImportarAlumnos));
            this.pct_Fondo = new System.Windows.Forms.PictureBox();
            this.lst_AlumnosAImportar = new System.Windows.Forms.ListBox();
            this.btn_Importar = new System.Windows.Forms.Button();
            this.lbl_AlumnosDisponibles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_Fondo
            // 
            this.pct_Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pct_Fondo.Image")));
            this.pct_Fondo.Location = new System.Drawing.Point(-1, -3);
            this.pct_Fondo.Name = "pct_Fondo";
            this.pct_Fondo.Size = new System.Drawing.Size(803, 481);
            this.pct_Fondo.TabIndex = 0;
            this.pct_Fondo.TabStop = false;
            // 
            // lst_AlumnosAImportar
            // 
            this.lst_AlumnosAImportar.FormattingEnabled = true;
            this.lst_AlumnosAImportar.ItemHeight = 20;
            this.lst_AlumnosAImportar.Location = new System.Drawing.Point(12, 43);
            this.lst_AlumnosAImportar.Name = "lst_AlumnosAImportar";
            this.lst_AlumnosAImportar.Size = new System.Drawing.Size(776, 384);
            this.lst_AlumnosAImportar.TabIndex = 1;
            // 
            // btn_Importar
            // 
            this.btn_Importar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Importar.FlatAppearance.BorderSize = 0;
            this.btn_Importar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Importar.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Importar.Location = new System.Drawing.Point(271, 433);
            this.btn_Importar.Name = "btn_Importar";
            this.btn_Importar.Size = new System.Drawing.Size(250, 29);
            this.btn_Importar.TabIndex = 2;
            this.btn_Importar.Text = "Importar alumnos";
            this.btn_Importar.UseVisualStyleBackColor = false;
            this.btn_Importar.Click += new System.EventHandler(this.btn_Importar_Click);
            // 
            // lbl_AlumnosDisponibles
            // 
            this.lbl_AlumnosDisponibles.AutoSize = true;
            this.lbl_AlumnosDisponibles.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_AlumnosDisponibles.Location = new System.Drawing.Point(280, 20);
            this.lbl_AlumnosDisponibles.Name = "lbl_AlumnosDisponibles";
            this.lbl_AlumnosDisponibles.Size = new System.Drawing.Size(259, 20);
            this.lbl_AlumnosDisponibles.TabIndex = 3;
            this.lbl_AlumnosDisponibles.Text = "Alumnos disponibles para importar";
            // 
            // frm_ImportarAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.lbl_AlumnosDisponibles);
            this.Controls.Add(this.btn_Importar);
            this.Controls.Add(this.lst_AlumnosAImportar);
            this.Controls.Add(this.pct_Fondo);
            this.Name = "frm_ImportarAlumnos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar alumnos";
            this.Load += new System.EventHandler(this.frm_ImportarAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pct_Fondo;
        private ListBox lst_AlumnosAImportar;
        private Button btn_Importar;
        private Label lbl_AlumnosDisponibles;
    }
}