using System;

namespace Program
{
    internal class Program
    {

        public static string[] HasSurvived(int[] attackers, int[] defenders)
        {
            bool WhichIsLonger = attackers.Length <= defenders.Length;
            int n = WhichIsLonger ? defenders.Length:attackers.Length;
            string[] temp = new string[n];

            for (int i = 0; i < n; i++)
            {
                try
                {
                    if (attackers[i] == defenders[i])
                    {
                        temp[i] = "empty"; 
                        continue;
                    }

                    temp[i] = attackers[i] > defenders[i] ? "Attackers":"Defenders";
                }
                catch (System.Exception)
                {
                    
                }
            }

            return temp;
        }

        static void Main(string[] args)
        {
            string[] h = HasSurvived(new[] {3,2,1}, new[] {1,2,3});

            foreach (string item in h)
            {
                Console.WriteLine(item);
            }
        }
    }
}