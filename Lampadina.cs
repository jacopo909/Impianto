using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impianto
{
    class Lampadina
    {
        private static int accesa = 1;
        private static int spenta = 0;
        private const int rotta = 2;
        private static int rottura = 50;
        private int click = 0;
        private int stato = spenta;


        public int NumeroClick { get; set; }


        public Lampadina() { }

        public int Click()
        {

            click = click + 1;
            if (click >= rottura)
            {
                stato = rotta;
            }
            else
            {
                if (stato == spenta)
                {
                    stato = accesa;
                }
                else
                {
                    stato = spenta;
                }
            }

            return stato;
        }
        public string Visualizza()
        {
            if (stato == rotta)
            {
                return "La lampadina è rotta";
            }
            if (stato == accesa)
            {
                return "La lampadina è accesa";
            }
            else
            {
                return "La lampadina è spenta";
            }
        }
    }
}
