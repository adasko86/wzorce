using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Class_Description> description = new List<Class_Description>();
            Console.WriteLine("Zajętość pamięci przed utworzeniem obiektu:");
            Console.WriteLine(GC.GetTotalMemory(true) + "b");
            long size = GC.GetTotalMemory(true);
            Class_DescriptionCreator creator = new Class_DescriptionCreator();
            for (int i = 0; i < 100; i++)
            {
                creator.createRelation("moja super nazwa");
            }
            Console.WriteLine("Zajętość pamięci po utworzeniu Description:");
            Console.WriteLine(GC.GetTotalMemory(true) + "b");

            Console.WriteLine(GC.GetTotalMemory(true) + " - " + size + " = " + (GC.GetTotalMemory(true) - size) + "b");


            Console.WriteLine("");


            Console.WriteLine("Zajętość pamięci przed utworzeniem obiektów:");
            Console.WriteLine(GC.GetTotalMemory(true) + "b");
            size = GC.GetTotalMemory(true);
            for (int i = 0; i < 100; i++)
            {
               description.Add(new Class_Description("moja super nazwa"));
            }
            Console.WriteLine("Zajętość pamięci po utworzeniu Description:");
            Console.WriteLine(GC.GetTotalMemory(true) + "b");

            Console.WriteLine(GC.GetTotalMemory(true) + " - " + size + " = " + (GC.GetTotalMemory(true) - size) + "b");
            Console.Read();
        }
    }
}
