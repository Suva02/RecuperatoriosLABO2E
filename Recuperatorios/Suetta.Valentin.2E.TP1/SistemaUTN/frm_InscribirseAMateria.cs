using Entidades.Agrupacion;
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
        //Formularios
        frm_Login formLogin;

        //Alumno actual
        Alumno alumnoActual;

        //Listas
        List<ParcialCorrelativa> parcialesCorrelativa;

        public frm_InscribirseAMateria(frm_Login login, Alumno alumno)
        {
            InitializeComponent();
            formLogin = login;
            alumnoActual = alumno;
            parcialesCorrelativa = new List<ParcialCorrelativa>();
        }

        private void frm_InscribirseAMateria_Load(object sender, EventArgs e)
        {
            lst_MateriasDisponibles.DataSource = formLogin.MateriasCreadas;
            lst_CorrelativasDisponibles.DataSource = formLogin.CorrelativasCreadas;
        }

        private void lst_MateriasDisponibles_DoubleClick(object sender, EventArgs e)
        {
            var materiaSeleccionada = lst_MateriasDisponibles.SelectedItem as Materia;

            if (materiaSeleccionada is not null)
            {
                var correlativa = formLogin.Correlatividades.GetValueOrDefault(materiaSeleccionada);

                if (correlativa is not null) //si no es null, es porque la materia tiene correlativa
                {

                    foreach (var parcial in formLogin.ParcialesCorrelativas)
                    {
                        if(parcial.Correlativa == correlativa)
                        {
                            parcialesCorrelativa.Add(parcial);
                        }
                    }

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
                                if(formLogin.CantidadInscripciones < 2)
                                {
                                    Inscripción inscripcion = new Inscripción(alumnoActual, materiaSeleccionada, ECondicion.Regular);
                                    formLogin.InscripcionesAMaterias.Add(inscripcion);
                                    MessageBox.Show("La inscripcion se realizó correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    AlumnoAsistencia asistencia = new AlumnoAsistencia(materiaSeleccionada, alumnoActual, string.Empty);
                                    formLogin.AsistenciaMaterias.Add(asistencia);
                                    formLogin.CantidadInscripciones++;
                                }
                                else
                                {
                                    MessageBox.Show("Puede inscribirse a dos materias como maximo!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {

                                var respuesta = MessageBox.Show($"Para inscribirse a {materiaSeleccionada.Nombre}, debe tener aprobada {correlativa.Nombre}. Desea inscribirse en la materia correlativa?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                                if (respuesta != DialogResult.Yes)
                                {
                                    MessageBox.Show("No se pudo realizar la inscripcion, lo sentimos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    if (formLogin.CantidadInscripciones < 2)
                                    {
                                        InscripcionACorrelativa inscripcionACorrelativa = new InscripcionACorrelativa(alumnoActual, correlativa, ECondicion.Regular);
                                        formLogin.InscripcionesACorrelativas.Add(inscripcionACorrelativa);
                                        MessageBox.Show("La inscripcion se realizó correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        AlumnoAsistenciaCorrelativa asistenciaACorrelativa = new AlumnoAsistenciaCorrelativa(correlativa, alumnoActual, string.Empty);
                                        formLogin.AsistenciaCorrelativas.Add(asistenciaACorrelativa);
                                        formLogin.CantidadInscripciones++;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Puede inscribirse a dos materias como maximo!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                }
                            }

                        }

                    }
                    else //si la lista es menor a cero, significa que el alumno no tiene parciales asignados en la correlativa, por lo tanto tiene que inscribirse a ella.
                    {
                        var respuesta = MessageBox.Show($"Para inscribirse a {materiaSeleccionada.Nombre}, debe tener aprobada {correlativa.Nombre}. Desea inscribirse en la materia correlativa?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (respuesta != DialogResult.Yes)
                        {
                            MessageBox.Show("No se pudo realizar la inscripcion, lo sentimos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (formLogin.CantidadInscripciones < 2)
                            {
                                InscripcionACorrelativa inscripcionACorrelativa = new InscripcionACorrelativa(alumnoActual, correlativa, ECondicion.Regular);
                                formLogin.InscripcionesACorrelativas.Add(inscripcionACorrelativa);
                                MessageBox.Show("La inscripcion se realizó correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                AlumnoAsistenciaCorrelativa asistenciaACorrelativa = new AlumnoAsistenciaCorrelativa(correlativa, alumnoActual, string.Empty);
                                formLogin.AsistenciaCorrelativas.Add(asistenciaACorrelativa);
                                formLogin.CantidadInscripciones++;
                            }
                            else
                            {
                                MessageBox.Show("Puede inscribirse a dos materias como maximo!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }

                }
                else
                {
                    if (correlativa is null)
                    {
                        if (formLogin.CantidadInscripciones < 2)
                        {
                            Inscripción inscripcion = new Inscripción(alumnoActual, materiaSeleccionada, ECondicion.Regular);
                            formLogin.InscripcionesAMaterias.Add(inscripcion);
                            MessageBox.Show("La inscripcion se realizó correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AlumnoAsistencia asistencia = new AlumnoAsistencia(materiaSeleccionada, alumnoActual, string.Empty);
                            formLogin.AsistenciaMaterias.Add(asistencia);
                            formLogin.CantidadInscripciones++;
                        }
                        else
                        {
                            MessageBox.Show("Puede inscribirse a dos materias como maximo!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }

            }
        }
    }
}
