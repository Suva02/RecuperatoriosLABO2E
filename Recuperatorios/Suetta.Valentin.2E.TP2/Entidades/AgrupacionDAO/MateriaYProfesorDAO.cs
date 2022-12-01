using Entidades.Agrupacion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.AgrupacionDAO
{
    public class MateriaYProfesorDAO : BaseDAO
    {
        /// <summary>
        /// CONSTRUCTOR BASE
        /// </summary>
        public MateriaYProfesorDAO() : base()
        {

        }

        /// <summary>
        /// METODO QUE SE ENCARGA DE ASIGNAR UN PROFESOR A UNA MATERIA
        /// </summary>
        /// <param name="materia"></param>
        /// <param name="profesor"></param>
        public void AsignarProfesorAMateria(Materia materia, Profesor profesor)
        {
            try
            {
                conexion = new SqlConnection(this.conexionDB);

                conexion.Open();

                string query = "INSERT INTO MateriaYProfesor (idMateria,idProfesor) VALUES (@idMateria,@idProfesor)";

                comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("idMateria", materia.Id);
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
        /// METODO QUE RETORNA UNA LISTA CON EL PROFESOR ASIGNADO A UNA O VARIAS MATERIAS
        /// </summary>
        /// <param name="idProfesor"></param>
        /// <returns></returns>
        public List<MateriaYProfesor> GetProfesorYMateriaById(int? idProfesor)
        {
            MateriaYProfesor? materiaYProfeRecuperado = null;
            List<MateriaYProfesor> materiasYProfesores = new List<MateriaYProfesor>();
            try
            {

                conexion = new SqlConnection(this.conexionDB);
                conexion.Open();

                string query = $" SELECT * FROM MateriaYProfesor WHERE idProfesor = {idProfesor} ";

                comando = new SqlCommand(query, conexion);

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {

                    int id = datos.GetInt32(0);
                    int? idProfesorRecuperado = datos.GetInt32(1);
                    int? idMateria = datos.GetInt32(2);


                    materiaYProfeRecuperado = new MateriaYProfesor(id, idProfesorRecuperado, idMateria);
                    materiasYProfesores.Add(materiaYProfeRecuperado);
                }

                return materiasYProfesores;
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
