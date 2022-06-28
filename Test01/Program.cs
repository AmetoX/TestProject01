namespace Test01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Test01Stack();
            //Test02BK();
            //Greddy();
            //GreddyTest();
            //GreddyTest2();
            //Ex2();
            //spirala();
            //contur();
            //conturv2();
            //matrice();
            //serpuire();
            //NrComplex();
            //problema1();
            //problema2();
            //Intls();
            P47();
        }
        static void Intls()
        {
            INTLS a = new INTLS(123459);
            a.test();
        }
        /// <summary>
        /// Afiseaza nr care se repeta intr- un tablou
        /// </summary>
        private static void P47()
        {
            Random rnd = new Random();
            int[] v = new int[100];
            int[] freq = new int[100];
            for (int i = 0; i < 100; i++)
            {
                v[i] = rnd.Next(99);
            }
            for (int i = 0; i < 100; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 100; i++)
            {
                freq[v[i]]++;
                Console.Write($"{freq[v[i]]} ");
            }
            Console.WriteLine("\nNumerele care se repeta sunt: ");
            for (int i = 0; i < 100; i++)
            {
                if (freq[i] > 1)
                {
                    Console.Write(i + " ");
                }
            }

        }
        static void problema1()
        {
            Random random = new Random();
            int n = random.Next(5, 25);
            int m = random.Next(5, 25);
            char[,] matr = new char[n, m];
            char a = 'a';
            char b = 'A';
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (j % 2 == 0)
                    {
                        matr[i, j] = a;
                    }
                    else
                    {
                        matr[i, j] = b;
                    }
                }
                a++;
                b++;
            }
            viewMatrix(matr);
        }
        static void problema2()
        {
            int n = 8;
            int[,] matr = new int[n, n];
            int nr = n;
            for (int i = 0; i < n; i++)
            {
                nr = n - i;
                for (int j = 0; j < n; j++)
                {

                    if (i + j == n - 1)
                    {
                        matr[i, j] = 0;
                    }
                    if (i + j < n - 1)
                    {
                        matr[i, j] = nr - 1;
                        nr--;
                    }
                    else
                    {
                        matr[i, j] = nr - 1;
                        nr++;
                    }
                }
            }
            viewMatrix2(matr);
        }
        static void viewMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void NrComplex()
        {
            Complex a = new Complex();a.init(2, 6,3);
            Complex b = new Complex();b.init(3, 4,5);
            Complex c = new Complex();Complex d = new Complex();
            c = a * b;
            d = a / b;
            Console.WriteLine(c.view());
            Console.WriteLine(d.view());
        }
        static void serpuire()
        {
            int n = 5; int m = 7;
            int[,] matrice = new int[n, m];
            viewMatrix2(matrice);
            Console.WriteLine();
            for(int s = 0; s <= n + m; s++)
            {
                if (s % 2 == 0)
                {
                    for(int i = n-1; i >= 0; i--)
                    {
                        for(int j = 0; j < m; j++)
                        {
                            if (i + j == s) 
                                matrice[i, j] = i+j;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            if (i + j == s) 
                            {
                                matrice[i, j] = 2;
                            }
                        }
                    }
                }
            }
            viewMatrix2(matrice);
        }
        static void matrice()
        {
            
            int n = 8; int m = 8;
            int[,] matrice = new int[n, m];
            viewMatrix2(matrice);
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for(int j= 0; j < m; j++)
                {
                    if (i + j < n - 1 && i <= j) //zona 1
                    {
                        matrice[i, j] = 1;
                    }
                    if (i + j >= n - 1 && i < j) //zona 2
                    {
                        matrice[i, j] = 2;
                    }
                    if (i + j > n - 1 && i >= j) //zona 3
                    {
                        matrice[i, j] = 3;
                    }
                    if (i + j <= n - 1 && i > j) //zona 4
                    {
                        matrice[i, j] = 4;
                    }
                }
            }
            viewMatrix2(matrice);
        }
        static void conturv2()
        {
            int n = 8; int m = 10;
            int[,] matrice = new int[n, m];
            viewMatrix2(matrice);
            Console.WriteLine();
            for (int j = 0; j < n; j++)
            {
                if (j % 2 == 1)
                {
                    for (int i = j; i < m - j-1; i++)
                    {
                        matrice[j, i] = 1;
                    }
                    for (int i = j; i < n - j-1; i++)
                    {
                        matrice[i, m - j-1] = 1;
                    }
                    for (int i = m - j-1; i > j; i--)
                    {
                        matrice[n - j-1, i] = 1;
                    }
                    for (int i = n - j-1; i > 0; i--)
                    {
                        matrice[i, j] = 1;
                    }
                }
            }
            viewMatrix2(matrice);
        }
        static void contur()
        {
            int n = 8; int m = 9;
            int[,] matrice = new int[n, m];
            viewMatrix2(matrice);
            Console.WriteLine();
            for (int i = 0; i < m - 1; i++)
            {
                matrice[0, i] = 1;
            }
            for (int i = 0; i < n - 1; i++)
            {
                matrice[i, m - 1] = 1;
            }
            for (int i = m - 1; i >= 1; i--)
            {
                matrice[n - 1, i] = 1;
            }
            for (int i = n - 1; i > 0; i--)
            {
                matrice[i, 0] = 1;
            }
            viewMatrix2(matrice);
        }
        static void spirala()
        {
            int n = 9;
            int[,] matrice = new int [n,n];
            viewMatrix2(matrice);
            Console.WriteLine();
            for (int j = 0; j < n/2; j++)
            {
                for (int i = j; i < n - 1 - j; i++)//zona 1
                    matrice[j, i] = 1;
                for (int i = j; i < n - 1 - j; i++)//zona 2
                    matrice[i, n - 1 - j] = 1;
                for (int i = n - j - 1; i > j; i--)//zona 3
                    matrice[n-1-j, i] = 1;
                for (int i = n - j - 1; i > 0; i--)//zona 4
                    matrice[i, j] = 1;
            }
            viewMatrix2(matrice);
        }
        static void viewMatrix2(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Ex2()
        {
            int[] u = { 2, 3, 3, 4, 4, 4, 3 };
            int[] v = { 1, 2, 3, 4, 5, 6, 6 };
            int[] powU = Pow(u);
            int[] powV = Pow(v);
        }
        private static int[] Pow(int[] v)
        {
            int[] freq = new int[201]; //monitorizeaza aparitiile pentru ficere nr din v
                                       //(nr din v sunt intre -100 si 100 => 201 valori)

            int notZeroCount = 0;    //numara cate valori apar cel putin o data    
            for (int i = 0; i < v.Length; i++)
            {
                if (freq[v[i] + 100] == 0) //daca este prima data cand gasim numarul crestem contorul        
                    notZeroCount++;
                freq[v[i] + 100]++; // ex: freq[0] monitorizeaza aparitiile lui -100
                                    // freq[1] -> -99
                                    //freq[2] -> -98
                                    //...
                                    //freq[199] -> 99
                                    //freq[200] -> 100
            }
            int[] pow = new int[notZeroCount];
            int pos = 0;
            //adaug in vectorul putere frecventele mai mari decat 0
            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] > 0)
                {
                    pow[pos] = freq[i];
                    pos++;
                }

            }
            BubbleSort(pow);
            for (int i = 0; i < pow.Length; i++)
            {
                Console.Write(pow[i] + " ");
            }
            Console.WriteLine();
            return pow;
        }
        static void GreddyTest2()
        {
            int[] s = { 1, 4, 7, 9, 10 };
            int[] f = { 3, 3, 5, 7, 8, 19, 20, 22 };
            int n = s.Length;
            int m = f.Length;
            for (int i = 0; i < m; i++)
            {
                if (i < n)
                {
                    if (s[i] % 2 == 0 && f[i] % 2 == 0) 
                    {
                        if(s[i] > f[i])
                        {
                            
                            Console.Write(f[i]+" " + s[i]+" ");
                        }
                        else
                        {
                            Console.Write(s[i] + " " + f[i] + " ");
                        }
                    }
                    else
                    {
                        if (s[i] % 2 == 0)
                        {
                            Console.Write(s[i] + " ");
                        }
                        if (f[i] % 2 == 0)
                        {
                            Console.Write(f[i] + " ");
                        }
                    }   
                }
                else
                {
                    if (f[i] % 2 == 0)
                    {
                        Console.Write(f[i] + " ");
                    }
                }
            }
        }
        static void GreddyTest()
        {
            int[] s = { 2, 6, 7, 9, 10};
            int[] f = { 1, 4, 5, 7, 8, 19, 20, 22 };
            int n = s.Length;
            int m = f.Length;
            for (int i = 0; i < m; i++)
            {
                if (i < n)
                {
                    if (s[i] % 2 == 0)
                    {
                        if (f[i] % 2 == 0)
                        {
                            if (s[i] > f[i])
                            {
                                Console.Write($"{f[i]} {s[i]} ");
                            }
                            else
                            {
                                Console.Write($"{s[i]} {f[i]} ");
                            }
                        }
                        else
                        {
                            Console.Write(s[i] + " ");
                        }
                    }else if (f[i] % 2 == 0)
                    {
                        Console.Write(f[i] + " ");
                    }
                }
                else
                {
                    if (f[i] % 2 == 0)
                    {
                        Console.Write(f[i]+" ");
                    }
                }
            }
        }
        static void Greddy()
        {
            int[] s = { 1, 3, 0, 5, 8, 5 };
            int[] f = { 2, 4, 6, 7, 9, 9 };
            int n = s.Length;//6
            int i, j;

            Console.Write("Following activities are selected : ");

            // The first activity always gets selected
            i = 0;
            Console.Write(s[i] + " ");

            // Consider rest of the activities
            for (j = 1; j < n; j++)
            {
                // If this activity has start time greater than or
                // equal to the finish time of previously selected
                // activity, then select it
                if (s[j] >= f[i])
                {
                    Console.Write(s[j] + " ");
                    i = j;
                }
            }
        }
        static void Obiecte()
        {
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