HashSet<string> ensemble = new HashSet<string>();

ensemble.Add("il fuoco");
ensemble.Add("el rue");
ensemble.Add("le Ruye");
ensemble.Add("ignis");
ensemble.Add("acqua");
ensemble.Add("Agua");
ensemble.Add("fire");
ensemble.Add("FIRE");

Console.WriteLine($"The ensemble hashSet contains {ensemble.Count} element");

foreach(var x in ensemble)
{
    Console.WriteLine(x);
}

Console.WriteLine("Capitalized letters are considered different");