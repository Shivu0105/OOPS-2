namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print 1 to 10 --> For Loop
            //for (int i = 1;i <= 10;i++)
            //{
            //    Console.WriteLine(i);
            //}

            //// While loop
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            // Do...while loop
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 20);
        }
    }
}
