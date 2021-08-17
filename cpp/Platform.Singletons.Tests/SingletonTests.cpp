namespace Platform::Singletons::Tests
{
    TEST_CLASS(SingletonTests)
    {
        public: TEST_METHOD(TwoValuesAreTheSameTest)
        {
            auto value1 = Singleton.Get([&]()-> auto { return 1; });
            auto value2 = Singleton.Get([&]()-> auto { return 1; });
            Assert::AreEqual(value1, value2);
        }
    };
}
