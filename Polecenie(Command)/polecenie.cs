using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polecenie_Command_
{

    interface Polecenie
    {
        void wykonaj();
        void cofnij();
    }


    /* obiekt wywolujacy */
    class Trener
    {
        private Polecenie mode;
        public void setMode(Polecenie polecenie)
        {
            mode = polecenie;
        }

        public void rozkaz()
        {
            mode.wykonaj();
        }

        public void cofnij()
        {
            mode.cofnij();
        }
    }


    /* odbiorca */
    class Zawodnik
    {
        private String id;
        public Zawodnik(String id)
        {
            this.id = id;
        }

        public void zacznijBiegac()
        {
            Console.WriteLine("zawodnik " + id + " biega");
        }

        public void przestanBiegac()
        {
            Console.WriteLine("zawodnik " + id + " przestal biegac");
        }

        public void zacznijPlywac()
        {
            Console.WriteLine("zawodnik " + id + " plywa");
        }

        public void przestanPlywac()
        {
            Console.WriteLine("zawodnik " + id + " przestal plywac");
        }

        public void zacznijCwiczyc()
        {
            Console.WriteLine("zawodnik " + id + " cwiczy");
        }

        public void przestanCwiczyc()
        {
            Console.WriteLine("zawodnik " + id + " przestal cwiczyc");
        }
    }


    /* Polecenie */
    class Bieganie : Polecenie
    {
        private Zawodnik zawodnik;  //obiekt wykonujacy
        public Bieganie(Zawodnik zawodnik)
        {
            this.zawodnik = zawodnik;
        }

        public void wykonaj()
        {
            zawodnik.zacznijBiegac();
        }

        public void cofnij()
        {
            zawodnik.przestanBiegac();
        }
    }


    /* Polecenie */
    class Plywanie : Polecenie
    {
        private Zawodnik zawodnik;  //obiekt wykonujacy
        public Plywanie(Zawodnik zawodnik)
        {
            this.zawodnik = zawodnik;
        }

        public void wykonaj()
        {
            zawodnik.zacznijPlywac();
        }

        public void cofnij()
        {
            zawodnik.przestanPlywac();
        }
    }


    /* Polecenie */
    class Cwiczenie : Polecenie
    {
        private Zawodnik zawodnik;  //obiekt wykonujacy
        public Cwiczenie(Zawodnik zawodnik)
        {
            this.zawodnik = zawodnik;
        }

        public void wykonaj()
        {
            zawodnik.zacznijCwiczyc();
        }

        public void cofnij()
        {
            zawodnik.przestanCwiczyc();
        }

    }


    /* Polecenie */
    class PelnyTrening : Polecenie
    {
        Polecenie[] tab = null;

        public PelnyTrening(Polecenie[] tab)
        {
            this.tab = tab;
        }

        public void wykonaj()
        {
            foreach(Polecenie temp in tab)
            {
                temp.wykonaj();
            }
        }

        public void cofnij()
        {
            foreach (Polecenie temp in tab)
            {
                temp.cofnij();
            }
        }
    }
}
