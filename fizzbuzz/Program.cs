using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int mod3;
            int mod5;

            while (counter < 101)
            {
                mod3 = counter % 3;
                mod5 = counter % 5;

                if (mod3 == 0 && mod5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (mod3 == 0)
                {
                    Console.WriteLine("fizz");    
                }
                else if (mod5 == 0)
                {
                    Console.WriteLine("buzz");
                }

                else 
                {
                    Console.WriteLine(counter);
                }
               
               counter = counter + 1; // counter++
            }
          
        
            Console.ReadKey();


        }
    }
}
