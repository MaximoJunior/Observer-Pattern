using Patterns.Observer.Contracts;

public class DisplaySquare : IObserver , IDisplayElement
{
    int number = 0;

     public DisplaySquare(GeneratorNumber generatorNumber)
    {
        generatorNumber.RegisterObserver( this );
    }
    public void Display()
    {
        Console.WriteLine($"Square of {this.number} : { this.GetSquare() }");
    }

    public void Update(int number)
    {
        this.number = number;
        this.Display();
    }

    private int GetSquare(){
         return number * number;
    }
}