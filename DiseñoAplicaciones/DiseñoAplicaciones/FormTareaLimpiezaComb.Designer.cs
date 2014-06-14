namespace InterfazGrafica
{
    partial class FormTareaLimpiezaComb
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
            this.btnIzq.Location = new System.Drawing.Point(297, 153);
            this.btnIzq.Name = "btnIzq";
            this.btnIzq.Size = new System.Drawing.Size(66, 26);
            this.btnIzq.TabIndex = 20;
            this.btnIzq.Text = "<---";
            this.btnIzq.UseVisualStyleBackColor = true;
            this.btnIzq.Click += new System.EventHandler(this.btnIzq_Click);
            // 
            // btnDer
            // 
            this.btnDer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDer.Location = new System.Drawing.Point(297, 103);
            this.btnDer.Name = "btnDer";
            this.btnDer.Size = new System.Drawing.Size(66, 26);
            this.btnDer.TabIndex = 19;
            this.btnDer.Text = "--->";
            this.btnDer.UseVisualStyleBackColor = true;
            this.btnDer.Click += new System.EventHandler(this.btnDer_Click);
            // 
            // listBoxNuevaTanquesComb
            // 
            this.listBoxNuevaTanquesComb.FormattingEnabled = true;
            this.listBoxNuevaTanquesComb.Location = new System.Drawing.Point(399, 12);
            this.listBoxNuevaTanquesComb.Name = "listBoxNuevaTanquesComb";
            this.listBoxNuevaTanquesComb.Size = new System.Drawing.Size(203, 238);
            this.listBoxNuevaTanquesComb.TabIndex = 18;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(202, 284);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(98, 39);
            this.buttonSalir.TabIndex = 17;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonRealizar
            // 
            this.buttonRealizar.Location = new System.Drawing.Point(354, 284);
            this.buttonRealizar.Name = "buttonRealizar";
            this.buttonRealizar.Size = new System.Drawing.Size(98, 39);
            this.buttonRealizar.TabIndex = 16;
            this.buttonRealizar.Text = "Realizar";
            this.buttonRealizar.UseVisualStyleBackColor = true;
            this.buttonRealizar.Click += new System.EventHandler(this.buttonRealizar_Click);
            // 
            // listBoxTanquesComb
            // 
            this.listBoxTanquesComb.FormattingEnabled = true;
            this.listBoxTanquesComb.Location = new System.Drawing.Point(50, 12);
            this.listBoxTanquesComb.Name = "listBoxTanquesComb";
            this.listBoxTanquesComb.Size = new System.Drawing.Size(203, 238);
            this.listBoxTanquesComb.TabIndex = 15;
            // 
            // FormTareaLimpiezaComb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 351);
            this.Controls.Add(this.btnIzq);
            this.Controls.Add(this.btnDer);
            this.Controls.Add(this.listBoxNuevaTanquesComb);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonRealizar);
            this.Controls.Add(this.listBoxTanquesComb);
            this.Name = "FormTareaLimpiezaComb";
            this.Text = "Tarea Limpieza - Tanque de Combustible";
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