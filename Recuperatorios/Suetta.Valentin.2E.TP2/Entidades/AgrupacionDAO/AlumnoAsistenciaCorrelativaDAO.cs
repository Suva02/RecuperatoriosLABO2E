using Entidades.Agrupacion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.AgrupacionDAO
{
    public class AlumnoAsistenciaCorrelativaDAO : BaseDAO
    {
        /// <summary>
        /// CONSTRUCTOR BASE
        /// </summary>
        public AlumnoAsistenciaCorrelativaDAO() : base()
        {

        }

        /// <summary>
        /// METODO QUE SE ENCARGA DE DARLE ASISTENCIA AL ALUMNO EN LA MATERIA
        /// </summary>
        /// <param name="idMateriaCorrelativa"></param>
        /// <param name="idAlumno"></param>
        /// <param name="asistencia"></param>
        public void AsignarAsistenciaAlAlumno(int? idMateriaCorrelativa, int? idAlumno, string? asistencia)
        {
            try
            {
                conexion = new SqlConnection(this.conexionDB);

                conexion.Open();


                string query = "INSERT INTO AlumnoAsistenciaCorrelativa (idMateriaCorrelativa,idAlumno,asistencia) VALUES (@idMateriaCorrelativa,@idAlumno,@asistencia)";

                comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("idMateriaCorrelativa", idMateriaCorrelativa);
                comando.Parameters.AddWithValue("idAlumno", idAlumno);
                comando.Parameters.AddWithValue("asistencia", asistencia);

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
        /// METODO QUE SE ENCARGA DE DAR LA ASISTENCIA DE UN ALUMNO A UNA MATERIA CORRELATIVA
        /// </summary>
        /// <param name="asistencia"></param>
        public void DarAsistencia(InscripcionACorrelativa inscripcion, string asistencia)
        {
            try
            {
                conexion = new SqlConnection(this.conexionDB);

                conexion.Open();


                string query = "INSERT INTO AlumnoAsistenciaCorrelativa(idMateriaCorrelativa,idAlumno,asistencia)  VALUES (@idMateriaCorrelativa,@idAlumno,@asistencia)";

                comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("idMateriaCorrelativa", inscripcion.IdMateriaCorrelativa);
                comando.Parameters.AddWithValue("idAlumno", inscripcion.IdAlumno);
                comando.Parameters.AddWithValue("asistencia", asistencia);

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
