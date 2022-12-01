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
        frm_AsignarProfesorAMateria formAsignarProfeMateria;
        frm_AsignarProfesorACorrelativa formAsignarProfeMateriaCorrelativa;
        public frm_OpcionesMateriaAsignarProfesor()
        {
            InitializeComponent();
        }

        private void btn_AsignarProfeAMateria_Click(object sender, EventArgs e)
        {
            formAsignarProfeMateria = new frm_AsignarProfesorAMateria();
            formAsignarProfeMateria.ShowDialog();
        }

        private void btn_AsignarProfesorACorrelativa_Click(object sender, EventArgs e)
        {
            formAsignarProfeMateriaCorrelativa = new frm_AsignarProfesorACorrelativa();
            formAsignarProfeMateriaCorrelativa.ShowDialog();
        }
    }
}
