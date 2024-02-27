namespace RockPaperScissorsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rock, Paper, Scissors Game");
            Console.WriteLine("---------------------------\n");
            Console.Write("Enter number of rounds : ");
            int round =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Random random = new Random();
            while(true)
            {
                int cnt = 1;
                int playerScore = 0, computerScore = 0;
                while(cnt <= round)
                {
                    Console.WriteLine($"Round {cnt} ");
                    Console.WriteLine("--------------\n");
                    Console.Write("Enter a number : [1] Rock, [2] Paper, [3] Scissors : ");
                    int player = Convert.ToInt32(Console.ReadLine());
                    int computer =random.Next(1,4);

                    if(player == 1)
                    {
                        if(computer == 2)
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
                    else if(player == 3)
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
                Console.WriteLine("-------------------------------------------\n");
                if(playerScore > computerScore)
                {
                    Console.WriteLine("You Win\n");
                }
                else if (playerScore < computerScore)
                {
                    Console.WriteLine("You Lose\n");

                }
                else { Console.WriteLine("Draw\n"); }
                Console.WriteLine($"You = {playerScore}   Computer = {computerScore} \n");
                Console.WriteLine("-------------------------------------------\n");

                Console.Write("Play Again (Y/N) ? ");
                string ? again = Console.ReadLine();
                if (again != null && again.ToLower()!="y")
                {
                    break;
                }
                Console.WriteLine("-------------------------------------------\n");
            }
        }
    }
}