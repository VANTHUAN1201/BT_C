using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanh10_05
{
   
    class Program
    {
        static void Main(string[] args)
        {
            int[] a166 = new int[100];
            int i166, max166, min166, n166;
            Console.Write("\nTim phan tu lon nhat, phan tu nho nhat trong mang trong C#:\n");
            Console.Write("-----------------------------------------------------------\n");
            Console.Write("Nhap so phan tu can luu giu trong mang: ");
            n166 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap {0} phan tu vao trong mang:\n", n166);
            for (i166 = 0; i166 < n166; i166++)
            {
                Console.Write("Phan tu {0}: ", i166);
                a166[i166] = Convert.ToInt32(Console.ReadLine());
            }
            max166 = a166[0];
            min166 = a166[0];
            for (i166 = 1; i166 < n166; i166++)
            {
                if (a166[i166] > max166)
                {
                    max166 = a166[i166];
                }
                if (a166[i166] < min166)
                {
                    min166 = a166[i166];
                }
            }
            Console.Write("Phan tu lon nhat trong mang la: {0}\n", max166);
            Console.Write("Phan tu nho nhat trong mang la: {0}\n\n", min166);

            Console.ReadKey();
        }
    }
}
