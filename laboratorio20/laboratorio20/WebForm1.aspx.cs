using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace laboratorio20
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            ListBox1.Items.Clear();

           
            string texto = TextBox1.Text?.Trim();
            if (string.IsNullOrEmpty(texto))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Ingrese un número.');", true);
                return;
            }

            if (!int.TryParse(texto, out int numero))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Número inválido. Ingrese un entero.');", true);
                return;
            }

            
            for (int i = 1; i <= 25; i++)
            {
                ListBox1.Items.Add($"{numero} x {i} = {numero * i}");
            }
        }
    }
}