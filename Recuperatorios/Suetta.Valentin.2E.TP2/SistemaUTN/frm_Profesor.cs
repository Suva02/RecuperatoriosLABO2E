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
    public partial class frm_Profesor : Form
    {
        frm_OpcionesAlCrearExamen formOpcionesCrearExamen;
        frm_IngresarNota formParaIngresarNotas;
        frm_OpcionesParaIngresarNotas formOpcionesIngresarNotas;
        frm_MateriasYAlumnos formMateriasYAlumnosACargo;

        Profesor profesorActual;
        public frm_Profesor(Profesor profesor)
        {
            InitializeComponent();
            profesorActual = profesor;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CrearExamen_Click(object sender, EventArgs e)
        {
            formOpcionesCrearExamen = new frm_OpcionesAlCrearExamen(profesorActual);
            formOpcionesCrearExamen.ShowDialog();
        }

        private void btn_PonerNotas_Click(object sender, EventArgs e)
        {
            formOpcionesIngresarNotas = new frm_OpcionesParaIngresarNotas(profesorActual);
            formOpcionesIngresarNotas.ShowDialog();
        }

        private void btn_MateriasYAlumnos_Click(object sender, EventArgs e)
        {
            formMateriasYAlumnosACargo = new frm_MateriasYAlumnos(profesorActual);
            formMateriasYAlumnosACargo.ShowDialog();
        }
    }
}
