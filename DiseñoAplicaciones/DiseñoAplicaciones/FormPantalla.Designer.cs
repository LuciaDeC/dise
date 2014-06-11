namespace InterfazGrafica
{
    partial class FormPantalla
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
            this.listTanques = new System.Windows.Forms.ListBox();
            this.listTanqDisp = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboSurtidores = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listExpendidos = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listTanques
            // 
            this.listTanques.FormattingEnabled = true;
            this.listTanques.Location = new System.Drawing.Point(6, 20);
            this.listTanques.Name = "listTanques";
            this.listTanques.Size = new System.Drawing.Size(645, 147);
            this.listTanques.TabIndex = 1;
            this.listTanques.SelectedIndexChanged += new System.EventHandler(this.listTanques_SelectedIndexChanged);
            // 
            // listTanqDisp
            // 
            this.listTanqDisp.FormattingEnabled = true;
            this.listTanqDisp.Location = new System.Drawing.Point(7, 46);
            this.listTanqDisp.Name = "listTanqDisp";
            this.listTanqDisp.Size = new System.Drawing.Size(400, 134);
            this.listTanqDisp.TabIndex = 5;
            this.listTanqDisp.SelectedIndexChanged += new System.EventHandler(this.listTanqDisp_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listTanques);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 180);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion en tiempo real de los tanques: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // comboSurtidores
            // 
            this.comboSurtidores.FormattingEnabled = true;
            this.comboSurtidores.Location = new System.Drawing.Point(7, 19);
            this.comboSurtidores.Name = "comboSurtidores";
            this.comboSurtidores.Size = new System.Drawing.Size(223, 21);
            this.comboSurtidores.TabIndex = 7;
            this.comboSurtidores.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listExpendidos);
            this.groupBox2.Controls.Add(this.comboSurtidores);
            this.groupBox2.Controls.Add(this.listTanqDisp);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(657, 188);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion por Surtidor";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // listExpendidos
            // 
            this.listExpendidos.FormattingEnabled = true;
            this.listExpendidos.Location = new System.Drawing.Point(425, 46);
            this.listExpendidos.Name = "listExpendidos";
            this.listExpendidos.Size = new System.Drawing.Size(226, 134);
            this.listExpendidos.TabIndex = 8;
            this.listExpendidos.SelectedIndexChanged += new System.EventHandler(this.listExpendidos_SelectedIndexChanged);
            // 
            // FormPantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 398);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPantalla";
            this.Text = "Pantallas";
            this.Load += new System.EventHandler(this.FormPantalla_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listTanques;
        private System.Windows.Forms.ListBox listTanqDisp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboSurtidores;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listExpendidos;
    }
}