using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Conways;

namespace ConwaysTest
{
    [TestClass]
    public class TextWriterGameOutputTest
    {
        [TestMethod]
        public void Test5x5GameOutput()
        {
            var testState = new []
            {
                new [] {false, false, false, false, false},
                new [] {false, true, false, true, false},
                new [] {false, true, false, false, false},
                new [] {false, true, true, true, false},
                new [] {false, false, false, false, false},
            };
            var tw = new StringWriter();
            var output = new TextWriterGameOutput(testState.Length, tw);
            output.Display(testState);
            Assert.AreEqual("\n░░░░░\n░█░█░\n░█░░░\n░███░\n░░░░░", tw.ToString());
        }
    }
}