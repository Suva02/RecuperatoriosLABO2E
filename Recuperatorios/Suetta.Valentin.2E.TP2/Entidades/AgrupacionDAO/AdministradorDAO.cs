using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Agrupacion;

namespace Entidades.AgrupacionDAO
{
    public class AdministradorDAO : BaseDAO
    {
        /// <summary>
        /// CONSTRUCTOR BASE
        /// </summary>
        public AdministradorDAO() : base()
        {

        }

        /// <summary>
        /// METODO QUE DEVUELVE UN ADMINISTRADOR (EL ADMIN HARDCODEADO)
        /// </summary>
        /// <returns>ADMINISTRADOR</returns>
        public Administrador GetAdministradaorHardcodeado()
        {
            Administrador? adminRecuperado = null;
            try
            {

                conexion = new SqlConnection(conexionDB);
                conexion.Open();

                string query = "SELECT * FROM Administrador WHERE id = 1";

                comando = new SqlCommand(query, conexion);

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {
                    int id = datos.GetInt32(0);
                    string nombre = datos.GetString(1);
                    string apellido = datos.GetString(2);
                    string email = datos.GetString(3);
                    string contraseña = datos.GetString(4);


                    adminRecuperado = new Administrador(id, nombre, apellido, email, contraseña);

                }

                return adminRecuperado;
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
        /// METODO QUE RETORNA TODOS LOS ADMINISTRADORES DE LA BASE
        /// </summary>
        /// <returns></returns>
        public List<Administrador> GetAdministradores()
        {
            Administrador? adminRecuperado = null;
            List<Administrador>? listaAdministradores = new List<Administrador>();
            try
            {

                conexion = new SqlConnection(conexionDB);
                conexion.Open();

                string query = "SELECT * FROM Administrador";

                comando = new SqlCommand(query, conexion);

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {
                    int id = datos.GetInt32(0);
                    string nombre = datos.GetString(1);
                    string apellido = datos.GetString(2);
                    string email = datos.GetString(3);
                    string contraseña = datos.GetString(4);


                    adminRecuperado = new Administrador(id, nombre, apellido, email, contraseña);
                    listaAdministradores?.Add(adminRecuperado);

                }

                return listaAdministradores;
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
        /// METODO QUE CREA UN ADMINISTRADOR EN LA BASE DE DATOS
        /// </summary>
        /// <param name="admin"></param>
        public void CrearAdministrador(Administrador admin)
        {
            Administrador? administrador = admin;
            try
            {
                conexion = new SqlConnection(this.conexionDB);

                conexion.Open();


                string query = "INSERT INTO Administrador (nombre,apellido,email,contraseña) VALUES (@nombre,@apellido,@email,@contraseña)";

                comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("nombre", administrador.Nombre);
                comando.Parameters.AddWithValue("apellido", administrador.Apellido);
                comando.Parameters.AddWithValue("email", administrador.Email);
                comando.Parameters.AddWithValue("contraseña", administrador.Contraseña);

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
