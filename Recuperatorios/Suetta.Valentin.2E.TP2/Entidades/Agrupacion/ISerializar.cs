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
        /// METODO QUE SE ENCARGA DE SERIALIZAR UN OBJETO
        /// </summary>
        /// <param name="objeto"></param>
        /// <param name="path"></param>
        void ExportarJSON(T objeto, string path);
    }
}
