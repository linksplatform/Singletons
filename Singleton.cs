using System;
using System.Runtime.CompilerServices;
using Platform.Interfaces;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Platform.Singletons
{
    public static class Singleton
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Singleton<T> Create<T>(Func<T> creator) => new Singleton<T>(creator);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Singleton<T> Create<T>(IFactory<T> factory) => new Singleton<T>(factory.Create);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Get<T>(Func<T> creator) => new Singleton<T>(creator).Instance;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Get<T>(IFactory<T> factory) => new Singleton<T>(factory.Create).Instance;
    }
}
