namespace laboratorio123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculos calculos = new Calculos();

            calculos.CalcularSemiperimetro(textBox1, textBox2, textBox3, textBox4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculos calculos = new Calculos();

            calculos.CalcularArea(textBox1, textBox2, textBox3, textBox4, textBox5);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
