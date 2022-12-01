using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Agrupacion;

namespace Entidades.AgrupacionDAO
{
    public class AlumnoDAO : BaseDAO
    {
        /// <summary>
        /// CONSTRUCTOR BASE
        /// </summary>
        public AlumnoDAO() : base()
        {

        }

        /// <summary>
        /// METODO QUE ME DEVUELVE EL ALUMNO HARDCODEADO EN LA BASE DE DATOS
        /// </summary>
        /// <returns></returns>
        public Alumno GetAlumnoHardcodeado()
        {
            Alumno? alumnoRecuperado = null;
            try
            {

                conexion = new SqlConnection(conexionDB);
                conexion.Open();

                string query = "SELECT * FROM Alumno WHERE id = 1";

                comando = new SqlCommand(query, conexion);

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {
                    int id = datos.GetInt32(0);
                    string nombre = datos.GetString(1);
                    string apellido = datos.GetString(2);
                    string email = datos.GetString(3);
                    string contraseña = datos.GetString(4);


                    alumnoRecuperado = new Alumno(id, nombre, apellido, email, contraseña);

                }

                return alumnoRecuperado;
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
        /// METODO QUE RETORNA TODOS LOS ALUMNOS DE LA BASE
        /// </summary>
        /// <returns></returns>
        public List<Alumno> GetAlumnos()
        {
            Alumno? alumnoRecuperado = null;
            List<Alumno>? listaDeAlumnos = new List<Alumno>();
            try
            {

                conexion = new SqlConnection(conexionDB);
                conexion.Open();

                string query = "SELECT * FROM Alumno";

                comando = new SqlCommand(query, conexion);

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {
                    int id = datos.GetInt32(0);
                    string nombre = datos.GetString(1);
                    string apellido = datos.GetString(2);
                    string email = datos.GetString(3);
                    string contraseña = datos.GetString(4);


                    alumnoRecuperado = new Alumno(id, nombre, apellido, email, contraseña);
                    listaDeAlumnos?.Add(alumnoRecuperado);

                }

                return listaDeAlumnos;
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
        /// METODO QUE CREA UN ALUMNO EN LA BASE DE DATOS
        /// </summary>
        /// <param name="al"></param>
        public void CrearAlumno(Alumno al)
        {
            Alumno? alumno = al;
            try
            {
                conexion = new SqlConnection(this.conexionDB);

                conexion.Open();


                string query = "INSERT INTO Alumno (nombre,apellido,email,contraseña) VALUES (@nombre,@apellido,@email,@contraseña)";

                comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("nombre", alumno.Nombre);
                comando.Parameters.AddWithValue("apellido", alumno.Apellido);
                comando.Parameters.AddWithValue("email", alumno.Email);
                comando.Parameters.AddWithValue("contraseña", alumno.Contraseña);

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
        /// METODO QUE ME RETORNA UN ALUMNO ESPECIFICO
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Alumno GetAlumnoById(int? id)
        {
            Alumno? alumnoRecuperado = null;
            try
            {

                conexion = new SqlConnection(conexionDB);
                conexion.Open();

                string query = $"SELECT * FROM Alumno WHERE id = {id}";

                comando = new SqlCommand(query, conexion);

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {
                    int idAlumno = datos.GetInt32(0);
                    string nombre = datos.GetString(1);
                    string apellido = datos.GetString(2);
                    string email = datos.GetString(3);
                    string contraseña = datos.GetString(4);


                    alumnoRecuperado = new Alumno(idAlumno, nombre, apellido, email, contraseña);

                }

                return alumnoRecuperado;
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
