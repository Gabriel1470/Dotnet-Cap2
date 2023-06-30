Console.WriteLine("inserire 10 numeri:");
int[] arryNumber = new int[10];
int i = 0;

while (i < arryNumber.Length)
{
    arryNumber[i] = int.Parse(Console.ReadLine());
    i++;
}

Console.WriteLine("/------------------------------------------/");
Console.WriteLine("Sto stampando l'elenco:");

foreach (int number in arryNumber)
{
    Console.WriteLine(number);
}

Console.WriteLine("/------------------------------------------/");
Console.WriteLine("Sto stampando l'elenco al contrario:");

Array.Reverse(arryNumber);
foreach(int number in arryNumber)
{
    Console.WriteLine(number);
}

