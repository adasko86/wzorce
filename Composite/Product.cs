using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Product : ProductAbstract
    {
        String name;
        public Product(String name)
        {
            this.name = name;
        }

        public string getProductName()
        {
            return this.name;
        }

        public void showMe()
        {
            Console.WriteLine("Produkt" + this.getProductName());
        }

        public void addChild(ProductAbstract p)
        {
            Console.WriteLine("Nie można dodać dziecka, ponieważ produkt jest liściem w strukturze drzewiastej");
        }

        public void removeChild(ProductAbstract p)
        {
            Console.WriteLine("Nie można usunąć dziecka, ponieważ produkt jest liściem w strukturze drzewiastej");
        }
    }
}
