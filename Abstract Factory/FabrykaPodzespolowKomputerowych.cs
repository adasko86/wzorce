using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    interface IFabrykaPodzespolowKomputerowych
    {
        IDysk produkujemyDysk();
        IGrafika produkujemyGrafike();
        IRam produkujemyRam();
        IProcesor produkujemyProcesor();
        IChlodzenie produkujemyChlodzenie();
    }

    class FabrykaPodzespolowPC : IFabrykaPodzespolowKomputerowych
    {
        public IDysk produkujemyDysk()
        {
            return new DyskDlaPC();
        }

        public IGrafika produkujemyGrafike()
        {
            return new GrafikaDlaPC();
        }

        public IRam produkujemyRam()
        {
            return new DDR3();
        }

        public IProcesor produkujemyProcesor()
        {
            return new ProcesorDlaPC();
        }

        public IChlodzenie produkujemyChlodzenie()
        {
            return null;
        }
    }

    class FabrykaPodzespolowLaptop : IFabrykaPodzespolowKomputerowych
    {
        public IDysk produkujemyDysk()
        {
            return new DyskDlaLaptopa();
        }

        public IGrafika produkujemyGrafike()
        {
            return new GrafikaDlaLaptopa();
        }

        public IRam produkujemyRam()
        {
            return new DDR2();
        }

        public IProcesor produkujemyProcesor()
        {
            return new ProcesorDlaLaptopa();
        }

        public IChlodzenie produkujemyChlodzenie()
        {
            return new ChlodzenieDlaLaptopa();
        }
    }
}
