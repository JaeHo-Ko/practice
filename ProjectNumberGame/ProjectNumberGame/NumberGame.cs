using ProjectNumberGame;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectNumberGame
{
    class CardDeck
    {
        private readonly int[] _arr1;
        private readonly int[] _arr2;

        // int[]
        public CardDeck(int[] a, int[] b)
        {
            this._arr1 = (int[])a.Clone();
            this._arr2 = (int[])b.Clone();
        }
        // string
        public CardDeck(string a, string b)
        {
            int[] _a = a.Split(" ").Select(int.Parse).ToArray();
            int[] _b = b.Split(" ").Select(int.Parse).ToArray();

            this._arr1 = (int[])_a.Clone();
            this._arr2 = (int[])_b.Clone(); ;
        }
        // List<int>
        public CardDeck(List<int> a, List<int> b)
        {
            this._arr1 = (int[])a.ToArray().Clone();
            this._arr2 = (int[])b.ToArray().Clone();
        }

        public int[] YourDeck => _arr1;
        public int[] MyDeck => _arr2;
    }

    class CompareDecks
    {
        // 내림차순으로 int배열을 정렬한다.
        public int[] SortArray(int[] arrayValue)
        {
            int temp;

            for (int i = 0; i < arrayValue.Length; i++)
            {
                for (int k = i + 1; k < arrayValue.Length; k++)
                {
                    if (arrayValue[i] < arrayValue[k])
                    {
                        temp = arrayValue[i];
                        arrayValue[i] = arrayValue[k];
                        arrayValue[k] = temp;
                    }
                }
            }
            return arrayValue;
        }

        // 계산전 에러관련 조건을 적용.
        public void Constraint(int[] first_array, int[] second_array)
        {
            if (first_array.Length != second_array.Length)
                throw new ArgumentOutOfRangeException();

            if (first_array.Length < 0 || first_array.Length > 100000 || second_array.Length < 0 || second_array.Length > 100000)
                throw new ArgumentOutOfRangeException();
        }

        // 승점구하기
        public void CalculateVictoryPoint(int[] first_array, int[] second_array)
        {
            Constraint(first_array, second_array);
            SortArray(first_array);
            SortArray(second_array);

            int result = 0;

            foreach (int aValue in first_array)
            {
                foreach (int bValue in second_array)
                {
                    if (aValue < bValue)
                    {
                        result++;
                        int valueIndex = Array.IndexOf(second_array, bValue); // second_array배열에서 bValue의 객체를 검색. 처음 검색된 개체의 인덱스를 반환
                        second_array = second_array.Where((val, idx) => idx != valueIndex).ToArray();
                        break;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}