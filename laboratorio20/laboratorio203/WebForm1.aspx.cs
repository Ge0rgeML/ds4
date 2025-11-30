using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Web.UI;

namespace laboratorio203
{
    public partial class WebForm1 : Page
    {
        private readonly string connectionString = @"Server=.\sqlexpress;Database=productos;Trusted_Connection=True;";
        private bool nuevo;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                EstadoInicial();
            }
        }

        private void EstadoInicial()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;
            btnBuscar.Enabled = true;
            tstId.Enabled = true;

            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";

            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;

            lblError.Text = "";
            lblMessage.Text = "";
            nuevo = false;
        }

        private void EstadoEditando()
        {
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = true;
            btnBuscar.Enabled = false;
            tstId.Enabled = false;

            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = true;
            lblError.Text = "";
            lblMessage.Text = "";
            nuevo = false;
        }

        private void EstadoNuevo()
        {
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = false;
            btnBuscar.Enabled = false;
            tstId.Enabled = false;

            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";

            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = true;
            txtNombre.Focus();

            lblError.Text = "";
            lblMessage.Text = "";
            nuevo = true;
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            lblMessage.Text = "";

            if (!int.TryParse(tstId.Text?.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out int id))
            {
                lblError.Text = "Id inválido. Ingrese un entero.";
                return;
            }

            const string sql = "SELECT id, nombre, precio, stock FROM LAPTOPS WHERE id = @id";
            try
            {
                using (var con = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        if (reader.Read())
                        {
                            txtId.Text = reader.GetInt32(0).ToString(CultureInfo.InvariantCulture);
                            txtNombre.Text = reader.IsDBNull(1) ? "" : reader.GetString(1);
                            txtPrecio.Text = reader.IsDBNull(2) ? "" : reader.GetDecimal(2).ToString(CultureInfo.InvariantCulture);
                            txtStock.Text = reader.IsDBNull(3) ? "" : reader.GetInt32(3).ToString(CultureInfo.InvariantCulture);

                            EstadoEditando();
                        }
                        else
                        {
                            lblError.Text = "Ningún registro encontrado con el Id proporcionado.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "Error al buscar: " + ex.Message;
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            EstadoNuevo();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            lblMessage.Text = "";

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                lblError.Text = "Nombre es obligatorio.";
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text?.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out decimal precio))
            {
                lblError.Text = "Precio inválido.";
                return;
            }

            if (!int.TryParse(txtStock.Text?.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out int stock))
            {
                lblError.Text = "Stock inválido.";
                return;
            }

            if (nuevo)
            {
                const string sqlInsert = "INSERT INTO LAPTOPS (nombre, precio, stock) VALUES (@nombre, @precio, @stock)";
                try
                {
                    using (var con = new SqlConnection(connectionString))
                    using (var cmd = new SqlCommand(sqlInsert, con))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@precio", precio);
                        cmd.Parameters.AddWithValue("@stock", stock);

                        con.Open();
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0) lblMessage.Text = "Registro ingresado correctamente.";
                        else lblError.Text = "No se insertó el registro.";
                    }
                }
                catch (Exception ex)
                {
                    lblError.Text = "Error al insertar: " + ex.Message;
                }
            }
            else
            {
                if (!int.TryParse(txtId.Text, out int id))
                {
                    lblError.Text = "Id inválido para actualizar.";
                    return;
                }

                const string sqlUpdate = "UPDATE LAPTOPS SET nombre=@nombre, precio=@precio, stock=@stock WHERE id=@id";
                try
                {
                    using (var con = new SqlConnection(connectionString))
                    using (var cmd = new SqlCommand(sqlUpdate, con))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@precio", precio);
                        cmd.Parameters.AddWithValue("@stock", stock);
                        cmd.Parameters.AddWithValue("@id", id);

                        con.Open();
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0) lblMessage.Text = "Registro actualizado correctamente.";
                        else lblError.Text = "No se encontró el registro para actualizar.";
                    }
                }
                catch (Exception ex)
                {
                    lblError.Text = "Error al actualizar: " + ex.Message;
                }
            }

            EstadoInicial();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            lblMessage.Text = "";

            if (!int.TryParse(txtId.Text, out int id))
            {
                lblError.Text = "Id inválido para eliminar.";
                return;
            }

            const string sqlDelete = "DELETE FROM LAPTOPS WHERE id = @id";
            try
            {
                using (var con = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(sqlDelete, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0) lblMessage.Text = "Registro eliminado correctamente.";
                    else lblError.Text = "No se encontró el registro para eliminar.";
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "Error al eliminar: " + ex.Message;
            }

            EstadoInicial();
        }
    }
}