namespace SistemaUTN
{
    partial class frm_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.pctb_LogoUTN = new System.Windows.Forms.PictureBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.txt_EmailIngresado = new System.Windows.Forms.TextBox();
            this.txt_ContraseñaIngresada = new System.Windows.Forms.TextBox();
            this.btn_IniciarSesion = new System.Windows.Forms.Button();
            this.btn_AutocompletarComoAdministrador = new System.Windows.Forms.Button();
            this.btn_AutocompletarComoProfesor = new System.Windows.Forms.Button();
            this.btn_AutocompletarComoAlumno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_LogoUTN)).BeginInit();
            this.SuspendLayout();
            // 
            // pctb_LogoUTN
            // 
            this.pctb_LogoUTN.Image = ((System.Drawing.Image)(resources.GetObject("pctb_LogoUTN.Image")));
            this.pctb_LogoUTN.Location = new System.Drawing.Point(-1, -4);
            this.pctb_LogoUTN.Name = "pctb_LogoUTN";
            this.pctb_LogoUTN.Size = new System.Drawing.Size(424, 420);
            this.pctb_LogoUTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctb_LogoUTN.TabIndex = 0;
            this.pctb_LogoUTN.TabStop = false;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Email.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Email.Location = new System.Drawing.Point(450, 29);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(151, 22);
            this.lbl_Email.TabIndex = 1;
            this.lbl_Email.Text = "Ingrese su email:";
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Contraseña.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Contraseña.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Contraseña.Location = new System.Drawing.Point(450, 101);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(199, 22);
            this.lbl_Contraseña.TabIndex = 2;
            this.lbl_Contraseña.Text = "Ingrese su contraseña:";
            // 
            // txt_EmailIngresado
            // 
            this.txt_EmailIngresado.Location = new System.Drawing.Point(451, 54);
            this.txt_EmailIngresado.Name = "txt_EmailIngresado";
            this.txt_EmailIngresado.PlaceholderText = "Email";
            this.txt_EmailIngresado.Size = new System.Drawing.Size(271, 27);
            this.txt_EmailIngresado.TabIndex = 3;
            // 
            // txt_ContraseñaIngresada
            // 
            this.txt_ContraseñaIngresada.Location = new System.Drawing.Point(451, 126);
            this.txt_ContraseñaIngresada.Name = "txt_ContraseñaIngresada";
            this.txt_ContraseñaIngresada.PasswordChar = '*';
            this.txt_ContraseñaIngresada.PlaceholderText = "Contraseña";
            this.txt_ContraseñaIngresada.Size = new System.Drawing.Size(271, 27);
            this.txt_ContraseñaIngresada.TabIndex = 4;
            // 
            // btn_IniciarSesion
            // 
            this.btn_IniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_IniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IniciarSesion.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_IniciarSesion.Location = new System.Drawing.Point(452, 159);
            this.btn_IniciarSesion.Name = "btn_IniciarSesion";
            this.btn_IniciarSesion.Size = new System.Drawing.Size(270, 29);
            this.btn_IniciarSesion.TabIndex = 5;
            this.btn_IniciarSesion.Text = "Iniciar sesion";
            this.btn_IniciarSesion.UseVisualStyleBackColor = false;
            this.btn_IniciarSesion.Click += new System.EventHandler(this.btn_IniciarSesion_Click);
            // 
            // btn_AutocompletarComoAdministrador
            // 
            this.btn_AutocompletarComoAdministrador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_AutocompletarComoAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AutocompletarComoAdministrador.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AutocompletarComoAdministrador.Location = new System.Drawing.Point(448, 283);
            this.btn_AutocompletarComoAdministrador.Name = "btn_AutocompletarComoAdministrador";
            this.btn_AutocompletarComoAdministrador.Size = new System.Drawing.Size(274, 29);
            this.btn_AutocompletarComoAdministrador.TabIndex = 6;
            this.btn_AutocompletarComoAdministrador.Text = "Autocompletar como administrador";
            this.btn_AutocompletarComoAdministrador.UseVisualStyleBackColor = false;
            this.btn_AutocompletarComoAdministrador.Click += new System.EventHandler(this.btn_AutocompletarComoAdministrador_Click);
            // 
            // btn_AutocompletarComoProfesor
            // 
            this.btn_AutocompletarComoProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_AutocompletarComoProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AutocompletarComoProfesor.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AutocompletarComoProfesor.Location = new System.Drawing.Point(448, 318);
            this.btn_AutocompletarComoProfesor.Name = "btn_AutocompletarComoProfesor";
            this.btn_AutocompletarComoProfesor.Size = new System.Drawing.Size(274, 29);
            this.btn_AutocompletarComoProfesor.TabIndex = 7;
            this.btn_AutocompletarComoProfesor.Text = "Autocompletar como profesor";
            this.btn_AutocompletarComoProfesor.UseVisualStyleBackColor = false;
            this.btn_AutocompletarComoProfesor.Click += new System.EventHandler(this.btn_AutocompletarComoProfesor_Click);
            // 
            // btn_AutocompletarComoAlumno
            // 
            this.btn_AutocompletarComoAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_AutocompletarComoAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AutocompletarComoAlumno.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AutocompletarComoAlumno.Location = new System.Drawing.Point(448, 353);
            this.btn_AutocompletarComoAlumno.Name = "btn_AutocompletarComoAlumno";
            this.btn_AutocompletarComoAlumno.Size = new System.Drawing.Size(274, 29);
            this.btn_AutocompletarComoAlumno.TabIndex = 8;
            this.btn_AutocompletarComoAlumno.Text = "Autocompletar como alumno";
            this.btn_AutocompletarComoAlumno.UseVisualStyleBackColor = false;
            this.btn_AutocompletarComoAlumno.Click += new System.EventHandler(this.btn_AutocompletarComoAlumno_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::SistemaUTN.Properties.Resources.Oscuro1;
            this.ClientSize = new System.Drawing.Size(753, 414);
            this.Controls.Add(this.btn_AutocompletarComoAlumno);
            this.Controls.Add(this.btn_AutocompletarComoProfesor);
            this.Controls.Add(this.btn_AutocompletarComoAdministrador);
            this.Controls.Add(this.btn_IniciarSesion);
            this.Controls.Add(this.txt_ContraseñaIngresada);
            this.Controls.Add(this.txt_EmailIngresado);
            this.Controls.Add(this.lbl_Contraseña);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.pctb_LogoUTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sesion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pctb_LogoUTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pctb_LogoUTN;
        private Label lbl_Email;
        private Label lbl_Contraseña;
        private TextBox txt_EmailIngresado;
        private TextBox txt_ContraseñaIngresada;
        private Button btn_IniciarSesion;
        private Button btn_AutocompletarComoAdministrador;
        private Button btn_AutocompletarComoProfesor;
        private Button btn_AutocompletarComoAlumno;
    }
}