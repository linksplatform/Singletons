#pragma once
#include <type_traits>

namespace Platform::Singletons
{
    /// <summary>
    /// <para>Represents an access point to instances of default types (created using the constructor with no arguments).</para>
    /// <para>Представляет собой точку доступа к экземплярам типов по умолчанию (созданных с помощью конструктора без аргументов).</para>
    /// </summary>
    /// <typeparam name="T"><para>The type of instance of the object.</para><para>Тип экземпляра объекта.</para></typeparam>
    template <typename T>
    class Default
    {
        static_assert(std::is_default_constructible_v<T>, "Type T must be default constructible");
        
    private:
        /// <summary>
        /// <para>
        /// The thread instance.
        /// </para>
        /// <para></para>
        /// </summary>
        static thread_local T _threadInstance;

    public:
        /// <summary>
        /// <para>Returns an instance of an object by default.</para>
        /// <para>Возвращает экземпляр объекта по умолчанию.</para>
        /// </summary>
        static const T Instance;

        /// <summary>
        /// <para>If you really need maximum performance, use this property. This property should create only one instance per thread.</para>
        /// <para>Если вам действительно нужна максимальная производительность, используйте это свойство. Это свойство должно создавать только один экземпляр на поток.</para>
        /// </summary>
        /// <remarks>
        /// <para>Check for null is intended to create only classes, not structs.</para>
        /// <para>Проверка на значение null выполняется специально для создания только классов, а не структур.</para>
        /// </remarks>
        static T& GetThreadInstance()
        {
            return _threadInstance;
        }
    };
    
    template<typename T>
    const T Default<T>::Instance = T{};
    
    template<typename T>
    thread_local T Default<T>::_threadInstance = T{};
}
