using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Agrupacion
{
    public interface ISerializar<T>
    {
        /// <summary>
        /// METODO QUE SE ENCARGA DE SERIALIZAR UN OBJETO/LISTA DE OBJETOS
        /// </summary>
        /// <param name="objeto"></param>
        /// <param name="path"></param>
        void ExportarJSON(T objeto, string path);

        /// <summary>
        /// METODO QUE SE ENCARGA DE DESERIALIZAR UN OBJETO/LISTA DE OBJETOS
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public T DeserializarJSON(string path);
    }
}
