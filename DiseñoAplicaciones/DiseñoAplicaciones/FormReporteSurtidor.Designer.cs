namespace InterfazGrafica
{
    partial class FormReporteSurtidor
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
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dateTimePickerFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSurtidor = new System.Windows.Forms.ComboBox();
            this.listaCargas = new System.Windows.Forms.ListBox();
            this.listaTareas = new System.Windows.Forms.ListBox();
            this.Filtros = new System.Windows.Forms.GroupBox();
            this.Fechas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(618, 28);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(59, 35);
            this.buttonBuscar.TabIndex = 8;
            this.buttonBuscar.Text = "Filtrar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // dateTimePickerFechaHasta
            // 
            this.dateTimePickerFechaHasta.Location = new System.Drawing.Point(105, 50);
            this.dateTimePickerFechaHasta.Name = "dateTimePickerFechaHasta";
            this.dateTimePickerFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaHasta.TabIndex = 7;
            // 
            // dateTimePickerFechaDesde
            // 
            this.dateTimePickerFechaDesde.Location = new System.Drawing.Point(105, 19);
            this.dateTimePickerFechaDesde.Name = "dateTimePickerFechaDesde";
            this.dateTimePickerFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaDesde.TabIndex = 6;
            // 
            // comboBoxSurtidor
            // 
            this.comboBoxSurtidor.FormattingEnabled = true;
            this.comboBoxSurtidor.Location = new System.Drawing.Point(358, 36);
            this.comboBoxSurtidor.Name = "comboBoxSurtidor";
            this.comboBoxSurtidor.Size = new System.Drawing.Size(195, 21);
            this.comboBoxSurtidor.TabIndex = 5;
            this.comboBoxSurtidor.Text = "Surtidor";
            // 
            // listaCargas
            // 
            this.listaCargas.FormattingEnabled = true;
            this.listaCargas.HorizontalScrollbar = true;
            this.listaCargas.Location = new System.Drawing.Point(28, 134);
            this.listaCargas.Name = "listaCargas";
            this.listaCargas.ScrollAlwaysVisible = true;
            this.listaCargas.Size = new System.Drawing.Size(348, 173);
            this.listaCargas.TabIndex = 9;
            // 
            // listaTareas
            // 
            this.listaTareas.FormattingEnabled = true;
            this.listaTareas.HorizontalScrollbar = true;
            this.listaTareas.Location = new System.Drawing.Point(405, 134);
            this.listaTareas.Name = "listaTareas";
            this.listaTareas.ScrollAlwaysVisible = true;
            this.listaTareas.Size = new System.Drawing.Size(348, 173);
            this.listaTareas.TabIndex = 10;
            // 
            // Filtros
            // 
            this.Filtros.Controls.Add(this.Fechas);
            this.Filtros.Controls.Add(this.label1);
            this.Filtros.Controls.Add(this.dateTimePickerFechaDesde);
            this.Filtros.Controls.Add(this.buttonBuscar);
            this.Filtros.Controls.Add(this.dateTimePickerFechaHasta);
            this.Filtros.Controls.Add(this.comboBoxSurtidor);
            this.Filtros.Location = new System.Drawing.Point(28, 12);
            this.Filtros.Name = "Filtros";
            this.Filtros.Size = new System.Drawing.Size(725, 83);
            this.Filtros.TabIndex = 11;
            this.Filtros.TabStop = false;
            this.Filtros.Text = "Filtrar resultados";
            // 
            // Fechas
            // 
            this.Fechas.AutoSize = true;
            this.Fechas.Location = new System.Drawing.Point(45, 25);
            this.Fechas.Name = "Fechas";
            this.Fechas.Size = new System.Drawing.Size(41, 13);
            this.Fechas.TabIndex = 2;
            this.Fechas.Text = "Desde:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(402, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tareas de mantenimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cargas realizadas:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormReporteSurtidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 372);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Filtros);
            this.Controls.Add(this.listaTareas);
            this.Controls.Add(this.listaCargas);
            this.Name = "FormReporteSurtidor";
            this.Text = "Información del surtidor";
            this.Load += new System.EventHandler(this.FormReporteSurtidor_Load);
            this.Filtros.ResumeLayout(false);
            this.Filtros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaHasta;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaDesde;
        private System.Windows.Forms.ComboBox comboBoxSurtidor;
        private System.Windows.Forms.ListBox listaCargas;
        private System.Windows.Forms.ListBox listaTareas;
        private System.Windows.Forms.GroupBox Filtros;
        private System.Windows.Forms.Label Fechas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}