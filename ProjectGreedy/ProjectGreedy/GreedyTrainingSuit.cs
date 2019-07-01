using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectGreedy
{
    public class GreedyTrainingSuit
    {
        private readonly int Student;
        private readonly int[] Lost;
        private readonly int[] Extra;

        public GreedyTrainingSuit(int student, string lost, string extra)
        {
            this.Student = student;
            this.Lost = lost.Split(" ").Select(int.Parse).ToArray();
            this.Extra = extra.Split(" ").Select(int.Parse).ToArray();
        }

        public void CalculatorGreedy()
        {
            int result = 0;
            int[] maxArray = new int[31];

            for(int i = 0; i < this.Lost.Length; i++)
            {
                maxArray[this.Lost[i]] -= 1;
            }
            for (int i = 0; i < this.Extra.Length; i++)
            {
                maxArray[this.Extra[i]] += 1;
            }

            for (int i = 1; i <= this.Student; i++)
            {
                if (maxArray[i] == 0)
                {
                    result++;
                    continue;
                }

                if (maxArray[i] > 0)
                {
                    result++;
                    continue;
                }
                if (maxArray[i] < 0)
                {
                    if (maxArray[i - 1] == 1)
                    {
                        maxArray[i - 1] = 0;
                        result++;
                        continue;
                    }
                    if (maxArray[i + 1] == 1)
                    {
                        maxArray[i + 1] = 0;
                        result++;
                        continue;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
