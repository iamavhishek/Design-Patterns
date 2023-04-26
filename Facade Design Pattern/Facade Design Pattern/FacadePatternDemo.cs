using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Design_Pattern
{
    public class FacadePatternDemo
    {
        public static void Main(String[] args)
        {
            ShapeMaker shapeMaker = new ShapeMaker();

            shapeMaker.DrawCircle();
            shapeMaker.DrawRectangle();
            shapeMaker.DrawSquare();
        }
    }
}
