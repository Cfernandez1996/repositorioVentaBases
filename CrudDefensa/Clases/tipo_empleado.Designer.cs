namespace CrudDefensa.Clases
{
    partial class tipo_empleado
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
            this.bdTipoEmpleado = new System.Windows.Forms.DataGridView();
            this.DatosTP = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textdesc = new System.Windows.Forms.TextBox();
            this.textidtp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdTipoEmpleado)).BeginInit();
            this.DatosTP.SuspendLayout();
            this.SuspendLayout();
            // 
            // bdTipoEmpleado
            // 
            this.bdTipoEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bdTipoEmpleado.Location = new System.Drawing.Point(589, 71);
            this.bdTipoEmpleado.Name = "bdTipoEmpleado";
            this.bdTipoEmpleado.Size = new System.Drawing.Size(325, 284);
            this.bdTipoEmpleado.TabIndex = 7;
            // 
            // DatosTP
            // 
            this.DatosTP.Controls.Add(this.btnEliminar);
            this.DatosTP.Controls.Add(this.btnModificar);
            this.DatosTP.Controls.Add(this.btnGuardar);
            this.DatosTP.Controls.Add(this.textdesc);
            this.DatosTP.Controls.Add(this.textidtp);
            this.DatosTP.Controls.Add(this.label2);
            this.DatosTP.Controls.Add(this.label1);
            this.DatosTP.Location = new System.Drawing.Point(58, 53);
            this.DatosTP.Margin = new System.Windows.Forms.Padding(2);
            this.DatosTP.Name = "DatosTP";
            this.DatosTP.Padding = new System.Windows.Forms.Padding(2);
            this.DatosTP.Size = new System.Drawing.Size(433, 346);
            this.DatosTP.TabIndex = 6;
            this.DatosTP.TabStop = false;
            this.DatosTP.Text = "Datos Tipo Empleado";
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
            // textdesc
            // 
            this.textdesc.Location = new System.Drawing.Point(111, 50);
            this.textdesc.Margin = new System.Windows.Forms.Padding(2);
            this.textdesc.Name = "textdesc";
            this.textdesc.Size = new System.Drawing.Size(93, 20);
            this.textdesc.TabIndex = 7;
            // 
            // textidtp
            // 
            this.textidtp.Location = new System.Drawing.Point(111, 18);
            this.textidtp.Margin = new System.Windows.Forms.Padding(2);
            this.textidtp.Name = "textidtp";
            this.textidtp.Size = new System.Drawing.Size(93, 20);
            this.textidtp.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
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
            // tipo_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 450);
            this.Controls.Add(this.bdTipoEmpleado);
            this.Controls.Add(this.DatosTP);
            this.Name = "tipo_empleado";
            this.Text = "tipo_empleado";
            ((System.ComponentModel.ISupportInitialize)(this.bdTipoEmpleado)).EndInit();
            this.DatosTP.ResumeLayout(false);
            this.DatosTP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bdTipoEmpleado;
        private System.Windows.Forms.GroupBox DatosTP;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox textdesc;
        private System.Windows.Forms.TextBox textidtp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}