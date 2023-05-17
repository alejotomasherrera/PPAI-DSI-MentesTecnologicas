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
            // Llamada llamada = new Llamada();
            // EncuestaDisponible ventana_llamadasDisponibles = new EncuestaDisponible();
            // ventana_llamadasDisponibles.Show();
            // this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ConsultarLlamadas_Load(object sender, EventArgs e)
        {
            txtCallDesde.Text = "DD/MM/AAAA";
            txtCallHasta.Text = "DD/MM/AAAA";
        }

        private void txtCallDesde_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtCallDesde_Click(object sender, EventArgs e)
        {
            txtCallDesde.Text = "";
        }
        private void txtCallHasta_Click(object sender, EventArgs e)
        {
            txtCallHasta.Text = "";
        }
    }
}