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
    public partial class frm_OpcionesMateriaAsignarProfesor : Form
    {
        //Formularios
        frm_AsignarProfesorAMateria formAsignarProfeMateria;
        frm_AsignarProfesorACorrelativa formAsignarProfeMateriaCorrelativa;
        frm_Login formLogin;
        public frm_OpcionesMateriaAsignarProfesor(frm_Login login)
        {
            InitializeComponent();
            formLogin = login;
        }

        private void btn_AsignarProfeAMateria_Click(object sender, EventArgs e)
        {
            formAsignarProfeMateria = new frm_AsignarProfesorAMateria(formLogin);
            formAsignarProfeMateria.ShowDialog();
        }

        private void btn_AsignarProfesorACorrelativa_Click(object sender, EventArgs e)
        {
            formAsignarProfeMateriaCorrelativa = new frm_AsignarProfesorACorrelativa(formLogin);
            formAsignarProfeMateriaCorrelativa.ShowDialog();
        }
    }
}
