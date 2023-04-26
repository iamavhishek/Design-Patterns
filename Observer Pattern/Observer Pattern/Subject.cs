using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public interface Subject
    {
        public void Attach(Observer observer);

        public void Detach(Observer observer);

        public void NotifyObservers();
    }
}
