using System.Text;
using System.Xml.Schema;

namespace Entidades.Agrupacion
{
    public abstract class Persona
    {
        protected int id;
        protected string? nombre;
        protected string? apellido;
        protected string? email;
        protected string? contraseña;

        /// <summary>
        /// CONSTRUCTOR SIN PARAMETROS
        /// </summary>
        public Persona()
        {
            nombre = string.Empty;
            apellido = string.Empty;
            email = string.Empty;
            contraseña = string.Empty;
        }
        
        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="nombre"></param>
        public Persona(string? nombre) : this()
        {
            this.nombre = nombre;
        }
        
        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public Persona(string? nombre, string? apellido) : this(nombre)
        {
            this.apellido = apellido;
        }
        
        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="email"></param>
        /// <param name="contraseña"></param>
        public Persona(string? nombre, string? apellido, string? email, string? contraseña) : this(nombre, apellido)
        {
            this.email = email;
            this.contraseña = contraseña;
        }

        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="email"></param>
        /// <param name="contraseña"></param>
        public Persona(int id, string? nombre, string? apellido, string? email, string? contraseña) : this(nombre, apellido,email,contraseña)
        {
            this.id = id;
        }

        /// <summary>
        /// PROPIEDAD DE ESCRITURA Y LECTURA DEL ID
        /// </summary>
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA PARA EL ATRIBUTO NOMBRE
        /// </summary>
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA PARA EL ATRIBUTO APELLIDO
        /// </summary>
        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }
        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA PARA EL ATRIBUTO EMAIL
        /// </summary>
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA PARA EL ATRIBUTO CONTRASEÑA
        /// </summary>
        public string Contraseña
        {
            get
            {
                return contraseña;
            }
            set
            {
                contraseña = value;
            }
        }
        /// <summary>
        /// METODO ABSTRACTO QUE RETORNA EL NOMBRE COMPLETO DE UNA PERSONA
        /// </summary>
        /// <returns></returns>
        public abstract string NombreCompleto();

        /// <summary>
        /// SOBREESCRITURA DEL METODO TOSTRING
        /// </summary>
        /// <returns>STRING</returns>
        public override string ToString()
        {
            return NombreCompleto();
        }

        /// <summary>
        /// METODO VIRTUAL QUE RETORNA LOS DATOS COMPLETOS DE UNA PERSONA
        /// </summary>
        /// <returns></returns>
        public virtual string MostrarDatosCompletos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(ToString());
            sb.Append($"Email: {this.Email}");
            sb.AppendLine($"Contraseña: {this.Contraseña}");
            return sb.ToString();
        }
    }
}