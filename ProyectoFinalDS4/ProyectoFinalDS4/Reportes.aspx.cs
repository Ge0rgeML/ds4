using System;
using System.Data;
using System.Web.UI;

namespace ProyectoFinalDS4
{
    public partial class Reportes : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarReportes();
            }
        }

        private void CargarReportes()
        {
            TicketDAL dal = new TicketDAL();

            lblTotal.Text = dal.ContarTickets().ToString();
            lblAbiertos.Text = dal.ContarPorEstado("Abierto").ToString();
            lblEnProceso.Text = dal.ContarPorEstado("En Proceso").ToString();
            lblResueltos.Text = dal.ContarPorEstado("Resuelto").ToString();

        }
    }
}
