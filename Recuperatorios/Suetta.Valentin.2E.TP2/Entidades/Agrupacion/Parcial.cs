using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Agrupacion
{
    public class Parcial
    {
        private int id;
        private string? nombre;
        private int? idMateria;
        private int? idAlumno;
        private string? tipoParcial;
        private DateTime? fecha;
        private string? nota;

        /// <summary>
        /// CONSTRUCTOR SIN PARAMETROS
        /// </summary>
        public Parcial()
        {
            nombre = string.Empty;
            idMateria = null;
            idAlumno = null;
            tipoParcial = string.Empty;
            fecha = null;
            nota = string.Empty;
        }

        /// <summary>
        /// SOBRECARGA DE CONSTRUCTOR
        /// </summary>
        /// <param name="nombre"></param>
        public Parcial(string? nombre) : this()
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// SOBRECARGA DE CONSTRUCTOR
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="idMateria"></param>
        /// <param name="idAlumno"></param>
        public Parcial(string? nombre, int? idMateria, int? idAlumno) : this(nombre)
        {
            this.idMateria = idMateria;
            this.idAlumno = idAlumno;
        }
        /// <summary>
        /// SOBRECARGA DE CONSTRUCTOR
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="idMateria"></param>
        /// <param name="idAlumno"></param>
        /// <param name="tipoParcial"></param>
        public Parcial(string? nombre, int? idMateria, int? idAlumno, string? tipoParcial) : this(nombre, idMateria, idAlumno)
        {
            this.tipoParcial = tipoParcial;
        }

        /// <summary>
        /// SOBRECARGA DE CONSTRUCTOR
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="idMateria"></param>
        /// <param name="idAlumno"></param>
        /// <param name="tipoParcial"></param>
        /// <param name="fecha"></param>
        public Parcial(string? nombre, int? idMateria, int? idAlumno, string? tipoParcial, DateTime? fecha) : this(nombre, idMateria, idAlumno,tipoParcial)
        {
            this.fecha = fecha;
        }

        public Parcial(string? nombre, int? idMateria, int? idAlumno, string? tipoParcial, DateTime? fecha, string? nota) : this(nombre, idMateria, idAlumno, tipoParcial, fecha)
        {
            this.nota = nota;
        }
        /// <summary>
        /// SOBRECARGA DE CONSTRUCTOR
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="idMateria"></param>
        /// <param name="idAlumno"></param>
        /// <param name="tipoParcial"></param>
        /// <param name="fecha"></param>
        public Parcial(int id, string? nombre, int? idMateria, int? idAlumno, string? tipoParcial, DateTime? fecha, string? nota) : this(nombre, idMateria, idAlumno, tipoParcial, fecha, nota)
        {
            this.id = id;
        }

        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DEL ID
        /// </summary>
        public int Id { get => id; set => id = value; }
        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DEL NOMBRE
        /// </summary>
        public string? Nombre { get => nombre; set => nombre = value; }
        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DEL ID DE LA MATERIA
        /// </summary>
        public int? IdMateria { get => idMateria; set => idMateria = value; }
        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DEL ID DEL ALUMNO
        /// </summary>
        public int? IdAlumno { get => idAlumno; set => idAlumno = value; }
        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DEL TIPO DE PARCIAL
        /// </summary>
        public string? TipoParcial { get => tipoParcial; set => tipoParcial = value; }
        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DE LA FECHA
        /// </summary>
        public DateTime? Fecha { get => fecha; set => fecha = value; }
        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DE LA NOTA
        /// </summary>
        public string? Nota { get => nota; set => nota = value; }

        /// <summary>
        /// METODO TOSTRING SOBREESCRITO
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Numero de materia: {this.idMateria} | Numero de alumno: {this.idAlumno} | {this.tipoParcial} | Nota: {this.nota}";
        }
    }
}
