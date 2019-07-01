using System;

namespace ProjectGreedy
{
    class Program
    {
        static void Main(string[] args)
        {
            // 학생수 1<n<31
            // 도난학생수와 여벌학생수는 겹칠수잇음.
            // 학생의 중복번호는 존재하지 않음.
            // 여벌학생만 체육복을 빌려줄 수 있으나 여벌학생이 체육복을 도난당햇을 경우 빌려줄수 없음.

            //  (EX)
            //  n   lost    reserve    return
            //  5   [2, 4]  [1, 3, 5]    5
            //  5   [2, 4]     [3]       4
            //  3    [3]       [1]       2

            // 2번은 1,3에게 4번은 3,5에게 빌릴수있으며 이때 return은 5

            Console.Write("학생수를 입력하세요: ");
            int student = Int32.Parse(Console.ReadLine());
            Console.Write("체육복을 도난당한 학생번호를 입력하세요: ");
            string lost = Console.ReadLine();
            Console.Write("체육복 여벌이 있는 학생번호를 입력하세요: ");
            string extra = Console.ReadLine();

            GreedyTrainingSuit suit = new GreedyTrainingSuit(student, lost, extra);

            suit.CalculatorGreedy();

        }
    }
}
