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
    public partial class frm_MateriasYAlumnos : Form
    {
        //Profesor actual
        Profesor profesorActual;

        //Formularios
        frm_Login formLogin;

        //Listas
        List<Materia> materiasAsignadas;
        List<MateriaCorrelativa> correlativasAsignadas;
        List<Alumno> alumnosInscriptosAMateria;
        List<Alumno> alumnosInscriptosACorrelativa;

        public frm_MateriasYAlumnos(Profesor profesor, frm_Login login)
        {
            InitializeComponent();
            profesorActual = profesor;
            formLogin = login;
            materiasAsignadas = new List<Materia>();
            correlativasAsignadas = new List<MateriaCorrelativa>();
            alumnosInscriptosAMateria = new List<Alumno>();
            alumnosInscriptosACorrelativa = new List<Alumno>();
        }

        private void frm_MateriasYAlumnos_Load(object sender, EventArgs e)
        {
            foreach (var materiaYProfesor in formLogin.MateriasYProfesores)
            {
                if(materiaYProfesor.Value == profesorActual)
                {
                    materiasAsignadas.Add(materiaYProfesor.Key);
                }
            }

            if(materiasAsignadas is not null && materiasAsignadas.Count > 0)
            {
                lst_MateriasAsignadas.DataSource = materiasAsignadas;
            }

            foreach (var inscripciones in formLogin.InscripcionesAMaterias)
            {
                foreach (var materiaYProfesor in formLogin.MateriasYProfesores)
                {
                    if(inscripciones.Materia == materiaYProfesor.Key)
                    {
                        alumnosInscriptosAMateria.Add(inscripciones.Alumno);
                    }
                }
            }

            if(alumnosInscriptosAMateria is not null && alumnosInscriptosAMateria.Count > 0)
            {
                lst_AlumnosInscriptosAMaterias.DataSource = alumnosInscriptosAMateria;
            }

            foreach (var correlativaYProfesor in formLogin.CorrelativasYProfesores)
            {
                if (correlativaYProfesor.Value == profesorActual)
                {
                    correlativasAsignadas.Add(correlativaYProfesor.Key);
                }
            }

            if (correlativasAsignadas is not null && correlativasAsignadas.Count > 0)
            {
                lst_CorrelativasAsignadas.DataSource = correlativasAsignadas;
            }

            foreach (var inscripciones in formLogin.InscripcionesACorrelativas)
            {
                foreach (var CorrrelativaYProfesor in formLogin.CorrelativasYProfesores)
                {
                    if (inscripciones.Correlativa == CorrrelativaYProfesor.Key)
                    {
                        alumnosInscriptosACorrelativa.Add(inscripciones.Alumno);
                    }
                }
            }

            if (alumnosInscriptosACorrelativa is not null && alumnosInscriptosACorrelativa.Count > 0)
            {
                lst_AlumnosInscriptosACorrelativas.DataSource = alumnosInscriptosACorrelativa;
            }
        }
    }
}
