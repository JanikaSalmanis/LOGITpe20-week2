using System;

namespace week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("what`s your name?");
            string Name;
            Name =
            Console.ReadLine();
            Console.WriteLine("Hello Janika");
            Console.WriteLine("How old are you?");
            string UserInput;
            UserInput =
                Console.ReadLine();
            int Year; 
            Year =
                Int32.Parse(UserInput);
            int age = 2020 - Year;
            Console.WriteLine("You were born in" + age );


                
        }
    }
}
