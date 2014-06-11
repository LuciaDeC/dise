namespace InterfazGrafica
{
    partial class FormTareaTratamientoComb
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
            this.btnIzq = new System.Windows.Forms.Button();
            this.btnDer = new System.Windows.Forms.Button();
            this.listBoxNuevaTanquesComb = new System.Windows.Forms.ListBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonRealizar = new System.Windows.Forms.Button();
            this.listBoxTanquesComb = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnIzq
            // 
            this.btnIzq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzq.Location = new System.Drawing.Point(316, 165);
            this.btnIzq.Name = "btnIzq";
            this.btnIzq.Size = new System.Drawing.Size(66, 26);
            this.btnIzq.TabIndex = 14;
            this.btnIzq.Text = "<---";
            this.btnIzq.UseVisualStyleBackColor = true;
            this.btnIzq.Click += new System.EventHandler(this.btnIzq_Click);
            // 
            // btnDer
            // 
            this.btnDer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDer.Location = new System.Drawing.Point(316, 115);
            this.btnDer.Name = "btnDer";
            this.btnDer.Size = new System.Drawing.Size(66, 26);
            this.btnDer.TabIndex = 13;
            this.btnDer.Text = "--->";
            this.btnDer.UseVisualStyleBackColor = true;
            this.btnDer.Click += new System.EventHandler(this.btnDer_Click);
            // 
            // listBoxNuevaTanquesComb
            // 
            this.listBoxNuevaTanquesComb.FormattingEnabled = true;
            this.listBoxNuevaTanquesComb.Location = new System.Drawing.Point(418, 24);
            this.listBoxNuevaTanquesComb.Name = "listBoxNuevaTanquesComb";
            this.listBoxNuevaTanquesComb.Size = new System.Drawing.Size(203, 238);
            this.listBoxNuevaTanquesComb.TabIndex = 12;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(221, 296);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(98, 39);
            this.buttonSalir.TabIndex = 11;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            // 
            // buttonRealizar
            // 
            this.buttonRealizar.Location = new System.Drawing.Point(373, 296);
            this.buttonRealizar.Name = "buttonRealizar";
            this.buttonRealizar.Size = new System.Drawing.Size(98, 39);
            this.buttonRealizar.TabIndex = 10;
            this.buttonRealizar.Text = "Realizar";
            this.buttonRealizar.UseVisualStyleBackColor = true;
            this.buttonRealizar.Click += new System.EventHandler(this.buttonRealizar_Click);
            // 
            // listBoxTanquesComb
            // 
            this.listBoxTanquesComb.FormattingEnabled = true;
            this.listBoxTanquesComb.Location = new System.Drawing.Point(69, 24);
            this.listBoxTanquesComb.Name = "listBoxTanquesComb";
            this.listBoxTanquesComb.Size = new System.Drawing.Size(203, 238);
            this.listBoxTanquesComb.TabIndex = 9;
            // 
            // FormTratamientoTanqueComb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 359);
            this.Controls.Add(this.btnIzq);
            this.Controls.Add(this.btnDer);
            this.Controls.Add(this.listBoxNuevaTanquesComb);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonRealizar);
            this.Controls.Add(this.listBoxTanquesComb);
            this.Name = "FormTratamientoTanqueComb";
            this.Text = "Tarea Tratamiento - Tanque de Combustible";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIzq;
        private System.Windows.Forms.Button btnDer;
        private System.Windows.Forms.ListBox listBoxNuevaTanquesComb;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonRealizar;
        private System.Windows.Forms.ListBox listBoxTanquesComb;
    }
}