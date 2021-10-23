using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Console.Write("New ATM, please enter amount: ");
            string amount = Console.ReadLine();

            var ATM = new ATM(amount);


        }
    }
}
