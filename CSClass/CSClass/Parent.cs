using System;

namespace CSClass
{
    internal class Parent
    {
        public Parent()
        {

        }
        public Parent(int param)
        {
            Console.WriteLine("Parent(int param)");
        }

        public Parent(string input)
        {
            Console.WriteLine("Parent(string input)");
        }

    }
}