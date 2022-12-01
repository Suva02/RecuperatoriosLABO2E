using Entidades.Agrupacion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.AgrupacionDAO
{
    public class CorrelatividadesDAO : BaseDAO
    {
        /// <summary>
        /// CONSTRUCTOR BASE
        /// </summary>
        public CorrelatividadesDAO() : base()
        {

        }

        /// <summary>
        ///METODO QUE SE GUARDA UNA MATERIA CON SU CORRELATIVA EN LA BASE DE DATOS 
        /// </summary>
        /// <param name="m"></param>
        /// <param name="mc"></param>
        public void GuardarMateriaConCorrelativa(Materia m, MateriaCorrelativa mc)
        {
            Materia? materia = m;
            MateriaCorrelativa? correlativa = mc;
            try
            {
                conexion = new SqlConnection(this.conexionDB);

                conexion.Open();


                string query = "INSERT INTO Correlatividades (idMateria,idMateriaCorrelativa) VALUES (@idMateria,@idMateriaCorrelativa)";

                comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("idMateria", materia.Id);
                comando.Parameters.AddWithValue("idMateriaCorrelativa", correlativa.Id);

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
        /// METODO QUE RETORNA LA CORRELATIVIDAD DE UNA MATERIA (SI TIENE)
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public Correlatividades ValidarMateriaCorrelativa(Materia m)
        {
            Materia materia = m;
            Correlatividades correlatividad = null;
            try
            {

                conexion = new SqlConnection(this.conexionDB);
                conexion.Open();

                string query = $"SELECT * FROM Correlatividades co " +
                                $"INNER JOIN Materia m ON m.id = co.idMateria " +
                                $"INNER JOIN MateriaCorrelativa mc ON mc.id = co.idMateriaCorrelativa WHERE m.nombre LIKE '{materia.Nombre}'";

                comando = new SqlCommand(query, conexion);

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {

                    int id = datos.GetInt32(0);
                    int? idMateria = datos.GetInt32(1);
                    int? idMateriaCorrelativa = datos.GetInt32(2);


                    correlatividad = new Correlatividades(id, idMateria, idMateriaCorrelativa);
                }

                return correlatividad;
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
