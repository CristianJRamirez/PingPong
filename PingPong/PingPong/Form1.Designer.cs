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
            this.btIniciarCompe = new System.Windows.Forms.Button();
            this.btCancelarLiga = new System.Windows.Forms.Button();
            this.btPlayMatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btGestionUsuario
            // 
            this.btGestionUsuario.Location = new System.Drawing.Point(28, 34);
            this.btGestionUsuario.Name = "btGestionUsuario";
            this.btGestionUsuario.Size = new System.Drawing.Size(109, 23);
            this.btGestionUsuario.TabIndex = 0;
            this.btGestionUsuario.Text = "Gestion Usuario";
            this.btGestionUsuario.UseVisualStyleBackColor = true;
            this.btGestionUsuario.Click += new System.EventHandler(this.btGestionUsuario_Click);
            // 
            // btIniciarCompe
            // 
            this.btIniciarCompe.Location = new System.Drawing.Point(208, 34);
            this.btIniciarCompe.Name = "btIniciarCompe";
            this.btIniciarCompe.Size = new System.Drawing.Size(144, 23);
            this.btIniciarCompe.TabIndex = 1;
            this.btIniciarCompe.Text = "Iniciar competicion";
            this.btIniciarCompe.UseVisualStyleBackColor = true;
            // 
            // btCancelarLiga
            // 
            this.btCancelarLiga.Location = new System.Drawing.Point(358, 34);
            this.btCancelarLiga.Name = "btCancelarLiga";
            this.btCancelarLiga.Size = new System.Drawing.Size(122, 23);
            this.btCancelarLiga.TabIndex = 2;
            this.btCancelarLiga.Text = "Cancelar Liga";
            this.btCancelarLiga.UseVisualStyleBackColor = true;
            // 
            // btPlayMatch
            // 
            this.btPlayMatch.Location = new System.Drawing.Point(486, 34);
            this.btPlayMatch.Name = "btPlayMatch";
            this.btPlayMatch.Size = new System.Drawing.Size(143, 23);
            this.btPlayMatch.TabIndex = 3;
            this.btPlayMatch.Text = "Jugar el proper partit";
            this.btPlayMatch.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 617);
            this.Controls.Add(this.btPlayMatch);
            this.Controls.Add(this.btCancelarLiga);
            this.Controls.Add(this.btIniciarCompe);
            this.Controls.Add(this.btGestionUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btGestionUsuario;
        private System.Windows.Forms.Button btIniciarCompe;
        private System.Windows.Forms.Button btCancelarLiga;
        private System.Windows.Forms.Button btPlayMatch;
    }
}

