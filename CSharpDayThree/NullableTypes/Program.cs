namespace NullableTypes;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nullable Types\n");

        int? number;
        number = null;

        // We Add ? right after the data type identifier, in order to let that variable accept nullable type.
        if (number == null)
        {
            Console.WriteLine($"{nameof(number)} = {number}");
        }

        // Null Coalascing Type ??
        int availableTickets;
        int? ticketsOnSale = null;

        availableTickets = ticketsOnSale ?? 0;
        Console.WriteLine(availableTickets);
        Console.WriteLine(ticketsOnSale.HasValue);

    }
}
