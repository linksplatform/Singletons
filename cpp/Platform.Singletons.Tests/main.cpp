#include <iostream>
#include "GlobalTests.cpp"
#include "DefaultTests.cpp"
#include "SingletonTests.cpp"

int main()
{
    std::cout << "Running Platform.Singletons Tests..." << std::endl;
    
    try 
    {
        std::cout << "Running GlobalTests..." << std::endl;
        Platform::Singletons::Tests::GlobalTests::RunAllTests();
        std::cout << "GlobalTests passed!" << std::endl;
        
        std::cout << "Running DefaultTests..." << std::endl;
        Platform::Singletons::Tests::DefaultTests::RunAllTests();
        std::cout << "DefaultTests passed!" << std::endl;
        
        std::cout << "Running SingletonTests..." << std::endl;
        Platform::Singletons::Tests::SingletonTests::RunAllTests();
        std::cout << "SingletonTests passed!" << std::endl;
        
        std::cout << "All tests passed!" << std::endl;
        return 0;
    }
    catch (...)
    {
        std::cout << "Tests failed!" << std::endl;
        return 1;
    }
}