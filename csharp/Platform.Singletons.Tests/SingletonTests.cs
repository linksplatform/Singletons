using Xunit;

namespace Platform.Singletons.Tests
{
    public class SingletonTests
    {
        [Fact]
        public void TwoValuesAreTheSameTest()
        {
            var value1 = Singleton.Get(() => 1);
            var value2 = Singleton.Get(() => 1);
            Assert.Equal(value1, value2);
        }

        // Looks like ILBytes do not help here
        //[Fact]
        //public void TwoFunctionsAreTheSameTest()
        //{
        //    //Func<Func<int>> factory = () => () => 1;
        //    var func1 = Singleton.Get<Func<int>>(() => () => 1);
        //    var func2 = Singleton.Get<Func<int>>(() => () => 1);
        //    Assert.Equal(func1, func2);
        //}
    }
}
