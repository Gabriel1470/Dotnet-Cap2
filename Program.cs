Console.WriteLine("Inserisci 10 cose nella lista:");
List<object> CoseList = new();
int i = 0;

while (i <= CoseList.Count)
{
    object Input = Console.ReadLine();
    CoseList.Add(Input);
    i++;
    
    if(CoseList.Count == 10)
    {
        break;
    }
}

Console.WriteLine("/-------------------------------------/");

foreach(object x in CoseList)
{
    Console.WriteLine(x);
}

