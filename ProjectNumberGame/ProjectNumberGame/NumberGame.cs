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

            if(intArray.Length < 0 || intArray.Length > 100000)
            {
                throw new NotImplementedException();
            }

            foreach (int value in intArray)
            {
                if (value < 0 || value > 1000000000)
                {
                    throw new NotImplementedException();
                }
            }
            return intArray;
        }

        // 입력받은 배열을 오름차순으로 변경
        //public int[] SortArray(int[] arrayValue)
        //{
        //    int temp;

        //    for (int i = 0; i < arrayValue.Length; i++)
        //    {
        //        for (int k = i + 1; k < arrayValue.Length; k++)
        //        {
        //            if (arrayValue[i] > arrayValue[k])
        //            {
        //                temp = arrayValue[i];
        //                arrayValue[i] = arrayValue[k];
        //                arrayValue[k] = temp;
        //            }
        //        }
        //        //Console.Write(arrayValue[i]);
        //    }

        //    return arrayValue;
        //}        

        // 배열값을 비교하여 승점을 부여(단 B의 최대값을 A의 최대값과 묶어서 날린다)
        public int CompareToArrays(int[] first_array, int[] second_array)
        {
            int result = 0;

            foreach(int aValue in first_array)
            {
                foreach(int bValue in second_array)
                {
                    if(aValue < bValue)
                    {
                        result++;
                        int valueIndex = Array.IndexOf(second_array, bValue);
                        second_array = second_array.Where((val,idx) => idx != valueIndex).ToArray();
                        break;
                    }
                }
            }

            return result;
        }

        // 실패 - 단순한 오름차순만으로는 계산에 오류(최대한의 승리를 계산치 못한다)
        //public void test1(string first_string, string second_string)
        //{
        //    int result;

        //    int[] first_array = ConvertStringToInt(first_string);
        //    int[] second_array = ConvertStringToInt(second_string);

        //    if (first_array.Length != second_array.Length)
        //        throw new NotImplementedException();

        //    result = CompareToArrays(first_array, SortArray(second_array));

        //    Console.WriteLine($"B팀의 승점은 {result}입니다");
        //}

        // 결과 성공
        public void NumberGameActiveResult(string first_string, string second_string)
        {
            int result;

            int[] first_array = ConvertStringToInt(first_string);
            int[] second_array = ConvertStringToInt(second_string);

            if (first_array.Length != second_array.Length)
                throw new NotImplementedException();

            //result = CompareToArrays(first_array, SortArray(second_array));
            result = CompareToArrays(first_array, second_array);

            Console.WriteLine($"B팀의 승점은 {result}입니다");
        }
    }
}