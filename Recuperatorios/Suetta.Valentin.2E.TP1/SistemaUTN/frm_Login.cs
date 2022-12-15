using Entidades.Agrupacion;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaUTN
{
    public partial class frm_Login : Form
    {

        //Usuarios hardcodeados
        public Administrador administradorHardcodeado;
        public Alumno alumnoHardcodeado;
        public Profesor profesorHardcodeado;

        //Banderas
        bool esAdministrador;
        bool esAlumno;
        bool esProfesor;

        //Formularios
        frm_Administrador formAdministrador;
        frm_Alumno formAlumno;
        frm_Profesor formProfesor;

        //Usuarios dados de alta
        List<Administrador> administradoresCreados;
        List<Alumno> alumnosCreados;
        List<Profesor> profesoresCreados;

        //Materias creadas
        List<Materia> materiasCreadas;
        List<MateriaCorrelativa> correlativasCreadas;

        //Diccionarios
        Dictionary<Materia, MateriaCorrelativa> correlatividades;
        Dictionary<Materia, Profesor> materiasYProfesores;
        Dictionary<MateriaCorrelativa, Profesor> correlativasYProfesores;

        //Lista de examenes
        List<Parcial> parcialesMaterias;
        List<ParcialCorrelativa> parcialesCorrelativas;

        //Lista de inscripciones
        List<Inscripción> inscripcionesAMaterias;
        List<InscripcionACorrelativa> inscripcionesACorrelativas;

        //Lista de asistencias
        List<AlumnoAsistencia> asistenciaMaterias;
        List<AlumnoAsistenciaCorrelativa> asistenciaCorrelativas;

        //Contador de inscripciones
        int cantidadInscripciones;

        public frm_Login()
        {
            InitializeComponent();
            administradorHardcodeado = new Administrador("Valentin", "Suetta", "valentin@gmail.com", "esAdmin123");
            alumnoHardcodeado = new Alumno("Felipe", "Gil", "felipe@gmail.com", "esAlumno123");
            profesorHardcodeado = new Profesor("Mario", "Rampi", "mario@gmail.com", "esProfe123");
            UsuariosHardcodeados.usuariosHarcodeados.Add(administradorHardcodeado.Email,administradorHardcodeado.Contraseña);
            UsuariosHardcodeados.usuariosHarcodeados.Add(alumnoHardcodeado.Email, alumnoHardcodeado.Contraseña);
            UsuariosHardcodeados.usuariosHarcodeados.Add(profesorHardcodeado.Email, profesorHardcodeado.Contraseña);
            esAdministrador = false;
            esProfesor = false;
            esAlumno = false;
            administradoresCreados = new List<Administrador>();
            alumnosCreados = new List<Alumno>();
            profesoresCreados = new List<Profesor>();
            materiasCreadas = new List<Materia>();
            correlativasCreadas = new List<MateriaCorrelativa>();
            correlatividades = new Dictionary<Materia, MateriaCorrelativa>();
            profesoresCreados.Add(profesorHardcodeado);
            alumnosCreados.Add(alumnoHardcodeado);
            administradoresCreados.Add(administradorHardcodeado);
            materiasYProfesores = new Dictionary<Materia, Profesor>();
            correlativasYProfesores = new Dictionary<MateriaCorrelativa, Profesor>();
            parcialesMaterias = new List<Parcial>();
            parcialesCorrelativas = new List<ParcialCorrelativa>();
            inscripcionesAMaterias = new List<Inscripción>();
            inscripcionesACorrelativas = new List<InscripcionACorrelativa>();
            asistenciaMaterias = new List<AlumnoAsistencia>();
            asistenciaCorrelativas = new List<AlumnoAsistenciaCorrelativa>();
            cantidadInscripciones = 0;
        }

        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA PARA LA CANTIDAD DE INSCRIPCIONES
        /// </summary>
        public int CantidadInscripciones
        {
            get
            {
                return cantidadInscripciones;
            }
            set
            {
                cantidadInscripciones = value;
            }
        }

        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DE LOS ADMINISTRADORES CREADOS
        /// </summary>
        public List<Administrador> AdministradoresCreados
        {
            get
            {
                return this.administradoresCreados;
            }
            set
            {
                this.administradoresCreados = value;
            }
        }
        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DE LOS ALUMNOS CREADOS
        /// </summary>
        public List<Alumno> AlumnosCreados
        {
            get
            {
                return this.alumnosCreados;
            }
            set
            {
                this.alumnosCreados = value;
            }
        }

        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DE LOS PROFESORES CREADOS
        /// </summary>
        public List<Profesor> ProfesoresCreados
        {
            get
            {
                return this.profesoresCreados;
            }
            set
            {
                this.profesoresCreados = value;
            }
        }

        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DE LAS MATERIAS CREADAS
        /// </summary>
        public List<Materia> MateriasCreadas
        {
            get
            {
                return this.materiasCreadas;
            }
            set
            {
                this.materiasCreadas = value;
            }
        }

        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DE LAS CORRELATIVAS CREADAS
        /// </summary>
        public List<MateriaCorrelativa> CorrelativasCreadas
        {
            get
            {
                return this.correlativasCreadas;
            }
            set
            {
                this.correlativasCreadas = value;
            }
        }

        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DE LAS CORRELATIVIDADES CREADAS
        /// </summary>
        public Dictionary<Materia,MateriaCorrelativa> Correlatividades
        {
            get
            {
                return this.correlatividades;
            }
            set
            {
                this.correlatividades = value;
            }
        }

        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DE LAS MATERIAS CON SUS PROFESORES
        /// </summary>
        public Dictionary<Materia, Profesor> MateriasYProfesores
        {
            get
            {
                return this.materiasYProfesores;
            }
            set
            {
                this.materiasYProfesores = value;
            }
        }

        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DE LAS CORRELATIVAS CON SUS PROFESORES
        /// </summary>
        public Dictionary<MateriaCorrelativa, Profesor> CorrelativasYProfesores
        {
            get
            {
                return this.correlativasYProfesores;
            }
            set
            {
                this.correlativasYProfesores = value;
            }
        }

        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DE LA LISTA DE EXAMENES CREADOS PARA MATERIAS
        /// </summary>
        public List<Parcial> ParcialesMaterias
        {
            get
            {
                return this.parcialesMaterias;
            }
            set
            {
                this.parcialesMaterias = value;
            }
        }

        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DE LA LISTA DE EXAMENES CREADOS PARA CORRELATIVAS
        /// </summary>
        public List<ParcialCorrelativa> ParcialesCorrelativas
        {
            get
            {
                return this.parcialesCorrelativas;
            }
            set
            {
                this.parcialesCorrelativas = value;
            }
        }

        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DE LAS INSCRIPCIONES A MATERIAS
        /// </summary>
        public List<Inscripción> InscripcionesAMaterias
        {
            get
            {
                return this.inscripcionesAMaterias;
            }
            set
            {
                this.inscripcionesAMaterias = value;
            }
        }


        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DE LAS INSCRIPCIONES A CORRELATIVAS
        /// </summary>
        public List<InscripcionACorrelativa> InscripcionesACorrelativas
        {
            get
            {
                return this.inscripcionesACorrelativas;
            }
            set
            {
                this.inscripcionesACorrelativas = value;
            }
        }

        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DE LA LISTA DE ASISTENCIAS A MATERIAS
        /// </summary>
        public List<AlumnoAsistencia> AsistenciaMaterias
        {
            get
            {
                return this.asistenciaMaterias;
            }
            set
            {
                this.asistenciaMaterias = value;
            }
        }

        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DE LA LISTA DE ASISTENCIAS A CORRELATIVAS
        /// </summary>
        public List<AlumnoAsistenciaCorrelativa> AsistenciaCorrelativas
        {
            get
            {
                return this.asistenciaCorrelativas;
            }
            set
            {
                this.asistenciaCorrelativas = value;
            }
        }

        /// <summary>
        /// EVENTO CLICK QUE AUTOCOMPLETA LOS CAMPOS CON LOS DATOS DE UN ADMINISTRADOR HARDCODEADO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AutocompletarComoAdministrador_Click(object sender, EventArgs e)
        {
            foreach (var datos in UsuariosHardcodeados.usuariosHarcodeados)
            {
                if(datos.Key == "valentin@gmail.com" && datos.Value == "esAdmin123")
                {
                    txt_EmailIngresado.Text = datos.Key;
                    txt_ContraseñaIngresada.Text = datos.Value;
                    esAdministrador = true;
                    break;
                }
            }
        }

        /// <summary>
        /// EVENTO CLICK QUE AUTOCOMPLETA LOS CAMPOS CON LOS DATOS DE UN PROFESOR HARDCODEADO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AutocompletarComoProfesor_Click(object sender, EventArgs e)
        {
            foreach (var datos in UsuariosHardcodeados.usuariosHarcodeados)
            {
                if (datos.Key == "mario@gmail.com" && datos.Value == "esProfe123")
                {
                    txt_EmailIngresado.Text = datos.Key;
                    txt_ContraseñaIngresada.Text = datos.Value;
                    esProfesor = true;
                    break;
                }
            }
        }

        /// <summary>
        /// EVENTO CLICK QUE AUTOCOMPLETA LOS CAMPOS CON LOS DATOS DE UN ALUMNO HARDCODEADO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AutocompletarComoAlumno_Click(object sender, EventArgs e)
        {
            foreach (var datos in UsuariosHardcodeados.usuariosHarcodeados)
            {
                if (datos.Key == "felipe@gmail.com" && datos.Value == "esAlumno123")
                {
                    txt_EmailIngresado.Text = datos.Key;
                    txt_ContraseñaIngresada.Text = datos.Value;
                    esAlumno = true;
                    break;
                }
            }
        }

        /// <summary>
        /// EVENTO CLICK QUE INICIA SESION SEGUN LOS DATOS QUE SE INGRESARON EN LOS CAMPOS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_EmailIngresado.Text) && !string.IsNullOrEmpty(txt_ContraseñaIngresada.Text))
            {
                if (esAdministrador)
                {
                    formAdministrador = new frm_Administrador(administradorHardcodeado,this);
                    formAdministrador.ShowDialog();
                    esAdministrador = false;
                    LimpiarCampos();
                }
                else if (esProfesor)
                {
                    formProfesor = new frm_Profesor(profesorHardcodeado,this);
                    formProfesor.ShowDialog();
                    esProfesor = false;
                    LimpiarCampos();
                }
                else if (esAlumno)
                {
                    formAlumno = new frm_Alumno(alumnoHardcodeado,this);
                    formAlumno.ShowDialog();
                    esAlumno = false;
                    LimpiarCampos();
                }
                else
                {
                    if(administradoresCreados is not null)
                    {
                        foreach (var administrador in administradoresCreados)
                        {
                            if (txt_EmailIngresado.Text == administrador.Email && txt_ContraseñaIngresada.Text == administrador.Contraseña)
                            {
                                esAdministrador = true;
                                formAdministrador = new frm_Administrador(administradorHardcodeado, this);
                                formAdministrador.ShowDialog();
                                esAdministrador = false;
                                LimpiarCampos();
                            }
                        }
                    }

                    if(alumnosCreados is not null)
                    {
                        foreach (var alumno in alumnosCreados)
                        {
                            if (txt_EmailIngresado.Text == alumno.Email && txt_ContraseñaIngresada.Text == alumno.Contraseña)
                            {            
                                esAlumno = true;
                                formAlumno = new frm_Alumno(alumno, this);
                                formAlumno.ShowDialog();
                                esAlumno = false;
                                LimpiarCampos();
                            }
                        }
                    }

                    if (profesoresCreados is not null)
                    {
                        foreach (var profesor in profesoresCreados)
                        {
                            if (txt_EmailIngresado.Text == profesor.Email && txt_ContraseñaIngresada.Text == profesor.Contraseña)
                            {
                                esProfesor = true;
                                formProfesor = new frm_Profesor(profesor,this);
                                formProfesor.ShowDialog();
                                esProfesor = false;
                                LimpiarCampos();
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe completar los campos antes de iniciar sesion", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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