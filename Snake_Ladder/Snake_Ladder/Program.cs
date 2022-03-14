using System;

namespace Snake_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int player1 = 0;
            int player2 = 0;
            int rollDie1 = 0;
            int rollDie2 = 0;
            int finish = 100;

            while (player1 < finish && player2 < finish)
            {
                Random obj = new Random();
                int randomDie1 = obj.Next(1, 7);
                rollDie1++;

                string[] names = new string[] { "no play", "ladder", "snake" };
                Random rand = new Random();
                int randomOption1 = rand.Next(names.Length);

                if (names[randomOption1] == "ladder")
                {
                    player1 += randomDie1;
                    if (player1 > 100)
                    {
                        player1 -= randomDie1;
                    }
                }
                else if (names[randomOption1] == "snake")
                {
                    player1 -= randomDie1;
                    if (player1 < 0)
                    {
                        player1 += randomDie1;
                    }
                }

                int randomDie2 = obj.Next(1, 7);
                rollDie2++;
                int randomOption2 = rand.Next(names.Length);

                if (names[randomOption2] == "ladder")
                {
                    player2 += randomDie2;
                    if (player2 > 100)
                    {
                        player2 -= randomDie2;
                    }
                }
                else if (names[randomOption2] == "snake")
                {
                    player2 -= randomDie2;
                    if (player2 < 0)
                    {
                        player2 += randomDie2;
                    }
                }
                Console.WriteLine("positions in the game of PLAYER 1 = " + player1);
                Console.WriteLine("Times of Die thrown By PLAYER 1 = " + rollDie1);

                Console.WriteLine("positions in the game of PLAYER 2 = " + player2);
                Console.WriteLine("Times of Die thrown By PLAYER 2 = " + rollDie2);

                if (player1 == 100)
                {
                    Console.WriteLine("\"Congratulations\" \n player 1 You \"won\" the game.");
                }
                if (player2 == 100)
                {
                    Console.WriteLine("\"Congratulations\" \n player 2 You \"won\" the game.");
                }

            }
        }
    }
}
