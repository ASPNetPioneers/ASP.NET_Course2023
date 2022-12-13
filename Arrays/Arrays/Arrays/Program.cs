namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays\n");

            /* 
             A collection of data of the same type.

             */

            int[] evenNumbers = new int[3];
            evenNumbers[0] = 2;
            evenNumbers[1] = 4;
            evenNumbers[2] = 6;

            Console.WriteLine($"First number = {evenNumbers[0]}\n");

            string[] friendsList = { "ali", "steve", "bana", "sarah" };

            Console.WriteLine($"First friend is {friendsList[0]}");

            foreach (var item in friendsList)
            {
                //string name = Char.ToUpper(item[0]) + item.Substring(1);
                //item = name;
                Console.WriteLine(item);
            }
            for (int i = 1; i < friendsList.Length; i++)
            {
                string name = Char.ToUpper(friendsList[i][0]) + friendsList[i].Substring(1);                
                Console.WriteLine(name);
            }
            

        }

        static void greetUser()
        {

            ///
            /// This method returns the username with a greet.
            ///
            ///
            ///
            /*
             * This method greets the user.
             */

            Console.WriteLine("Hello, user!");


        }
    }
}