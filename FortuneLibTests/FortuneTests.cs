using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FortuneLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace FortuneLib.Tests
{
    [TestClass()]
    public class FortuneTests
    {
        [TestMethod()]
        public void ParseFortuneTest_InvalidFortuneType()
        {
            FortuneItem expected = null;
            var result = Fortune.ParseFortune("sfdfsdf", "some text", false);
            Assert.AreSame(expected, result);
        }
    }
}
