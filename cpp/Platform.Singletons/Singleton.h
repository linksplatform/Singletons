#pragma once
#include <functional>

namespace Platform::Singletons
{
    template<typename T> struct Singleton;
    
    /// <summary>
    /// <para>
    /// Represents the singleton.
    /// </para>
    /// <para></para>
    /// </summary>
    class SingletonFactory
    {
    public:
        /// <summary>
        /// <para>
        /// Creates the creator.
        /// </para>
        /// <para></para>
        /// </summary>
        /// <typeparam name="T">
        /// <para>The .</para>
        /// <para></para>
        /// </typeparam>
        /// <param name="creator">
        /// <para>The creator.</para>
        /// <para></para>
        /// </param>
        /// <returns>
        /// <para>A singleton of t</para>
        /// <para></para>
        /// </returns>
        template<typename T>
        static Singleton<T> Create(std::function<T()> creator)
        {
            return Singleton<T>(creator);
        }

        /// <summary>
        /// <para>
        /// Gets the creator.
        /// </para>
        /// <para></para>
        /// </summary>
        /// <typeparam name="T">
        /// <para>The .</para>
        /// <para></para>
        /// </typeparam>
        /// <param name="creator">
        /// <para>The creator.</para>
        /// <para></para>
        /// </param>
        /// <returns>
        /// <para>The</para>
        /// <para></para>
        /// </returns>
        template<typename T>
        static T Get(std::function<T()> creator)
        {
            return Create(creator).Instance;
        }
    };
}
