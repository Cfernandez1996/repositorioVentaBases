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
    public partial class proveedor : Form
    {
        public proveedor()
        {
            InitializeComponent();
            CargarDatosProveedor();
        }
        string cadenaConexion = "Host=proyecto-aws.c2htk24uoh9j.us-east-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=bases123456789;Database=Proyecto";

        private void CargarDatosProveedor()
        {
            // Cadena de conexión
          
            using (NpgsqlConnection conexion = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    // Abre la conexión
                    conexion.Open();

                    // Consulta SQL
                    string consulta = "SELECT * FROM proveedor";

                    // Crear un adaptador de datos
                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(consulta, conexion);

                    // Crear un DataTable para almacenar los datos
                    DataTable dt = new DataTable();

                    // Llenar el DataTable con los datos de la consulta
                    dataAdapter.Fill(dt);

                    // Asignar el DataTable como la fuente de datos del DataGridView
                    bdProveedor.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int nuevoIdproveedor;
            if (!int.TryParse(textIdProv.Text, out nuevoIdproveedor))
            {
                MessageBox.Show("Por favor, ingresa un número entero válido para id proveedor.");
                return;
            }

            string nuevonombre= textnombre.Text;

            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    // Configurar el comando para el procedimiento almacenado
                    using (var cmd = new NpgsqlCommand("agregar_proveedor", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar los parámetros necesarios para la inserción
                        cmd.Parameters.AddWithValue("id_proveedor", nuevoIdproveedor);
                        cmd.Parameters.AddWithValue("nombre", nuevonombre);

                        // Ejecutar el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Proveedor registrado exitosamente.");
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error al guardar el proveedor: " + ex.Message);
                }
            }

            // Recargar el DataGridView para reflejar los nuevos datos
            bdProoveedorLoad();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nuevonombre = textnombre.Text;
            // Suponiendo que tienes una clave primaria en la tabla para identificar la fila a actualizar
            int nuevoidproc = Convert.ToInt32(bdProveedor.CurrentRow.Cells["id_proveedor"].Value);

            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    using (var cmd = new NpgsqlCommand("modificar_proveedor", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar los parámetros
                        cmd.Parameters.AddWithValue("p_id_proveedor", nuevoidproc);
                        cmd.Parameters.AddWithValue("p_nombre", nuevonombre);


                        // Ejecutar la actualización
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Proveedor modificado exitosamente.");
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error al modificar el proveedor: " + ex.Message);
                }
            }

            // Actualizar el DataGridView para reflejar los cambios
            bdProoveedorLoad();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        { // Verificar si hay una fila seleccionada en el DataGridView
            if (bdProveedor.CurrentRow != null)
            {
                // Obtener el valor del idinventario de la fila seleccionada
                int idprov = Convert.ToInt32(bdProveedor.CurrentRow.Cells["id_proveedor"].Value);

                // Confirmar la eliminación con el usuario
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este inventario?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (var connection = new NpgsqlConnection(cadenaConexion))
                    {
                        try
                        {
                            connection.Open();

                            // Configurar el comando para el procedimiento almacenado
                            using (var cmd = new NpgsqlCommand("eliminar_proveedor", connection))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                // Agregar el parámetro necesario para la eliminación
                                cmd.Parameters.AddWithValue("p_id_proveedor", idprov);

                                // Ejecutar el procedimiento almacenado
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Proveedor eliminado exitosamente.");
                            }
                        }
                        catch (NpgsqlException ex)
                        {
                            MessageBox.Show("Error al eliminar el proveedor: " + ex.Message);
                        }
                    }

                    // Recargar el DataGridView para reflejar los cambios
                    bdProoveedorLoad();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un proveedor para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bdProoveedorLoad()
        {
            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                connection.Open();

                using (var cmd = new NpgsqlCommand("SELECT * FROM proveedor", connection))
                {
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Asigna el DataTable al DataGridView
                    bdProveedor.DataSource = dataTable;
                }
            }
        }
    }
    
}
