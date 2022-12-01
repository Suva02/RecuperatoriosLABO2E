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
    public partial class frm_AsistenciaEnMateria : Form
    {
        InscripcionDAO inscripcionDAO;
        Alumno alumnoActual;
        Inscripción? inscripcionSeleccionada;
        AlumnoAsistenciaMateriaDAO alumnoAsistenciaDAO;
        public frm_AsistenciaEnMateria(Alumno alumno)
        {
            InitializeComponent();
            alumnoActual = alumno;
            inscripcionDAO = new InscripcionDAO();
            alumnoAsistenciaDAO = new AlumnoAsistenciaMateriaDAO();
        }

        private void frm_AsistenciaEnMateria_Load(object sender, EventArgs e)
        {
            try
            {
                var inscripciones = inscripcionDAO.GetInscripcionByIdAlumno(alumnoActual);

                if (inscripciones.Any())
                    lst_InscripcionesAMaterias.DataSource = inscripciones;
                else
                    MessageBox.Show("No te has inscripto a materias para dar asistencia", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            } 
        }

        private void lst_InscripcionesAMaterias_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                inscripcionSeleccionada = lst_InscripcionesAMaterias.SelectedItem as Inscripción;

                if(inscripcionSeleccionada is not null)
                {
                    txt_NombreMateria.Text = inscripcionSeleccionada.IdMateria.ToString();
                }
                else
                {
                    MessageBox.Show("Hubo un error al seleccionar la inscripcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_DarAsistencia_Click(object sender, EventArgs e)
        {
            if(inscripcionSeleccionada is not null)
            {
                if(!string.IsNullOrEmpty(txt_NombreMateria.Text) && !string.IsNullOrEmpty(txt_AsistenciaIngresada.Text))
                {
                    if(txt_AsistenciaIngresada.Text == "Presente" || txt_AsistenciaIngresada.Text == "presente")
                    {
                        try
                        {
                            alumnoAsistenciaDAO.DarAsistencia(inscripcionSeleccionada, txt_AsistenciaIngresada.Text);
                            MessageBox.Show("La asistencia se ha dado correctamente!","Atencion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            LimpiarCampos();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if(txt_AsistenciaIngresada.Text == "Ausente" || txt_AsistenciaIngresada.Text == "ausente")
                        {
                            try
                            {
                                alumnoAsistenciaDAO.DarAsistencia(inscripcionSeleccionada, txt_AsistenciaIngresada.Text);
                                MessageBox.Show("La asistencia se ha dado correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarCampos();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lo asistencia ingresada no es valida... (Presente/Ausente)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Para dar asistencia debe seleccionar una materia a la que se encuentre inscripto y dar su asistencia ingresando en el campo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ocurrio un error al dar asistencia, porfavor vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// METODO QUE SE ENCARGA DE LIMPIAR LOS CAMPOS
        /// </summary>
        private void LimpiarCampos()
        {
            txt_NombreMateria.Text = string.Empty;
            txt_AsistenciaIngresada.Text = string.Empty;
            lst_InscripcionesAMaterias.DataSource = null;
            lst_InscripcionesAMaterias.DataSource = inscripcionDAO.GetInscripcionByIdAlumno(alumnoActual);
        }
    }
}
