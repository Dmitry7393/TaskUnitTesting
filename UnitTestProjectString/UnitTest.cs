using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProjectString
{
    [TestClass]
    public class UnitTest
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

        [TestMethod]
        public void TestSplitString_Char()
        {
            //arrange
            string originalString = "Split is+used-to break+a*delimited string+into substrings";
            string separators = " -+*";
            string[] expected = new string[] { "Split", "is", "used", "to", "break", "a", "delimited", "string", "into", "substrings" };

            //act
            string[] actual = originalString.Split(separators.ToCharArray());

            //assert
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestSplitString_CharMaxReturns()
        {
            //arrange
            string originalString = "Split is+used-to break+a*delimited string+into substrings";
            string separators = " -+*";
            int count = 4;
            string[] expected = new string[] { "Split", "is", "used", "to break+a*delimited string+into substrings" };

            //act
            string[] actual = originalString.Split(separators.ToCharArray(), count);


            //assert
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestSplitString_Char_CountOptions()
        {
            //arrange
            string originalString = "Split is+used-to break+a*delimited string+into substrings";
            string separators = "-+* ";
            int count = 7;
            string[] expected = new string[] { "Split", "is", "used", "to", "break", "a", "delimited string+into substrings" };

            //act
            string[] actual = originalString.Split(separators.ToCharArray(), count, StringSplitOptions.RemoveEmptyEntries);


            //assert
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestSplitString_Char_StringSplitOptions()
        {
            //arrange
            string originalString = "Task Unit   Testing";
            string[] expected = new string[] { "Task", "Unit", "Testing" };

            //act
            string[] actual = originalString.Split(default(char[]), StringSplitOptions.RemoveEmptyEntries);

            //assert
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestSplitString_StringArray_Count_StringSplitOptions()
        {
            //arrange
            string originalString = "Task[Split]Unit[split]Testing";
            string[] separators = new string[] { "[Split]", "[split]" };
            int count = 2;
            string[] expected = new string[] { "Task", "Unit[split]Testing" };

            //act
            string[] actual = originalString.Split(separators, count, StringSplitOptions.RemoveEmptyEntries);

            //assert
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestSplitString_StringArray_StringSplitOptions()
        {
            //arrange
            string originalString = "Task[Split]Unit[split]Testing";
            string[] separators = new string[] { "[Split]", "[split]" };
            string[] expected = new string[] { "Task", "Unit", "Testing" };

            //act
            string[] actual = originalString.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            //assert
            CollectionAssert.AreEqual(actual, expected);
        }
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
