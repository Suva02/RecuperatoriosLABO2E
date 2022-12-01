using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Agrupacion
{
    public class AlumnoAsistencia
    {
        private int id;
        private int? idMateria;
        private int? idAlumno;
        private string? asistencia;

        /// <summary>
        /// CONSTRUCTOR SIN PARAMETROS
        /// </summary>
        public AlumnoAsistencia()
        {
            idMateria = null;
            idAlumno = null;
            asistencia = null;
        }

        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="idMateria"></param>
        /// <param name="idAlumno"></param>
        public AlumnoAsistencia(int? idMateria, int? idAlumno) : this()
        {
            this.idMateria = idMateria;
            this.idAlumno = idAlumno;
        }

        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="idMateria"></param>
        /// <param name="idAlumno"></param>

        public AlumnoAsistencia(int? idMateria, int? idAlumno, string? asistencia) : this(idMateria, idAlumno)
        {
            this.asistencia = asistencia;
        }
        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="idMateria"></param>
        /// <param name="idAlumno"></param>
        public AlumnoAsistencia(int id, int? idMateria, int? idAlumno, string? asistencia) : this(idMateria, idAlumno, asistencia)
        {
            this.id = id;
        }

        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DEL ID
        /// </summary>
        public int Id { get => id; set => id = value; }
        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DEL ID DE LA MATERIA
        /// </summary>
        public int? IdMateria { get => idMateria; set => idMateria = value; }
        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DEL ID DEL ALUMNO
        /// </summary>
        public int? IdAlumno { get => idAlumno; set => idAlumno = value; }
        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DE LA ASISTENCIA
        /// </summary>
        public string? Asistencia { get => asistencia; set => asistencia = value; }
    }
}
