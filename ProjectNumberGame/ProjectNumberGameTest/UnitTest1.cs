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
        [TestMethod]
        public void 게임_인원이_1명이_맞는가()
        {
            NumberGame game = new NumberGame();
            int a = game.Member;
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void 게임_인원이_4명이_맞는가()
        {
            NumberGame game = new NumberGame();
            int a = game.Member;
            Assert.AreEqual(4, a);
        }
    }
}
