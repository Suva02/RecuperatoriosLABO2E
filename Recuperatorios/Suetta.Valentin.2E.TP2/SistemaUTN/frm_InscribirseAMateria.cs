using Entidades.Agrupacion;
using Entidades.AgrupacionDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaUTN
{
    public partial class frm_InscribirseAMateria : Form
    {
        //Objetos DAO
        InscripcionDAO inscripcionDAO;
        MateriaDAO materiaDAO;
        CorrelatividadesDAO correlatividades;
        MateriaCorrelativaDAO materiaCorrelativaDAO;
        ParcialCorrelativaDAO parcialCorrelativaDAO;
        InscripcionACorrelativaDAO inscripcionCorrelativa;


        AlumnoAsistenciaMateriaDAO asistenciaMateriaDAO;
        AlumnoAsistenciaCorrelativaDAO asistenciaCorrelativaDAO;

        frm_Login formLogin;


        //Personas
        Alumno alumnoActual;

        public frm_InscribirseAMateria(Alumno alumno, frm_Login form)
        {
            InitializeComponent();
            correlatividades = new CorrelatividadesDAO();
            materiaCorrelativaDAO = new MateriaCorrelativaDAO();
            inscripcionDAO = new InscripcionDAO();
            parcialCorrelativaDAO = new ParcialCorrelativaDAO();
            materiaDAO = new MateriaDAO();
            inscripcionCorrelativa = new InscripcionACorrelativaDAO();
            alumnoActual = alumno;
            asistenciaMateriaDAO = new AlumnoAsistenciaMateriaDAO();
            asistenciaCorrelativaDAO = new AlumnoAsistenciaCorrelativaDAO();
            this.formLogin = form;
        }

        private void frm_InscribirseAMateria_Load(object sender, EventArgs e)
        {
            try
            {
                lst_MateriasDisponibles.DataSource = materiaDAO.GetAllMaterias();
                lst_CorrelativasDisponibles.DataSource = materiaCorrelativaDAO.GetAllCorrelativas();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lst_MateriasDisponibles_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if(formLogin.contadorDeInscripciones < 2)
                {
                    var materiaSeleccionada = lst_MateriasDisponibles.SelectedItem as Materia;

                    if (materiaSeleccionada is not null)
                    {
                        var correlatividad = correlatividades.ValidarMateriaCorrelativa(materiaSeleccionada);

                        if (correlatividad is not null) //si no es null, es porque la materia tiene correlativa
                        {

                            var parcialesCorrelativa = parcialCorrelativaDAO.GetParcialDelAlumnoEnCorrelativa(alumnoActual, correlatividad.IdMateriaCorrelativa);

                            if (parcialesCorrelativa.Count > 0 && parcialesCorrelativa.Count > 3)
                            {
                                if (parcialesCorrelativa[0].TipoParcial == "Primer parcial" && parcialesCorrelativa[1].TipoParcial == "Segundo parcial")
                                {
                                    int notaParcialUno;
                                    int notaParcialDos;

                                    int.TryParse(parcialesCorrelativa[0].Nota, out notaParcialUno);
                                    int.TryParse(parcialesCorrelativa[1].Nota, out notaParcialDos);


                                    if (notaParcialUno > 5 && notaParcialDos > 5)
                                    {
                                        inscripcionDAO.RealizarInscripcionAMateria(alumnoActual, materiaSeleccionada, ECondicion.Regular);
                                        MessageBox.Show("La inscripcion se realizó correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        asistenciaMateriaDAO.AsignarAsistenciaAlAlumno(materiaSeleccionada.Id, alumnoActual.Id, string.Empty);
                                        formLogin.contadorDeInscripciones++;
                                    }
                                    else
                                    {

                                        var respuesta = MessageBox.Show($"Para inscribirse a {materiaSeleccionada.Nombre}, debe tener aprobada su correlativa. Desea inscribirse en la materia correlativa?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                                        if (respuesta != DialogResult.Yes)
                                        {
                                            MessageBox.Show("No se pudo realizar la inscripcion, lo sentimos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            inscripcionCorrelativa.RealizarInscripcionAMateriaCorrelativa(alumnoActual, correlatividad.IdMateriaCorrelativa, ECondicion.Regular);
                                            MessageBox.Show("La inscripcion se realizó correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            asistenciaCorrelativaDAO.AsignarAsistenciaAlAlumno(correlatividad.IdMateriaCorrelativa, alumnoActual.Id, string.Empty);
                                            formLogin.contadorDeInscripciones++;
                                        }
                                    }

                                }

                            }
                            else //si la lista es menor a cero, significa que el alumno no tiene parciales asignados en la correlativa, por lo tanto tiene que inscribirse a ella.
                            {
                                var respuesta = MessageBox.Show($"Para inscribirse a {materiaSeleccionada.Nombre}, debe tener aprobada su correlativa. Desea inscribirse en la materia correlativa?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                                if (respuesta != DialogResult.Yes)
                                {
                                    MessageBox.Show("No se pudo realizar la inscripcion, lo sentimos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    //Inscripcion a correlativa (fijarse antes si esta inscripto)
                                    inscripcionCorrelativa.RealizarInscripcionAMateriaCorrelativa(alumnoActual, correlatividad.IdMateriaCorrelativa, ECondicion.Regular);
                                    MessageBox.Show("La inscripcion se realizó correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    asistenciaCorrelativaDAO.AsignarAsistenciaAlAlumno(correlatividad.IdMateriaCorrelativa, alumnoActual.Id, string.Empty);
                                    formLogin.contadorDeInscripciones++;
                                }
                            }

                        }
                        else
                        {
                            if (correlatividad is null)
                            {

                                inscripcionDAO.RealizarInscripcionAMateria(alumnoActual, materiaSeleccionada, ECondicion.Regular);
                                MessageBox.Show("La inscripcion se realizó correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                asistenciaMateriaDAO.AsignarAsistenciaAlAlumno(materiaSeleccionada.Id, alumnoActual.Id, string.Empty);
                                formLogin.contadorDeInscripciones++;
                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Puede realizar un maximo de 2 inscripciones!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
