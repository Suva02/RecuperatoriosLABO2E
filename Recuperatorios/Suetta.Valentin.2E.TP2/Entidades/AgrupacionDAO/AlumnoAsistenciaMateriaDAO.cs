using Entidades.Agrupacion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.AgrupacionDAO
{
    public class AlumnoAsistenciaMateriaDAO : BaseDAO
    {
        /// <summary>
        /// CONSTRUCTOR BASE
        /// </summary>
        public AlumnoAsistenciaMateriaDAO() : base()
        {

        }

        /// <summary>
        /// METODO QUE SE ENCARGA DE DARLE ASISTENCIA AL ALUMNO EN LA MATERIA
        /// </summary>
        /// <param name="idMateria"></param>
        /// <param name="idAlumno"></param>
        /// <param name="asistencia"></param>
        public void AsignarAsistenciaAlAlumno(int? idMateria, int? idAlumno, string? asistencia)
        {
            try
            {
                conexion = new SqlConnection(this.conexionDB);

                conexion.Open();


                string query = "INSERT INTO AlumnoAsistenciaMateria (idMateria,idAlumno,asistencia) VALUES (@idMateria,@idAlumno,@asistencia)";

                comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("idMateria", idMateria);
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
        /// METODO QUE SE ENCARGA DE DAR LA ASISTENCIA DE UN ALUMNO
        /// </summary>
        /// <param name="asistencia"></param>
        public void DarAsistencia(Inscripción inscripcion, string asistencia)
        {
            try
            {
                conexion = new SqlConnection(this.conexionDB);

                conexion.Open();


                string query = "INSERT INTO AlumnoAsistenciaMateria (idMateria,idAlumno,asistencia) VALUES (@idMateria,@idAlumno,@asistencia)";

                comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("idMateria", inscripcion.IdMateria);
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
