namespace Inheritance
{
    /// <summary>
    /// Child class
    /// </summary>
    internal class PartTimeEmployee : Employee
    {
        // members

        // fields
        internal int HourlyRate;

        // constructor
        public PartTimeEmployee()
        {
            Console.WriteLine("This is the PartTimeEmployee constructor!");
            base.PrintFullName();   //invokes PrintFullName();
        }

        // methods 

        public void PrintFullName()
        {
            Console.WriteLine($"\nChild Class Method:\nFull Name: {firstName} {lastName}");
        }
    }
}
