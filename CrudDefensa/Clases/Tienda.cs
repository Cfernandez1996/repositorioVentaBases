﻿using Npgsql;
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
    public partial class Tienda : Form
    {
        public Tienda()
        {
            InitializeComponent();
            CargarDatosTienda();

        }
        string cadenaConexion = "Host=proyecto-aws.c2htk24uoh9j.us-east-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=bases123456789;Database=Proyecto";

        private void CargarDatosTienda()
        {
            // Cadena de conexión
           
            using (NpgsqlConnection conexion = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    // Abre la conexión
                    conexion.Open();

                    // Consulta SQL
                    string consulta = "SELECT * FROM tienda";

                    // Crear un adaptador de datos
                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(consulta, conexion);

                    // Crear un DataTable para almacenar los datos
                    DataTable dt = new DataTable();

                    // Llenar el DataTable con los datos de la consulta
                    dataAdapter.Fill(dt);

                    // Asignar el DataTable como la fuente de datos del DataGridView
                    dbTienda.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
         
            string nuevoNombreTienda = txtNombreTienda.Text;
            string nuevoHorario = txtHorario.Text;
            int nuevaIDTienda;
            if (!int.TryParse(txtIdTienda.Text, out nuevaIDTienda))
            {
                MessageBox.Show("Por favor, ingresa un número entero válido para el ID tienda.");
                return;
            }
          

            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    // Configurar el comando para el procedimiento almacenado
                    using (var cmd = new NpgsqlCommand("insertar_tienda", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar los parámetros necesarios para la inserción
                        cmd.Parameters.AddWithValue("p_id_tienda", nuevaIDTienda);
                        cmd.Parameters.AddWithValue("p_nombre", nuevoNombreTienda);
                        cmd.Parameters.AddWithValue("p_horario", nuevoHorario);
                       


                        // Ejecutar el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Cliente guardado exitosamente.");
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error al guardar el cliente: " + ex.Message);
                }
            }

            // Recargar el DataGridView para reflejar los nuevos datos
            bdTiendaLoad();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dbTienda.CurrentRow != null)
            {
                // Obtener el valor del DNI de la fila seleccionada
                int id = Convert.ToInt32(dbTienda.CurrentRow.Cells["id_tienda"].Value);

                // Confirmar la eliminación con el usuario
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta tienda?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (var connection = new NpgsqlConnection(cadenaConexion))
                    {
                        try
                        {
                            connection.Open();

                            // Configurar el comando para el procedimiento almacenado
                            using (var cmd = new NpgsqlCommand("eliminar_tienda", connection))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                // Agregar el parámetro necesario para la eliminación
                                cmd.Parameters.AddWithValue("p_id_tienda", id);

                                // Ejecutar el procedimiento almacenado
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("tienda eliminada exitosamente.");
                            }
                        }
                        catch (NpgsqlException ex)
                        {
                            MessageBox.Show("Error al eliminar la tienda: " + ex.Message);
                        }
                    }

                    // Recargar el DataGridView para reflejar los cambios
                    bdTiendaLoad();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una tienda para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bdTiendaLoad()
        {
            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                connection.Open();

                using (var cmd = new NpgsqlCommand("SELECT * FROM tienda", connection))
                {
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Asigna el DataTable al DataGridView
                    dbTienda.DataSource = dataTable;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Obtener el nuevo valor del TextBox
            string nuevoNombreTienda = txtNombreTienda.Text;
            string nuevoHorario = txtHorario.Text;
            int nuevaIDTienda;
            if (!int.TryParse(txtIdTienda.Text, out nuevaIDTienda))
            {
                MessageBox.Show("Por favor, ingresa un número entero válido para el ID tienda.");
                return;
            }




            // Suponiendo que tienes una clave primaria en la tabla para identificar la fila a actualizar
            int id = Convert.ToInt32(dbTienda.CurrentRow.Cells["id_tienda"].Value);

            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                connection.Open();

                using (var cmd = new NpgsqlCommand("modificar_tienda", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Agregar los parámetros
                    cmd.Parameters.AddWithValue("p_id_tienda", id);
                    cmd.Parameters.AddWithValue("p_nombre",  nuevoNombreTienda );

                    cmd.Parameters.AddWithValue("p_horario", nuevoHorario);
                  



                    // Ejecutar la actualización
                    cmd.ExecuteNonQuery();
                }
            }

            // Actualizar el DataGridView para reflejar los cambios
            bdTiendaLoad();
        }
    }
}
