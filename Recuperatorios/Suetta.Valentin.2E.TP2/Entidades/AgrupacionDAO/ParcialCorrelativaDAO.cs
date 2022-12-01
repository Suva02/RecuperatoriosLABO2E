using Entidades.Agrupacion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.AgrupacionDAO
{
    public class ParcialCorrelativaDAO : BaseDAO
    {
        /// <summary>
        /// CONSTRUCTOR BASE
        /// </summary>
        public ParcialCorrelativaDAO() : base()
        {

        }

        /// <summary>
        /// METODO QUE RETORNA LA LISTA DE PARCIALES QUE TIENE UN ALUMNO EN UNA MATERIA CORRELATIVA
        /// </summary>
        /// <param name="al"></param>
        /// <param name="idMateriaCorrelativa"></param>
        /// <returns></returns>
        public List<ParcialCorrelativa> GetParcialDelAlumnoEnCorrelativa(Alumno al, int? idMateriaCorrelativa)
        {
            ParcialCorrelativa parcial = null;
            List<ParcialCorrelativa> parciales = new List<ParcialCorrelativa>();
            try
            {

                conexion = new SqlConnection(conexionDB);
                conexion.Open();

                string query = $"SELECT pc.id, pc.nota,pc.fecha,pc.tipoParcial,pc.idAlumno,pc.idMateriaCorrelativa FROM ParcialesCorrelativas pc " +
                               $"INNER JOIN MateriaCorrelativa mc ON mc.id = pc.idMateriaCorrelativa " +
                               $"INNER JOIN Alumno al ON pc.idAlumno = al.id WHERE al.nombre LIKE '{al.Nombre}' AND mc.id = {idMateriaCorrelativa} ";


                comando = new SqlCommand(query, conexion);

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {

                    int id = datos.GetInt32(0);
                    string? nota = datos.GetString(1);
                    DateTime? fecha = datos.GetDateTime(2);
                    string? tipoParcial = datos.GetString(3);
                    int? idAlumno = datos.GetInt32(4);
                    int? idCorrelativa = datos.GetInt32(5);


                    parcial = new ParcialCorrelativa(id, null, idCorrelativa, idAlumno, tipoParcial, fecha, nota);
                    parciales.Add(parcial);
                }

                return parciales;
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
        /// METODO QUE SE ENCARGA DE CREAR UN EXAMEN PARA UNA CORRELATIVA
        /// </summary>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <param name="text1"></param>
        /// <param name="text2"></param>
        /// <param name="text3"></param>
        /// <param name="text4"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void CrearExamen(int idMateriaCorrelativa, int idAlumno, string tipoParcial,string nota, string fecha)
        {
            try
            {
                conexion = new SqlConnection(this.conexionDB);

                conexion.Open();


                string query = "INSERT INTO ParcialesCorrelativas (nota,fecha,TipoParcial,idAlumno,idMateriaCorrelativa) VALUES (@nota,@fecha,@tipoParcial,@idAlumno,@idMateriaCorrelativa)";

                comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("nota", nota);
                comando.Parameters.AddWithValue("fecha", fecha);
                comando.Parameters.AddWithValue("tipoParcial", tipoParcial);
                comando.Parameters.AddWithValue("idAlumno", idAlumno);
                comando.Parameters.AddWithValue("idMateriaCorrelativa", idMateriaCorrelativa);

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
        /// METODO QUE ME RETORNA EXAMENES DE UNA MATERIA ESPECIFICA
        /// </summary>
        /// <param name="idMateriaCorrelativa"></param>
        /// <returns></returns>
        public List<ParcialCorrelativa> GetExamenesByIdMateria(int? idMateriaCorrelativa)
        {
            ParcialCorrelativa parcialRecuperado = null;
            List<ParcialCorrelativa> listaDeParciales = new List<ParcialCorrelativa>();
            try
            {

                conexion = new SqlConnection(this.conexionDB);
                conexion.Open();

                string query = $" SELECT * FROM ParcialesCorrelativas WHERE idMateriaCorrelativa = {idMateriaCorrelativa}";

                comando = new SqlCommand(query, conexion);

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {

                    int id = datos.GetInt32(0);
                    string? nota = datos.GetString(1);
                    var fecha = datos.GetDateTime(2);
                    string tipoParcial = datos.GetString(3);
                    int? idAlumno = datos.GetInt32(4);
                    int? idMateriaCorrelativaRecuperada = datos.GetInt32(5);


                    parcialRecuperado = new ParcialCorrelativa(id,null, idMateriaCorrelativaRecuperada, idAlumno, tipoParcial, null, nota);
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
        public void ModificarNotaParcial(int? idParcialCorrelativa, string? nuevaNota)
        {
            try
            {
                conexion = new SqlConnection(this.conexionDB);

                conexion.Open();


                string query = $"UPDATE ParcialesCorrelativas SET nota = '{nuevaNota}' WHERE id = {idParcialCorrelativa}";

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
        /// METODO QUE SE ENCARGA DE BUSCAR Y RETORNAR LOS EXAMENES DE UN ALUMNO POR ID
        /// </summary>
        /// <param name="al"></param>
        /// <returns></returns>
        public List<ParcialCorrelativa> GetExamenDelAlumnoById(Alumno al)
        {
            ParcialCorrelativa parcial = null;
            List<ParcialCorrelativa> parciales = new List<ParcialCorrelativa>();
            try
            {

                conexion = new SqlConnection(conexionDB);
                conexion.Open();

                string query = $"SELECT * FROM ParcialesCorrelativas WHERE idAlumno = {al.Id}";


                comando = new SqlCommand(query, conexion);

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {

                    int id = datos.GetInt32(0);
                    string? nota = datos.GetString(1);
                    DateTime? fecha = datos.GetDateTime(2);
                    string? tipoParcial = datos.GetString(3);
                    int? idAlumno = datos.GetInt32(4);
                    int? idCorrelativa = datos.GetInt32(5);


                    parcial = new ParcialCorrelativa(id, null, idCorrelativa, idAlumno, tipoParcial, fecha, nota);
                    parciales.Add(parcial);
                }

                return parciales;
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
