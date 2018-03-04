<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class CarriageUnavailable : CarriageState
    {
        public void reportPosition(Carriage carriage) {
		Console.WriteLine(String.Format("Wagon: {0} jest niedostepny - w trakcie realizacji przewozu", carriage.getNumber()));
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
    public class CarriageUnavailable : CarriageState
    {
        public void reportPosition(Carriage carriage) {
		Console.WriteLine(String.Format("Wagon: {0} jest niedostepny - w trakcie realizacji przewozu", carriage.getNumber()));
	}
    }
}
>>>>>>> 4caa80cb97af2f3fb4fcb5527a83d779863544dc
