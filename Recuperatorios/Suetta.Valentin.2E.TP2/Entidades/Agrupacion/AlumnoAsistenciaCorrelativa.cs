using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Agrupacion
{
    public class AlumnoAsistenciaCorrelativa
    {
        private int id;
        private int? idMateriCorrelativa;
        private int? idAlumno;
        private string? asistencia;

        /// <summary>
        /// CONSTRUCTOR SIN PARAMETROS
        /// </summary>
        public AlumnoAsistenciaCorrelativa()
        {
            idMateriCorrelativa = null;
            idAlumno = null;
            asistencia = null;
        }

        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="idMateriaCorrelativa"></param>
        /// <param name="idAlumno"></param>
        public AlumnoAsistenciaCorrelativa(int? idMateriCorrelativa, int? idAlumno) : this()
        {
            this.idMateriCorrelativa = idMateriCorrelativa;
            this.idAlumno = idAlumno;
        }

        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="idMateriaCorrelativa"></param>
        /// <param name="idAlumno"></param>

        public AlumnoAsistenciaCorrelativa(int? idMateriCorrelativa, int? idAlumno, string? asistencia) : this(idMateriCorrelativa, idAlumno)
        {
            this.asistencia = asistencia;
        }
        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="idMateriaCorrelativa"></param>
        /// <param name="idAlumno"></param>
        public AlumnoAsistenciaCorrelativa(int id, int? idMateriaCorrelativa, int? idAlumno, string? asistencia) : this(idMateriaCorrelativa, idAlumno,asistencia)
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
        public int? IdMateria { get => idMateriCorrelativa; set => idMateriCorrelativa = value; }

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
