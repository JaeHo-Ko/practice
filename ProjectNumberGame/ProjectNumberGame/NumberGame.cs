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
        private void SortArray(int[] arrayValue)
        {
            Array.Sort(arrayValue);
            Array.Reverse(arrayValue);
        }

        // 계산전 에러관련 조건을 적용.
        private void Constraint(int[] first_array, int[] second_array)
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

            //List<int> test = second_array.ToList();
            //test.OrderByDescending(i => i);

            //for(int i = 0; i< first_array.Length; i++)
            //{
            //    for(int k = 0; k<second_array.Length; k++)
            //    {
            //        if(first_array[i] >= second_array[k])
            //        {
            //            Console.WriteLine("1");
            //            break;
            //        }

            //        else if(first_array[i] < second_array[k])
            //        {
            //            result++;
            //            Console.WriteLine("2");
            //            break;

            //        }
            //    }
            //}

            int i = 0;
            int j = 0;

            while (i < first_array.Length)
            {
                if(first_array[i] >= second_array[j])
                {
                    i++;
                }
                else if(first_array[i] < second_array[j])
                {
                    result++;
                    i++;
                    j++;
                }
            }

            //4 3 2 1
            //3 3 1 0

            //}
            //foreach (int aValue in first_array)
            //{
            //    if(aValue < test.Max())
            //    {
            //        result++;
            //        test.Remove(test.Max());
            //        continue;
            //    }
            //}
            Console.WriteLine(result);
        }
    }
}