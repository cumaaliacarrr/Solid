using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    //class imalat
    //{
    //    public void Olustur()
    //    {
    //        Kek kek = new Kek();
    //        kek.KekYap(true);
    //    }
    //}
    //class Kek
    //{
    //    public void KekYap(bool kakao)
    //    {
    //        Console.WriteLine("Kakao Konuldu");
    //    }
    //}

    /*DIP uygulanmış hali*/
    interface IGida
    {
        void Yap(bool kakao);
    }
    class imalat
    {
        IGida gida;
        public imalat()
        {
            gida = new Kek();
        }
        public void Olustur()
        {
            gida.Yap(true);
        }
    }
    class Kek : IGida
    {
        public void Yap(bool kakao)
        {
            Console.WriteLine("Prossecler");
        }
    }

}
