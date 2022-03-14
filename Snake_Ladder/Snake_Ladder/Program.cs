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
                Console.WriteLine(randomDie);
                rollDie++;

                Console.WriteLine(rollDie);

                string[] names = new string[] { "no play", "ladder", "snake" };
                Random rand = new Random();
                int index = rand.Next(names.Length);
                start++;
            }
           
        }
    }
}
