﻿using System;
using System.Collections.Concurrent;
using System.Reflection;
using System.Runtime.CompilerServices;
using Platform.Collections.Lists;
using Platform.Reflection;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable RECS0108 // Warns about static fields in generic types

namespace Platform.Singletons
{
    public struct Singleton<T>
    {
        private static readonly ConcurrentDictionary<Func<T>, byte[]> _functions = new ConcurrentDictionary<Func<T>, byte[]>();
        private static readonly ConcurrentDictionary<byte[], T> _singletons = new ConcurrentDictionary<byte[], T>(Default<IListEqualityComparer<byte>>.Instance);

        public T Instance
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Singleton(Func<T> creator) => Instance = _singletons.GetOrAdd(_functions.GetOrAdd(creator, creator.GetMethodInfo().GetILBytes()), key => creator());
    }
}
