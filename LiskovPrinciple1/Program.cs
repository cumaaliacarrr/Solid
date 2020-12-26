using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    //interface IUcak
    //{
    //    bool KesifYap();
    //    bool HedefiVur();
    //}
    //class UcakA : IUcak
    //{
    //    public bool HedefiVur()
    //    {
    //        Console.WriteLine("Ucak A hedefi Vurdu");
    //        return true;
    //    }
    //    public bool KesifYap()
    //    {
    //        Console.WriteLine("Ucak A kesif yaptı");
    //        return true;
    //    }
    //}
    //class UcakB : IUcak
    //{
    //    public bool HedefiVur()
    //    {
    //        Console.WriteLine("Ucak B hedefi Vurdu");
    //        return true;
    //    }
    //    public bool KesifYap()
    //    {
    //        Console.WriteLine("Ucak B kesif yaptı");
    //        return true;
    //    }
    //}
    //class UcakC : IUcak
    //{
    //    public bool HedefiVur()
    //    {
    //        Console.WriteLine("Ucak C hedefi Vurdu");
    //        return true;
    //    }
    //    public bool KesifYap()
    //    {
    //        Console.WriteLine("Ucak C kesif yaptı");
    //        return true;
    //    }
    //}
    //class Savas
    //{
    //    List<IUcak> Ucaklar;
    //    public Savas(List<IUcak> Ucaklar)
    //    {
    //        this.Ucaklar = Ucaklar;
    //    }
    //    public void KesifYap()
    //    {
    //        Ucaklar.ForEach(u => {
    //            u.KesifYap();
    //        });
    //    }
    //    public void HedefiVur()
    //    {
    //        Ucaklar.ForEach(U => {
    //            U.HedefiVur();
    //        });
    //    }
    //}

    /*LiskovSubsitution olduktan sonraki Hali*/
    interface IUcakKesifYap
    {
        bool KesifYap();
    }
    interface IUcakHedefVur
    {
        bool HedefVur();
    }
    class UcakA : IUcakHedefVur, IUcakKesifYap
    {
        public bool HedefVur()
        {
            Console.WriteLine("Ucak A hedefi Vurdu");
            return true;
        }
        public bool KesifYap()
        {
            Console.WriteLine("Ucak A kesif yaptı");
            return true;
        }
    }
    class UcakB : IUcakKesifYap, IUcakHedefVur
    {
        public bool HedefVur()
        {
            Console.WriteLine("Ucak B hedefi Vurdu");
            return true;
        }
        public bool KesifYap()
        {
            Console.WriteLine("Ucak B kesif yaptı");
            return true;
        }
    }
    class UcakC : IUcakHedefVur, IUcakKesifYap
    {
        public bool HedefVur()
        {
            Console.WriteLine("Ucak C hedefi Vurdu");
            return true;
        }
        public bool KesifYap()
        {
            Console.WriteLine("Ucak C kesif yaptı");
            return true;
        }
    }
    class UcakD : IUcakKesifYap
    {
        public bool KesifYap()
        {
            Console.WriteLine("Ucak D kesif yaptı...");
            return true;
        }
    }
    class Savas
    {
        List<IUcakHedefVur> HedefVurucular;
        List<IUcakKesifYap> Kesifciler;
        public Savas(List<IUcakKesifYap> kesifciler, List<IUcakHedefVur> hedefciler)
        {
            this.Kesifciler = kesifciler;
            this.HedefVurucular = hedefciler;
        }
        public void KesifYap()
        {
            Kesifciler.ForEach(u =>
            {
                u.KesifYap();
            });
        }
        public void HedefiVur()
        {
            HedefVurucular.ForEach(U =>
            {
                U.HedefVur();
            });
        }
    }

}
