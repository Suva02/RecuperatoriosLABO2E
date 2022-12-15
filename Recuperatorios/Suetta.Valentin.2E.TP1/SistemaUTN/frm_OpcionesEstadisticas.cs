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
    public partial class frm_OpcionesEstadisticas : Form
    {
        //Formularios
        frm_Login formLogin;
        frm_SeleccionarProfesor formSeleccionarProfesor;
        frm_SeleccionarAlumno formSeleccionarAlumno;
        public frm_OpcionesEstadisticas(frm_Login login)
        {
            InitializeComponent();
            formLogin = login;
        }

        private void btn_CalcularAlumnosDeProfesor_Click(object sender, EventArgs e)
        {
            formSeleccionarProfesor = new frm_SeleccionarProfesor(formLogin);
            formSeleccionarProfesor.ShowDialog();
        }

        private void btn_CalcularNotaPromedioDeAlumno_Click(object sender, EventArgs e)
        {
            formSeleccionarAlumno = new frm_SeleccionarAlumno(formLogin);
            formSeleccionarAlumno.ShowDialog();
        }
    }
}
