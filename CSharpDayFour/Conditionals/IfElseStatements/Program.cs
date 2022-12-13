namespace IfElseStatements;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("If/Else statements\n");

        Console.Write("Please enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number == 1)
        {
            Console.WriteLine($"Number = {1}");
        }
        else if (number == 2)
        {
            Console.WriteLine($"Number = {2}");
        }
        else if (number == 3)
        {
            Console.WriteLine($"Number = {3}");
        }
        else
        {
            Console.WriteLine("Number should be in range 1- 3");
        }
    }
}
