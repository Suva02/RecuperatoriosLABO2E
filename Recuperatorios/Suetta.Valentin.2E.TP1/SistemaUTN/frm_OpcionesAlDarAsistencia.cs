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
        //Formularios
        frm_AsistenciaEnMateria formAsistenciaMateria;
        frm_AsistenciaEnCorrelativa formAsistenciaEnCorrelativa;
        frm_Login formLogin;

        //Alumno actual
        Alumno alumnoLogeado;
        public frm_OpcionesAlDarAsistencia(Alumno alumno, frm_Login login)
        {
            InitializeComponent();
            alumnoLogeado = alumno;
            formLogin = login;
        }

        private void btn_AsistenciaEnMateria_Click(object sender, EventArgs e)
        {
            formAsistenciaMateria = new frm_AsistenciaEnMateria(alumnoLogeado,formLogin);
            formAsistenciaMateria.ShowDialog();
        }

        private void btn_DarAsistenciaCorrelativa_Click(object sender, EventArgs e)
        {
            formAsistenciaEnCorrelativa = new frm_AsistenciaEnCorrelativa(alumnoLogeado, formLogin);
            formAsistenciaEnCorrelativa.ShowDialog();
        }
    }
}
