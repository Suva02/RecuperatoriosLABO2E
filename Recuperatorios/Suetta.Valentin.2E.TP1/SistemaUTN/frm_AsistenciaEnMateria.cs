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
    public partial class frm_AsistenciaEnMateria : Form
    {
        //Formularios
        frm_Login formLogin;

        //Alumno actual
        Alumno alumnoLogeado;

        //Inscripcion seleccionada
        Inscripción inscripcionSeleccionada;

        //Lista de inscripciones
        List<Inscripción> inscripciones = new List<Inscripción>();

        public frm_AsistenciaEnMateria(Alumno alumno, frm_Login login)
        {
            InitializeComponent();
            formLogin = login;
            alumnoLogeado = alumno;
        }

        private void frm_AsistenciaEnMateria_Load(object sender, EventArgs e)
        {

            if(inscripciones is not null)
            {
                foreach (var inscripcion in formLogin.InscripcionesAMaterias)
                {
                    if (inscripcion.Alumno == alumnoLogeado)
                    {
                        inscripciones.Add(inscripcion);
                    }
                }
            }
            else
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (inscripciones.Count > 0)
                lst_InscripcionesAMaterias.DataSource = inscripciones;
            else
                MessageBox.Show("No te inscribiste a materias para dar asistencia", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void lst_InscripcionesAMaterias_DoubleClick(object sender, EventArgs e)
        {
            inscripcionSeleccionada = lst_InscripcionesAMaterias.SelectedItem as Inscripción;

            if (inscripcionSeleccionada is not null)
            {
                txt_NombreMateria.Text = inscripcionSeleccionada.Materia.Nombre;
            }
            else
            {
                MessageBox.Show("Hubo un error al seleccionar la inscripcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_DarAsistencia_Click(object sender, EventArgs e)
        {
            if (inscripcionSeleccionada is not null)
            {
                if (!string.IsNullOrEmpty(txt_NombreMateria.Text) && !string.IsNullOrEmpty(txt_AsistenciaIngresada.Text))
                {
                    if (txt_AsistenciaIngresada.Text == "Presente" || txt_AsistenciaIngresada.Text == "presente")
                    {
                        AlumnoAsistencia asistencia = new AlumnoAsistencia(inscripcionSeleccionada.Materia, alumnoLogeado, txt_AsistenciaIngresada.Text);
                        if(formLogin.AsistenciaMaterias + asistencia)
                        {
                            MessageBox.Show("La asistencia se ha cargado correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Se produjo un error al cargar la asistencia, por favor vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        LimpiarCampos();
                        
                    }
                    else
                    {
                        if (txt_AsistenciaIngresada.Text == "Ausente" || txt_AsistenciaIngresada.Text == "ausente")
                        {
                            AlumnoAsistencia asistencia = new AlumnoAsistencia(inscripcionSeleccionada.Materia, alumnoLogeado, txt_AsistenciaIngresada.Text);
                            if (formLogin.AsistenciaMaterias + asistencia)
                            {
                                MessageBox.Show("La asistencia se ha cargado correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Se produjo un error al cargar la asistencia, por favor vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            LimpiarCampos();
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
            lst_InscripcionesAMaterias.DataSource = inscripciones;
        }
    }
}
