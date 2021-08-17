namespace Platform::Singletons
{
    template <typename ...> class Default;
    template <typename T> class Default<T>
        where T : new()
    {
        private: static T _threadInstance;

        public: inline static T Instance;

        public: static T ThreadInstance
        {
            get => _threadInstance == nullptr ? _threadInstance = T() : _threadInstance;
        }
    }
}
