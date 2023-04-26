public class ObserverPlayer : IObserver
{
    public bool Update(ISubject subject)
    {
        int guess = new Random().Next(1, 5);
        Console.WriteLine("Observer guessed ball is with player {0}", guess);

        if (((Subject)subject).State == guess)
        {
            return true;
        }
        return false;
    }
}