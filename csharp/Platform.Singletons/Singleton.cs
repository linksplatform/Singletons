using System;
using System.Runtime.CompilerServices;
using Platform.Interfaces;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Platform.Singletons
{
    /// <summary>
    /// <para>
    /// Represents the singleton.
    /// </para>
    /// <para>Представляет одиночку.</para>
    /// </summary>
    public static class Singleton
    {
        /// <summary>
        /// <para>
        /// Creates the creator.
        /// </para>
        /// <para>Создает создателя.</para>
        /// </summary>
        /// <typeparam name="T">
        /// <para>The type of the singleton.</para>
        /// <para>Тип одиночки.</para>
        /// </typeparam>
        /// <param name="creator">
        /// <para>The creator.</para>
        /// <para>Создатель.</para>
        /// </param>
        /// <returns>
        /// <para>A singleton of T</para>
        /// <para>Одиночка типа T</para>
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Singleton<T> Create<T>(Func<T> creator) => new Singleton<T>(creator);

        /// <summary>
        /// <para>
        /// Creates the factory.
        /// </para>
        /// <para>Создает фабрику.</para>
        /// </summary>
        /// <typeparam name="T">
        /// <para>The type of the singleton.</para>
        /// <para>Тип одиночки.</para>
        /// </typeparam>
        /// <param name="factory">
        /// <para>The factory.</para>
        /// <para>Фабрика.</para>
        /// </param>
        /// <returns>
        /// <para>A singleton of T</para>
        /// <para>Одиночка типа T</para>
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Singleton<T> Create<T>(IFactory<T> factory) => new Singleton<T>(factory.Create);

        /// <summary>
        /// <para>
        /// Gets the creator.
        /// </para>
        /// <para>Получает создателя.</para>
        /// </summary>
        /// <typeparam name="T">
        /// <para>The type of the singleton.</para>
        /// <para>Тип одиночки.</para>
        /// </typeparam>
        /// <param name="creator">
        /// <para>The creator.</para>
        /// <para>Создатель.</para>
        /// </param>
        /// <returns>
        /// <para>The instance of T</para>
        /// <para>Экземпляр типа T</para>
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Get<T>(Func<T> creator) => Create(creator).Instance;

        /// <summary>
        /// <para>
        /// Gets the factory.
        /// </para>
        /// <para>Получает фабрику.</para>
        /// </summary>
        /// <typeparam name="T">
        /// <para>The type of the singleton.</para>
        /// <para>Тип одиночки.</para>
        /// </typeparam>
        /// <param name="factory">
        /// <para>The factory.</para>
        /// <para>Фабрика.</para>
        /// </param>
        /// <returns>
        /// <para>The instance of T</para>
        /// <para>Экземпляр типа T</para>
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Get<T>(IFactory<T> factory) => Create(factory).Instance;
    }
}
