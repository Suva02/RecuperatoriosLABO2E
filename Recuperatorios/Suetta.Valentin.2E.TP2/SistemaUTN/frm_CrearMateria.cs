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
    public partial class frm_CrearMateria : Form
    {
        MateriaDAO materiaDAO;
        MateriaCorrelativaDAO materiaCorrelativaDAO;
        CorrelatividadesDAO correlatividadesDAO;

        public frm_CrearMateria()
        {
            InitializeComponent();
            materiaDAO = new MateriaDAO();
            materiaCorrelativaDAO = new MateriaCorrelativaDAO();
            correlatividadesDAO = new CorrelatividadesDAO();
        }

        private void btn_CrearMateria_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_NombreMateria.Text) && string.IsNullOrEmpty(txt_CuatrimestreMateria.Text))
            {
                MessageBox.Show("Debe ingresar el nombre y el cuatrimestre de la materia", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    var materiaACrear = new Materia(txt_NombreMateria.Text, txt_CuatrimestreMateria.Text);
                    //Hacer un metodo que me devuelva 1 si la materia que se quiere crear ya existe o 0 si no existe
                    materiaDAO.CrearMateria(materiaACrear);
                    MessageBox.Show("La materia se creo correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!string.IsNullOrEmpty(txt_MateriaCorrelativa.Text) && !string.IsNullOrEmpty(txt_CuatrimestreMateriaCorrelativa.Text))
                    {
                        var materiaCorrelativa = new MateriaCorrelativa(txt_MateriaCorrelativa.Text, txt_CuatrimestreMateriaCorrelativa.Text);
                        //Hacer un metodo que me devuelva 1 si la correlativa que se quiere crear ya existe o 0 si no existe
                        materiaCorrelativaDAO.CrearMateriaCorrelativa(materiaCorrelativa);
                        MessageBox.Show("La correlativa se creo correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        var materiaEncontrada = materiaDAO.GetMateria(materiaACrear.Nombre, materiaACrear.Cuatrimestre);
                        var materiaCorrelativaEncontrada = materiaCorrelativaDAO.GetMateriaCorrelativa(materiaCorrelativa.Nombre, materiaCorrelativa.Cuatrimestre);

                        correlatividadesDAO.GuardarMateriaConCorrelativa(materiaEncontrada, materiaCorrelativaEncontrada);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            txt_NombreMateria.Text = string.Empty;
            txt_CuatrimestreMateria.Text = string.Empty;
            txt_MateriaCorrelativa.Text = string.Empty;
            txt_CuatrimestreMateriaCorrelativa.Text = string.Empty;
        }
    }
}
