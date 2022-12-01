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
    public partial class frm_MateriasYAlumnos : Form
    {
        Profesor profesorActual;
        MateriaYProfesorDAO materiaYProfesorDAO;
        InscripcionDAO inscripcionDAO;
        MateriaCorrelativaYProfesorDAO correlativaYProfesorDAO;
        InscripcionACorrelativaDAO inscripcionCorrelativaDAO;
        public frm_MateriasYAlumnos(Profesor profesor)
        {
            InitializeComponent();
            profesorActual = profesor;
            materiaYProfesorDAO = new MateriaYProfesorDAO();
            inscripcionDAO = new InscripcionDAO();
            correlativaYProfesorDAO = new MateriaCorrelativaYProfesorDAO();
            inscripcionCorrelativaDAO = new InscripcionACorrelativaDAO();
        }

        private void frm_MateriasYAlumnos_Load(object sender, EventArgs e)
        {
            try
            {
                var materiasYProfesor = materiaYProfesorDAO.GetProfesorYMateriaById(profesorActual.Id);

                lst_MateriasAsignadas.DataSource = materiasYProfesor;

                foreach (var item in materiasYProfesor)
                {
                    lst_AlumnosInscriptosAMaterias.DataSource = inscripcionDAO.GetInscripcionByIdMateria(item.IdMateria);
                }

                var correlativasYProfesor = correlativaYProfesorDAO.GetProfesorYMateriaById(profesorActual.Id);

                lst_CorrelativasAsignadas.DataSource = correlativasYProfesor;

                foreach (var item in correlativasYProfesor)
                {
                    lst_AlumnosInscriptosACorrelativas.DataSource = inscripcionCorrelativaDAO.GetInscripcionCorrelativaByIdCorrelativa(item.IdMateriaCorrelativa);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
