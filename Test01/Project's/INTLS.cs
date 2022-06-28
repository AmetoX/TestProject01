using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    internal class INTLS
    {
        public int numar;
        public INTLS(int numar)
        {
            this.numar = numar;
        }
        public static INTLS operator +(INTLS a, INTLS b)
        {
            INTLS c = new INTLS(0);
            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();
            while (a.numar != 0)
            {
                stack1.Append(a.numar % 10);
                a.numar /= 10;
            }
            return c;
        }
        public void test()
        {

        }
    }
}
