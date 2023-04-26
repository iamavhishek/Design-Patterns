using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class Product : Subject
    {


    private List<Observer> observers = new List<Observer>();
    private String productName;
    private String availability;

    public Product(String productName, String availability)
    {
        this.productName = productName;
        this.availability = availability;
    }

    public void SetAvailability(String availability)
    {
        this.availability = availability;
        NotifyObservers();
    }

    public void NotifyObservers()
    {
        Console.WriteLine("Notifying to all the subscribers");
        foreach (Observer ob in observers)
        {
            ob.update(this.availability);
        }
    }

    public void Attach(Observer observer)
    {
        observers.Add(observer);
    }

    public void Detach(Observer observer)
    {
        observers.Remove(observer);
    }
}
}
