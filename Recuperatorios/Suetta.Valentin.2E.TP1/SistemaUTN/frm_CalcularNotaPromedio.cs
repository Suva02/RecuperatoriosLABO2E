using Entidades.Agrupacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaUTN
{
    public partial class frm_CalcularNotaPromedio : Form
    {
        frm_Login formLogin;
        Materia materiaSeleccionada;
        MateriaCorrelativa correlativaSeleccionada;

        List<Parcial> parcialesMateria;
        List<ParcialCorrelativa> parcialesCorrelativas;

        Alumno alumnoSeleccionado;
        public frm_CalcularNotaPromedio(frm_Login login, Alumno alumno)
        {
            InitializeComponent();
            formLogin = login;
            parcialesMateria = new List<Parcial>();
            alumnoSeleccionado = alumno;
            parcialesCorrelativas = new List<ParcialCorrelativa>();
        }

        private void frm_CalcularNotaPromedio_Load(object sender, EventArgs e)
        {
            if(formLogin.MateriasCreadas.Count > 0)
            {
                lst_Materias.DataSource = formLogin.MateriasCreadas;
            }

            if(formLogin.CorrelativasCreadas.Count > 0)
            {
                lst_Correlativas.DataSource = formLogin.CorrelativasCreadas;
            }
        }

        private void lst_Materias_DoubleClick(object sender, EventArgs e)
        {
            materiaSeleccionada = lst_Materias.SelectedItem as Materia;
            if(materiaSeleccionada is not null)
            {
                MessageBox.Show($"Materia seleccionada: {materiaSeleccionada.Nombre}");
            }
        }

        private void lst_Correlativas_DoubleClick(object sender, EventArgs e)
        {
            correlativaSeleccionada = lst_Correlativas.SelectedItem as MateriaCorrelativa;
            if (correlativaSeleccionada is not null)
            {
                MessageBox.Show($"Correlativa seleccionada: {correlativaSeleccionada.Nombre}");
            }
        }

        private void btn_CalcularMateria_Click(object sender, EventArgs e)
        {
            if(materiaSeleccionada is not null)
            {
                foreach (var parcial in formLogin.ParcialesMaterias)
                {
                    if (parcial.Materia == materiaSeleccionada)
                    {
                        if(parcial.Alumno == alumnoSeleccionado)
                        {
                            parcialesMateria.Add(parcial);
                        }
                    }
                }

                if (parcialesMateria.Count > 0 && parcialesMateria.Count > 3)
                {
                    if (parcialesMateria[0].TipoParcial == "Primer parcial" && parcialesMateria[1].TipoParcial == "Segundo parcial")
                    {
                        int notaParcialUno;
                        int notaParcialDos;

                        int.TryParse(parcialesMateria[0].Nota, out notaParcialUno);
                        int.TryParse(parcialesMateria[1].Nota, out notaParcialDos);

                        MessageBox.Show($"La nota promedio del alumno es: {(notaParcialUno + notaParcialDos) /2 }","Atencion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btn_CalcularNotaEnCorrelativa_Click(object sender, EventArgs e)
        {
            if (correlativaSeleccionada is not null)
            {
                foreach (var parcialCorrelativa in formLogin.ParcialesCorrelativas)
                {
                    if (parcialCorrelativa.Correlativa == correlativaSeleccionada)
                    {
                        if (parcialCorrelativa.Alumno == alumnoSeleccionado)
                        {
                            parcialesCorrelativas.Add(parcialCorrelativa);
                        }
                    }
                }

                if (parcialesCorrelativas.Count > 0 && parcialesCorrelativas.Count > 3)
                {
                    if (parcialesCorrelativas[0].TipoParcial == "Primer parcial" && parcialesCorrelativas[1].TipoParcial == "Segundo parcial")
                    {
                        int notaParcialUno;
                        int notaParcialDos;

                        int.TryParse(parcialesMateria[0].Nota, out notaParcialUno);
                        int.TryParse(parcialesMateria[1].Nota, out notaParcialDos);

                        MessageBox.Show($"La nota promedio del alumno es: {(notaParcialUno + notaParcialDos) / 2}","Atencion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
