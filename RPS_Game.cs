namespace MySecondProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;

            while (playAgain)
            {
                player = "";
                computer = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.WriteLine("Welcome to the Rock-Paper-Scissors Game!");
                    Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine($"Player: {player}");
                Console.WriteLine($"Computer: {computer}");

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                            Console.WriteLine("It's a Draw!");
                        else if (computer == "PAPER")
                            Console.WriteLine("You lost! Paper beats Rock!");
                        else
                            Console.WriteLine("You won! Rock beats Scissors!");
                        break;

                    case "PAPER":
                        if (computer == "ROCK")
                            Console.WriteLine("You won! Paper beats Rock!");
                        else if (computer == "PAPER")
                            Console.WriteLine("It's a Draw!");
                        else
                            Console.WriteLine("You lost! Scissors beat Paper!");
                        break;

                    case "SCISSORS":
                        if (computer == "ROCK")
                            Console.WriteLine("You lost! Rock beats Scissors!");
                        else if (computer == "PAPER")
                            Console.WriteLine("You won! Scissors beat Paper!");
                        else
                            Console.WriteLine("It's a Draw!");
                        break;
                }

                Console.Write("Would you like to play again? (Y/N): ");
                answer = Console.ReadLine().ToUpper();

                while (answer != "Y" && answer != "N")
                {
                    Console.Write("Invalid input. Please enter 'Y' or 'N': ");
                    answer = Console.ReadLine().ToUpper();
                }

                playAgain = answer == "Y";
            }

            Console.WriteLine("Thanks for playing my game! @egandore99");
            Console.ReadKey();
        }
    }
}
