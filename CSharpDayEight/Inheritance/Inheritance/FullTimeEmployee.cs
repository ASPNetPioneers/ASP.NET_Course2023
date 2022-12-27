namespace Inheritance
{
    /// <summary>
    /// Child class
    /// </summary>
    internal class FullTimeEmployee : Employee
    {
        // members
        internal int yearlySalary;

        // constructors
        //public FullTimeEmployee(string fullTimemsg)
        //{
        //    Console.WriteLine("This is the FullTimeEmployee parameterized constructor");
        //}
        //public FullTimeEmployee() : base("Create a message from a child class.")
        //{
        //    Console.WriteLine("FullTimeEmployee child class constructor");

        //}


        // methods
        public new void PrintFullName() // using new keyword in child class
        {
            Console.WriteLine($"\nChild Class Method:\nFull Name: {firstName} {lastName}");
        }

        // method override

        public override void OverrideExample()
        {
            Console.WriteLine("\nOverride Example: This is method is in the child class.\n");
        }



    }
}
