using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Prototyp_
{
    class Program
    {
        static void Main(string[] args)
        {
            int cellnumber = 0;

            SingleCellOrganism singlecell = new SingleCellOrganism(++cellnumber);

            Cell cell1 = singlecell.Split(++cellnumber);
            Cell cell2 = singlecell.Split(++cellnumber);
            Cell cell3 = singlecell.Split(++cellnumber);
            Cell cell4 = singlecell.Split(++cellnumber);

            Console.ReadKey();
        }
    }
}
