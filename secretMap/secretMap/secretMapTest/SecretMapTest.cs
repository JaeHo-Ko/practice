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
            int[] combineArray = map.CombineArray(arr1, arr2);

            int[] arrTest = new int[5] { 31, 21, 29, 19, 31 };
            Assert.AreEqual(arrTest[0], combineArray[0]);
            Assert.AreEqual(arrTest[1], combineArray[1]);
            Assert.AreEqual(arrTest[2], combineArray[2]);
            Assert.AreEqual(arrTest[3], combineArray[3]);
            Assert.AreEqual(arrTest[4], combineArray[4]);
        }

        [TestMethod]
        public void 입력받은_2개의_배열을_비트연산_한다()
        {
            SecretMap map = new SecretMap(5);
            int[] arr1 = new int[] { 8, 18, 6, 24, 11 };
            int[] arr2 = new int[] { 5, 22, 28, 17, 14 };
            int[] combineArray = map.CombineArray(arr1, arr2);

            int[] arrTest = new int[5] { 13, 22, 30, 25, 15 };
            Assert.AreEqual(arrTest[0], combineArray[0]);
            Assert.AreEqual(arrTest[1], combineArray[1]);
            Assert.AreEqual(arrTest[2], combineArray[2]);
            Assert.AreEqual(arrTest[3], combineArray[3]);
            Assert.AreEqual(arrTest[4], combineArray[4]);
        }

        [TestMethod]
        public void 한개의_배열값속_이진수의_0과_1을_각각_빈칸과_샵으로_변환()
        {
            SecretMap map = new SecretMap(5);
            string[] test = map.ConvertArrayValue();
            string[] test1 = new string[] { "# # #" };
            Assert.AreEqual(test1[0], test[0]);
        }

        [TestMethod]
        public void 두개의_배열값속_이진수의_0과_1을_각각_빈칸과_샵으로_변환()
        {
            SecretMap map = new SecretMap(5);
            string[] test = map.ConvertArrayValue();
            string[] test1 = new string[] { "# # #", "#####" };
            Assert.AreEqual(test1[0], test[0]);
            Assert.AreEqual(test1[1], test[1]);
        }

        [TestMethod]
        public void 입력받은_string을_int배열로_치환()
        {
            SecretMap map = new SecretMap(5);
            int[] arr1 = map.ConvertStringToInt("9 15 25 22 7");
            int[] arr2 = new int[] { 9, 15, 25, 22, 7 };
            Assert.AreEqual(arr2[0], arr1[0]);
        }

        [TestMethod]
        public void int배열을_string배열로_변환_후_배열의_값을_2진수로_변환_2진수의_내용을_치환()
        {
            SecretMap map = new SecretMap(5);
            int[] arr1 = new int[] { 31, 21, 29, 19, 31 };
            string[] arr2 = new string[] { "#####", "# # #", "### #", "# ##", "#####" };
            string[] result = map.ConversionBinaryContent(arr1);
            Assert.AreEqual(arr2[0], result[0]);
        }
    }
}