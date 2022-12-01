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
    public partial class frm_AsignarProfesorAMateria : Form
    {
        MateriaDAO materiaDAO;
        ProfesorDAO profesorDAO;
        MateriaYProfesorDAO materiaYProfesorDAO;

        Profesor? profesorSeleccionado;
        Materia? materiaSeleccionada;
        public frm_AsignarProfesorAMateria()
        {
            InitializeComponent();
            materiaDAO = new MateriaDAO();
            profesorDAO = new ProfesorDAO();
            materiaYProfesorDAO = new MateriaYProfesorDAO();
        }

        private void frm_AsignarProfesorAMateria_Load(object sender, EventArgs e)
        {
            try
            {
                lst_ListadoDeMaterias.DataSource = materiaDAO.GetAllMaterias();
                lst_ListadoDeProfesoresDisponibles.DataSource = profesorDAO.GetProfesores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lst_ListadoDeMaterias_DoubleClick(object sender, EventArgs e)
        {
            materiaSeleccionada = lst_ListadoDeMaterias.SelectedItem as Materia;

            if(materiaSeleccionada is not null)
            {
                txt_MateriaSeleccionada.Text = materiaSeleccionada.Nombre;
            }
            else
            {
                MessageBox.Show("Se produjo un error al seleccionar la materia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lst_ListadoDeProfesoresDisponibles_DoubleClick(object sender, EventArgs e)
        {
            profesorSeleccionado = lst_ListadoDeProfesoresDisponibles.SelectedItem as Profesor;

            if (profesorSeleccionado is not null)
            {
                txt_ProfesorSeleccionado.Text = profesorSeleccionado.Nombre + " " + profesorSeleccionado.Apellido;
            }
            else
            {
                MessageBox.Show("Se produjo un error al seleccionar el profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Asignar_Click(object sender, EventArgs e)
        {
            if(materiaSeleccionada is not null && profesorSeleccionado is not null)
            {
                if(!string.IsNullOrEmpty(txt_MateriaSeleccionada.Text) && !string.IsNullOrEmpty(txt_ProfesorSeleccionado.Text))
                {
                    try
                    {
                        materiaYProfesorDAO.AsignarProfesorAMateria(materiaSeleccionada, profesorSeleccionado);
                        MessageBox.Show("Profesor asignado correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una materia y un profesor","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Se ha producido un error... vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txt_MateriaSeleccionada.Text = string.Empty;
            txt_ProfesorSeleccionado.Text = string.Empty;
        }
    }
}
