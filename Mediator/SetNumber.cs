using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator
{
    class SetNumber
    {
        private Mediator mediator;
        private int no;

        public SetNumber(Mediator m)
        {
            mediator = m;
            no++;
        }

        public void run()
        {
            int num;
            while (true)
            {
                Thread.Sleep(2500);
                mediator.storeMessage(num = (int)(new Random().Next(54200)));
                Console.WriteLine("Setter " + mediator.countsetter + " - " + num + " ");
            }
        }
    }
}
