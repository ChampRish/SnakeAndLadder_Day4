using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem_Day4
{
    internal class UC4_RepeatPlayer
    {
        public static void RepeatPlayer()
        {
            int start = 0;
            int final = 100;
            int n;
            Random random = new Random();
            n = random.Next(95, 101);
            if (n == final)
            {
                Console.WriteLine("Starts from Starting Position");
            }
            else
            {
                Console.WriteLine("Play Continously");
            }
        }
    }
}
