namespace _Rock_Paper_Scissor 
{
    public class Program 
    {
        public void Main()
        {
            int userScore = 0;
            int consoleScore = 0;
            string [] options = new string [3] {"Rock", "Paper", "Scissors"};
            Random rnd = new Random();
            int number = rnd.Next(1,3);

        }
            Console.WriteLine ("Make your choice? \n" +
            "1. Rock \n" +
            "2. Paper \n" +
            "3. Scissors");

            string userInput = Console.ReadLine().ToLower(); 
    }
}

