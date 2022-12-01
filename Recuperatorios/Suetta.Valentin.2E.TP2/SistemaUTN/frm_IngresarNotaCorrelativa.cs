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
    public partial class frm_IngresarNotaCorrelativa : Form
    {
        Profesor profesorActual;
        ParcialCorrelativaDAO parcialCorrelativaDAO;
        MateriaCorrelativaYProfesorDAO materiaCorrelativaYProfesorDAO;
        List<MateriaCorrelativaYProfesor> listaDeProfesoresYMateriasCorrelativas;

        ParcialCorrelativa parcialSeleccionado;
        public frm_IngresarNotaCorrelativa(Profesor profesor)
        {
            InitializeComponent();
            profesorActual = profesor;
            parcialCorrelativaDAO = new ParcialCorrelativaDAO();
            materiaCorrelativaYProfesorDAO = new MateriaCorrelativaYProfesorDAO();
        }

        private void frm_IngresarNotaCorrelativa_Load(object sender, EventArgs e)
        {
            try
            {
                listaDeProfesoresYMateriasCorrelativas = materiaCorrelativaYProfesorDAO.GetProfesorYMateriaById(profesorActual.Id);
                if (listaDeProfesoresYMateriasCorrelativas.Count > 0)
                {
                    foreach (var profesYMateriasCorrelativas in listaDeProfesoresYMateriasCorrelativas)
                    {
                        lst_ParcialesDisponibles.DataSource = parcialCorrelativaDAO.GetExamenesByIdMateria(profesYMateriasCorrelativas.IdMateriaCorrelativa);
                    }
                }
                else
                {
                    MessageBox.Show("No tiene correlativas asignadas para ingresar notas, lo sentimos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lst_ParcialesDisponibles_DoubleClick(object sender, EventArgs e)
        {
            parcialSeleccionado = lst_ParcialesDisponibles.SelectedItem as ParcialCorrelativa;

            if (parcialSeleccionado is not null)
            {
                txt_TipoDeParcial.Text = parcialSeleccionado.TipoParcial;
                txt_NumeroDeMateria.Text = parcialSeleccionado.IdMateriaCorrelativa.ToString();
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
                parcialCorrelativaDAO.ModificarNotaParcial(parcialSeleccionado.Id, txt_Nota.Text);
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
            listaDeProfesoresYMateriasCorrelativas = materiaCorrelativaYProfesorDAO.GetProfesorYMateriaById(profesorActual.Id);
            if (listaDeProfesoresYMateriasCorrelativas.Count > 0)
            {
                foreach (var profesYMateriasCorrelativas in listaDeProfesoresYMateriasCorrelativas)
                {
                    lst_ParcialesDisponibles.DataSource = parcialCorrelativaDAO.GetExamenesByIdMateria(profesYMateriasCorrelativas.IdMateriaCorrelativa);
                }
            }
            else
            {
                MessageBox.Show("No tiene correlativas asignadas para ingresar notas, lo sentimos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            txt_TipoDeParcial.Text = string.Empty;
            txt_NumeroDeMateria.Text = string.Empty;
            txt_Nota.Text = string.Empty;
        }
    }
}
