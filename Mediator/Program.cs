using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator mediator = new Mediator();
            GetNumber gn = new GetNumber(mediator);
            SetNumber sn = new SetNumber(mediator);
            
            Thread th = new Thread(gn.run);
            th.Start();

            th = new Thread(sn.run);
            th.Start();
            Console.ReadLine();
        }
    }
}
