using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    internal interface AutoVehicul : Putere
    {
        void brand();
        void tractiune();
    }
    internal interface Putere
    {
        void caiPutere();
    }
    internal class BMW  : AutoVehicul 
    {
       virtual public void brand()
        {
            Console.WriteLine("Brandul masini cerute este BMW.");
        }

        public void caiPutere()
        {
            Console.WriteLine("Cai putere 250");
        }

        public void tractiune()
        {
            Console.WriteLine("Tractiune spate.");
        }
    }
    internal class Audi : AutoVehicul
    {
        public void brand()
        {
            Console.WriteLine("Brandul masini cerute este Audi.");
        }

        public void caiPutere()
        {
            Console.WriteLine("Cai putere 210");
        }

        public void tractiune()
        {
            Console.WriteLine("Tractiune 4x4.");
        }
    }
    internal class Mercedes : BMW , AutoVehicul
    {
        public override void  brand()
        {
            Console.WriteLine("Brandul masini cerute este Mercedes.");
        }
    }
    internal class Masina
    {
        private int masini, entry;
        string culoare, marca;


        public Masina() { entry++; Console.WriteLine("-Constructor 1-"); }
        public void MasinaNoua(string culoare, string marca)
        {
            masini++;
            this.marca = marca; this.culoare = culoare;
            Console.WriteLine(ToString());                     
        }
        public override string ToString()
        {
            return $"Masina{masini}: "+marca+" "+culoare.ToString();
        }
        public void Stats()
        {
            Console.WriteLine($"Masini fabricate: {masini}, accesari a clasei: {entry}.");
        }
    }
    internal class MasiniStruct : Masina
    {
        public MasiniStruct() { Console.WriteLine("-Constructor 2-"); }
    }
    internal class MasiniMarca : MasiniStruct
    {
        public MasiniMarca() { Console.WriteLine("-Constructor 3-"); }
    }
}
