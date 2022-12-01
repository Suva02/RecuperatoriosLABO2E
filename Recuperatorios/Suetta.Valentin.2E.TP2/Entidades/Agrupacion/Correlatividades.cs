using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Agrupacion
{
    public class Correlatividades
    {
        private int id;
        private int? idMateria;
        private int? idMateriaCorrelativa;

        /// <summary>
        /// CONSTRUCTOR SIN PARAMETROS
        /// </summary>
        public Correlatividades()
        {
            idMateria = null;
            idMateriaCorrelativa = null;
        }

        /// <summary>
        /// SOBRECARGA DE CONSTRUCTOR
        /// </summary>
        /// <param name="idMateria"></param>
        /// <param name="idMateriaCorrelativa"></param>
        public Correlatividades(int? idMateria, int? idMateriaCorrelativa) : this()
        {
            this.idMateria = idMateria;
            this.idMateriaCorrelativa = idMateriaCorrelativa;
        }

        /// <summary>
        /// SOBRECARGA DE CONSTRUCTOR
        /// </summary>
        /// <param name="id"></param>
        /// <param name="idMateria"></param>
        /// <param name="idMateriaCorrelativa"></param>
        public Correlatividades(int id,int? idMateria, int? idMateriaCorrelativa) : this(idMateria,idMateriaCorrelativa)
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
        /// PROPIEDAD DE LECTURA Y ESCRITURA DEL ID DE LA CORRELATIVA
        /// </summary>
        public int? IdMateriaCorrelativa { get => idMateriaCorrelativa; set => idMateriaCorrelativa = value; }
    }
}
