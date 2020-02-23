using Xunit;

namespace Platform.Singletons.Tests
{
    public class GlobalTests
    {
        [Fact]
        public void TrashIsNullTest()
        {
            Assert.Null(Global.Trash);
        }
    }
}
