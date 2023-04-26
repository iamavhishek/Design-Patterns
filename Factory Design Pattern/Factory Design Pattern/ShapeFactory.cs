using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    public class ShapeFactory
    {
        public Shape GetShape(String shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if (string.Equals(shapeType, "CIRCLE", StringComparison.OrdinalIgnoreCase))
            {
                return new Circle();
            }
            if (string.Equals(shapeType, "RECTANGLE", StringComparison.OrdinalIgnoreCase))
            {
                return new Rectangle();
            }
            if (string.Equals(shapeType, "SQUARE", StringComparison.OrdinalIgnoreCase))
            {
                return new Square();
            }
            return null;
        }
    }
}
