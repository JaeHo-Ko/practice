using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectNumberGame;

namespace ProjectNumberGameTest
{
    [TestClass]
    public class UnitTest1
    {
        // To-Do
        // 게임에 참여할 인원을 모집(총 인원수)
        // 각 팀의 팀원에게 숫자를 부여
        // B가 반드시 이기는 상황을 만들어야함(특례)

        // 인원 입력여부가 확인되어 테스트 주석처리
        //[TestMethod] 
        //public void 게임_인원이_2명이_맞는가()
        //{
        //    NumberGame game = new NumberGame(2);
        //    int a = game.totalMember;
        //    Assert.AreEqual(2, a);
        //}

        //[TestMethod]
        //public void 게임_인원이_4명이_맞는가()
        //{
        //    NumberGame game = new NumberGame(4);
        //    int a = game.totalMember;
        //    Assert.AreEqual(4, a);
        //}

        [TestMethod]
        public void 각팀의_팀원은_1명이_맞는가()
        {
            NumberGame game = new NumberGame(2);
            int[] a = new int[1];

            int[] b = game.TestArray();

            CollectionAssert.AreEqual(a, b);
        }

        [TestMethod]
        public void 각팀의_팀원은_4명이_맞는가()
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
