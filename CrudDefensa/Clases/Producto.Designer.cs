namespace CrudDefensa.Clases
{
    partial class Producto
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
            this.bdProducto = new System.Windows.Forms.DataGridView();
            this.DatosClientes = new System.Windows.Forms.GroupBox();
            this.textReorden = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textIdProveedor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textIdMarca = new System.Windows.Forms.TextBox();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.textEmbalaje = new System.Windows.Forms.TextBox();
            this.textTamano = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdProducto)).BeginInit();
            this.DatosClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // bdProducto
            // 
            this.bdProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bdProducto.Location = new System.Drawing.Point(556, 60);
            this.bdProducto.Margin = new System.Windows.Forms.Padding(2);
            this.bdProducto.Name = "bdProducto";
            this.bdProducto.RowHeadersWidth = 51;
            this.bdProducto.RowTemplate.Height = 24;
            this.bdProducto.Size = new System.Drawing.Size(368, 300);
            this.bdProducto.TabIndex = 5;
            this.bdProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bdProducto_CellContentClick);
            // 
            // DatosClientes
            // 
            this.DatosClientes.Controls.Add(this.textReorden);
            this.DatosClientes.Controls.Add(this.label11);
            this.DatosClientes.Controls.Add(this.textIdProveedor);
            this.DatosClientes.Controls.Add(this.label7);
            this.DatosClientes.Controls.Add(this.label10);
            this.DatosClientes.Controls.Add(this.textIdMarca);
            this.DatosClientes.Controls.Add(this.textCantidad);
            this.DatosClientes.Controls.Add(this.textPrecio);
            this.DatosClientes.Controls.Add(this.lbl_marca);
            this.DatosClientes.Controls.Add(this.label8);
            this.DatosClientes.Controls.Add(this.label9);
            this.DatosClientes.Controls.Add(this.btnEliminar);
            this.DatosClientes.Controls.Add(this.btnModificar);
            this.DatosClientes.Controls.Add(this.btnGuardar);
            this.DatosClientes.Controls.Add(this.textMarca);
            this.DatosClientes.Controls.Add(this.textEmbalaje);
            this.DatosClientes.Controls.Add(this.textTamano);
            this.DatosClientes.Controls.Add(this.textNombre);
            this.DatosClientes.Controls.Add(this.textID);
            this.DatosClientes.Controls.Add(this.label6);
            this.DatosClientes.Controls.Add(this.label5);
            this.DatosClientes.Controls.Add(this.label4);
            this.DatosClientes.Controls.Add(this.label3);
            this.DatosClientes.Controls.Add(this.label2);
            this.DatosClientes.Controls.Add(this.label1);
            this.DatosClientes.Location = new System.Drawing.Point(31, 76);
            this.DatosClientes.Margin = new System.Windows.Forms.Padding(2);
            this.DatosClientes.Name = "DatosClientes";
            this.DatosClientes.Padding = new System.Windows.Forms.Padding(2);
            this.DatosClientes.Size = new System.Drawing.Size(433, 346);
            this.DatosClientes.TabIndex = 6;
            this.DatosClientes.TabStop = false;
            this.DatosClientes.Text = "Datos Producto";
            this.DatosClientes.Enter += new System.EventHandler(this.DatosClientes_Enter);
            // 
            // textReorden
            // 
            this.textReorden.Location = new System.Drawing.Point(111, 301);
            this.textReorden.Margin = new System.Windows.Forms.Padding(2);
            this.textReorden.Name = "textReorden";
            this.textReorden.Size = new System.Drawing.Size(93, 20);
            this.textReorden.TabIndex = 24;
            this.textReorden.TextChanged += new System.EventHandler(this.textReorden_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 301);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Reorden";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // textIdProveedor
            // 
            this.textIdProveedor.Location = new System.Drawing.Point(111, 268);
            this.textIdProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.textIdProveedor.Name = "textIdProveedor";
            this.textIdProveedor.Size = new System.Drawing.Size(93, 20);
            this.textIdProveedor.TabIndex = 22;
            this.textIdProveedor.TextChanged += new System.EventHandler(this.textIdproveedor_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 271);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Id Proveedor";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 271);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 20;
            // 
            // textIdMarca
            // 
            this.textIdMarca.Location = new System.Drawing.Point(111, 232);
            this.textIdMarca.Margin = new System.Windows.Forms.Padding(2);
            this.textIdMarca.Name = "textIdMarca";
            this.textIdMarca.Size = new System.Drawing.Size(93, 20);
            this.textIdMarca.TabIndex = 19;
            this.textIdMarca.TextChanged += new System.EventHandler(this.textIdMarca_TextChanged);
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(111, 199);
            this.textCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(93, 20);
            this.textCantidad.TabIndex = 18;
            this.textCantidad.TextChanged += new System.EventHandler(this.textCantidad_TextChanged);
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(113, 171);
            this.textPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(93, 20);
            this.textPrecio.TabIndex = 17;
            this.textPrecio.TextChanged += new System.EventHandler(this.textPrecio_TextChanged);
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Location = new System.Drawing.Point(12, 239);
            this.lbl_marca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(49, 13);
            this.lbl_marca.TabIndex = 16;
            this.lbl_marca.Text = "Id Marca";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 206);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 174);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "precio";
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
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            // textMarca
            // 
            this.textMarca.Location = new System.Drawing.Point(111, 135);
            this.textMarca.Margin = new System.Windows.Forms.Padding(2);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(93, 20);
            this.textMarca.TabIndex = 10;
            this.textMarca.TextChanged += new System.EventHandler(this.textMarca_TextChanged);
            // 
            // textEmbalaje
            // 
            this.textEmbalaje.Location = new System.Drawing.Point(111, 106);
            this.textEmbalaje.Margin = new System.Windows.Forms.Padding(2);
            this.textEmbalaje.Name = "textEmbalaje";
            this.textEmbalaje.Size = new System.Drawing.Size(93, 20);
            this.textEmbalaje.TabIndex = 9;
            this.textEmbalaje.TextChanged += new System.EventHandler(this.textEmbalaje_TextChanged);
            // 
            // textTamano
            // 
            this.textTamano.Location = new System.Drawing.Point(111, 77);
            this.textTamano.Margin = new System.Windows.Forms.Padding(2);
            this.textTamano.Name = "textTamano";
            this.textTamano.Size = new System.Drawing.Size(93, 20);
            this.textTamano.TabIndex = 8;
            this.textTamano.TextChanged += new System.EventHandler(this.textTamano_TextChanged);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(111, 50);
            this.textNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(93, 20);
            this.textNombre.TabIndex = 7;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(111, 18);
            this.textID.Margin = new System.Windows.Forms.Padding(2);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(93, 20);
            this.textID.TabIndex = 6;
            this.textID.TextChanged += new System.EventHandler(this.textID_TextChanged);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "marca";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "embalaje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tamaño";
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
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "upc";
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 450);
            this.Controls.Add(this.DatosClientes);
            this.Controls.Add(this.bdProducto);
            this.Name = "Producto";
            this.Text = "upc";
            ((System.ComponentModel.ISupportInitialize)(this.bdProducto)).EndInit();
            this.DatosClientes.ResumeLayout(false);
            this.DatosClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bdProducto;
        private System.Windows.Forms.GroupBox DatosClientes;
        private System.Windows.Forms.TextBox textIdMarca;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.TextBox textEmbalaje;
        private System.Windows.Forms.TextBox textTamano;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textIdProveedor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textReorden;
    }
}