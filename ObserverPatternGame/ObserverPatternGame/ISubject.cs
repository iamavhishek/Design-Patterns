public interface ISubject
{
    //Method that Subscribe an Observer to get notification about change in state of Subject(Ball in this case)
    public void Attach(IObserver observer_Player);

    //Method that detach an observer from getting notification
    public void Detach(IObserver observer_Player);

    //Method that notifies all observer who are subscribed to get update about subject's state change.
    public bool Notify();

}