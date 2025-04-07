using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Vypocet
    {
        

        double Procento(double chybelHodin, long celkemHodin)
        {
            return chybelHodin / celkemHodin * 100;
        }

        public void VypocetHodin(long celkemHodin, long chybelHodin, long zbyvaHodin)
        {
            Console.WriteLine("Procento chybejicich hodin ted je: " + Procento(chybelHodin, celkemHodin) + "%.");
            //chybelHodin++;
            //celkemHodin++;
            if(zbyvaHodin> 0) { 
            celkemHodin += zbyvaHodin;
            }
            Console.WriteLine("Procento chybejicich hodin ted bude: " + Procento(chybelHodin, celkemHodin) + "%.");

        }
    }
}
