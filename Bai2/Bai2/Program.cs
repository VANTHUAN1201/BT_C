using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        public class Animal_166
        {

            //public double Weight;
            //public double Height;

            public void Eat_166()
            {
                Console.WriteLine("đang ăn. . .");
            }
            public void MakeSound()
            {
                Console.WriteLine("đang phát ra tiếng kêu. . .");
            }
        }
        class Cat_166 : Animal_166
        {
            public void Run_166()
            {
                Console.WriteLine("Mèo đang chạy. . .");
            }
            Animal_166 animal = new Animal_166();

        }
        class Bird : Animal_166
        {
            public void Fly_166()
            {
                Console.WriteLine("Chim đang bay. . .");
            }

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Cat_166 cat = new Cat_166();
            cat.Run_166();
            cat.Run_166();
            Bird bird = new Bird();
            bird.Fly_166();
            bird.MakeSound();
            Console.ReadKey();
        }
    }
}
