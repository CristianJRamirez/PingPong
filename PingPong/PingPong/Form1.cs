using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        List<Jugador> jugadores = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btGestionUsuario_Click(object sender, EventArgs e)
        {
            GestionJugador gu = new GestionJugador(jugadores);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TODO buscar jugadores en el Firebase

        }
    }
}
