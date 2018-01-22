using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton instance = null;
        public String name = null;

        /// <summary>
        /// Konstruktor domyślny jest prywatny przez co nie utworzymy żadnej instancji klasy
        /// </summary>
        private Singleton()
        {
        
        }

        private static readonly object syncLock = new object();

        /// <summary>
        /// Metoda ktora zwraca nam instancję obiektu, który może wystąpić tylko i wyłącznie raz
        /// </summary>
        /// <returns>Metoda zwraca instancje klasy Singleton</returns>
        public static Singleton getSingleton()
        {
            ///lock jest stworzony po to aby aplikacja działająca na wielu wątkach nie porobiła nas podczas sprawdzania czy instancja istnieje
            lock (syncLock)
            {
                //jeżeli instance == null to tworzymy nowy obiekt inaczej zwtacamy instance
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
    }
}
