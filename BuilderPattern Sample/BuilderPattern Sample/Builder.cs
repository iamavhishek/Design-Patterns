using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_Sample
{
    class Builder
    {
        public static void Main(String[] args)
        {
            HouseBuilder firtHouseBuilder = new FirstHouseBuilder();
            CivilEngineer engineer1 = new CivilEngineer(firtHouseBuilder);

            engineer1.ConstructHouse();

            House house1 = engineer1.GetHouse();

            Console.WriteLine("Builder constructed: " + house1);


            HouseBuilder secondHouseBuilder = new SecondHouseBuilder();
            CivilEngineer engineer2 = new CivilEngineer(secondHouseBuilder);

            engineer2.ConstructHouse();

            House house2 = engineer2.GetHouse();

            Console.WriteLine("Builder constructed: " + house2);
        }
    }
}
