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

        // �ο� �Է¿��ΰ� Ȯ�εǾ� �׽�Ʈ �ּ�ó��
        //[TestMethod] 
        //public void ����_�ο���_2����_�´°�()
        //{
        //    NumberGame game = new NumberGame(2);
        //    int a = game.totalMember;
        //    Assert.AreEqual(2, a);
        //}

        //[TestMethod]
        //public void ����_�ο���_4����_�´°�()
        //{
        //    NumberGame game = new NumberGame(4);
        //    int a = game.totalMember;
        //    Assert.AreEqual(4, a);
        //}

        [TestMethod]
        public void ������_������_1����_�´°�()
        {
            NumberGame game = new NumberGame(2);
            int[] a = new int[1];

            int[] b = game.TestArray();

            CollectionAssert.AreEqual(a, b);
        }

        [TestMethod]
        public void ������_������_4����_�´°�()
        {
            NumberGame game = new NumberGame(8);
            int[] a = new int[4];

            int[] b = game.TestArray();

            CollectionAssert.AreEqual(a, b);
        }

        //[TestMethod]
        //public void a()
        //{
        //}

        //[TestMethod]
        //public void a()
        //{
        //}

        //[TestMethod]
        //public void a()
        //{
        //}
    }
}
