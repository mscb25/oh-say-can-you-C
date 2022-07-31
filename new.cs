using System;


namespace Samples {
    class CompileAndRun {
        static void Main() {
        //Console.WriteLine("Hello World");
            Console.WriteLine("Compile with csc filename.cs");
            Console.WriteLine("Run the exe via .\\filename");

            Console.WriteLine("Now, please enter your name: ");
        //readline for taking input from user
            string user_name = Console.ReadLine();
        //formatting output like C
            Console.WriteLine("Welcome, {0}", user_name);
        }
    }
}