namespace Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // instances
            Point p1 = new(10, 20, 5);

            // print p1 
            Console.WriteLine($"\nOrigin: {Point.Origin}");

            Console.WriteLine($"p1: {p1}");

            Point p2 = Point.Origin;

            // reset values
            p1.SetToOrigin();
            Console.WriteLine($"\np1: {p1}");
            Console.WriteLine();


        }
    }
}