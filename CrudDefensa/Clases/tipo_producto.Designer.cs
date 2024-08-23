namespace CrudDefensa.Clases
{
    partial class tipo_producto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bdTipoProducto = new System.Windows.Forms.DataGridView();
            this.DatosClientes = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txt_id_producto = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_id_tipo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdTipoProducto)).BeginInit();
            this.DatosClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // bdTipoProducto
            // 
            this.bdTipoProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bdTipoProducto.Location = new System.Drawing.Point(501, 49);
            this.bdTipoProducto.Margin = new System.Windows.Forms.Padding(2);
            this.bdTipoProducto.Name = "bdTipoProducto";
            this.bdTipoProducto.RowHeadersWidth = 51;
            this.bdTipoProducto.RowTemplate.Height = 24;
            this.bdTipoProducto.Size = new System.Drawing.Size(368, 300);
            this.bdTipoProducto.TabIndex = 9;
            // 
            // DatosClientes
            // 
            this.DatosClientes.Controls.Add(this.btnEliminar);
            this.DatosClientes.Controls.Add(this.btnModificar);
            this.DatosClientes.Controls.Add(this.btnGuardar);
            this.DatosClientes.Controls.Add(this.txt_id_producto);
            this.DatosClientes.Controls.Add(this.txt_nombre);
            this.DatosClientes.Controls.Add(this.txt_id_tipo);
            this.DatosClientes.Controls.Add(this.label6);
            this.DatosClientes.Controls.Add(this.label3);
            this.DatosClientes.Controls.Add(this.label2);
            this.DatosClientes.Controls.Add(this.label1);
            this.DatosClientes.Location = new System.Drawing.Point(11, 30);
            this.DatosClientes.Margin = new System.Windows.Forms.Padding(2);
            this.DatosClientes.Name = "DatosClientes";
            this.DatosClientes.Padding = new System.Windows.Forms.Padding(2);
            this.DatosClientes.Size = new System.Drawing.Size(433, 346);
            this.DatosClientes.TabIndex = 8;
            this.DatosClientes.TabStop = false;
            this.DatosClientes.Text = "Datos Tipo Producto";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(309, 99);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(66, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(307, 36);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(68, 23);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(283, 160);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txt_id_producto
            // 
            this.txt_id_producto.Location = new System.Drawing.Point(111, 74);
            this.txt_id_producto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_id_producto.Name = "txt_id_producto";
            this.txt_id_producto.Size = new System.Drawing.Size(93, 20);
            this.txt_id_producto.TabIndex = 8;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(111, 50);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(93, 20);
            this.txt_nombre.TabIndex = 7;
            // 
            // txt_id_tipo
            // 
            this.txt_id_tipo.Location = new System.Drawing.Point(111, 18);
            this.txt_id_tipo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_id_tipo.Name = "txt_id_tipo";
            this.txt_id_tipo.Size = new System.Drawing.Size(93, 20);
            this.txt_id_tipo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id tipo";
            // 
            // tipo_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 366);
            this.Controls.Add(this.bdTipoProducto);
            this.Controls.Add(this.DatosClientes);
            this.Name = "tipo_producto";
            this.Text = "tipo_producto";
            ((System.ComponentModel.ISupportInitialize)(this.bdTipoProducto)).EndInit();
            this.DatosClientes.ResumeLayout(false);
            this.DatosClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bdTipoProducto;
        private System.Windows.Forms.GroupBox DatosClientes;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txt_id_producto;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_id_tipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}