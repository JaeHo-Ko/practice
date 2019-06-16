using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectNumberGame;

namespace ProjectNumberGameTest
{
    [TestClass]
    public class UnitTest1
    {
        // To-Do
        // ���ӿ� ������ �ο��� ����(�� �ο���)
        // �� ���� �������� ���ڸ� �ο�
        // B�� �ݵ�� �̱�� ��Ȳ�� ��������(Ư��)

        // �迭�� 2�� �Է¹޴´�.
        // �迭�� �� ���� ���Ͽ� �ι�° �迭�� �ִ�� Ŭ���ֵ��� �Ѵ�.
        // �̸� ���� ���� �񱳴� ū������ �켱���Ͽ� ���Ѵ�.


        [TestMethod]
        public void �迭��_����_����_int�迭��_�����Ѱ�_1()
        {
            NumberGame test = new NumberGame();
            int[] a = new int[] { 1, 2, 3 };

            int[] b = test.ConvertStringToInt("1 2 3");

            CollectionAssert.AreEqual(a, b);
        }

        [TestMethod]
        public void �迭��_����_����_int�迭��_�����Ѱ�_2()
        {
            NumberGame test = new NumberGame();
            int[] a = new int[] { 4, 5, 6 };

            int[] b = test.ConvertStringToInt("4 5 6");

            CollectionAssert.AreEqual(a, b);
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

        //[TestMethod]
        //public void �迭��_����_ū����_8�ΰ�()
        //{
        //    NumberGame test = new NumberGame();

        //    test.ConvertStringToInt("");
        //}
    }
}
