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

            Console.WriteLine(Math.Abs(-52323));
            Console.WriteLine(Math.Ceiling(52.323));
            Console.WriteLine(Math.Floor(52.323));
            Console.WriteLine(Math.Round(52.323));
            Console.WriteLine(Math.Round(52.323, 2)); // 소수점 둘 째자리에서 반올림
            Console.WriteLine(Math.Max(52, 323));
            Console.WriteLine(Math.Min(52, 323));
            Console.WriteLine(Math.PI);

            /*
            Product product = new Product();
            product.name = "고구마";
            product.price = 6000;
            */
            Product productA = new Product() { name = "감자", price = 2000 };  
            Product productB = new Product() { price = 6000 , name = "고구마" };  
            Product productC = new Product() { name = "옥수수" };


            // Console.WriteLine(product.name + ": " + product.price);
            Console.WriteLine(productA);
            Console.WriteLine(productB);
            Console.WriteLine(productC);

            List<Student> students = new List<Student>()
            {
                new Student() { name = "유예영", grade = 70 },
                new Student() { name = "양정원", grade = 95 },
                new Student() { name = "박성훈", grade = 98 },
                new Student() { name = "이희승", grade = 73 },
                new Student() { name = "제이크", grade = 53 },
                new Student() { name = "박종성", grade = 83 },
                new Student() { name = "김선우", grade = 52 },
                new Student() { name = "손석구", grade = 89 },
                new Student() { name = "윤재혁", grade = 85 },
                new Student() { name = "박정우", grade = 21 }
            };

            /*
            foreach( var student in students)
            {
                if(student.grade > 60)
                {
                    students.Remove(student);
                }
            }
            */
            /*
            for (int i = 0; i < students.Count; i++)
            {
                if(students[i].grade > 60)
                {
                    students.RemoveAt(i);
                    i--;
                }
            }
            */
            for (int i = students.Count-1; i >= 0; i--)
            {
                if (students[i].grade > 60)
                {
                    students.RemoveAt(i);
                }
            }
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-273));
            Console.WriteLine(MyMath.Abs(-52));
            Console.WriteLine(MyMath.Abs(-52.3)); // float, long은 int가 감당 불가
            Console.WriteLine(MyMath.Abs(52f)); // double 호출
            Console.WriteLine(MyMath.Abs(52L)); // double 호출

            Product productX = new Product("감자", 2000);
            Product productY = new Product("고구마", 3000);

            Console.WriteLine(productX);
            Console.WriteLine(productY);
            Console.WriteLine(Product.counter + "개가 생성되었습니다.");

            SingleTon mySingle = SingleTon.getInstance();

            Console.WriteLine("첫 번째 위치");
            Sample sample = new Sample();
            
            Console.WriteLine("두 번째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("세 번째 위치");

            Product product = new Product("과자", 1500);
            productA = null;

        }
    }
}
