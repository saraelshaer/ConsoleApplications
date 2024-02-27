namespace RockPaperScissorsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Game game = new Game();
            
            while(true)
            {
                Console.Write("Enter number of rounds : ");
                game.Round = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                game.Play(game.Round);
                Console.WriteLine("-------------------------------------------\n");
                game.GetTheResult();
                Console.WriteLine("-------------------------------------------\n");
                if(!game.PlayAgain())
                {
                    break;
                }

                
            }
        }
    }
}
