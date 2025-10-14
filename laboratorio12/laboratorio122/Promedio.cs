using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio122
{
    internal class Promedio
    {
        public void CalcularPromedio(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4)
        {
            try
            {
                
                decimal nota1 = Convert.ToDecimal(textBox1.Text);
                decimal nota2 = Convert.ToDecimal(textBox2.Text);
                decimal nota3 = Convert.ToDecimal(textBox3.Text);

                
                decimal promedio = (nota1 + nota2 + nota3) / 3;

                
                textBox4.Text = promedio.ToString("F2");
            }
            catch (FormatException)
            {
                
                MessageBox.Show("Por favor, ingresa valores numéricos en las notas.");
            }
        }
    }
}
