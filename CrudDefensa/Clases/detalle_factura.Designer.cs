namespace CrudDefensa.Clases
{
    partial class detalle_factura
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
            this.bdDetalleFactura = new System.Windows.Forms.DataGridView();
            this.DatosClientes = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textFacPrecio = new System.Windows.Forms.TextBox();
            this.textFacCantidad = new System.Windows.Forms.TextBox();
            this.textIDProducto = new System.Windows.Forms.TextBox();
            this.textIDFacura = new System.Windows.Forms.TextBox();
            this.textIdDetalle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdDetalleFactura)).BeginInit();
            this.DatosClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // bdDetalleFactura
            // 
            this.bdDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bdDetalleFactura.Location = new System.Drawing.Point(606, 51);
            this.bdDetalleFactura.Name = "bdDetalleFactura";
            this.bdDetalleFactura.Size = new System.Drawing.Size(325, 284);
            this.bdDetalleFactura.TabIndex = 7;
            // 
            // DatosClientes
            // 
            this.DatosClientes.Controls.Add(this.btnModificar);
            this.DatosClientes.Controls.Add(this.btnGuardar);
            this.DatosClientes.Controls.Add(this.textFacPrecio);
            this.DatosClientes.Controls.Add(this.textFacCantidad);
            this.DatosClientes.Controls.Add(this.textIDProducto);
            this.DatosClientes.Controls.Add(this.textIDFacura);
            this.DatosClientes.Controls.Add(this.textIdDetalle);
            this.DatosClientes.Controls.Add(this.label6);
            this.DatosClientes.Controls.Add(this.label5);
            this.DatosClientes.Controls.Add(this.label4);
            this.DatosClientes.Controls.Add(this.label3);
            this.DatosClientes.Controls.Add(this.label2);
            this.DatosClientes.Controls.Add(this.label1);
            this.DatosClientes.Location = new System.Drawing.Point(75, 33);
            this.DatosClientes.Margin = new System.Windows.Forms.Padding(2);
            this.DatosClientes.Name = "DatosClientes";
            this.DatosClientes.Padding = new System.Windows.Forms.Padding(2);
            this.DatosClientes.Size = new System.Drawing.Size(433, 346);
            this.DatosClientes.TabIndex = 6;
            this.DatosClientes.TabStop = false;
            this.DatosClientes.Text = "datos detslleFactura";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(287, 213);
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
            this.btnGuardar.Location = new System.Drawing.Point(15, 213);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // textFacPrecio
            // 
            this.textFacPrecio.Location = new System.Drawing.Point(111, 135);
            this.textFacPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.textFacPrecio.Name = "textFacPrecio";
            this.textFacPrecio.Size = new System.Drawing.Size(93, 20);
            this.textFacPrecio.TabIndex = 10;
            this.textFacPrecio.TextChanged += new System.EventHandler(this.textFacPrecio_TextChanged);
            // 
            // textFacCantidad
            // 
            this.textFacCantidad.Location = new System.Drawing.Point(111, 106);
            this.textFacCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.textFacCantidad.Name = "textFacCantidad";
            this.textFacCantidad.Size = new System.Drawing.Size(93, 20);
            this.textFacCantidad.TabIndex = 9;
            this.textFacCantidad.TextChanged += new System.EventHandler(this.textFacCantidad_TextChanged);
            // 
            // textIDProducto
            // 
            this.textIDProducto.Location = new System.Drawing.Point(111, 74);
            this.textIDProducto.Margin = new System.Windows.Forms.Padding(2);
            this.textIDProducto.Name = "textIDProducto";
            this.textIDProducto.Size = new System.Drawing.Size(93, 20);
            this.textIDProducto.TabIndex = 8;
            this.textIDProducto.TextChanged += new System.EventHandler(this.textIDProducto_TextChanged);
            // 
            // textIDFacura
            // 
            this.textIDFacura.Location = new System.Drawing.Point(111, 50);
            this.textIDFacura.Margin = new System.Windows.Forms.Padding(2);
            this.textIDFacura.Name = "textIDFacura";
            this.textIDFacura.Size = new System.Drawing.Size(93, 20);
            this.textIDFacura.TabIndex = 7;
            this.textIDFacura.TextChanged += new System.EventHandler(this.textIDFactura_TextChanged);
            // 
            // textIdDetalle
            // 
            this.textIdDetalle.Location = new System.Drawing.Point(111, 18);
            this.textIdDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.textIdDetalle.Name = "textIdDetalle";
            this.textIdDetalle.Size = new System.Drawing.Size(93, 20);
            this.textIdDetalle.TabIndex = 6;
            this.textIdDetalle.TextChanged += new System.EventHandler(this.textIdDetalle_TextChanged);
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
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Factura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id detalle";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // detalle_factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 418);
            this.Controls.Add(this.bdDetalleFactura);
            this.Controls.Add(this.DatosClientes);
            this.Name = "detalle_factura";
            this.Text = "detalle_factura";
            ((System.ComponentModel.ISupportInitialize)(this.bdDetalleFactura)).EndInit();
            this.DatosClientes.ResumeLayout(false);
            this.DatosClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bdDetalleFactura;
        private System.Windows.Forms.GroupBox DatosClientes;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox textFacPrecio;
        private System.Windows.Forms.TextBox textFacCantidad;
        private System.Windows.Forms.TextBox textIDProducto;
        private System.Windows.Forms.TextBox textIDFacura;
        private System.Windows.Forms.TextBox textIdDetalle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}