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
    public partial class frm_InscribirAlumnoAMateria : Form
    {
        //Formularios
        frm_Login formLogin;

        //Alumno seleccionado
        Alumno alumnoSeleccionado;

        //Listas
        List<ParcialCorrelativa> parcialesCorrelativa;
        public frm_InscribirAlumnoAMateria(frm_Login login)
        {
            InitializeComponent();
            formLogin = login;
            parcialesCorrelativa = new List<ParcialCorrelativa>();
        }

        private void frm_InscribirAlumnoAMateria_Load(object sender, EventArgs e)
        {
            lst_AlumnosDisponibles.DataSource = formLogin.AlumnosCreados;
            lst_MateriasDisponibles.DataSource = formLogin.MateriasCreadas;
            lst_CorrelativasDisponibles.DataSource = formLogin.CorrelativasCreadas;
        }

        private void lst_AlumnosDisponibles_DoubleClick(object sender, EventArgs e)
        {
            alumnoSeleccionado = lst_AlumnosDisponibles.SelectedItem as Alumno;
            if(alumnoSeleccionado is not null)
            {
                MessageBox.Show($"{alumnoSeleccionado.MostrarDatosCompletos()}", "Alumno seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                        if (parcial.Correlativa == correlativa)
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
                                if(alumnoSeleccionado is not null)
                                {
                                    if (formLogin.CantidadInscripciones < 2)
                                    {
                                        Inscripción inscripcion = new Inscripción(alumnoSeleccionado, materiaSeleccionada, ECondicion.Regular);
                                        formLogin.InscripcionesAMaterias.Add(inscripcion);
                                        MessageBox.Show("La inscripcion se realizó correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        AlumnoAsistencia asistencia = new AlumnoAsistencia(materiaSeleccionada, alumnoSeleccionado, string.Empty);
                                        formLogin.AsistenciaMaterias.Add(asistencia);
                                        formLogin.CantidadInscripciones++;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Puede inscribirlo a dos materias como maximo!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Se produjo un error con el alumno seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                var respuesta = MessageBox.Show($"Para inscribir a {alumnoSeleccionado.NombreCompleto()} a {materiaSeleccionada.Nombre}, debe tener aprobada {correlativa.Nombre}. Desea inscribirlo en la materia correlativa?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                                if (respuesta != DialogResult.Yes)
                                {
                                    MessageBox.Show("No se pudo realizar la inscripcion, lo sentimos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    if(alumnoSeleccionado is not null)
                                    {
                                        if (formLogin.CantidadInscripciones < 2)
                                        {
                                            InscripcionACorrelativa inscripcionACorrelativa = new InscripcionACorrelativa(alumnoSeleccionado, correlativa, ECondicion.Regular);
                                            formLogin.InscripcionesACorrelativas.Add(inscripcionACorrelativa);
                                            MessageBox.Show("La inscripcion se realizó correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            AlumnoAsistenciaCorrelativa asistenciaACorrelativa = new AlumnoAsistenciaCorrelativa(correlativa, alumnoSeleccionado, string.Empty);
                                            formLogin.AsistenciaCorrelativas.Add(asistenciaACorrelativa);
                                            formLogin.CantidadInscripciones++;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Puede inscribirlo a dos materias como maximo!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Se produjo un error con el alumno seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }

                    }
                    else //si la lista es menor a cero, significa que el alumno no tiene parciales asignados en la correlativa, por lo tanto tiene que inscribirse a ella.
                    {
                        if(alumnoSeleccionado is not null)
                        {
                            var respuesta = MessageBox.Show($"Para inscribir a {alumnoSeleccionado.NombreCompleto()} a {materiaSeleccionada.Nombre}, debe tener aprobada {correlativa.Nombre}. Desea inscribirlo en la materia correlativa?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (respuesta != DialogResult.Yes)
                            {
                                MessageBox.Show("No se pudo realizar la inscripcion, lo sentimos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (formLogin.CantidadInscripciones < 2)
                                {
                                    InscripcionACorrelativa inscripcionACorrelativa = new InscripcionACorrelativa(alumnoSeleccionado, correlativa, ECondicion.Regular);
                                    formLogin.InscripcionesACorrelativas.Add(inscripcionACorrelativa);
                                    MessageBox.Show("La inscripcion se realizó correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    AlumnoAsistenciaCorrelativa asistenciaACorrelativa = new AlumnoAsistenciaCorrelativa(correlativa, alumnoSeleccionado, string.Empty);
                                    formLogin.AsistenciaCorrelativas.Add(asistenciaACorrelativa);
                                    formLogin.CantidadInscripciones++;
                                }
                                else
                                {
                                    MessageBox.Show("Puede inscribirlo a dos materias como maximo!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Se produjo un error con el alumno seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    if (correlativa is null)
                    {
                        if (alumnoSeleccionado is not null)
                        {
                            if (formLogin.CantidadInscripciones < 2)
                            {
                                Inscripción inscripcion = new Inscripción(alumnoSeleccionado, materiaSeleccionada, ECondicion.Regular);
                                formLogin.InscripcionesAMaterias.Add(inscripcion);
                                MessageBox.Show("La inscripcion se realizó correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                AlumnoAsistencia asistencia = new AlumnoAsistencia(materiaSeleccionada, alumnoSeleccionado, string.Empty);
                                formLogin.AsistenciaMaterias.Add(asistencia);
                                formLogin.CantidadInscripciones++;
                            }
                            else
                            {
                                MessageBox.Show("Puede inscribirlo a dos materias como maximo!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Se produjo un error con el alumno seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
