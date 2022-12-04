
using Patterns.Observer.Contracts;

public class GeneratorNumber : ISubject
{
    int number = 0;
    List<IObserver> observers;

    public GeneratorNumber()
    {
        this.observers = new List<IObserver>();
    }

    public void Generate()
    {
       this.number = new Random().Next(1, 101);
       this.NotifyObservers();
    }

    public void NotifyObservers()
    {
        foreach(IObserver observer in this.observers)
        {
            observer.Update( this.number );
        }
    }

    public void RegisterObserver(IObserver o)
    {
        this.observers.Add(o);
    }

    public void RemoveObserver(IObserver o)
    {
        this.observers.Remove(o);
    }
}