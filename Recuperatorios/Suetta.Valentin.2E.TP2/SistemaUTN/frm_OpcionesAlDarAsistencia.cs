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
    public partial class frm_OpcionesAlDarAsistencia : Form
    {
        Alumno alumnoActual;

        frm_AsistenciaEnMateria formAsistenciaMateria;
        frm_AsistenciaEnCorrelativa formAsistenciaEnCorrelativa;
        public frm_OpcionesAlDarAsistencia(Alumno alumno)
        {
            InitializeComponent();
            alumnoActual = alumno;
        }

        private void btn_AsistenciaEnMateria_Click(object sender, EventArgs e)
        {
            formAsistenciaMateria = new frm_AsistenciaEnMateria(alumnoActual);
            formAsistenciaMateria.ShowDialog();
        }

        private void btn_DarAsistenciaCorrelativa_Click(object sender, EventArgs e)
        {
            formAsistenciaEnCorrelativa = new frm_AsistenciaEnCorrelativa(alumnoActual);
            formAsistenciaEnCorrelativa.ShowDialog();
        }
    }
}
