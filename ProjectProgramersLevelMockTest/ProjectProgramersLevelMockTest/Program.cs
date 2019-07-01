using System;

namespace ProjectProgramersLevelMockTest
{
    class Program
    {
        // 수포자는 A,B,C이다
        // 맞춘 개수는 N개이다.
        // 제일 많이 맞춘 수포자만을 등록. 만일 모두 동일하게 맞췄다면 오름차순으로 리스트를 뿌려준다.
        // 배열의 원소는 1~5까지이다.
        // answers는 10000이하이다.

        static void Main(string[] args)
        {
            //int[] a = new int[] { 1, 2, 3, 4, 5 };

            //for(int i = 0; i< 100; i++)
            //{
            //    Console.Write(a[i % 5] + " ");
            //}


        }

        public int[] solution(int[] answers)
        {
            if (answers.Length > 10000)
                throw new ArgumentOutOfRangeException();


            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i] > 5)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }

            int[] answer = new int[] { 1,2,3 };
            int[] answer1 = new int[1];
            int[] answer2 = new int[2];

            int qu1 = 0;
            int qu2 = 0;
            int qu3 = 0;
            int repeatCount = 0;

            int[] luser1 = { 1, 2, 3, 4, 5 };
            int[] luser2 = { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] luser3 = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

            while(repeatCount < answers.Length)
            {
                if (answers[repeatCount] == luser1[repeatCount % 5])
                    qu1++;
                if (answers[repeatCount] == luser2[repeatCount % 8])
                    qu2++;
                if (answers[repeatCount] == luser3[repeatCount % 10])
                    qu3++;
                repeatCount++;
            }

            if(qu1 > qu2)
            {
                if (qu1 > qu3)
                {
                    answer1[0] = 1;
                    answer = answer1;
                }
                if (qu1 == qu3)
                {
                    answer2[0] = 1;
                    answer2[1] = 3;
                    answer = answer2;
                }
            }
            if (qu2 > qu1)
            {
                if(qu2 > qu3)
                {
                    answer1[0] = 2;
                    answer = answer1;
                }
                if(qu2 == qu3)
                {
                    answer2[0] = 2;
                    answer2[1] = 3;
                    answer = answer2;
                }
            }
            if (qu3 > qu1 && qu3 > qu2)
            {
                answer1[0] = 3;
                answer = answer1;
            }
            if (qu1 >qu3 && qu1 == qu2)
            {
                answer2[0] = 1;
                answer2[1] = 2;
                answer = answer2;
            }

            return answer;
        }
    }
}
