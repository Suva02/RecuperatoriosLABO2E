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
    public partial class frm_ImportarAlumnos : Form
    {
        string path = "alumnosAImportar.json";
        SerializadorDAO<List<Alumno>> serializador;
        List<Alumno> listaDeAlumnos;
        AlumnoDAO alumnoDAO;

        /// <summary>
        /// CONSTRUCTOR DEL FORMULARIO SIN PARAMETROS
        /// </summary>
        public frm_ImportarAlumnos()
        {
            InitializeComponent();
            serializador = new SerializadorDAO<List<Alumno>>();
            listaDeAlumnos = new List<Alumno>();
            alumnoDAO = new AlumnoDAO();
        }

        /// <summary>
        /// EVENTO LOAD QUE APENAS SE ABRE EL FORMULARIO, MUESTRA EN UN LISTBOX LOS ALUMNOS DISPONIBLES PARA IMPORTAR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_ImportarAlumnos_Load(object sender, EventArgs e)
        {
            try
            {
                listaDeAlumnos = serializador.DeserializarJSON(path);
                lst_AlumnosAImportar.DataSource = listaDeAlumnos;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// BOTON/EVENTO CLICK QUE SE ENCARGA DE IMPORTAR LOS ALUMNOS A LA BASE DE DATOS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Importar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaDeAlumnos is not null && listaDeAlumnos.Count > 0)
                {
                    foreach (var alumno in listaDeAlumnos)
                    {
                        var alumnoAImportar = new Alumno();
                        alumnoAImportar.Nombre = alumno.Nombre;
                        alumnoAImportar.Apellido = alumno.Apellido;
                        alumnoAImportar.Email = alumno.Email;
                        alumnoAImportar.Contraseña = alumno.Contraseña;

                        alumnoDAO.CrearAlumno(alumnoAImportar);
                    }
                    MessageBox.Show("Los alumnos se han importado correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hubo un error con la lista de alumnos... por favor, vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
