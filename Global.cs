#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Platform.Singletons
{
    public static class Global
    {
        /// <summary>
        /// Представляет поле-помойку, куда можно сбрасывать ненужные значения.
        /// В некоторых случаях это может помочь избежать нежелательной оптимизации
        /// (исключения записи в переменную в конце функции)
        /// и сделать вид, что значение действительно используется.
        /// Такое может быть полезно при реализации тестов на производительность.
        /// </summary>
        public static object Trash;
    }
}