using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoda_Szablonowa
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort bubbleSort = new BubbleSort();
            Console.WriteLine(bubbleSort.sort(new int[] { 65, 4, 5, 8, 90, 44, 75, 3, 88, 22 }) + " Lista: " + bubbleSort.ToString());
            BubbleSortInt intSort = new BubbleSortInt();
            Console.WriteLine(intSort.sort(new int[] { 65, 4, 5, 8, 90, 44, 75, 3, 88, 22 }) + " Lista: " + intSort.ToString());
            BubbleSortDouble doubleSort = new BubbleSortDouble();
            Console.WriteLine(doubleSort.sort(new double[] { 65.2, 5.9, 8.0, 90, 3, 88.7, 22.6, 75.77, 2.82 }) + " Lista: " + doubleSort.ToString());
            Console.Read();
        }
    }
}
