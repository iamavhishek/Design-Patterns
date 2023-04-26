public class Program
{
    public static void Main(string[] args)
    {
        var subject = new Subject();   //Creates a ball
        var observer = new ObserverPlayer();
        subject.Attach(observer);
        subject.BallPass();

    }
}