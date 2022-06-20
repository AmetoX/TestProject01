namespace Test01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test01Stack();
            //Test02BK();
            MasiniMarca car = new MasiniMarca();
            car.MasinaNoua("negru", "audi");
            car.MasinaNoua("albastru", "bmw");
            car.MasinaNoua("mov", "opel");
            car.Stats();
            List<AutoVehicul> masini = new List<AutoVehicul>();
            masini.Add(new BMW());
            masini.Add(new Audi());
            masini.Add(new Mercedes());
            foreach (var masina in masini)
            {
                masina.brand();
                masina.tractiune();  
                masina.caiPutere();
            }
            BMW masina1 = new BMW();
            masina1 = new Mercedes();
            masina1.brand();
        }
        static void Test01Stack()
        {
            Stack test01 = new Stack();//ultimul element introdus va fi primul in vector
            test01.Push(2);
            test01.Push(3);
            test01.Push(4);
            test01.Push(5);
            test01.Push(6);
            test01.Push(7);
            test01.View();
            //test01.Pop();
            //test01.Pop2(); 
            //test01.Pop3(1);
            test01.View();
        }
        static void Test02BK()//generare patrat perfect
        {
            int n = 9;
            int[] s = new int[n];
            bool[] b = new bool[n];
            BK(0, n, s, b);
        }
        static void BK(int k, int n, int[] s, bool[] b)
        {
            if (k >= n)
            {
                int sl1 = s[0] + s[1] + s[2];
                int sl2 = s[3] + s[4] + s[5];
                int sl3 = s[6] + s[7] + s[8];

                int sc1 = s[0] + s[3] + s[6];
                int sc2 = s[1] + s[4] + s[7];
                int sc3 = s[2] + s[5] + s[8];

                int sd1 = s[0] + s[4] + s[8];
                int sd2 = s[2] + s[4] + s[6];
                if (sl1 == sl2 && sl1 == sl3 && sl1 == sc1 && sl1 == sc2 && sl1 == sc3 && sl1 == sd1 && sl1 == sd2)
                {
                    int l = 0;
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(s[i] + " ");
                        l++;
                        if (l == 3)
                        {
                            Console.WriteLine();
                            l = 0;
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!b[i])
                    {
                        b[i] = true;
                        s[k] = i + 1;
                        BK(k + 1, n, s, b);
                        b[i] = false;
                    }
                }
            }
        }
        static void BubbleSort(int[] v)
        {
            int n = v.Length;
            bool sw;
            for (int i = 0; i < n - 1; i++)
            {
                sw = false;
                for (int j = 0; j < n - 1; j++)
                {
                    if (v[j] > v[j + 1])
                    {
                        int temp = v[j];
                        v[j] = v[j + 1];
                        v[j + 1] = temp;
                        sw = true;
                    }
                }
                if (!sw)
                    break;
            }
        }
        static void Matrice() { }
    }
}