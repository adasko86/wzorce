using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Kobieta : Observator, Observable
    {
        List<Observator> observators = new List<Observator>();
        private string name = null;
        public Kobieta(String _name)
        {
            name = _name;
        }

        public void changeTrousersToSkirt()
        {
            Console.WriteLine(name + " zmienia spodnie na spodniczke :) ");
            notifyObservator();
        }

        public void addObservator(Observator obj)
        {
            if (obj != null && !observators.Contains(obj))
                observators.Add(obj);
        }

        public void deleteObservator(Observator obj)
        {
            if (obj != null && observators.Contains(obj))
                observators.Remove(obj);
        }

        public void notifyObservator()
        {
            foreach (Observator observator in observators)
                observator.update("spodnie", "spodniczke");
        }

        public void update(string changeFrom, string changeTo)
        {
            Console.WriteLine(name + " zauwaza ze ktos zmienil " + changeFrom + " na " + changeTo + ", mrr.. :)");
        }
    }
}
