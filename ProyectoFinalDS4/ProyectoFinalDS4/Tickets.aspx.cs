using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net.Sockets;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ProyectoFinalDS4
{
    public class Ticket
    {
        public int IdTicket { get; set; }
        public string NombreSolicitante { get; set; }
        public string Asunto { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        public string Prioridad { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Imagen { get; set; }

        
        public Ticket()
        {
        }
    }
    public class TicketDAL
    {
        private string cadenaConexion;

        public TicketDAL()
        {
            cadenaConexion = ConfigurationManager
                .ConnectionStrings["ConexionTickets"]
                .ConnectionString;
        }
        public void EliminarTicket(int idTicket)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                string sql = "DELETE FROM Tickets WHERE IdTicket = @Id";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Id", idTicket);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void InsertarTicket(Ticket ticket)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                string sql = @"INSERT INTO Tickets
                (NombreSolicitante, Asunto, Categoria, Descripcion, Prioridad, Estado, Imagen)
                VALUES
                (@Nombre, @Asunto, @Categoria, @Descripcion, @Prioridad, @Estado, @Imagen)";

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@Nombre", ticket.NombreSolicitante);
                cmd.Parameters.AddWithValue("@Asunto", ticket.Asunto);
                cmd.Parameters.AddWithValue("@Categoria", ticket.Categoria);
                cmd.Parameters.AddWithValue("@Descripcion", ticket.Descripcion);
                cmd.Parameters.AddWithValue("@Prioridad", ticket.Prioridad);
                cmd.Parameters.AddWithValue("@Estado", ticket.Estado);
                cmd.Parameters.AddWithValue("@Imagen", ticket.Imagen ?? (object)DBNull.Value);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Ticket> ListarTickets()
        {
            List<Ticket> lista = new List<Ticket>();

            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                string sql = "SELECT * FROM Tickets ORDER BY FechaCreacion DESC";
                SqlCommand cmd = new SqlCommand(sql, con);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Ticket t = new Ticket();
                    t.IdTicket = Convert.ToInt32(dr["IdTicket"]);
                    t.NombreSolicitante = dr["NombreSolicitante"].ToString();
                    t.Asunto = dr["Asunto"].ToString();
                    t.Categoria = dr["Categoria"].ToString();
                    t.Descripcion = dr["Descripcion"].ToString();
                    t.Prioridad = dr["Prioridad"].ToString();
                    t.Estado = dr["Estado"].ToString();
                    t.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
                    t.Imagen = dr["Imagen"] == DBNull.Value ? null : dr["Imagen"].ToString();

                    lista.Add(t);
                }
            }

            return lista;
        }

        public Ticket ObtenerTicketPorId(int idTicket)
        {
            Ticket t = null;

            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                string sql = "SELECT * FROM Tickets WHERE IdTicket = @Id";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Id", idTicket);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    t = new Ticket();
                    t.IdTicket = Convert.ToInt32(dr["IdTicket"]);
                    t.NombreSolicitante = dr["NombreSolicitante"].ToString();
                    t.Asunto = dr["Asunto"].ToString();
                    t.Categoria = dr["Categoria"].ToString();
                    t.Descripcion = dr["Descripcion"].ToString();
                    t.Prioridad = dr["Prioridad"].ToString();
                    t.Estado = dr["Estado"].ToString();
                    t.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
                    t.Imagen = dr["Imagen"] == DBNull.Value ? null : dr["Imagen"].ToString();
                }
            }

            return t;
        }

        public void ActualizarTicket(Ticket ticket)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                string sql = @"UPDATE Tickets SET
                NombreSolicitante = @Nombre,
                Asunto = @Asunto,
                Categoria = @Categoria,
                Descripcion = @Descripcion,
                Prioridad = @Prioridad,
                Estado = @Estado,
                Imagen = @Imagen
                WHERE IdTicket = @Id";

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@Nombre", ticket.NombreSolicitante);
                cmd.Parameters.AddWithValue("@Asunto", ticket.Asunto);
                cmd.Parameters.AddWithValue("@Categoria", ticket.Categoria);
                cmd.Parameters.AddWithValue("@Descripcion", ticket.Descripcion);
                cmd.Parameters.AddWithValue("@Prioridad", ticket.Prioridad);
                cmd.Parameters.AddWithValue("@Estado", ticket.Estado);
                cmd.Parameters.AddWithValue("@Imagen", ticket.Imagen ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Id", ticket.IdTicket);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public int ContarTickets()
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Tickets", con);
                con.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public int ContarPorEstado(string estado)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Tickets WHERE Estado = @Estado", con);
                cmd.Parameters.AddWithValue("@Estado", estado);
                con.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
        public DataTable ResumenPorEstado()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                string sql = @"SELECT Estado, COUNT(*) AS Cantidad
                       FROM Tickets
                       GROUP BY Estado";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
            }

            return dt;
        }
        
    }


    public partial class Tickets : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTickets();
            }
        }

        protected void btnNuevoTicket_Click(object sender, EventArgs e)
        {
            pnlFormulario.Visible = true;
            hfIdTicket.Value = "";
        }
        protected void gvTickets_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            int idTicket = Convert.ToInt32(gvTickets.DataKeys[index].Value);

            if (e.CommandName == "Editar")
            {
                CargarTicketEnFormulario(idTicket);
            }
            else if (e.CommandName == "Eliminar")
            {
                TicketDAL dal = new TicketDAL();
                dal.EliminarTicket(idTicket);
                CargarTickets();
            }
        }

        private void CargarTicketEnFormulario(int idTicket)
        {
            TicketDAL dal = new TicketDAL();
            Ticket t = dal.ObtenerTicketPorId(idTicket);

            if (t != null)
            {
                hfIdTicket.Value = t.IdTicket.ToString();
                txtNombre.Text = t.NombreSolicitante;
                txtAsunto.Text = t.Asunto;
                txtDescripcion.Text = t.Descripcion;

                
                if (ddlCategoria.Items.FindByValue(t.Categoria) != null)
                    ddlCategoria.SelectedValue = t.Categoria;
                else
                    ddlCategoria.SelectedIndex = 0;

                
                if (ddlPrioridad.Items.FindByValue(t.Prioridad) != null)
                    ddlPrioridad.SelectedValue = t.Prioridad;
                else
                    ddlPrioridad.SelectedIndex = 0;

                
                if (ddlEstado.Items.FindByValue(t.Estado) != null)
                    ddlEstado.SelectedValue = t.Estado;
                else
                    ddlEstado.SelectedIndex = 0;

                
                if (!string.IsNullOrEmpty(t.Imagen))
                {
                    imgTicket.ImageUrl = t.Imagen;
                    imgTicket.Visible = true;
                }
                else
                {
                    imgTicket.Visible = false;
                }

                pnlFormulario.Visible = true;
            }
        }


        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Ticket t = new Ticket();

            t.NombreSolicitante = txtNombre.Text;
            t.Asunto = txtAsunto.Text;
            t.Categoria = ddlCategoria.SelectedValue;
            t.Descripcion = txtDescripcion.Text;
            t.Prioridad = ddlPrioridad.SelectedValue;
            t.Estado = ddlEstado.SelectedValue;

            TicketDAL dal = new TicketDAL();

            
            if (fuImagen.HasFile)
            {
                string nombreArchivo = Guid.NewGuid().ToString() +
                    System.IO.Path.GetExtension(fuImagen.FileName);

                string rutaServidor = Server.MapPath("~/ImagenesTickets/" + nombreArchivo);
                fuImagen.SaveAs(rutaServidor);

                
                t.Imagen = "~/ImagenesTickets/" + nombreArchivo;
            }
            else
            {
                
                if (!string.IsNullOrEmpty(hfIdTicket.Value))
                {
                    int id = Convert.ToInt32(hfIdTicket.Value);
                    Ticket ticketActual = dal.ObtenerTicketPorId(id);
                    t.Imagen = ticketActual.Imagen;
                }
            }

            if (string.IsNullOrEmpty(hfIdTicket.Value))
            {
                dal.InsertarTicket(t);
            }
            else
            {
                t.IdTicket = Convert.ToInt32(hfIdTicket.Value);
                dal.ActualizarTicket(t);
            }

            LimpiarFormulario();
            pnlFormulario.Visible = false;
            CargarTickets();
        }


        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            txtAsunto.Text = "";
            txtDescripcion.Text = "";
            ddlCategoria.SelectedIndex = 0;
            ddlPrioridad.SelectedIndex = 0;
        }

        private void CargarTickets()
        {
            TicketDAL dal = new TicketDAL();
            List<Ticket> lista = dal.ListarTickets();

            gvTickets.DataSource = lista;
            gvTickets.DataBind();
        }
        
    }
}