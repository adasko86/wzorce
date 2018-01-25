using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluence_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Class_ProblemCat c1 = new Class_ProblemCat("Puszek", "Adam");
            c1.Name = "Puszkin";
            c1.Owner = "Adam";
            c1.Age = 3;
            c1.Color = "Bury";

            Console.WriteLine(c1.ToString());
                
            Class_cat cat = new Builder("Koteczek")
                ._age(3)
                ._color("Bury")
                ._owner("Adam")
                .build();

            Console.WriteLine(cat.ToString());
           // PrzykladFluency a = new PrzykladFluency();
            Console.ReadLine();
        }
    }

    public class PrzykladFluency :Fluency.FluentBuilder<Class_cat>
    {
        public PrzykladFluency()
        {
            Class_cat cat = new Fluency.DynamicFluentBuilder<Class_cat>()
                .For(x => x.Name, "abc")
                .For(x => x.Owner, "cccc")
                .For(x => x.Age, 9)
                .For(x => x.Color, "Rudy")
                .build();
        }
    }
}
