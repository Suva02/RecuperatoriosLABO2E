using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Agrupacion
{
    public class ParcialCorrelativa
    {
        private int id;
        private string? nombre;
        private int? idMateriaCorrelativa;
        private int? idAlumno;
        private string? tipoParcial;
        private DateTime? fecha;
        private string? nota;

        /// <summary>
        /// CONSTRUCTOR SIN PARAMETROS
        /// </summary>
        public ParcialCorrelativa()
        {
            nombre = string.Empty;
            idMateriaCorrelativa = null;
            idAlumno = null;
            tipoParcial = string.Empty;
            fecha = null;
            nota = string.Empty;
        }

        /// <summary>
        /// SOBRECARGA DE CONSTRUCTOR
        /// </summary>
        /// <param name="nombre"></param>
        public ParcialCorrelativa(string? nombre) : this()
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// SOBRECARGA DE CONSTRUCTOR
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="idMateria"></param>
        /// <param name="idAlumno"></param>
        public ParcialCorrelativa(string? nombre, int? idMateriaCorrelativa, int? idAlumno) : this(nombre)
        {
            this.idMateriaCorrelativa = idMateriaCorrelativa;
            this.idAlumno = idAlumno;
        }
        /// <summary>
        /// SOBRECARGA DE CONSTRUCTOR
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="idMateria"></param>
        /// <param name="idAlumno"></param>
        /// <param name="tipoParcial"></param>
        public ParcialCorrelativa(string? nombre, int? idMateriaCorrelativa, int? idAlumno, string? tipoParcial) : this(nombre, idMateriaCorrelativa, idAlumno)
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
        public ParcialCorrelativa(string? nombre, int? idMateriaCorrelativa, int? idAlumno, string? tipoParcial, DateTime? fecha) : this(nombre, idMateriaCorrelativa, idAlumno, tipoParcial)
        {
            this.fecha = fecha;
        }

        /// <summary>
        /// SOBRECARGA DE CONSTRUCTOR
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="idMateria"></param>
        /// <param name="idAlumno"></param>
        /// <param name="tipoParcial"></param>
        /// <param name="fecha"></param>
        /// <param name="nota"></param>
        public ParcialCorrelativa(string? nombre, int? idMateriaCorrelativa, int? idAlumno, string? tipoParcial, DateTime? fecha, string? nota) : this(nombre, idMateriaCorrelativa, idAlumno, tipoParcial, fecha)
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
        public ParcialCorrelativa(int id, string? nombre, int? idMateriaCorrelativa, int? idAlumno, string? tipoParcial, DateTime? fecha, string? nota) : this(nombre, idMateriaCorrelativa, idAlumno, tipoParcial, fecha,nota)
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
        /// PROPIEDAD DE LECTURA Y ESCRITURA DEL ID DE LA MATERIA CORRELATIVA
        /// </summary>
        public int? IdMateriaCorrelativa { get => idMateriaCorrelativa; set => idMateriaCorrelativa = value; }
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
        /// PROPIEDAD DE LECTURA Y ESCRITURA DE LA NOTA DEL PARCIAL
        /// </summary>
        public string? Nota { get => nota; set => nota = value; }

        /// <summary>
        /// METODO TOSTRING SOBREESCRITO
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Numero de correlativa: {this.idMateriaCorrelativa} | Numero de alumno: {this.idAlumno} | {this.tipoParcial} | Nota: {this.nota}";
        }
    }
}
