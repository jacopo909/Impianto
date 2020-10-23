using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impianto
{
    class Program
    {
        static void Main(string[] args)
        {
            Lampadina l = new Lampadina();
            Console.WriteLine("Quanti Click vuoi effettuare?");
            l.NumeroClick = int.Parse(Console.ReadLine());
            for (int i = 0; i < l.NumeroClick; i++)
            {
                l.Click();
                Console.WriteLine(l.Visualizza());
               
            }
        }
    }
}
