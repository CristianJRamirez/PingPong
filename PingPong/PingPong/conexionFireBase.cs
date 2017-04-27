using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    public static class conexionFireBase
    {
        public static List<Jugador> players = null;
        public static Jugador jugador = null;

        #region Jugadores

        /// <summary> Agregar Jugador al Firebase  </summary>
        /// <returns></returns>
        public static async Task setJugadorFB()
        {
            if (jugador == null)
            {
                jugador = new Jugador();
            }

            var client = new FirebaseClient("https://ligapingpong-17f52.firebaseio.com/");
            var child = client.Child("jugadors/");

            var p1 = await child.PostAsync(jugador);
            jugador.ID = p1.Key;
        }

        /// <summary> Devolver los jugadores en la BBDD </summary>
        /// <param name="players">En que lista se quieren los jugadores</param>
        /// <returns></returns>
        public static async Task getJugadoresFB()
        {
            if (players == null)
            {
                players = new List<Jugador>();
            }

            var firebase = new FirebaseClient("https://ligapingpong-17f52.firebaseio.com/");

            var jugadores = await firebase.Child("jugadors").OnceAsync<Jugador>();

            foreach (var p1 in jugadores)
            {
                Jugador j = p1.Object;
                players.Add(j);
            }

        }

        public static async Task deleteJugadores(Jugador j)
        {
            var client = new FirebaseClient("https://ligapingpong-17f52.firebaseio.com/");
            var child = client.Child("jugadors/" + j.ID);

            await child.DeleteAsync();
            //jugador.Id = p1.Key;
        }


        //sin implementar, setear puntos de la liga actual para el jugador
        public static async Task setPuntosJugadorFB(Jugador j)
        {
            var client = new FirebaseClient("https://ligapingpong-17f52.firebaseio.com/");
            var child = client.Child("jugadors/" + j.ID);

            var p1 = await child.PostAsync(jugador);
            jugador.ID = p1.Key;
        }

        #endregion

        #region Liga

        public static Partido partido = null;
        public static async Task setPartidoFB()
        {
            if (partido == null)
            {
                partido = new Partido();
            }

            var client = new FirebaseClient("https://ligapingpong-17f52.firebaseio.com/");
            var child = client.Child("liga/partidos/");

            var p1 = await child.PostAsync(partido);
            partido.ID = p1.Key;
        }


        public static List<Partido> calendario = null;
        public static async Task getPartidosFB()
        {
            if (calendario == null)
            {
                calendario = new List<Partido>();
            }

            var firebase = new FirebaseClient("https://ligapingpong-17f52.firebaseio.com/");

            var calen = await firebase.Child("liga/partidos/").OnceAsync<Partido>();

            foreach (var p1 in calen)
            {
                Partido j = p1.Object;
                calendario.Add(j);
            }

        }

        public static async Task deletePartido(Partido p)
        {
            var client = new FirebaseClient("https://ligapingpong-17f52.firebaseio.com/");
            var child = client.Child("liga/partidos/" + p.ID);

            await child.DeleteAsync();
        }

        public static async Task deleteLiga()
        {
            var client = new FirebaseClient("https://ligapingpong-17f52.firebaseio.com/");
            var child = client.Child("liga/partidos/" );

            await child.DeleteAsync();
        }

        #endregion

    }
}
