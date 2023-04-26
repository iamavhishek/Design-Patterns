using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Design_Pattern
{
    public class Circle : Shape
    {

       // @Override
       public void Draw()
        {
           Console.WriteLine("Circle::draw()");
        }
    }
}
