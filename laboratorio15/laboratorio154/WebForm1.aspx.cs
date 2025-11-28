using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace laboratorio154
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double value1, value2;

            var s1 = (TextBox1?.Text ?? string.Empty).Trim();
            var s2 = (TextBox2?.Text ?? string.Empty).Trim();

            var style = NumberStyles.Float | NumberStyles.AllowThousands;
            var culture = CultureInfo.CurrentCulture;

            if (double.TryParse(s1, style, culture, out value1) &&
                double.TryParse(s2, style, culture, out value2))
            {
                var sum = value1 + value2;
                Label1.Text = sum.ToString(culture);
            }
            else
            {
                Label1.Text = "Entrada no válida";
            }
        }
    }
}