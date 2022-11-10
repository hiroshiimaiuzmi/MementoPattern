namespace MementoPattern;

public class Calc
{
    public int temperatureNumber { get; private set; }

    public void Add(int number)
    {
        temperatureNumber += number;
    }

    public Memento CreateMemento()
    {
        return new Memento(temperatureNumber);
    }

    public void SetMemento(Memento memento)
    {
        temperatureNumber = memento.result;
    }

}