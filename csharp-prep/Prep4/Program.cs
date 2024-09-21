using System;
using System.Data;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List <int> numbers = new List<int>();

        int userNumber = -1;
        int sum = 0;
        while(userNumber != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished ");
            userNumber = int.Parse(Console.ReadLine());

            if(userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        foreach(int number in numbers)
        {
            sum += number;
        }        
       Console.WriteLine($"The sum is :{sum}");

       float average = (float)sum / numbers.Count;
       Console.WriteLine($"The average is: {average}");
       int max = numbers.Max();
       int min = numbers.Min();
       Console.WriteLine($"The max is: {max}");
       Console.WriteLine($"The min is: {min}");
       Console.WriteLine("Sorted is: ");

       numbers.Sort();

       foreach(int number in numbers)
       {
        Console.WriteLine(number);
       }
       
     
       
    }
}