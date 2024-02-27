using System;

namespace GuessTheNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Guess My Number \n ");
            Console.WriteLine("Hey there! Ready for the guessing game? Please enter the range you'd like to use.\n");
            Game game = new Game();
            bool replay = false;
            int round = 1;
            do
            {
                game.Play(ref round);
                replay = game.PlayAgain(); 
                

            } while (replay);
            
        }
        
    }
    public class Game
    {
        public int CheckInputIsValid()
        {
            Random random = new Random();
            int myNumber = 0;
            while (true)
            {
                try
                {
                    Console.Write("Enter Lower Bound : ");
                    int minValue = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter upper Bound : ");
                    int maxValue = Convert.ToInt32(Console.ReadLine());
                    myNumber = random.Next(minValue, maxValue);
                    break;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.Write("Lower bound cannot be greater than upper bound.");
                    Console.WriteLine(" Try Again. ");
                }
            }
            return myNumber;

        }
        public void Play(ref int round)
        {
            
            Console.WriteLine($"Round : {round}\n");
            Console.WriteLine("---------------------\n");
            int myNumber = CheckInputIsValid();
            Console.WriteLine();
            int noOfAttempts = 0, guessingNumber;
            do
            {
                noOfAttempts++;
                Console.Write("Guess a random number : ");
                guessingNumber = Convert.ToInt32(Console.ReadLine());
                if (guessingNumber == myNumber)
                {
                    Console.Write($"Bingo! You got it! The number was indeed {guessingNumber}.");
                    Console.WriteLine($" It took you {noOfAttempts} attempts to guess this number.\n");
                }
                else if (guessingNumber < myNumber)
                {
                    Console.WriteLine($"Not quit, the number is higher than {guessingNumber}. Keep Guessing!\n");
                }
                else
                {
                    Console.WriteLine($"Not quit, the number is lower than {guessingNumber}. Keep Guessing!\n");
                }
            } while (guessingNumber != myNumber);
            round++;

        }
        public bool PlayAgain()
        {
            Console.Write("Would you like to start a new round (Y / N) ?  ");
            string ? again;
            again = Console.ReadLine();
            if (again != null && again.ToLower() == "y")
            {
                Console.WriteLine("------------------------------------------------------\n");
                return true;
            }
            return false;
        }
    }

  
}