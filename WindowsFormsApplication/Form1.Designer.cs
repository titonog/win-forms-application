namespace WindowsFormsApplication
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTestCalculadora = new System.Windows.Forms.Button();
            this.btnTestCalendario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestCalculadora
            // 
            this.btnTestCalculadora.Location = new System.Drawing.Point(12, 36);
            this.btnTestCalculadora.Name = "btnTestCalculadora";
            this.btnTestCalculadora.Size = new System.Drawing.Size(234, 33);
            this.btnTestCalculadora.TabIndex = 0;
            this.btnTestCalculadora.Text = "Calculadora";
            this.btnTestCalculadora.UseVisualStyleBackColor = true;
            this.btnTestCalculadora.Click += new System.EventHandler(this.btnTestCalculadora_Click);
            // 
            // btnTestCalendario
            // 
            this.btnTestCalendario.Location = new System.Drawing.Point(12, 87);
            this.btnTestCalendario.Name = "btnTestCalendario";
            this.btnTestCalendario.Size = new System.Drawing.Size(234, 33);
            this.btnTestCalendario.TabIndex = 1;
            this.btnTestCalendario.Text = "Calendario";
            this.btnTestCalendario.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 224);
            this.Controls.Add(this.btnTestCalendario);
            this.Controls.Add(this.btnTestCalculadora);
            this.Name = "Form1";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestCalculadora;
        private System.Windows.Forms.Button btnTestCalendario;
    }
}

