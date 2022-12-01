using Entidades.Agrupacion;
using Entidades.AgrupacionDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaUTN
{
    public partial class frm_MateriasCursadas : Form
    {
        Alumno alumnoActual;
        InscripcionDAO inscripcionDAO;
        InscripcionACorrelativaDAO inscripcionCorrelativaDAO;
        ParcialDAO parcialDAO;
        ParcialCorrelativaDAO parcialCorrelativaDAO;

        public frm_MateriasCursadas(Alumno alumno)
        {
            InitializeComponent();
            alumnoActual = alumno;
            inscripcionDAO = new InscripcionDAO();
            inscripcionCorrelativaDAO = new InscripcionACorrelativaDAO();
            parcialDAO = new ParcialDAO();
            parcialCorrelativaDAO = new ParcialCorrelativaDAO();

        }

        private void frm_MateriasCursadas_Load(object sender, EventArgs e)
        {
            try
            {
                lst_MateriasCursadas.DataSource = inscripcionDAO.GetInscripcionByIdAlumno(alumnoActual);
                lst_CorrelativasCursadas.DataSource = inscripcionCorrelativaDAO.GetInscripcionCorrelativaByIdAlumno(alumnoActual);
                lst_ParcialesMateriasCursadas.DataSource = parcialDAO.GetExamenesByIdAlumno(alumnoActual);
                lst_ParcialesCorrelativasCursadas.DataSource = parcialCorrelativaDAO.GetExamenDelAlumnoById(alumnoActual);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
