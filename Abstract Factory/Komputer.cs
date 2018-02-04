using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public abstract class Komputer
    {
        public IDysk dysk;
        public IGrafika grafika;
        public IRam ram;
        public IProcesor procesor;
        public IChlodzenie chlodzenie;

        public abstract void skladanie();

        public void instalowanieOprogramowania()
        {
            Console.WriteLine("Instaluje oprogramowanie...");
        }

        public void pakowanie()
        {
            Console.WriteLine("Pakuje sprzet...");
        }
        public void sprzedawanie()
        {
            Console.WriteLine("Sprzedaje sprzet...");
        }
    }

    class KomputerPC : Komputer
    {
        IFabrykaPodzespolowKomputerowych fabrykaPodzespolowKomputerowych;

        public KomputerPC(IFabrykaPodzespolowKomputerowych f)
        {
            fabrykaPodzespolowKomputerowych = f;
            skladanie();
        }

        public override void skladanie()
        {
            dysk = fabrykaPodzespolowKomputerowych.produkujemyDysk().dodajDysk();
            grafika = fabrykaPodzespolowKomputerowych.produkujemyGrafike().dodajGrafike();
            procesor = fabrykaPodzespolowKomputerowych.produkujemyProcesor().dodajProcesor();
            ram = fabrykaPodzespolowKomputerowych.produkujemyRam().dodajRam();
        }
    }

    class Laptop : Komputer
    {
        FabrykaPodzespolowLaptop fabrykaPodzespolowLaptop;

        public Laptop(FabrykaPodzespolowLaptop fabrykaPodzespolowLaptop)
        {
            this.fabrykaPodzespolowLaptop = fabrykaPodzespolowLaptop;
            skladanie();
        }

        public override void skladanie()
        {
            dysk = fabrykaPodzespolowLaptop.produkujemyDysk().dodajDysk();
            grafika = fabrykaPodzespolowLaptop.produkujemyGrafike().dodajGrafike();
            procesor = fabrykaPodzespolowLaptop.produkujemyProcesor().dodajProcesor();
            ram = fabrykaPodzespolowLaptop.produkujemyRam().dodajRam();
            chlodzenie = fabrykaPodzespolowLaptop.produkujemyChlodzenie().dodajChlodzenie();
        }
    }

}
