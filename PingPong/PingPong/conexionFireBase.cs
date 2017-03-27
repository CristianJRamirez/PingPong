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
        //private Jugador jugador;

        /// <summary> Agregar Jugador al Firebase  </summary>
        /// <returns></returns>
        public static async Task setJugadorFB(Jugador jugador)
        {
            var client = new FirebaseClient("https://ligapingpong-17f52.firebaseio.com/");
            var child = client.Child("jugadors/");

            var p1 = await child.PostAsync(jugador);
            //jugador.Id = p1.Key;
        }

        /// <summary> Devolver los jugadores en la BBDD </summary>
        /// <param name="players">En que lista se quieren los jugadores</param>
        /// <returns></returns>
        public static async Task getJugadoresFB(List<Jugador> players)
        {
            if (players ==null)
            {
                players = new List<Jugador>();
            }

            var firebase = new FirebaseClient("https://ligapingpong-17f52.firebaseio.com/");

            var jugadores = await firebase.Child("jugadors").OnceAsync<Jugador>();


           // string msg = "";

            //List<Jugador> players = new List<Jugador>();

            foreach (var p1 in jugadores)
            {
                Jugador j = p1.Object;
                players.Add(j);
               // msg += j.Nombre + "\n";
            }

            //return players;
        }
    }
}
