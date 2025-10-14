using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio123
{
    class Calculos
    {
        public void CalcularSemiperimetro(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4)
        {
            try
            {
                
                decimal lado1 = Convert.ToDecimal(textBox1.Text);
                decimal lado2 = Convert.ToDecimal(textBox2.Text);
                decimal lado3 = Convert.ToDecimal(textBox3.Text);

                
                decimal semiperimetro = (lado1 + lado2 + lado3) / 2;

                textBox4.Text = semiperimetro.ToString("F2"); 
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos para los lados.");
            }
        }

        public void CalcularArea(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4, TextBox textBox5)
        {
            try
            {
                decimal lado1 = Convert.ToDecimal(textBox1.Text);
                decimal lado2 = Convert.ToDecimal(textBox2.Text);
                decimal lado3 = Convert.ToDecimal(textBox3.Text);

                decimal semiperimetro = Convert.ToDecimal(textBox4.Text);

                decimal area = (decimal)Math.Sqrt((double)(semiperimetro * (semiperimetro - lado1) * (semiperimetro - lado2) * (semiperimetro - lado3)));

                textBox5.Text = area.ToString("F2"); 
            }
            catch (FormatException)
            {
                MessageBox.Show("Asegúrate de ingresar números válidos para los lados y el semiperímetro.");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Los valores ingresados no forman un triángulo válido.");
            }
        }
    }
}
