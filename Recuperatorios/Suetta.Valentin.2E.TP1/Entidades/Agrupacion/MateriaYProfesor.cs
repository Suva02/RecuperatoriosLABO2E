using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Agrupacion
{
    public class MateriaYProfesor
    {

        private Materia materia;
        private Profesor profesor;

        /// <summary>
        /// CONSTRUCTOR SIN PARAMETROS
        /// </summary>
        public MateriaYProfesor()
        {
            materia = null;
            profesor = null;
        }
        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="materia"></param>
        /// <param name="profesor"></param>
        public MateriaYProfesor(Materia materia, Profesor profesor) : this()
        {
            this.materia = materia;
            this.profesor = profesor;
        }

        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DE LA MATERIA
        /// </summary>
        public Materia Materia
        {
            get
            {
                return this.materia;
            }
            set
            {
                this.materia = value;
            }
        }

        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DEL PROFESOR
        /// </summary>
        public Profesor Profesor
        {
            get
            {
                return this.profesor;
            }
            set
            {
                this.profesor = value;
            }
        }

        /// <summary>
        /// SOBREESCRITURA DE METODO
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Materia: {materia.Nombre} | Profesor: {profesor.Nombre}";
        }
    }
}
