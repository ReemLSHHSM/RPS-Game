using System;

namespace Rock__Paper__Scissors
{
    public class RPSGame
    {
        private Random rand = new Random();
        public int AI_score = 0;

        public string AI_move()
        {
            string[] arr = { "rock", "paper", "scissors" };
            int ind = rand.Next(arr.Length);
            return arr[ind];
        }

        public string Compare(Player player, string move, string AIMove)
        {
            //string AIMove = AI_move();
            AIMove = AI_move();
            Console.WriteLine($"Billy chose: {AIMove} \n");

            if ((move == "rock" && AIMove == "scissors") ||
                (move == "scissors" && AIMove == "paper") ||
                (move == "paper" && AIMove == "rock"))
            {
                player.Score++;
                Console.WriteLine($"The winner for this round is {player.Name} :)\nScore is: {player.Score}:{AI_score} \n");
                return player.Name;
            }
            else if ((AIMove == "rock" && move == "scissors") ||
                     (AIMove == "paper" && move == "rock") ||
                     (AIMove == "scissors" && move == "paper"))
            {
                AI_score++;
                Console.WriteLine($"The winner for this round is Billy :(\nScore is: {player.Score}:{AI_score} \n");
                return "AI";
            }
            else if((AIMove == "rock" && move == "rock") ||
                     (AIMove == "paper" && move == "paper") ||
                     (AIMove == "scissors" && move == "scissors"))
            {
                Console.WriteLine($"It was a tie :| \nScore is: {player.Score}:{AI_score} \n");
                return "tie";
            }
            else
            {
                return "";
            }
        }

        public string Rounds(Player player)
        {
            while (player.Score < 3 && AI_score < 3)
            {
                string move = player.Move();
                Compare(player, move, AI_move());//*********************************
            }

            if (player.Score > AI_score)
            {
                return player.Name;
            }
            else
            {
                return "Billy";
            }
        }


    }
}
