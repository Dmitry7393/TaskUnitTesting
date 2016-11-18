using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProjectString
{
    [TestClass]
    public class UnitTestReplace
    {
        [TestMethod]
        public void TestReplace_Char()
        {
            //arrange
            string initialString = "1 2 3 4 5 6 7";
            string expected = "1,2,3,4,5,6,7";

            //act
            string actual = initialString.Replace(' ', ',');

            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestReplace_String()
        {
            //arrange
            string originalString = "some string";
            string str = "ing";
            string str2 = "4";
            string expected = "some str4";

            //act
            string actual = originalString.Replace(str, str2);

            //assert
            Assert.AreEqual(actual, expected);
        } 
    }
}
