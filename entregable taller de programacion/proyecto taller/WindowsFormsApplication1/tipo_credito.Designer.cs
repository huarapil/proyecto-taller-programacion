namespace WindowsFormsApplication1
{
    partial class tipo_credito
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
            this.Ingresar_credito = new System.Windows.Forms.Button();
            this.texto_creditos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre_credito = new System.Windows.Forms.TextBox();
            this.Codigo_credito = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tasa_interes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Sueldo_minimo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Monto_maximo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Monto_minimo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Edad_maxima = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ingresar_credito
            // 
            this.Ingresar_credito.AutoSize = true;
            this.Ingresar_credito.BackColor = System.Drawing.Color.Brown;
            this.Ingresar_credito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingresar_credito.ForeColor = System.Drawing.Color.White;
            this.Ingresar_credito.Location = new System.Drawing.Point(213, 260);
            this.Ingresar_credito.Name = "Ingresar_credito";
            this.Ingresar_credito.Size = new System.Drawing.Size(204, 30);
            this.Ingresar_credito.TabIndex = 6;
            this.Ingresar_credito.Text = "ingresar tipo de credito";
            this.Ingresar_credito.UseVisualStyleBackColor = false;
            this.Ingresar_credito.Click += new System.EventHandler(this.ingresar_sueldo_cliente_Click);
            // 
            // texto_creditos
            // 
            this.texto_creditos.AutoSize = true;
            this.texto_creditos.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.texto_creditos.ForeColor = System.Drawing.Color.Brown;
            this.texto_creditos.Location = new System.Drawing.Point(95, 56);
            this.texto_creditos.Name = "texto_creditos";
            this.texto_creditos.Size = new System.Drawing.Size(288, 26);
            this.texto_creditos.TabIndex = 7;
            this.texto_creditos.Text = "ingresar dato de los creditos ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre credito";
            // 
            // Nombre_credito
            // 
            this.Nombre_credito.Location = new System.Drawing.Point(45, 129);
            this.Nombre_credito.Name = "Nombre_credito";
            this.Nombre_credito.Size = new System.Drawing.Size(122, 20);
            this.Nombre_credito.TabIndex = 9;
            this.Nombre_credito.TextChanged += new System.EventHandler(this.Nombre_credito_TextChanged);
            // 
            // Codigo_credito
            // 
            this.Codigo_credito.Location = new System.Drawing.Point(45, 168);
            this.Codigo_credito.MaxLength = 5;
            this.Codigo_credito.Name = "Codigo_credito";
            this.Codigo_credito.Size = new System.Drawing.Size(122, 20);
            this.Codigo_credito.TabIndex = 11;
            this.Codigo_credito.TextChanged += new System.EventHandler(this.Codigo_credito_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Codigo";
            // 
            // Tasa_interes
            // 
            this.Tasa_interes.Location = new System.Drawing.Point(45, 207);
            this.Tasa_interes.Name = "Tasa_interes";
            this.Tasa_interes.Size = new System.Drawing.Size(122, 20);
            this.Tasa_interes.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tasa de interes";
            // 
            // Sueldo_minimo
            // 
            this.Sueldo_minimo.Location = new System.Drawing.Point(268, 207);
            this.Sueldo_minimo.Name = "Sueldo_minimo";
            this.Sueldo_minimo.Size = new System.Drawing.Size(122, 20);
            this.Sueldo_minimo.TabIndex = 19;
            this.Sueldo_minimo.TextChanged += new System.EventHandler(this.Sueldo_minimo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Sueldo minimo";
            // 
            // Monto_maximo
            // 
            this.Monto_maximo.Location = new System.Drawing.Point(268, 168);
            this.Monto_maximo.Name = "Monto_maximo";
            this.Monto_maximo.Size = new System.Drawing.Size(122, 20);
            this.Monto_maximo.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Monto maximo";
            // 
            // Monto_minimo
            // 
            this.Monto_minimo.Location = new System.Drawing.Point(268, 129);
            this.Monto_minimo.Name = "Monto_minimo";
            this.Monto_minimo.Size = new System.Drawing.Size(122, 20);
            this.Monto_minimo.TabIndex = 15;
            this.Monto_minimo.TextChanged += new System.EventHandler(this.Monto_minimo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 14;
            // 
            // Edad_maxima
            // 
            this.Edad_maxima.Location = new System.Drawing.Point(45, 246);
            this.Edad_maxima.Name = "Edad_maxima";
            this.Edad_maxima.Size = new System.Drawing.Size(122, 20);
            this.Edad_maxima.TabIndex = 21;
            this.Edad_maxima.TextChanged += new System.EventHandler(this.Edad_maxima_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Edad maxima";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(265, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Monto minimo";
            // 
            // tipo_credito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(496, 383);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Edad_maxima);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Sueldo_minimo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Monto_maximo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Monto_minimo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Tasa_interes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Codigo_credito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre_credito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texto_creditos);
            this.Controls.Add(this.Ingresar_credito);
            this.Name = "tipo_credito";
            this.Text = "Ingreso de tipos de creditos";
            this.Load += new System.EventHandler(this.tipo_credito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Ingresar_credito;
        private System.Windows.Forms.Label texto_creditos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nombre_credito;
        private System.Windows.Forms.TextBox Codigo_credito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tasa_interes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Sueldo_minimo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Monto_maximo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Monto_minimo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Edad_maxima;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}