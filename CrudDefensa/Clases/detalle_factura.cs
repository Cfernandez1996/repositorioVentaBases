using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudDefensa.Clases
{
    public partial class detalle_factura : Form
    {
        public detalle_factura()
        {
            InitializeComponent();
            CargarDatosDetalle();
        }
        string cadenaConexion = "Host=proyecto-aws.c2htk24uoh9j.us-east-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=bases123456789;Database=Proyecto";

        private void CargarDatosDetalle()
        {
            // Cadena de conexión
            string cadenaConexion = "Host=proyecto-aws.c2htk24uoh9j.us-east-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=bases123456789;Database=postgres";

            using (NpgsqlConnection conexion = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    // Abre la conexión
                    conexion.Open();

                    // Consulta SQL
                    string consulta = "SELECT * FROM detalle_factura";

                    // Crear un adaptador de datos
                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(consulta, conexion);

                    // Crear un DataTable para almacenar los datos
                    DataTable dt = new DataTable();

                    // Llenar el DataTable con los datos de la consulta
                    dataAdapter.Fill(dt);

                    // Asignar el DataTable como la fuente de datos del DataGridView
                    bdDetalleFactura.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string cadenaConexion = "Host=proyecto-aws.c2htk24uoh9j.us-east-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=bases123456789;Database=Proyecto";

            using (NpgsqlConnection conexion = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    // Abre la conexión
                    conexion.Open();

                    // Crear un comando
                    using (NpgsqlCommand cmd = new NpgsqlCommand("agregar_detalle_actualizar_total", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Asignar valores a los parámetros del procedimiento almacenado
                        cmd.Parameters.AddWithValue("p_iddetalle", Convert.ToInt32(textIdDetalle.Text));
                        cmd.Parameters.AddWithValue("p_idfactura", Convert.ToInt32(textIDFacura.Text));
                        cmd.Parameters.AddWithValue("p_idproducto", Convert.ToString(textIDProducto.Text));
                        cmd.Parameters.AddWithValue("p_cantidad", Convert.ToInt32(textFacCantidad.Text));
                        cmd.Parameters.AddWithValue("p_precio", Convert.ToDecimal(textFacPrecio.Text));

                        // Ejecutar el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Detalle de factura guardado y total actualizado exitosamente.");

                        // Recargar los datos en el DataGridView para reflejar los cambios
                        bdDetalleFacturaLoad();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos: " + ex.Message);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Cadena de conexión
            string cadenaConexion = "Host=proyecto-aws.c2htk24uoh9j.us-east-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=bases123456789;Database=postgres";

            using (NpgsqlConnection conexion = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    // Abre la conexión
                    conexion.Open();
                    int nuevaiddet = Convert.ToInt32(bdDetalleFactura.CurrentRow.Cells["iddetalle"].Value);
                    // Crear un comando
                    using (NpgsqlCommand cmd = new NpgsqlCommand("actualizar_detalle_factura", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Asignar valores a los parámetros del procedimiento almacenado
                        cmd.Parameters.AddWithValue("p_iddetalle", nuevaiddet);
                        cmd.Parameters.AddWithValue("p_idfactura", Convert.ToInt32(textIDFacura.Text));
                        cmd.Parameters.AddWithValue("p_idproducto", Convert.ToInt32(textIDProducto.Text));
                        cmd.Parameters.AddWithValue("p_cantidad", Convert.ToInt32(textFacCantidad.Text));
                        cmd.Parameters.AddWithValue("p_precio", Convert.ToDecimal(textFacPrecio.Text));

                        // Ejecutar el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Detalle de factura modificado exitosamente.");

                        // Recargar los datos en el DataGridView para reflejar los cambios
                        CargarDatosDetalle();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar los datos: " + ex.Message);
                }
            }
        }

        private void textIDFactura_TextChanged(object sender, EventArgs e)
        {

        }

        private void textIDProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textIdDetalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFacCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFacPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void bdDetalleFacturaLoad()
        {
            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                connection.Open();

                using (var cmd = new NpgsqlCommand("SELECT * FROM detalle_factura", connection))
                {
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Asigna el DataTable al DataGridView
                    bdDetalleFactura.DataSource = dataTable;
                }
            }
        }
    }
}
