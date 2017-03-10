using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    public class Jugador
    {
        public string nombre { get; set; }
        public string puntos { get; set; }

        public Jugador() { }

        public Jugador (string name)
        {
            nombre = name;
        }

        public Jugador(string name,string punt)
        {
            nombre = name;
            puntos = punt;
        }

        public override string ToString()
        {
            return "Jugador -> "+nombre;
        }
    }
}
