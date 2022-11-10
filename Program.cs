using MementoPattern;

var calc = new Calc();
for (int n = 1; n <= 5; n++)
{
    calc.Add(n);
}

Console.WriteLine($"First Calc 現在の数値は : {calc.temperatureNumber} です。");
SnapShot.AddSnapShot("First Calc", calc.CreateMemento());


var calcVersion2 = new Calc();
calcVersion2.SetMemento(SnapShot.GetSnapShot("First Calc"));
for (var n = 6; n <= 10; n++)
{
    calcVersion2.Add(n);
}

Console.WriteLine($"Second Calc 現在の数値は : {calcVersion2.temperatureNumber} です。");
SnapShot.AddSnapShot("Second Calc", calcVersion2.CreateMemento());

var calcVersion3 = new Calc();
calcVersion3.SetMemento(SnapShot.GetSnapShot("Second Calc"));

Console.WriteLine($"Third Calc 現在の数値は : {calcVersion3.temperatureNumber} です。");
