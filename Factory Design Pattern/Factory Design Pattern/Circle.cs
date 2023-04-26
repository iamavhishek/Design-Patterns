using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    public class Circle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("This is Circle::Draw() method");
        }
    }
}
