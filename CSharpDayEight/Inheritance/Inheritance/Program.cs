namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance\n");

            // Objects
            FullTimeEmployee johnSmith = new FullTimeEmployee();
            PartTimeEmployee sarahAdams = new PartTimeEmployee();

            johnSmith.firstName = "John";
            johnSmith.lastName = "Smith";
            johnSmith.email = "john_smith@email.com";
            johnSmith.yearlySalary = 100000;

            sarahAdams.firstName = "Sarah";
            sarahAdams.lastName = "Smith";
            sarahAdams.email = "sarah22@email.com";
            sarahAdams.HourlyRate = 25;

            // Arrays and classes
            Console.WriteLine("Print ALL employee names using Arrays");
            Employee[] employees = new Employee[3];
            employees[0] = new Employee();
            employees[1] = new FullTimeEmployee();
            employees[2] = new PartTimeEmployee();

            employees[0].firstName = "john";
            employees[0].lastName = "smith";
            foreach (var item in employees)
            {
                item.PrintFullName();
            }
            Console.WriteLine("\n");
            // Method calls
            //johnSmith.PrintFullName();
            //sarahAdams.PrintFullName();

            // Calling an overridden method
            johnSmith.OverrideExample();   //override
            sarahAdams.PrintFullName();    // hide
        }
    }
}