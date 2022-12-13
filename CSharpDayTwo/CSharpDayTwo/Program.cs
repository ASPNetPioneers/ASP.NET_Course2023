namespace CSharpDayTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!\n");

            // ReadLine and WriteLine

            Console.Write("First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            // Concatenation
            Console.WriteLine("Hello, " + firstName + " " + lastName + "!");

            // Place Holder
            Console.WriteLine("Hello, {0} {1}!", firstName, lastName);

            // Interpolation           
            Console.WriteLine($"Hello, {firstName} {lastName}");
        }
    }
}
