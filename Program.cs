public class Program
{
     /*
     * Console.WriteLine("Hello, World!");
     * Console.Write("using console.write");
     * Console.WriteLine(); // handle new line
     */

    // Data Types in C#
    /*
    * three kinds of data types:
    * 1. Value type: stores data directly in memory. Examples: int, float, bool, char, struct, enum
    * 2. Reference type: stores a reference to the data in memory. Examples: string, class, array, delegate, interface, dynamic, object
    * 3. Pointer type (unsafe code)
    */

    // --- Value type ---
    // Pre defined/Built in
        // * Integers
        byte a = 10; // Storage: 1 byte || Range: 0 to 255
        sbyte b = -10; // Storage: 1 byte || Range: -128 to 127
        short c = 30000; // Storage: 2 bytes || Range: -32,768 to 32,767
        int d = 3215464; // Storage: 4 bytes || Range: -2,147,483,648 to 2,147,483,647
        long e = 1234567890123456L; // Storage: 8 bytes || Range: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 || Suffix 'L'
                                    // * Floating-point 
        float f = 3.14f; // Storage: 4 bytes || Range: ±1.5 x 10^−45 to ±3.4 x 10^38 || Precision: 6-9 digits, suffix 'f'
        double g = 3.141592653589793; // Storage: 8 bytes || Range: ±5.0 × 10^−324 to ±1.7 × 10^308 || Precision: 15-17 digits
        decimal h = 3.14159265358979323846m; // Storage: 16 bytes || Range: ±1.0 x 10^-28 to ±7.9 x 10^28 || Precision: 28-29 digits, suffix 'm'
                                             // * Others
        char i = 'A'; // Storage: 2 bytes || Range: U+0000 to U+FFFF || Represents a single Unicode character, enclosed in single quotes
        bool j = true; // Storage: 1 byte || Values: true or false
    // User defined
        // * Structure || A struct is stored directly in memory where it’s declared. It acts as a value container.
        struct Point
        {
            public int X;
            public int Y;
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
        // *  Enum || An enum is stored as an integral type (default is int) and represents a set of named constants.
        enum DayOfWeek
        {
            Sunday, // 0
            Monday, // 1
            Tuesday, // 2
            Wednesday, // 3
            Thursday, // 4
            Friday, // 5
            Saturday // 6
        }

    // --- Reference type ---
    // Pre defined/Built in
        string str = "Hello, World!"; // Storage: Reference to a string object in memory || Represents a sequence of characters, enclosed in double quotes
        object obj = new object(); // Storage: Reference to an object in memory || Base type for all types in C#
        dynamic dyn = 123; // Storage: Reference to an object in memory || Type is determined at runtime || Bypasses compile-time type checking
        int[] arr = new int[] { 1, 2, 3, 4, 5 }; // Storage: Reference to an array object in memory || Represents a collection of elements of the same type

    // --- Pointer type (unsafe code) ---
    /*
    * Pointer types are used in unsafe code blocks and allow direct memory manipulation. They are not commonly used in C# and require the 'unsafe' keyword.
    * Only value types can have pointers. Like: simple numeric values, bool, char, and structs (but only if all their fields are also unmanaged).
    * Simple numeric types: int, float, double, byte, short, long, decimal, char
    * For compile unsafe code, you need to enable the 'Allow unsafe code' option in your project settings.
    * For .NET CLI: dotnet build -p:AllowUnsafeBlocks=true
    * In Visual Studio: Project Properties → Build → Allow unsafe code.
    * Example:
    * unsafe
    * {
    *     int d = 3215464; // Declare an integer variable
    *     int* p = &d; // Get the address of variable d
    *     Console.WriteLine(*p); // Dereference the pointer to get the value of d
    * }
    */
}

// --- Reference type ---
    // User defined
    // * Class || A class is stored as a reference in memory. It contains data and behavior (methods) and is instantiated as an object.
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    // * Interface || It is a reference type that defines a contract for classes to implement. It cannot be instantiated and does not contain implementation. || Abstract type
    interface IAnimal
    {
        void MakeSound();
    }
    // * Record || It is a reference type that provides built-in functionality for immutability and value-based equality. It is often used for data transfer objects (DTOs) or simple data structures.
    record PersonRecord(string Name, int Age);
    // Storage: Reference to a record object in memory || Records can’t be changed by default; use 'init' to set once during creation or 'set' to change anytime.                                               
    // Automatically generates useful methods like ToString(), Equals(), and GetHashCode() based on the properties defined in the record
    record Cars
    {
        public required string Model { get; init; } // immutable property
        public required string Owner { get; set; } // mutable property
        public int Price { get; set; } // mutable property
    }
    // * Delegate || It is a reference type that represents a method signature and can hold references to methods with matching signatures(params + return type).
    // It is used for event handling and callback mechanisms. You can invoke the delegate to call the method(s) it references.
    delegate void GreetDelegate(string message);
    class Example
    {
        static void Greet(string message)
        {
            Console.WriteLine(message);
        }
        static void Main()
        {
            GreetDelegate greet = Greet;
            greet("Hello, World!"); // Output: Hello, World!
        }
    }