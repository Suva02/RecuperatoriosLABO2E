namespace SistemaUTN
{
    partial class frm_Alumno
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
            this.btn_Inscribirse = new System.Windows.Forms.Button();
            this.btn_DarAsistencia = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_MateriasCursadas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Inscribirse
            // 
            this.btn_Inscribirse.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_Inscribirse.BackColor = System.Drawing.Color.Black;
            this.btn_Inscribirse.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Inscribirse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inscribirse.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Inscribirse.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Inscribirse.Location = new System.Drawing.Point(117, 53);
            this.btn_Inscribirse.Name = "btn_Inscribirse";
            this.btn_Inscribirse.Size = new System.Drawing.Size(253, 32);
            this.btn_Inscribirse.TabIndex = 2;
            this.btn_Inscribirse.Text = "Inscribirse a materia";
            this.btn_Inscribirse.UseVisualStyleBackColor = false;
            this.btn_Inscribirse.Click += new System.EventHandler(this.btn_Inscribirse_Click);
            // 
            // btn_DarAsistencia
            // 
            this.btn_DarAsistencia.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_DarAsistencia.BackColor = System.Drawing.Color.Black;
            this.btn_DarAsistencia.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_DarAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DarAsistencia.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DarAsistencia.ForeColor = System.Drawing.Color.Transparent;
            this.btn_DarAsistencia.Location = new System.Drawing.Point(117, 105);
            this.btn_DarAsistencia.Name = "btn_DarAsistencia";
            this.btn_DarAsistencia.Size = new System.Drawing.Size(253, 32);
            this.btn_DarAsistencia.TabIndex = 3;
            this.btn_DarAsistencia.Text = "Dar asistencia";
            this.btn_DarAsistencia.UseVisualStyleBackColor = false;
            this.btn_DarAsistencia.Click += new System.EventHandler(this.btn_DarAsistencia_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_Salir.BackColor = System.Drawing.Color.Black;
            this.btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Salir.Location = new System.Drawing.Point(117, 208);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(253, 32);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_MateriasCursadas
            // 
            this.btn_MateriasCursadas.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_MateriasCursadas.BackColor = System.Drawing.Color.Black;
            this.btn_MateriasCursadas.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_MateriasCursadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MateriasCursadas.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_MateriasCursadas.ForeColor = System.Drawing.Color.Transparent;
            this.btn_MateriasCursadas.Location = new System.Drawing.Point(117, 157);
            this.btn_MateriasCursadas.Name = "btn_MateriasCursadas";
            this.btn_MateriasCursadas.Size = new System.Drawing.Size(253, 32);
            this.btn_MateriasCursadas.TabIndex = 5;
            this.btn_MateriasCursadas.Text = "Materias cursadas";
            this.btn_MateriasCursadas.UseVisualStyleBackColor = false;
            this.btn_MateriasCursadas.Click += new System.EventHandler(this.btn_MateriasCursadas_Click);
            // 
            // frm_Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaUTN.Properties.Resources.Oscuro1;
            this.ClientSize = new System.Drawing.Size(474, 284);
            this.Controls.Add(this.btn_MateriasCursadas);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_DarAsistencia);
            this.Controls.Add(this.btn_Inscribirse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Alumno";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Inscribirse;
        private Button btn_DarAsistencia;
        private Button btn_Salir;
        private Button btn_MateriasCursadas;
    }
}