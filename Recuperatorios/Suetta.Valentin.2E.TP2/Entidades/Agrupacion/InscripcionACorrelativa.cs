using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Agrupacion
{
    public class InscripcionACorrelativa
    {
        private int id;
        private ECondicion? condicionAlumno;
        private int? idAlumno;
        private int? idMateriaCorrelativa;

        /// <summary>
        /// CONSTRUCTOR SIN PARAMETROS
        /// </summary>
        public InscripcionACorrelativa()
        {
            condicionAlumno = null;
            idAlumno = null;
            idMateriaCorrelativa = null;
        }

        /// <summary>
        /// SOBRECARGA DE CONSTRUCTOR
        /// </summary>
        /// <param name="idAlumno"></param>
        /// <param name="idMateria"></param>
        public InscripcionACorrelativa(int? idAlumno, int? idMateriaCorrelativa) : this()
        {
            this.idAlumno = idAlumno;
            this.idMateriaCorrelativa = idMateriaCorrelativa;
        }

        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="condicionAlumno"></param>
        /// <param name="idAlumno"></param>
        /// <param name="idMateria"></param>
        public InscripcionACorrelativa(ECondicion? condicionAlumno, int? idAlumno, int? idMateriaCorrelativa) : this(idAlumno, idMateriaCorrelativa)
        {
            this.condicionAlumno = condicionAlumno;
        }

        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="id"></param>
        /// <param name="condicionAlumno"></param>
        /// <param name="idAlumno"></param>
        /// <param name="idMateria"></param>
        public InscripcionACorrelativa(int id, ECondicion? condicionAlumno, int? idAlumno, int? idMateriaCorrelativa) : this(condicionAlumno, idAlumno, idMateriaCorrelativa)
        {
            this.id = id;
        }

        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DEL ID
        /// </summary>
        public int Id { get => id; set => id = value; }
        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DE LA CONDICION DEL ALUMNO
        /// </summary>
        public ECondicion? CondicionAlumno { get => condicionAlumno; set => condicionAlumno = value; }
        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DEL ID DEL ALUMNO
        /// </summary>
        public int? IdAlumno { get => idAlumno; set => idAlumno = value; }
        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DEL ID DE LA MATERIA CORRELATIVA
        /// </summary>
        public int? IdMateriaCorrelativa { get => idMateriaCorrelativa; set => idMateriaCorrelativa = value; }

        /// <summary>
        /// METODO SOBREESCRITURA QUE RETORNA PARTE DE LA INFO DE UNA INSCRIPCION
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Alumno N° {this.idAlumno} | Materia N° {this.idMateriaCorrelativa} | Condicion: {this.condicionAlumno}";
        }
    }
}
