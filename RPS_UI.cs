// namespace _Rock_Paper_Scissor 
// {
    public class Hello
    {
        public void RPS()
        {
            int userScore = 0;
            int computerScore = 0;
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
                    // user loses
                    // computer score +=1
                } else if (userInput == "rock" && number == 3)
                {
                    // user wins
                    // user score +=1
                } else if (userInput == "paper" && number == 1)
                {
                    // user wins
                    // user score +=1
                } else if (userInput == "paper" && number == 3)
                {
                    // user loses
                    // computer score +=
                } else if (userInput == "scissors" && number == 1)
                {
                    // user loses
                    // computer score +=1
                } else if (userInput == "scissors" && number == 2)
                {
                    // user wins
                    // user score +=1
                } else 
                {
                    System.Console.WriteLine("It's a tie!");
                }

                System.Console.WriteLine("Do you want to keep playing? (yes/no)");
                keepPlaying = Console.ReadLine().ToLower();
            }

            System.Console.WriteLine("User Score:" + userScore);
            System.Console.WriteLine("Computer Score:" + computerScore);
            Console.Clear();
        }
    }
// }

