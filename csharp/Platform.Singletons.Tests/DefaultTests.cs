using Xunit;

namespace Platform.Singletons.Tests
{
    /// <summary>
    /// <para>
    /// Represents the default tests.
    /// </para>
    /// <para></para>
    /// </summary>
    public class DefaultTests
    {
        /// <summary>
        /// <para>
        /// Tests that struct instance test.
        /// </para>
        /// <para></para>
        /// </summary>
        [Fact]
        public void StructInstanceTest()
        {
            Assert.Equal(0, Default<int>.Instance);
        }

        /// <summary>
        /// <para>
        /// Tests that class instance test.
        /// </para>
        /// <para></para>
        /// </summary>
        [Fact]
        public void ClassInstanceTest()
        {
            Assert.NotNull(Default<object>.Instance);
        }

        /// <summary>
        /// <para>
        /// Tests that struct thread instance test.
        /// </para>
        /// <para></para>
        /// </summary>
        [Fact]
        public void StructThreadInstanceTest()
        {
            Assert.Equal(0, Default<int>.ThreadInstance);
        }

        /// <summary>
        /// <para>
        /// Tests that class thread instance test.
        /// </para>
        /// <para></para>
        /// </summary>
        [Fact]
        public void ClassThreadInstanceTest()
        {
            Assert.NotNull(Default<object>.ThreadInstance);
        }
    }
}
