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
    public partial class frm_AsignarProfesorACorrelativa : Form
    {

        //Formularios
        frm_Login formLogin;

        //Materia seleccionada
        MateriaCorrelativa correlativaSeleccionada;

        //Profesor seleccionado
        Profesor profesorSeleccionado;

        //Materia y profesor
        MateriaCorrelativaYProfesor correlativaYProfesor;
        public frm_AsignarProfesorACorrelativa(frm_Login login)
        {
            InitializeComponent();
            formLogin = login;
        }

        private void frm_AsignarProfesorACorrelativa_Load(object sender, EventArgs e)
        {
            lst_ListadoDeCorrelativas.DataSource = formLogin.CorrelativasCreadas;
            lst_ListadoDeProfesoresDisponibles.DataSource = formLogin.ProfesoresCreados;
        }

        private void lst_ListadoDeCorrelativas_DoubleClick(object sender, EventArgs e)
        {
            correlativaSeleccionada = lst_ListadoDeCorrelativas.SelectedItem as MateriaCorrelativa;

            if (correlativaSeleccionada is not null)
            {
                txt_CorrelativaSeleccionada.Text = correlativaSeleccionada.Nombre;
            }
            else
            {
                MessageBox.Show("Se produjo un error al seleccionar la correlativa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lst_ListadoDeProfesoresDisponibles_DoubleClick(object sender, EventArgs e)
        {
            profesorSeleccionado = lst_ListadoDeProfesoresDisponibles.SelectedItem as Profesor;

            if (profesorSeleccionado is not null)
            {
                txt_ProfesorSeleccionado.Text = profesorSeleccionado.Nombre + " " + profesorSeleccionado.Apellido;
            }
            else
            {
                MessageBox.Show("Se produjo un error al seleccionar el profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Asignar_Click(object sender, EventArgs e)
        {
            if (correlativaSeleccionada is not null && profesorSeleccionado is not null)
            {
                if (!string.IsNullOrEmpty(txt_CorrelativaSeleccionada.Text) && !string.IsNullOrEmpty(txt_ProfesorSeleccionado.Text))
                {
                    MateriaCorrelativaYProfesor correlativaYProfesor = new MateriaCorrelativaYProfesor(correlativaSeleccionada, profesorSeleccionado);
                    formLogin.CorrelativasYProfesores.Add(correlativaYProfesor.MateriaCorrelativa, correlativaYProfesor.Profesor);
                    MessageBox.Show("Profesor asignado correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una correlativa y un profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Se ha producido un error... vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txt_CorrelativaSeleccionada.Text = string.Empty;
            txt_ProfesorSeleccionado.Text = string.Empty;
        }
    }
}
