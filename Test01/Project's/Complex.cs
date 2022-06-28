using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    internal class Complex
    {
        public float re, im, jm;
        public Complex()
        {

        }
        public void init(float re, float im, float jm)
        {
            this.re = re;
            this.im = im;
            this.jm = jm;
        }
        public string view()
        {
            if (im > 0)
                return re.ToString("0.00") + " + i" + im.ToString("0.00") + " + j" + jm.ToString("0.00");
            else
                return re.ToString("0.00") + " - i" + (-1 * im).ToString("0.00") + " - j" + jm.ToString("0.00");
        }
        public static Complex operator +(Complex a, Complex b)
        {
            Complex t = new Complex();
            t.re = a.re + b.re;
            t.im = a.im + b.im;
            t.jm = a.jm + b.jm;
            return t;
        }
        public static Complex operator *(Complex a, Complex b)
        {
            Complex t = new Complex();
            t.re+= a.re * b.re;
            t.im+= a.re * b.im;
            t.jm += a.re * b.jm;
            t.im += a.im * b.re;
            t.re -= a.im * b.im;
            t.jm += a.jm * b.re;
            t.re -= a.jm * b.jm;
            return t;
        }
        private Complex conj()
        {
            Complex t = new Complex();
            t.re = re;
            t.im = -1 * im;
            t.jm = -1 * jm;
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
            t.jm = u.jm / d.re;
            return t;
        }
    }
}
