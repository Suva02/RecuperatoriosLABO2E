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
    public partial class frm_ModificarEstado : Form
    {
        //Inscripcion seleccionada
        Inscripción inscripcionAModificar;
        public frm_ModificarEstado(Inscripción inscripcion)
        {
            InitializeComponent();
            inscripcionAModificar = inscripcion;

        }

        private void btn_ModificarEstado_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_NuevaCondicion.Text))
            {
                if (txt_NuevaCondicion.Text == "Libre" || txt_NuevaCondicion.Text == "libre")
                {
                    inscripcionAModificar.Condicion = ECondicion.Libre;
                    MessageBox.Show("La condicion se modifico correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_NuevaCondicion.Text = string.Empty;
                    this.Close();
                }
                else
                {
                    if (txt_NuevaCondicion.Text == "Regular" || txt_NuevaCondicion.Text == "regular")
                    {
                        inscripcionAModificar.Condicion = ECondicion.Regular;
                        MessageBox.Show("La condicion se modifico correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_NuevaCondicion.Text = string.Empty;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese una condicion valida porfavor (Libre-Regular)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar la condicion del alumno!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
