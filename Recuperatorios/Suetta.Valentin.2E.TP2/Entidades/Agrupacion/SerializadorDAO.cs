using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades.Agrupacion
{
    public class SerializadorDAO<T> : ISerializar<T> where T : class
    {
        public delegate void DelegadoAvisoSerializacion();
        private string pathEscritorio;

        public SerializadorDAO()
        {
            this.pathEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        public string PathEscritorio { get => pathEscritorio; set => pathEscritorio = value; }

        /// <summary>
        /// METODO QUE SE ENCARGA DE GUARDAR UN OBJETO EN FORMATO JSON
        /// </summary>
        /// <param name="objeto"></param>
        /// <param name="path"></param>
        public void ExportarJSON(T objeto, string path)
        {
            string pathNuevo = $"{this.pathEscritorio}\\{path}";
            string cadenaJson;
            try
            {
                JsonSerializerOptions opciones = new JsonSerializerOptions();
                opciones.WriteIndented = true;

                cadenaJson = JsonSerializer.Serialize(objeto, opciones);
                File.WriteAllText(pathNuevo, cadenaJson);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// METODO QUE SE ENCARGA DE DESERIALIZAR UN ARCHIVO DE TIPO JSON
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public T DeserializarJSON(string path)
        {
            string pathEscritorio = $"{this.pathEscritorio}\\{path}";
            try
            {
                string jsonString = File.ReadAllText(pathEscritorio);
                T? objeto = JsonSerializer.Deserialize<T>(jsonString);
                return objeto;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
