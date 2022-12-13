namespace DataTypes;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Data Types\n");

        // variable - A storage name, located in memory.
        int age = 18;
        Console.WriteLine($"Your age is: {age}");

        bool isActive = false;
        
     
        // constant - fixed, non-changable value.
        const float PI = 3.14F;
        Console.WriteLine($"PI = {PI}");
    }
}
