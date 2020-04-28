using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyClass.Test
{

    // this is the test class
    [TestClass]
    public class FileProcessTest
    {
        // check if the file Name  exists
        // not the file
        [TestMethod]
        public void FileNameDoesExists()
        {
            // first dont make any assert just pass
            Assert.Inconclusive();
        }


        // this will test if the file exists
        [TestMethod]
        public void FileNameNullOrEmpty_throwsArgumentNullException()
        {
            // TODO:
            Assert.Inconclusive();
        }
    }
}
