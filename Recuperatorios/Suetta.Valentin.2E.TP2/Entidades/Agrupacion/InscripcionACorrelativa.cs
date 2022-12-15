using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Agrupacion
{
    public class InscripcionACorrelativa
    {
        private Alumno alumno;
        private MateriaCorrelativa correlativa;
        private ECondicion? condicionAlumno;

        /// <summary>
        /// CONSTRUCTOR SIN PARAMETROS
        /// </summary>
        public InscripcionACorrelativa()
        {
            alumno = null;
            correlativa = null;
            condicionAlumno = null;
        }


        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="alumno"></param>
        /// <param name="correlativa"></param>
        public InscripcionACorrelativa(Alumno alumno, MateriaCorrelativa correlativa) : this()
        {
            this.alumno = alumno;
            this.correlativa = correlativa;
        }

        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="alumno"></param>
        /// <param name="correlativa"></param>
        /// <param name="condicion"></param>
        public InscripcionACorrelativa(Alumno alumno, MateriaCorrelativa correlativa, ECondicion condicion) : this(alumno, correlativa)
        {
            this.condicionAlumno = condicion;
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
        /// PROPIEDAD DE LECTURA Y ESCRITURA DE LA MATERIA
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
        /// PROPIEDAD DE LECTURA Y ESCRITURA DE LA CONDICION
        /// </summary>
        public ECondicion? Condicion
        {
            get
            {
                return condicionAlumno;
            }
            set
            {
                condicionAlumno = value;
            }
        }



        /// <summary>
        /// METODO SOBREESCRITO QUE RETORNA LA INFORMACION DE UNA INSCRIPCION
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Alumno: {this.alumno} | Correlativa: {this.correlativa} | Condicion: {this.condicionAlumno}";
        }
    }
}
