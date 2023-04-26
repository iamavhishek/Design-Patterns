using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class ObserverMain
    {
        public static void Main(String[] args)
        {
            Person p1 = new Person("Asraf");
            Person p2 = new Person("Aslam");

            Product mayos = new Product("Mayos", "Not available");
            //if you want to know when product is available
            // attach method
            // get executed
            mayos.Attach(p1);
            mayos.Attach(p2);
            // Now product is available
            mayos.SetAvailability("Available");
            mayos.Detach(p2);
            mayos.SetAvailability("Not Available");
        }
    }
}
