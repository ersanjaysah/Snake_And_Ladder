using System;

namespace Snake_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 0;
            int finish = 100;
            int rollDie = 0;
            
            Random obj = new Random();

            while (start < finish)
            {
                int randomDie = obj.Next(1, 7);
                rollDie++;

                string[] names = new string[] { "no play", "ladder", "snake" };
                Random rand = new Random();
                int index = rand.Next(names.Length);


                if (names[index] == "ladder")
                {
                    start += randomDie;
                    if (start > 100)
                    {
                        start -= randomDie;
                    }
                }
                else if (names[index] == "snake")
                {
                    start -= randomDie;
                    if (start < 0)
                    {
                        start += randomDie;
                    }

                }

                Console.WriteLine("positions are in the game = " + start);

            }
           
        }
    }
}
