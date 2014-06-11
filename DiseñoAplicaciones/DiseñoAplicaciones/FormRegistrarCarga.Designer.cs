namespace InterfazGrafica
{
    partial class FormRegistrarCarga
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
            this.comboUsuarios = new System.Windows.Forms.ComboBox();
            this.comboClientes = new System.Windows.Forms.ComboBox();
            this.comboVehiculos = new System.Windows.Forms.ComboBox();
            this.comboSurtidor = new System.Windows.Forms.ComboBox();
            this.comboManguera = new System.Windows.Forms.ComboBox();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.listaCargasRealizadas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonRealizarCarga = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboUsuarios
            // 
            this.comboUsuarios.FormattingEnabled = true;
            this.comboUsuarios.Location = new System.Drawing.Point(71, 12);
            this.comboUsuarios.Name = "comboUsuarios";
            this.comboUsuarios.Size = new System.Drawing.Size(172, 21);
            this.comboUsuarios.TabIndex = 0;
            this.comboUsuarios.SelectedIndexChanged += new System.EventHandler(this.comboUsuarios_SelectedIndexChanged);
            // 
            // comboClientes
            // 
            this.comboClientes.FormattingEnabled = true;
            this.comboClientes.Location = new System.Drawing.Point(593, 120);
            this.comboClientes.Name = "comboClientes";
            this.comboClientes.Size = new System.Drawing.Size(174, 21);
            this.comboClientes.TabIndex = 1;
            this.comboClientes.SelectedIndexChanged += new System.EventHandler(this.comboClientes_SelectedIndexChanged_1);
            // 
            // comboVehiculos
            // 
            this.comboVehiculos.FormattingEnabled = true;
            this.comboVehiculos.Location = new System.Drawing.Point(593, 157);
            this.comboVehiculos.Name = "comboVehiculos";
            this.comboVehiculos.Size = new System.Drawing.Size(174, 21);
            this.comboVehiculos.TabIndex = 2;
            // 
            // comboSurtidor
            // 
            this.comboSurtidor.FormattingEnabled = true;
            this.comboSurtidor.Location = new System.Drawing.Point(593, 190);
            this.comboSurtidor.Name = "comboSurtidor";
            this.comboSurtidor.Size = new System.Drawing.Size(174, 21);
            this.comboSurtidor.TabIndex = 3;
            this.comboSurtidor.SelectedIndexChanged += new System.EventHandler(this.comboSurtidor_SelectedIndexChanged);
            // 
            // comboManguera
            // 
            this.comboManguera.FormattingEnabled = true;
            this.comboManguera.Location = new System.Drawing.Point(593, 228);
            this.comboManguera.Name = "comboManguera";
            this.comboManguera.Size = new System.Drawing.Size(174, 21);
            this.comboManguera.TabIndex = 4;
            this.comboManguera.SelectedIndexChanged += new System.EventHandler(this.comboManguera_SelectedIndexChanged);
            // 
            // textNumero
            // 
            this.textNumero.Location = new System.Drawing.Point(593, 85);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(121, 20);
            this.textNumero.TabIndex = 5;
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(593, 265);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(121, 20);
            this.textCantidad.TabIndex = 6;
            // 
            // listaCargasRealizadas
            // 
            this.listaCargasRealizadas.FormattingEnabled = true;
            this.listaCargasRealizadas.Location = new System.Drawing.Point(25, 70);
            this.listaCargasRealizadas.Name = "listaCargasRealizadas";
            this.listaCargasRealizadas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listaCargasRealizadas.Size = new System.Drawing.Size(361, 290);
            this.listaCargasRealizadas.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cargas Realizadas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Vehiculo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Surtidor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Manguera";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Numero de carga";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(420, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cantidad de combustible";
            // 
            // buttonRealizarCarga
            // 
            this.buttonRealizarCarga.Location = new System.Drawing.Point(671, 312);
            this.buttonRealizarCarga.Name = "buttonRealizarCarga";
            this.buttonRealizarCarga.Size = new System.Drawing.Size(95, 35);
            this.buttonRealizarCarga.TabIndex = 16;
            this.buttonRealizarCarga.Text = "Registrar carga";
            this.buttonRealizarCarga.UseVisualStyleBackColor = true;
            this.buttonRealizarCarga.Click += new System.EventHandler(this.buttonRealizarCarga_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(310, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "lts";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(410, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 227);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(477, 312);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(87, 35);
            this.buttonSalir.TabIndex = 19;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // FormRegistrarCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 373);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonRealizarCarga);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaCargasRealizadas);
            this.Controls.Add(this.textCantidad);
            this.Controls.Add(this.textNumero);
            this.Controls.Add(this.comboManguera);
            this.Controls.Add(this.comboSurtidor);
            this.Controls.Add(this.comboVehiculos);
            this.Controls.Add(this.comboClientes);
            this.Controls.Add(this.comboUsuarios);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRegistrarCarga";
            this.Text = "Registrar Carga";
            this.Load += new System.EventHandler(this.FormRegistrarCarga_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboUsuarios;
        private System.Windows.Forms.ComboBox comboClientes;
        private System.Windows.Forms.ComboBox comboVehiculos;
        private System.Windows.Forms.ComboBox comboSurtidor;
        private System.Windows.Forms.ComboBox comboManguera;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.ListBox listaCargasRealizadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonRealizarCarga;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSalir;
    }
}