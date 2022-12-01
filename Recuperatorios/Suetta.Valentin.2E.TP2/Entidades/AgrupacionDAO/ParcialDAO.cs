using Entidades.Agrupacion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.AgrupacionDAO
{
    public class ParcialDAO : BaseDAO
    {
        /// <summary>
        /// CONSTRUCTOR BASE
        /// </summary>
        public ParcialDAO() : base()
        {

        }

        /// <summary>
        /// METODO QUE SE ENCARGA DE CREAR UN EXAMEN PARA MATERIAS
        /// </summary>
        /// <param name="idMateria"></param>
        /// <param name="idAlumno"></param>
        /// <param name="tipoParcial"></param>
        /// <param name="nota"></param>
        /// <param name="fecha"></param>
        /// <param name="nombreExamen"></param>
        public void CrearExamen(int idMateria, int idAlumno, string tipoParcial, string nota, string fecha)
        {
            try
            {
                conexion = new SqlConnection(this.conexionDB);

                conexion.Open();


                string query = "INSERT INTO Parciales (nota,fecha,TipoParcial,idAlumno,idMateria) VALUES (@nota,@fecha,@tipoParcial,@idAlumno,@idMateria)";

                comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("nota", nota);
                comando.Parameters.AddWithValue("fecha", fecha);
                comando.Parameters.AddWithValue("tipoParcial", tipoParcial);
                comando.Parameters.AddWithValue("idAlumno", idAlumno);
                comando.Parameters.AddWithValue("idMateria", idMateria);

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
        /// METODO QUE RETORNA UNA LISTA DE EXAMENES DE MATERIAS ESPECIFICAS
        /// </summary>
        /// <param name="idsMaterias"></param>
        /// <returns></returns>
        public List<Parcial> GetExamenesByIdMateria(int? idMateria)
        {
            Parcial parcialRecuperado = null;
            List<Parcial> listaDeParciales = new List<Parcial>();
            try
            {

                conexion = new SqlConnection(this.conexionDB);
                conexion.Open();

                string query = $" SELECT * FROM Parciales WHERE idMateria = {idMateria}";

                comando = new SqlCommand(query, conexion);

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {

                    int id = datos.GetInt32(0);
                    int? nota = datos.GetInt32(1);
                    var fecha = datos.GetDateTime(2);
                    string tipoParcial = datos.GetString(3);
                    int? idAlumno = datos.GetInt32(4);
                    int? idMateriaRecuperada = datos.GetInt32(5);


                    parcialRecuperado = new Parcial(id, null, idMateriaRecuperada, idAlumno, tipoParcial, null,nota.ToString());
                    listaDeParciales.Add(parcialRecuperado);
                }

                return listaDeParciales;
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
        /// METODO QUE SE ENCARGA DE MODIFICAR LA NOTA DEL PARCIAL DE UN ALUMNO
        /// </summary>
        /// <param name="idParcial"></param>
        /// <param name="nuevaNota"></param>
        public void ModificarNotaParcial(int? idParcial, string? nuevaNota)
        {
            try
            {
                conexion = new SqlConnection(this.conexionDB);

                conexion.Open();


                string query = $"UPDATE Parciales SET nota = '{nuevaNota}' WHERE id = {idParcial}";

                comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("nota", nuevaNota);

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
        /// METODO QUE SE ENCARGA DE TRAER EXAMENES DE UN ALUMNO Y UNA MATERIA EN ESPECIFICO
        /// </summary>
        /// <param name="alumno"></param>
        /// <param name="idMateria"></param>
        /// <returns></returns>
        public List<Parcial> GetExamenesByIdAlumnoYIdMateria(Alumno alumno, int? idMateria)
        {
            Parcial parcialRecuperado = null;
            List<Parcial> listaDeParciales = new List<Parcial>();
            try
            {

                conexion = new SqlConnection(this.conexionDB);
                conexion.Open();

                string query = $" SELECT p.id, p.nota, p.tipoParcial, p.idAlumno, p.idMateria FROM Parciales p " +
                               $" WHERE p.idAlumno = {alumno.Id} AND p.idMateria = {idMateria}";
                

                comando = new SqlCommand(query, conexion);

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {

                    int id = datos.GetInt32(0);
                    int? nota = datos.GetInt32(1);
                    string tipoParcial = datos.GetString(2);
                    int? idAlumno = datos.GetInt32(3);
                    int? idMateriaRecuperada = datos.GetInt32(4);


                    parcialRecuperado = new Parcial(id, null, idMateriaRecuperada, idAlumno, tipoParcial, null, nota.ToString());
                    listaDeParciales.Add(parcialRecuperado);
                }

                return listaDeParciales;
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
        /// METODO QUE SE ENCARGA DE RETORNAR LOS EXAMENES DE UN ALUMNO ESPECIFICO
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns></returns>
        public List<Parcial> GetExamenesByIdAlumno(Alumno alumno)
        {
            Parcial parcialRecuperado = null;
            List<Parcial> listaDeParciales = new List<Parcial>();
            try
            {

                conexion = new SqlConnection(this.conexionDB);
                conexion.Open();

                string query = $" SELECT p.id, p.nota, p.tipoParcial, p.idAlumno, p.idMateria FROM Parciales p" +
                               $" WHERE p.idAlumno = {alumno.Id}";


                comando = new SqlCommand(query, conexion);

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {

                    int id = datos.GetInt32(0);
                    int? nota = datos.GetInt32(1);
                    string tipoParcial = datos.GetString(2);
                    int? idAlumno = datos.GetInt32(3);
                    int? idMateriaRecuperada = datos.GetInt32(4);


                    parcialRecuperado = new Parcial(id, null, idMateriaRecuperada, idAlumno, tipoParcial, null, nota.ToString());
                    listaDeParciales.Add(parcialRecuperado);
                }

                return listaDeParciales;
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
