using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Agrupacion;
using Entidades.AgrupacionDAO;

namespace UnitTest
{
    [TestClass]
    public class InscripcionDAO_Test
    {
        [TestMethod]
        public void GetInscripcionByIdAlumno_CuandoIdAlumnoNoExiste_DeberiaRetornarListaVaciaDeInscripciones()
        {
            List<Inscripción> inscripciones = null;
            InscripcionDAO inscripcionDAO = new InscripcionDAO();
            Alumno alumno = new Alumno()
            {
                Id = 0,
            };

            inscripciones = inscripcionDAO.GetInscripcionByIdAlumno(alumno);
     
            Assert.AreEqual(0,inscripciones.Count);
        }

        [TestMethod]
        public void GetInscripcionByIdAlumno_CuandoIdAlumnoExiste_DeberiaRetornarListaConLasInscripciones()
        {          
            List<Inscripción> inscripciones = null;
            InscripcionDAO inscripcionDAO = new InscripcionDAO();
            Alumno alumno = new Alumno()
            {
                Id = 1,
            };

            inscripciones = inscripcionDAO.GetInscripcionByIdAlumno(alumno);
          
            Assert.AreNotEqual(0,inscripciones.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetInscripcionByIdAlumno_CuandoLaCadenaDeConexionEsNula_SeDeberiaLanzarUnaInvalidOperationException()
        {
            List<Inscripción> inscripciones = null;
            InscripcionDAO inscripcionDAO = new InscripcionDAO();
            inscripcionDAO.ConexionDB = null;
            Alumno alumno = new Alumno()
            {
                Id = 1,
            };

            inscripciones = inscripcionDAO.GetInscripcionByIdAlumno(alumno);
        }
    }
}
