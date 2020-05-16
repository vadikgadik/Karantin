using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZForInfa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выдерите что нужно перевести\n1) Радианы\n2) Градусы");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine((num * Math.PI) / 180);
            }
            else if (num == 2)
            {
                Console.WriteLine(num * 180 / Math.PI);
            }
            else
            {
                Console.WriteLine("Еррор Чо? 1 или 2 а не " + num);
            }
        }
    }
}
