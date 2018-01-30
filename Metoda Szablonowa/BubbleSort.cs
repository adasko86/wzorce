using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoda_Szablonowa
{
    public class BubbleSort
    {
        int operations = 0;
        int[] _array;
        public int sort(int[] array)
        {
            operations = 0;
            if (array.Count() <= 1)
                return operations;
            for (int nextToLast = array.Count() - 2;
            nextToLast >= 0; nextToLast--)
                for (int index = 0; index <= nextToLast; index++)
                    compareAndSwap(array, index);
            _array = array;
            return operations;
        }

        private void swap(int[] array, int index)
        {
            int temp = array[index];
            array[index] = array[index + 1];
            array[index + 1] = temp;
        }

        private void compareAndSwap(int[] array, int index)
        {
            if (array[index] > array[index + 1])
                swap(array, index);
            operations++;
        }

        public override string ToString()
        {
            return string.Join(" ", _array).ToString();
        }
    }
}
