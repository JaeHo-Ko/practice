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
        
        // 입력받은 배열을 오름차순으로 변경
        public int[] SortArray(int[] arrayValue)
        {
            int temp;

            for(int i=0; i < arrayValue.Length; i++)
            {
                for(int k=i+1; k < arrayValue.Length; k++)
                {
                    if (arrayValue[i] > arrayValue[k])
                    {
                        temp = arrayValue[i];
                        arrayValue[i] = arrayValue[k];
                        arrayValue[k] = temp;
                    }
                }
            }
            return arrayValue;
        }

        // 서로의 배열을 비교하여 큰경우 승점을 부여
        public int CompareToArrays(int[] first_array, int[] second_array)
        {
            int result = 0;
            for(int i=0; i<first_array.Length; i++)
            {
                if (first_array[i] < second_array[i])
                    result++;
            }
            return result;
        }

        // 실패 - 단순한 오름차순만으로는 계산에 오류(최대한의 승리를 계산치 못한다)
        public void test1(string first_string, string second_string)
        {
            int result;

            int[] first_array = ConvertStringToInt(first_string);
            int[] second_array = ConvertStringToInt(second_string);

            if (first_array.Length != second_array.Length)
                throw new NotImplementedException();

            result = CompareToArrays(first_array, SortArray(second_array));

            Console.WriteLine(SortArray(second_array)[0]);
            Console.WriteLine(SortArray(second_array)[1]);
            Console.WriteLine(SortArray(second_array)[2]);
            Console.WriteLine(SortArray(second_array)[3]);

            //Console.WriteLine($"B팀의 승점은 {result}입니다");
        }
    }
}