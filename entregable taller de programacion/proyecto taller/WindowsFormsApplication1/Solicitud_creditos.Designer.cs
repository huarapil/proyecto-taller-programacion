namespace WindowsFormsApplication1
{
    partial class Solicitud_creditos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Plazo_credito = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Monto_credito = new System.Windows.Forms.TextBox();
            this.Nombre_credito = new System.Windows.Forms.ComboBox();
            this.Rut_cliente = new System.Windows.Forms.TextBox();
            this.Dv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Ingresar_solicitud = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(127, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingereso de solicitud de creditos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rut cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre de credito ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pazo en años";
            // 
            // Plazo_credito
            // 
            this.Plazo_credito.Location = new System.Drawing.Point(315, 89);
            this.Plazo_credito.Name = "Plazo_credito";
            this.Plazo_credito.Size = new System.Drawing.Size(165, 20);
            this.Plazo_credito.TabIndex = 5;
            this.Plazo_credito.TextChanged += new System.EventHandler(this.plazo_credito_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Monto del credito";
            // 
            // Monto_credito
            // 
            this.Monto_credito.Location = new System.Drawing.Point(315, 137);
            this.Monto_credito.Name = "Monto_credito";
            this.Monto_credito.Size = new System.Drawing.Size(165, 20);
            this.Monto_credito.TabIndex = 7;
            this.Monto_credito.TextChanged += new System.EventHandler(this.monto_credito_TextChanged);
            // 
            // Nombre_credito
            // 
            this.Nombre_credito.FormattingEnabled = true;
            this.Nombre_credito.Location = new System.Drawing.Point(51, 137);
            this.Nombre_credito.Name = "Nombre_credito";
            this.Nombre_credito.Size = new System.Drawing.Size(165, 21);
            this.Nombre_credito.TabIndex = 9;
            this.Nombre_credito.SelectedIndexChanged += new System.EventHandler(this.nombre_credito_SelectedIndexChanged_1);
            // 
            // Rut_cliente
            // 
            this.Rut_cliente.Location = new System.Drawing.Point(51, 89);
            this.Rut_cliente.MaxLength = 10;
            this.Rut_cliente.Name = "Rut_cliente";
            this.Rut_cliente.Size = new System.Drawing.Size(123, 20);
            this.Rut_cliente.TabIndex = 10;
            this.Rut_cliente.TextChanged += new System.EventHandler(this.rut_cliente_TextChanged);
            // 
            // Dv
            // 
            this.Dv.Location = new System.Drawing.Point(180, 89);
            this.Dv.MaxLength = 1;
            this.Dv.Name = "Dv";
            this.Dv.Size = new System.Drawing.Size(36, 20);
            this.Dv.TabIndex = 11;
            this.Dv.TextChanged += new System.EventHandler(this.dv_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "DV";
            // 
            // Ingresar_solicitud
            // 
            this.Ingresar_solicitud.Location = new System.Drawing.Point(315, 176);
            this.Ingresar_solicitud.Name = "Ingresar_solicitud";
            this.Ingresar_solicitud.Size = new System.Drawing.Size(165, 33);
            this.Ingresar_solicitud.TabIndex = 13;
            this.Ingresar_solicitud.Text = "Ingrresar solicitud de credito";
            this.Ingresar_solicitud.UseVisualStyleBackColor = true;
            this.Ingresar_solicitud.Click += new System.EventHandler(this.ingresar_solicitud_Click);
            // 
            // Codigo
            // 
            this.Codigo.FormattingEnabled = true;
            this.Codigo.Location = new System.Drawing.Point(51, 183);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(165, 21);
            this.Codigo.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Codigo de credito ";
            // 
            // Solicitud_creditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 346);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.Ingresar_solicitud);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Dv);
            this.Controls.Add(this.Rut_cliente);
            this.Controls.Add(this.Nombre_credito);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Monto_credito);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Plazo_credito);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Solicitud_creditos";
            this.Text = "Gestion de creditos";
            this.Load += new System.EventHandler(this.Solicitud_creditos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Plazo_credito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Monto_credito;
        private System.Windows.Forms.ComboBox Nombre_credito;
        private System.Windows.Forms.TextBox Rut_cliente;
        private System.Windows.Forms.TextBox Dv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Ingresar_solicitud;
        private System.Windows.Forms.ComboBox Codigo;
        private System.Windows.Forms.Label label7;
    }
}