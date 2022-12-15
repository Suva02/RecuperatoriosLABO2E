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
    public partial class frm_SeleccionarProfesor : Form
    {
        //Formularios
        frm_Login formLogin;
        frm_CalcularAlumnosPorProfesor formCalcularAlumnos;

        Profesor profesorSeleccionado;
        public frm_SeleccionarProfesor(frm_Login login)
        {
            InitializeComponent();
            formLogin = login;
        }

        private void frm_SeleccionarProfesor_Load(object sender, EventArgs e)
        {
            if (formLogin.ProfesoresCreados is not null)
            {
                lst_Profesores.DataSource = formLogin.ProfesoresCreados;
            }
        }

        private void lst_Profesores_DoubleClick(object sender, EventArgs e)
        {
            profesorSeleccionado = lst_Profesores.SelectedItem as Profesor;
            if(profesorSeleccionado is not null)
            {
                formCalcularAlumnos = new frm_CalcularAlumnosPorProfesor(formLogin,profesorSeleccionado);
                formCalcularAlumnos.ShowDialog();
            }
        }
    }
}
