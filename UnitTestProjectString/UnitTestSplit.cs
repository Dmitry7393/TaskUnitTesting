using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectString
{
    /// <summary>
    /// Summary description for UnitTestSplit
    /// </summary>
    [TestClass]
    public class UnitTestSplit
    {
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
    }
}
