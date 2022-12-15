using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Agrupacion
{
    public class Materia
    {
        private int id;
        private string? nombre;
        private string? cuatrimestre;

        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        public Materia()
        {
            nombre = string.Empty;
            cuatrimestre = string.Empty;
        }
        /// <summary>
        /// SOBRECARGA DE CONSTRUCTOR
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="cuatrimestre"></param>
        public Materia(string? nombre, string? cuatrimestre)
        {
            this.nombre = nombre;
            this.cuatrimestre = cuatrimestre;
        }

        /// <summary>
        /// SOBRECARGA DE CONSTRUCTOR
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="cuatrimestre"></param>
        public Materia(int id, string? nombre, string? cuatrimestre) : this(nombre,cuatrimestre)
        {
            this.id = id;
        }

        public int Id { get => id; set => id = value; }
        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Cuatrimestre { get => cuatrimestre; set => cuatrimestre = value; }

        /// <summary>
        /// SOBREESCRITURA DEL METODO toString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{nombre} | Cuatrimestre: {Cuatrimestre}";
        }
    }
}
