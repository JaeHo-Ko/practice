using System;
using System.Collections.Generic;
using System.Text;

namespace LongJump
{
    public class Jump
    {
        private readonly int JumpCount;

        public Jump(int value)
        {
            if (value < 1 || value > 2000)
            {
                throw new Exception();
            }
            this.JumpCount = value;
        }

        public void CalculatorJumpCount()
        {
            ulong[] f = new ulong[this.JumpCount];

            JumpCycle(f);

            Console.WriteLine(f[this.JumpCount - 1] % 1234567);
        }

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
