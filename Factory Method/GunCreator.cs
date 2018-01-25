using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    /// <summary>
    /// Singleton
    /// </summary>
    public class GunCreator : I_GunCreator
    {
        private static GunCreator instance = null;
        private GunCreator()
        {

        }

        public static readonly object lockObject = new object();
        public static GunCreator getInstance()
        {
            lock (lockObject)
            {
                instance = new GunCreator();
            }
            return instance;
        }


        public I_AbstractGun create(GunType gunType)
        {
            I_AbstractGun abstractGun;
            switch (gunType)
            {
                case GunType.AK47:
                    AK47 ak = new AK47();
                    ak.setPrice((float)1500);
                    abstractGun = ak;
                    break;
                case GunType.Famas:
                    Famas famas = new Famas();
                    famas.setPrice((float)2500);
                    abstractGun = famas;
                    break;
                case GunType.Rewolwer:
                    Rewolwer rewolwer = new Rewolwer();
                    rewolwer.setPrice(1000);
                    abstractGun = rewolwer;
                    break;
                default:
                    abstractGun = null;
                    break;
            }
            return abstractGun;
        }
    }
}
