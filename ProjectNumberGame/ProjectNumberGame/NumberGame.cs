using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectNumberGame
{
    class GamePreparation
    {
        // 스트링 2개를 한번에 받게 하는가?
        //public void NumberCard(string aTeam, string bTeam)
        //{
        //    int[] aTeam = aTeam.Split(" ").Select(int.Parse).ToArray();
        //}

        // 준비과정 1-1. 숫자카드 준비
        public int[] NumberCard(string teamCards)
        {
            int[] cards = teamCards.Split(" ").Select(int.Parse).ToArray();

            if (cards.Length < 0 || cards.Length > 100000)
            {
                throw new NotImplementedException();
            }

            foreach (int value in cards)
            {
                if (value < 0 || value > 1000000000)
                {
                    throw new NotImplementedException();
                }
            }

            return cards;
        }

        // 준비과정 2. 승점구하기
        public int CalculateVictoryPoint(int[] first_array, int[] second_array)
        {
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

            return result;
        }

        public int CalculateVictoryPoint(List<int> first_array, List<int> second_array)
        {
            int result = 0;

            foreach (int aValue in first_array)
            {
                int removeIndex = 0;
                foreach (int bValue in second_array)
                {
                    if (aValue < bValue)
                    {
                        result++;
                        second_array.RemoveAt(removeIndex);
                        break;
                    }
                    ++removeIndex;
                }
            }

            return result;
        }
    }

    public class NumberGame
    {
        GamePreparation preparations = new GamePreparation();
                
        // 결과 성공
        public void Play(string first_string, string second_string)
        {
            int result;

            int[] first_array = preparations.NumberCard(first_string);
            int[] second_array = preparations.NumberCard(second_string);

            if (first_array.Length != second_array.Length)
                throw new NotImplementedException();

            //result = CompareToArrays(first_array, SortArray(second_array));
            result = preparations.CalculateVictoryPoint(first_array, second_array);

            Console.WriteLine($"B팀의 승점은 {result}입니다");
        }

        public void Play(int[] first_int_value, int[] second_int_value)
        {
            int result;

            if (first_int_value.Length != second_int_value.Length)
                throw new NotImplementedException();

            //result = CompareToArrays(first_array, SortArray(second_array));
            result = preparations.CalculateVictoryPoint(first_int_value, second_int_value);

            Console.WriteLine($"B팀의 승점은 {result}입니다");
        }

        public void Play(List<int> first_list, List<int> second_list)
        {
            int result;

            if (first_list.Count != second_list.Count)
                throw new NotImplementedException();

            //result = CompareToArrays(first_array, SortArray(second_array));
            result = preparations.CalculateVictoryPoint(first_list, second_list);

            Console.WriteLine($"B팀의 승점은 {result}입니다");
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

        // 인트배열을 받아서 승점 계산
        //public void palyGameInIntArray(int[] first_array, int[] second_array)
        //{
        //    int result;

        //    if (first_array.Length != second_array.Length)
        //        throw new NotImplementedException();

        //    //result = CompareToArrays(first_array, SortArray(second_array));
        //    result = CompareToArrays(first_array, second_array);

        //    Console.WriteLine($"B팀의 승점은 {result}입니다");
        //}

        //public void CalculatePointsInIntList(List<int> first_array, List<int> second_array)
        //{
        //    int result;

        //    if (first_array.Count != second_array.Count)
        //        throw new NotImplementedException();

        //    //result = CompareToArrays(first_array, SortArray(second_array));
        //    result = CompareToLists(first_array, second_array);

        //    Console.WriteLine($"B팀의 승점은 {result}입니다");
        //}

        //public int CompareToLists(List<int> first_array, List<int> second_array)
        //{
        //    int result = 0;

        //    foreach (int aValue in first_array)
        //    {
        //        int removeIndex = 0;
        //        foreach (int bValue in second_array)
        //        {
        //            if (aValue < bValue)
        //            {
        //                result++;
        //                second_array.RemoveAt(removeIndex);
        //                break;
        //            }
        //            ++removeIndex;
        //        }
        //    }

        //    return result;
        //}
    }
}