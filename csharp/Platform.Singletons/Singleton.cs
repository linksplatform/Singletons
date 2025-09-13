using System;
using System.Runtime.CompilerServices;
using Platform.Interfaces;


namespace Platform.Singletons
{
    /// <summary>
    /// <para>Provides factory methods for creating singleton instances of any type.</para>
    /// <para>Предоставляет фабричные методы для создания одиночных экземпляров любого типа.</para>
    /// </summary>
    public static class Singleton
    {
        /// <summary>
        /// <para>Creates a singleton instance using the provided creator function.</para>
        /// <para>Создаёт одиночный экземпляр, используя предоставленную функцию-создатель.</para>
        /// </summary>
        /// <typeparam name="T"><para>The type of the singleton instance.</para><para>Тип одиночного экземпляра.</para></typeparam>
        /// <param name="creator"><para>The function that creates the instance.</para><para>Функция, которая создаёт экземпляр.</para></param>
        /// <returns><para>A singleton wrapper containing the created instance.</para><para>Обёртка одиночного экземпляра, содержащая созданный экземпляр.</para></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Singleton<T> Create<T>(Func<T> creator) => new Singleton<T>(creator);

        /// <summary>
        /// <para>Creates a singleton instance using the provided factory.</para>
        /// <para>Создаёт одиночный экземпляр, используя предоставленную фабрику.</para>
        /// </summary>
        /// <typeparam name="T"><para>The type of the singleton instance.</para><para>Тип одиночного экземпляра.</para></typeparam>
        /// <param name="factory"><para>The factory that creates the instance.</para><para>Фабрика, которая создаёт экземпляр.</para></param>
        /// <returns><para>A singleton wrapper containing the created instance.</para><para>Обёртка одиночного экземпляра, содержащая созданный экземпляр.</para></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Singleton<T> Create<T>(IFactory<T> factory) => new Singleton<T>(factory.Create);

        /// <summary>
        /// <para>Gets a singleton instance using the provided creator function.</para>
        /// <para>Получает одиночный экземпляр, используя предоставленную функцию-создатель.</para>
        /// </summary>
        /// <typeparam name="T"><para>The type of the singleton instance.</para><para>Тип одиночного экземпляра.</para></typeparam>
        /// <param name="creator"><para>The function that creates the instance.</para><para>Функция, которая создаёт экземпляр.</para></param>
        /// <returns><para>The singleton instance.</para><para>Одиночный экземпляр.</para></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Get<T>(Func<T> creator) => Create(creator).Instance;

        /// <summary>
        /// <para>Gets a singleton instance using the provided factory.</para>
        /// <para>Получает одиночный экземпляр, используя предоставленную фабрику.</para>
        /// </summary>
        /// <typeparam name="T"><para>The type of the singleton instance.</para><para>Тип одиночного экземпляра.</para></typeparam>
        /// <param name="factory"><para>The factory that creates the instance.</para><para>Фабрика, которая создаёт экземпляр.</para></param>
        /// <returns><para>The singleton instance.</para><para>Одиночный экземпляр.</para></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Get<T>(IFactory<T> factory) => Create(factory).Instance;
    }
}
