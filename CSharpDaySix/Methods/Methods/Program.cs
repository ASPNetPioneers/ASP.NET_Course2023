namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Methods\n");

            // calling instance methods
            // In order to call instance methods, we need first to create an object of the class the method is in.
            Program program = new Program();
            //  program.EvenNumber(40);

            // calling static methods
            /* 
             Called directly from it's class, and not an object.
             */
            Console.WriteLine("");
            int addResult = Add(10, 20);
            Console.WriteLine(addResult);

            Console.WriteLine("");
            int i = 0;
            ValueTypeMethod(i);
            i = 100;
            Console.WriteLine(i           );


            Console.WriteLine("");
            int x = 0;
            RefTypeMethod(ref i);
            x = 100;
            Console.WriteLine(x);

        }
         // Methods
         public void EvenNumber(int target)
        {
            int start = 0;
            while (start <= target)
            {
                Console.WriteLine(start);
                start +=2;
            }
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static void ValueTypeMethod(int j) // value parameter
        {
            Console.WriteLine(j);
        }
        public static void RefTypeMethod(ref int j) // value parameter
        {
            Console.WriteLine(j);
        }

        // out 
      
        // array params keyword
    }
}