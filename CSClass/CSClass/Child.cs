﻿using System;

namespace CSClass
{
    internal class Child: Parent
    {
        public Child():base(10)
        {
            Console.WriteLine("Child() : base(10)");
        }

        public Child(string input) : base (input)
        {
            Console.WriteLine("Child(string input) : base(input)");
        }
    }
}