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
        List<Jugador> jugadores;
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
            jugadores= gu.jugadores;
            if (jugadores != null)
            {
                foreach (Jugador j in jugadores)
                {
                    listJugadores.Items.Add(j.ToString());
                }
                btIniciarCompe.Enabled = true;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TODO buscar jugadores en el Firebase
            //this.Cursor = AppStarting;
            this.UseWaitCursor = true;
            getJugadorFirebase();

        }

        private async void getJugadorFirebase()
        {
            await conexionFireBase.getJugadoresFB();
            jugadores = conexionFireBase.players;
            btGestionUsuario.Enabled = true;
            this.UseWaitCursor = false;

            if (jugadores != null)
            {
                foreach (Jugador j in jugadores)
                {
                    listJugadores.Items.Add(j.ToString());
                }

                btIniciarCompe.Enabled = true;
            }
        }

        private void btIniciarCompe_Click(object sender, EventArgs e)
        {
            liga = new Liga(jugadores);

            foreach (Partido p in liga.calendario)
            {
                listCalendario.Items.Add(p.ToString());
            }

            cargarTablaResultado();

            btCancelarLiga.Enabled = true;
            btPlayMatch.Enabled = true;
            btIniciarCompe.Enabled = false;

        }

        private void cargarTablaResultado()
        {
            foreach (Jugador j in jugadores)
            {
                listResultado.Items.Add(j.nombre);
            }
        }

        private void btPlayMatch_Click(object sender, EventArgs e)
        {
            partActual = liga.getNextMatch();
            if (partActual != null)
            {
                btGuardarMarcador.Enabled = true;
                txtjugador1.Text = partActual.j1.nombre;
                txtjugador2.Text = partActual.j2.nombre;
                txtResultadoj1.Text = string.Empty;
                txtResultadoj2.Text = string.Empty;
            }
        }
    
        private void btGuardarMarcador_Click(object sender, EventArgs e)
        {
            if (partActual != null)
            {
                string quien = liga.setMarcador(int.Parse(txtResultadoj1.Text.Trim()), int.Parse(txtResultadoj2.Text.Trim()));

                Jugador ganador = null;
                Jugador perdedor = null;


                ListViewItem itemGanador = null;
                ListViewItem itemPerdedor = null;



                if (partActual.j1.nombre.Equals(quien))
                {
                    itemGanador = buscarItem(partActual.j1.nombre);
                    ganador = partActual.j1;
                    itemPerdedor = buscarItem(partActual.j2.nombre);
                    perdedor = partActual.j2;


                }
                else
                {
                    itemGanador = buscarItem(partActual.j2.nombre);
                    ganador = partActual.j2;
                    itemPerdedor = buscarItem(partActual.j1.nombre);
                    perdedor = partActual.j1;
                }


                //itemGanador = buscarItem(quien);
                listResultado.BeginUpdate();


                //añadir datos de ganador
                añadirDatosPartido(itemGanador, ganador.puntos);




                //añadir datos de perdedor
                añadirDatosPartido(itemPerdedor, perdedor.puntos);

                
                listResultado.EndUpdate();



                //TODO ordenar la lista por los puntos

                

            }
        }

        private ListViewItem buscarItem(string quien)
        {
            ListViewItem item=null;
            foreach (ListViewItem i in listResultado.Items)
            {
                if (i.Text.Equals(quien))
                {
                    item = i;
                }
            }

            return item;
        }

        private void añadirDatosPartido(ListViewItem item,string puntos)
        {
            if (listResultado.Items[item.Index].SubItems.Count >= 2)
            {
                int jugados = int.Parse(listResultado.Items[item.Index].SubItems[1].Text);
                listResultado.Items[item.Index].SubItems[1].Text = jugados + 1 + "";
            }
            else
            {
                listResultado.Items[item.Index].SubItems.Add("1");
            }

            if (listResultado.Items[item.Index].SubItems.Count >= 3)
            {
                int punt = int.Parse(listResultado.Items[item.Index].SubItems[2].Text);
                listResultado.Items[item.Index].SubItems[2].Text =  puntos ;
            }
            else
            {
                listResultado.Items[item.Index].SubItems.Add(puntos);
            }
        }

        private void btCancelarLiga_Click(object sender, EventArgs e)
        {
            if (liga !=null)
            {
                liga = null;
                if (partActual!=null)
                {
                    partActual = null;
                }
                btIniciarCompe.Enabled = true;
                btCancelarLiga.Enabled = false;
                btPlayMatch.Enabled = false;
                listCalendario.Clear();
                listResultado.Clear();
                btGuardarMarcador.Enabled = false;
                txtjugador1.Text = string.Empty;
                txtjugador2.Text = string.Empty;
                txtResultadoj1.Text = string.Empty;
                txtResultadoj2.Text = string.Empty;
            }
        }
    }
}
