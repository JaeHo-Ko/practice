using System;
using System.Linq;

namespace PractiseSecretMap
{
    public class SecretMap
    {
        // 변의 길이(1~16까지의 입력만을 받는다)
        private readonly int numberOfSides;

        public SecretMap(int numberOfSide)
        {
            if(numberOfSide <= 16)
                this.numberOfSides = numberOfSide;
            else
                throw new NotImplementedException();
        }

        public int Line => numberOfSides;

        // 입력받은 스트링값을 빈칸을 제거하고 int배열로 변경
        public int[] ConvertStringToInt(string stringArray)
        {
            int[] intArray = stringArray.Split(" ").Select(int.Parse).ToArray();

            foreach(int test in intArray)
            {
                if (test > Math.Pow(2, numberOfSides) - 1)
                {
                    //Console.WriteLine("한변에 들어갈수있는 최대 정수값을 넘었습니다.");
                    throw new NotImplementedException();
                }
            }
            return intArray;

        }

        // 배열의 값을 비교한뒤 각각의 배열값을 비트연산 후 합산&출력
        public int[] CombineArray(int[] first_array, int[] second_array)
        {
            int[] result = new int[numberOfSides];

            for(int i = 0; i < numberOfSides; i++)
            {
                result[i] = first_array[i] | second_array[i];
            }

            return result;
        }

        // 10진수를 2진수로 변경
        public string BinaryConvert(int decimalValue)
        {
            string binaryValue = Convert.ToString(decimalValue, 2).PadLeft(numberOfSides, '0');
            return binaryValue;
        }

        // 2진수를 10진수로 변경
        public int DecimalConvert(string binaryValue)
        {
            int decimalValue = Convert.ToInt32(binaryValue, 2);
            return decimalValue;
        }

        // int배열을 받아서 2진수로 변환 및 2진수의 0을 ' '으로 1을 '#'으로 변환
        public string[] ConversionBinaryContent(int[] intArray)
        {
            string[] conversionResult = new string[numberOfSides];

            for (int i = 0; i < numberOfSides; i++)
            {
                conversionResult[i] = BinaryConvert(intArray[i]);

                char[] arr = conversionResult[i].ToCharArray();
                for (int k = 0; k < arr.Length; k++)
                {
                    if (arr[k] == '0')
                    {
                        arr[k] = ' ';
                    }
                    else if (arr[k] == '1')
                        arr[k] = '#';
                }
                string converArr = new string(arr);
                conversionResult[i] = converArr;
            }

            return conversionResult;
        }

        // 입력값을 기반으로 배열의 비트연산을 실행 후 2진수로 변환한 뒤 각각 0,1을 공백과 #으로 바꿔서 콘솔에 출력
        public string[] ResultConvertArray(string first_string, string second_string)
        {
            var first_array = ConvertStringToInt(first_string);
            var second_array = ConvertStringToInt(second_string);

            var result = ConversionBinaryContent(CombineArray(first_array, second_array));

#if DEBUG

            for (int i = 0; i < numberOfSides; i++)
            {
                //System.Diagnostics.Debug.Write("'" + result[i] + "' ");
                Console.Write("'" + result[i] + "' ");
            }
            //Console.WriteLine();
#endif

            return result;
        }
    }
}