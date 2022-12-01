using Entidades.Agrupacion;
using Entidades.AgrupacionDAO;
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
        AdministradorDAO administradorDAO;
        AlumnoDAO alumnoDAO;
        ProfesorDAO profesorDAO;
        public frm_AltaUsuario()
        {
            InitializeComponent();
            administradorDAO = new AdministradorDAO();
            alumnoDAO = new AlumnoDAO();
            profesorDAO = new ProfesorDAO();
        }

        private void btn_CrearUsuario_Click(object sender, EventArgs e)
        {
          if(string.IsNullOrEmpty(txt_EmailUsuario.Text) && string.IsNullOrEmpty(txt_ContraseñaUsuario.Text) && string.IsNullOrEmpty(cmb_TipoDeUsuario.Text))
          {
                MessageBox.Show("Debe ingresar como minimo el email, la contraseña y el tipo de usuario...", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
          else
          {
                switch (cmb_TipoDeUsuario.Text)
                {
                    case "Administrador":
                        var nuevoAdmin = new Administrador(txt_NombreUsuario.Text,txt_ApellidoUsuario.Text,txt_EmailUsuario.Text,txt_ContraseñaUsuario.Text);
                        administradorDAO.CrearAdministrador(nuevoAdmin);
                        MessageBox.Show("El usuario se creo correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    break;
                    case "Profesor":
                        var nuevoProfesor = new Profesor(txt_NombreUsuario.Text, txt_ApellidoUsuario.Text, txt_EmailUsuario.Text, txt_ContraseñaUsuario.Text);
                        profesorDAO.CrearProfesor(nuevoProfesor);
                        MessageBox.Show("El usuario se creo correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    break;
                    case "Alumno":
                        var nuevoAlumno = new Alumno(txt_NombreUsuario.Text, txt_ApellidoUsuario.Text, txt_EmailUsuario.Text, txt_ContraseñaUsuario.Text);
                        alumnoDAO.CrearAlumno(nuevoAlumno);
                        MessageBox.Show("El usuario se creo correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    break;
                }
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
