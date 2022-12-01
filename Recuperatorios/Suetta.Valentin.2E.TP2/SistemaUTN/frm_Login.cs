using Entidades.Agrupacion;
using Entidades.AgrupacionDAO;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaUTN
{
    public partial class frm_Login : Form
    {

        Alumno alumnoHardcodeado;
        Profesor profesorHardcodeado;
 
        //Objetos DAO
        AdministradorDAO administradorDAO;
        AlumnoDAO alumnoDAO;
        ProfesorDAO profesorDAO;


        //Variables booleanas para indicar que formulario abrir (De tipo admin, profesor o alumno)
        bool esAdministrador;
        bool esProfesor;
        bool esAlumno;

        //Objetos de formularios
        frm_Administrador formularioDeAdministrador;
        frm_Profesor formularioDeProfesor;
        frm_Alumno formularioDeAlumno;

        public int contadorDeInscripciones = 0;


        public frm_Login()
        {
            InitializeComponent();
            administradorDAO = new AdministradorDAO();
            alumnoDAO = new AlumnoDAO();
            profesorDAO = new ProfesorDAO();
            this.esAdministrador = false;
            this.esProfesor = false;
            this.esAlumno = false;
        }



        /// <summary>
        /// EVENTO CLICK QUE AUTOCOMPLETA LOS CAMPOS CON LOS DATOS DE UN ADMINISTRADOR HARDCODEADO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AutocompletarComoAdministrador_Click(object sender, EventArgs e)
        {
            try
            {
                AdministradorDAO adminDAO = new AdministradorDAO();
                var administradorHardcodeado = adminDAO.GetAdministradaorHardcodeado();

                if(administradorHardcodeado is not null)
                {
                    if(!string.IsNullOrEmpty(administradorHardcodeado.Email) && !string.IsNullOrEmpty(administradorHardcodeado.Contraseña))
                    {
                        if (!UsuariosHardcodeados.datosIngresoAdministrador.ContainsKey(administradorHardcodeado.Email) && !UsuariosHardcodeados.datosIngresoAdministrador.ContainsValue(administradorHardcodeado.Contraseña))
                        {
                            UsuariosHardcodeados.datosIngresoAdministrador.Add(administradorHardcodeado.Email, administradorHardcodeado.Contraseña);
                            txt_EmailIngresado.Text = UsuariosHardcodeados.datosIngresoAdministrador.Keys.First();
                            txt_ContraseñaIngresada.Text = UsuariosHardcodeados.datosIngresoAdministrador.Values.First();
                            this.esAdministrador = true;
                        }
                        else
                        {
                            txt_EmailIngresado.Text = UsuariosHardcodeados.datosIngresoAdministrador.Keys.First();
                            txt_ContraseñaIngresada.Text = UsuariosHardcodeados.datosIngresoAdministrador.Values.First();
                            this.esAdministrador = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error con los datos personales del administrador, por favor vuelta a intentarlo...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hubo un error al completar como administrador, lo sentimos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// EVENTO CLICK QUE AUTOCOMPLETA LOS CAMPOS CON LOS DATOS DE UN PROFESOR HARDCODEADO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AutocompletarComoProfesor_Click(object sender, EventArgs e)
        {
            try
            {
                ProfesorDAO profesorDAO = new ProfesorDAO();
                profesorHardcodeado = profesorDAO.GetProfesorHardcodeado();

                if (profesorHardcodeado is not null)
                {
                    if (!string.IsNullOrEmpty(profesorHardcodeado.Email) && !string.IsNullOrEmpty(profesorHardcodeado.Contraseña))
                    {
                        if (!UsuariosHardcodeados.datosIngresoProfesor.ContainsKey(profesorHardcodeado.Email) && !UsuariosHardcodeados.datosIngresoProfesor.ContainsValue(profesorHardcodeado.Contraseña))
                        {
                            UsuariosHardcodeados.datosIngresoProfesor.Add(profesorHardcodeado.Email, profesorHardcodeado.Contraseña);
                            txt_EmailIngresado.Text = UsuariosHardcodeados.datosIngresoProfesor.Keys.First();
                            txt_ContraseñaIngresada.Text = UsuariosHardcodeados.datosIngresoProfesor.Values.First();
                            this.esProfesor = true;
                        }
                        else
                        {
                            txt_EmailIngresado.Text = UsuariosHardcodeados.datosIngresoProfesor.Keys.First();
                            txt_ContraseñaIngresada.Text = UsuariosHardcodeados.datosIngresoProfesor.Values.First();
                            this.esProfesor = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error con los datos personales del profesor, por favor vuelta a intentarlo...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hubo un error al completar como profesor, lo sentimos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// EVENTO CLICK QUE AUTOCOMPLETA LOS CAMPOS CON LOS DATOS DE UN ALUMNO HARDCODEADO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AutocompletarComoAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                AlumnoDAO alumnoDAO = new AlumnoDAO();
                alumnoHardcodeado = alumnoDAO.GetAlumnoHardcodeado();

                if (alumnoHardcodeado is not null)
                {
                    if (!string.IsNullOrEmpty(alumnoHardcodeado.Email) && !string.IsNullOrEmpty(alumnoHardcodeado.Contraseña))
                    {
                        if (!UsuariosHardcodeados.datosIngresoAlumno.ContainsKey(alumnoHardcodeado.Email) && !UsuariosHardcodeados.datosIngresoAlumno.ContainsValue(alumnoHardcodeado.Contraseña))
                        {
                            UsuariosHardcodeados.datosIngresoAlumno.Add(alumnoHardcodeado.Email, alumnoHardcodeado.Contraseña);
                            txt_EmailIngresado.Text = UsuariosHardcodeados.datosIngresoAlumno.Keys.First();
                            txt_ContraseñaIngresada.Text = UsuariosHardcodeados.datosIngresoAlumno.Values.First();
                            this.esAlumno = true;
                        }
                        else
                        {
                            txt_EmailIngresado.Text = UsuariosHardcodeados.datosIngresoAlumno.Keys.First();
                            txt_ContraseñaIngresada.Text = UsuariosHardcodeados.datosIngresoAlumno.Values.First();
                            this.esAlumno = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error con los datos personales del alumno, por favor vuelta a intentarlo...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hubo un error al completar como alumno, lo sentimos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// EVENTO CLICK QUE INICIA SESION SEGUN LOS DATOS QUE SE INGRESARON EN LOS CAMPOS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            bool existenAdministradores = false;
            bool existenProfesores = false;
            bool existenAlumnos = false;

            if (!string.IsNullOrEmpty(txt_EmailIngresado.Text) && !string.IsNullOrEmpty(txt_ContraseñaIngresada.Text))
            {
                if (this.esAdministrador)
                {
                    this.formularioDeAdministrador = new frm_Administrador();
                    this.formularioDeAdministrador.ShowDialog();
                    this.esAdministrador = false;
                    LimpiarCampos();
                }
                else
                {
                    if (this.esProfesor)
                    {
                        this.formularioDeProfesor = new frm_Profesor(profesorHardcodeado);
                        this.formularioDeProfesor.ShowDialog();
                        this.esProfesor = false;
                        LimpiarCampos();
                    }
                    else
                    {
                        if (this.esAlumno)
                        {
                            this.formularioDeAlumno = new frm_Alumno(alumnoHardcodeado,this);
                            this.formularioDeAlumno.ShowDialog();
                            this.esAlumno = false;
                            contadorDeInscripciones = 0;
                            LimpiarCampos();
                        }
                        else
                        {
                            try
                            {
                                var administradoresRecuperados = administradorDAO.GetAdministradores();

                                if(administradoresRecuperados.Count > 0)
                                {
                                    foreach (var admin in administradoresRecuperados)
                                    {
                                        if (admin.Email == txt_EmailIngresado.Text && admin.Contraseña == txt_ContraseñaIngresada.Text)
                                        {
                                            this.formularioDeAdministrador = new frm_Administrador();
                                            this.formularioDeAdministrador.ShowDialog();
                                            this.esAdministrador = false;
                                            LimpiarCampos();
                                            break;
                                        }
                                        else
                                        {
                                            existenAdministradores = false;
                                        }
                                    }
                                }

                                var profesoresRecuperados = profesorDAO.GetProfesores();

                                if(profesoresRecuperados.Count > 0)
                                {
                                    foreach (var profe in profesoresRecuperados)
                                    {
                                        if (profe.Email == txt_EmailIngresado.Text && profe.Contraseña == txt_ContraseñaIngresada.Text)
                                        {
                                            this.formularioDeProfesor = new frm_Profesor(profe);
                                            this.formularioDeProfesor.ShowDialog();
                                            this.esProfesor = false;
                                            LimpiarCampos();
                                            break;
                                        }
                                        else
                                        {
                                            existenProfesores = false;
                                        }
                                    }
                                }

                                var alumnosRecuperados = alumnoDAO.GetAlumnos();

                                if(alumnosRecuperados.Count > 0)
                                {
                                    foreach (var alumno in alumnosRecuperados)
                                    {
                                        if (alumno.Email == txt_EmailIngresado.Text && alumno.Contraseña == txt_ContraseñaIngresada.Text)
                                        {
                                            this.formularioDeAlumno = new frm_Alumno(alumno, this);
                                            this.formularioDeAlumno.ShowDialog();
                                            this.esAlumno = false;
                                            contadorDeInscripciones = 0;
                                            LimpiarCampos();
                                            break;
                                        }
                                        else
                                        {
                                            existenAlumnos = false;
                                        }
                                    }
                                }

                                //MOSTRAR MENSAJE CUANDO LOS DATOS INGRESADOS NO EXISTAN
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe completar los campos si desea iniciar sesion...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /// <summary>
        /// METODO  QUE SE ENCARGA DE LIMPIAR LOS TEXTBOX
        /// </summary>
        /// <param name="campoUno"></param>
        /// <param name="campoDos"></param>
        public void LimpiarCampos()
        {
            this.txt_EmailIngresado.Text = string.Empty;
            this.txt_ContraseñaIngresada.Text = string.Empty;
        }

        private void frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            var respuesta = MessageBox.Show("Desea salir del programa?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(respuesta != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}