namespace CrudDefensa.Clases
{
    partial class Empleados
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
            this.bdEmpleados = new System.Windows.Forms.DataGridView();
            this.DatosClientes = new System.Windows.Forms.GroupBox();
            this.txtid_empleado = new System.Windows.Forms.TextBox();
            this.salario = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtSegundoApellidos = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdEmpleados)).BeginInit();
            this.DatosClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // bdEmpleados
            // 
            this.bdEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bdEmpleados.Location = new System.Drawing.Point(497, 59);
            this.bdEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.bdEmpleados.Name = "bdEmpleados";
            this.bdEmpleados.RowHeadersWidth = 51;
            this.bdEmpleados.RowTemplate.Height = 24;
            this.bdEmpleados.Size = new System.Drawing.Size(368, 300);
            this.bdEmpleados.TabIndex = 3;
            this.bdEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bdEmpleados_CellContentClick);
            // 
            // DatosClientes
            // 
            this.DatosClientes.Controls.Add(this.txtSalario);
            this.DatosClientes.Controls.Add(this.label10);
            this.DatosClientes.Controls.Add(this.txtid_empleado);
            this.DatosClientes.Controls.Add(this.salario);
            this.DatosClientes.Controls.Add(this.txtTelefono);
            this.DatosClientes.Controls.Add(this.txtGenero);
            this.DatosClientes.Controls.Add(this.txtEdad);
            this.DatosClientes.Controls.Add(this.label7);
            this.DatosClientes.Controls.Add(this.label8);
            this.DatosClientes.Controls.Add(this.label9);
            this.DatosClientes.Controls.Add(this.btnEliminar);
            this.DatosClientes.Controls.Add(this.btnModificar);
            this.DatosClientes.Controls.Add(this.btnGuardar);
            this.DatosClientes.Controls.Add(this.txtDNI);
            this.DatosClientes.Controls.Add(this.txtSegundoApellidos);
            this.DatosClientes.Controls.Add(this.txtPrimerApellido);
            this.DatosClientes.Controls.Add(this.txtSegundoNombre);
            this.DatosClientes.Controls.Add(this.txtPrimerNombre);
            this.DatosClientes.Controls.Add(this.label6);
            this.DatosClientes.Controls.Add(this.label5);
            this.DatosClientes.Controls.Add(this.label4);
            this.DatosClientes.Controls.Add(this.label3);
            this.DatosClientes.Controls.Add(this.label2);
            this.DatosClientes.Controls.Add(this.label1);
            this.DatosClientes.Location = new System.Drawing.Point(42, 75);
            this.DatosClientes.Margin = new System.Windows.Forms.Padding(2);
            this.DatosClientes.Name = "DatosClientes";
            this.DatosClientes.Padding = new System.Windows.Forms.Padding(2);
            this.DatosClientes.Size = new System.Drawing.Size(433, 420);
            this.DatosClientes.TabIndex = 2;
            this.DatosClientes.TabStop = false;
            this.DatosClientes.Text = "Datos Empleados";
            this.DatosClientes.Enter += new System.EventHandler(this.DatosClientes_Enter);
            // 
            // txtid_empleado
            // 
            this.txtid_empleado.Location = new System.Drawing.Point(113, 264);
            this.txtid_empleado.Margin = new System.Windows.Forms.Padding(2);
            this.txtid_empleado.Name = "txtid_empleado";
            this.txtid_empleado.Size = new System.Drawing.Size(93, 20);
            this.txtid_empleado.TabIndex = 27;
            // 
            // salario
            // 
            this.salario.AutoSize = true;
            this.salario.Location = new System.Drawing.Point(6, 267);
            this.salario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.salario.Name = "salario";
            this.salario.Size = new System.Drawing.Size(65, 13);
            this.salario.TabIndex = 26;
            this.salario.Text = "id Empleado";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(113, 232);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(93, 20);
            this.txtTelefono.TabIndex = 19;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(113, 203);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(2);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(93, 20);
            this.txtGenero.TabIndex = 18;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(113, 171);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(2);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(93, 20);
            this.txtEdad.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 239);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 206);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Genero";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 174);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Edad";
            this.label9.Click += new System.EventHandler(this.label9_Click);
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
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(111, 135);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(2);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(93, 20);
            this.txtDNI.TabIndex = 10;
            // 
            // txtSegundoApellidos
            // 
            this.txtSegundoApellidos.Location = new System.Drawing.Point(111, 106);
            this.txtSegundoApellidos.Margin = new System.Windows.Forms.Padding(2);
            this.txtSegundoApellidos.Name = "txtSegundoApellidos";
            this.txtSegundoApellidos.Size = new System.Drawing.Size(93, 20);
            this.txtSegundoApellidos.TabIndex = 9;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Location = new System.Drawing.Point(111, 74);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(93, 20);
            this.txtPrimerApellido.TabIndex = 8;
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Location = new System.Drawing.Point(111, 50);
            this.txtSegundoNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(93, 20);
            this.txtSegundoNombre.TabIndex = 7;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Location = new System.Drawing.Point(111, 18);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(93, 20);
            this.txtPrimerNombre.TabIndex = 6;
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
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "DNI: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "segundo apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Primer apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Segundo Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primer Nombre";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(113, 288);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(93, 20);
            this.txtSalario.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 291);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Salario";
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 506);
            this.Controls.Add(this.bdEmpleados);
            this.Controls.Add(this.DatosClientes);
            this.Name = "Empleados";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdEmpleados)).EndInit();
            this.DatosClientes.ResumeLayout(false);
            this.DatosClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bdEmpleados;
        private System.Windows.Forms.GroupBox DatosClientes;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtSegundoApellidos;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtid_empleado;
        private System.Windows.Forms.Label salario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label10;
    }
}