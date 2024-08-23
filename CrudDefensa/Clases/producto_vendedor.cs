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
using static System.Net.Mime.MediaTypeNames;

namespace CrudDefensa.Clases
{
    public partial class producto_vendedor : Form
    {
        public producto_vendedor()
        {
            InitializeComponent();
            CargarDatosProductoVendedor();
        }
        string cadenaConexion = "Host=proyecto-aws.c2htk24uoh9j.us-east-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=bases123456789;Database=Proyecto";
        private void CargarDatosProductoVendedor()
        {
            // Cadena de conexión


            using (NpgsqlConnection conexion = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    // Abre la conexión
                    conexion.Open();

                    // Consulta SQL
                    string consulta = "SELECT * FROM producto_vendedor";

                    // Crear un adaptador de datos
                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(consulta, conexion);

                    // Crear un DataTable para almacenar los datos
                    DataTable dt = new DataTable();

                    // Llenar el DataTable con los datos de la consulta
                    dataAdapter.Fill(dt);

                    // Asignar el DataTable como la fuente de datos del DataGridView
                    bdproducto_vendedor.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }
        private void DatosClientes_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nuevaidProd = textIdProd.Text;
            int nuevaIdEmp;
            if (!int.TryParse(textIdEmp.Text, out nuevaIdEmp))
            {
                MessageBox.Show("Por favor, ingresa un número entero válido para la id tienda.");
                return;
            }

            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    // Configurar el comando para el procedimiento almacenado
                    using (var cmd = new NpgsqlCommand("agregar_prodvend", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar los parámetros necesarios para la inserción
                        cmd.Parameters.AddWithValue("p_id_prod", nuevaidProd);
                        cmd.Parameters.AddWithValue("p_dni", nuevaIdEmp);

                        // Ejecutar el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Al vendedor se le registro exitosamente un producto.");
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error  " + ex.Message);
                }
            }

            // Recargar el DataGridView para reflejar los nuevos datos
            bdProductoVendedorLoad();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (bdproducto_vendedor.CurrentRow != null)
            {
                // Obtener el valor del idinventario de la fila seleccionada
                string idprod = Convert.ToString(bdproducto_vendedor.CurrentRow.Cells["idproducto"].Value);

                int idemp = Convert.ToInt32(bdproducto_vendedor.CurrentRow.Cells["dni"].Value);

                // Confirmar la eliminación con el usuario
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta relacion?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (var connection = new NpgsqlConnection(cadenaConexion))
                    {
                        try
                        {
                            connection.Open();

                            // Configurar el comando para el procedimiento almacenado
                            using (var cmd = new NpgsqlCommand("eliminar_prodvend", connection))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                // Agregar el parámetro necesario para la eliminación
                                cmd.Parameters.AddWithValue("p_id_prod", idprod);
                                cmd.Parameters.AddWithValue("p_dni", idemp);

                                // Ejecutar el procedimiento almacenado
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Relacion eliminada exitosamente.");
                            }
                        }
                        catch (NpgsqlException ex)
                        {
                            MessageBox.Show("Error al eliminar la relacion: " + ex.Message);
                        }
                    }

                    // Recargar el DataGridView para reflejar los cambios
                    bdProductoVendedorLoad();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una relacion prod-vend para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bdProductoVendedorLoad()
        {
            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                connection.Open();

                using (var cmd = new NpgsqlCommand("SELECT * FROM producto_vendedor", connection))
                {
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Asigna el DataTable al DataGridView
                    bdproducto_vendedor.DataSource = dataTable;
                }
            }
        }

        
    }
}
