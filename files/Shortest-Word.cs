using System;

namespace Shortestword
{

    class SW
    {

        public static int FindShort(string s)
        {
            string[] array = s.Split(" ");
            int i = array[0].Length;


            foreach (string item in array)
            {
                if (item.Length < i)
                {
                    i = item.Length;
                }  
            }

            return i;
        }

        static void Main (string[] args) {
            string h = "this is a test";

            FindShort(h);

            Console.WriteLine();
        }
    }

}