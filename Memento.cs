namespace MementoPattern;

public class Memento
{
    public int result { get; private set; }

    public Memento(int temp)
    {
        result = temp;
    }
}