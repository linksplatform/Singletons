using System;
using System.Runtime.CompilerServices;

#pragma warning disable RECS0017 // Possible compare of value type with 'null'

namespace Platform.Singletons
{
    /// <summary>
    /// <para>Represents an access point to instances of default types (created using the constructor with no arguments).</para>
    /// <para>Представляет собой точку доступа к экземплярям типов по умолчанию (созданных с помощью конструктора без аргументов).</para>
    /// </summary>
    /// <typeparam name="T"><para>The type of instance of the object.</para><para>Тип экземпляра объекта.</para></typeparam>
    public static class Default<T>
        where T : new()
    {
        /// <summary>
        /// <para>
        /// The thread instance.
        /// </para>
        /// <para></para>
        /// </summary>
        [ThreadStatic]
        private static T _threadInstance;

        /// <summary>
        /// <para>Returns an instance of an object by default.</para>
        /// <para>Возвращает экземпляр объекта по умолчанию.</para>
        /// </summary>
        public static readonly T Instance = new T();

        /// <summary>
        /// <para>If you really need maximum performance, use this property. This property should create only one instance per thread.</para>
        /// <para>Если вам действительно нужна максимальная производительность, используйте это свойство. Это свойство должно создавать только один экземпляр на поток.</para>
        /// </summary>
        /// <remarks>
        /// <para>Check for null is intended to create only classes, not structs.</para>
        /// <para>Проверка на значение null выполняется специально для создания только классов, а не структур.</para>
        /// </remarks>
        public static T ThreadInstance
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _threadInstance == null ? _threadInstance = new T() : _threadInstance; //-V3111
        }
    }
}
