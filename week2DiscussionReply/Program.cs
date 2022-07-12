
using static System.Console;
using System;



namespace LoopExamples
{
    class Program
    {
        public static void DoLoop(string[] args)
        {
            string more = "";
            do
            {
                WriteLine("Doing some tasks....");
                Write("\nDo it again (y/n)? ");
                more = ReadLine();
            } while (more == "y" || more == "Y");
        }

        public static void WhileLoop(string[] args)
        {
            double bankBal;
            double interestRate;
            string inputString;
            char response;
            Write("Enter your current bank balance>> ");
            inputString = ReadLine();
            bankBal = Convert.ToDouble(inputString);
            Write("Enter your interest rate...0.04...0.05..etc >> ");
            inputString = ReadLine();
            interestRate = Convert.ToDouble(inputString);
            Write("Do you want to see your balance? Y or N...");
            inputString = ReadLine();
            response = Convert.ToChar(inputString);
            while (response == 'Y')
            {
                WriteLine("Bank Balance is {0}", bankBal.ToString("C"));
                bankBal = bankBal + bankBal * interestRate;
                Write("Do you want to see next year's balance? Y or N...");
                inputString = ReadLine();
                response = Convert.ToChar(inputString);
            }
            WriteLine("Have a nice day!");
        }

        public static void ForLoop(string[] args)
        {
            const int limit = 10;
            for (int x = 1; x <= limit; x++)
            {
                WriteLine("Hello");
                WriteLine("Goodbye");
            }
        }
        static void Main(string[] args)
        {
            WriteLine("Running DoLoop()");
            DoLoop(null);
            WriteLine("Running ForLoop()");
            ForLoop(null);
            WriteLine("Running WhileLoop()");
            WhileLoop(null);

        }
    }
    
}




