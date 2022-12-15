namespace SistemaUTN
{
    partial class frm_Profesor
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
            this.btn_CrearExamen = new System.Windows.Forms.Button();
            this.btn_PonerNotas = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_MateriasYAlumnos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CrearExamen
            // 
            this.btn_CrearExamen.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_CrearExamen.BackColor = System.Drawing.Color.Black;
            this.btn_CrearExamen.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_CrearExamen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CrearExamen.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CrearExamen.ForeColor = System.Drawing.Color.Transparent;
            this.btn_CrearExamen.Location = new System.Drawing.Point(128, 64);
            this.btn_CrearExamen.Name = "btn_CrearExamen";
            this.btn_CrearExamen.Size = new System.Drawing.Size(253, 32);
            this.btn_CrearExamen.TabIndex = 1;
            this.btn_CrearExamen.Text = "Crear examen";
            this.btn_CrearExamen.UseVisualStyleBackColor = false;
            this.btn_CrearExamen.Click += new System.EventHandler(this.btn_CrearExamen_Click);
            // 
            // btn_PonerNotas
            // 
            this.btn_PonerNotas.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_PonerNotas.BackColor = System.Drawing.Color.Black;
            this.btn_PonerNotas.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_PonerNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PonerNotas.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_PonerNotas.ForeColor = System.Drawing.Color.Transparent;
            this.btn_PonerNotas.Location = new System.Drawing.Point(128, 123);
            this.btn_PonerNotas.Name = "btn_PonerNotas";
            this.btn_PonerNotas.Size = new System.Drawing.Size(253, 32);
            this.btn_PonerNotas.TabIndex = 2;
            this.btn_PonerNotas.Text = "Ingresar notas";
            this.btn_PonerNotas.UseVisualStyleBackColor = false;
            this.btn_PonerNotas.Click += new System.EventHandler(this.btn_PonerNotas_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_Salir.BackColor = System.Drawing.Color.Black;
            this.btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Salir.Location = new System.Drawing.Point(128, 240);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(253, 32);
            this.btn_Salir.TabIndex = 3;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_MateriasYAlumnos
            // 
            this.btn_MateriasYAlumnos.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_MateriasYAlumnos.BackColor = System.Drawing.Color.Black;
            this.btn_MateriasYAlumnos.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_MateriasYAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MateriasYAlumnos.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_MateriasYAlumnos.ForeColor = System.Drawing.Color.Transparent;
            this.btn_MateriasYAlumnos.Location = new System.Drawing.Point(128, 185);
            this.btn_MateriasYAlumnos.Name = "btn_MateriasYAlumnos";
            this.btn_MateriasYAlumnos.Size = new System.Drawing.Size(253, 32);
            this.btn_MateriasYAlumnos.TabIndex = 4;
            this.btn_MateriasYAlumnos.Text = "Materias y alumnos";
            this.btn_MateriasYAlumnos.UseVisualStyleBackColor = false;
            this.btn_MateriasYAlumnos.Click += new System.EventHandler(this.btn_MateriasYAlumnos_Click);
            // 
            // frm_Profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaUTN.Properties.Resources.Oscuro1;
            this.ClientSize = new System.Drawing.Size(503, 332);
            this.Controls.Add(this.btn_MateriasYAlumnos);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_PonerNotas);
            this.Controls.Add(this.btn_CrearExamen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Profesor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_CrearExamen;
        private Button btn_PonerNotas;
        private Button btn_Salir;
        private Button btn_MateriasYAlumnos;
    }
}