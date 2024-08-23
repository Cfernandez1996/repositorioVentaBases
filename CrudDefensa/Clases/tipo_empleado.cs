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
    public partial class tipo_empleado : Form
    {
        public tipo_empleado()
        {
            InitializeComponent();
            CargarDatosTipoEmpleado();
        }
        string cadenaConexion = "Host=proyecto-aws.c2htk24uoh9j.us-east-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=bases123456789;Database=Proyecto";

        private void CargarDatosTipoEmpleado()
        {
            // Cadena de conexión
            
            using (NpgsqlConnection conexion = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    // Abre la conexión
                    conexion.Open();

                    // Consulta SQL
                    string consulta = "SELECT * FROM tipo_empleado";

                    // Crear un adaptador de datos
                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(consulta, conexion);

                    // Crear un DataTable para almacenar los datos
                    DataTable dt = new DataTable();

                    // Llenar el DataTable con los datos de la consulta
                    dataAdapter.Fill(dt);

                    // Asignar el DataTable como la fuente de datos del DataGridView
                    bdTipoEmpleado.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int nuevoidtp;
            if (!int.TryParse(textidtp.Text, out nuevoidtp))
            {
                MessageBox.Show("Por favor, ingresa un número entero válido para id Tipo Empleado.");
                return;
            }

            string nuevaDesc = textdesc.Text;

            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    // Configurar el comando para el procedimiento almacenado
                    using (var cmd = new NpgsqlCommand("agregar_tipo_empleado", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar los parámetros necesarios para la inserción
                        cmd.Parameters.AddWithValue("id_tipo_p", nuevoidtp);
                        cmd.Parameters.AddWithValue("desc_p", nuevaDesc);

                        // Ejecutar el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Tipo de empleado registrado exitosamente.");
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error al guardar el tipo empleado: " + ex.Message);
                }
            }

            // Recargar el DataGridView para reflejar los nuevos datos
            bdTipoEmpleadoLoad();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nuevaDesc = textdesc.Text;

            // Suponiendo que tienes una clave primaria en la tabla para identificar la fila a actualizar
            int nuevoidtp = Convert.ToInt32(bdTipoEmpleado.CurrentRow.Cells["id_tipo"].Value);

            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    using (var cmd = new NpgsqlCommand("modificar_tipo_empleado", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar los parámetros
                        cmd.Parameters.AddWithValue("id_tipo_p", nuevoidtp);
                        cmd.Parameters.AddWithValue("desc_p", nuevaDesc);



                        // Ejecutar la actualización
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Tipo empleado modificado exitosamente.");
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error al modificar el tipo empleado: " + ex.Message);
                }
            }

            // Actualizar el DataGridView para reflejar los cambios
            bdTipoEmpleadoLoad();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (bdTipoEmpleado.CurrentRow != null)
            {
                // Obtener el valor del idinventario de la fila seleccionada
                int nuevoidtp = Convert.ToInt32(bdTipoEmpleado.CurrentRow.Cells["id_tipo"].Value);

                // Confirmar la eliminación con el usuario
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este tipo de empleado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (var connection = new NpgsqlConnection(cadenaConexion))
                    {
                        try
                        {
                            connection.Open();

                            // Configurar el comando para el procedimiento almacenado
                            using (var cmd = new NpgsqlCommand("eliminar_tipo_empleado", connection))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                // Agregar el parámetro necesario para la eliminación
                                cmd.Parameters.AddWithValue("id_tipo_p", nuevoidtp);

                                // Ejecutar el procedimiento almacenado
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Tipo Empleado eliminado exitosamente.");
                            }
                        }
                        catch (NpgsqlException ex)
                        {
                            MessageBox.Show("Error al eliminar el Tipo de Empleado: " + ex.Message);
                        }
                    }

                    // Recargar el DataGridView para reflejar los cambios
                    bdTipoEmpleadoLoad();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un tipo de empleado para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bdTipoEmpleadoLoad()
        {
            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                connection.Open();

                using (var cmd = new NpgsqlCommand("SELECT * FROM tipo_empleado", connection))
                {
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Asigna el DataTable al DataGridView
                    bdTipoEmpleado.DataSource = dataTable;
                }
            }
        }
    }
}
