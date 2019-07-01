using System;
using System.Numerics;
using System.Threading.Tasks;

namespace LongJump
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("멀리뛰기 총 칸수를 입력해주세요: ");
            int jumpCount = Int32.Parse(Console.ReadLine());

            Jump jump = new Jump(jumpCount);

            jump.CalculatorJumpCount();
        }
    }
}
