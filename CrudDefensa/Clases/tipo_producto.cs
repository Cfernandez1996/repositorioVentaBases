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
    public partial class tipo_producto : Form
    {
        public tipo_producto()
        {
            InitializeComponent();
            CargarDatosTipoProducto();
        }
        string cadenaConexion = "Host=proyecto-aws.c2htk24uoh9j.us-east-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=bases123456789;Database=Proyecto";

        private void CargarDatosTipoProducto()
        {
            // Cadena de conexión
           
            using (NpgsqlConnection conexion = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    // Abre la conexión
                    conexion.Open();

                    // Consulta SQL
                    string consulta = "SELECT * FROM tipo_producto";

                    // Crear un adaptador de datos
                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(consulta, conexion);

                    // Crear un DataTable para almacenar los datos
                    DataTable dt = new DataTable();

                    // Llenar el DataTable con los datos de la consulta
                    dataAdapter.Fill(dt);

                    // Asignar el DataTable como la fuente de datos del DataGridView
                    bdTipoProducto.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nuevoNombre = txt_nombre.Text;

            int nuevoIDTipo;
            if (!int.TryParse(txt_id_tipo.Text, out nuevoIDTipo))
            {
                MessageBox.Show("Por favor, ingresa un número entero válido para el Id TIPO.");
                return;
            }
            string nuevoIdProducto=txt_id_producto.Text;


            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    // Configurar el comando para el procedimiento almacenado
                    using (var cmd = new NpgsqlCommand("agregar_tipo_producto", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar los parámetros necesarios para la inserción
                        cmd.Parameters.AddWithValue("p_idtipo", nuevoIDTipo);
                        cmd.Parameters.AddWithValue("p_nombre", nuevoNombre);
                        cmd.Parameters.AddWithValue("p_idproducto", nuevoIdProducto);



                        // Ejecutar el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("tipoProducto guardado exitosamente.");
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error al guardar el el tipo producto: " + ex.Message);
                }

            }
            bdTipoProductoLoad();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (bdTipoProducto.CurrentRow != null)
            {
                // Obtener el valor del DNI de la fila seleccionada
                int dni = Convert.ToInt32(bdTipoProducto.CurrentRow.Cells["id_tipo"].Value);

                // Confirmar la eliminación con el usuario
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este tipo producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (var connection = new NpgsqlConnection(cadenaConexion))
                    {
                        try
                        {
                            connection.Open();

                            // Configurar el comando para el procedimiento almacenado
                            using (var cmd = new NpgsqlCommand("eliminar_tipo_producto", connection))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                // Agregar el parámetro necesario para la eliminación
                                cmd.Parameters.AddWithValue("p_id_producto", dni);

                                // Ejecutar el procedimiento almacenado
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("tipo_producto eliminado exitosamente.");
                            }
                        }
                        catch (NpgsqlException ex)
                        {
                            MessageBox.Show("Error al eliminar el tipo de producto: " + ex.Message);
                        }
                    }

                    // Recargar el DataGridView para reflejar los cambios
                    bdTipoProductoLoad();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un tipo producto para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
          
        }
        private void bdTipoProductoLoad()
        {
            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                connection.Open();

                using (var cmd = new NpgsqlCommand("SELECT * FROM tipo_producto", connection))
                {
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Asigna el DataTable al DataGridView
                    bdTipoProducto.DataSource = dataTable;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Obtener el nuevo valor del TextBox
            string nuevoNombre = txt_nombre.Text;

            string nuevoIdProducto=txt_id_producto.Text;


            // Suponiendo que tienes una clave primaria en la tabla para identificar la fila a actualizar
            int id = Convert.ToInt32(bdTipoProducto.CurrentRow.Cells["id_tipo"].Value);

            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                connection.Open();

                using (var cmd = new NpgsqlCommand("modificar_tipo_producto", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Agregar los parametros
                    cmd.Parameters.AddWithValue("p_idtipo", id);
                    cmd.Parameters.AddWithValue("p_nombre", nuevoNombre);
                    cmd.Parameters.AddWithValue("p_idproducto", nuevoIdProducto);




                    // Ejecutar la actualización
                    cmd.ExecuteNonQuery();
                }
            }

            // Actualizar el DataGridView para reflejar los cambios
            bdTipoProductoLoad();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (bdTipoProducto.CurrentRow != null)
            {
                // Obtener el valor del DNI de la fila seleccionada
                int dni = Convert.ToInt32(bdTipoProducto.CurrentRow.Cells["id_tipo"].Value);

                // Confirmar la eliminación con el usuario
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este tipo producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (var connection = new NpgsqlConnection(cadenaConexion))
                    {
                        try
                        {
                            connection.Open();

                            // Configurar el comando para el procedimiento almacenado
                            using (var cmd = new NpgsqlCommand("eliminar_tipo_producto", connection))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                // Agregar el parámetro necesario para la eliminación
                                cmd.Parameters.AddWithValue("p_idtipo", dni);

                                // Ejecutar el procedimiento almacenado
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("tipo producto eliminado exitosamente.");
                            }
                        }
                        catch (NpgsqlException ex)
                        {
                            MessageBox.Show("Error al eliminar el tipo producto: " + ex.Message);
                        }
                    }

                    // Recargar el DataGridView para reflejar los cambios
                    bdTipoProductoLoad();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un tipo de empleado para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
