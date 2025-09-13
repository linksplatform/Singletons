using System;
using System.Collections.Concurrent;
using System.Reflection;
using System.Runtime.CompilerServices;
using Platform.Collections.Lists;
using Platform.Reflection;

#pragma warning disable RECS0108 // Warns about static fields in generic types

namespace Platform.Singletons
{
    /// <summary>
    /// <para>Represents a singleton wrapper that ensures only one instance of type T is created per unique creator function.</para>
    /// <para>Представляет обёртку одиночного экземпляра, которая гарантирует создание только одного экземпляра типа T для каждой уникальной функции-создателя.</para>
    /// </summary>
    /// <typeparam name="T"><para>The type of the singleton instance.</para><para>Тип одиночного экземпляра.</para></typeparam>
    public struct Singleton<T>
    {
        private static readonly ConcurrentDictionary<Func<T>, byte[]> _functions = new ConcurrentDictionary<Func<T>, byte[]>();
        private static readonly ConcurrentDictionary<byte[], T> _singletons = new ConcurrentDictionary<byte[], T>(Default<IListEqualityComparer<byte>>.Instance);

        /// <summary>
        /// <para>Gets the singleton instance.</para>
        /// <para>Получает одиночный экземпляр.</para>
        /// </summary>
        public T Instance
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get;
        }

        /// <summary>
        /// <para>Initializes a new <see cref="Singleton{T}"/> instance using the provided creator function.</para>
        /// <para>Инициализирует новый экземпляр <see cref="Singleton{T}"/>, используя предоставленную функцию-создатель.</para>
        /// </summary>
        /// <param name="creator"><para>The function that creates the instance. The same function will always return the same singleton instance.</para><para>Функция, которая создаёт экземпляр. Одна и та же функция всегда будет возвращать один и тот же одиночный экземпляр.</para></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Singleton(Func<T> creator) => Instance = _singletons.GetOrAdd(_functions.GetOrAdd(creator, creator.GetMethodInfo().GetILBytes()), key => creator());
    }
}
