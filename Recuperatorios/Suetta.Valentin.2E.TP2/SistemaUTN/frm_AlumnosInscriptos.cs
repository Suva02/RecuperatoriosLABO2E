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
    public partial class frm_AlumnosInscriptos : Form
    {
        //Formularios
        frm_Login formLogin;
        frm_ModificarEstado formModificacion;
        frm_ModificarEstadoCorrelativa formModificacionCorrelativa;

        //Inscripciones a modificar
        Inscripción? inscripcionSeleccionada;
        InscripcionACorrelativa? inscripcionCorrelativaSeleccionada;

        public frm_AlumnosInscriptos(frm_Login login)
        {
            InitializeComponent();
            formLogin = login;
        }

        private void frm_AlumnosInscriptos_Load(object sender, EventArgs e)
        {
            lst_ListadoDeInscripcionesMaterias.DataSource = formLogin.InscripcionesAMaterias;
            lst_ListadoDeInscripcionesCorrelativas.DataSource = formLogin.InscripcionesACorrelativas;
        }

        private void lst_ListadoDeInscripcionesMaterias_DoubleClick(object sender, EventArgs e)
        {
            inscripcionSeleccionada = lst_ListadoDeInscripcionesMaterias.SelectedItem as Inscripción;

            if (inscripcionSeleccionada is not null)
            {
                MessageBox.Show($"{inscripcionSeleccionada.Alumno.MostrarDatosCompletos()}","Alumno seleccionado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                formModificacion = new frm_ModificarEstado(inscripcionSeleccionada);
                formModificacion.ShowDialog();
                ActualizarListadoMaterias();
            }
        }


        private void lst_ListadoDeInscripcionesCorrelativas_DoubleClick(object sender, EventArgs e)
        {
            inscripcionCorrelativaSeleccionada = lst_ListadoDeInscripcionesCorrelativas.SelectedItem as InscripcionACorrelativa;

            if (inscripcionCorrelativaSeleccionada is not null)
            {
                MessageBox.Show($"{inscripcionCorrelativaSeleccionada.Alumno.MostrarDatosCompletos()}", "Alumno seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formModificacionCorrelativa = new frm_ModificarEstadoCorrelativa(inscripcionCorrelativaSeleccionada);
                formModificacionCorrelativa.ShowDialog();

                ActualizarListadoMateriasCorrelativas();
            }
        }

        private void ActualizarListadoMaterias()
        {
            lst_ListadoDeInscripcionesMaterias.DataSource = null;
            lst_ListadoDeInscripcionesMaterias.DataSource = formLogin.InscripcionesAMaterias;
        }
        private void ActualizarListadoMateriasCorrelativas()
        {
            lst_ListadoDeInscripcionesCorrelativas.DataSource = null;
            lst_ListadoDeInscripcionesCorrelativas.DataSource = formLogin.InscripcionesACorrelativas;
        }
    }
}
