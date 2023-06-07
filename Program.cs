using System;

namespace HelloWorld {
    class Program {
        static void Main(string[] args){
            // concatenating variables
            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            string greeting = "Hello";
            Console.WriteLine(greeting + fullName);

            // declaring multiple variables & assigning the same value to multiple variables
            int x = 5, y = 7, z = 9;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            
            int a, b, c;
            a = b = c= 34;
            Console.WriteLine(a + b + c);
        }
    }
}