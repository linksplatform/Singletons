#pragma once
#include <cassert>
#include "../Platform.Singletons/Global.h"

namespace Platform::Singletons::Tests
{
    class GlobalTests
    {
    public:
        static void TrashIsNullTest()
        {
            // Test that trash is initially null
            assert(Global::GetTrash() == nullptr);
            
            // Test setting and getting trash
            void* testValue = reinterpret_cast<void*>(0x12345678);
            Global::SetTrash(testValue);
            assert(Global::GetTrash() == testValue);
            
            // Test reference access
            Global::Trash() = nullptr;
            assert(Global::GetTrash() == nullptr);
        }
        
        static void RunAllTests()
        {
            TrashIsNullTest();
        }
    };
}
