using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Haru.Shared.Tests.Units
{
    [TestClass]
    public class ExtensionsTest
    {
        private readonly string _text;

        public ExtensionsTest()
        {
            _text = "The quick brown lazy fox jumps over the lazy dog";
        }

        [TestMethod]
        public void TestReplaceFirstFound()
        {
            var segment = "lazy";
            var text = _text.ReplaceFirst(segment, string.Empty);
            var result = text.Split(segment);
            Assert.IsTrue(result.Length > 0);
        }

        public void TestReplaceFirstNone()
        {
            var segment = "cookie";
            var text = _text.ReplaceFirst(segment, string.Empty);
            var result = text.Split(segment);
            Assert.IsTrue(result.Length == 0);
        }
    }
}