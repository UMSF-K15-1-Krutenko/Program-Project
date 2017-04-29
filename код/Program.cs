using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumber
{
    class Complex
    {
        double re, im;
        //конструктор с параметрами по умолчанию
        public Complex(double re = 0.0, double im = 0.0)
        {
            this.re = re;
            this.im = im;
        }
        public void ShowResult()
        {
            if (im < 0)
                Console.WriteLine("{0}{1}*i", re, im);
            else
                Console.WriteLine("{0} + {1}*i", re, im);
        }
        
        public static Complex Sum(Complex val1, Complex val2)
        {
            Complex result = new Complex();
            result = val1 + val2;
            return result;
        }
        //перегрузка оператора +
        public static Complex operator +(Complex val1, Complex val2)
        {
            return new Complex(val1.re + val2.re, val1.im + val2.im);
        }
        
        public static Complex Substract(Complex val1, Complex val2)
        {
            Complex result = new Complex();
            result = val1 - val2;
            return result;
        }
        //перегрузка оператора -
        public static Complex operator -(Complex val1, Complex val2)
        {
            return new Complex(val1.re - val2.re, val1.im - val2.im);
        }
        
        public static Complex Multiplication(Complex val1, Complex val2)
        {
            Complex result = new Complex();
            result = val1 * val2;
            return result;
        }
        //перегрузка оператора *
        public static Complex operator *(Complex val1, Complex val2)
        {
            return new Complex(val1.re * val2.re - val1.im * val2.im, val1.im * val2.re + val1.re * val2.im);
        }
        
        public static Complex Division(Complex val1, Complex val2)
        {
            Complex result = new Complex();
            result = val1 / val2;
            return result;
        }
        //перегрузка оператора /
        public static Complex operator /(Complex val1, Complex val2)
        {
            return new Complex(Math.Round(((val1.re * val2.re) + (val1.im * val2.im)) / (Math.Pow(val2.re, 2) + Math.Pow(val2.im, 2)), 2), Math.Round(((val2.re * val1.im) - (val1.re * val2.im)) / (Math.Pow(val2.re, 2) + Math.Pow(val2.im, 2)), 2));
        }
        // перегрузка оператора ==
        public static bool operator ==(Complex val1, Complex val2)
        {
            if (val1.re == val2.re && val1.im == val2.im)
                return true;
            else return false;
        }
        //перегрузка оператора !=
        public static bool operator !=(Complex val1, Complex val2)
        {
            if (val1.re != val2.re || val1.im != val2.im)
                return true;
            else return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex val1 = new Complex(11, 5);
            Complex val2 = new Complex(8, 7);
            Console.WriteLine("Сумма:");
            Complex a = Complex.Sum(val1, val2);
            Complex b = val1 + val2;
            a.ShowResult();
            b.ShowResult();
            Console.WriteLine("Разница:");
            Complex c = Complex.Substract(val1, val2);
            Complex d = val1 - val2;
            c.ShowResult();
            d.ShowResult();
            Console.WriteLine("Умножение:");
            Complex x = Complex.Multiplication(val1, val2);
            Complex y = val1 * val2;
            x.ShowResult();
            y.ShowResult();
            Console.WriteLine("Деление:");
            Complex f = Complex.Division(val1, val2);
            Complex g = val1 / val2;
            f.ShowResult();
            g.ShowResult();
            Console.Write("Результат сравнения чисел:");
            if (val1 == val2)
                Console.WriteLine(" числа равны.");
            else
                Console.WriteLine(" числа не равны.");
            Console.ReadKey();
        }
    }
}
