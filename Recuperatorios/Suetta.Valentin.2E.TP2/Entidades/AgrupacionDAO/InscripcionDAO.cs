using Entidades.Agrupacion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.AgrupacionDAO
{
    public class InscripcionDAO : BaseDAO
    {
        /// <summary>
        /// CONSTRUCTOR BASE
        /// </summary>
        public InscripcionDAO() : base()
        {

        }

        /// <summary>
        /// METODO QUE SE ENCARGA DE INSCRIBIR UN ALUMNO A UNA MATERIA
        /// </summary>
        /// <param name="a"></param>
        /// <param name="m"></param>
        /// <param name="condicionAlumno"></param>
        public void RealizarInscripcionAMateria(Alumno a, Materia m, ECondicion condicionAlumno)
        {
            Alumno alumno = a;
            Materia materia = m;
            ECondicion condicion = condicionAlumno;

            try
            {
                conexion = new SqlConnection(this.conexionDB);

                conexion.Open();


                string query = "INSERT INTO Inscripcion (condicionAlumno,idAlumno,idMateria) VALUES (@condicionAlumno,@idAlumno,@idMateria)";

                comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("condicionAlumno", condicion.ToString());
                comando.Parameters.AddWithValue("idAlumno", alumno.Id);
                comando.Parameters.AddWithValue("idMateria", materia.Id);

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
        /// METODO QUE ME RETORNA TODAS LAS INSCRIPCIONES A MATERIAS
        /// </summary>
        /// <returns></returns>
        public List<Inscripción> GetAllAlumnosInscriptosAMateria()
        {
            Inscripción inscripcion = null;
            List<Inscripción> inscripciones = new List<Inscripción>();
            try
            {

                conexion = new SqlConnection(this.conexionDB);
                conexion.Open();

                string query = $"SELECT * FROM Inscripcion";

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
                        inscripcion = new Inscripción(id, ECondicion.Regular, idAlumno, idMateria);
                    }
                    else
                    {
                        if (condicion == "Libre")
                        {
                            inscripcion = new Inscripción(id, ECondicion.Libre, idAlumno, idMateria);
                        }
                    }
                    _ = inscripciones + inscripcion;
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
        /// <param name="inscripcion"></param>
        public void ModificarInscripcion(int id, Inscripción inscripcion)
        {
            try
            {

                conexion = new SqlConnection(this.conexionDB);

                conexion.Open();

                string query = "UPDATE Inscripcion SET condicionAlumno = @condicionAlumno, idAlumno = @idAlumno, idMateria = @idMateria WHERE id = @id";

                comando = new SqlCommand(query, conexion);

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("id", id);
                comando.Parameters.AddWithValue("condicionAlumno", inscripcion.CondicionAlumno.ToString());
                comando.Parameters.AddWithValue("idAlumno", inscripcion.IdAlumno);
                comando.Parameters.AddWithValue("idMateria", inscripcion.IdMateria);

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
        /// METODO QUE SE ENCARGA DE RETORNAR TODAS LAS INSCRIPCIONES QUE TIENE UN ALUMNO EN ESPECIFICO
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns></returns>
        public List<Inscripción> GetInscripcionByIdAlumno(Alumno alumno)
        {
            Inscripción inscripcionRecuperada = null;
            List<Inscripción> inscripciones = new List<Inscripción>();

            try
            {

                conexion = new SqlConnection(this.conexionDB);
                conexion.Open();

                string query = $"SELECT * FROM Inscripcion WHERE idAlumno = {alumno.Id}";

                comando = new SqlCommand(query, conexion);

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {

                    int id = datos.GetInt32(0);
                    string condicion = datos.GetString(1);
                    int? idAlumno = datos.GetInt32(2);
                    int? idMateria = datos.GetInt32(3);

                    if (condicion == "Regular" || condicion == "regular")
                    {
                        inscripcionRecuperada = new Inscripción(id, ECondicion.Regular, idAlumno, idMateria);
                    }
                    else
                    {
                        if (condicion == "Libre" || condicion == "libre")
                        {
                            inscripcionRecuperada = new Inscripción(id, ECondicion.Libre, idAlumno, idMateria);
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
        /// METODO QUE SE ENCARGA DE RETORNAR TODAS LAS INSCRIPCIONES QUE TIENE UNA MATERIA ESPECIFICA
        /// </summary>
        /// <param name="materia"></param>
        /// <returns></returns>
        public List<Inscripción> GetInscripcionByIdMateria(int? idMateria)
        {
            Inscripción inscripcionRecuperada = null;
            List<Inscripción> inscripciones = new List<Inscripción>();

            try
            {

                conexion = new SqlConnection(this.conexionDB);
                conexion.Open();

                string query = $"SELECT * FROM Inscripcion WHERE idMateria = {idMateria}";

                comando = new SqlCommand(query, conexion);

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {

                    int id = datos.GetInt32(0);
                    string condicion = datos.GetString(1);
                    int? idAlumno = datos.GetInt32(2);
                    int? idMateriaRecuperada = datos.GetInt32(3);

                    if (condicion == "Regular" || condicion == "regular")
                    {
                        inscripcionRecuperada = new Inscripción(id, ECondicion.Regular, idAlumno, idMateria);
                    }
                    else
                    {
                        if (condicion == "Libre" || condicion == "libre")
                        {
                            inscripcionRecuperada = new Inscripción(id, ECondicion.Libre, idAlumno, idMateria);
                        }
                    }
                    _ = inscripciones + inscripcionRecuperada;
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
