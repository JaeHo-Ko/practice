using System;

namespace ProjectNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // 숫자 카드 입력시 띄어쓰기로 구분해주세요.
            // A팀의 숫자 카드들을 입력해주세요
            Console.WriteLine("숫자 카드 입력시 띄어쓰기로 구분해주세요.");
            Console.Write("A팀의 숫자 카드들을 입력해주세요: ");
            string first_string = Console.ReadLine();

            Console.Write("B팀의 숫자 카드들을 입력해주세요: ");
            string second_string = Console.ReadLine();

            NumberGame game = new NumberGame();

            game.NumberGameActiveResult(first_string, second_string);
        }
    }
}

