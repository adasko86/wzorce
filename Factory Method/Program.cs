using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            GunCreator gunCreator = GunCreator.getInstance();
            I_AbstractGun akGun = gunCreator.create(GunType.AK47);
            Console.WriteLine(akGun.ToString());
            Console.WriteLine();
            I_AbstractGun famasGun = gunCreator.create(GunType.Famas);
            Console.WriteLine(famasGun.ToString());
            Console.Read();
        }
    }
}
