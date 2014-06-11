namespace InterfazGrafica
{
    partial class FormListadoCargas
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
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.Fechas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textLtsDesde = new System.Windows.Forms.TextBox();
            this.textLtsHasta = new System.Windows.Forms.TextBox();
            this.Filtros = new System.Windows.Forms.GroupBox();
            this.comboManguera = new System.Windows.Forms.ComboBox();
            this.comboSurtidor = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.listCargas = new System.Windows.Forms.ListBox();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.lblresumenFiltro = new System.Windows.Forms.Label();
            this.Filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.Location = new System.Drawing.Point(58, 29);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDesde.TabIndex = 0;
            this.dateTimePickerDesde.Value = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.Location = new System.Drawing.Point(58, 63);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerHasta.TabIndex = 1;
            this.dateTimePickerHasta.Value = new System.DateTime(2014, 5, 5, 13, 42, 16, 0);
            this.dateTimePickerHasta.ValueChanged += new System.EventHandler(this.dateTimePickerHasta_ValueChanged);
            // 
            // Fechas
            // 
            this.Fechas.AutoSize = true;
            this.Fechas.Location = new System.Drawing.Point(14, 35);
            this.Fechas.Name = "Fechas";
            this.Fechas.Size = new System.Drawing.Size(41, 13);
            this.Fechas.TabIndex = 2;
            this.Fechas.Text = "Desde:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Desde:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Litros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Litros";
            // 
            // textLtsDesde
            // 
            this.textLtsDesde.Location = new System.Drawing.Point(57, 96);
            this.textLtsDesde.Name = "textLtsDesde";
            this.textLtsDesde.Size = new System.Drawing.Size(100, 20);
            this.textLtsDesde.TabIndex = 8;
            // 
            // textLtsHasta
            // 
            this.textLtsHasta.Location = new System.Drawing.Point(58, 125);
            this.textLtsHasta.Name = "textLtsHasta";
            this.textLtsHasta.Size = new System.Drawing.Size(100, 20);
            this.textLtsHasta.TabIndex = 9;
            this.textLtsHasta.TextChanged += new System.EventHandler(this.textLtsHasta_TextChanged);
            // 
            // Filtros
            // 
            this.Filtros.Controls.Add(this.comboManguera);
            this.Filtros.Controls.Add(this.comboSurtidor);
            this.Filtros.Controls.Add(this.btnFiltrar);
            this.Filtros.Controls.Add(this.dateTimePickerDesde);
            this.Filtros.Controls.Add(this.textLtsHasta);
            this.Filtros.Controls.Add(this.dateTimePickerHasta);
            this.Filtros.Controls.Add(this.textLtsDesde);
            this.Filtros.Controls.Add(this.Fechas);
            this.Filtros.Controls.Add(this.label4);
            this.Filtros.Controls.Add(this.label1);
            this.Filtros.Controls.Add(this.label5);
            this.Filtros.Controls.Add(this.label3);
            this.Filtros.Controls.Add(this.label2);
            this.Filtros.Location = new System.Drawing.Point(374, 33);
            this.Filtros.Name = "Filtros";
            this.Filtros.Size = new System.Drawing.Size(333, 251);
            this.Filtros.TabIndex = 10;
            this.Filtros.TabStop = false;
            this.Filtros.Text = "Filtrar resultados";
            this.Filtros.Enter += new System.EventHandler(this.Filtros_Enter);
            // 
            // comboManguera
            // 
            this.comboManguera.DisplayMember = "mhg";
            this.comboManguera.FormattingEnabled = true;
            this.comboManguera.Location = new System.Drawing.Point(16, 197);
            this.comboManguera.Name = "comboManguera";
            this.comboManguera.Size = new System.Drawing.Size(121, 21);
            this.comboManguera.TabIndex = 12;
            this.comboManguera.Text = "Manguera";
            // 
            // comboSurtidor
            // 
            this.comboSurtidor.DisplayMember = "mhg";
            this.comboSurtidor.FormattingEnabled = true;
            this.comboSurtidor.Location = new System.Drawing.Point(17, 161);
            this.comboSurtidor.Name = "comboSurtidor";
            this.comboSurtidor.Size = new System.Drawing.Size(121, 21);
            this.comboSurtidor.TabIndex = 11;
            this.comboSurtidor.Text = "Surtidor";
            this.comboSurtidor.SelectedIndexChanged += new System.EventHandler(this.comboSurtidor_SelectedIndexChanged);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(213, 191);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(83, 30);
            this.btnFiltrar.TabIndex = 10;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // listCargas
            // 
            this.listCargas.FormattingEnabled = true;
            this.listCargas.HorizontalScrollbar = true;
            this.listCargas.Location = new System.Drawing.Point(30, 33);
            this.listCargas.Name = "listCargas";
            this.listCargas.ScrollAlwaysVisible = true;
            this.listCargas.Size = new System.Drawing.Size(315, 251);
            this.listCargas.TabIndex = 11;
            this.listCargas.SelectedIndexChanged += new System.EventHandler(this.listCargas_SelectedIndexChanged);
            // 
            // lbFiltro
            // 
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbFiltro.Location = new System.Drawing.Point(24, 96);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(0, 13);
            this.lbFiltro.TabIndex = 12;
            // 
            // lblresumenFiltro
            // 
            this.lblresumenFiltro.AutoSize = true;
            this.lblresumenFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblresumenFiltro.Location = new System.Drawing.Point(57, 294);
            this.lblresumenFiltro.Name = "lblresumenFiltro";
            this.lblresumenFiltro.Size = new System.Drawing.Size(0, 13);
            this.lblresumenFiltro.TabIndex = 13;
            // 
            // FormListadoCargas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 316);
            this.Controls.Add(this.lblresumenFiltro);
            this.Controls.Add(this.lbFiltro);
            this.Controls.Add(this.listCargas);
            this.Controls.Add(this.Filtros);
            this.Name = "FormListadoCargas";
            this.Text = "Listado de Cargas";
            this.Load += new System.EventHandler(this.FormListadoCargas_Load);
            this.Filtros.ResumeLayout(false);
            this.Filtros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
        private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
        private System.Windows.Forms.Label Fechas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textLtsDesde;
        private System.Windows.Forms.TextBox textLtsHasta;
        private System.Windows.Forms.GroupBox Filtros;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ListBox listCargas;
        private System.Windows.Forms.ComboBox comboManguera;
        private System.Windows.Forms.ComboBox comboSurtidor;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.Label lblresumenFiltro;
    }
}