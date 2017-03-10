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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Jugador 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(547, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Jugador 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(349, 202);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(486, 202);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(719, 202);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(732, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 617);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btPlayMatch);
            this.Controls.Add(this.btCancelarLiga);
            this.Controls.Add(this.btIniciarCompe);
            this.Controls.Add(this.btGestionUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGestionUsuario;
        private System.Windows.Forms.Button btIniciarCompe;
        private System.Windows.Forms.Button btCancelarLiga;
        private System.Windows.Forms.Button btPlayMatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
    }
}

