﻿namespace CSClass
{
    internal class Product
    {
        public string name = "noname";
        public int price = 1000;

        public override string ToString()
        {
            return this.name + ": " + this.price;
        }
    }
}