using System;
using System.Text;
using System.Web.UI;

namespace laboratorio202
{
    public partial class WebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            litMatrix.Text = "";

            if (!int.TryParse(txtN.Text?.Trim(), out int n) || n <= 0)
            {
                lblError.Text = "Ingrese un número entero positivo para N.";
                return;
            }

            const int MAX_N = 100;
            if (n > MAX_N)
            {
                lblError.Text = $"N demasiado grande. El máximo permitido es {MAX_N}.";
                return;
            }

            var sb = new StringBuilder();
            sb.AppendFormat("<table class='matrix-table' border='1' cellpadding='0' cellspacing='0' style='border-collapse:collapse;'>");

            for (int i = 0; i < n; i++)
            {
                sb.Append("<tr>");
                for (int j = 0; j < n; j++)
                {
                    string valor = (j == n - i - 1) ? "1" : "0";
                    sb.AppendFormat("<td style='padding:4px; text-align:center; width:40px;'>{0}</td>", valor);
                }
                sb.Append("</tr>");
            }

            sb.Append("</table>");
            litMatrix.Text = sb.ToString();
        }
    }
}