namespace SistemaUTN
{
    partial class frm_AltaUsuario
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
            this.txt_NombreUsuario = new System.Windows.Forms.TextBox();
            this.txt_ApellidoUsuario = new System.Windows.Forms.TextBox();
            this.txt_EmailUsuario = new System.Windows.Forms.TextBox();
            this.txt_ContraseñaUsuario = new System.Windows.Forms.TextBox();
            this.lbl_NombreUsuario = new System.Windows.Forms.Label();
            this.lbl_ApellidoUsuario = new System.Windows.Forms.Label();
            this.lbl_EmailUsuario = new System.Windows.Forms.Label();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.cmb_TipoDeUsuario = new System.Windows.Forms.ComboBox();
            this.lbl_TipoDeUsuario = new System.Windows.Forms.Label();
            this.btn_CrearUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_NombreUsuario
            // 
            this.txt_NombreUsuario.Location = new System.Drawing.Point(167, 30);
            this.txt_NombreUsuario.MaxLength = 40;
            this.txt_NombreUsuario.Name = "txt_NombreUsuario";
            this.txt_NombreUsuario.Size = new System.Drawing.Size(180, 27);
            this.txt_NombreUsuario.TabIndex = 0;
            // 
            // txt_ApellidoUsuario
            // 
            this.txt_ApellidoUsuario.Location = new System.Drawing.Point(167, 97);
            this.txt_ApellidoUsuario.MaxLength = 40;
            this.txt_ApellidoUsuario.Name = "txt_ApellidoUsuario";
            this.txt_ApellidoUsuario.Size = new System.Drawing.Size(180, 27);
            this.txt_ApellidoUsuario.TabIndex = 1;
            // 
            // txt_EmailUsuario
            // 
            this.txt_EmailUsuario.Location = new System.Drawing.Point(167, 158);
            this.txt_EmailUsuario.MaxLength = 50;
            this.txt_EmailUsuario.Name = "txt_EmailUsuario";
            this.txt_EmailUsuario.Size = new System.Drawing.Size(180, 27);
            this.txt_EmailUsuario.TabIndex = 2;
            // 
            // txt_ContraseñaUsuario
            // 
            this.txt_ContraseñaUsuario.Location = new System.Drawing.Point(169, 220);
            this.txt_ContraseñaUsuario.MaxLength = 40;
            this.txt_ContraseñaUsuario.Name = "txt_ContraseñaUsuario";
            this.txt_ContraseñaUsuario.Size = new System.Drawing.Size(178, 27);
            this.txt_ContraseñaUsuario.TabIndex = 3;
            // 
            // lbl_NombreUsuario
            // 
            this.lbl_NombreUsuario.AutoSize = true;
            this.lbl_NombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NombreUsuario.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_NombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lbl_NombreUsuario.Location = new System.Drawing.Point(168, 9);
            this.lbl_NombreUsuario.Name = "lbl_NombreUsuario";
            this.lbl_NombreUsuario.Size = new System.Drawing.Size(140, 18);
            this.lbl_NombreUsuario.TabIndex = 4;
            this.lbl_NombreUsuario.Text = "Nombre del usuario";
            // 
            // lbl_ApellidoUsuario
            // 
            this.lbl_ApellidoUsuario.AutoSize = true;
            this.lbl_ApellidoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ApellidoUsuario.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ApellidoUsuario.ForeColor = System.Drawing.Color.White;
            this.lbl_ApellidoUsuario.Location = new System.Drawing.Point(168, 76);
            this.lbl_ApellidoUsuario.Name = "lbl_ApellidoUsuario";
            this.lbl_ApellidoUsuario.Size = new System.Drawing.Size(140, 18);
            this.lbl_ApellidoUsuario.TabIndex = 5;
            this.lbl_ApellidoUsuario.Text = "Apellido del usuario";
            // 
            // lbl_EmailUsuario
            // 
            this.lbl_EmailUsuario.AutoSize = true;
            this.lbl_EmailUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_EmailUsuario.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_EmailUsuario.ForeColor = System.Drawing.Color.White;
            this.lbl_EmailUsuario.Location = new System.Drawing.Point(168, 137);
            this.lbl_EmailUsuario.Name = "lbl_EmailUsuario";
            this.lbl_EmailUsuario.Size = new System.Drawing.Size(124, 18);
            this.lbl_EmailUsuario.TabIndex = 6;
            this.lbl_EmailUsuario.Text = "Email del usuario";
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Contraseña.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Contraseña.ForeColor = System.Drawing.Color.White;
            this.lbl_Contraseña.Location = new System.Drawing.Point(167, 199);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(162, 18);
            this.lbl_Contraseña.TabIndex = 7;
            this.lbl_Contraseña.Text = "Contraseña del usuario";
            // 
            // cmb_TipoDeUsuario
            // 
            this.cmb_TipoDeUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoDeUsuario.FormattingEnabled = true;
            this.cmb_TipoDeUsuario.Items.AddRange(new object[] {
            "",
            "Administrador",
            "Profesor",
            "Alumno"});
            this.cmb_TipoDeUsuario.Location = new System.Drawing.Point(169, 280);
            this.cmb_TipoDeUsuario.Name = "cmb_TipoDeUsuario";
            this.cmb_TipoDeUsuario.Size = new System.Drawing.Size(178, 28);
            this.cmb_TipoDeUsuario.TabIndex = 8;
            // 
            // lbl_TipoDeUsuario
            // 
            this.lbl_TipoDeUsuario.AutoSize = true;
            this.lbl_TipoDeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TipoDeUsuario.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TipoDeUsuario.ForeColor = System.Drawing.Color.White;
            this.lbl_TipoDeUsuario.Location = new System.Drawing.Point(169, 259);
            this.lbl_TipoDeUsuario.Name = "lbl_TipoDeUsuario";
            this.lbl_TipoDeUsuario.Size = new System.Drawing.Size(109, 18);
            this.lbl_TipoDeUsuario.TabIndex = 9;
            this.lbl_TipoDeUsuario.Text = "Tipo de usuario";
            // 
            // btn_CrearUsuario
            // 
            this.btn_CrearUsuario.BackColor = System.Drawing.Color.Black;
            this.btn_CrearUsuario.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_CrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CrearUsuario.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CrearUsuario.ForeColor = System.Drawing.Color.Transparent;
            this.btn_CrearUsuario.Location = new System.Drawing.Point(169, 331);
            this.btn_CrearUsuario.Name = "btn_CrearUsuario";
            this.btn_CrearUsuario.Size = new System.Drawing.Size(178, 33);
            this.btn_CrearUsuario.TabIndex = 10;
            this.btn_CrearUsuario.Text = "Crear usuario";
            this.btn_CrearUsuario.UseVisualStyleBackColor = false;
            this.btn_CrearUsuario.Click += new System.EventHandler(this.btn_CrearUsuario_Click);
            // 
            // frm_AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaUTN.Properties.Resources.Oscuro11;
            this.ClientSize = new System.Drawing.Size(519, 406);
            this.Controls.Add(this.btn_CrearUsuario);
            this.Controls.Add(this.lbl_TipoDeUsuario);
            this.Controls.Add(this.cmb_TipoDeUsuario);
            this.Controls.Add(this.lbl_Contraseña);
            this.Controls.Add(this.lbl_EmailUsuario);
            this.Controls.Add(this.lbl_ApellidoUsuario);
            this.Controls.Add(this.lbl_NombreUsuario);
            this.Controls.Add(this.txt_ContraseñaUsuario);
            this.Controls.Add(this.txt_EmailUsuario);
            this.Controls.Add(this.txt_ApellidoUsuario);
            this.Controls.Add(this.txt_NombreUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AltaUsuario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_NombreUsuario;
        private TextBox txt_ApellidoUsuario;
        private TextBox txt_EmailUsuario;
        private TextBox txt_ContraseñaUsuario;
        private Label lbl_NombreUsuario;
        private Label lbl_ApellidoUsuario;
        private Label lbl_EmailUsuario;
        private Label lbl_Contraseña;
        private ComboBox cmb_TipoDeUsuario;
        private Label lbl_TipoDeUsuario;
        private Button btn_CrearUsuario;
    }
}