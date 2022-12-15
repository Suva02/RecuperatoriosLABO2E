using Entidades.Agrupacion;

namespace SistemaUTN
{
    public partial class frm_CrearMateria : Form
    {
        //Materias a crear
        Materia materiaACrear;
        MateriaCorrelativa correlativaACrear;

        //Correlatividades
        Correlatividades correlatividades;

        //Formularios
        frm_Login formLogin;

        public frm_CrearMateria(frm_Login login)
        {
            InitializeComponent();
            formLogin = login;
        }

        private void btn_CrearMateria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_NombreMateria.Text) && string.IsNullOrEmpty(txt_CuatrimestreMateria.Text))
            {
                MessageBox.Show("Debe ingresar el nombre y el cuatrimestre de la materia", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                materiaACrear = new Materia(txt_NombreMateria.Text, txt_CuatrimestreMateria.Text);
                formLogin.MateriasCreadas.Add(materiaACrear);
                MessageBox.Show("La materia se creo correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (!string.IsNullOrEmpty(txt_MateriaCorrelativa.Text) && !string.IsNullOrEmpty(txt_CuatrimestreMateriaCorrelativa.Text))
                {
                    correlativaACrear = new MateriaCorrelativa(txt_MateriaCorrelativa.Text, txt_CuatrimestreMateriaCorrelativa.Text);
                    formLogin.CorrelativasCreadas.Add(correlativaACrear);
                    MessageBox.Show("La correlativa se creo correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (materiaACrear is not null && correlativaACrear is not null)
                    {
                        correlatividades = new Correlatividades(materiaACrear, correlativaACrear);
                        formLogin.Correlatividades.Add(correlatividades.Materia,correlatividades.Correlativa);
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al guardar la materia con su correlativa... por favor vuelta a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
