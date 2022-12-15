using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Agrupacion
{
    public class Parcial
    {

        private Materia materia;
        private Alumno alumno;
        private string? tipoParcial;
        private DateTime? fecha;
        private string? nota;

        /// <summary>
        /// CONSTRUCTOR SIN PARAMETROS
        /// </summary>
        public Parcial()
        {
            materia = null;
            alumno = null;
            tipoParcial = string.Empty;
            fecha = null;
            nota = string.Empty;
        }
        
        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="materia"></param>
        /// <param name="alumno"></param>
        public Parcial(Materia materia, Alumno alumno) : this()
        {
            this.materia = materia;
            this.alumno = alumno;
        }

        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="materia"></param>
        /// <param name="alumno"></param>
        /// <param name="tipoParcial"></param>
        public Parcial(Materia materia, Alumno alumno, string? tipoParcial) : this(materia, alumno)
        {
            this.tipoParcial = tipoParcial;
        }

        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="materia"></param>
        /// <param name="alumno"></param>
        /// <param name="tipoParcial"></param>
        /// <param name="fecha"></param>
        public Parcial(Materia materia, Alumno alumno, string? tipoParcial,DateTime? fecha) : this(materia, alumno, tipoParcial)
        {
            this.fecha = fecha;
        }

        /// <summary>
        /// CONSTRUCTOR SOBRECARGADO
        /// </summary>
        /// <param name="materia"></param>
        /// <param name="alumno"></param>
        /// <param name="tipoParcial"></param>
        /// <param name="fecha"></param>
        /// <param name="nota"></param>
        public Parcial(Materia materia, Alumno alumno, string? tipoParcial, DateTime? fecha, string? nota) : this(materia, alumno, tipoParcial, fecha)
        {
            this.nota = nota;
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
        /// PROPIEDAD DE LECTURA Y ESCRITURA DEL ALUMNO
        /// </summary>
        public Alumno Alumno
        {
            get
            {
                return this.alumno;
            }
            set
            {
                this.alumno = value;
            }
        }


        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DEL TIPO DE PARCIAL
        /// </summary>
        public string? TipoParcial
        {
            get
            {
                return this.tipoParcial;
            }
            set
            {
                this.tipoParcial = value;
            }
        }


        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DE LA FECHA
        /// </summary>
        public DateTime? Fecha
        {
            get
            {
                return this.fecha;
            }
            set
            {
                this.fecha = value;
            }
        }


        /// <summary>
        /// PROPIEDAD DE LECTURA Y ESCRITURA DE LA NOTA
        /// </summary>
        public string? Nota
        {
            get
            {
                return this.nota;
            }
            set
            {
                this.nota = value;
            }
        }


        /// <summary>
        /// METODO TOSTRING SOBREESCRITO
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Materia: {materia.Nombre} | Alumno: {alumno.Nombre} | {this.tipoParcial} | Nota: {nota}";
        }
    }
}
