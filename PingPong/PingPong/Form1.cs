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

            actualizarBBDD();

        }
        List<Partido> calenTemp = new List<Partido>();

        private async void actualizarBBDD()
        {
            
            foreach (Partido p in liga.calendario)
            {
                await setPartidoFirebase(p);
                //calenTemp.Add(partidoTemp);
            }
            liga.calendario = calenTemp;
        }


        private async Task setPartidoFirebase(Partido p)
        {
            conexionFireBase.partido = p;
            await conexionFireBase.setPartidoFB();
            p = conexionFireBase.partido;

            calenTemp.Add(conexionFireBase.partido);
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
            if (partActual != null )
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
                partActual = liga.partActual;
                Jugador ganador = null;
                Jugador perdedor = null;


                ListViewItem itemGanador = null;
                ListViewItem itemPerdedor = null;

                setPartidoFirebase(new Partido(partActual.ID, partActual.j1, partActual.j2, partActual.marcadorJ1, partActual.marcadorJ2, true));
                borrarPartido(partActual);

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


        private async void borrarPartido(Partido p)
        {
            await conexionFireBase.deletePartido(p);
        }

        private void btCargarLiga_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            getLigaFB();
        }


        private async void getLigaFB()
        {
            await conexionFireBase.getPartidosFB();
            if (liga==null)
            {
                liga = new Liga();
            }
            liga.calendario = conexionFireBase.calendario;

            this.UseWaitCursor = false;

            foreach (Partido p in liga.calendario)
            {
                listCalendario.Items.Add(p.ToString());
            }


            //cargarTablaResultado();

            cargarJugadoresPuntos();

        }
        
        public void cargarJugadoresPuntos()
        {
            List<Jugador> jugadoresCargar = new List<Jugador>();
            foreach (Partido part in liga.calendario)
            {
                if (jugadoresCargar.Count==0)
                {
                    jugadoresCargar.Add(part.j1);
                    jugadoresCargar.Add(part.j2);

                }
                else
                {
                    if (buscarJugador(jugadoresCargar,part.j1.nombre) == true)
                    {
                        if (int.Parse(jugadoresCargar.First(x => x.nombre.Equals(part.j1.nombre)).puntos) < int.Parse(part.j1.puntos))
                        {
                            jugadoresCargar.RemoveAll(x => x.nombre.Equals(part.j1.nombre));
                            jugadoresCargar.Add(part.j1);
                        }
                    }
                    else
                    {
                        jugadoresCargar.Add(part.j1);
                    }

                    
                    if (buscarJugador(jugadoresCargar,part.j2.nombre) == true)
                    {
                        if (int.Parse(jugadoresCargar.First(x => x.nombre.Equals(part.j2.nombre)).puntos) < int.Parse(part.j2.puntos))
                        {
                            jugadoresCargar.RemoveAll(x => x.nombre.Equals(part.j2.nombre));
                            jugadoresCargar.Add(part.j2);
                        }
                    }
                    else
                    {
                        jugadoresCargar.Add(part.j2);
                    }

                }


            }
            cargarTablaResultadoJugadoresCargados(jugadoresCargar);
  

            foreach (Jugador item in jugadoresCargar)
            {
                ListViewItem item2 = buscarItem(item.nombre);
                añadirDatosPartido(item2, item.puntos);
            }
            
        }

        private bool buscarJugador(List<Jugador> jugadoresCargar,string quien)
        {
            foreach (Jugador j in jugadoresCargar)
            {
                if (j.nombre.Equals(quien))
                {
                    return true;
                }
            }
            return false;
        }


        private void cargarTablaResultadoJugadoresCargados(List<Jugador> jugadoresCargar )
        {
            foreach (Jugador j in jugadoresCargar)
            {
                listResultado.Items.Add(j.nombre);
            }
        }
    }
}
