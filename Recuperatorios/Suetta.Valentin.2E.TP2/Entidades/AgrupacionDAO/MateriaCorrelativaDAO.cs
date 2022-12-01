using Entidades.Agrupacion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.AgrupacionDAO
{
    public class MateriaCorrelativaDAO : BaseDAO
    {
        /// <summary>
        /// CONSTRUCTOR BASE
        /// </summary>
        public MateriaCorrelativaDAO() : base()
        {

        }

        /// <summary>
        /// METODO QUE CREA UNA MATERIA CORRELATIVA EN LA BASE DE DATOS
        /// </summary>
        /// <param name="mc"></param>
        public void CrearMateriaCorrelativa(MateriaCorrelativa mc)
        {
            MateriaCorrelativa? correlativa = mc;
            try
            {
                conexion = new SqlConnection(this.conexionDB);

                conexion.Open();


                string query = "INSERT INTO MateriaCorrelativa (nombre,cuatrimestre) VALUES (@nombre,@cuatrimestre)";

                comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("nombre", correlativa.Nombre);
                comando.Parameters.AddWithValue("cuatrimestre", correlativa.Cuatrimestre);

                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conexion is not null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        /// <summary>
        /// METODO QUE ME DEVUELVE LA MATERIA CORRELATIVA SEGUN LOS PARAMETROS QUE SE LE PASAN (NOMBRE, CUATRIMESTRE)
        /// </summary>
        /// <param name="correlativa"></param>
        /// <param name="cuatrimestreCorrelativa"></param>
        /// <returns></returns>
        public MateriaCorrelativa GetMateriaCorrelativa(string? correlativa, string? cuatrimestreCorrelativa)
        {
            MateriaCorrelativa? correlativaRecuperada = null;
            try
            {

                conexion = new SqlConnection(this.conexionDB);
                conexion.Open();

                string query = $"SELECT * FROM MateriaCorrelativa WHERE nombre = '{correlativa}' AND cuatrimestre = '{cuatrimestreCorrelativa}' ";

                comando = new SqlCommand(query, conexion);

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {

                    int id = datos.GetInt32(0);
                    string nombre = datos.GetString(1);
                    string cuatrimestre = datos.GetString(2);


                    correlativaRecuperada = new MateriaCorrelativa(id, nombre, cuatrimestre);
                }

                return correlativaRecuperada;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conexion is not null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        /// <summary>
        /// METODO QUE TRAE TODAS LAS MATERIAS CORRELATIVAS GUARDADAS EN LA BASE
        /// </summary>
        /// <returns></returns>
        public List<MateriaCorrelativa> GetAllCorrelativas()
        {
            MateriaCorrelativa? correlativaRecuperada = null;
            List<MateriaCorrelativa> correlativas = new List<MateriaCorrelativa>();
            try
            {
                conexion = new SqlConnection(this.conexionDB);
                conexion.Open();

                string query = $"SELECT * FROM MateriaCorrelativa";

                comando = new SqlCommand(query, conexion);

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {

                    int id = datos.GetInt32(0);
                    string nombre = datos.GetString(1);
                    string cuatrimestre = datos.GetString(2);


                    correlativaRecuperada = new MateriaCorrelativa(id, nombre, cuatrimestre);
                    correlativas.Add(correlativaRecuperada);
                }

                return correlativas;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conexion is not null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
    }
}
