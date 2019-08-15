using System;
using Platform.Interfaces;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Platform.Singletons
{
    public static class Singleton
    {
        public static Singleton<T> Create<T>(Func<T> creator) => new Singleton<T>(creator);
        public static Singleton<T> Create<T>(IFactory<T> factory) => new Singleton<T>(factory.Create);
        public static T Get<T>(Func<T> creator) => new Singleton<T>(creator).Instance;
        public static T Get<T>(IFactory<T> factory) => new Singleton<T>(factory.Create).Instance;
    }
}
