using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Triangle
    {
        private int A;
        private int B;
        private int C;

        public int _A { get; set; }
        public int _B { get; set; }
        public int _C { get; set; }

        public bool TruthfulTriangle { get; private set; }

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;

            if(A + B > C && A + C > B && B + C > A)
            {
                TruthfulTriangle = true;
            }
            else
            {
                TruthfulTriangle = false;
            }
        }

        public void WriteLine()
        {
            Console.WriteLine("\nA = " + A +"\nB = " + B + "\nC = " + C);
        }

        public void CalcPer()
        {
            Console.WriteLine("P = " + A + B + C);
        }
        public void CalcArea()
        {
            var P = (a + b + c) / 2;
            double S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            Console.WriteLine("S = " + S);
        }

    }
}
