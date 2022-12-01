using Entidades.Agrupacion;
using Entidades.AgrupacionDAO;
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
    public partial class frm_CrearExamenCorrelativa : Form
    {
        MateriaCorrelativaDAO materiaCorrelativaDAO;
        AlumnoDAO alumnoDAO;
        ParcialCorrelativaDAO parcialCorrelativaDAO;


        MateriaCorrelativa correlativaSeleccionada;
        Alumno alumnoSeleccionado;

        Profesor profesorActual;
        public frm_CrearExamenCorrelativa(Profesor profesor)
        {
            InitializeComponent();
            materiaCorrelativaDAO = new MateriaCorrelativaDAO();
            alumnoDAO = new AlumnoDAO();
            parcialCorrelativaDAO = new ParcialCorrelativaDAO();
            profesorActual = profesor;
        }

        private void frm_CrearExamenCorrelativa_Load(object sender, EventArgs e)
        {
            try
            {
                lst_ListadoDeCorrelativas.DataSource = materiaCorrelativaDAO.GetAllCorrelativas();
                lst_ListadoDeAlumnos.DataSource = alumnoDAO.GetAlumnos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lst_ListadoDeCorrelativas_DoubleClick(object sender, EventArgs e)
        {
            correlativaSeleccionada = lst_ListadoDeCorrelativas.SelectedItem as MateriaCorrelativa;

            if (correlativaSeleccionada is not null)
            {
                txt_MateriaSeleccionada.Text = correlativaSeleccionada.Nombre;
            }
            else
            {
                MessageBox.Show("Hubo un error al seleccionar la correlativa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Hubo un error al seleccionar la materia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_CrearExamen_Click(object sender, EventArgs e)
        {
            if (correlativaSeleccionada is not null && alumnoSeleccionado is not null)
            {
                if (!string.IsNullOrEmpty(txt_MateriaSeleccionada.Text) && !string.IsNullOrEmpty(txt_AlumnoSeleccionado.Text) && !string.IsNullOrEmpty(txt_TipoDeParcial.Text) 
                    && !string.IsNullOrEmpty(txt_FechaExamen.Text) && !string.IsNullOrEmpty(txt_NotaDeAlumno.Text))
                {
                    try
                    {
                        parcialCorrelativaDAO.CrearExamen(correlativaSeleccionada.Id, alumnoSeleccionado.Id, txt_TipoDeParcial.Text, txt_NotaDeAlumno.Text, txt_FechaExamen.Text);
                        MessageBox.Show("Se creo el examen correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
