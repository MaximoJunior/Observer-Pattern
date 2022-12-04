using Patterns.Observer.Contracts;

public class DisplayEven : IObserver , IDisplayElement
{
    int number = 0;

    public DisplayEven(GeneratorNumber generatorNumber)
    {
        generatorNumber.RegisterObserver( this );
    }
    public void Display()
    {
        string answer = this.IsEven() ? "Yes" : "No";
        Console.WriteLine($"Is {this.number} number even? : {answer}");
    }

    public void Update(int number)
    {
        this.number = number;
        this.Display();
    }

    private bool IsEven(){
         return this.number % 2 == 0;
    }
}