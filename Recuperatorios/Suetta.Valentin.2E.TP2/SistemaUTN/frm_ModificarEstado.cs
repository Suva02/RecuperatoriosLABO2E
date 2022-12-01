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
    public partial class frm_ModificarEstado : Form
    {
        Inscripción inscripcionAModificar;
        InscripcionDAO inscripcionDAO;
        public frm_ModificarEstado(Inscripción inscripcion)
        {
            InitializeComponent();
            inscripcionAModificar = inscripcion;
            inscripcionDAO = new InscripcionDAO();
        }

        private void btn_ModificarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_NuevaCondicion.Text))
                {
                    if(txt_NuevaCondicion.Text == "Libre" || txt_NuevaCondicion.Text == "libre")
                    {
                        inscripcionAModificar.CondicionAlumno = ECondicion.Libre;
                        inscripcionDAO.ModificarInscripcion(inscripcionAModificar.Id, inscripcionAModificar);
                        MessageBox.Show("La condicion se modifico correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_NuevaCondicion.Text = string.Empty;
                        this.Close();
                    }
                    else
                    {
                        if (txt_NuevaCondicion.Text == "Regular" || txt_NuevaCondicion.Text == "regular")
                        {
                            inscripcionAModificar.CondicionAlumno = ECondicion.Regular;
                            inscripcionDAO.ModificarInscripcion(inscripcionAModificar.Id, inscripcionAModificar);
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
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
