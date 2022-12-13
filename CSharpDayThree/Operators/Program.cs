namespace Operators;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Operators\n");
        
        int num1, num2;

        num1 = 10;
        num2 = 2;

        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");

        int number = 10;
        bool isNumber10 = false;

        if ( number == 10 )
        {
            isNumber10 = true;
        }
        else
        {
            isNumber10 = false;
        }

        // Ternary Operator ?:
        bool result = number == 10 ? true : false;

        Console.WriteLine($"{nameof(result)} = {result}");

       

    }
}
