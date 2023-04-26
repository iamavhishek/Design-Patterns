using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Design_Pattern
{
    //Facade Class
    public class ShapeMaker
    {
        private Shape circle;
        private Shape rectangle;
        private Shape square;

        public ShapeMaker()
        {
            circle = new Circle();
            rectangle = new Rectangle();
            square = new Square();
        }

        public void DrawCircle()
        {
            circle.Draw();
        }
        public void DrawRectangle()
        {
            rectangle.Draw();
        }
        public void DrawSquare()
        {
            square.Draw();
        }
    }
}
