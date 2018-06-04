using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class Measure:IComparable
    {
        public double X { get; set; }
        public double A { get; set; }
        public double Y => A * Math.Sin(A * X) * Math.Cos(2 * X / A);

        public int CompareTo(object obj) => Y.CompareTo(((Measure)obj).Y);

        public Measure(double x, double a)
        {
            X = x;
            A = a;
        }
        //public double Y => A * Math.Sin(A * X) * Math.Pow(Math.Cos(X / A), 2);

    }
}
