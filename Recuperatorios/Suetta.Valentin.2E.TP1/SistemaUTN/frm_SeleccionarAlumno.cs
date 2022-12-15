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
    public partial class frm_SeleccionarAlumno : Form
    {
        //Formularios
        frm_Login formLogin;
        frm_CalcularNotaPromedio formCalcularNota;

        Alumno alumnoSeleccionado;
        public frm_SeleccionarAlumno(frm_Login login)
        {
            InitializeComponent();
            formLogin = login;
        }

        private void frm_SeleccionarAlumno_Load(object sender, EventArgs e)
        {
            if(formLogin.AlumnosCreados.Count > 0)
            {
                lst_ListadoDeAlumnos.DataSource = formLogin.AlumnosCreados;
            }
        }

        private void lst_ListadoDeAlumnos_DoubleClick(object sender, EventArgs e)
        {
            alumnoSeleccionado = lst_ListadoDeAlumnos.SelectedItem as Alumno;
            if(alumnoSeleccionado is not null)
            {
                formCalcularNota = new frm_CalcularNotaPromedio(formLogin,alumnoSeleccionado);
                formCalcularNota.ShowDialog();
            }
        }
    }
}
