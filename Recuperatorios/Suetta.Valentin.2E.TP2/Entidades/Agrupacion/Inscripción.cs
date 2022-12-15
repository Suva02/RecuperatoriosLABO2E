using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Agrupacion
{
    public class Inscripción
    {
        private Alumno alumno;
        private Materia materia;
        private ECondicion? condicionAlumno;

        /// <summary>
        /// CONSTRUCTOR SIN PARAMETROS
        /// </summary>
        public Inscripción()
        {
            alumno = null;
            materia = null;
            condicionAlumno = null;
        }

        
        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="alumno"></param>
        /// <param name="materia"></param>
        public Inscripción(Alumno alumno, Materia materia) : this()
        {
            this.alumno = alumno;
            this.materia = materia;
        }

        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="alumno"></param>
        /// <param name="materia"></param>
        /// <param name="condicion"></param>
        public Inscripción(Alumno alumno, Materia materia, ECondicion condicion) : this(alumno, materia)
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
            return $"Alumno: {this.alumno} | Materia: {this.materia} | Condicion: {this.condicionAlumno}";
        }
    }
}
