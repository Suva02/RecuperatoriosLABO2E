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
    public partial class frm_OpcionesParaIngresarNotas : Form
    {
        frm_IngresarNota formIngresarNota;
        frm_IngresarNotaCorrelativa formIngresarNotaCorrelativa;

        Profesor profesorActual;
        public frm_OpcionesParaIngresarNotas(Profesor profesor)
        {
            InitializeComponent();
            profesorActual = profesor;
        }

        private void btn_IngresarNotasMaterias_Click(object sender, EventArgs e)
        {
            formIngresarNota = new frm_IngresarNota(profesorActual);
            formIngresarNota.ShowDialog();
        }

        private void btn_IngresarNotasCorrelativas_Click(object sender, EventArgs e)
        {
            formIngresarNotaCorrelativa = new frm_IngresarNotaCorrelativa(profesorActual);
            formIngresarNotaCorrelativa.ShowDialog();
        }
    }
}
