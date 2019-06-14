using Microsoft.VisualStudio.TestTools.UnitTesting;
using PractiseSecretMap;

namespace PractiseSecretMapTest
{
    [TestClass]
    public class SecretMapTest
    {
        [TestMethod]
        public void 변의_갯수가_5개_확인()
        {
            SecretMap map = new SecretMap(5);
            int line = map.Line;
            Assert.AreEqual(5, line);
        }

        [TestMethod]
        public void 변의_갯수가_7개_확인()
        {
            SecretMap map = new SecretMap(7);
            int line = map.Line;
            Assert.AreEqual(7, line);
        }

        [TestMethod]
        public void 십진수_9를_2진수로_변환()
        {
            SecretMap map = new SecretMap(5);
            string binaryValue = map.BinaryConvert(9);
            Assert.AreEqual("01001", binaryValue);
        }

        [TestMethod]
        public void 십진수_20을_2진수로_변환()
        {
            SecretMap map = new SecretMap(5);
            string binaryValue = map.BinaryConvert(20);
            Assert.AreEqual("10100", binaryValue);
        }

        [TestMethod]
        public void 십진수_1을_2진수로_변환()
        {
            SecretMap map = new SecretMap(5);
            string binaryValue = map.BinaryConvert(1);
            Assert.AreEqual("00001", binaryValue);
        }

        [TestMethod]
        public void 이진수_01001을_10진수로_변환()
        {
            SecretMap map = new SecretMap(5);
            int decimalValue = map.DecimalConvert("01001");
            Assert.AreEqual(9, decimalValue);
        }

        [TestMethod]
        public void 이진수_01001을_10진수로_변환시_자리수적용확인()
        {
            SecretMap map = new SecretMap(7);
            int decimalValue = map.DecimalConvert("0001001");
            Assert.AreEqual(9, decimalValue);
        }

        [TestMethod]
        public void 이진수_11110을_10진수로_변환()
        {
            SecretMap map = new SecretMap(5);
            int decimalValue = map.DecimalConvert("11110");
            Assert.AreEqual(30, decimalValue);
        }

        [TestMethod]
        public void 배열의_값을_비교하여_하나로_출력()
        {
            SecretMap map = new SecretMap(5);

            int[] arr1 = new int[] { 9, 20, 28, 18, 11 };
            int[] arr2 = new int[] { 30, 1, 21, 17, 28 };
            int[] arrTest = new int[5] { 31, 21, 29, 19, 31 };

            int[] combineArray = map.CombineArray(arr1, arr2);

            CollectionAssert.AreEqual(arrTest, combineArray);
        }

        [TestMethod]
        public void 입력받은_2개의_배열을_비트연산_한다()
        {
            SecretMap map = new SecretMap(5);
            int[] arr1 = new int[] { 8, 18, 6, 24, 11 };
            int[] arr2 = new int[] { 5, 22, 28, 17, 14 };
            int[] arrTest = new int[5] { 13, 22, 30, 25, 15 };

            int[] combineArray = map.CombineArray(arr1, arr2);

            CollectionAssert.AreEqual(arrTest, combineArray);
        }

        [TestMethod]
        public void 입력받은_string을_int배열로_치환()
        {
            SecretMap map = new SecretMap(5);
            int[] arr2 = new int[] { 9, 15, 24, 22, 7 };

            int[] arr1 = map.ConvertStringToInt("9 15 24 22 7");

            CollectionAssert.AreEqual(arr1, arr2);
        }

        [TestMethod]
        public void int배열을_string배열로_변환_후_배열의_값을_2진수로_변환_2진수의_내용을_치환()
        {
            SecretMap map = new SecretMap(5);
            int[] arr1 = new int[] { 31, 21, 29, 19, 31 };
            string[] arr2 = new string[] { "#####", "# # #", "### #", "#  ##", "#####" };

            string[] result = map.ConversionBinaryContent(arr1);

            CollectionAssert.AreEqual(arr2, result);
        }

        [TestMethod]
        public void 두개의_string을_받아_배열로_변환_후_비트연산을_실행하여_나온_배열을_이진수로_바꾼뒤_0은_공백으로_1은_샵으로_변경()
        {
            SecretMap map = new SecretMap(5);
            string[] arr2 = new string[] { "#####", "# # #", "### #", "#  ##", "#####" };

            string[] arr1 = map.ResultConvertArray("9 20 28 18 11", "30 1 21 17 28");

            CollectionAssert.AreEqual(arr1, arr2);
        }

        [TestMethod]
        public void 배열체크()
        {
            string[] arr1 = new string[] { "AAA", "BBB", "CCC" };
            string[] arr2 = new string[] { "AAA", "BBB", "CCC" };
            //Assert.AreEqual(arr1, arr2);
            //Assert.AreSame(arr1, arr2);
            CollectionAssert.AreEqual(arr1, arr2);
            //actual.Should().Equal(arr1);
        }
    }
}