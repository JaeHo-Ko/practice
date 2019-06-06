using System;
using System.Linq;

namespace PractiseSecretMap
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 한변의 길이를 입력
            Console.Write("한 변의 길이(1~16): ");
            int.TryParse(Console.ReadLine(), out int numberOfSide);

            SecretMap map = new SecretMap(numberOfSide);

            // 2. 한변의 길이와 동일한 첫번째 배열을 입력
            Console.Write("첫 번째 배열(길이는 변의 길이와 동일해야 한다): ");
            string first_string = Console.ReadLine();

            // 3. 한변의 길이와 동일한 두번째 배열을 입력
            Console.Write("두 번째 배열(길이는 변의 길이와 동일해야 한다): ");
            string second_string = Console.ReadLine();

            var first_array = map.ConvertStringToInt(first_string);
            var second_array = map.ConvertStringToInt(second_string);

            // 4. 배열의 비트연산 후 0,# 변환처리 및 출력
            var result_array = map.ConversionBinaryContent(map.CombineArray(first_array, second_array));

            for (int i = 0; i < numberOfSide; i++)
            {
                Console.Write("'"+ result_array[i]+"' ");
            }
            Console.WriteLine();
        }
    }
}
