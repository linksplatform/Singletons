using System;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Platform.Singletons
{
    /// <summary>
    /// Представляет собой точку доступа к экземплярям типов по умолчанию (созданных с помощью конструктора без аргументов).
    /// </summary>
    /// <typeparam name="T">Тип экземпляра объекта.</typeparam>
    public static class Default<T>
        where T : new()
    {
        [ThreadStatic]
        private static T _threadInstance;

        public static readonly T Instance = new T();

        /// <summary>
        /// If you really need maximum performance, use this property.
        /// This property should create only one instance per thread.
        /// </summary>
        public static T ThreadInstance => _threadInstance == null ? _threadInstance = new T() : _threadInstance; //-V3111
    }
}
