namespace Platform::Singletons::Tests
{
    TEST_CLASS(GlobalTests)
    {
        public: TEST_METHOD(TrashIsNullTest)
        {
            Assert.Null(Global.Trash);
        }
    };
}
