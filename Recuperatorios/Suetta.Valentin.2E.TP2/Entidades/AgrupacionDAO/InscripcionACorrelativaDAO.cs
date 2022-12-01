using Entidades.Agrupacion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.AgrupacionDAO
{
    public class InscripcionACorrelativaDAO : BaseDAO
    {
        /// <summary>
        /// CONSTRUCTOR BASE
        /// </summary>
        public InscripcionACorrelativaDAO() : base()
        {

        }

        /// <summary>
        /// METODO QUE SE ENCARGA DE REALIZAR LA INSCRIPCION A LA MATERIA CORRELATIVA
        /// </summary>
        /// <param name="a"></param>
        /// <param name="mc"></param>
        /// <param name="condicionAlumno"></param>
        public void RealizarInscripcionAMateriaCorrelativa(Alumno a, int? idMateriaCorrelativa, ECondicion condicionAlumno)
        {
            Alumno alumno = a;
            ECondicion condicion = condicionAlumno;

            try
            {
                conexion = new SqlConnection(this.conexionDB);

                conexion.Open();


                string query = "INSERT INTO InscripcionACorrelativa (condicionAlumno,idAlumno,idMateriaCorrelativa) VALUES (@condicionAlumno,@idAlumno,@idMateriaCorrelativa)";

                comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("condicionAlumno", condicion.ToString());
                comando.Parameters.AddWithValue("idAlumno", alumno.Id);
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
        /// METODO QUE ME RETORNA TODAS LAS INSCRIPCIONES A MATERIAS CORRELATIVAS
        /// </summary>
        /// <returns></returns>
        public List<InscripcionACorrelativa> GetAllAlumnosInscriptosAMateriaCorrelativa()
        {
            InscripcionACorrelativa inscripcion = null;
            List<InscripcionACorrelativa> inscripciones = new List<InscripcionACorrelativa>();
            try
            {

                conexion = new SqlConnection(this.conexionDB);
                conexion.Open();

                string query = $"SELECT * FROM InscripcionACorrelativa";

                comando = new SqlCommand(query, conexion);

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {

                    int id = datos.GetInt32(0);
                    string condicion = datos.GetString(1);
                    int? idAlumno = datos.GetInt32(2);
                    int? idMateria = datos.GetInt32(3);

                    if (condicion == "Regular")
                    {
                        inscripcion = new InscripcionACorrelativa(id, ECondicion.Regular, idAlumno, idMateria);
                    }
                    else
                    {
                        if (condicion == "Libre")
                        {
                            inscripcion = new InscripcionACorrelativa(id, ECondicion.Libre, idAlumno, idMateria);
                        }
                    }
                    inscripciones.Add(inscripcion);
                }

                return inscripciones;
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
        /// METODO QUE SE ENCARGA DE MODIFICAR UNA INSCRIPCION
        /// </summary>
        /// <param name="id"></param>
        /// <param name="inscripcionAModificar"></param>
        public void ModificarInscripcion(int id, InscripcionACorrelativa inscripcionAModificar)
        {
            try
            {

                conexion = new SqlConnection(this.conexionDB);

                conexion.Open();

                string query = "UPDATE InscripcionACorrelativa SET condicionAlumno = @condicionAlumno, idAlumno = @idAlumno, idMateriaCorrelativa = @idMateriaCorrelativa WHERE id = @id";

                comando = new SqlCommand(query, conexion);

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("id", id);
                comando.Parameters.AddWithValue("condicionAlumno", inscripcionAModificar.CondicionAlumno.ToString());
                comando.Parameters.AddWithValue("idAlumno", inscripcionAModificar.IdAlumno);
                comando.Parameters.AddWithValue("idMateriaCorrelativa", inscripcionAModificar.IdMateriaCorrelativa);

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
        /// METODO QUE SE ENCARGA DE RETORNAR TODAS LAS INSCRIPCIONES A CORRELATIVAS QUE TIENE UN ALUMNO EN ESPECIFICO
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns></returns>
        public List<InscripcionACorrelativa> GetInscripcionCorrelativaByIdAlumno(Alumno alumno)
        {
            InscripcionACorrelativa inscripcionRecuperada = null;
            List<InscripcionACorrelativa> inscripciones = new List<InscripcionACorrelativa>();

            try
            {

                conexion = new SqlConnection(this.conexionDB);
                conexion.Open();

                string query = $"SELECT * FROM InscripcionACorrelativa WHERE idAlumno = {alumno.Id}";

                comando = new SqlCommand(query, conexion);

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {

                    int id = datos.GetInt32(0);
                    string condicion = datos.GetString(1);
                    int? idAlumno = datos.GetInt32(2);
                    int? idMateriaCorrelativa = datos.GetInt32(3);

                    if (condicion == "Regular" || condicion == "regular")
                    {
                        inscripcionRecuperada = new InscripcionACorrelativa(id, ECondicion.Regular, idAlumno, idMateriaCorrelativa);
                    }
                    else
                    {
                        if (condicion == "Libre" || condicion == "libre")
                        {
                            inscripcionRecuperada = new InscripcionACorrelativa(id, ECondicion.Libre, idAlumno, idMateriaCorrelativa);
                        }
                    }
                    inscripciones.Add(inscripcionRecuperada);
                }

                return inscripciones;
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
        /// METODO QUE SE ENCARGA DE RETORNAR TODAS LAS INSCRIPCIONES A CORRELATIVAS QUE TIENE UN ALUMNO EN ESPECIFICO
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns></returns>
        public List<InscripcionACorrelativa> GetInscripcionByIdAlumno(Alumno alumno)
        {
            InscripcionACorrelativa inscripcionRecuperada = null;
            List<InscripcionACorrelativa> inscripciones = new List<InscripcionACorrelativa>();

            try
            {

                conexion = new SqlConnection(this.conexionDB);
                conexion.Open();

                string query = $"SELECT * FROM InscripcionACorrelativa WHERE idAlumno = {alumno.Id}";

                comando = new SqlCommand(query, conexion);

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {

                    int id = datos.GetInt32(0);
                    string condicion = datos.GetString(1);
                    int? idAlumno = datos.GetInt32(2);
                    int? idMateriaCorrelativa = datos.GetInt32(3);

                    if (condicion == "Regular" || condicion == "regular")
                    {
                        inscripcionRecuperada = new InscripcionACorrelativa(id, ECondicion.Regular, idAlumno, idMateriaCorrelativa);
                    }
                    else
                    {
                        if (condicion == "Libre" || condicion == "libre")
                        {
                            inscripcionRecuperada = new InscripcionACorrelativa(id, ECondicion.Libre, idAlumno, idMateriaCorrelativa);
                        }
                    }
                    inscripciones.Add(inscripcionRecuperada);
                }

                return inscripciones;
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
        /// METODO QUE RETORNA LAS INSCRIPCIONES A UNA MATERIA ESPECIFICA
        /// </summary>
        /// <param name="idCorrelativa"></param>
        /// <returns></returns>
        public List<InscripcionACorrelativa> GetInscripcionCorrelativaByIdCorrelativa(int? idCorrelativa)
        {
            InscripcionACorrelativa inscripcionRecuperada = null;
            List<InscripcionACorrelativa> inscripciones = new List<InscripcionACorrelativa>();

            try
            {

                conexion = new SqlConnection(this.conexionDB);
                conexion.Open();

                string query = $"SELECT * FROM InscripcionACorrelativa WHERE idMateriaCorrelativa = {idCorrelativa}";

                comando = new SqlCommand(query, conexion);

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {

                    int id = datos.GetInt32(0);
                    string condicion = datos.GetString(1);
                    int? idAlumno = datos.GetInt32(2);
                    int? idMateriaCorrelativa = datos.GetInt32(3);

                    if (condicion == "Regular" || condicion == "regular")
                    {
                        inscripcionRecuperada = new InscripcionACorrelativa(id, ECondicion.Regular, idAlumno, idMateriaCorrelativa);
                    }
                    else
                    {
                        if (condicion == "Libre" || condicion == "libre")
                        {
                            inscripcionRecuperada = new InscripcionACorrelativa(id, ECondicion.Libre, idAlumno, idMateriaCorrelativa);
                        }
                    }
                    inscripciones.Add(inscripcionRecuperada);
                }

                return inscripciones;
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
