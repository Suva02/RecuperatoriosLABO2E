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
    public partial class frm_Administrador : Form
    {
        //Instancias de formularios
        frm_AltaUsuario formularioDeAlta;
        frm_CrearMateria formularioCreacionMateria;
        frm_AlumnosInscriptos formAlumnosInscriptos;
        frm_OpcionesMateriaAsignarProfesor formOpcionesAsignacion;
        frm_Login formLogin;

        //Administrador actual
        Administrador administradorLogeado;


        public frm_Administrador(Administrador administrador, frm_Login login)
        {
            InitializeComponent();
            administradorLogeado = administrador;
            formLogin = login;
        }

        private void btn_DarDeAltaUsuario_Click(object sender, EventArgs e)
        {
            formularioDeAlta = new frm_AltaUsuario(formLogin);
            formularioDeAlta.ShowDialog();
        }

        private void btn_ModificarEstadosDeMateria_Click(object sender, EventArgs e)
        {
            formAlumnosInscriptos = new frm_AlumnosInscriptos(formLogin);
            formAlumnosInscriptos.ShowDialog();
        }

        private void btn_CrearMaterias_Click(object sender, EventArgs e)
        {
            formularioCreacionMateria = new frm_CrearMateria(formLogin);
            formularioCreacionMateria.ShowDialog();
        }

        private void btn_SalirDelForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AsignarProfesores_Click(object sender, EventArgs e)
        {
            formOpcionesAsignacion = new frm_OpcionesMateriaAsignarProfesor(formLogin);
            formOpcionesAsignacion.ShowDialog();
        }
    }
}
