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
    public partial class frm_Alumno : Form
    {
        Alumno alumnoLogeado;

        frm_InscribirseAMateria formularioInscripcionMateria;
        frm_OpcionesAlDarAsistencia formularioOpcionesAsistencia;
        frm_MateriasCursadas formMateriasCursadas;
        frm_Login frmLogin;
        public frm_Alumno(Alumno alumno, frm_Login form)
        {
            InitializeComponent();
            alumnoLogeado = alumno;
            this.frmLogin = form;
        }

        private void btn_Inscribirse_Click(object sender, EventArgs e)
        {
            formularioInscripcionMateria = new frm_InscribirseAMateria(alumnoLogeado, frmLogin);
            formularioInscripcionMateria.ShowDialog();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DarAsistencia_Click(object sender, EventArgs e)
        {
            formularioOpcionesAsistencia = new frm_OpcionesAlDarAsistencia(alumnoLogeado);
            formularioOpcionesAsistencia.ShowDialog();
        }

        private void btn_MateriasCursadas_Click(object sender, EventArgs e)
        {
            formMateriasCursadas = new frm_MateriasCursadas(alumnoLogeado);
            formMateriasCursadas.ShowDialog();
        }
    }
}
