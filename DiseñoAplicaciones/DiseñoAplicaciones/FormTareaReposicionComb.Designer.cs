namespace InterfazGrafica
{
    partial class FormTareaReposicionComb
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
            this.comboBoxTipoComb = new System.Windows.Forms.ComboBox();
            this.listBoxListaTareas = new System.Windows.Forms.ListBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.comboBoxTanque = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxTipoComb
            // 
            this.comboBoxTipoComb.Enabled = false;
            this.comboBoxTipoComb.FormattingEnabled = true;
            this.comboBoxTipoComb.Location = new System.Drawing.Point(424, 163);
            this.comboBoxTipoComb.Name = "comboBoxTipoComb";
            this.comboBoxTipoComb.Size = new System.Drawing.Size(185, 21);
            this.comboBoxTipoComb.TabIndex = 16;
            // 
            // listBoxListaTareas
            // 
            this.listBoxListaTareas.FormattingEnabled = true;
            this.listBoxListaTareas.HorizontalScrollbar = true;
            this.listBoxListaTareas.Location = new System.Drawing.Point(12, 25);
            this.listBoxListaTareas.Name = "listBoxListaTareas";
            this.listBoxListaTareas.ScrollAlwaysVisible = true;
            this.listBoxListaTareas.Size = new System.Drawing.Size(302, 290);
            this.listBoxListaTareas.TabIndex = 15;
            this.listBoxListaTareas.SelectedIndexChanged += new System.EventHandler(this.listBoxListaTareas_SelectedIndexChanged);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(553, 282);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(59, 35);
            this.buttonSalir.TabIndex = 14;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(635, 282);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(59, 35);
            this.buttonGuardar.TabIndex = 13;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(424, 213);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(100, 20);
            this.textBoxCantidad.TabIndex = 11;
            // 
            // comboBoxTanque
            // 
            this.comboBoxTanque.FormattingEnabled = true;
            this.comboBoxTanque.Location = new System.Drawing.Point(424, 117);
            this.comboBoxTanque.Name = "comboBoxTanque";
            this.comboBoxTanque.Size = new System.Drawing.Size(286, 21);
            this.comboBoxTanque.TabIndex = 9;
            this.comboBoxTanque.SelectedIndexChanged += new System.EventHandler(this.comboBoxTanque_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tanque:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tipo de Comb.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "lts";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(522, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(331, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 224);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(422, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 24);
            this.label7.TabIndex = 24;
            this.label7.Text = "Reposición de Combustible";
            // 
            // FormTareaReposicionComb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 334);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxTipoComb);
            this.Controls.Add(this.listBoxListaTareas);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.comboBoxTanque);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTareaReposicionComb";
            this.Text = "Tareas de Reposición - Tanque de  Combustible";
            this.Load += new System.EventHandler(this.FormTareaReposicion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTipoComb;
        private System.Windows.Forms.ListBox listBoxListaTareas;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.ComboBox comboBoxTanque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
    }
}