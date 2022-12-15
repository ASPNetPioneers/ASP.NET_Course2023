namespace Loop;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Loops in C#\n");

        // Write a program that returns even numbers.

        // User input
        Console.WriteLine("Please enter a number: ");
        int userTarget = Convert.ToInt32(Console.ReadLine());

        // Iterate over user input, starting from 1, all the way till the last number, 
        // and return only the even numbers:

        int start = 0;


        // Solution using while loop:
        Console.WriteLine("\nwhile loop");
        while (start <= userTarget)
        {
            
            if (start % 2 == 0)
            {
                Console.WriteLine($"{start} is an even number.");
            }
            start++;            
        }        
        Console.WriteLine("\ndo-while loop");
        // Solution using do-while loop:
        // Let's return odd numbers this time.
         start = 0;
        do
        {
            if (start % 2 != 0)
            {
                Console.WriteLine($"{start} is an odd number.");
            }
            start++;
        }
        while (start <= userTarget);

        // Solution using for loop        
        Console.WriteLine("\nfor loop");
       
        for (int i = 20; i >= userTarget; i--)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"{i} is an even number.");
            }
            else
            {
                Console.WriteLine($"{i} is an odd number.");
            }
        }

        // foreach loop
        Console.WriteLine("\nforeach loop");
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i;
        }
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    numbers[i] =+ 100;
        //}

        // reverse array
        Console.WriteLine("Reverse Numbers array");
        Array.Reverse(numbers);

        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }

    }
}
