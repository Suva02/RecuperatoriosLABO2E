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
    public partial class frm_AltaUsuario : Form
    {
        //Usuarios a crear
        Administrador administradorACrear;
        Alumno alumnoACrear;
        Profesor profesorACrear;

        //Formularios
        frm_Login formLogin;


        public frm_AltaUsuario(frm_Login login)
        {
            InitializeComponent();
            formLogin = login;
        }

        private void btn_CrearUsuario_Click(object sender, EventArgs e)
        {
          if(!string.IsNullOrEmpty(txt_NombreUsuario.Text) && !string.IsNullOrEmpty(txt_ApellidoUsuario.Text) && !string.IsNullOrEmpty(txt_EmailUsuario.Text)
                && !string.IsNullOrEmpty(txt_ContraseñaUsuario.Text) && !string.IsNullOrEmpty(cmb_TipoDeUsuario.Text))
            {
                switch (cmb_TipoDeUsuario.Text)
                {
                    case "Administrador":
                        administradorACrear = new Administrador(txt_NombreUsuario.Text, txt_ApellidoUsuario.Text, txt_EmailUsuario.Text, txt_ContraseñaUsuario.Text);
                        formLogin.AdministradoresCreados.Add(administradorACrear);
                        MessageBox.Show("El administrador se dio de alta correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    break;
                    case "Alumno":
                        alumnoACrear = new Alumno(txt_NombreUsuario.Text, txt_ApellidoUsuario.Text, txt_EmailUsuario.Text, txt_ContraseñaUsuario.Text);
                        formLogin.AlumnosCreados.Add(alumnoACrear);
                        MessageBox.Show("El alumno se dio de alta correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    break;
                    case "Profesor":
                        profesorACrear = new Profesor(txt_NombreUsuario.Text, txt_ApellidoUsuario.Text, txt_EmailUsuario.Text, txt_ContraseñaUsuario.Text);
                        formLogin.ProfesoresCreados.Add(profesorACrear);
                        MessageBox.Show("El profesor se dio de alta correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    break;
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos para poder dar de alta el usuario", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void LimpiarCampos()
        {
            txt_NombreUsuario.Text = string.Empty;
            txt_ApellidoUsuario.Text = string.Empty;
            txt_EmailUsuario.Text = string.Empty;
            txt_ContraseñaUsuario.Text = string.Empty;
            cmb_TipoDeUsuario.SelectedItem = null;
        }
    }
}
