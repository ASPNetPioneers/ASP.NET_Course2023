namespace DataTypeConvert;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Data Type conversion");

        /* Implicit
            - Automatically converted by the C# compiler.
            - Automatically convert a lower data type value to a greater one. i.e int => float.
         
         */

        int intNum = 100;
        float floatNum = intNum;



        /* Explicit
         - From higher to a lower data type, using casting or Convert class.
        */
        float floatNum2 = 100.25f;
        int intNum2 = (int)floatNum2;
        Console.WriteLine($"{nameof(intNum2)} = {intNum2}");

        float floatNum3 = 100.555F;
        int intNum3 = Convert.ToInt32(floatNum3);

        // Parse() VS TryParse()
        // To convert a number in a string format to a numerical one.

        string stringNumber = "2450";
        int parsedString = default;

        int parseNum = int.Parse(stringNumber);

        Console.WriteLine(parseNum);

        bool isParsed = int.TryParse(stringNumber, out parsedString);
        Console.WriteLine(isParsed);
        Console.WriteLine(parsedString);
    }
}
