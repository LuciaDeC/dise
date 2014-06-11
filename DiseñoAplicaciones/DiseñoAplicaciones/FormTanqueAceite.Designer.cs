namespace InterfazGrafica
{
    partial class FormTanqueAceite
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
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.textCapacidad = new System.Windows.Forms.TextBox();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listaTanques = new System.Windows.Forms.ListBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.textBoxViscosidad = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(465, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "Tanque de Aceite";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(566, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 35);
            this.button1.TabIndex = 32;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(116, 311);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 29);
            this.btnEliminar.TabIndex = 33;
            this.btnEliminar.Text = "Eliminar Seleccionado";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxViscosidad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textDescripcion);
            this.groupBox1.Controls.Add(this.textCapacidad);
            this.groupBox1.Controls.Add(this.textNumero);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(400, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 198);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "lts";
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(138, 66);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(169, 20);
            this.textDescripcion.TabIndex = 6;
            // 
            // textCapacidad
            // 
            this.textCapacidad.Location = new System.Drawing.Point(142, 107);
            this.textCapacidad.Name = "textCapacidad";
            this.textCapacidad.Size = new System.Drawing.Size(130, 20);
            this.textCapacidad.TabIndex = 5;
            // 
            // textNumero
            // 
            this.textNumero.Location = new System.Drawing.Point(138, 32);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(169, 20);
            this.textNumero.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Viscosidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Capacidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Tanque:";
            // 
            // listaTanques
            // 
            this.listaTanques.FormattingEnabled = true;
            this.listaTanques.HorizontalScrollbar = true;
            this.listaTanques.Location = new System.Drawing.Point(13, 46);
            this.listaTanques.Name = "listaTanques";
            this.listaTanques.ScrollAlwaysVisible = true;
            this.listaTanques.Size = new System.Drawing.Size(365, 238);
            this.listaTanques.TabIndex = 29;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AccessibleDescription = "";
            this.btnRegistrar.AccessibleName = "";
            this.btnRegistrar.Location = new System.Drawing.Point(648, 308);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(59, 35);
            this.btnRegistrar.TabIndex = 31;
            this.btnRegistrar.Tag = "";
            this.btnRegistrar.Text = "Guardar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // textBoxViscosidad
            // 
            this.textBoxViscosidad.Location = new System.Drawing.Point(142, 148);
            this.textBoxViscosidad.Name = "textBoxViscosidad";
            this.textBoxViscosidad.Size = new System.Drawing.Size(130, 20);
            this.textBoxViscosidad.TabIndex = 9;
            // 
            // FormTanqueAceite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 388);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listaTanques);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "FormTanqueAceite";
            this.Text = "Tanque de Aceite";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxViscosidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.TextBox textCapacidad;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listaTanques;
        private System.Windows.Forms.Button btnRegistrar;
    }
}