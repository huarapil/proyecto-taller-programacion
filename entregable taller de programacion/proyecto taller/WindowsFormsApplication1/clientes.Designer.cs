namespace WindowsFormsApplication1
{
    partial class Clientes
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label7 = new System.Windows.Forms.Label();
            this.Rut = new System.Windows.Forms.TextBox();
            this.Btningresocliente = new System.Windows.Forms.Button();
            this.Dv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.titulo_clientes = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Lista_profesion = new System.Windows.Forms.ComboBox();
            this.Sueldo_cliente = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Apellido2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Apellido1 = new System.Windows.Forms.TextBox();
            this.Fechanacimiento = new System.Windows.Forms.Label();
            this.Fecha_nacimiento = new System.Windows.Forms.TextBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Datos_clientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datos_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(9, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Rut";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Rut
            // 
            this.Rut.Location = new System.Drawing.Point(12, 167);
            this.Rut.MaxLength = 10;
            this.Rut.Name = "Rut";
            this.Rut.Size = new System.Drawing.Size(88, 20);
            this.Rut.TabIndex = 13;
            this.Rut.Click += new System.EventHandler(this.textBox6_Click);
            this.Rut.TextChanged += new System.EventHandler(this.rut_TextChanged);
            this.Rut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rut_KeyPress);
            // 
            // Btningresocliente
            // 
            this.Btningresocliente.AutoSize = true;
            this.Btningresocliente.Location = new System.Drawing.Point(327, 246);
            this.Btningresocliente.Name = "Btningresocliente";
            this.Btningresocliente.Size = new System.Drawing.Size(135, 23);
            this.Btningresocliente.TabIndex = 14;
            this.Btningresocliente.Text = "Ingresar datos del cliente";
            this.Btningresocliente.UseVisualStyleBackColor = true;
            this.Btningresocliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dv
            // 
            this.Dv.Location = new System.Drawing.Point(113, 167);
            this.Dv.MaxLength = 1;
            this.Dv.Name = "Dv";
            this.Dv.Size = new System.Drawing.Size(26, 20);
            this.Dv.TabIndex = 15;
            this.Dv.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            this.Dv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            this.Dv.Leave += new System.EventHandler(this.dv_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(110, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "DV";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // titulo_clientes
            // 
            this.titulo_clientes.BackColor = System.Drawing.Color.IndianRed;
            this.titulo_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_clientes.ForeColor = System.Drawing.Color.White;
            this.titulo_clientes.Location = new System.Drawing.Point(-8, -1);
            this.titulo_clientes.Name = "titulo_clientes";
            this.titulo_clientes.Size = new System.Drawing.Size(632, 34);
            this.titulo_clientes.TabIndex = 18;
            this.titulo_clientes.Text = "Ingrese los datos del cliente  ";
            this.titulo_clientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titulo_clientes.Click += new System.EventHandler(this.titulo_clientes_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(15, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Profesion";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Lista_profesion
            // 
            this.Lista_profesion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Lista_profesion.FormattingEnabled = true;
            this.Lista_profesion.Location = new System.Drawing.Point(15, 288);
            this.Lista_profesion.Name = "Lista_profesion";
            this.Lista_profesion.Size = new System.Drawing.Size(211, 21);
            this.Lista_profesion.TabIndex = 22;
            this.Lista_profesion.SelectedIndexChanged += new System.EventHandler(this.lista_profesion_SelectedIndexChanged);
            // 
            // Sueldo_cliente
            // 
            this.Sueldo_cliente.Location = new System.Drawing.Point(15, 249);
            this.Sueldo_cliente.Name = "Sueldo_cliente";
            this.Sueldo_cliente.Size = new System.Drawing.Size(166, 20);
            this.Sueldo_cliente.TabIndex = 24;
            this.Sueldo_cliente.TextChanged += new System.EventHandler(this.sueldo_cliente_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Sueldo liquido";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(12, 49);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(133, 20);
            this.Nombre.TabIndex = 31;
            this.Nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Apellido 1";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // Apellido2
            // 
            this.Apellido2.Location = new System.Drawing.Point(12, 128);
            this.Apellido2.Name = "Apellido2";
            this.Apellido2.Size = new System.Drawing.Size(136, 20);
            this.Apellido2.TabIndex = 28;
            this.Apellido2.TextChanged += new System.EventHandler(this.apellido2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(9, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Apellido 2";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // Apellido1
            // 
            this.Apellido1.Location = new System.Drawing.Point(12, 89);
            this.Apellido1.Name = "Apellido1";
            this.Apellido1.Size = new System.Drawing.Size(136, 20);
            this.Apellido1.TabIndex = 33;
            this.Apellido1.TextChanged += new System.EventHandler(this.apellido1_TextChanged);
            // 
            // Fechanacimiento
            // 
            this.Fechanacimiento.AutoSize = true;
            this.Fechanacimiento.ForeColor = System.Drawing.Color.Blue;
            this.Fechanacimiento.Location = new System.Drawing.Point(12, 194);
            this.Fechanacimiento.Name = "Fechanacimiento";
            this.Fechanacimiento.Size = new System.Drawing.Size(161, 13);
            this.Fechanacimiento.TabIndex = 35;
            this.Fechanacimiento.Text = "Fecha nacimiento (año/dia/mes)";
            this.Fechanacimiento.Click += new System.EventHandler(this.Fechanacimiento_Click);
            // 
            // Fecha_nacimiento
            // 
            this.Fecha_nacimiento.Location = new System.Drawing.Point(15, 210);
            this.Fecha_nacimiento.Name = "Fecha_nacimiento";
            this.Fecha_nacimiento.Size = new System.Drawing.Size(166, 20);
            this.Fecha_nacimiento.TabIndex = 34;
            this.Fecha_nacimiento.TextChanged += new System.EventHandler(this.fecha_nacimiento_TextChanged);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            // 
            // Datos_clientes
            // 
            this.Datos_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datos_clientes.Location = new System.Drawing.Point(204, 36);
            this.Datos_clientes.Name = "Datos_clientes";
            this.Datos_clientes.RowHeadersWidth = 47;
            this.Datos_clientes.Size = new System.Drawing.Size(388, 181);
            this.Datos_clientes.TabIndex = 36;
            this.Datos_clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datos_clientes_CellContentClick);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(616, 344);
            this.Controls.Add(this.Datos_clientes);
            this.Controls.Add(this.Fechanacimiento);
            this.Controls.Add(this.Fecha_nacimiento);
            this.Controls.Add(this.Apellido1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Apellido2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sueldo_cliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Lista_profesion);
            this.Controls.Add(this.titulo_clientes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Dv);
            this.Controls.Add(this.Btningresocliente);
            this.Controls.Add(this.Rut);
            this.Controls.Add(this.label7);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de clientes";
            this.Load += new System.EventHandler(this.clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datos_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Rut;
        private System.Windows.Forms.Button Btningresocliente;
        private System.Windows.Forms.TextBox Dv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label titulo_clientes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Lista_profesion;
        private System.Windows.Forms.TextBox Sueldo_cliente;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Apellido2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Apellido1;
        private System.Windows.Forms.Label Fechanacimiento;
        private System.Windows.Forms.TextBox Fecha_nacimiento;
  
        private System.Windows.Forms.BindingSource clienteBindingSource;
        
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridView Datos_clientes;
    }
}

