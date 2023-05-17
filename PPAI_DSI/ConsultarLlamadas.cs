using PPAI_DSI.Entidades;
using System.Reflection.Metadata;

namespace PPAI_DSI
{
    public partial class ConsultarLlamadas : Form
    {
        public ConsultarLlamadas()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultarLlamadas_Click(object sender, EventArgs e)
        {
            boxHideLlamadasEncontradas.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ConsultarLlamadas_Load(object sender, EventArgs e)
        {
            boxHideLlamadasEncontradas.Hide();
            boxDatosLlamada.Hide();

        }

        private void txtCallDesde_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtCallDesde_Click(object sender, EventArgs e)
        {

        }
        private void txtCallHasta_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void btnSeleccionarLlamada_Click(object sender, EventArgs e)
        {
            boxDatosLlamada.Show();
        }
    }
}