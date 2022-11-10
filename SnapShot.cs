namespace MementoPattern;

public static class SnapShot
{
    public static Dictionary<string, Memento> snapShot = new();

    public static void AddSnapShot(string name, Memento memento)
    {
        snapShot.Add(name, memento);
    }

    public static Memento GetSnapShot(string name)
    {
        return snapShot[name];
    }
}