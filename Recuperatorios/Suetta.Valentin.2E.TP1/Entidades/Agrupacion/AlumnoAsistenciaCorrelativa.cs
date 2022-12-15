using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Agrupacion
{
    public class AlumnoAsistenciaCorrelativa
    {
        private MateriaCorrelativa correlativa;
        private Alumno alumno;
        private string? asistencia;

        /// <summary>
        /// CONSTRUCTOR SIN PARAMETROS
        /// </summary>
        public AlumnoAsistenciaCorrelativa()
        {
            correlativa = null;
            alumno = null;
            asistencia = null;
        }

        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="correlativa"></param>
        /// <param name="alumno"></param>
        public AlumnoAsistenciaCorrelativa(MateriaCorrelativa correlativa, Alumno alumno) : this()
        {
            this.correlativa = correlativa;
            this.alumno = alumno;
        }

        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="correlativa"></param>
        /// <param name="alumno"></param>
        /// <param name="asistencia"></param>
        public AlumnoAsistenciaCorrelativa(MateriaCorrelativa correlativa, Alumno alumno, string? asistencia) : this(correlativa, alumno)
        {
            this.asistencia = asistencia;
        }

        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DE LA CORRELATIVA
        /// </summary>
        public MateriaCorrelativa Correlativa
        {
            get
            {
                return correlativa;
            }
            set
            {
                correlativa = value;
            }
        }

        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DEL ALUMNO
        /// </summary>
        public Alumno Alumno
        {
            get
            {
                return alumno;
            }
            set
            {
                alumno = value;
            }
        }

        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DE LA ASISTENCIA
        /// </summary>
        public string? Asistencia
        {
            get
            {
                return asistencia;
            }
            set
            {
                asistencia = value;
            }
        }


        /// <summary>
        /// SOBRECARGA DE OPERADOR QUE SE ENCARGA DE CARGAR UNA ASISTENCIA EN EL LISTADO DE ASISTENCIAS
        /// </summary>
        /// <param name="asistencias"></param>
        /// <param name="asistencia"></param>
        /// <returns></returns>
        public static bool operator +(List<AlumnoAsistenciaCorrelativa> asistencias, AlumnoAsistenciaCorrelativa asistencia)
        {
            bool seCargo = false;
            if (asistencias is not null)
            {
                asistencias.Add(asistencia);
                seCargo = true;
            }
            return seCargo;
        }
    }
}
