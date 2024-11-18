using halmaz;

Set halmaz = new Set(10);
halmaz.Add(1.5);
halmaz.Add(2.0);
halmaz.Add(3.5);

Console.WriteLine($"A halmaz jelenlegi hossza: {halmaz.Length()}");
Console.WriteLine("Elem eltávolítása:");
halmaz.Remove(2.0);  
Console.WriteLine($"A halmaz jelenlegi hossza: {halmaz.Length()}");
Console.WriteLine($"A halmaz kapacitása: {halmaz.GetSize()}");