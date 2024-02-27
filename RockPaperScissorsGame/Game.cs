using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
{
    internal class Game
    {
        private int _round;
        public int Round
        {
            get { return _round; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Value should be greater than zero");
                }
                _round = value;
            }
        }
        private int  playerScore , computerScore ;
        public Game()
        {
            Console.WriteLine("Rock, Paper, Scissors Game");
            Console.WriteLine("---------------------------\n");
        }
        public void Play(int noOfRounds)
        {
            Random random = new Random();
            int cnt = 1;
            playerScore = 0;
            computerScore = 0;
            while (cnt <= noOfRounds)
            {
                Console.WriteLine($"Round {cnt} ");
                Console.WriteLine("--------------\n");
                Console.Write("Enter a number : [1] Rock, [2] Paper, [3] Scissors : ");
                int player = Convert.ToInt32(Console.ReadLine());
                int computer = random.Next(1, 4);

                if (player == 1)
                {
                    if (computer == 2)
                    {
                        computerScore++;
                        Console.WriteLine("You Lose!\nPaper beats Rock! ");
                        Console.WriteLine($"You = {playerScore}   Computer = {computerScore} \n");

                    }
                    else if (computer == 3)
                    {
                        playerScore++;
                        Console.WriteLine("You win!\nRock beats Scissors! ");
                        Console.WriteLine($"You = {playerScore}   Computer = {computerScore} \n");

                    }
                    else
                    {
                        Console.WriteLine("Draw! ");
                        Console.WriteLine($"You = {playerScore}   Computer = {computerScore} \n");
                    }
                }
                else if (player == 2)
                {
                    if (computer == 1)
                    {
                        playerScore++;
                        Console.WriteLine("You win!\nPaper beats Rock! ");
                        Console.WriteLine($"You = {playerScore}   Computer = {computerScore} \n");

                    }
                    else if (computer == 3)
                    {
                        computerScore++;
                        Console.WriteLine("You lose!\nScissors beats Paper! ");
                        Console.WriteLine($"You = {playerScore}   Computer = {computerScore} \n");

                    }
                    else
                    {
                        Console.WriteLine("Draw! ");
                        Console.WriteLine($"You = {playerScore}   Computer = {computerScore} \n");
                    }
                }
                else if (player == 3)
                {
                    if (computer == 2)
                    {
                        playerScore++;
                        Console.WriteLine("You win!\nScissors beats Paper! ");
                        Console.WriteLine($"You = {playerScore}   Computer = {computerScore} \n");

                    }
                    else if (computer == 1)
                    {
                        computerScore++;
                        Console.WriteLine("You lose!\nRock beats Scissors! ");
                        Console.WriteLine($"You = {playerScore}   Computer = {computerScore} \n");

                    }
                    else
                    {
                        Console.WriteLine("Draw! ");
                        Console.WriteLine($"You = {playerScore}   Computer = {computerScore} \n");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!\n");
                }
                cnt++;
            }
           
        

        }
        public void GetTheResult()
        {
            if (playerScore > computerScore)
            {
                Console.WriteLine("You Win\n");
            }
            else if (playerScore < computerScore)
            {
                Console.WriteLine("You Lose\n");
            }
            else { Console.WriteLine("Draw\n"); }
            Console.WriteLine($"You = {playerScore}   Computer = {computerScore} \n");
        }
        public bool PlayAgain()
        {
            Console.Write("Play Again (Y/N) ? ");
            string? again = Console.ReadLine();
            if (again != null && again.ToLower() != "y")
            {
                return false;
            }
            Console.WriteLine("-------------------------------------------\n");
            return true;
        }
        

        


    }
}
