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
    public partial class frm_OpcionesAlCrearExamen : Form
    {
        frm_CrearExamenMateria formCrearExamenMateria;
        frm_CrearExamenCorrelativa formCrearExamenCorrelativa;

        Profesor profesorActual;
        public frm_OpcionesAlCrearExamen(Profesor profesor)
        {
            InitializeComponent();
            profesorActual = profesor;
        }

        private void btn_CrearExamenMateria_Click(object sender, EventArgs e)
        {
            formCrearExamenMateria = new frm_CrearExamenMateria(profesorActual);
            formCrearExamenMateria.ShowDialog();
        }

        private void btn_CrearExamenCorrelativa_Click(object sender, EventArgs e)
        {
            formCrearExamenCorrelativa = new frm_CrearExamenCorrelativa(profesorActual);
            formCrearExamenCorrelativa.ShowDialog();
        }
    }
}
