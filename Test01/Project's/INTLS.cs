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
        public Stack<int> stack = new Stack<int>();
        public Stack<int> stack2 = new Stack<int>();
        public Stack<int> stack3 = new Stack<int>();
        public INTLS() { }
        public INTLS(int numar)
        {
            this.numar = numar;
            while (numar != 0)
            {
                stack.Push(numar % 10);
                numar/=10;
            }
            stack3 = stack;
            while (stack.Count >= 1)
            {
                stack2.Push(stack.Pop());
            }
        }
        public void Stview()
        {            
            foreach(var item in stack2)
            {
                Console.Write(item + ",");
            }            
        }
        public static INTLS operator +(INTLS a, INTLS b)
        {
            int nr = 0;
            int im = 0;
            INTLS c = new INTLS();
            if (a.stack2.Count > b.stack2.Count)
            {                
                while (b.stack2.Count >= 1)
                {
                    int n1 = b.stack2.Pop();
                    int n2 = a.stack2.Pop();
                    nr = n1 + n2 + im;
                    im = 0;
                    if (nr > 9)
                    {
                        nr %= 10;
                        im++;
                        c.stack3.Push(nr);
                    }
                    else
                    {
                        c.stack3.Push(nr);
                    }
                }
                while (a.stack2.Count >= 1)
                {
                    nr = a.stack2.Pop();
                    nr += im;
                    im = 0;
                    if (nr > 9)
                    {
                        nr %= 10;
                        im++;
                        c.stack3.Push(nr);
                    }
                    c.stack3.Push(nr);
                }
            }
            else
            {
                while (a.stack2.Count >= 1)
                {
                    int n1 = a.stack2.Pop();
                    int n2 = b.stack2.Pop();
                    nr = n1 + n2 + im;
                    im = 0;
                    if (nr > 9)
                    {
                        nr %= 10;
                        im++;
                        c.stack3.Push(nr);
                    }
                    else
                    {
                        c.stack3.Push(nr);
                    }
                }
                while (a.stack2.Count >= 1)
                {
                    nr = a.stack2.Pop();
                    nr += im;
                    im = 0;
                    if (nr > 9)
                    {
                        nr %= 10;
                        im++;
                        c.stack3.Push(nr);
                    }
                    c.stack3.Push(nr);
                }
            }
            c.stack2 = c.stack3;
            return c;
        }
        public static INTLS operator *(INTLS a, INTLS b)
        {
            int nr = 0;
            int im = 0;
            INTLS c = new INTLS();

            return c;
        }
        public void view()
        {
            int count = 0;
            while (numar >= 1000)
            {
                numar /= 1000;
                count++;
            }
            char a = 'A';
            while (count != 0)
            {
                a++;
                count--;
            }
            Console.WriteLine(numar + $"{a}");
        }
    }
}
