using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock__Paper__Scissors
{
    public class Player
    {

        private string name;
        private int score;

        public Player(string name)
        {
            this.name = name;
            this.score = 0;
        }
        //this is way one to do getters and setters 
      /*  public string getname()
        {
            return name;
        }

        public string setname(string name)
        {
            this.name = name;

            return name;
        }*/


        //this is way 2 of getting and setting
      /*
        public string setname(string name)
        {
            this.name = name; // ***************>>>this points at the instance 
            return name;  ********************>>>returns the actual name field
        }*/

        //way 3 of doing get and set
        public String Name
        {
            get {
                return name;
            }
            set{
                name=value;
            }
        }


        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }


        
        public string Move()
        {
            Console.WriteLine("Choose a move please(Rock,Paper,Scissors) \n");
            string move = Console.ReadLine().ToLower();

            Boolean move_test=Int32.TryParse(move, out int move_output);
            while (move!="rock" && move!= "paper" && move != "scissors")
            {
                move_test = Int32.TryParse(move, out int move_outputs);
                if (move_test != false)
                {
                    Console.WriteLine("Invalid input :<,please try again! \n");
                    Console.WriteLine("What's your move? \n");
                    move = Console.ReadLine().ToLower();

                }

                else if(move != "rock" && move != "paper" && move != "scissors") 
                {
                    Console.WriteLine("Sorry,this choice isn't available :( \n");
                    Console.WriteLine("What's your move? \n");
                    move = Console.ReadLine().ToLower();


                }
            }
            return move;
        }


    }
}
