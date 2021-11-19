using Xunit;

namespace Platform.Singletons.Tests
{
    public class DefaultTests
    {
        [Fact]
        public void StructInstanceTest()
        {
            Assert.Equal(0, Default<int>.Instance);
        }

        [Fact]
        public void ClassInstanceTest()
        {
            Assert.NotNull(Default<object>.Instance);
        }

        [Fact]
        public void StructThreadInstanceTest()
        {
            Assert.Equal(0, Default<int>.ThreadInstance);
        }

        [Fact]
        public void ClassThreadInstanceTest()
        {
            Assert.NotNull(Default<object>.ThreadInstance);
        }
    }
}
