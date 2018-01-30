using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoda_Szablonowa
{
    public abstract class BubbleSortAbstract
    {
        private int operations = 0;
        protected int length = 0;
        protected int doSort()
        {
            operations = 0;
            if (length <= 1)
                return operations;
            for (int nextToLast = length - 2;
            nextToLast >= 0; nextToLast--)
                for (int index = 0; index <= nextToLast; index++)
                {
                    if (outOfOrder(index))
                        swap(index);
                    operations++;
                }
            return operations;
        }
        protected abstract void swap(int index);
        protected abstract bool outOfOrder(int index);
    }
}
