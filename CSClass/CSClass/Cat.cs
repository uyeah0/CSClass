using System;

namespace CSClass
{
    public class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("고양이가 챱챱 먹어요");
        }

        public void Meow()
        {
            Console.WriteLine("냥냥");
        }
    }
}