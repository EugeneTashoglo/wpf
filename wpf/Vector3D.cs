using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf
{
    internal class Vector3D:Norm
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector3D(double x,double y)
        {
            X = x;
            Y = y;
        }
        public override double Module()
        {
            return Math.Sqrt(X*X + Y*Y);
        }
        public override double Norma()
        {
           return  Math.Max(Math.Abs(X),Math.Abs(Y));

        }
        public override string Print()
        {
            return $"Модуль вектора: {Module():F2}," +
                $"Норма вектора: {Norma():F2}";
        }

    }
}
