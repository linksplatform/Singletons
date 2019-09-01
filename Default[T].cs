using System;

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
        public static T ThreadInstance => _threadInstance == null ? _threadInstance = new T() : _threadInstance; //-V3111
    }
}
