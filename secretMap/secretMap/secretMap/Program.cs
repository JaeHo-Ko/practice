using System;
using System.Linq;

namespace PractiseSecretMap
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 한변의 길이를 입력
            Console.WriteLine("조건1. 한 변의 길이가 n인 정사각형 배열");
            Console.WriteLine("조건2. 각 칸은 공백(' ') 또는 벽('#') 두 종류로 이뤄짐");
            Console.WriteLine("조건3. 정수 배열의 암호화이다");
            Console.WriteLine("조건4. 각 가로줄에서 공백은 0, 벽은 1로 부호화시 얻어지는 2진수에 해당하는 값을 배열이다.");
            Console.Write("한 변의 길이: ");
            int.TryParse(Console.ReadLine(), out int numberOfSide);

            // 2. 한변의 길이와 동일한 첫번째 배열을 입력
            Console.Write("첫 번째 배열(길이는 변의 길이와 동일해야 한다): ");
            string first_string = Console.ReadLine();

            // 3. 한변의 길이와 동일한 두번째 배열을 입력
            Console.Write("두 번째 배열(길이는 변의 길이와 동일해야 한다): ");
            string second_string = Console.ReadLine();
            
            // 4. 입력된 값을 기반으로 배열의 비트연산 후 0,# 변환처리 및 출력
            SecretMap map = new SecretMap(numberOfSide);

            map.ResultConvertArray(first_string, second_string);
        }
    }
}
