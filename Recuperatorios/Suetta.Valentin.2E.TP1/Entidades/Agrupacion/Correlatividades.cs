using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Agrupacion
{
    public class Correlatividades
    {
        private Materia materia;
        private MateriaCorrelativa correlativa;

        /// <summary>
        /// CONSTRUCTOR SIN PARAMETROS
        /// </summary>
        public Correlatividades()
        {
            materia = null;
            correlativa = null;
        }

        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="materia"></param>
        /// <param name="correlativa"></param>
        public Correlatividades(Materia materia, MateriaCorrelativa correlativa) : this()
        {
            this.materia = materia;
            this.correlativa = correlativa;
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
        /// PROPIEDAD DE LECTURA Y ESCRITURA DE LA CORRELATIVA
        /// </summary>
        public MateriaCorrelativa Correlativa
        {
            get
            {
                return this.correlativa;
            }
            set
            {
                this.correlativa = value;
            }
        }

        /// <summary>
        /// METODO SOBREESCRITO
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Materia: {this.materia.Nombre} | Correlativa: {this.correlativa.Nombre}";
        }
    }
}
