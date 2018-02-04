using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Factory
{
    public class FabrykaKomputerow
    {
        public Komputer zlozKomputer(string model)
        {
            Komputer komputer = null;
            if (model.Equals("PC"))
            {
                komputer = new KomputerPC(new FabrykaPodzespolowPC());
            }
            else if (model.Equals("Laptop"))
            {
                komputer = new Laptop(new FabrykaPodzespolowLaptop());
            }
            return komputer;
        }

        public Komputer wydajKomputer(string model)
        {
            Komputer komputer = zlozKomputer(model);
            komputer.instalowanieOprogramowania();
            komputer.pakowanie();
            komputer.sprzedawanie();
            return komputer;
        }
    }
}
