using Entidades.Agrupacion;
using Entidades.AgrupacionDAO;
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
        Profesor profesorActual;
        ParcialDAO parcialDAO;
        MateriaYProfesorDAO materiaYProfesorDAO;
        List<MateriaYProfesor> listaDeProfesoresYMaterias;
        Parcial parcialSeleccionado;

        public frm_IngresarNota(Profesor profesor)
        {
            InitializeComponent();
            profesorActual = profesor;
            parcialDAO = new ParcialDAO();
            materiaYProfesorDAO = new MateriaYProfesorDAO();
        }

        private void frm_IngresarNota_Load(object sender, EventArgs e)
        {
            try
            {
                listaDeProfesoresYMaterias = materiaYProfesorDAO.GetProfesorYMateriaById(profesorActual.Id);
                if(listaDeProfesoresYMaterias.Count > 0)
                {
                    foreach (var profesYMaterias in listaDeProfesoresYMaterias)
                    {
                        lst_ParcialesDisponibles.DataSource = parcialDAO.GetExamenesByIdMateria(profesYMaterias.IdMateria);
                    }
                }
                else
                {
                    MessageBox.Show("No tiene materias asignadas para ingresar notas, lo sentimos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lst_ParcialesDisponibles_DoubleClick(object sender, EventArgs e)
        {
            parcialSeleccionado = lst_ParcialesDisponibles.SelectedItem as Parcial;

            if(parcialSeleccionado is not null)
            {
                txt_TipoDeParcial.Text = parcialSeleccionado.TipoParcial;
                txt_NumeroDeMateria.Text = parcialSeleccionado.IdMateria.ToString();
                txt_Nota.Text = parcialSeleccionado.Nota;
            }
            else
            {
                MessageBox.Show("Hubo un error al seleccionar el parcial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_IngresarNota_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Nota.Text) && !string.IsNullOrEmpty(txt_NumeroDeMateria.Text) && !string.IsNullOrEmpty(txt_TipoDeParcial.Text))
            {
                parcialDAO.ModificarNotaParcial(parcialSeleccionado.Id, txt_Nota.Text);
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
            listaDeProfesoresYMaterias = materiaYProfesorDAO.GetProfesorYMateriaById(profesorActual.Id);
            if (listaDeProfesoresYMaterias.Count > 0)
            {
                foreach (var profesYMaterias in listaDeProfesoresYMaterias)
                {
                    lst_ParcialesDisponibles.DataSource = parcialDAO.GetExamenesByIdMateria(profesYMaterias.IdMateria);
                }
            }
            txt_TipoDeParcial.Text = string.Empty;
            txt_NumeroDeMateria.Text = string.Empty;
            txt_Nota.Text = string.Empty;
        }
    }
}
