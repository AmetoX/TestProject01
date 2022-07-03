using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    internal class INTLS
    {
        public int numar, numar2;
        public Stack<int> stack = new Stack<int>();// 1 2 3 4 5
        public Stack<int> stack2 = new Stack<int>();// 5 4 3 2 1
        public Stack<int> stack3 = new Stack<int>();
        public Stack<int> stack4 = new Stack<int>();// 1 2 3 4 5
        public INTLS() { }
        public INTLS(int numar)
        {
            this.numar = numar;
            this.numar2 = numar;
            while (numar2 != 0)
            {
                int aux = numar2 % 10;
                stack.Push(aux);
                stack4.Push(aux);
                numar2/=10;
            }
            while (stack.Count >= 1)
            {
                stack2.Push(stack.Pop());
            }
        }
        public void Stview()
        {            
            foreach(var item in stack4)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
        }
        public static INTLS operator +(INTLS a, INTLS b)
        {
            int nr = 0;
            int im = 0;
            INTLS t = new INTLS();
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
                        t.stack3.Push(nr);
                    }
                    else
                    {
                        t.stack3.Push(nr);
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
                        t.stack3.Push(nr);
                    }
                    t.stack3.Push(nr);
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
                        t.stack3.Push(nr);
                    }
                    else
                    {
                        t.stack3.Push(nr);
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
                        t.stack3.Push(nr);
                    }
                    else
                    {
                        t.stack3.Push(nr);
                    }
                }
            }
            t.stack2 = t.stack3;
            return t;
        }
        public static INTLS operator *(INTLS a, INTLS b)
        {
            Stack<int> stack5 = new Stack<int>();
            INTLS r = new INTLS();
            int sum = 0;
            foreach (int aux2 in b.stack2)
            {
                foreach (int aux in a.stack2)
                {
                    Console.Write(aux + " ");
                    sum += aux2 * aux;
                }
                sum *= 10;
                Console.WriteLine();
            }
            
            Console.WriteLine("inmultire: "+ sum);
            r.numar = sum;
            INTLS s = new INTLS(sum);
            return s;
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
