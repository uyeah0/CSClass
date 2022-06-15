using System;

namespace CSClass
{
    public class Dog : Animal
    {
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
            Console.WriteLine("");
        }
    }
}