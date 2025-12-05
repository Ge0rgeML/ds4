using System;
using System.Data.SqlClient;

namespace parcial3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            string conexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=PasaportesDB;Integrated Security=True";
            string query = "INSERT INTO Solicitantes (NombreCompleto, Cedula, Correo, Telefono, FechaNacimiento) " +
                           "VALUES (@Nombre, @Cedula, @Correo, @Telefono, @Fecha)";
            SqlConnection con = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@Cedula", txtCedula.Text);
            cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);
            cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
            cmd.Parameters.AddWithValue("@Fecha", txtFecha.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
