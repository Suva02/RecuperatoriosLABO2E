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
    public partial class frm_CalcularAlumnosPorProfesor : Form
    {
        //Formularios
        frm_Login formLogin;

        //Listas
        List<Materia> materiasAsignadas;
        List<MateriaCorrelativa> correlativasAsignadas;
        List<Alumno> alumnosInscriptosAMateria;
        List<Alumno> alumnosInscriptosACorrelativa;

        //Profesor seleccionado
        Profesor profesorSeleccionado;

        int cantidadAlumnos;

        public frm_CalcularAlumnosPorProfesor(frm_Login login, Profesor profesor)
        {
            InitializeComponent();
            formLogin = login;
            materiasAsignadas = new List<Materia>();
            correlativasAsignadas = new List<MateriaCorrelativa>();
            alumnosInscriptosAMateria = new List<Alumno>();
            alumnosInscriptosACorrelativa = new List<Alumno>();
            profesorSeleccionado = profesor;
            cantidadAlumnos = 0;
        }
        private void frm_CalcularAlumnosPorProfesor_Load(object sender, EventArgs e)
        {

            foreach (var materiaYProfesor in formLogin.MateriasYProfesores)
            {
                if (materiaYProfesor.Value == profesorSeleccionado)
                {
                    materiasAsignadas.Add(materiaYProfesor.Key);
                }
            }

            if (materiasAsignadas is not null && materiasAsignadas.Count > 0)
            {
                lst_MateriasAsignadas.DataSource = materiasAsignadas;
            }

            foreach (var inscripciones in formLogin.InscripcionesAMaterias)
            {
                foreach (var materiaYProfesor in formLogin.MateriasYProfesores)
                {
                    if (inscripciones.Materia == materiaYProfesor.Key)
                    {
                        if (!alumnosInscriptosAMateria.Contains(inscripciones.Alumno))
                        {
                            alumnosInscriptosAMateria.Add(inscripciones.Alumno);
                            cantidadAlumnos++;
                        }
                    }
                }
            }

            if (alumnosInscriptosAMateria is not null && alumnosInscriptosAMateria.Count > 0)
            {
                lst_AlumnosInscriptosAMaterias.DataSource = alumnosInscriptosAMateria;
            }

            foreach (var correlativaYProfesor in formLogin.CorrelativasYProfesores)
            {
                if (correlativaYProfesor.Value == profesorSeleccionado)
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
                        if (!alumnosInscriptosACorrelativa.Contains(inscripciones.Alumno))
                        {
                            alumnosInscriptosACorrelativa.Add(inscripciones.Alumno);
                            cantidadAlumnos++;
                        }
                    }
                }
            }

            if (alumnosInscriptosACorrelativa is not null && alumnosInscriptosACorrelativa.Count > 0)
            {
                lst_AlumnosInscriptosACorrelativas.DataSource = alumnosInscriptosACorrelativa;
            }
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"En total, {profesorSeleccionado.NombreCompleto()} tiene {cantidadAlumnos.ToString()} alumnos");
        }
    }
}
