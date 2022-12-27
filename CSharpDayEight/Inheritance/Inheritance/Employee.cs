namespace Inheritance
{
    /// <summary>
    /// Base class
    /// </summary>
    internal class Employee
    {
        internal string firstName;
        internal string lastName;
        internal string email;

        // constructor
        //public Employee()
        //{
        //    Console.WriteLine("This is the base constructor!");
        //}
        //public Employee(string message)
        //{
        //    Console.WriteLine("A message from a base constructor");
        //}
        // Methods
        public void PrintFullName()
        {
            Console.WriteLine($"\nParent Class Method:\nFull Name: {firstName} {lastName}");
        }

        // method override
        public virtual void OverrideExample()
        {
            Console.WriteLine("\nOverride Example: This is method is in the base class.\n");
        }

    }
}
