namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Exception Handling\n");

            try
            {
                StreamReader streamReader = new StreamReader(@"E:\AAAMyText.txt");  // Define reader obj from SteamReader class
                var readFile = streamReader.ReadToEnd();                                          // Read file                

                Console.WriteLine(readFile);
                streamReader.Close();                                                                       // Close file
            }
            catch (FileNotFoundException err)
            {
                Console.WriteLine("File not found.");
            }
            catch (Exception err)  // base class exception. Should not be on top in case if other specific exceptions were implemented.
            {
                Console.WriteLine($"Error: {err.Message}\n");                       // production
                Console.WriteLine($"Error Stack Trace: {err.StackTrace}");     // development
            }

            finally
            {
                Console.WriteLine("\nFinished compiling");
            }
        }
    }
}
