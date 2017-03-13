using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    class Partido
    {
        
        public Jugador j1 { get; set; }
        public Jugador j2 { get; set; }
        public int marcadorJ1 {get;set;}
        public int marcadorJ2 { get; set; }


        public Partido(Jugador juno,Jugador jdos)
        {
            j1 = juno;
            j2 = jdos;
        }


        public void setMarcador(int uno, int dos)
        {
            marcadorJ1 = uno;
            marcadorJ2 = dos;

            if (marcadorJ1>marcadorJ2)
            {
                j1.puntos = j1.puntos + 3;
            }
            else
            {
                j2.puntos = j2.puntos + 3;
            }
            
        }



        public Boolean getFinishGame()
        {
            return ((marcadorJ1 != null) && (marcadorJ2 != null)) ? true :false;
        }

        
    }
}
