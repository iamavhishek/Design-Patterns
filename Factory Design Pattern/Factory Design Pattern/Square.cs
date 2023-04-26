using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    public class Square : Shape
    {
        public void Draw()
        {
            Console.WriteLine("This is Square::Draw() method");
        }
    }
}
