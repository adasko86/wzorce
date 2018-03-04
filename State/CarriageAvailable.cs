<<<<<<< HEAD
﻿using System;
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
=======
﻿using System;
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
>>>>>>> 4caa80cb97af2f3fb4fcb5527a83d779863544dc
