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
        //Formularios
        frm_InscribirseAMateria formularioInscripcionMateria;
        frm_OpcionesAlDarAsistencia formularioOpcionesAsistencia;
        frm_MateriasCursadas formMateriasCursadas;
        frm_Login formLogin;

        //Alumno logeado
        Alumno alumnoLogeado;

        public frm_Alumno(Alumno alumno, frm_Login login)
        {
            InitializeComponent();
            alumnoLogeado = alumno;
            formLogin = login;
        }

        private void btn_Inscribirse_Click(object sender, EventArgs e)
        {
            formularioInscripcionMateria = new frm_InscribirseAMateria(formLogin, alumnoLogeado);
            formularioInscripcionMateria.ShowDialog();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DarAsistencia_Click(object sender, EventArgs e)
        {
            formularioOpcionesAsistencia = new frm_OpcionesAlDarAsistencia(alumnoLogeado,formLogin);
            formularioOpcionesAsistencia.ShowDialog();
        }

        private void btn_MateriasCursadas_Click(object sender, EventArgs e)
        {
            formMateriasCursadas = new frm_MateriasCursadas(alumnoLogeado,formLogin);
            formMateriasCursadas.ShowDialog();
        }
    }
}
