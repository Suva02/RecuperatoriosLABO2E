using Entidades.Agrupacion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.AgrupacionDAO
{
    public class MateriaCorrelativaYProfesorDAO : BaseDAO
    {
        /// <summary>
        /// CONSTRUCTOR BASE
        /// </summary>
        public MateriaCorrelativaYProfesorDAO() : base()
        {

        }

        /// <summary>
        /// METODO QUE SE ENCARGA DE ASIGNAR UN PROFESOR A LA MATERIA CORRELATIVA
        /// </summary>
        /// <param name="correlativa"></param>
        /// <param name="profesor"></param>
        public void AsignarProfesorAMateriaCorrelativa(MateriaCorrelativa correlativa, Profesor profesor)
        {
            try
            {
                conexion = new SqlConnection(this.conexionDB);

                conexion.Open();

                string query = "INSERT INTO MateriaCorrelativaYProfesor (idMateriaCorrelativa,idProfesor) VALUES (@idMateriaCorrelativa,@idProfesor)";

                comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("idMateriaCorrelativa", correlativa.Id);
                comando.Parameters.AddWithValue("idProfesor", profesor.Id);

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
        /// METODO QUE RETORNA UN PROFESOR ESPECIFICO CON SUS MATERIAS ASIGNADAS
        /// </summary>
        /// <param name="idProfesor"></param>
        /// <returns></returns>
        public List<MateriaCorrelativaYProfesor> GetProfesorYMateriaById(int idProfesor)
        {
            MateriaCorrelativaYProfesor? materiaCorrelativaYProfeRecuperado = null;
            List<MateriaCorrelativaYProfesor> correlativasYProfesores = new List<MateriaCorrelativaYProfesor>();
            try
            {

                conexion = new SqlConnection(this.conexionDB);
                conexion.Open();

                string query = $" SELECT * FROM MateriaCorrelativaYProfesor WHERE idProfesor = {idProfesor} ";

                comando = new SqlCommand(query, conexion);

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {

                    int id = datos.GetInt32(0);
                    int? idProfesorRecuperado = datos.GetInt32(1);
                    int? idMateriaCorrelativa = datos.GetInt32(2);


                    materiaCorrelativaYProfeRecuperado = new MateriaCorrelativaYProfesor(id, idProfesorRecuperado, idMateriaCorrelativa);
                    correlativasYProfesores.Add(materiaCorrelativaYProfeRecuperado);
                }

                return correlativasYProfesores;
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
