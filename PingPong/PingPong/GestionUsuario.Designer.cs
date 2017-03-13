namespace PingPong
{
    partial class GestionJugador
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
            this.btCrearUsuario = new System.Windows.Forms.Button();
            this.btModificarUsuario = new System.Windows.Forms.Button();
            this.btEliminarUsuario = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPuntos = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.listJugador = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btCrearUsuario
            // 
            this.btCrearUsuario.Location = new System.Drawing.Point(12, 27);
            this.btCrearUsuario.Name = "btCrearUsuario";
            this.btCrearUsuario.Size = new System.Drawing.Size(114, 23);
            this.btCrearUsuario.TabIndex = 0;
            this.btCrearUsuario.Text = "Crear Jugador";
            this.btCrearUsuario.UseVisualStyleBackColor = true;
            this.btCrearUsuario.Click += new System.EventHandler(this.btCrearUsuario_Click);
            // 
            // btModificarUsuario
            // 
            this.btModificarUsuario.Location = new System.Drawing.Point(203, 27);
            this.btModificarUsuario.Name = "btModificarUsuario";
            this.btModificarUsuario.Size = new System.Drawing.Size(113, 23);
            this.btModificarUsuario.TabIndex = 1;
            this.btModificarUsuario.Text = "Modificar Jugador";
            this.btModificarUsuario.UseVisualStyleBackColor = true;
            this.btModificarUsuario.Click += new System.EventHandler(this.btModificarUsuario_Click);
            // 
            // btEliminarUsuario
            // 
            this.btEliminarUsuario.Location = new System.Drawing.Point(389, 27);
            this.btEliminarUsuario.Name = "btEliminarUsuario";
            this.btEliminarUsuario.Size = new System.Drawing.Size(114, 23);
            this.btEliminarUsuario.TabIndex = 2;
            this.btEliminarUsuario.Text = "Eliminar Jugador";
            this.btEliminarUsuario.UseVisualStyleBackColor = true;
            this.btEliminarUsuario.Click += new System.EventHandler(this.btEliminarUsuario_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(92, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtPuntos
            // 
            this.txtPuntos.Location = new System.Drawing.Point(305, 69);
            this.txtPuntos.Name = "txtPuntos";
            this.txtPuntos.Size = new System.Drawing.Size(100, 20);
            this.txtPuntos.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 72);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Location = new System.Drawing.Point(239, 72);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(40, 13);
            this.lblPuntos.TabIndex = 6;
            this.lblPuntos.Text = "Puntos";
            // 
            // listJugador
            // 
            this.listJugador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listJugador.Location = new System.Drawing.Point(0, 128);
            this.listJugador.MultiSelect = false;
            this.listJugador.Name = "listJugador";
            this.listJugador.Size = new System.Drawing.Size(548, 241);
            this.listJugador.TabIndex = 7;
            this.listJugador.UseCompatibleStateImageBehavior = false;
            this.listJugador.View = System.Windows.Forms.View.List;
            // 
            // GestionJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 369);
            this.Controls.Add(this.listJugador);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtPuntos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btEliminarUsuario);
            this.Controls.Add(this.btModificarUsuario);
            this.Controls.Add(this.btCrearUsuario);
            this.Name = "GestionJugador";
            this.Text = "Gestion de Jugador";
            this.Load += new System.EventHandler(this.GestionJugador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCrearUsuario;
        private System.Windows.Forms.Button btModificarUsuario;
        private System.Windows.Forms.Button btEliminarUsuario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPuntos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.ListView listJugador;
    }
}