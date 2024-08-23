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
    public partial class Ubicacion : Form
    {
        public Ubicacion()
        {
            InitializeComponent();
            CargarDatosUbicacion();
        }
        string cadenaConexion = "Host=proyecto-aws.c2htk24uoh9j.us-east-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=bases123456789;Database=Proyecto";
        
        private void CargarDatosUbicacion()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    // Abre la conexión
                    conexion.Open();

                    // Consulta SQL
                    string consulta = "SELECT * FROM ubicacion";

                    // Crear un adaptador de datos
                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(consulta, conexion);

                    // Crear un DataTable para almacenar los datos
                    DataTable dt = new DataTable();

                    // Llenar el DataTable con los datos de la consulta
                    dataAdapter.Fill(dt);

                    // Asignar el DataTable como la fuente de datos del DataGridView
                    dbUbicacion.DataSource = dt;
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
            int nuevaidUb;
            if (!int.TryParse(textubi.Text, out nuevaidUb))
            {
                MessageBox.Show("Por favor, ingresa un número entero válido para la id Ubicacion.");
                return;
            }
            int nuevaidtienda;
            if (!int.TryParse(textidtienda.Text, out nuevaidtienda))
            {
                MessageBox.Show("Por favor, ingresa un número entero válido para la id tienda.");
                return;
            }
            string nuevatt = texttt.Text;

            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    // Configurar el comando para el procedimiento almacenado
                    using (var cmd = new NpgsqlCommand("agregar_ubicacion", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar los parámetros necesarios para la inserción
                        cmd.Parameters.AddWithValue("id_ubicacion", nuevaidUb);
                        cmd.Parameters.AddWithValue("tipo_tienda", nuevatt);
                        cmd.Parameters.AddWithValue("id_tienda", nuevaidtienda);

                        // Ejecutar el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Ubicacion registrada exitosamente.");
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error al guardar la ubicacion: " + ex.Message);
                }
            }

            // Recargar el DataGridView para reflejar los nuevos datos
            bdUbicacionLoad();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Obtener el nuevo valor del TextBox
            int nuevaIdTienda;
            if (!int.TryParse(textidtienda.Text, out nuevaIdTienda))
            {
                MessageBox.Show("Por favor, ingresa un número entero válido para la id de la tienda.");
                return;
            }
            string nuevott = texttt.Text;

            // Suponiendo que tienes una clave primaria en la tabla para identificar la fila a actualizar
            int nuevoidub = Convert.ToInt32(dbUbicacion.CurrentRow.Cells["id_ubicacion"].Value);

            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    using (var cmd = new NpgsqlCommand("modificar_ubicacion", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar los parámetros
                        cmd.Parameters.AddWithValue("p_id_ubicacion", nuevoidub);
                        cmd.Parameters.AddWithValue("p_tipo_tienda", nuevott);
                        cmd.Parameters.AddWithValue("p_id_tienda", nuevaIdTienda);



                        // Ejecutar la actualización
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Ubicacion modificada exitosamente.");
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error al modificar la ubicacion: " + ex.Message);
                }
            }

            // Actualizar el DataGridView para reflejar los cambios
            bdUbicacionLoad();
        }
        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dbUbicacion.CurrentRow != null)
            {
                // Obtener el valor del idinventario de la fila seleccionada
                int idubi = Convert.ToInt32(dbUbicacion.CurrentRow.Cells["id_ubicacion"].Value);

                // Confirmar la eliminación con el usuario
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta ubicacion?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (var connection = new NpgsqlConnection(cadenaConexion))
                    {
                        try
                        {
                            connection.Open();

                            // Configurar el comando para el procedimiento almacenado
                            using (var cmd = new NpgsqlCommand("eliminar_ubicacion", connection))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                // Agregar el parámetro necesario para la eliminación
                                cmd.Parameters.AddWithValue("p_id_ubicacion", idubi);

                                // Ejecutar el procedimiento almacenado
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Ubicacion eliminada exitosamente.");
                            }
                        }
                        catch (NpgsqlException ex)
                        {
                            MessageBox.Show("Error al eliminar la ubicacion: " + ex.Message);
                        }
                    }

                    // Recargar el DataGridView para reflejar los cambios
                    bdUbicacionLoad();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una ubicacion para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bdUbicacionLoad()
        {
            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                connection.Open();

                using (var cmd = new NpgsqlCommand("SELECT * FROM ubicacion", connection))
                {
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Asigna el DataTable al DataGridView
                    dbUbicacion.DataSource = dataTable;
                }
            }
        }
    }
}
