namespace SwitchStatements;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Switch Statements\n");

        Repeat:

        Console.Write("Please enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());


        switch (number)
        {
            case 1:
                Console.WriteLine($"Number = {1}");
                break;
            case 2:
                Console.WriteLine($"Number = {number}");
                break;
            case 3:
                Console.WriteLine($"Number = {number}");
                break;
            default:
                Console.WriteLine("Invalid number.");
                goto Repeat;
        }
    }
}
