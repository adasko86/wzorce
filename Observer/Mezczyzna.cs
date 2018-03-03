using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Mezczyzna : Observable, Observator
    {
        String name;
        private List<Observator> observators = new List<Observator>();

        public Mezczyzna(String name)
        {
            this.name = name;
        }

        public void update(string changeFrom, string changeTo)
        {
            Console.WriteLine(name + " wlasnie zauwazyl, ze Kobieta zmienila " + changeFrom + " na " + changeTo + ".");
        }

        public void addObservator(Observator obj)
        {
            if (obj != null)
                observators.Add(obj);
        }

        public void deleteObservator(Observator obj)
        {
            this.observators.Remove(obj);
        }

        public void notifyObservator()
        {
            foreach (Observator ob in observators)
                ob.update("bluzke", "koszule");
        }

        public void changeBlouseToShirt()
        {
            Console.WriteLine(name + " zmienia bluzke na koszule.");
            notifyObservator();
        }
    }
}
