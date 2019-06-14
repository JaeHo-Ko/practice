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
        public void ������_01001��_10������_��ȯ��_�ڸ�������Ȯ��()
        {
            SecretMap map = new SecretMap(7);
            int decimalValue = map.DecimalConvert("0001001");
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
            int[] arrTest = new int[5] { 31, 21, 29, 19, 31 };

            int[] combineArray = map.CombineArray(arr1, arr2);

            CollectionAssert.AreEqual(arrTest, combineArray);
        }

        [TestMethod]
        public void �Է¹���_2����_�迭��_��Ʈ����_�Ѵ�()
        {
            SecretMap map = new SecretMap(5);
            int[] arr1 = new int[] { 8, 18, 6, 24, 11 };
            int[] arr2 = new int[] { 5, 22, 28, 17, 14 };
            int[] arrTest = new int[5] { 13, 22, 30, 25, 15 };

            int[] combineArray = map.CombineArray(arr1, arr2);

            CollectionAssert.AreEqual(arrTest, combineArray);
        }

        [TestMethod]
        public void �Է¹���_string��_int�迭��_ġȯ()
        {
            SecretMap map = new SecretMap(5);
            int[] arr2 = new int[] { 9, 15, 24, 22, 7 };

            int[] arr1 = map.ConvertStringToInt("9 15 24 22 7");

            CollectionAssert.AreEqual(arr1, arr2);
        }

        [TestMethod]
        public void int�迭��_string�迭��_��ȯ_��_�迭��_����_2������_��ȯ_2������_������_ġȯ()
        {
            SecretMap map = new SecretMap(5);
            int[] arr1 = new int[] { 31, 21, 29, 19, 31 };
            string[] arr2 = new string[] { "#####", "# # #", "### #", "#  ##", "#####" };

            string[] result = map.ConversionBinaryContent(arr1);

            CollectionAssert.AreEqual(arr2, result);
        }

        [TestMethod]
        public void �ΰ���_string��_�޾�_�迭��_��ȯ_��_��Ʈ������_�����Ͽ�_����_�迭��_��������_�ٲ۵�_0��_��������_1��_������_����()
        {
            SecretMap map = new SecretMap(5);
            string[] arr2 = new string[] { "#####", "# # #", "### #", "#  ##", "#####" };

            string[] arr1 = map.ResultConvertArray("9 20 28 18 11", "30 1 21 17 28");

            CollectionAssert.AreEqual(arr1, arr2);
        }

        [TestMethod]
        public void �迭üũ()
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