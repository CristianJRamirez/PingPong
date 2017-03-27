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
        public List<Jugador> jugadores = null;

        public GestionJugador(List<Jugador> jugs)
        {
            InitializeComponent();
            jugadores = jugs;
        }

        private void GestionJugador_Load(object sender, EventArgs e)
        {
            if (jugadores != null)
            {
                foreach (Jugador j in jugadores)
                {
                    listJugador.Items.Add(j.ToString());
                }
            }
            
        }

        private void btModificarUsuario_Click(object sender, EventArgs e)
        {
            if (listJugador.SelectedItems.Count > 0)
            {
                

                Jugador j= new Jugador(txtNombre.Text, txtPuntos.Text);
                setJugadorFirebase(j);
                jugadores.Add(j);

                txtNombre.Text = string.Empty;
                txtPuntos.Text = string.Empty;
                //TODO subir version al fireBase
                listJugador.Items.Add(j.ToString());

                borrarUsuario();
            }

            //TODO subir version al fireBase
        
        }

        private void btCrearUsuario_Click(object sender, EventArgs e)
        {
            Jugador jug = null;
            if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtPuntos.Text))
            {
                if (jugadores != null)
                {
                    jug = new Jugador(txtNombre.Text, txtPuntos.Text);
                    setJugadorFirebase(jug);
                    jugadores.Add(jug);
                }
                else
                {
                    jug = new Jugador(txtNombre.Text, txtPuntos.Text);
                    setJugadorFirebase(jug);
                    jugadores = new List<Jugador>();
                    jugadores.Add(jug);
                }
            }
            else if (string.IsNullOrEmpty(txtPuntos.Text))
            {
                if (jugadores != null)
                {
                    jug = new Jugador(txtNombre.Text, "0");
                    setJugadorFirebase(jug);
                    jugadores.Add(jug);
                }
                else
                {
                    jug = new Jugador(txtNombre.Text, "0");
                    setJugadorFirebase(jug);
                    jugadores = new List<Jugador>();
                    jugadores.Add(jug);
                }
            }
            else
            {
                MessageBox.Show("Pon un nombre al jugador!");
            }
            txtNombre.Text = string.Empty;
            txtPuntos.Text = string.Empty;
            
            listJugador.Items.Add(jug.ToString());

            

            //TODO subir version al fireBase
        }

        private async void setJugadorFirebase(Jugador jug)
        {
            conexionFireBase.jugador = jug;
            await conexionFireBase.setJugadorFB();
            jug = conexionFireBase.jugador;
        }

        private void btEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (listJugador.SelectedItems.Count > 0)
            {
                borrarUsuario();            

                //TODO borrar del Firebase
            }
        }

        private void listJugador_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listJugador.SelectedItems.Count > 0)
            {
                foreach (Jugador j in jugadores)
                {
                    if (listJugador.SelectedItems[0].Text == j.ToString())
                    {
                        txtNombre.Text = j.nombre;
                        txtPuntos.Text = j.puntos;
                    }
                }
            }
            else
            {
                txtNombre.Text = string.Empty;
                txtPuntos.Text = string.Empty;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            activarBoton();
        }

        private void txtPuntos_TextChanged(object sender, EventArgs e)
        {
            activarBoton();
        }

        private void listJugador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listJugador.SelectedItems.Count <= 0)
            {
                btEliminarUsuario.Enabled = false;
            }
            else
            {
                btEliminarUsuario.Enabled = true;
            }
        }

        private void activarBoton()
        {
            if (string.IsNullOrEmpty(txtNombre.Text) && string.IsNullOrEmpty(txtPuntos.Text) && listJugador.SelectedItems.Count<=0)
            {
                btModificarUsuario.Enabled = false;
            }
            else
            {
                btModificarUsuario.Enabled = true;
            }

        }

        private void borrarUsuario()
        {
            foreach (Jugador j in jugadores)
            {
                if (listJugador.SelectedItems[0].Text == j.ToString())
                {
                    conexionFireBase.deleteJugadores(j);
                    jugadores.Remove(j);
                    listJugador.Items.Remove(listJugador.SelectedItems[0]);
                    return;
                }
            }
        }

    }
}
