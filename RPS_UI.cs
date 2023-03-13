// namespace _Rock_Paper_Scissor 
// {

    public class GameStartUI
    {
        
            private RPSRepository _accessKey = new RPSRepository();
        public void RPS()
        {

            string keepPlaying = "";
            System.Console.WriteLine("Lets Play rock paper scissors!");

            while (keepPlaying != "no")
            {
                Random rnd = new Random();
                int number = rnd.Next(1,3);
                System.Console.WriteLine("Make your choice\n" +
                "Rock\n" +
                "Paper\n" +
                "Scissors");
                string userInput = Console.ReadLine().ToLower(); 
                if (number == 1)
                {
                    System.Console.WriteLine("Computer: Rock");
                } else if (number == 2)
                {
                    System.Console.WriteLine("Computer: Paper");
                } else if (number == 3)
                {
                    System.Console.WriteLine("Computer: Scissors");
                }
                if (userInput == "rock" && number == 2)
                {
                    _accessKey.PlusComputerScore();
                    _accessKey.UserRockComputerPaper();
                } else if (userInput == "rock" && number == 3)
                {
                    _accessKey.PlusUserScore();
                    _accessKey.UserRockComputerScissors();
                } else if (userInput == "paper" && number == 1)
                {
                    _accessKey.PlusUserScore();
                    _accessKey.UserPaperComputerRock();
                } else if (userInput == "paper" && number == 3)
                {
                    _accessKey.PlusComputerScore();
                    _accessKey.UserPaperComputerScissors();
                } else if (userInput == "scissors" && number == 1)
                {
                    _accessKey.PlusComputerScore();
                    _accessKey.UserScissorsComputerRock();
                } else if (userInput == "scissors" && number == 2)
                {
                    _accessKey.PlusUserScore();
                    _accessKey.UserScissorsComputerPaper();
                } else 
                {
                    System.Console.WriteLine("It's a tie!");
                }

                System.Console.WriteLine("Do you want to keep playing? (yes/no)");
                keepPlaying = Console.ReadLine().ToLower();
                Console.Clear();
                System.Console.WriteLine("User Score:" + RPSRepository.userScore);
                System.Console.WriteLine("Computer Score:" + RPSRepository.computerScore);
            }
        }
    }
        public class RPSRepository
        {
            static public int userScore = 0;
            static public int computerScore = 0;

            public void PlusUserScore()
            {
                userScore += 1;
            }

            public void PlusComputerScore()
            {
                computerScore += 1;
            }
            public void UserComputerComparison(int userChoice, int computerChoice)
            {
                string result = $"{userChoice} beats {computerChoice}";
                new competitionResult = result, userScore, computerScore;
            }
            public void UserRockComputerPaper()
            {
                System.Console.WriteLine("Paper beats rock, You lose!");
            }

            public void UserRockComputerScissors()
            {
                System.Console.WriteLine("Rock beats scissors, you win!");
            }

            public void UserPaperComputerRock()
            {
                System.Console.WriteLine("Paper beats rock, You win!");
            }

            public void UserPaperComputerScissors()
            {
                System.Console.WriteLine("Scissors beats paper, You lose!");
            }

            public void UserScissorsComputerRock()
            {
                System.Console.WriteLine("Rock beats scissors, You lose!");
            }

            public void UserScissorsComputerPaper()
            {
                System.Console.WriteLine("Scissors beats paper, You win!");
            }
        }


