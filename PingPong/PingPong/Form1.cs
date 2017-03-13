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
        Partido partActual;
        Liga liga = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btGestionUsuario_Click(object sender, EventArgs e)
        {
            GestionJugador gu = new GestionJugador(jugadores);
            gu.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TODO buscar jugadores en el Firebase

        }

        private void btIniciarCompe_Click(object sender, EventArgs e)
        {
            liga = new Liga();



        }

        private void btPlayMatch_Click(object sender, EventArgs e)
        {
            partActual = liga.getNextMatch();
            if (partActual != null)
            {
                txtjugador1.Text = partActual.j1.nombre;
                txtjugador2.Text = partActual.j2.nombre;
            }
        }
    
        private void btGuardarMarcador_Click(object sender, EventArgs e)
        {
            if (partActual != null)
            {
                liga.setMarcador(int.Parse(txtResultadoj1.Text.Trim()), int.Parse(txtResultadoj2.Text.Trim()));
            }
        }
    }
}
