namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encapsultion\n");

            // Objects
            Student student1 = new Student();
            student1.ID = 1;
            student1.Name = "John Smith";
            student1.Email = "john.smith@email.com";

            // Call methods
            student1.StudentDetails();

        }
    }
}