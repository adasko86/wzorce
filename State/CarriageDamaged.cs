<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class CarriageDamaged : CarriageState
    {
        public void reportPosition(Carriage carriage)
        {
            Console.WriteLine(String.Format("Wagon: {0} jest w naprawie", carriage.getNumber()));
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
    public class CarriageDamaged : CarriageState
    {
        public void reportPosition(Carriage carriage)
        {
            Console.WriteLine(String.Format("Wagon: {0} jest w naprawie", carriage.getNumber()));
        }
    }
}
>>>>>>> 4caa80cb97af2f3fb4fcb5527a83d779863544dc
