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
        public void �ϴ�_2����_2������_��_�����_11111()
        {
            SecretMap map = new SecretMap(5);
            string test = map.CompareArrays(9, 30);
            Assert.AreEqual("11111", test);
        }

        [TestMethod]
        public void �ϴ�_2����_2������_��_�����_10101()
        {
            SecretMap map = new SecretMap(5);
            string test = map.CompareArrays(20, 1);
            Assert.AreEqual("10101", test);
        }

       [TestMethod]
        public void �ΰ���_�迭��_��_�����_����()
        {
            SecretMap map = new SecretMap(5);
            bool test = map.CompareArraysArrayMode();
            Assert.AreEqual(true, test);
        }

        [TestMethod]
        public void �迭��_����_���Ͽ�_�ϳ���_���()
        {
            SecretMap map = new SecretMap(5);
            int[] combineArray = map.CombineArray();
            int[] arrTest = new int[5] { 31, 21, 29, 19, 31 };
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
    }
}