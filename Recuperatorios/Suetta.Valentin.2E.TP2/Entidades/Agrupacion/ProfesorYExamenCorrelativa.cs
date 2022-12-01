using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Agrupacion
{
    public class ProfesorYExamenCorrelativa
    {
        private int id;
        private int? idProfesor;
        private int? idParcialCorrelativa;

        /// <summary>
        /// CONSTRUCTOR SIN PARAMETROS
        /// </summary>
        public ProfesorYExamenCorrelativa()
        {
            idParcialCorrelativa = null;
            idProfesor = null;
        }

        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="idParcialCorrelativa"></param>
        /// <param name="idProfesor"></param>
        public ProfesorYExamenCorrelativa(int? idParcialCorrelativa, int? idProfesor) : this()
        {
            this.idParcialCorrelativa = idParcialCorrelativa;
            this.idProfesor = idProfesor;
        }

        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="id"></param>
        /// <param name="idParcialCorrelativa"></param>
        /// <param name="idProfesor"></param>
        public ProfesorYExamenCorrelativa(int id, int? idParcialCorrelativa, int? idProfesor) : this(idParcialCorrelativa, idProfesor)
        {
            this.id = id;
        }

        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DEL ID
        /// </summary>
        public int Id { get => id; set => id = value; }
        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DEL ID DEL PROFESOR
        /// </summary>
        public int? IdProfesor { get => idProfesor; set => idProfesor = value; }
        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DEL ID DEL PARCIAL
        /// </summary>
        public int? IdParcialCorrelativa { get => idParcialCorrelativa; set => idParcialCorrelativa = value; }
    }
}
