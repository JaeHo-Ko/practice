using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectNumberGame;

namespace ProjectNumberGameTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void 배열의_값이_비교할_int배열과_동일한가_1()
        {
            NumberGame game = new NumberGame();
            int[] arr1 = { 1, 2, 3 };

            int[] arr2 = game.ConvertStringToInt("1 2 3");

            CollectionAssert.AreEqual(arr1, arr2);
        }

        [TestMethod]
        public void 배열의_값이_비교할_int배열과_동일한가_2()
        {
            NumberGame game = new NumberGame();
            int[] arr1 = { 4, 5, 6 };

            int[] arr2 = game.ConvertStringToInt("4 5 6");

            CollectionAssert.AreEqual(arr1, arr2);
        }

        // 음수값의 테스트는 정상일경우 테스트가 에러이기에 주석처리한다.
        //[TestMethod]
        //public void 배열의_값이_음수일때_에러를_발생시키는가()
        //{
        //    NumberGame test = new NumberGame();
        //    int[] a = new int[] { -4, 5, 6 };

        //    int[] b = test.ConvertStringToInt("-4 5 6");

        //    CollectionAssert.AreEqual(a, b);
        //}

        [TestMethod]
        public void 두개의_배열을_비교하면_arr2의_원소값중_크기가_2개_더_큰가()
        {
            NumberGame game = new NumberGame();
            int[] arr1 = { 4, 5, 6 };
            int[] arr2 = { 4, 6, 7 };
            int resultsToCompare = 2;

            int result = game.CompareToArrays(arr1, arr2);

            Assert.AreEqual(resultsToCompare, result);
        }

        [TestMethod]
        public void 두개의_배열을_비교하면_arr2의_원소값중_크기가_4개_더_큰가()
        {
            NumberGame game = new NumberGame();
            int[] arr1 = { 4, 5, 6, 1, 8, 9 };
            int[] arr2 = { 4, 6, 7, 2, 9, 2 };
            int resultsToCompare = 4;

            int result = game.CompareToArrays(arr1, arr2);

            Assert.AreEqual(resultsToCompare, result);
        }


        [TestMethod]
        public void 배열의_내부를_오름차순으로_변경하였는가_1()
        {
            NumberGame game = new NumberGame();
            int[] arrayToCalculate = new int[] { 6, 4, 5 };
            int[] resultsToCompare = new int[] { 4, 5, 6 };

            int[] resultToCalculate = game.SortArray(arrayToCalculate);

            CollectionAssert.AreEqual(resultsToCompare, resultToCalculate);
        }

        [TestMethod]
        public void 배열의_내부를_오름차순으로_변경하였는가_2()
        {
            NumberGame game = new NumberGame();
            int[] arrayToCalculate = new int[] { 1, 9, 7, 6 };
            int[] resultsToCompare = new int[] { 1, 6, 7, 9 };

            int[] resultToCalculate = game.SortArray(arrayToCalculate);

            CollectionAssert.AreEqual(resultsToCompare, resultToCalculate);
        }
    }
}
