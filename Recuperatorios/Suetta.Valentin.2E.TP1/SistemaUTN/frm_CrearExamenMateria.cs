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
    public partial class frm_CrearExamenMateria : Form
    {
        //Profesor actual
        Profesor profesorActual;

        //Formularios
        frm_Login formLogin;

        //Materia seleccionada
        Materia materiaSeleccionada;

        //Alumno seleccionado
        Alumno alumnoSeleccionado;

        //Parcial a crear
        Parcial parcialACrear;

        public frm_CrearExamenMateria(Profesor profesor, frm_Login login)
        {
            InitializeComponent();
            profesorActual = profesor;
            formLogin = login;

        }

        private void frm_CrearExamenMateria_Load(object sender, EventArgs e)
        {
            lst_ListadoDeMaterias.DataSource = formLogin.MateriasCreadas;
            lst_ListadoDeAlumnos.DataSource = formLogin.AlumnosCreados;
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
                MessageBox.Show("Hubo un error al seleccionar la materia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lst_ListadoDeAlumnos_DoubleClick(object sender, EventArgs e)
        {
            alumnoSeleccionado = lst_ListadoDeAlumnos.SelectedItem as Alumno;

            if (alumnoSeleccionado is not null)
            {
                txt_AlumnoSeleccionado.Text = alumnoSeleccionado.Nombre + " " + alumnoSeleccionado.Apellido;
            }
            else
            {
                MessageBox.Show("Hubo un error al seleccionar el alumno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_CrearExamen_Click(object sender, EventArgs e)
        {
            if (materiaSeleccionada is not null && alumnoSeleccionado is not null)
            {
                if (!string.IsNullOrEmpty(txt_MateriaSeleccionada.Text) && !string.IsNullOrEmpty(txt_AlumnoSeleccionado.Text) && !string.IsNullOrEmpty(txt_TipoDeParcial.Text)
                    && !string.IsNullOrEmpty(txt_FechaExamen.Text) && !string.IsNullOrEmpty(txt_NotaDeAlumno.Text))
                {
                    parcialACrear = new Parcial(materiaSeleccionada,alumnoSeleccionado,txt_TipoDeParcial.Text,DateTime.Parse(txt_FechaExamen.Text),txt_NotaDeAlumno.Text);
                    formLogin.ParcialesMaterias.Add(parcialACrear);
                    MessageBox.Show("Se creo el examen correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();   
                }
                else
                {
                    MessageBox.Show("Todos los campos deben estar completos para crear el examen", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Se ha producido un error, vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txt_AlumnoSeleccionado.Text = string.Empty;
            txt_MateriaSeleccionada.Text = string.Empty;
            txt_FechaExamen.Text = string.Empty;
            txt_NotaDeAlumno.Text = string.Empty;
            txt_TipoDeParcial.Text = string.Empty;
        }
    }
}
