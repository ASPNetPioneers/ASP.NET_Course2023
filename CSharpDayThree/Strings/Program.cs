namespace Strings;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Strings\n");

        /*
         * A string is a sequence of characters wrapped in double quotes.
         * 
         */

        // string example
        string username = "john.75_smith";
        Console.WriteLine(username);

        Console.WriteLine($"User Details:\nName: {username}\n");

        // String Methods
        string str = string.Empty;
        str = "hello world";
        string newString = str.Replace("o", "O");
        Console.WriteLine($"{nameof(newString)}: {newString}");

    }
}

