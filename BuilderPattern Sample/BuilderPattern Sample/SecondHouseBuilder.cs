using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_Sample
{

    class SecondHouseBuilder : HouseBuilder
    {
    private House house;

    public SecondHouseBuilder()
    {
        this.house = new House();
    }

    public void BuildBasement()
    {
        house.SetBasement("Wooden Poles");
    }

    public void BuildStructure()
    {
        house.SetStructure("Wood and Ice");
    }

    public void BuildInterior()
    {
        house.SetInterior("Fire Wood");
    }

    public void BuildRoof()
    {
        house.SetRoof("Wood, caribou and seal skins");
    }

    public House GetHouse()
    {
        return this.house;
    }

}
}
