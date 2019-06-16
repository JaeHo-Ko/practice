using System;
using System.Linq;

namespace ProjectNumberGame
{
    public class NumberGame
    {
        // 입력받은 스트링값을 빈칸을 제거하고 int배열로 변경
        public int[] ConvertStringToInt(string stringArray)
        {
            int[] intArray = stringArray.Split(" ").Select(int.Parse).ToArray();

            foreach (int value in intArray)
            {
                if (value < 0)
                {
                    throw new NotImplementedException();
                }
            }
            return intArray;
        }



        public int[] NumberAssignment()
        {
            var a = new int[] { 2, 3 };
            return a;
        }

       
    }
}