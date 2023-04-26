using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_Sample
{
    class FirstHouseBuilder : HouseBuilder
    {
    private House house;

    public FirstHouseBuilder()
    {
        this.house = new House();
    }

    public void BuildBasement()
    {
        house.SetBasement("Ice Bars");
    }

    public void BuildStructure()
    {
        house.SetStructure("Ice Blocks");
    }

    public void BuildInterior()
    {
        house.SetInterior("Ice Carvings");
    }

    public void BuildRoof()
    {
        house.SetRoof("Ice Dome");
    }

    public House GetHouse()
    {
        return this.house;
    }
}
}
