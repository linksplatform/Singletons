using Xunit;

namespace Platform.Singletons.Tests
{
    /// <summary>
    /// <para>
    /// Represents the global tests.
    /// </para>
    /// <para></para>
    /// </summary>
    public class GlobalTests
    {
        /// <summary>
        /// <para>
        /// Tests that trash is null test.
        /// </para>
        /// <para></para>
        /// </summary>
        [Fact]
        public void TrashIsNullTest()
        {
            Assert.Null(Global.Trash);
        }
    }
}
