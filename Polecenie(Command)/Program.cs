using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polecenie_Command_
{
    class Program
    {
        public enum PrintCommand
        {
            wlacz,
            drukuj,
            wylacz
        }

        static void Main(string[] args)
        {
            Trener trener = new Trener();
            Zawodnik z1 = new Zawodnik("Kowalski");
            Zawodnik z2 = new Zawodnik("Nowak");
            Zawodnik z3 = new Zawodnik("Brzeczyszczykiewicz");
 
            Bieganie bieganie = new Bieganie(z1);
            Plywanie plywanie = new Plywanie(z2);
 
            trener.setMode(bieganie);
            trener.rozkaz();
            trener.setMode(plywanie);
            trener.rozkaz();
            trener.cofnij();
 
            Polecenie []tab = { new Cwiczenie(z3), new Bieganie(z3), new Plywanie(z3)};
            PelnyTrening pelnyTrening = new PelnyTrening(tab);
            trener.setMode(pelnyTrening);
            trener.rozkaz();



            Command commandWlacz = new Wlacz();
            commandWlacz.run();
            Command commandDrukuj = new Drukuj();
            commandDrukuj.run();
            Command commandWylacz = new Wylacz();
            commandWylacz.run();

            Console.Read();
        }
    }
}
