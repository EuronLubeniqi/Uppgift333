using System;

  
class Program
{
    static void Main()
    {
        int sum = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Ange ett heltal: ");
            int number = int.Parse(Console.ReadLine());
            sum += number;
        }

        Console.WriteLine("Summan av de inmatade talen är: " + sum);
    }
}


