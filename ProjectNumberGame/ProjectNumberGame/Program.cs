using System;

namespace ProjectNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aTeam = { 5, 1, 3, 7 };
            int[] bTeam = { 2, 6, 2, 8 };
            int result = 0;

            for (int i = 0; i < aTeam.Length; i++)
            {
                if (aTeam[i] < bTeam[i])
                    result++;
            }
            Console.WriteLine(result);
        }
    }
}

