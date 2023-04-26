using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class Person : Observer
    {

    private String personName;
    public Person(String personName)
    {
        this.personName = personName;
    }
    public void update(String availabiliy)
    {
       Console.WriteLine("Hello " + personName +
                ", Product is now " +
                availabiliy +
                " on daraz");
    }
}
}
