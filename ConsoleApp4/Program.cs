using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            SumDigit();
      
        }

        static void SumDigit()
        {

            int num = int.Parse(Console.ReadLine());           
            string myString = num.ToString();
            char[] array = myString.ToCharArray();
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += int.Parse(array[i].ToString());
            }
            Console.WriteLine($"The sum is {sum}");
        }

    }
}
