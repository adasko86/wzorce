using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class CarriageAvailable : CarriageState
    {
        public void reportPosition(Carriage carriage)
        {
            Console.WriteLine("Wagon: " + carriage.getNumber() + " rozporządzalny oczekuje na bocznicy : " + carriage.getSidingNumber() + " na torze " + carriage.getTrack());
        }
    }
}
