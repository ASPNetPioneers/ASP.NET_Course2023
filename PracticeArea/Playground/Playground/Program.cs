namespace Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Happy Coding!");

            string sentence = " hello world";
            ToCapitalize(sentence);
        }

        static void ToCapitalize(string text)
        {
            string[] words = text.Split(" ");
            string[] capWord = new string[words.Length];

            string word = string.Empty;

            for (int i = 0; i < words.Length; i++)
            {
                capWord[i] = Char.ToUpper(words[i][0]) + words[i].Substring(1);
                //Console.WriteLine(word);
               // capWord[i] = word;
            }

            foreach (var item in capWord)
            {
                Console.WriteLine(item);
            }
        }
    }
}