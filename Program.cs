
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Inserisci 10 cose nella lista:");
        ArrayList CoseList = new ArrayList();
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

        foreach (var x in CoseList)
        {
            Console.WriteLine(x);
        }
    }
}