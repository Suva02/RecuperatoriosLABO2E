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
        //Formularios
        frm_IngresarNota formIngresarNota;
        frm_IngresarNotaCorrelativa formIngresarNotaCorrelativa;
        frm_Login formLogin;

        //Profesor actual
        Profesor profesorActual;

        public frm_OpcionesParaIngresarNotas(Profesor profesor, frm_Login login)
        {
            InitializeComponent();
            profesorActual = profesor;
            formLogin = login;
        }

        private void btn_IngresarNotasMaterias_Click(object sender, EventArgs e)
        {
            formIngresarNota = new frm_IngresarNota(profesorActual,formLogin);
            formIngresarNota.ShowDialog();
        }

        private void btn_IngresarNotasCorrelativas_Click(object sender, EventArgs e)
        {
            formIngresarNotaCorrelativa = new frm_IngresarNotaCorrelativa(profesorActual,formLogin);
            formIngresarNotaCorrelativa.ShowDialog();
        }
    }
}
