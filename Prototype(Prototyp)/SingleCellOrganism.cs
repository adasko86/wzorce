using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Prototyp_
{
    class SingleCellOrganism : Cell
    {
        int cellnumber;

        public SingleCellOrganism(int CellNumber)
        {
            cellnumber = CellNumber;
            Count();
        }
        public override Cell Split(int cellnumber)
        {
            return new SingleCellOrganism(cellnumber);
        }

        public void Count()
        {
            Console.WriteLine("Cell number: " + cellnumber);
        }
    }
}
