﻿namespace CrudDefensa.Clases
{
    partial class proveedor
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
            this.bdProveedor = new System.Windows.Forms.DataGridView();
            this.DatosProveedor = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.textIdProv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdProveedor)).BeginInit();
            this.DatosProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // bdProveedor
            // 
            this.bdProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bdProveedor.Location = new System.Drawing.Point(391, 76);
            this.bdProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.bdProveedor.Name = "bdProveedor";
            this.bdProveedor.RowHeadersWidth = 51;
            this.bdProveedor.RowTemplate.Height = 24;
            this.bdProveedor.Size = new System.Drawing.Size(368, 300);
            this.bdProveedor.TabIndex = 3;
            // 
            // DatosProveedor
            // 
            this.DatosProveedor.Controls.Add(this.btnEliminar);
            this.DatosProveedor.Controls.Add(this.btnModificar);
            this.DatosProveedor.Controls.Add(this.btnGuardar);
            this.DatosProveedor.Controls.Add(this.textnombre);
            this.DatosProveedor.Controls.Add(this.textIdProv);
            this.DatosProveedor.Controls.Add(this.label6);
            this.DatosProveedor.Controls.Add(this.label2);
            this.DatosProveedor.Controls.Add(this.label1);
            this.DatosProveedor.Location = new System.Drawing.Point(42, 75);
            this.DatosProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.DatosProveedor.Name = "DatosProveedor";
            this.DatosProveedor.Padding = new System.Windows.Forms.Padding(2);
            this.DatosProveedor.Size = new System.Drawing.Size(314, 256);
            this.DatosProveedor.TabIndex = 2;
            this.DatosProveedor.TabStop = false;
            this.DatosProveedor.Text = "Datos Proveedor";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(100, 206);
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
            this.btnModificar.Location = new System.Drawing.Point(14, 206);
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
            this.btnGuardar.Location = new System.Drawing.Point(188, 206);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // textnombre
            // 
            this.textnombre.Location = new System.Drawing.Point(200, 43);
            this.textnombre.Margin = new System.Windows.Forms.Padding(2);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(93, 20);
            this.textnombre.TabIndex = 7;
            // 
            // textIdProv
            // 
            this.textIdProv.Location = new System.Drawing.Point(200, 15);
            this.textIdProv.Margin = new System.Windows.Forms.Padding(2);
            this.textIdProv.Name = "textIdProv";
            this.textIdProv.Size = new System.Drawing.Size(93, 20);
            this.textIdProv.TabIndex = 6;
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
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id proveedor";
            // 
            // proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bdProveedor);
            this.Controls.Add(this.DatosProveedor);
            this.Name = "proveedor";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdProveedor)).EndInit();
            this.DatosProveedor.ResumeLayout(false);
            this.DatosProveedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bdProveedor;
        private System.Windows.Forms.GroupBox DatosProveedor;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.TextBox textIdProv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}