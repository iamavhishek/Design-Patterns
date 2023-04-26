using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Design_Pattern
{
    public class SingletonMain
    {
        public static void Main(String[] args)
        {
            Singleton s = Singleton.getInstance();

            //Doesnt create new object
            Singleton t = Singleton.getInstance();
            s.Method();
            t.Method();
        }
    }
}
