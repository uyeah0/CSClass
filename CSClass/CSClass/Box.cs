using System;

namespace CSClass
{
    public class Box
    {
        
        public int foo { get; set; } // 기본적인 getter, setter

        private int width;

        public int Width
        {
            // get, set 생략 가능
            get { return width; }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Box의 가로는 양수여야 합니다.");
                }
            }
        }
        // prop 간략하게 propfull 전체적 tab키

        private int height;

        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Box의 세로는 양수여야 합니다.");
                }
            }
        }





        public Box(int w, int h)
        {
            this.Width = w;
            this.Height = h;
        }

        private int area;

        public int Area
        {
            get { return this.width * this.height; }
        }
    }
}