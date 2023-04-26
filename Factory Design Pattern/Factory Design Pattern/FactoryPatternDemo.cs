using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    public class FactoryPatternDemo
    {
        public static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            //Factory creates circle
            Shape circle = shapeFactory.GetShape("circle");
            circle.Draw();

            Shape rectangle = shapeFactory.GetShape("Rectangle");
            rectangle.Draw();

            Shape square = shapeFactory.GetShape("Square");
            square.Draw();


        }
        
    }
}
