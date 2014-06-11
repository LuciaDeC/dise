namespace InterfazGrafica
{
    partial class FormTareaTratamientoAceite
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
            this.listBoxTanquesAceite = new System.Windows.Forms.ListBox();
            this.buttonRealizar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.listBoxNuevaListaTanques = new System.Windows.Forms.ListBox();
            this.btnIzq = new System.Windows.Forms.Button();
            this.btnDer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxTanquesAceite
            // 
            this.listBoxTanquesAceite.FormattingEnabled = true;
            this.listBoxTanquesAceite.Location = new System.Drawing.Point(47, 37);
            this.listBoxTanquesAceite.Name = "listBoxTanquesAceite";
            this.listBoxTanquesAceite.Size = new System.Drawing.Size(176, 212);
            this.listBoxTanquesAceite.TabIndex = 0;
            // 
            // buttonRealizar
            // 
            this.buttonRealizar.Location = new System.Drawing.Point(227, 265);
            this.buttonRealizar.Name = "buttonRealizar";
            this.buttonRealizar.Size = new System.Drawing.Size(98, 39);
            this.buttonRealizar.TabIndex = 1;
            this.buttonRealizar.Text = "Realizar";
            this.buttonRealizar.UseVisualStyleBackColor = true;
            this.buttonRealizar.Click += new System.EventHandler(this.buttonRealizar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(369, 265);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(98, 39);
            this.buttonSalir.TabIndex = 2;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            // 
            // listBoxNuevaListaTanques
            // 
            this.listBoxNuevaListaTanques.FormattingEnabled = true;
            this.listBoxNuevaListaTanques.Location = new System.Drawing.Point(360, 37);
            this.listBoxNuevaListaTanques.Name = "listBoxNuevaListaTanques";
            this.listBoxNuevaListaTanques.Size = new System.Drawing.Size(176, 212);
            this.listBoxNuevaListaTanques.TabIndex = 3;
            // 
            // btnIzq
            // 
            this.btnIzq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzq.Location = new System.Drawing.Point(262, 170);
            this.btnIzq.Name = "btnIzq";
            this.btnIzq.Size = new System.Drawing.Size(66, 26);
            this.btnIzq.TabIndex = 10;
            this.btnIzq.Text = "<---";
            this.btnIzq.UseVisualStyleBackColor = true;
            this.btnIzq.Click += new System.EventHandler(this.btnIzq_Click);
            // 
            // btnDer
            // 
            this.btnDer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDer.Location = new System.Drawing.Point(262, 120);
            this.btnDer.Name = "btnDer";
            this.btnDer.Size = new System.Drawing.Size(66, 26);
            this.btnDer.TabIndex = 9;
            this.btnDer.Text = "--->";
            this.btnDer.UseVisualStyleBackColor = true;
            this.btnDer.Click += new System.EventHandler(this.btnDer_Click);
            // 
            // FormTratamientoTanqueAceite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 316);
            this.Controls.Add(this.btnIzq);
            this.Controls.Add(this.btnDer);
            this.Controls.Add(this.listBoxNuevaListaTanques);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonRealizar);
            this.Controls.Add(this.listBoxTanquesAceite);
            this.Name = "FormTratamientoTanqueAceite";
            this.Text = "Tarea Tratamiento - Tanque de Aceite";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTanquesAceite;
        private System.Windows.Forms.Button buttonRealizar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.ListBox listBoxNuevaListaTanques;
        private System.Windows.Forms.Button btnIzq;
        private System.Windows.Forms.Button btnDer;
    }
}