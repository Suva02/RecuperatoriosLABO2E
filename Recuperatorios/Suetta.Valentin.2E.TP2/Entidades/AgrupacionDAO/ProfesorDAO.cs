using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Agrupacion;

namespace Entidades.AgrupacionDAO
{
    public class ProfesorDAO : BaseDAO
    {
        /// <summary>
        /// CONSTRUCTOR BASE
        /// </summary>
        public ProfesorDAO() : base()
        {

        }

        /// <summary>
        /// METODO QUE ME RETORNA EL PROFESOR HARDCODEADO EN LA BASE DE DATOS
        /// </summary>
        /// <returns></returns>
        public Profesor GetProfesorHardcodeado()
        {
            Profesor? profesorRecuperado = null;
            try
            {

                conexion = new SqlConnection(conexionDB);
                conexion.Open();

                string query = "SELECT * FROM Profesor WHERE id = 1";

                comando = new SqlCommand(query, conexion);

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {
                    int id = datos.GetInt32(0);
                    string nombre = datos.GetString(1);
                    string apellido = datos.GetString(2);
                    string email = datos.GetString(3);
                    string contraseña = datos.GetString(4);


                    profesorRecuperado = new Profesor(id, nombre, apellido, email, contraseña);

                }

                return profesorRecuperado;
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
        /// METODO QUE RETORNA TODOS LOS PROFESORES DE LA BASE
        /// </summary>
        /// <returns></returns>
        public List<Profesor> GetProfesores()
        {
            Profesor? profesorRecuperado = null;
            List<Profesor>? listaDeProfesores = new List<Profesor>();
            try
            {

                conexion = new SqlConnection(conexionDB);
                conexion.Open();

                string query = "SELECT * FROM Profesor";

                comando = new SqlCommand(query, conexion);

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {
                    int id = datos.GetInt32(0);
                    string nombre = datos.GetString(1);
                    string apellido = datos.GetString(2);
                    string email = datos.GetString(3);
                    string contraseña = datos.GetString(4);


                    profesorRecuperado = new Profesor(id, nombre, apellido, email, contraseña);
                    listaDeProfesores?.Add(profesorRecuperado);

                }

                return listaDeProfesores;
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
        /// METODO QUE CREA UN PROFESOR EN LA BASE DE DATOS
        /// </summary>
        /// <param name="profe"></param>
        public void CrearProfesor(Profesor profe)
        {
            Profesor? profesor = profe;
            try
            {
                conexion = new SqlConnection(this.conexionDB);

                conexion.Open();


                string query = "INSERT INTO Profesor (nombre,apellido,email,contraseña) VALUES (@nombre,@apellido,@email,@contraseña)";

                comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("nombre", profesor.Nombre);
                comando.Parameters.AddWithValue("apellido", profesor.Apellido);
                comando.Parameters.AddWithValue("email", profesor.Email);
                comando.Parameters.AddWithValue("contraseña", profesor.Contraseña);

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
    }
}
