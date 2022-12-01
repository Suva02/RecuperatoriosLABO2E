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
    public partial class frm_ExportarDatos : Form
    {
        MateriaDAO materiaDAO;
        MateriaCorrelativaDAO materiaCorrelativaDAO;

        List<Materia> materias;
        List<MateriaCorrelativa> materiasCorrelativas;

        InscripcionDAO inscripcionDAO;
        InscripcionACorrelativaDAO inscripcionCorrelativaDAO;

        AlumnoDAO alumnoDAO;


        Materia? materiaSeleccionada;
        MateriaCorrelativa? correlativaSeleccionada;

        public frm_ExportarDatos()
        {
            InitializeComponent();
            materiaDAO = new MateriaDAO();
            materiaCorrelativaDAO = new MateriaCorrelativaDAO();
            inscripcionDAO = new InscripcionDAO();
            alumnoDAO = new AlumnoDAO();
            inscripcionCorrelativaDAO = new InscripcionACorrelativaDAO();
        }

        private void frm_ExportarDatos_Load(object sender, EventArgs e)
        {
            try
            {
                materias = materiaDAO.GetAllMaterias();
                lst_ListadoMaterias.DataSource = materias;

                materiasCorrelativas = materiaCorrelativaDAO.GetAllCorrelativas();
                lst_ListadoDeCorrelativas.DataSource = materiasCorrelativas;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lst_ListadoMaterias_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //Obtengo la materia seleccionada
                materiaSeleccionada = lst_ListadoMaterias.SelectedItem as Materia;

                if(materiaSeleccionada is not null)
                {
                    txt_MateriaSeleccionada.Text = materiaSeleccionada.Nombre;
                }
                else
                {
                    MessageBox.Show("Hubo un error al seleccionar la materia, porfavor vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ExportarAlumnosMateria_Click(object sender, EventArgs e)
        {
            try
            {
                if (materiaSeleccionada is not null)
                {
                    var inscripciones = inscripcionDAO.GetInscripcionByIdMateria(materiaSeleccionada.Id);
                    List<Alumno> listaDeAlumnos = new List<Alumno>();
                    Alumno alumno = null;

                    for (int i = 0; i < inscripciones.Count; i++)
                    {
                        alumno = alumnoDAO.GetAlumnoById(inscripciones[i].IdAlumno);
                        listaDeAlumnos.Add(alumno);
                    }

                    if (!string.IsNullOrEmpty(txt_MateriaSeleccionada.Text))
                    {
                        if (!string.IsNullOrEmpty(cmb_FormatoDeArchivo.Text))
                        {
                            if(listaDeAlumnos.Count > 0)
                            {
                                if(cmb_FormatoDeArchivo.Text == "JSON")
                                {
                                    string path = "alumnosInscriptos.json";
                                    SerializadorDAO<List<Alumno>> serializador = new SerializadorDAO<List<Alumno>>();
                                    SerializadorDAO<List<Alumno>>.DelegadoAvisoSerializacion delegadoAvisoSerializacion = new SerializadorDAO<List<Alumno>>.DelegadoAvisoSerializacion(NotificarExportacionJSON);
                                    serializador.ExportarJSON(listaDeAlumnos, path);
                                    delegadoAvisoSerializacion();
                                    LimpiarCamposMateria();
                                }
                                else
                                {
                                    string pathCsv = "alumnosInscriptos.csv";
                                    ArchivoDAO archivoDAO = new ArchivoDAO();
                                    ArchivoDAO.DelegadoAvisoArchivo delegadoAvisoArchivo = new ArchivoDAO.DelegadoAvisoArchivo(NotificarExportacionCSV);
                                    archivoDAO.GuardarArchivo(pathCsv, listaDeAlumnos);
                                    delegadoAvisoArchivo();
                                    LimpiarCamposMateria();
                                }
                            }
                            else
                            {
                                MessageBox.Show("La materia no tiene alumnos inscriptos para importar, lo sentimos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe seleccionar el formato del archivo!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error con la materia seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hubo un error con la materia seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void lst_ListadoDeCorrelativas_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //Obtengo la correlativa seleccionada
                correlativaSeleccionada = lst_ListadoDeCorrelativas.SelectedItem as MateriaCorrelativa;

                if (correlativaSeleccionada is not null)
                {
                    txt_CorrelativaSeleccionada.Text = correlativaSeleccionada.Nombre;
                }
                else
                {
                    MessageBox.Show("Hubo un error al seleccionar la correlativa, porfavor vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ExportarAlumnosCorrelativa_Click(object sender, EventArgs e)
        {
            try
            {
                if (correlativaSeleccionada is not null)
                {
                    var inscripcionesACorrelativas = inscripcionCorrelativaDAO.GetInscripcionCorrelativaByIdCorrelativa(correlativaSeleccionada.Id);
                    List<Alumno> listaDeAlumnos = new List<Alumno>();
                    Alumno alumno = null;

                    for (int i = 0; i < inscripcionesACorrelativas.Count; i++)
                    {
                        alumno = alumnoDAO.GetAlumnoById(inscripcionesACorrelativas[i].IdAlumno);
                        listaDeAlumnos.Add(alumno);
                    }

                    if (!string.IsNullOrEmpty(txt_CorrelativaSeleccionada.Text))
                    {
                        if (!string.IsNullOrEmpty(cmb_FormatoArchivoCorrelativa.Text))
                        {
                            if (listaDeAlumnos.Count > 0)
                            {
                                if (cmb_FormatoArchivoCorrelativa.Text == "JSON")
                                {
                                    string path = "alumnosInscriptosACorrelativa.json";
                                    SerializadorDAO<List<Alumno>> serializador = new SerializadorDAO<List<Alumno>>();
                                    SerializadorDAO<List<Alumno>>.DelegadoAvisoSerializacion delegadoAvisoSerializacion = new SerializadorDAO<List<Alumno>>.DelegadoAvisoSerializacion(NotificarExportacionJSON); 
                                    serializador.ExportarJSON(listaDeAlumnos, path);
                                    delegadoAvisoSerializacion();
                                    LimpiarCamposCorrelativa();
                                }
                                else
                                {
                                    string pathCsv = "alumnosInscriptosACorrelativa.csv";
                                    ArchivoDAO archivoDAO = new ArchivoDAO();
                                    ArchivoDAO.DelegadoAvisoArchivo delegadoAvisoArchivo = new ArchivoDAO.DelegadoAvisoArchivo(NotificarExportacionCSV);
                                    archivoDAO.GuardarArchivo(pathCsv, listaDeAlumnos);
                                    delegadoAvisoArchivo();
                                    LimpiarCamposCorrelativa();
                                }
                            }
                            else
                            {
                                MessageBox.Show("La correlativa no tiene alumnos inscriptos para importar, lo sentimos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe seleccionar el formato del archivo!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error con la correlativa seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hubo un error con la correlativa seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCamposMateria()
        {
            lst_ListadoMaterias.DataSource = null;
            lst_ListadoMaterias.DataSource = materiaDAO.GetAllMaterias();
            txt_MateriaSeleccionada.Text = string.Empty;
            cmb_FormatoDeArchivo.Items.Clear();
            cmb_FormatoDeArchivo.Items.Add("JSON");
            cmb_FormatoDeArchivo.Items.Add("CSV");
        }

        private void LimpiarCamposCorrelativa()
        {
            lst_ListadoDeCorrelativas.DataSource = null;
            lst_ListadoDeCorrelativas.DataSource = materiaCorrelativaDAO.GetAllCorrelativas();
            txt_CorrelativaSeleccionada.Text = string.Empty;
            cmb_FormatoArchivoCorrelativa.Items.Clear();
            cmb_FormatoArchivoCorrelativa.Items.Add("JSON");
            cmb_FormatoArchivoCorrelativa.Items.Add("CSV");
        }

        public void NotificarExportacionJSON()
        {
            MessageBox.Show("El archivo JSON se ha exportado correctamente!", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void NotificarExportacionCSV()
        {
            MessageBox.Show("El archivo CSV se ha exportado correctamente!", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_LimpiarCamposMateria_Click(object sender, EventArgs e)
        {
            LimpiarCamposMateria();
        }

        private void btn_LimpiarCamposCorrelativa_Click(object sender, EventArgs e)
        {
            LimpiarCamposCorrelativa();
        }
    }
}
