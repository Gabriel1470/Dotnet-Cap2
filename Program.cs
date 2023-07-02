
  class Program
    {
      static void Main(string[] args)

      {

        int oddNumCount = 0;
        int smallNum = 0;
        int largeNum = 0;
            Random randNum = new Random();


           for (int i = 0; i <= 1000; i++)
        {
            int num = randNum.Next(1000);
            int remain = num % 2;

            if (remain != 0)
            {
                oddNumCount++;
            }
            if (num < smallNum)
            {
                smallNum = num;
            }
            else if (num > largeNum)
            {
                largeNum = num;
            }

            }

           Console.WriteLine($"the Number of odd numbers generated:  {oddNumCount}  \n Smallest number was:  {smallNum} \n Largerst number was:  {largeNum} ,\n random number generation results");
        }
    }
