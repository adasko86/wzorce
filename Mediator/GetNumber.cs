using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator
{
    class GetNumber
    {
        private Mediator mediator;


        public GetNumber(Mediator m)
        {
            mediator = m;
        }

        public void run()
        {
            while (true)
            {
                Thread.Sleep(3500);
                Console.WriteLine("Getter " + mediator.countgetter + " - " + mediator.retrieveMessage());
            }
        }
    }
}
