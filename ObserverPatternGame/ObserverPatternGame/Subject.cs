using System.Threading;
using System.Threading.Tasks.Dataflow;

public class Subject : ISubject
{
    //The initial state of subject (Ball) is stored this variable and initially it is set to -0
    public int State { get; set; } = -0;
    private List<IObserver> _observers = new List<IObserver>();
    public void Attach(IObserver observer)
    {
        //Limit the no of Player who guess the state of subject to 1
        if (_observers.Capacity <1)
        {
            Console.WriteLine("Subject(Ball): Attached an observer(A player).");
            this._observers.Add(observer);

        }
        
    }

    public void Detach(IObserver observer)
    {
        if (_observers.Capacity <= 1)
        {

        }
        else
        {
            this._observers.Remove(observer);
            Console.WriteLine("Subject(Ball): Detached from an observer(A player).");
        }
            
    }
    public bool Notify()
    {
        if (_observers.Count != 1)
        {

        }
        else
        {
            foreach (var observer in _observers)
            {
                return observer.Update(this);
            }

        }
        return true;
      
        
    }
    public void BallPass()
    {
        bool t = false;
        do
        {
            Thread.Sleep(2000);
            this.State = new Random().Next(1, 5);
            Console.WriteLine("\nBall is with Player {0}",State);
            Thread.Sleep(1000);
            t = this.Notify();
        } while (!t);
        Console.WriteLine("\nGame Over");
        
    }

}