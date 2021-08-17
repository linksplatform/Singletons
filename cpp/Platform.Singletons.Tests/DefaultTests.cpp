namespace Platform::Singletons::Tests
{
    TEST_CLASS(DefaultTests)
    {
        public: TEST_METHOD(StructInstanceTest)
        {
            Assert::AreEqual(0, Default<std::int32_t>.Instance);
        }

        public: TEST_METHOD(ClassInstanceTest)
        {
            Assert.NotNull(Default<void*>.Instance);
        }

        public: TEST_METHOD(StructThreadInstanceTest)
        {
            Assert::AreEqual(0, Default<std::int32_t>.ThreadInstance);
        }

        public: TEST_METHOD(ClassThreadInstanceTest)
        {
            Assert.NotNull(Default<void*>.ThreadInstance);
        }
    };
}
