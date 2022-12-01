using Entidades.Agrupacion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.AgrupacionDAO
{
    public class MateriaDAO : BaseDAO
    {
        /// <summary>
        /// CONSTRUCTOR BASE
        /// </summary>
        public MateriaDAO() : base()
        {

        }

        /// <summary>
        /// METODO QUE CREA UNA MATERIA EN LA BASE DE DATOS
        /// </summary>
        /// <param name="m"></param>
        public void CrearMateria(Materia m)
        {
            Materia? materia = m;
            try
            {
                conexion = new SqlConnection(this.conexionDB);

                conexion.Open();


                string query = "INSERT INTO Materia (nombre,cuatrimestre) VALUES (@nombre,@cuatrimestre)";

                comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("nombre", materia.Nombre);
                comando.Parameters.AddWithValue("cuatrimestre", materia.Cuatrimestre);

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
        /// METODO QUE ME RETORNA UNA MATERIA SEGUN LOS PARAMETROS QUE SE LE PASAN (NOMBRE, CUATRIMESTRE)
        /// </summary>
        /// <param name="materia"></param>
        /// <param name="cuatrimestreMateria"></param>
        /// <returns></returns>
        public Materia GetMateria(string? materia, string? cuatrimestreMateria)
        {
            Materia? materiaRecuperada = null;
            try
            {

                conexion = new SqlConnection(this.conexionDB);
                conexion.Open();

                string query = $"SELECT * FROM Materia WHERE nombre = '{materia}' AND cuatrimestre = '{cuatrimestreMateria}' ";

                comando = new SqlCommand(query, conexion);

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {

                    int id = datos.GetInt32(0);
                    string nombre = datos.GetString(1);
                    string cuatrimestre = datos.GetString(2);


                    materiaRecuperada = new Materia(id, nombre, cuatrimestre);
                }

                return materiaRecuperada;
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
        /// METODO QUE SE ENCARGA DE TRAER TODAS LAS MATERIAS DISPONIBLES
        /// </summary>
        /// <returns></returns>
        public List<Materia> GetAllMaterias()
        {
            Materia materiaRecuperada = null;
            List<Materia> materias = new List<Materia>();
            try
            {

                conexion = new SqlConnection(this.conexionDB);
                conexion.Open();

                string query = $"SELECT * FROM Materia";

                comando = new SqlCommand(query, conexion);

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {

                    int id = datos.GetInt32(0);
                    string nombre = datos.GetString(1);
                    string cuatrimestre = datos.GetString(2);


                    materiaRecuperada = new Materia(id, nombre, cuatrimestre);
                    materias.Add(materiaRecuperada);
                }

                return materias;
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
