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
        [TestMethod]
        public void ����_�ο���_1����_�´°�()
        {
            NumberGame game = new NumberGame();
            int a = game.Member;
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void ����_�ο���_4����_�´°�()
        {
            NumberGame game = new NumberGame();
            int a = game.Member;
            Assert.AreEqual(4, a);
        }
    }
}
