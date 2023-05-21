using PPAI_DSI.Entidades;
using System.Numerics;
using System.Reflection.Metadata;
using System.Windows.Forms;

namespace PPAI_DSI
{
    public partial class VentanaConsultarLlamadas : Form
    {
        // declarar atributo gestor
        private controladorConsultasEncuestas gestor;
        // atributo llamadas que es una lista de llamadas
        private List<Llamada> llamadasFiltradas;
        private Llamada llamadaSeleccionada;

        public VentanaConsultarLlamadas()
        {
            InitializeComponent();
            gestor = new controladorConsultasEncuestas(this);
            llamadasFiltradas = new List<Llamada>();


        }

        //metodo llamado "solicitarPeriodoLlamada()" que muestra en la pantalla "ConsultarLlamadas" los campos para ingresar el periodo de la llamada
        public void solicitarPeriodoLlamada()
        {
            boxConsultaLlamada.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultarLlamadas_Click(object sender, EventArgs e)
        {
            gestor.fechaInicioYFinSeleccionadas(fechaDesde.Value, fechaHasta.Value);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        //metodo "pedirSeleccionLlamada(Llamada llamadas)" que actualize el dataGrindLlamadas_CellContentClick con los datos de la llamadas pasada por parametro
        public void pedirSeleccionLlamada(List<Llamada> llamadas)
        {
            llamadasFiltradas = llamadas;
            dataGrindLlamadas.ClearSelection();
            foreach (var llamada in llamadasFiltradas)
            {
                DataGridViewRow fila = new DataGridViewRow();

                // Agrega las celdas a la fila con los valores correspondientes de la llamada
                DataGridViewCell celda1 = new DataGridViewTextBoxCell();
                celda1.Value = llamada.cliente._dniCliente.ToString(); // Asigna el valor de la primera propiedad de la llamada
                fila.Cells.Add(celda1);

                DataGridViewCell celda2 = new DataGridViewTextBoxCell();
                celda2.Value = llamada._cliente._nombreCompletoCliente; // Asigna el valor de la segunda propiedad de la llamada
                fila.Cells.Add(celda2);

                DataGridViewCell celda3 = new DataGridViewTextBoxCell();
                celda3.Value = llamada._duracion; // Asigna el valor de la segunda propiedad de la llamada
                fila.Cells.Add(celda3);

                // Agrega la fila al DataGridView
                dataGrindLlamadas.Rows.Add(fila);
            }
            boxHideLlamadasEncontradas.Show();

        }

        private void ConsultarLlamadas_Load(object sender, EventArgs e)
        {

            boxHideLlamadasEncontradas.Hide();
            boxDatosLlamada.Hide();
            boxConsultaLlamada.Hide();
            gestor.consultarEncuesta();
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
            gestor.llamadaSeleccionada(llamadaSeleccionada);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void dataGrindLlamadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // metodo  pedirSeleccionGeneracionCsvOImprimir() de tipo void
        public void pedirSeleccionGeneracionCsvOImprimir()
        {
            boxDatosLlamada.Show();
        }
    }
}