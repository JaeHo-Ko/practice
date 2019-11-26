using System;
using System.Numerics;
using System.Threading.Tasks;

namespace LongJump
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("멀리뛰기 총 칸수를 입력해주세요: ");
            //int jumpCount = Int32.Parse(Console.ReadLine());

            //Jump jump = new Jump(jumpCount);

            //jump.CalculatorJumpCount();

            int a = Int32.Parse(Console.ReadLine());

            long[] array = new long[2000];

            array[0] = 1;
            array[1] = 2;

            // 나머지 연산의 법칙을 이용(나누고자 하는 값보다 큰 값은 미리 나눈 나머지값에서부터 계산을 시작해도 나오는 마지막 값이 동일)
            for (int i = 2; i < a; i++)
            {
                array[i] = array[i - 1] + array[i - 2];

                if (array[i] > 1234567)
                {
                    array[i] %= 1234567;
                }
            }

            //for
            //    BigInteger b = new BigInteger(array[i]);

            // 더큰공간?
            // 나....머지연산?????? 법칙???
             //b = 6835702259575806647045396549170580107055408029365524565407553367798082454408054014954534318953113802726603726769523447478238192192714526677939943338306101405105414819705664090901813637296453767095528104868264704914433529355579148731044685634135487735897954629842516947101494253575869699893400976539545740214819819151952085089538422954565146720383752121972115725761141759114990448978941370030912401573418221496592822626;

            Console.WriteLine(array[a-1]);
        }
    }
}