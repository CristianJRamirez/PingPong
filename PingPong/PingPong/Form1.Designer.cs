namespace PingPong
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
            this.btGestionUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btGestionUsuario
            // 
            this.btGestionUsuario.Location = new System.Drawing.Point(28, 34);
            this.btGestionUsuario.Name = "btGestionUsuario";
            this.btGestionUsuario.Size = new System.Drawing.Size(75, 23);
            this.btGestionUsuario.TabIndex = 0;
            this.btGestionUsuario.Text = "Gestion Usuario";
            this.btGestionUsuario.UseVisualStyleBackColor = true;
            this.btGestionUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 617);
            this.Controls.Add(this.btGestionUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btGestionUsuario;
    }
}

