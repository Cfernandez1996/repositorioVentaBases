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
  
    public partial class Empleados : Form
    {
        string cadenaConexion = "Host=proyecto-aws.c2htk24uoh9j.us-east-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=bases123456789;Database=Proyecto";
        public Empleados()
        {
            InitializeComponent();
            CargarDatosEmpleado();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void CargarDatosEmpleado()
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
                    string consulta = "SELECT * FROM empleado";

                    // Crear un adaptador de datos
                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(consulta, conexion);

                    // Crear un DataTable para almacenar los datos
                    DataTable dt = new DataTable();

                    // Llenar el DataTable con los datos de la consulta
                    dataAdapter.Fill(dt);

                    // Asignar el DataTable como la fuente de datos del DataGridView
                    bdEmpleados.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void DatosClientes_Enter(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nuevoPNombre = txtPrimerNombre.Text;
            string nuevoSNombre = txtSegundoNombre.Text;
            string nuevoPApellido = txtPrimerApellido.Text;
            string nuevoSApellido = txtSegundoApellidos.Text;
            int nuevoDNI;
            if (!int.TryParse(txtDNI.Text, out nuevoDNI))
            {
                MessageBox.Show("Por favor, ingresa un número entero válido para la dni.");
                return;
            }
            int nuevaEdad;
            if (!int.TryParse(txtEdad.Text, out nuevaEdad))
            {
                MessageBox.Show("Por favor, ingresa un número entero válido para la edad.");
                return;
            }
            string nuevoGenero = txtGenero.Text;
            string nuevoTelefono = txtTelefono.Text;
            int nuevoIdEmpleado;
            if (!int.TryParse(txtid_empleado.Text, out nuevoIdEmpleado))
            {
                MessageBox.Show("Por favor, ingresa un número entero válido para la dni empleado.");
                return;
            }
            decimal nuevoSalario;
            if (!decimal.TryParse(txtSalario.Text, out nuevoSalario))
            {
                MessageBox.Show("Por favor, ingresa un número entero válido para el salario del empleado.");
                return;
            }


            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    // Configurar el comando para el procedimiento almacenado
                    using (var cmd = new NpgsqlCommand("insertar_empleado", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar los parámetros necesarios para la inserción
                        cmd.Parameters.AddWithValue("p_dni", nuevoDNI);
                        cmd.Parameters.AddWithValue("p_pnombre", nuevoPNombre);
                        cmd.Parameters.AddWithValue("p_snombre", nuevoSNombre);
                        cmd.Parameters.AddWithValue("p_papellido", nuevoPApellido);
                        cmd.Parameters.AddWithValue("p_sapellido", nuevoSApellido);
                        cmd.Parameters.AddWithValue("p_edad", nuevaEdad);
                        cmd.Parameters.AddWithValue("p_genero", nuevoGenero);
                        cmd.Parameters.AddWithValue("p_telefono", nuevoTelefono);
                        cmd.Parameters.AddWithValue("p_id_tipo_empleado", nuevoIdEmpleado);
                        cmd.Parameters.AddWithValue("p_salario",nuevoSalario);
                      
                        // Ejecutar el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Empleado guardado exitosamente.");
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error al guardar el empleado: " + ex.Message);
                }
            }

            // Recargar el DataGridView para reflejar los nuevos datos
            bdEmpleadosLoad();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (bdEmpleados.CurrentRow != null)
            {
                // Obtener el valor del DNI de la fila seleccionada
                int dni = Convert.ToInt32(bdEmpleados.CurrentRow.Cells["dni"].Value);

                // Confirmar la eliminación con el usuario
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este empleado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (var connection = new NpgsqlConnection(cadenaConexion))
                    {
                        try
                        {
                            connection.Open();

                            // Configurar el comando para el procedimiento almacenado
                            using (var cmd = new NpgsqlCommand("eliminar_empleado", connection))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                // Agregar el parámetro necesario para la eliminación
                                cmd.Parameters.AddWithValue("p_id_empleado", dni);

                                // Ejecutar el procedimiento almacenado
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("empleado eliminado exitosamente.");
                            }
                        }
                        catch (NpgsqlException ex)
                        {
                            MessageBox.Show("Error al eliminar el empleado: " + ex.Message);
                        }
                    }

                    // Recargar el DataGridView para reflejar los cambios
                    bdEmpleadosLoad();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un empleado para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bdEmpleadosLoad()
        {
            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                connection.Open();

                using (var cmd = new NpgsqlCommand("SELECT * FROM empleado", connection))
                {
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Asigna el DataTable al DataGridView
                    bdEmpleados.DataSource = dataTable;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Obtener el nuevo valor del TextBox
            string nuevoPNombre = txtPrimerNombre.Text;
            string nuevoSNombre = txtSegundoNombre.Text;
            string nuevoPApellido = txtPrimerApellido.Text;
            string nuevoSApellido = txtSegundoApellidos.Text;
            int nuevoDNI;
            if (!int.TryParse(txtDNI.Text, out nuevoDNI))
            {
                MessageBox.Show("Por favor, ingresa un número entero válido para la dni.");
                return;
            }
            int nuevaEdad;
            if (!int.TryParse(txtEdad.Text, out nuevaEdad))
            {
                MessageBox.Show("Por favor, ingresa un número entero válido para la edad.");
                return;
            }
            string nuevoGenero = txtGenero.Text;
            string nuevoTelefono = txtTelefono.Text;
            int nuevoIdEmpleado;
            if (!int.TryParse(txtid_empleado.Text, out nuevoIdEmpleado))
            {
                MessageBox.Show("Por favor, ingresa un número entero válido para la dni empleado.");
                return;
            }
            decimal nuevoSalario;
            if (!decimal.TryParse(txtSalario.Text, out nuevoSalario))
            {
                MessageBox.Show("Por favor, ingresa un número entero válido para el salario del empleado.");
                return;
            }


            // Suponiendo que tienes una clave primaria en la tabla para identificar la fila a actualizar
            int id = Convert.ToInt32(bdEmpleados.CurrentRow.Cells["dni"].Value);

            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                connection.Open();

                using (var cmd = new NpgsqlCommand("modificar_empleado", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Agregar los parámetros   
                    cmd.Parameters.AddWithValue("p_id_empleado", id);
                    cmd.Parameters.AddWithValue("p_pnombre", nuevoPNombre);
                    cmd.Parameters.AddWithValue("p_snombre", nuevoSNombre);
                    cmd.Parameters.AddWithValue("p_papellido", nuevoPApellido);
                    cmd.Parameters.AddWithValue("p_sapellido", nuevoSApellido);
                    cmd.Parameters.AddWithValue("p_edad", nuevaEdad);
                    cmd.Parameters.AddWithValue("p_genero", nuevoGenero);
                    cmd.Parameters.AddWithValue("p_telefono", nuevoTelefono);
                    cmd.Parameters.AddWithValue("p_id_tipo", nuevoIdEmpleado);
                    cmd.Parameters.AddWithValue("p_salario", nuevoSalario);



                    // Ejecutar la actualización
                    cmd.ExecuteNonQuery();
                }
            }

            // Actualizar el DataGridView para reflejar los cambios
            bdEmpleadosLoad();
        }

        private void bdEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = bdEmpleados.Rows[e.RowIndex];

                // Asignar el valor de la columna específica al TextBox
                txtPrimerNombre.Text = row.Cells["PNombre"].Value.ToString();
                txtSegundoNombre.Text = row.Cells["SNombre"].Value.ToString();
                txtPrimerApellido.Text = row.Cells["PApellido"].Value.ToString();
                txtSegundoApellidos.Text = row.Cells["SApellido"].Value.ToString();
                txtDNI.Text = row.Cells["dni"].Value.ToString();
                txtEdad.Text = row.Cells["edad"].Value.ToString();
                txtGenero.Text = row.Cells["genero"].Value.ToString();
                txtTelefono.Text = row.Cells["telefono"].Value.ToString();
                //txtid_empleado.Text = row.Cells["idempleado"].ToString();
                //txtSalario.Text = row.Cells["salario"].ToString();



            }
        }
    }
    
}
