using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Agrupacion
{
    public class Profesor : Persona
    {
        /// <summary>
        /// CONSTRUCTOR BASE
        /// </summary>
        public Profesor() : base()
        {

        }
        
        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="nombre"></param>
        public Profesor(string? nombre) : base()
        {
            this.nombre = nombre;
        }
        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public Profesor(string? nombre, string? apellido) : base(nombre)
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
        public Profesor(string? nombre, string? apellido, string? email, string? contraseña) : base(nombre, apellido)
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
        public Profesor(int id, string? nombre, string? apellido, string? email, string? contraseña) : base(nombre, apellido,email,contraseña)
        {
            this.id = id;
        }

        /// <summary>
        /// METODO ABSTRACTO IMPLEMETADO PARA RETORNAR EL NOMBRE Y APELLIDO DEL PROFESOR
        /// </summary>
        /// <returns></returns>
        public override string NombreCompleto()
        {
            return $"{this.Nombre} {this.Apellido}";
        }

        /// <summary>
        /// SOBREESCRITURA DEL METODO TOSTRING
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
        }

        /// <summary>
        /// METODO VIRTUAL IMPLEMENTADO PARA MOSTRAR LOS DATOS COMPLETOS DE UN ALUMNO
        /// </summary>
        /// <returns></returns>
        public override string MostrarDatosCompletos()
        {
            return base.MostrarDatosCompletos();
        }
    }
}
