using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Agrupacion
{
    public class MateriaCorrelativaYProfesor
    {
        private int id;
        private int? idMateriaCorrelativa;
        private int? idProfesor;

        /// <summary>
        /// CONSTRUCTOR SIN PARAMETROS
        /// </summary>
        public MateriaCorrelativaYProfesor()
        {
            idMateriaCorrelativa = null;
            idProfesor = null;
        }
        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="idMateriaCorrelativa"></param>
        /// <param name="idProfesor"></param>
        public MateriaCorrelativaYProfesor(int? idMateriaCorrelativa, int? idProfesor) : this()
        {
            this.idMateriaCorrelativa = idMateriaCorrelativa;
            this.idProfesor = idProfesor;
        }
        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="id"></param>
        /// <param name="idMateriaCorrelativa"></param>
        /// <param name="idProfesor"></param>
        public MateriaCorrelativaYProfesor(int id, int? idMateriaCorrelativa, int? idProfesor) : this(idMateriaCorrelativa, idProfesor)
        {
            this.id = id;
        }

        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DEL ID
        /// </summary>
        public int Id { get => id; set => id = value; }

        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DEL ID DE LA MATERIA CORRELATIVA
        /// </summary>
        public int? IdMateriaCorrelativa { get => idMateriaCorrelativa; set => idMateriaCorrelativa = value; }

        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DEL ID DEL PROFESOR
        /// </summary>
        public int? IdProfesor { get => idProfesor; set => idProfesor = value; }


        /// <summary>
        /// METODO SOBREESCRITO
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Correlativa N° {this.idMateriaCorrelativa} | Profesor N° {this.idProfesor}";
        }
    }
}
