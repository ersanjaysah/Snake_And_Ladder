using System;

namespace Snake_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 0;
            Random obj = new Random();
            int randomDie = obj.Next(1, 7);
            Console.WriteLine(randomDie);

            string[] names = new string[] { "no play", "ladder", "snake" };
            Random rand = new Random();
            int index = rand.Next(names.Length);
            Console.WriteLine(index);
        }
    }
}
