using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoFixture;

namespace lint_action_test
{
    [TestClass]
    public class UnitTest1 {
        const string testItem = "TestItem";

        [TestMethod]
        public void TestMethod1() {
            var MyTeStVar = 1;

            int _myTeStVar2 = 2;

            Assert.AreNotEqual(MyTeStVar, _myTeStVar2);

            bool item1 = true; var item2 = false;                                               
            Assert.AreNotEqual(item1, item2);
        }
    }
}
