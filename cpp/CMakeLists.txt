cmake_minimum_required(VERSION 3.10)
project(Platform.Singletons)

# Set C++ standard
set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

# Add include directories
include_directories(Platform.Singletons)

# Add library
add_library(Platform.Singletons
    Platform.Singletons/Global.cpp
)

# Set target properties for the library
set_target_properties(Platform.Singletons PROPERTIES
    CXX_STANDARD 17
    CXX_STANDARD_REQUIRED ON
)

# Add test executable
add_executable(Platform.Singletons.Tests
    Platform.Singletons.Tests/main.cpp
)

# Link test executable with library
target_link_libraries(Platform.Singletons.Tests Platform.Singletons)

# Set target properties for tests
set_target_properties(Platform.Singletons.Tests PROPERTIES
    CXX_STANDARD 17
    CXX_STANDARD_REQUIRED ON
)

# Enable testing
enable_testing()
add_test(NAME AllTests COMMAND Platform.Singletons.Tests)