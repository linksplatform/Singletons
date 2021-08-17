namespace Platform::Singletons
{
    template <typename ...> struct Singleton;
    template <typename T> struct Singleton<T>
    {
        private: static readonly ConcurrentDictionary<Func<T>, std::uint8_t[]> _functions = ConcurrentDictionary<Func<T>, std::uint8_t[]>();
        private: static readonly ConcurrentDictionary<std::uint8_t[], T> _singletons = ConcurrentDictionary<std::uint8_t[], T>(Default<IListEqualityComparer<std::uint8_t>>.Instance);

        public: const T Instance;

        public: Singleton(std::function<T()> creator) { Instance = _singletons.GetOrAdd(_functions.GetOrAdd(creator, creator.GetMethodInfo().GetILBytes()), key => creator()); }
    };
}
