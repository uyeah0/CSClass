using System;

namespace CSClass
{
    public class Dog : Animal
    {
        int Age;
        string color;

        public Dog()
        {
            Age = 0;
        }

        public void Sleep()
        {
            Console.WriteLine("쿨쿨");
        }
        public void Eat()
        {
            Console.WriteLine("멍멍");
        }
    }
}