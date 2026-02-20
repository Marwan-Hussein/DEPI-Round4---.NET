using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9.Classes
{
    internal class ComplexNumber
    {
        public int Real { get; set; }
        public int Imag { get; set; }
        public ComplexNumber(int real, int imag = 0) { Real = real; Imag = imag; }
        public ComplexNumber() { }
        public override string ToString()
        {
            switch (Imag) 
            {
                case > 0:
                    return $"{Real} + {Imag}i";
                case < 0:
                    return $"{Real} - {-1*Imag}i";
                default:
                    return Real.ToString();
            }
        }

        public static ComplexNumber operator +(ComplexNumber Left, ComplexNumber Right)
        {
            return new ComplexNumber()
            {
                Real = (Left?.Real ?? 0) + (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) + (Right?.Imag ?? 0),
            };
        }

        public static ComplexNumber operator -(ComplexNumber Left, ComplexNumber Right)
        {
            return new ComplexNumber
            {
                Real = Left.Real - Right.Real,
                Imag = Left.Imag - Right.Imag,
            };
        }

        public static ComplexNumber operator *(ComplexNumber Left, ComplexNumber Right)
        {
            // (a + c*i) * (b + d*i) = a*b + a*d*i + b*c*i - c*d
            int a = Left?.Real ?? 0,
                c = Left?.Imag ?? 0,
                b = Right?.Real ?? 0,
                d = Right?.Imag ?? 0;
            return new ComplexNumber()
            {
                Real = a * b - c * d,
                Imag = a * d + b * c
            };
        }
    }
}
