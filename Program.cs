Console.WriteLine("scegli le varie opzioni: \n1)Push;\n2)Pop;\n3)Peek.");

int Option = int.Parse(Console.ReadLine());

Stack<string> ListOfName = new();
ListOfName.Push("Sara");
ListOfName.Push("Luca");
ListOfName.Push("Anna");

if (Option == 1)
{
    Console.Write("inserisci un nuovo nome: ");
    string NewName = Console.ReadLine();

    ListOfName.Push(NewName);

    Console.WriteLine("lista completa con il nuovo nome:");
    foreach (string names in ListOfName)
    {
        Console.WriteLine(names);
    }
}
else if (Option == 2)
{
    string restOfList = ListOfName.Pop();
    Console.WriteLine($"sto rimuovendo l'ultimo nome dalla lista {restOfList}");
}
else if (Option == 3)
{
    string name = ListOfName.Peek();
    Console.WriteLine($"sto prendendo l'ultimo nome della lista  {name}");
}