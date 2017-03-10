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
    public partial class GestionJugador : Form
    {
        List<Jugador> jugadores = null;

        public GestionJugador(List<Jugador> jugs)
        {
            InitializeComponent();
            jugadores = jugs;
        }

        private void GestionJugador_Load(object sender, EventArgs e)
        {
            //Cargar los datos del firebase
        }


        private void btModificarUsuario_Click(object sender, EventArgs e)
        {
            if (listJugador.SelectedItems.Count > 0)
            {
                Jugador jug = (Jugador)listJugador.SelectedItems[0].Tag;

                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    jugadores.Find(x => x.nombre == jug.nombre && x.puntos == jug.puntos).nombre=txtNombre.Text;
                }
                if (!string.IsNullOrEmpty(txtPuntos.Text))
                {
                    jugadores.Find(x => x.nombre == jug.nombre && x.puntos == jug.puntos).puntos = txtPuntos.Text;
                }

            }

            //TODO subir version al fireBase
        
        }

        private void btCrearUsuario_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtPuntos.Text))
            {
                jugadores.Add(new Jugador(txtNombre.Text, txtPuntos.Text));
            }
            else if (string.IsNullOrEmpty(txtPuntos.Text))
            {
                jugadores.Add(new Jugador(txtNombre.Text,"0"));
            }
            else
            {
                MessageBox.Show("Pon un nombre al jugador!");
            }

            //TODO subir version al fireBase


        }

        private void btEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (listJugador.SelectedItems.Count > 0)
            {
                Jugador jug = (Jugador)listJugador.SelectedItems[0].Tag;
                jugadores.Remove(jug);

                //TODO borrar del Firebase
            }
        }


    }
}
