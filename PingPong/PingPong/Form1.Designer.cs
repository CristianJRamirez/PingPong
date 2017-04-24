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
            this.txtjugador1 = new System.Windows.Forms.TextBox();
            this.txtjugador2 = new System.Windows.Forms.TextBox();
            this.txtResultadoj1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btGuardarMarcador = new System.Windows.Forms.Button();
            this.txtResultadoj2 = new System.Windows.Forms.TextBox();
            this.listJugadores = new System.Windows.Forms.ListView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listCalendario = new System.Windows.Forms.ListView();
            this.listResultado = new System.Windows.Forms.ListView();
            this.Jugador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartidosJugados = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Puntos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btCargarLiga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btGestionUsuario
            // 
            this.btGestionUsuario.Enabled = false;
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
            this.btIniciarCompe.Enabled = false;
            this.btIniciarCompe.Location = new System.Drawing.Point(208, 34);
            this.btIniciarCompe.Name = "btIniciarCompe";
            this.btIniciarCompe.Size = new System.Drawing.Size(144, 23);
            this.btIniciarCompe.TabIndex = 1;
            this.btIniciarCompe.Text = "Iniciar competicion";
            this.btIniciarCompe.UseVisualStyleBackColor = true;
            this.btIniciarCompe.Click += new System.EventHandler(this.btIniciarCompe_Click);
            // 
            // btCancelarLiga
            // 
            this.btCancelarLiga.Enabled = false;
            this.btCancelarLiga.Location = new System.Drawing.Point(525, 34);
            this.btCancelarLiga.Name = "btCancelarLiga";
            this.btCancelarLiga.Size = new System.Drawing.Size(122, 23);
            this.btCancelarLiga.TabIndex = 2;
            this.btCancelarLiga.Text = "Cancelar Liga";
            this.btCancelarLiga.UseVisualStyleBackColor = true;
            this.btCancelarLiga.Click += new System.EventHandler(this.btCancelarLiga_Click);
            // 
            // btPlayMatch
            // 
            this.btPlayMatch.Enabled = false;
            this.btPlayMatch.Location = new System.Drawing.Point(583, 83);
            this.btPlayMatch.Name = "btPlayMatch";
            this.btPlayMatch.Size = new System.Drawing.Size(143, 23);
            this.btPlayMatch.TabIndex = 3;
            this.btPlayMatch.Text = "Jugar el proper partit";
            this.btPlayMatch.UseVisualStyleBackColor = true;
            this.btPlayMatch.Click += new System.EventHandler(this.btPlayMatch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Jugador 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Jugador 2";
            // 
            // txtjugador1
            // 
            this.txtjugador1.Location = new System.Drawing.Point(61, 115);
            this.txtjugador1.Name = "txtjugador1";
            this.txtjugador1.Size = new System.Drawing.Size(100, 20);
            this.txtjugador1.TabIndex = 6;
            // 
            // txtjugador2
            // 
            this.txtjugador2.Location = new System.Drawing.Point(232, 115);
            this.txtjugador2.Name = "txtjugador2";
            this.txtjugador2.Size = new System.Drawing.Size(100, 20);
            this.txtjugador2.TabIndex = 7;
            // 
            // txtResultadoj1
            // 
            this.txtResultadoj1.Location = new System.Drawing.Point(409, 115);
            this.txtResultadoj1.Name = "txtResultadoj1";
            this.txtResultadoj1.Size = new System.Drawing.Size(44, 20);
            this.txtResultadoj1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Resultado";
            // 
            // btGuardarMarcador
            // 
            this.btGuardarMarcador.Enabled = false;
            this.btGuardarMarcador.Location = new System.Drawing.Point(583, 112);
            this.btGuardarMarcador.Name = "btGuardarMarcador";
            this.btGuardarMarcador.Size = new System.Drawing.Size(117, 23);
            this.btGuardarMarcador.TabIndex = 10;
            this.btGuardarMarcador.Text = "Guardar Marcador";
            this.btGuardarMarcador.UseVisualStyleBackColor = true;
            this.btGuardarMarcador.Click += new System.EventHandler(this.btGuardarMarcador_Click);
            // 
            // txtResultadoj2
            // 
            this.txtResultadoj2.Location = new System.Drawing.Point(459, 115);
            this.txtResultadoj2.Name = "txtResultadoj2";
            this.txtResultadoj2.Size = new System.Drawing.Size(44, 20);
            this.txtResultadoj2.TabIndex = 11;
            // 
            // listJugadores
            // 
            this.listJugadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listJugadores.Location = new System.Drawing.Point(0, 0);
            this.listJugadores.MultiSelect = false;
            this.listJugadores.Name = "listJugadores";
            this.listJugadores.Size = new System.Drawing.Size(327, 380);
            this.listJugadores.TabIndex = 12;
            this.listJugadores.UseCompatibleStateImageBehavior = false;
            this.listJugadores.View = System.Windows.Forms.View.List;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 237);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listJugadores);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1127, 380);
            this.splitContainer1.SplitterDistance = 327;
            this.splitContainer1.TabIndex = 13;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listCalendario);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listResultado);
            this.splitContainer2.Size = new System.Drawing.Size(796, 380);
            this.splitContainer2.SplitterDistance = 264;
            this.splitContainer2.TabIndex = 0;
            // 
            // listCalendario
            // 
            this.listCalendario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCalendario.Location = new System.Drawing.Point(0, 0);
            this.listCalendario.MultiSelect = false;
            this.listCalendario.Name = "listCalendario";
            this.listCalendario.Size = new System.Drawing.Size(264, 380);
            this.listCalendario.TabIndex = 0;
            this.listCalendario.UseCompatibleStateImageBehavior = false;
            this.listCalendario.View = System.Windows.Forms.View.List;
            // 
            // listResultado
            // 
            this.listResultado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Jugador,
            this.PartidosJugados,
            this.Puntos});
            this.listResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listResultado.Location = new System.Drawing.Point(0, 0);
            this.listResultado.Name = "listResultado";
            this.listResultado.Size = new System.Drawing.Size(528, 380);
            this.listResultado.TabIndex = 0;
            this.listResultado.UseCompatibleStateImageBehavior = false;
            this.listResultado.View = System.Windows.Forms.View.Details;
            // 
            // Jugador
            // 
            this.Jugador.Tag = "Jugador";
            this.Jugador.Text = "Jugador";
            this.Jugador.Width = 123;
            // 
            // PartidosJugados
            // 
            this.PartidosJugados.Tag = "PartidosJugados";
            this.PartidosJugados.Text = "Partidos Jugados";
            this.PartidosJugados.Width = 130;
            // 
            // Puntos
            // 
            this.Puntos.Tag = "Puntos";
            this.Puntos.Text = "Puntos";
            this.Puntos.Width = 103;
            // 
            // btCargarLiga
            // 
            this.btCargarLiga.Location = new System.Drawing.Point(372, 34);
            this.btCargarLiga.Name = "btCargarLiga";
            this.btCargarLiga.Size = new System.Drawing.Size(131, 23);
            this.btCargarLiga.TabIndex = 14;
            this.btCargarLiga.Text = "Cargar Liga";
            this.btCargarLiga.UseVisualStyleBackColor = true;
            this.btCargarLiga.Click += new System.EventHandler(this.btCargarLiga_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 617);
            this.Controls.Add(this.btCargarLiga);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.txtResultadoj2);
            this.Controls.Add(this.btGuardarMarcador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResultadoj1);
            this.Controls.Add(this.txtjugador2);
            this.Controls.Add(this.txtjugador1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btPlayMatch);
            this.Controls.Add(this.btCancelarLiga);
            this.Controls.Add(this.btIniciarCompe);
            this.Controls.Add(this.btGestionUsuario);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtjugador1;
        private System.Windows.Forms.TextBox txtjugador2;
        private System.Windows.Forms.TextBox txtResultadoj1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btGuardarMarcador;
        private System.Windows.Forms.TextBox txtResultadoj2;
        private System.Windows.Forms.ListView listJugadores;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listCalendario;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView listResultado;
        private System.Windows.Forms.ColumnHeader Jugador;
        private System.Windows.Forms.ColumnHeader PartidosJugados;
        private System.Windows.Forms.ColumnHeader Puntos;
        private System.Windows.Forms.Button btCargarLiga;
    }
}

