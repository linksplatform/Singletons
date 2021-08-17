namespace Platform::Singletons
{
    class Singleton
    {
        public: static Singleton<T> Create<T>(std::function<T()> creator) { return Singleton<T>(creator); }

        public: static Singleton<T> Create<T>(IFactory<T> &factory) { return Singleton<T>(factory.Create); }

        public: template <typename T> static T Get(std::function<T()> creator) { return Create(creator)->Instance; }

        public: template <typename T> static T Get(IFactory<T> &factory) { return Create(factory)->Instance; }
    };
}
