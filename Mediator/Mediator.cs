using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator
{
    class Mediator
    {
        private bool slotFull = false;
        private int number;
        public int countsetter = 0;
        public int countgetter = 1;

        public void storeMessage(int num)
        {
            countsetter++;
            number = num;
        }

        public int retrieveMessage()
        {
            countgetter++;
            return number;
        }
    }
}
