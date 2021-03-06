﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    public class Partido
    {
        public string ID { get; set; }
        public Jugador j1 { get; set; }
        public Jugador j2 { get; set; }
        public int marcadorJ1 {get;set;}
        public int marcadorJ2 { get; set; }
        public bool done { get; set; }


        public Partido()
        {
        }

        public Partido(Jugador juno,Jugador jdos)
        {
            j1 = juno;
            j2 = jdos;
        }
        public Partido(string id,Jugador juno, Jugador jdos,int marc1, int marc2,bool don)
        {
            ID = id;
            j1 = juno;
            j2 = jdos;
            marcadorJ1 = marc1;
            marcadorJ2 = marc2;
            done=don;
        }


        public string setMarcador(int uno, int dos)
        {
            marcadorJ1 = uno;
            marcadorJ2 = dos;
            string quien = string.Empty;

            if (marcadorJ1>marcadorJ2)
            {
                int puntos = int.Parse(j1.puntos) + 3;
                j1.puntos =  +puntos + "";
                quien = j1.nombre;
            }
            else
            {
                int puntos = int.Parse(j2.puntos) + 3;
                j2.puntos = puntos + "";
                quien = j2.nombre;
            }
            done = true;
            return quien;
        }



        public Boolean getFinishGame()
        {
            return done;
        }


        public override string ToString()
        {
            return "Partido -> " + j1.nombre + " - " + j2.nombre;
        }

    }
}
