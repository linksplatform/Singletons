#pragma once
#include <cassert>
#include <cstdint>
#include <string>
#include "../Platform.Singletons/Default[T].h"

namespace Platform::Singletons::Tests
{
    class DefaultTests
    {
    public:
        static void StructInstanceTest()
        {
            // Test that default int instance is 0
            assert(Default<std::int32_t>::Instance == 0);
        }

        static void ClassInstanceTest()
        {
            // Test that default string instance is not null (default constructed string is valid)
            assert(Default<std::string>::Instance.empty()); // Empty string is the default
        }

        static void StructThreadInstanceTest()
        {
            // Test that default int thread instance is 0
            assert(Default<std::int32_t>::GetThreadInstance() == 0);
        }

        static void ClassThreadInstanceTest()
        {
            // Test that default string thread instance is not null
            assert(Default<std::string>::GetThreadInstance().empty());
        }
        
        static void RunAllTests()
        {
            StructInstanceTest();
            ClassInstanceTest();
            StructThreadInstanceTest();
            ClassThreadInstanceTest();
        }
    };
}
