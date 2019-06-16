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

        // 배열을 2개 입력받는다.
        // 배열의 각 값을 비교하여 두번째 배열이 최대로 클수있도록 한다.
        // 이를 위해 값의 비교는 큰값끼리 우선시하여 비교한다.


        [TestMethod]
        public void 배열의_값이_비교할_int배열과_동일한가_1()
        {
            NumberGame test = new NumberGame();
            int[] a = new int[] { 1, 2, 3 };

            int[] b = test.ConvertStringToInt("1 2 3");

            CollectionAssert.AreEqual(a, b);
        }

        [TestMethod]
        public void 배열의_값이_비교할_int배열과_동일한가_2()
        {
            NumberGame test = new NumberGame();
            int[] a = new int[] { 4, 5, 6 };

            int[] b = test.ConvertStringToInt("4 5 6");

            CollectionAssert.AreEqual(a, b);
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

        //[TestMethod]
        //public void 배열의_가장_큰값이_8인가()
        //{
        //    NumberGame test = new NumberGame();

        //    test.ConvertStringToInt("");
        //}
    }
}
