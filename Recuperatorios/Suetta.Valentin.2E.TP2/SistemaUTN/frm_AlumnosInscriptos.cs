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
    public partial class frm_AlumnosInscriptos : Form
    {
        InscripcionDAO inscripcionDAO;
        InscripcionACorrelativaDAO inscripcionCorrelativaDAO;
        Inscripción inscripcionSeleccionada;
        InscripcionACorrelativa inscripcionCorrelativaSeleccionada;
        frm_ModificarEstado formModificacion;
        frm_ModificarEstadoCorrelativa formModificacionCorrelativa;

        public frm_AlumnosInscriptos()
        {
            InitializeComponent();
            inscripcionDAO = new InscripcionDAO();
            inscripcionCorrelativaDAO = new InscripcionACorrelativaDAO();
        }

        private void frm_AlumnosInscriptos_Load(object sender, EventArgs e)
        {
            try
            {
                lst_ListadoDeInscripcionesMaterias.DataSource = inscripcionDAO.GetAllAlumnosInscriptosAMateria();
                lst_ListadoDeInscripcionesCorrelativas.DataSource = inscripcionCorrelativaDAO.GetAllAlumnosInscriptosAMateriaCorrelativa();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lst_ListadoDeInscripcionesMaterias_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                inscripcionSeleccionada = lst_ListadoDeInscripcionesMaterias.SelectedItem as Inscripción;

                if(inscripcionSeleccionada is not null)
                {
                    formModificacion = new frm_ModificarEstado(inscripcionSeleccionada);
                    formModificacion.ShowDialog();
                    ActualizarListadoMaterias();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepcion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void lst_ListadoDeInscripcionesCorrelativas_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                inscripcionCorrelativaSeleccionada = lst_ListadoDeInscripcionesCorrelativas.SelectedItem as InscripcionACorrelativa;

                if (inscripcionCorrelativaSeleccionada is not null)
                {
                    formModificacionCorrelativa = new frm_ModificarEstadoCorrelativa(inscripcionCorrelativaSeleccionada);
                    formModificacionCorrelativa.ShowDialog();

                    ActualizarListadoMateriasCorrelativas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepcion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarListadoMaterias()
        {
            lst_ListadoDeInscripcionesMaterias.DataSource = null;
            lst_ListadoDeInscripcionesMaterias.DataSource = inscripcionDAO.GetAllAlumnosInscriptosAMateria();
        }
        private void ActualizarListadoMateriasCorrelativas()
        {
            lst_ListadoDeInscripcionesCorrelativas.DataSource = null;
            lst_ListadoDeInscripcionesCorrelativas.DataSource = inscripcionCorrelativaDAO.GetAllAlumnosInscriptosAMateriaCorrelativa();
        }
    }
}
