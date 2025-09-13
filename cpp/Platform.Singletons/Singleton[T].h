#pragma once
#include <functional>
#include <unordered_map>
#include <mutex>
#include "Default[T].h"

namespace Platform::Singletons
{
    /// <summary>
    /// <para>
    /// The singleton.
    /// </para>
    /// <para></para>
    /// </summary>
    template <typename T>
    struct Singleton
    {
    private:
        // Using function address as key for singleton storage
        static std::unordered_map<void*, T> _singletons;
        static std::mutex _mutex;
        
    public:
        /// <summary>
        /// <para>
        /// Gets the instance value.
        /// </para>
        /// <para></para>
        /// </summary>
        const T Instance;

        /// <summary>
        /// <para>
        /// Initializes a new <see cref="Singleton"/> instance.
        /// </para>
        /// <para></para>
        /// </summary>
        /// <param name="creator">
        /// <para>A creator.</para>
        /// <para></para>
        /// </param>
        Singleton(std::function<T()> creator) : Instance(GetOrCreateInstance(creator))
        {
        }
        
    private:
        static T GetOrCreateInstance(std::function<T()> creator)
        {
            // Use the address of the function object as unique identifier
            // Note: This approach has limitations - different lambdas with same content
            // will have different addresses, unlike C# IL byte comparison
            void* funcAddr = reinterpret_cast<void*>(&creator);
            
            std::lock_guard<std::mutex> lock(_mutex);
            auto it = _singletons.find(funcAddr);
            if (it != _singletons.end()) 
            {
                return it->second;
            }
            else 
            {
                T instance = creator();
                _singletons[funcAddr] = instance;
                return instance;
            }
        }
    };
    
    template<typename T>
    std::unordered_map<void*, T> Singleton<T>::_singletons;
    
    template<typename T>
    std::mutex Singleton<T>::_mutex;
}
