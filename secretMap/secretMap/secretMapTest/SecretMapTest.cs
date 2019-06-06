using Microsoft.VisualStudio.TestTools.UnitTesting;
using PractiseSecretMap;

namespace PractiseSecretMapTest
{
    [TestClass]
    public class SecretMapTest
    {
        [TestMethod]
        public void ����_������_5��_Ȯ��()
        {
            SecretMap map = new SecretMap(5);
            int line = map.Line;
            Assert.AreEqual(5, line);
        }

        [TestMethod]
        public void ����_������_7��_Ȯ��()
        {
            SecretMap map = new SecretMap(7);
            int line = map.Line;
            Assert.AreEqual(7, line);
        }

        [TestMethod]
        public void ������_9��_2������_��ȯ()
        {
            SecretMap map = new SecretMap(5);
            string binaryValue = map.BinaryConvert(9);
            Assert.AreEqual("01001", binaryValue);
        }

        [TestMethod]
        public void ������_20��_2������_��ȯ()
        {
            SecretMap map = new SecretMap(5);
            string binaryValue = map.BinaryConvert(20);
            Assert.AreEqual("10100", binaryValue);
        }

        [TestMethod]
        public void ������_1��_2������_��ȯ()
        {
            SecretMap map = new SecretMap(5);
            string binaryValue = map.BinaryConvert(1);
            Assert.AreEqual("00001", binaryValue);
        }

        [TestMethod]
        public void ������_01001��_10������_��ȯ()
        {
            SecretMap map = new SecretMap(5);
            int decimalValue = map.DecimalConvert("01001");
            Assert.AreEqual(9, decimalValue);
        }

        [TestMethod]
        public void ������_11110��_10������_��ȯ()
        {
            SecretMap map = new SecretMap(5);
            int decimalValue = map.DecimalConvert("11110");
            Assert.AreEqual(30, decimalValue);
        }

        [TestMethod]
        public void �迭��_����_���Ͽ�_�ϳ���_���()
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
        public void �Է¹���_2����_�迭��_��Ʈ����_�Ѵ�()
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
        public void �Ѱ���_�迭����_��������_0��_1��_����_��ĭ��_������_��ȯ()
        {
            SecretMap map = new SecretMap(5);
            string[] test = map.ConvertArrayValue();
            string[] test1 = new string[] { "# # #" };
            Assert.AreEqual(test1[0], test[0]);
        }

        [TestMethod]
        public void �ΰ���_�迭����_��������_0��_1��_����_��ĭ��_������_��ȯ()
        {
            SecretMap map = new SecretMap(5);
            string[] test = map.ConvertArrayValue();
            string[] test1 = new string[] { "# # #", "#####" };
            Assert.AreEqual(test1[0], test[0]);
            Assert.AreEqual(test1[1], test[1]);
        }

        [TestMethod]
        public void �Է¹���_string��_int�迭��_ġȯ()
        {
            SecretMap map = new SecretMap(5);
            int[] arr1 = map.ConvertStringToInt("9 15 25 22 7");
            int[] arr2 = new int[] { 9, 15, 25, 22, 7 };
            Assert.AreEqual(arr2[0], arr1[0]);
        }

        [TestMethod]
        public void int�迭��_string�迭��_��ȯ_��_�迭��_����_2������_��ȯ_2������_������_ġȯ()
        {
            SecretMap map = new SecretMap(5);
            int[] arr1 = new int[] { 31, 21, 29, 19, 31 };
            string[] arr2 = new string[] { "#####", "# # #", "### #", "# ##", "#####" };
            string[] result = map.ConversionBinaryContent(arr1);
            Assert.AreEqual(arr2[0], result[0]);
        }
    }
}