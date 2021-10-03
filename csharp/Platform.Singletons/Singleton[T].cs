using System;
using System.Collections.Concurrent;
using System.Reflection;
using System.Runtime.CompilerServices;
using Platform.Collections.Lists;
using Platform.Reflection;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable RECS0108 // Warns about static fields in generic types

namespace Platform.Singletons
{
    /// <summary>
    /// <para>
    /// The singleton.
    /// </para>
    /// <para></para>
    /// </summary>
    public struct Singleton<T>
    {
        private static readonly ConcurrentDictionary<Func<T>, byte[]> _functions = new ConcurrentDictionary<Func<T>, byte[]>();
        private static readonly ConcurrentDictionary<byte[], T> _singletons = new ConcurrentDictionary<byte[], T>(Default<IListEqualityComparer<byte>>.Instance);

        /// <summary>
        /// <para>
        /// Gets the instance value.
        /// </para>
        /// <para></para>
        /// </summary>
        public T Instance
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get;
        }

        /// <summary>
        /// <para>
        /// Initializes a new <see cref="Singleton"/> instance.
        /// </para>
        /// <para></para>
        /// </summary>
        /// <param name="creator">
        /// <para>A creator.</para>
        /// <para></para>
        /// </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Singleton(Func<T> creator) => Instance = _singletons.GetOrAdd(_functions.GetOrAdd(creator, creator.GetMethodInfo().GetILBytes()), key => creator());
    }
}
