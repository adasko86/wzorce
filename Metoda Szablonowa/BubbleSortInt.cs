using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoda_Szablonowa
{
    public class BubbleSortInt : BubbleSortAbstract
    {
        private int[] array = null;
        public int sort(int[] theArray)
        {
            array = theArray;
            length = array.Count();
            return doSort();
        }
        protected override void swap(int index)
        {
            int temp = array[index];
            array[index] = array[index + 1];
            array[index + 1] = temp;
        }

        protected override bool outOfOrder(int index)
        {
            return (array[index] > array[index + 1]);
        }

        public override string ToString()
        {
            return string.Join(" ", array).ToString();
        }
    }
}
