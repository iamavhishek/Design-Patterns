using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_Sample
{
    interface HouseBuilder
    {
        public void BuildBasement();

        public void BuildStructure();

        public void BuildRoof();

        public void BuildInterior();

        public House GetHouse();
    }

}
