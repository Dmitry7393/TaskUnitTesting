using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectString
{
    /// <summary>
    /// Summary description for UnitTestSubstring
    /// </summary>
    [TestClass]
    public class UnitTestSubstring
    {
        [TestMethod]
        public void TestSubstring_startIndex()
        {
            //arrange
            string originalString = "my string 12345";
            int startIndex = 3;
            string expected = "string 12345";

            //act
            string actual = originalString.Substring(startIndex);

            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestSubstring_startIndex_Length()
        {
            //arrange
            string originalString = "my string 12345";
            int startIndex = 4;
            int length = 5;
            string expected = "tring";

            //act
            string actual = originalString.Substring(startIndex, length);

            //assert
            Assert.AreEqual(actual, expected);
        }
    }
}
