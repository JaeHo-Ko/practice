using System;

namespace PractiseSecretMap
{
    public class SecretMap
    {
        // 변의 길이
        private readonly int numberOfSides;

        public SecretMap(int numberOfSide)
        {
            this.numberOfSides = numberOfSide;
        }

        public int Line => numberOfSides;

        // 10진수를 2진수로 변경 (하나로 합칠지는 피드백 후 리펙토링)
        public string BinaryConvert(int value)
        {
            string binaryValue = Convert.ToString(value, 2).PadLeft(5, '0');
            return binaryValue;
        }

        // 2진수를 10진수로 변경 (하나로 합칠지는 피드백 후 리펙토링)
        public int DecimalConvert(string value)
        {
            int decimalValue = Convert.ToInt32(value, 2);
            return decimalValue;
        }

        // 1번맵과 2번맵의 배열을 하나로 하여 비교한뒤 계산된 값을 2진수로 컨버트
        public string CompareArrays(int map_one, int map_two)
        {
            string compareValue = Convert.ToString(map_one | map_two, 2).PadLeft(5, '0');
            return compareValue;

        }

        // 2개의 배열 값을 비교하여 각 배열값이 동일하면 true출력
        public bool CompareArraysArrayMode()
        {
            int[] arr1 = new int[] { 1, 2, 2, 3 };
            int[] arr2 = new int[] { 1, 2, 2, 4 };
            bool test = arr1[0] == arr2[0];
            // 각각의 배열값에 있는 값을 비교해서 출력비교
            bool test2 = arr1[3] == arr2[3];
            // 배열의 값이 각각 3과 4로 달라서 false출력
            return test;

        }

        // 배열의 값을 비교한뒤 각각의 배열값을 비트연산 후 합산&출력
        public int[] CombineArray()
        {
            int[] arr1 = new int[] { 9, 20, 28, 18, 11 };
            int[] arr2 = new int[] { 30, 1, 21, 17, 28 };

            int[] testc = new int[numberOfSides];

            for(int i = 0; i < numberOfSides; i++)
            {
                testc[i] = arr1[i] | arr2[i];
            }

            return testc;
        }

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
    }
}