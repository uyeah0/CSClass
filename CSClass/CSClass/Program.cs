using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SetInTime();
            car.SetOutTime();

            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            
            
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble() * 10);

            /*
            List<int> list = new List<int>();
            list.Add(59);
            list.Add(3);
            list.Add(100);
            list.Add(11);
            */

            List<int> list = new List<int>() { 59, 3, 100, 11 };
            list.Remove(42); // 숫자로 찾기
            list.RemoveAt(0); // 인덱스로 찾기
            foreach (var item in list)
            {
                Console.WriteLine("Count : " + list.Count + "\t" + item);
            }
        }
    }
}
