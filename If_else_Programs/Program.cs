namespace If_else_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Only If
            //int age = 18;

            //if (age >= 18)
            //{
            //    Console.WriteLine("Yeah...You can vote.");
            //}
            //Console.WriteLine();

            //// if - else
            //int aage = 15;

            //if (aage >= 18)
            //{
            //    Console.WriteLine("You're eligible");
            //}
            //else
            //{
            //    Console.WriteLine("Not elgible");
            //}
            //Console.WriteLine();

            //// if_else if_ else
            //Console.WriteLine("Enter you're marks");
            //int marks = Convert.ToInt32(Console.ReadLine());

            //if(marks >= 90)
            //{
            //    Console.WriteLine("Grade A");
            //}
            //else if (marks >= 75)
            //{
            //    Console.WriteLine("Grade B");
            //}
            //else if (marks >= 50)
            //{
            //    Console.WriteLine("Grade C");
            //}
            //else
            //{
            //    Console.WriteLine("You're Fail");
            //}
            //Console.WriteLine();

            ////Nested if
            //Console.WriteLine("Enter Mark");
            //int mark = Convert.ToInt32(Console.ReadLine());
            //bool isPresent = true;

            //if(isPresent)
            //{
            //    if (mark >= 45)
            //    { Console.WriteLine("Passed"); }

            //    else { Console.WriteLine("Fail"); }
            //}
            //Console.WriteLine();

            // Nested if_else
            Console.WriteLine("Enter age");
            int agge = Convert.ToInt32(Console.ReadLine());
            
            if (agge >= 18)
            {
                Console.WriteLine("You have License");
                Console.WriteLine("If you have press True, otherwise press False");
                bool hasLicense = Convert.ToBoolean(Console.ReadLine());

                if (hasLicense)
                { Console.WriteLine("You can drive"); }
                else { Console.WriteLine("Get a license first"); }
            }
            else 
            { 
                Console.WriteLine("You're too young"); 
            }
        }
    }
}
