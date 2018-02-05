using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Composite : ProductAbstract
    {
        private List<ProductAbstract> _children = new List<ProductAbstract>();
        String name;
        public Composite(String name)
        {
            this.name = name;
        }
        public string getProductName()
        {
            return this.name;
        }

        public void showMe()
        {
            Console.WriteLine("Komponent " + this.getProductName());
            foreach(ProductAbstract pa in _children)
            {
                pa.showMe();
            }
        }

        public void addChild(ProductAbstract p)
        {
            _children.Add(p);
        }

        public void removeChild(ProductAbstract p)
        {
            _children.Remove(p);
        }
    }
}
