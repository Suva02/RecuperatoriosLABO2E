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
    public partial class frm_OpcionesAlCrearExamen : Form
    {
        //Formularios
        frm_CrearExamenMateria formCrearExamenMateria;
        frm_CrearExamenCorrelativa formCrearExamenCorrelativa;
        frm_Login formLogin;

        //Profesor actual
        Profesor profesorActual;

        public frm_OpcionesAlCrearExamen(Profesor profesor, frm_Login login)
        {
            InitializeComponent();
            profesorActual = profesor;
            formLogin = login;
        }

        private void btn_CrearExamenMateria_Click(object sender, EventArgs e)
        {
            formCrearExamenMateria = new frm_CrearExamenMateria(profesorActual, formLogin);
            formCrearExamenMateria.ShowDialog();
        }

        private void btn_CrearExamenCorrelativa_Click(object sender, EventArgs e)
        {
            formCrearExamenCorrelativa = new frm_CrearExamenCorrelativa(profesorActual,formLogin);
            formCrearExamenCorrelativa.ShowDialog();
        }
    }
}
