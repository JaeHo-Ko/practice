using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectNumberGame;

namespace ProjectNumberGameTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void �迭��_����_����_int�迭��_�����Ѱ�_1()
        {
            NumberGame game = new NumberGame();
            int[] arr1 = { 1, 2, 3 };

            int[] arr2 = game.ConvertStringToInt("1 2 3");

            CollectionAssert.AreEqual(arr1, arr2);
        }

        [TestMethod]
        public void �迭��_����_����_int�迭��_�����Ѱ�_2()
        {
            NumberGame game = new NumberGame();
            int[] arr1 = { 4, 5, 6 };

            int[] arr2 = game.ConvertStringToInt("4 5 6");

            CollectionAssert.AreEqual(arr1, arr2);
        }

        // �������� �׽�Ʈ�� �����ϰ�� �׽�Ʈ�� �����̱⿡ �ּ�ó���Ѵ�.
        //[TestMethod]
        //public void �迭��_����_�����϶�_������_�߻���Ű�°�()
        //{
        //    NumberGame test = new NumberGame();
        //    int[] a = new int[] { -4, 5, 6 };

        //    int[] b = test.ConvertStringToInt("-4 5 6");

        //    CollectionAssert.AreEqual(a, b);
        //}

        [TestMethod]
        public void �ΰ���_�迭��_���ϸ�_arr2��_���Ұ���_ũ�Ⱑ_2��_��_ū��()
        {
            NumberGame game = new NumberGame();
            int[] arr1 = { 4, 5, 6 };
            int[] arr2 = { 4, 6, 7 };
            int resultsToCompare = 2;

            int result = game.CompareToArrays(arr1, arr2);

            Assert.AreEqual(resultsToCompare, result);
        }

        [TestMethod]
        public void �ΰ���_�迭��_���ϸ�_arr2��_���Ұ���_ũ�Ⱑ_4��_��_ū��()
        {
            NumberGame game = new NumberGame();
            int[] arr1 = { 4, 5, 6, 1, 8, 9 };
            int[] arr2 = { 4, 6, 7, 2, 9, 2 };
            int resultsToCompare = 4;

            int result = game.CompareToArrays(arr1, arr2);

            Assert.AreEqual(resultsToCompare, result);
        }


        [TestMethod]
        public void �迭��_���θ�_������������_�����Ͽ��°�_1()
        {
            NumberGame game = new NumberGame();
            int[] arrayToCalculate = new int[] { 6, 4, 5 };
            int[] resultsToCompare = new int[] { 4, 5, 6 };

            int[] resultToCalculate = game.SortArray(arrayToCalculate);

            CollectionAssert.AreEqual(resultsToCompare, resultToCalculate);
        }

        [TestMethod]
        public void �迭��_���θ�_������������_�����Ͽ��°�_2()
        {
            NumberGame game = new NumberGame();
            int[] arrayToCalculate = new int[] { 1, 9, 7, 6 };
            int[] resultsToCompare = new int[] { 1, 6, 7, 9 };

            int[] resultToCalculate = game.SortArray(arrayToCalculate);

            CollectionAssert.AreEqual(resultsToCompare, resultToCalculate);
        }
    }
}
