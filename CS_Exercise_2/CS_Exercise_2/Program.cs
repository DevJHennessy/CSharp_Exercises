using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_2
{
    class Program
    {
        static void Main()
        {

            //1.Do a boolean comparison using an if statement.
            //int player1Score = 82;
            //int player2Score = 70;

            //if (player1Score > player2Score)
            //    Console.WriteLine("Player 1 is the winner!");
            //Console.ReadLine();

            //2.Do a boolean comparison using an else if statement.
            //int player1Score = 50;
            //int player2Score = 70;
            //if (player1Score > player2Score)
            //    Console.WriteLine("Player 1 is the winner!");
            //else if (player1Score < player2Score)
            //    Console.WriteLine("Player 2 is the winner!");
            //Console.ReadLine();

            //3.Do a boolean comparison using the ternary operator.
            int player1Score = 98;
            int player2Score = 100;

            string result = player1Score > player2Score ? "Player 1 wins!" : "Player 2 wins!";
            Console.WriteLine(result);
            Console.ReadLine();

        }

    }
}
