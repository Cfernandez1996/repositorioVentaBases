namespace CrudDefensa.Clases
{
    partial class Ubicacion
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
            this.dbUbicacion = new System.Windows.Forms.DataGridView();
            this.DatosUbicacion = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textidtienda = new System.Windows.Forms.TextBox();
            this.texttt = new System.Windows.Forms.TextBox();
            this.textubi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbUbicacion)).BeginInit();
            this.DatosUbicacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbUbicacion
            // 
            this.dbUbicacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbUbicacion.Location = new System.Drawing.Point(510, 78);
            this.dbUbicacion.Margin = new System.Windows.Forms.Padding(2);
            this.dbUbicacion.Name = "dbUbicacion";
            this.dbUbicacion.RowHeadersWidth = 51;
            this.dbUbicacion.RowTemplate.Height = 24;
            this.dbUbicacion.Size = new System.Drawing.Size(368, 300);
            this.dbUbicacion.TabIndex = 7;
            // 
            // DatosUbicacion
            // 
            this.DatosUbicacion.Controls.Add(this.btnEliminar);
            this.DatosUbicacion.Controls.Add(this.btnModificar);
            this.DatosUbicacion.Controls.Add(this.btnGuardar);
            this.DatosUbicacion.Controls.Add(this.textidtienda);
            this.DatosUbicacion.Controls.Add(this.texttt);
            this.DatosUbicacion.Controls.Add(this.textubi);
            this.DatosUbicacion.Controls.Add(this.label6);
            this.DatosUbicacion.Controls.Add(this.label3);
            this.DatosUbicacion.Controls.Add(this.label2);
            this.DatosUbicacion.Controls.Add(this.label1);
            this.DatosUbicacion.Location = new System.Drawing.Point(20, 59);
            this.DatosUbicacion.Margin = new System.Windows.Forms.Padding(2);
            this.DatosUbicacion.Name = "DatosUbicacion";
            this.DatosUbicacion.Padding = new System.Windows.Forms.Padding(2);
            this.DatosUbicacion.Size = new System.Drawing.Size(433, 346);
            this.DatosUbicacion.TabIndex = 6;
            this.DatosUbicacion.TabStop = false;
            this.DatosUbicacion.Text = "Datos Ubicacion";
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
            // textidtienda
            // 
            this.textidtienda.Location = new System.Drawing.Point(111, 74);
            this.textidtienda.Margin = new System.Windows.Forms.Padding(2);
            this.textidtienda.Name = "textidtienda";
            this.textidtienda.Size = new System.Drawing.Size(93, 20);
            this.textidtienda.TabIndex = 8;
            // 
            // texttt
            // 
            this.texttt.Location = new System.Drawing.Point(111, 50);
            this.texttt.Margin = new System.Windows.Forms.Padding(2);
            this.texttt.Name = "texttt";
            this.texttt.Size = new System.Drawing.Size(93, 20);
            this.texttt.TabIndex = 7;
            // 
            // textubi
            // 
            this.textubi.Location = new System.Drawing.Point(111, 18);
            this.textubi.Margin = new System.Windows.Forms.Padding(2);
            this.textubi.Name = "textubi";
            this.textubi.Size = new System.Drawing.Size(93, 20);
            this.textubi.TabIndex = 6;
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
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id tienda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo Tiendas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Ubicacion";
            // 
            // Ubicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.dbUbicacion);
            this.Controls.Add(this.DatosUbicacion);
            this.Name = "Ubicacion";
            this.Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)(this.dbUbicacion)).EndInit();
            this.DatosUbicacion.ResumeLayout(false);
            this.DatosUbicacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dbUbicacion;
        private System.Windows.Forms.GroupBox DatosUbicacion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox textidtienda;
        private System.Windows.Forms.TextBox texttt;
        private System.Windows.Forms.TextBox textubi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}