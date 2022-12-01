using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Agrupacion
{
    public class Inscripción
    {
        private int id;
        private ECondicion? condicionAlumno;
        private int? idAlumno;
        private int? idMateria;

        /// <summary>
        /// CONSTRUCTOR SIN PARAMETROS
        /// </summary>
        public Inscripción()
        {
            condicionAlumno = null;
            idAlumno = null;
            idMateria = null;
        }

        /// <summary>
        /// SOBRECARGA DE CONSTRUCTOR
        /// </summary>
        /// <param name="idAlumno"></param>
        /// <param name="idMateria"></param>
        public Inscripción(int? idAlumno, int? idMateria) : this()
        {
            this.idAlumno = idAlumno;
            this.idMateria = idMateria;
        }

        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="condicionAlumno"></param>
        /// <param name="idAlumno"></param>
        /// <param name="idMateria"></param>
        public Inscripción(ECondicion? condicionAlumno, int? idAlumno, int? idMateria) : this(idAlumno, idMateria)
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
        public Inscripción(int id, ECondicion? condicionAlumno, int? idAlumno, int? idMateria) : this(condicionAlumno, idAlumno,idMateria)
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
        /// PROPIEDAD DE LECTURA Y ESCRITURA DEL ID DE LA MATERIA
        /// </summary>
        public int? IdMateria { get => idMateria; set => idMateria = value; }

        /// <summary>
        /// METODO SOBREESCRITURA QUE RETORNA PARTE DE LA INFO DE UNA INSCRIPCION
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Alumno N° {this.idAlumno} | Materia N° {this.idMateria} | Condicion: {this.condicionAlumno}";
        }

        /// <summary>
        /// SOBRECARGA DE OPERADOR QUE SE ENCARGA DE AGREGAR UNA INSCRIPCION A UNA LISTA
        /// </summary>
        /// <param name="listaDeInscripciones"></param>
        /// <param name="inscripcion"></param>
        /// <returns></returns>
        public static bool operator + (List<Inscripción> listaDeInscripciones, Inscripción inscripcion)
        {
            bool seAgrego = false;
            if(listaDeInscripciones is not null && inscripcion is not null)
            {
                if (!listaDeInscripciones.Contains(inscripcion))
                {
                    listaDeInscripciones.Add(inscripcion);
                    seAgrego = true;
                }
            }
            return seAgrego;
        }
    }
}
