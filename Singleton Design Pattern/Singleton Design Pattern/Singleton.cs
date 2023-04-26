using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Design_Pattern
{
    public class Singleton
    {

        private int count;
        private static Singleton single;
        private Singleton() {
            count = 0;
        }
        public static Singleton getInstance()
        {
            if (single == null)
                single = new Singleton();
            return single;
        }
        public void Method()
        {
            count++;    
            Console.WriteLine($"Count value is{count}");
        }
    }
}
