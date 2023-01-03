namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface\n");

            IEmployee employee1 = new Employee();
            employee1.PrintInfo();
        }
    }
}