using Entidades.Agrupacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaUTN
{
    public partial class frm_MateriasCursadas : Form
    {
        //Alumno actual
        Alumno alumnoActual;

        //Form login
        frm_Login formLogin;

        //Inscripciones a materias/correlativas
        List<Inscripción> inscripcionesMaterias;
        List<InscripcionACorrelativa> inscripcionesCorrelativas;

        //Parciales
        List<Parcial> parciales;
        List<ParcialCorrelativa> parcialesCorrelativa;

        public frm_MateriasCursadas(Alumno alumno, frm_Login login)
        {
            InitializeComponent();
            alumnoActual = alumno;
            formLogin = login;
            inscripcionesMaterias = new List<Inscripción>();
            inscripcionesCorrelativas = new List<InscripcionACorrelativa>();
            parciales = new List<Parcial>();
            parcialesCorrelativa = new List<ParcialCorrelativa>();
        }

        private void frm_MateriasCursadas_Load(object sender, EventArgs e)
        {
            foreach (var inscripcion in formLogin.InscripcionesAMaterias)
            {
                if(inscripcion.Alumno == alumnoActual)
                {
                    inscripcionesMaterias.Add(inscripcion);
                }
            }

            foreach (var inscripcionCorrelativa in formLogin.InscripcionesACorrelativas)
            {
                if(inscripcionCorrelativa.Alumno == alumnoActual)
                {
                    inscripcionesCorrelativas.Add(inscripcionCorrelativa);
                }
            }

            if (inscripcionesMaterias.Count > 0)
                lst_MateriasCursadas.DataSource = inscripcionesMaterias;


            if(inscripcionesCorrelativas.Count > 0)
                lst_CorrelativasCursadas.DataSource = inscripcionesCorrelativas;


            foreach (var parcial in formLogin.ParcialesMaterias)
            {
                if(parcial.Alumno == alumnoActual)
                {
                    parciales.Add(parcial);
                }
            }
            foreach (var parcialCorrelativa in formLogin.ParcialesCorrelativas)
            {
                if (parcialCorrelativa.Alumno == alumnoActual)
                {
                    parcialesCorrelativa.Add(parcialCorrelativa);
                }
            }

            if (parciales.Count > 0)
                lst_ParcialesMateriasCursadas.DataSource = parciales;


            if (parcialesCorrelativa.Count > 0)
                lst_ParcialesCorrelativasCursadas.DataSource = parcialesCorrelativa;

        }
    }
}
