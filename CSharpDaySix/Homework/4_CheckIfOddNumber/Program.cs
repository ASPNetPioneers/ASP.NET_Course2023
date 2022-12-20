using System.Globalization;

namespace _4_CheckIfOddNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4. Check if an array contains an odd number.\n");

            bool isOdd = false;
            int[] numbers = { 1, 2, 3, 5, 6, 8, 20 };

            for (int i = 0; i < numbers.Length; i++) 
                {
                 if (numbers[i] % 2 != 0)
                    {      
                        isOdd = true;
                    break;
                    }
                 else
                    {
                        isOdd= false;                        
                    }
                }
            Console.WriteLine($"Check if any array contains an odd number? {isOdd}");
        }        
    }
}