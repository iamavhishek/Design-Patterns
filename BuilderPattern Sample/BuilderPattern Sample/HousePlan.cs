using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_Sample
{
    interface HousePlan
    {
        public void SetBasement(String basement);

        public void SetStructure(String structure);

        public void SetRoof(String roof);

        public void SetInterior(String interior);
    }

}
