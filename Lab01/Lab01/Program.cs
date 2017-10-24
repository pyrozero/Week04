using System;
namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            ;
            
            Console.Write("Enter number : ");
            int A = Console.Read();

            Random random = new Random();
            int randomNumber = random.Next(0,9);
            Console.Write("Random Number is  : ");
            Console.WriteLine(randomNumber);


            Console.Write("Answer  : ");
            bool B = A < randomNumber ;
            Console.WriteLine("{0}", B);
           


        }
    }
}
