namespace Enumenations;
class Program
{


    static void Main(string[] args)
    {

        Console.WriteLine("Enumenations\n");

        //   Gender gender = new Gender();

        Customer[] customers = new Customer[3];

        //  customers[0] = new Customer() { Name = "Mark", Gender = (int)Gender.Male }; // in case the data type in Customer property was not Gender type
        customers[0] = new Customer() { Name = "Sarah", Gender = Gender.Female };
        customers[1] = new Customer() { Name = "Adam", Gender = Gender.Male };

        foreach (Customer customer in customers)
        {
            // Enum enumOb = Enum.Parse()
            Console.WriteLine($"Name: {customer.Name}\nGender: {customer.Gender}");
        }
    }
}
