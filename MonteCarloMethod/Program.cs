using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var monteCarloMethod = new MonteCarloMethod();

            do
            {
                double estimatedPi = monteCarloMethod.Estimate(AskForNumber());
                DisplayAnswer(estimatedPi);

            } while (RunAgain());

            Environment.Exit(0);
        }

        static int AskForNumber()
        {
            int inputAmount = 0;
            bool hasAnswered = true;
            string message;

            do
            {
                Console.Clear();

                message = hasAnswered ? "Please input the number of tests: "
                                      : "Invalid. Please enter a number: ";

                Console.Write(message);
                hasAnswered = (int.TryParse(Console.ReadLine(), out inputAmount));

            } while (!hasAnswered);

            if (inputAmount < 1)
            {
                Console.WriteLine("Please input a number greater than zero.  Press ENTER to continue.");
                Console.ReadKey();
                return AskForNumber();
            }

            return inputAmount;
        }

        static void DisplayAnswer(double estimatedPi)
        {
            var difference = Math.Abs(Math.PI - estimatedPi);

            Console.Clear();
            Console.WriteLine($"Monte Carlo Method: {estimatedPi}");
            Console.WriteLine($"Pi is: {Math.PI}");
            Console.WriteLine($"The difference: {difference}.");
            Console.ReadKey();
        }

        static bool RunAgain()
        {
            Console.Clear();
            Console.WriteLine("Enter another number? (Y)Yes or (N)No");
            var input = Console.ReadKey(true);
            switch (input.Key)
            {
                case ConsoleKey.Y:
                    return true;
                case ConsoleKey.N:
                    return false;
                default:
                    return RunAgain();
            }

        }
    }
}
