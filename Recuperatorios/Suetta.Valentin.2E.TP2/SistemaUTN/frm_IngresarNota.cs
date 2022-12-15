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
    public partial class frm_IngresarNota : Form
    {
        //Formularios
        frm_Login formLogin;

        //Profesor actual
        Profesor profesorActual;

        //Listas
        List<Parcial> parcialesDisponibles;

        //Parcial seleccionado
        Parcial parcialSeleccionado;


        public frm_IngresarNota(Profesor profesor, frm_Login login)
        {
            InitializeComponent();
            profesorActual = profesor;
            formLogin = login;
            parcialesDisponibles = new List<Parcial>();

        }

        private void frm_IngresarNota_Load(object sender, EventArgs e)
        {
            foreach (var materiaYProfesor in formLogin.MateriasYProfesores)
            {
                foreach (var parcial in formLogin.ParcialesMaterias)
                {
                    if(materiaYProfesor.Value == profesorActual)
                    {
                        if(parcial.Materia == materiaYProfesor.Key)
                        {
                            parcialesDisponibles.Add(parcial);
                        }
                    }
                }
            }

            if(parcialesDisponibles is not null && parcialesDisponibles.Count > 0)
            {
                lst_ParcialesDisponibles.DataSource = parcialesDisponibles;
            }
            else
            {
                MessageBox.Show("Debe estar asignado a materias y haber creado uno o mas parciales!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lst_ParcialesDisponibles_DoubleClick(object sender, EventArgs e)
        {
            parcialSeleccionado = lst_ParcialesDisponibles.SelectedItem as Parcial;

            if (parcialSeleccionado is not null)
            {
                txt_TipoDeParcial.Text = parcialSeleccionado.TipoParcial;
                txt_Materia.Text = parcialSeleccionado.Materia.Nombre;
                txt_Nota.Text = parcialSeleccionado.Nota;
            }
            else
            {
                MessageBox.Show("Hubo un error al seleccionar el parcial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_IngresarNota_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Nota.Text) && !string.IsNullOrEmpty(txt_Materia.Text) && !string.IsNullOrEmpty(txt_TipoDeParcial.Text))
            {
                parcialSeleccionado.Nota = txt_Nota.Text;
                MessageBox.Show("La nota se guardo correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarListado();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un parcial y modificar la nota, si es que lo precisa...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarListado()
        {
            lst_ParcialesDisponibles.DataSource = null;
            lst_ParcialesDisponibles.DataSource = parcialesDisponibles;
            txt_TipoDeParcial.Text = string.Empty;
            txt_Materia.Text = string.Empty;
            txt_Nota.Text = string.Empty;
        }
    }
}
