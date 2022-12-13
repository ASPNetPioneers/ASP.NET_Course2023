namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Enter username
            Console.Write("Username: ");
            string username = Console.ReadLine()!;

            CapitalizeString(username);
            
            //Console.WriteLine($"Hello, {CapitalizeString(username)}!\n" +
              //  $"Happy coding!");
        }

        static internal void CapitalizeString(string name)
        {
            string newString = string.Empty;
            string stringTitle = string.Empty;

            string[] names = name.Split();
            string[] captName = new string[names.Length];

            for (int i = 0; i < names.Length;)
            {
                captName[i] += Char.ToUpper(names[i][0]) + names[0].Substring(1);
                
                //captName[i] += newString;
            }
            //stringTitle = String.Join(" ", captName);
            Console.WriteLine(captName.Length);

            foreach (var item in captName)
            {
            Console.WriteLine(item);
            }
        }
    }
}
