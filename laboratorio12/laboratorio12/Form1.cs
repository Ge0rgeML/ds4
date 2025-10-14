namespace laboratorio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                double velocidad = Convert.ToDouble(tb_velocidad.Text);
                double tiempo = Convert.ToDouble(tb_tiempo.Text);

                DistRecorrida calculo = new DistRecorrida(velocidad, tiempo);

                double distancia = calculo.ObtenerDistancia();

                tb_resultado.Text = $"{distancia} km";
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa valores numericos validos");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tb_velocidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            tb_velocidad.Text = "";
            tb_tiempo.Text = "";
            tb_resultado.Text = "";
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
