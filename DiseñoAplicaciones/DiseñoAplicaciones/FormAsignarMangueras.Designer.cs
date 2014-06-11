namespace InterfazGrafica
{
    partial class FormAsignarMangueras
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
            this.comboSurtidor = new System.Windows.Forms.ComboBox();
            this.Surtidor = new System.Windows.Forms.Label();
            this.listMangueras = new System.Windows.Forms.ListBox();
            this.listAsignadas = new System.Windows.Forms.ListBox();
            this.btnDer = new System.Windows.Forms.Button();
            this.btnIzq = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboSurtidor
            // 
            this.comboSurtidor.FormattingEnabled = true;
            this.comboSurtidor.Location = new System.Drawing.Point(308, 22);
            this.comboSurtidor.Name = "comboSurtidor";
            this.comboSurtidor.Size = new System.Drawing.Size(207, 21);
            this.comboSurtidor.TabIndex = 0;
            this.comboSurtidor.SelectedIndexChanged += new System.EventHandler(this.comboSurtidor_SelectedIndexChanged);
            // 
            // Surtidor
            // 
            this.Surtidor.AutoSize = true;
            this.Surtidor.Location = new System.Drawing.Point(256, 25);
            this.Surtidor.Name = "Surtidor";
            this.Surtidor.Size = new System.Drawing.Size(46, 13);
            this.Surtidor.TabIndex = 1;
            this.Surtidor.Text = "Surtidor:";
            // 
            // listMangueras
            // 
            this.listMangueras.FormattingEnabled = true;
            this.listMangueras.HorizontalScrollbar = true;
            this.listMangueras.Location = new System.Drawing.Point(12, 96);
            this.listMangueras.Name = "listMangueras";
            this.listMangueras.Size = new System.Drawing.Size(276, 264);
            this.listMangueras.TabIndex = 2;
            // 
            // listAsignadas
            // 
            this.listAsignadas.FormattingEnabled = true;
            this.listAsignadas.HorizontalScrollbar = true;
            this.listAsignadas.Location = new System.Drawing.Point(495, 96);
            this.listAsignadas.Name = "listAsignadas";
            this.listAsignadas.Size = new System.Drawing.Size(276, 264);
            this.listAsignadas.TabIndex = 3;
            // 
            // btnDer
            // 
            this.btnDer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDer.Location = new System.Drawing.Point(357, 130);
            this.btnDer.Name = "btnDer";
            this.btnDer.Size = new System.Drawing.Size(66, 26);
            this.btnDer.TabIndex = 4;
            this.btnDer.Text = "--->";
            this.btnDer.UseVisualStyleBackColor = true;
            this.btnDer.Click += new System.EventHandler(this.btnDer_Click);
            // 
            // btnIzq
            // 
            this.btnIzq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzq.Location = new System.Drawing.Point(357, 180);
            this.btnIzq.Name = "btnIzq";
            this.btnIzq.Size = new System.Drawing.Size(66, 26);
            this.btnIzq.TabIndex = 5;
            this.btnIzq.Text = "<---";
            this.btnIzq.UseVisualStyleBackColor = true;
            this.btnIzq.Click += new System.EventHandler(this.btnIzq_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(245, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 53);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(492, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mangueras asignadas al surtidor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mangueras a asignar:";
            // 
            // FormAsignarMangueras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 373);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIzq);
            this.Controls.Add(this.btnDer);
            this.Controls.Add(this.listAsignadas);
            this.Controls.Add(this.listMangueras);
            this.Controls.Add(this.Surtidor);
            this.Controls.Add(this.comboSurtidor);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAsignarMangueras";
            this.Text = "Asignar Mangueras";
            this.Load += new System.EventHandler(this.FormAsignarMangueras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSurtidor;
        private System.Windows.Forms.Label Surtidor;
        private System.Windows.Forms.ListBox listMangueras;
        private System.Windows.Forms.ListBox listAsignadas;
        private System.Windows.Forms.Button btnDer;
        private System.Windows.Forms.Button btnIzq;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}