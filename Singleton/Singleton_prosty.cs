using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton_prosty
    {
        //Tworzymy stałą typu Singleton_prosty
        public static readonly Singleton_prosty instance = new Singleton_prosty();
        public String name = null;
        private Singleton_prosty()
        { 
        
        }
    }
}
