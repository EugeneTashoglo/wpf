using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf
{
    internal class Complex : Norm
    {
        public double Aba { get; set; }
        public double Ba { get; set; }

        public Complex(double aba, double ba)
        {
            Aba = aba;
            Ba = ba;
        }

        public override double Module()
        {
            return Math.Sqrt( Aba* Aba + Ba * Ba);
        }

        public override double Norma()
        {
            return Math.Abs(Math.Pow(Aba,2));
        }

        public override string Print()
        {
            return $"Модуль комплекса: {Module():F2}," +
                $"Норма комплекса: {Norma():F2}";
        }

    }
}
