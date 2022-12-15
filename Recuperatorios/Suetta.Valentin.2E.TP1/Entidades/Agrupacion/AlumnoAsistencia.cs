using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Agrupacion
{
    public class AlumnoAsistencia
    {
        private Materia materia;
        private Alumno alumno;
        private string? asistencia;

        /// <summary>
        /// CONSTRUCTOR SIN PARAMETROS
        /// </summary>
        public AlumnoAsistencia()
        {
            materia = null;
            alumno = null;
            asistencia = null;
        }

        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="materia"></param>
        /// <param name="alumno"></param>
        public AlumnoAsistencia(Materia materia, Alumno alumno) : this()
        {
            this.materia = materia;
            this.alumno = alumno;
        }

        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="materia"></param>
        /// <param name="alumno"></param>
        /// <param name="asistencia"></param>
        public AlumnoAsistencia(Materia materia, Alumno alumno, string? asistencia) : this(materia, alumno)
        {
            this.asistencia = asistencia;
        }

        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DE LA MATERIA
        /// </summary>
        public Materia Materia
        {
            get
            {
                return materia;
            }
            set
            {
                materia = value;
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
        public static bool operator + (List<AlumnoAsistencia> asistencias, AlumnoAsistencia asistencia)
        {
            bool seCargo = false;
            if(asistencias is not null)
            {
                asistencias.Add(asistencia);
                seCargo = true;
            }
            return seCargo;
        }
    }
}
