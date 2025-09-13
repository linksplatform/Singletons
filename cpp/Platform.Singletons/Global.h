#pragma once

namespace Platform::Singletons
{
    /// <summary>
    /// <para>Contains the global state of the system.</para>
    /// <para>Содержит глобальное состояние системы.</para>
    /// </summary>
    class Global
    {
    private:
        static void* _trash;
        
    public:
        /// <summary>
        /// <para>
        /// Represents a garbage field where you can dump unnecessary values.
        /// In some cases, this may help to avoid unwanted optimization and pretend that the value is really used.
        /// This may be useful when implementing performance tests.
        /// </para>
        /// <para>
        /// Представляет поле-помойку, куда можно сбрасывать ненужные значения.
        /// В некоторых случаях это может помочь избежать нежелательной оптимизации и сделать вид, что значение действительно используется.
        /// Такое может быть полезно при реализации тестов на производительность.
        /// </para>
        /// </summary>
        static void* GetTrash() { return _trash; }
        static void SetTrash(void* value) { _trash = value; }
        
        // Property-like access using macros for C# compatibility
        static void*& Trash() { return _trash; }
    };
}