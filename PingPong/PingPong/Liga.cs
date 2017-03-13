using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    class Liga
    {
        List<Jugador> jugadores { get; set; }


        int encuentros = 0;

        Partido partActual = null;
        Jugador[] local = null;
        Jugador[] visita =null;

        int auxT = 0;
        Boolean partidosImpares = false;
        int totalPartidos = 0;

        List<Partido> calendario = new List<Partido>();

        public Liga() { }

        public Liga(List<Jugador> jugs)
        {
            jugadores = jugs;

            //calcular el numero de partidos que tiene que existir
            getNumMatches();

            //conseguir quien es local y quien es visitante
            getCalendario();

            //assignamos la primera vuelta del calendario
            getPrimeraVuelta();

            //assignamos la segunda vuelta del calendario
            getSegundaVuelta();

        }


      




        ///<summary> Calculo de los partidos que tendra la liga </summary> 
        public void getNumMatches()
        {
            int auxT = jugadores.Count();
            Boolean impar = (auxT % 2 != 0);
            if (impar)
            {
                ++auxT;
            }

            totalPartidos = (auxT * (auxT - 1)) / 2;//total de partidos de una ronda

            local=new Jugador[totalPartidos];
            visita = new Jugador[totalPartidos];
        }

        /// <summary> Crear calendario de partidos</summary>
        public void getCalendario()
        {
            int modIF = (auxT / 2);//para hacer mod cada inicio de fecha
            int indiceInverso = auxT - 2;
            for (int i = 0; i < totalPartidos; i++)
            {
                if (i % modIF == 0)
                {//seria el partido inicial de cada fecha
                 //si es impar el numero de clubes la primera fecha se borra poniendo null
                    if (partidosImpares)
                    {
                        local[i] = null;
                        visita[i] = null;
                    }
                    else
                    {
                        //se pone uno local otro  visita al ultimo equipo
                        if (i % 2 == 0)
                        {
                            local[i] = jugadores[i % (auxT - 1)];
                            visita[i] = jugadores[auxT - 1];
                        }
                        else
                        {
                            local[i] = jugadores[auxT - 1];
                            visita[i] = jugadores[i % (auxT - 1)];
                        }
                    }
                }
                else
                {
                    local[i] = jugadores[i % (auxT - 1)];
                    visita[i] = jugadores[indiceInverso];
                    --indiceInverso;
                    if (indiceInverso < 0)
                    {
                        indiceInverso = auxT - 2;
                    }
                }
            }
        }

        /// <summary> Assignacion de la primera vuelta de los partidos </summary>
        public void getPrimeraVuelta()
        {
            MessageBox.Show("\n Primera ronda \n \n");
            for (int i = 0; i < totalPartidos; i++)
            {
                if (local[i] != null)
                {
                    //MessageBox.Show(local[i] + " vs " + visita[i] + "\n");
                    calendario.Add(new Partido(local[i], visita[i]));
                }
            }

        }

        /// <summary> Assignacion de la segunda vuelta de los partidos </summary>
        public void getSegundaVuelta()
        {
            MessageBox.Show("\n Segunda ronda \n \n");
            for (int i = 0; i < totalPartidos; i++)
            {
                if (local[i] != null)
                {
                    //MessageBox.Show(visita[i] + " vs " + local[i] + "\n");
                    calendario.Add(new Partido(visita[i], local[i]));
                }
            }
        }


        /// <summary> Siguiente Partido a Jugar</summary>
        /// <returns> El partido que falta por jugar </returns>
        public Partido getNextMatch()
        {
            foreach (Partido part in calendario)
            {
                if (!part.getFinishGame())
                {
                    partActual = part;
                    return partActual;
                }
            }

            return null;
        }

        /// <summary> Indicamo el valor del marcador del partido actual </summary>
        /// <param name="uno"> marcador del </param>
        /// <param name="dos"></param>
        public void setMarcador(int uno,int dos)
        {
            partActual.setMarcador(uno, dos);
        }

        ///////////////////////////////////////////////////////

        public void ejcutarLiga()
        {

            int tope = 15;

            //modificar el numero de clubes
            List<String> clubes = new List<String>();
            for (int i = 0; i < tope; i++)
            {
                
                clubes.Add("Club_" + i);
            }

            int auxT = clubes.Count();
            Boolean impar = (auxT % 2 != 0);
            if (impar)
            {
                ++auxT;
            }

            int totalP = (auxT * (auxT - 1)) / 2;//total de partidos de una ronda
            String[] local = new String[totalP];
            String[] visita = new String[totalP];
            int modIF = (auxT / 2);//para hacer mod cada inicio de fecha
            int indiceInverso = auxT - 2;
            for (int i = 0; i < totalP; i++)
            {
                if (i % modIF == 0)
                {//seria el partido inicial de cada fecha
                 //si es impar el numero de clubes la primera fecha se borra poniendo null
                    if (impar)
                    {
                        local[i] = null;
                        visita[i] = null;
                    }
                    else
                    {
                        //se pone uno local otro  visita al ultimo equipo
                        if (i % 2 == 0)
                        {
                            local[i] = clubes[i % (auxT - 1)];
                            visita[i] = clubes[auxT - 1];
                        }
                        else
                        {
                            local[i] = clubes[auxT - 1];
                            visita[i] = clubes[i % (auxT - 1)];
                        }
                    }
                }
                else
                {
                    local[i] = clubes[i % (auxT - 1)];
                    visita[i] = clubes[indiceInverso];
                    --indiceInverso;
                    if (indiceInverso < 0)
                    {
                        indiceInverso = auxT - 2;
                    }
                }
            }

            for (int i = 0; i < totalP; i++)
            {
                if (local[i] != null)
                {
                    MessageBox.Show(local[i] + " vs " + visita[i] + "\n");
                }
            }
            MessageBox.Show("\n Segunda ronda \n \n");
            for (int i = 0; i < totalP; i++)
            {
                if (local[i] != null)
                {
                    MessageBox.Show(visita[i] + " vs " + local[i] + "\n");
                }
            }
        }

    }
}
