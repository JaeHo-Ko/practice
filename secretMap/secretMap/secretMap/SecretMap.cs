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
            string binaryValue = Convert.ToString(decimalValue, 2).PadLeft(5, '0');
            return binaryValue;
        }

        // 2진수를 10진수로 변경
        public int DecimalConvert(string binaryValue)
        {
            int decimalValue = Convert.ToInt32(binaryValue, 2);
            return decimalValue;
        }

        // 2진수로 이루어진 배열을 0은 ' '로 1은 '#'으로 변환
        public string[] ConvertArrayValue()
        {
            string[] test = new string[] { "10101", "11111" };

            for(int k = 0; k < test.Length; k++)
            {
                char[] arr = test[k].ToCharArray();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == '0')
                    {
                        arr[i] = ' ';
                    }
                    else if (arr[i] == '1')
                        arr[i] = '#';
                }
                string test2 = new string(arr);
                test[k] = test2;
            }

            return test;
        }

        // 
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
    }
}