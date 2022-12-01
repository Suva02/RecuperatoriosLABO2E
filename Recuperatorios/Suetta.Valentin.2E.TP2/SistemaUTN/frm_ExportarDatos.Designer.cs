namespace SistemaUTN
{
    partial class frm_ExportarDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ExportarDatos));
            this.pct_Fondo = new System.Windows.Forms.PictureBox();
            this.lst_ListadoMaterias = new System.Windows.Forms.ListBox();
            this.lst_ListadoDeCorrelativas = new System.Windows.Forms.ListBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.cmb_FormatoDeArchivo = new System.Windows.Forms.ComboBox();
            this.txt_MateriaSeleccionada = new System.Windows.Forms.TextBox();
            this.lbl_MateriaSeleccionada = new System.Windows.Forms.Label();
            this.lbl_FormatoDeArchivo = new System.Windows.Forms.Label();
            this.btn_ExportarAlumnosMateria = new System.Windows.Forms.Button();
            this.btn_LimpiarCamposMateria = new System.Windows.Forms.Button();
            this.lbl_CorrelativaSeleccionada = new System.Windows.Forms.Label();
            this.txt_CorrelativaSeleccionada = new System.Windows.Forms.TextBox();
            this.lbl_FormatoDeArchivoCorrelativa = new System.Windows.Forms.Label();
            this.cmb_FormatoArchivoCorrelativa = new System.Windows.Forms.ComboBox();
            this.btn_ExportarAlumnosCorrelativa = new System.Windows.Forms.Button();
            this.btn_LimpiarCamposCorrelativa = new System.Windows.Forms.Button();
            this.lbl_Materias = new System.Windows.Forms.Label();
            this.lbl_Correlativas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_Fondo
            // 
            this.pct_Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pct_Fondo.Image")));
            this.pct_Fondo.Location = new System.Drawing.Point(-9, -3);
            this.pct_Fondo.Name = "pct_Fondo";
            this.pct_Fondo.Size = new System.Drawing.Size(892, 614);
            this.pct_Fondo.TabIndex = 0;
            this.pct_Fondo.TabStop = false;
            // 
            // lst_ListadoMaterias
            // 
            this.lst_ListadoMaterias.FormattingEnabled = true;
            this.lst_ListadoMaterias.ItemHeight = 20;
            this.lst_ListadoMaterias.Location = new System.Drawing.Point(11, 89);
            this.lst_ListadoMaterias.Name = "lst_ListadoMaterias";
            this.lst_ListadoMaterias.Size = new System.Drawing.Size(422, 384);
            this.lst_ListadoMaterias.TabIndex = 1;
            this.lst_ListadoMaterias.DoubleClick += new System.EventHandler(this.lst_ListadoMaterias_DoubleClick);
            // 
            // lst_ListadoDeCorrelativas
            // 
            this.lst_ListadoDeCorrelativas.FormattingEnabled = true;
            this.lst_ListadoDeCorrelativas.ItemHeight = 20;
            this.lst_ListadoDeCorrelativas.Location = new System.Drawing.Point(447, 92);
            this.lst_ListadoDeCorrelativas.Name = "lst_ListadoDeCorrelativas";
            this.lst_ListadoDeCorrelativas.Size = new System.Drawing.Size(422, 384);
            this.lst_ListadoDeCorrelativas.TabIndex = 2;
            this.lst_ListadoDeCorrelativas.DoubleClick += new System.EventHandler(this.lst_ListadoDeCorrelativas_DoubleClick);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.Location = new System.Drawing.Point(259, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(359, 20);
            this.lbl_Titulo.TabIndex = 3;
            this.lbl_Titulo.Text = "Seleccione una materia para exportar sus alumnos";
            // 
            // cmb_FormatoDeArchivo
            // 
            this.cmb_FormatoDeArchivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FormatoDeArchivo.FormattingEnabled = true;
            this.cmb_FormatoDeArchivo.Items.AddRange(new object[] {
            "JSON",
            "CSV"});
            this.cmb_FormatoDeArchivo.Location = new System.Drawing.Point(188, 519);
            this.cmb_FormatoDeArchivo.Name = "cmb_FormatoDeArchivo";
            this.cmb_FormatoDeArchivo.Size = new System.Drawing.Size(246, 28);
            this.cmb_FormatoDeArchivo.TabIndex = 4;
            // 
            // txt_MateriaSeleccionada
            // 
            this.txt_MateriaSeleccionada.Location = new System.Drawing.Point(188, 482);
            this.txt_MateriaSeleccionada.Name = "txt_MateriaSeleccionada";
            this.txt_MateriaSeleccionada.ReadOnly = true;
            this.txt_MateriaSeleccionada.Size = new System.Drawing.Size(245, 27);
            this.txt_MateriaSeleccionada.TabIndex = 5;
            // 
            // lbl_MateriaSeleccionada
            // 
            this.lbl_MateriaSeleccionada.AutoSize = true;
            this.lbl_MateriaSeleccionada.Location = new System.Drawing.Point(12, 485);
            this.lbl_MateriaSeleccionada.Name = "lbl_MateriaSeleccionada";
            this.lbl_MateriaSeleccionada.Size = new System.Drawing.Size(150, 20);
            this.lbl_MateriaSeleccionada.TabIndex = 6;
            this.lbl_MateriaSeleccionada.Text = "Materia seleccionada";
            // 
            // lbl_FormatoDeArchivo
            // 
            this.lbl_FormatoDeArchivo.AutoSize = true;
            this.lbl_FormatoDeArchivo.Location = new System.Drawing.Point(12, 522);
            this.lbl_FormatoDeArchivo.Name = "lbl_FormatoDeArchivo";
            this.lbl_FormatoDeArchivo.Size = new System.Drawing.Size(138, 20);
            this.lbl_FormatoDeArchivo.TabIndex = 7;
            this.lbl_FormatoDeArchivo.Text = "Formato de archivo";
            // 
            // btn_ExportarAlumnosMateria
            // 
            this.btn_ExportarAlumnosMateria.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_ExportarAlumnosMateria.FlatAppearance.BorderSize = 0;
            this.btn_ExportarAlumnosMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExportarAlumnosMateria.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ExportarAlumnosMateria.Location = new System.Drawing.Point(57, 566);
            this.btn_ExportarAlumnosMateria.Name = "btn_ExportarAlumnosMateria";
            this.btn_ExportarAlumnosMateria.Size = new System.Drawing.Size(150, 29);
            this.btn_ExportarAlumnosMateria.TabIndex = 8;
            this.btn_ExportarAlumnosMateria.Text = "Exportar";
            this.btn_ExportarAlumnosMateria.UseVisualStyleBackColor = false;
            this.btn_ExportarAlumnosMateria.Click += new System.EventHandler(this.btn_ExportarAlumnosMateria_Click);
            // 
            // btn_LimpiarCamposMateria
            // 
            this.btn_LimpiarCamposMateria.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_LimpiarCamposMateria.FlatAppearance.BorderSize = 0;
            this.btn_LimpiarCamposMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LimpiarCamposMateria.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_LimpiarCamposMateria.Location = new System.Drawing.Point(229, 566);
            this.btn_LimpiarCamposMateria.Name = "btn_LimpiarCamposMateria";
            this.btn_LimpiarCamposMateria.Size = new System.Drawing.Size(150, 29);
            this.btn_LimpiarCamposMateria.TabIndex = 9;
            this.btn_LimpiarCamposMateria.Text = "Limpiar";
            this.btn_LimpiarCamposMateria.UseVisualStyleBackColor = false;
            this.btn_LimpiarCamposMateria.Click += new System.EventHandler(this.btn_LimpiarCamposMateria_Click);
            // 
            // lbl_CorrelativaSeleccionada
            // 
            this.lbl_CorrelativaSeleccionada.AutoSize = true;
            this.lbl_CorrelativaSeleccionada.Location = new System.Drawing.Point(447, 485);
            this.lbl_CorrelativaSeleccionada.Name = "lbl_CorrelativaSeleccionada";
            this.lbl_CorrelativaSeleccionada.Size = new System.Drawing.Size(171, 20);
            this.lbl_CorrelativaSeleccionada.TabIndex = 10;
            this.lbl_CorrelativaSeleccionada.Text = "Correlativa seleccionada";
            // 
            // txt_CorrelativaSeleccionada
            // 
            this.txt_CorrelativaSeleccionada.Location = new System.Drawing.Point(624, 482);
            this.txt_CorrelativaSeleccionada.Name = "txt_CorrelativaSeleccionada";
            this.txt_CorrelativaSeleccionada.ReadOnly = true;
            this.txt_CorrelativaSeleccionada.Size = new System.Drawing.Size(245, 27);
            this.txt_CorrelativaSeleccionada.TabIndex = 11;
            // 
            // lbl_FormatoDeArchivoCorrelativa
            // 
            this.lbl_FormatoDeArchivoCorrelativa.AutoSize = true;
            this.lbl_FormatoDeArchivoCorrelativa.Location = new System.Drawing.Point(447, 527);
            this.lbl_FormatoDeArchivoCorrelativa.Name = "lbl_FormatoDeArchivoCorrelativa";
            this.lbl_FormatoDeArchivoCorrelativa.Size = new System.Drawing.Size(138, 20);
            this.lbl_FormatoDeArchivoCorrelativa.TabIndex = 12;
            this.lbl_FormatoDeArchivoCorrelativa.Text = "Formato de archivo";
            // 
            // cmb_FormatoArchivoCorrelativa
            // 
            this.cmb_FormatoArchivoCorrelativa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FormatoArchivoCorrelativa.FormattingEnabled = true;
            this.cmb_FormatoArchivoCorrelativa.Items.AddRange(new object[] {
            "JSON",
            "CSV"});
            this.cmb_FormatoArchivoCorrelativa.Location = new System.Drawing.Point(624, 519);
            this.cmb_FormatoArchivoCorrelativa.Name = "cmb_FormatoArchivoCorrelativa";
            this.cmb_FormatoArchivoCorrelativa.Size = new System.Drawing.Size(245, 28);
            this.cmb_FormatoArchivoCorrelativa.TabIndex = 13;
            // 
            // btn_ExportarAlumnosCorrelativa
            // 
            this.btn_ExportarAlumnosCorrelativa.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_ExportarAlumnosCorrelativa.FlatAppearance.BorderSize = 0;
            this.btn_ExportarAlumnosCorrelativa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExportarAlumnosCorrelativa.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ExportarAlumnosCorrelativa.Location = new System.Drawing.Point(503, 566);
            this.btn_ExportarAlumnosCorrelativa.Name = "btn_ExportarAlumnosCorrelativa";
            this.btn_ExportarAlumnosCorrelativa.Size = new System.Drawing.Size(150, 29);
            this.btn_ExportarAlumnosCorrelativa.TabIndex = 14;
            this.btn_ExportarAlumnosCorrelativa.Text = "Exportar";
            this.btn_ExportarAlumnosCorrelativa.UseVisualStyleBackColor = false;
            this.btn_ExportarAlumnosCorrelativa.Click += new System.EventHandler(this.btn_ExportarAlumnosCorrelativa_Click);
            // 
            // btn_LimpiarCamposCorrelativa
            // 
            this.btn_LimpiarCamposCorrelativa.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_LimpiarCamposCorrelativa.FlatAppearance.BorderSize = 0;
            this.btn_LimpiarCamposCorrelativa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LimpiarCamposCorrelativa.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_LimpiarCamposCorrelativa.Location = new System.Drawing.Point(675, 566);
            this.btn_LimpiarCamposCorrelativa.Name = "btn_LimpiarCamposCorrelativa";
            this.btn_LimpiarCamposCorrelativa.Size = new System.Drawing.Size(150, 29);
            this.btn_LimpiarCamposCorrelativa.TabIndex = 15;
            this.btn_LimpiarCamposCorrelativa.Text = "Limpiar";
            this.btn_LimpiarCamposCorrelativa.UseVisualStyleBackColor = false;
            this.btn_LimpiarCamposCorrelativa.Click += new System.EventHandler(this.btn_LimpiarCamposCorrelativa_Click);
            // 
            // lbl_Materias
            // 
            this.lbl_Materias.AutoSize = true;
            this.lbl_Materias.Location = new System.Drawing.Point(188, 55);
            this.lbl_Materias.Name = "lbl_Materias";
            this.lbl_Materias.Size = new System.Drawing.Size(66, 20);
            this.lbl_Materias.TabIndex = 16;
            this.lbl_Materias.Text = "Materias";
            // 
            // lbl_Correlativas
            // 
            this.lbl_Correlativas.AutoSize = true;
            this.lbl_Correlativas.Location = new System.Drawing.Point(610, 55);
            this.lbl_Correlativas.Name = "lbl_Correlativas";
            this.lbl_Correlativas.Size = new System.Drawing.Size(87, 20);
            this.lbl_Correlativas.TabIndex = 17;
            this.lbl_Correlativas.Text = "Correlativas";
            // 
            // frm_ExportarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 607);
            this.Controls.Add(this.lbl_Correlativas);
            this.Controls.Add(this.lbl_Materias);
            this.Controls.Add(this.btn_LimpiarCamposCorrelativa);
            this.Controls.Add(this.btn_ExportarAlumnosCorrelativa);
            this.Controls.Add(this.cmb_FormatoArchivoCorrelativa);
            this.Controls.Add(this.lbl_FormatoDeArchivoCorrelativa);
            this.Controls.Add(this.txt_CorrelativaSeleccionada);
            this.Controls.Add(this.lbl_CorrelativaSeleccionada);
            this.Controls.Add(this.btn_LimpiarCamposMateria);
            this.Controls.Add(this.btn_ExportarAlumnosMateria);
            this.Controls.Add(this.lbl_FormatoDeArchivo);
            this.Controls.Add(this.lbl_MateriaSeleccionada);
            this.Controls.Add(this.txt_MateriaSeleccionada);
            this.Controls.Add(this.cmb_FormatoDeArchivo);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.lst_ListadoDeCorrelativas);
            this.Controls.Add(this.lst_ListadoMaterias);
            this.Controls.Add(this.pct_Fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_ExportarDatos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportar datos";
            this.Load += new System.EventHandler(this.frm_ExportarDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pct_Fondo;
        private ListBox lst_ListadoMaterias;
        private ListBox lst_ListadoDeCorrelativas;
        private Label lbl_Titulo;
        private ComboBox cmb_FormatoDeArchivo;
        private TextBox txt_MateriaSeleccionada;
        private Label lbl_MateriaSeleccionada;
        private Label lbl_FormatoDeArchivo;
        private Button btn_ExportarAlumnosMateria;
        private Button btn_LimpiarCamposMateria;
        private Label lbl_CorrelativaSeleccionada;
        private TextBox txt_CorrelativaSeleccionada;
        private Label lbl_FormatoDeArchivoCorrelativa;
        private ComboBox cmb_FormatoArchivoCorrelativa;
        private Button btn_ExportarAlumnosCorrelativa;
        private Button btn_LimpiarCamposCorrelativa;
        private Label lbl_Materias;
        private Label lbl_Correlativas;
    }
}