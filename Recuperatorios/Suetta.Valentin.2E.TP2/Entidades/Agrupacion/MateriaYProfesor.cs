using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Agrupacion
{
    public class MateriaYProfesor
    {
        private int id;
        private int? idMateria;
        private int? idProfesor;

        /// <summary>
        /// CONSTRUCTOR SIN PARAMETROS
        /// </summary>
        public MateriaYProfesor()
        {
            idMateria = null;
            idProfesor = null;
        }
        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="idMateria"></param>
        /// <param name="idProfesor"></param>
        public MateriaYProfesor(int? idMateria, int? idProfesor) : this()
        {
            this.idMateria = idMateria;
            this.idProfesor = idProfesor;
        }
        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="id"></param>
        /// <param name="idMateria"></param>
        /// <param name="idProfesor"></param>
        public MateriaYProfesor(int id, int? idMateria, int? idProfesor) : this(idMateria,idProfesor)
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
        /// PROPIEDAD DE LECTURA Y ESCRITURA DEL ID DEL PROFESOR
        /// </summary>
        public int? IdProfesor { get => idProfesor; set => idProfesor = value; }

        /// <summary>
        /// SOBREESCRITURA DE METODO
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Materia N° {this.idMateria} | Profesor N° {this.idProfesor}";
        }
    }
}
