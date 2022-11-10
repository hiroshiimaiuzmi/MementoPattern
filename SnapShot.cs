namespace MementoPattern;

public class SnapShot
{
    public Dictionary<string, Memento> snapShot = new();

    public SnapShot(string name, Memento memento)
    {
        snapShot.Add(name, memento);
    }
}