using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Agrupacion
{
    public class MateriaCorrelativaYProfesor
    {
        private MateriaCorrelativa materiaCorrelativa;
        private Profesor profesor;

        /// <summary>
        /// CONSTRUCTOR SIN PARAMETROS
        /// </summary>
        public MateriaCorrelativaYProfesor()
        {
            materiaCorrelativa = null;
            profesor = null;
        }
        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="idMateriaCorrelativa"></param>
        /// <param name="idProfesor"></param>
        public MateriaCorrelativaYProfesor(MateriaCorrelativa correlativa, Profesor profesor) : this()
        {
            materiaCorrelativa = correlativa;
            this.profesor = profesor;
        }

        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DE LA MATERIA CORRELATIVA
        /// </summary>
        public MateriaCorrelativa MateriaCorrelativa
        {
            get
            {
                return this.materiaCorrelativa;
            }
            set
            {
                this.materiaCorrelativa = value;
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
        /// METODO SOBREESCRITO
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Correlativa: {materiaCorrelativa.Nombre} | Profesor: {profesor.Nombre}";
        }
    }
}
