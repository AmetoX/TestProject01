using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    internal class Complex
    {
        public float re, im;
        public Complex()
        {

        }
        public void init(float re, float im)
        {
            this.re = re;
            this.im = im;
        }
        public string view()
        {
            if (im > 0)
                return re.ToString("0.00") + " + i" + im.ToString("0.00");
            else
                return re.ToString("0.00") + " - i" + (-1 * im).ToString("0.00");
        }
        public static Complex operator +(Complex a, Complex b)
        {
            Complex t = new Complex();
            t.re = a.re + b.re;
            t.im = a.im + b.im;
            return t;
        }
        public static Complex operator *(Complex a, Complex b)
        {
            Complex t = new Complex();
            t.re = a.re * b.re - a.im + b.im;
            t.im = a.im * b.re + a.re + b.im;
            return t;
        }
        private Complex conj()
        {
            Complex t = new Complex();
            t.re = re;
            t.im = -1 * im;
            return t;
        }
        public static Complex operator /(Complex a, Complex b)
        {
            Complex c = b.conj();
            Complex u = a * c;
            Complex d = b * c;
            Complex t = new Complex();
            t.re = u.re / d.re;
            t.im = u.im / d.re;
            return t;
        }
    }
}
