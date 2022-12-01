using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Agrupacion
{
    public class ProfesorYExamen
    {
        private int id;
        private int? idProfesor;
        private int? idParcial;

        /// <summary>
        /// CONSTRUCTOR SIN PARAMETROS
        /// </summary>
        public ProfesorYExamen()
        {
            idParcial = null;
            idProfesor = null;
        }
        
        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="idParcial"></param>
        /// <param name="idProfesor"></param>
        public ProfesorYExamen(int? idParcial, int? idProfesor) : this()
        {
            this.idParcial = idParcial;
            this.idProfesor = idProfesor;
        }

        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="id"></param>
        /// <param name="idParcial"></param>
        /// <param name="idProfesor"></param>
        public ProfesorYExamen(int id, int? idParcial, int? idProfesor) : this(idParcial, idProfesor)
        {
            this.id = id;
        }

        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA PARA EL ID
        /// </summary>
        public int Id { get => id; set => id = value; }
        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA PARA EL ID DEL PROFESOR
        /// </summary>
        public int? IdProfesor { get => idProfesor; set => idProfesor = value; }
        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA PARA EL ID DEL PARCIAL
        /// </summary>
        public int? IdParcial { get => idParcial; set => idParcial = value; }
    }
}
