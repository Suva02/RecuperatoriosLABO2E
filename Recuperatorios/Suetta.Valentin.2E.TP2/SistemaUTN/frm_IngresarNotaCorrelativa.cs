using Entidades.Agrupacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaUTN
{
    public partial class frm_IngresarNotaCorrelativa : Form
    {

        //Formularios
        frm_Login formLogin;

        //Profesor actual
        Profesor profesorActual;

        //Listas
        List<ParcialCorrelativa> parcialesCorrelativasDisponibles;

        //Parcial seleccionado
        ParcialCorrelativa parcialSeleccionado;


        public frm_IngresarNotaCorrelativa(Profesor profesor, frm_Login login)
        {
            InitializeComponent();
            profesorActual = profesor;
            formLogin = login;
            parcialesCorrelativasDisponibles = new List<ParcialCorrelativa>();
        }

        private void frm_IngresarNotaCorrelativa_Load(object sender, EventArgs e)
        {
            foreach (var CorrelativaYProfesor in formLogin.CorrelativasYProfesores)
            {
                foreach (var parcial in formLogin.ParcialesCorrelativas)
                {
                    if (CorrelativaYProfesor.Value == profesorActual)
                    {
                        if (parcial.Correlativa == CorrelativaYProfesor.Key)
                        {
                            parcialesCorrelativasDisponibles.Add(parcial);
                        }
                    }
                }
            }

            if (parcialesCorrelativasDisponibles is not null && parcialesCorrelativasDisponibles.Count > 0)
            {
                lst_ParcialesDisponibles.DataSource = parcialesCorrelativasDisponibles;
            }
            else
            {
                MessageBox.Show("Debe estar asignado a correlativas y haber creado uno o mas parciales!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lst_ParcialesDisponibles_DoubleClick(object sender, EventArgs e)
        {
            parcialSeleccionado = lst_ParcialesDisponibles.SelectedItem as ParcialCorrelativa;

            if (parcialSeleccionado is not null)
            {
                txt_TipoDeParcial.Text = parcialSeleccionado.TipoParcial;
                txt_Correlativa.Text = parcialSeleccionado.Correlativa.Nombre;
                txt_Nota.Text = parcialSeleccionado.Nota;
            }
            else
            {
                MessageBox.Show("Hubo un error al seleccionar el parcial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_IngresarNota_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Nota.Text) && !string.IsNullOrEmpty(txt_Correlativa.Text) && !string.IsNullOrEmpty(txt_TipoDeParcial.Text))
            {
                parcialSeleccionado.Nota = txt_Nota.Text;
                MessageBox.Show("La nota se guardo correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarListado();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un parcial y modificar la nota, si es que lo precisa...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarListado()
        {
            lst_ParcialesDisponibles.DataSource = null;
            lst_ParcialesDisponibles.DataSource = parcialesCorrelativasDisponibles;
            txt_TipoDeParcial.Text = string.Empty;
            txt_Correlativa.Text = string.Empty;
            txt_Nota.Text = string.Empty;
        }
    }
}
