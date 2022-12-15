namespace Methods;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Methods in C#\n");

        string userame = "john5.smith";

        GreetUser(userame);
    }

    // Methods 
    static internal void GreetUser(string name)
    {
        Console.WriteLine($"Hello, {name}");
    }
}
