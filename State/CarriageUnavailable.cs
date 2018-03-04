using System;
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
