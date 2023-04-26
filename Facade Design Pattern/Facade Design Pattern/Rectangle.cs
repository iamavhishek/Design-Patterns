using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Design_Pattern
{
    public class Rectangle : Shape
    {

    // @Override
       public void Draw()
        {
            Console.WriteLine("Rectangle::draw()");
        }
    }
}
