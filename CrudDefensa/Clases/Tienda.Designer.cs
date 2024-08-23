namespace CrudDefensa.Clases
{
    partial class Tienda
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
            this.dbTienda = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdTienda = new System.Windows.Forms.TextBox();
            this.txtNombreTienda = new System.Windows.Forms.TextBox();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.DatosClientes = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbTienda)).BeginInit();
            this.DatosClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbTienda
            // 
            this.dbTienda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbTienda.Location = new System.Drawing.Point(513, 70);
            this.dbTienda.Margin = new System.Windows.Forms.Padding(2);
            this.dbTienda.Name = "dbTienda";
            this.dbTienda.RowHeadersWidth = 51;
            this.dbTienda.RowTemplate.Height = 24;
            this.dbTienda.Size = new System.Drawing.Size(368, 300);
            this.dbTienda.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id tienda";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horario";
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
            // txtIdTienda
            // 
            this.txtIdTienda.Location = new System.Drawing.Point(111, 18);
            this.txtIdTienda.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdTienda.Name = "txtIdTienda";
            this.txtIdTienda.Size = new System.Drawing.Size(93, 20);
            this.txtIdTienda.TabIndex = 6;
            // 
            // txtNombreTienda
            // 
            this.txtNombreTienda.Location = new System.Drawing.Point(111, 50);
            this.txtNombreTienda.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreTienda.Name = "txtNombreTienda";
            this.txtNombreTienda.Size = new System.Drawing.Size(93, 20);
            this.txtNombreTienda.TabIndex = 7;
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(111, 74);
            this.txtHorario.Margin = new System.Windows.Forms.Padding(2);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(93, 20);
            this.txtHorario.TabIndex = 8;
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
            // DatosClientes
            // 
            this.DatosClientes.Controls.Add(this.btnEliminar);
            this.DatosClientes.Controls.Add(this.btnModificar);
            this.DatosClientes.Controls.Add(this.btnGuardar);
            this.DatosClientes.Controls.Add(this.txtHorario);
            this.DatosClientes.Controls.Add(this.txtNombreTienda);
            this.DatosClientes.Controls.Add(this.txtIdTienda);
            this.DatosClientes.Controls.Add(this.label6);
            this.DatosClientes.Controls.Add(this.label3);
            this.DatosClientes.Controls.Add(this.label2);
            this.DatosClientes.Controls.Add(this.label1);
            this.DatosClientes.Location = new System.Drawing.Point(23, 51);
            this.DatosClientes.Margin = new System.Windows.Forms.Padding(2);
            this.DatosClientes.Name = "DatosClientes";
            this.DatosClientes.Padding = new System.Windows.Forms.Padding(2);
            this.DatosClientes.Size = new System.Drawing.Size(433, 346);
            this.DatosClientes.TabIndex = 8;
            this.DatosClientes.TabStop = false;
            this.DatosClientes.Text = "Datos Clientes";
            // 
            // Tienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 450);
            this.Controls.Add(this.dbTienda);
            this.Controls.Add(this.DatosClientes);
            this.Name = "Tienda";
            this.Text = "Form10";
            ((System.ComponentModel.ISupportInitialize)(this.dbTienda)).EndInit();
            this.DatosClientes.ResumeLayout(false);
            this.DatosClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dbTienda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdTienda;
        private System.Windows.Forms.TextBox txtNombreTienda;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox DatosClientes;
    }
}