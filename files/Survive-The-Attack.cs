using System;

namespace Program
{
    internal class Program
    {

        public static bool HasSurvived(int[] attackers, int[] defenders)
        {

            //variables
            //checks which array is longer
            bool WhichIsLonger = attackers.Length <= defenders.Length;
            //gets the length of the longest array
            int n = WhichIsLonger ? defenders.Length:attackers.Length;
            //sets the array string
            int[] temp = new int[3];

            //main loop for step 1
            for (int i = 0; i < n; i++)
            {
                try
                {
                    if (attackers[i] == defenders[i])
                    {
                        continue;
                    }

                    temp[attackers[i] > defenders[i] ? 1:2] += 1 ;
                }
                catch (System.Exception)
                {
                    temp[WhichIsLonger ? 2:1] += 1;
                }
            }

            int Asum = 0, Dsum = 0;
            Array.ForEach(attackers, delegate(int i) {Asum += i; });
            Array.ForEach(defenders, delegate(int i) {Dsum += i; });

            if (temp[2] == temp[1])
            {
                return Asum <= Dsum; 
            }

            return temp[1] < temp[2];
        }

        static void Main(string[] args)
        {
            bool h = HasSurvived(new[] {2, 9, 9, 7}, new[] {1, 1, 3, 8});

            Console.WriteLine(h ? "The battle is WON!!!":"the battle is sadly lost");
        }
    }
}