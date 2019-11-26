using System;
using System.Collections.Generic;
using System.Text;

namespace LongJump
{
    public class Jump
    {
        private readonly int JumpCount;

        // 점프의 총 칸수 제한
        public Jump(int value)
        {
            if (value < 1 || value > 2000)
            {
                throw new Exception();
            }
            this.JumpCount = value;
        }

        // 점프의 총 수를 계산하고 1234567로 나눈 나머지를 출력
        public void CalculatorJumpCount()
        {
            ulong[] f = new ulong[this.JumpCount];

            JumpCycle(f);

            Console.WriteLine(f[this.JumpCount - 1] % 1234567);
        }

        // 피보나치 수열을 계산. 1,2,3,5,8.....
        private void JumpCycle(ulong[] countValue)
        {
            int n = this.JumpCount;

            countValue[0] = 1;
            countValue[1] = 2;

            for (int i = 2; i < n; i++)
            {
                countValue[i] = countValue[i - 1] + countValue[i - 2];
            }
        }
    }
}
