using System;

namespace RPS
{
    class Program
    {

        public static void rps(string input1, string input2){

            string p1 = "Player 1 Wins";
            string p2 = "Player 2 Wins";

            if(input1 == input2)
            {
                Console.WriteLine("TIE");
            }
            else if(input1 == "r" && input2 == "s")
            {
                Console.WriteLine(p1);
            }
            else if(input1 == "r" && input2 == "p")
            {
                Console.WriteLine(p2);
            }
            else if(input1 == "p" && input2 == "s")
            {
                Console.WriteLine(p2);
            }
            else if(input1 == "p" && input2 == "r")
            {
                Console.WriteLine(p1);
            }
            else if(input1 == "s" && input2 == "r")
            {
                Console.WriteLine(p2);
            }
            else if(input1 == "s" && input2 == "p")
            {
                Console.WriteLine(p1);
            }
            else
            {
                Console.WriteLine("No Winner");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Player 1 enter 'r', 'p', or 's' :");
            string player1 = Console.ReadLine();
            Console.WriteLine("Player 2 enter 'r', 'p', or 's':");
            string player2 = Console.ReadLine();
            rps(player1, player2);
        }
    }
}
