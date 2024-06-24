using System;

namespace Rock__Paper__Scissors
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game of Rock Paper Scissors\nYou'll play against Billy the computer, good luck :) \n");
            Console.WriteLine("Enter your name: \n");
            
            string name = Console.ReadLine();
            bool name_test = Int32.TryParse(name, out int name_output);

            while (name_test!=false ||name.Length<2) {
                name_test = Int32.TryParse(name, out int name_outputs);
                if (name_test == true)
                {
                   
                    Console.WriteLine("Name choice not allowed! please try again \n");
                    name = Console.ReadLine();
                    
                }
                else if (name.Length < 2) {
                    Console.WriteLine("Name must be more than 2 letters! please try again \n");
                    name = Console.ReadLine();
                }
            }




            Player player = new Player(name);
            RPSGame game = new RPSGame();
            string winner = game.Rounds(player).ToLower();
     
            if (winner == name.ToLower())
            {
                Console.WriteLine($"The winner is: {name},congrats :) \n");
            }
            else
            {
                Console.WriteLine($"The winner is: Billy,better luck next time :) \n");
            }
            Console.WriteLine("Thanks for playing RPSGame untill next time :) \n");
            Console.ReadKey();
        }
    }
}
