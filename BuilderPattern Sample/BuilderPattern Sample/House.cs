using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_Sample
{
    class House : HousePlan
    {


    private String basement;
    private String structure;
    private String roof;
    private String interior;

    public void SetBasement(String basement)
    {
        this.basement = basement;
    }

    public void SetStructure(String structure)
    {
        this.structure = structure;
    }

    public void SetRoof(String roof)
    {
        this.roof = roof;
    }

    public void SetInterior(String interior)
    {
        this.interior = interior;
    }

}
}
