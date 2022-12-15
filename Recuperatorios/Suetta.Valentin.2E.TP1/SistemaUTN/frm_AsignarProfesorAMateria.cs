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
    public partial class frm_AsignarProfesorAMateria : Form
    {
        //Formularios
        frm_Login formLogin;

        //Materia seleccionada
        Materia materiaSeleccionada;

        //Profesor seleccionado
        Profesor profesorSeleccionado;

        //Materia y profesor
        MateriaYProfesor materiaYProfesor;

        public frm_AsignarProfesorAMateria(frm_Login login)
        {
            InitializeComponent();
            formLogin = login;
        }

        private void frm_AsignarProfesorAMateria_Load(object sender, EventArgs e)
        {
            lst_ListadoDeMaterias.DataSource = formLogin.MateriasCreadas;
            lst_ListadoDeProfesoresDisponibles.DataSource = formLogin.ProfesoresCreados;
        }

        private void lst_ListadoDeMaterias_DoubleClick(object sender, EventArgs e)
        {
            materiaSeleccionada = lst_ListadoDeMaterias.SelectedItem as Materia;

            if (materiaSeleccionada is not null)
            {
                txt_MateriaSeleccionada.Text = materiaSeleccionada.Nombre;
            }
            else
            {
                MessageBox.Show("Se produjo un error al seleccionar la materia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (materiaSeleccionada is not null && profesorSeleccionado is not null)
            {
                if (!string.IsNullOrEmpty(txt_MateriaSeleccionada.Text) && !string.IsNullOrEmpty(txt_ProfesorSeleccionado.Text))
                {
                    materiaYProfesor = new MateriaYProfesor(materiaSeleccionada, profesorSeleccionado);
                    formLogin.MateriasYProfesores.Add(materiaYProfesor.Materia, materiaYProfesor.Profesor);
                    MessageBox.Show("Profesor asignado correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();   
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una materia y un profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Se ha producido un error... vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txt_MateriaSeleccionada.Text = string.Empty;
            txt_ProfesorSeleccionado.Text = string.Empty;
        }
    }
}
