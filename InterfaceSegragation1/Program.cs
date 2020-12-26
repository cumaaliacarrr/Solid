using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegragation1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    // Nesneler asla ihtiyacı olmayan property metot vs. içeren interfaceleri implement etmeye zorlanmamalıdır.
    /*----------------------*/
    //interface Itank
    //{
    //    bool AtesEt();
    //    bool HareketEt();
    //    double DusmanIleMesafeOlc();
    //}
    //class Tank1 : Itank
    //{
    //    public bool AtesEt() => true;
    //    public double DusmanIleMesafeOlc()
    //    {
    //        return 100;
    //    }
    //    public bool HareketEt() => true;
    //}
    //class Tank2 : Itank
    //{
    //    public bool AtesEt()
    //    {
    //        return false;
    //    }
    //    public double DusmanIleMesafeOlc()
    //    {
    //        return 230;
    //    }
    //    public bool HareketEt() => false;
    //}
    //class Tank3 : Itank
    //{
    //    public bool AtesEt() => true;

    //    public double DusmanIleMesafeOlc()
    //    {
    //        return -1;
    //    }
    //    public bool HareketEt() => true;
    //}
    /*InterFace Segregation ile yapılmış Hali*/
    interface ITank : ItankMesafeOlc, ItankHareketEt, ItankAtesEt
    {
    }
    interface ItankAtesEt
    {
        bool AtesEt();
    }
    interface ItankHareketEt
    {
        bool HareketEt();
    }
    interface ItankMesafeOlc
    {
        double MesafeOlc();
    }
    class Tank1 : ITank
    {
        public bool AtesEt() => true;
        public double MesafeOlc()
        {
            Console.WriteLine("Tank 1 Mesafe Ölçüldü");
            return 100;
        }
        public bool HareketEt() => true;
    }
    class Tank2 : ItankHareketEt, ItankMesafeOlc
    {
        public double MesafeOlc()
        {
            Console.WriteLine("Tank 2 Mesafe Ölçüldü");
            return 230;
        }
        public bool HareketEt() => true;
    }
    class Tank3 : ItankAtesEt, ItankHareketEt
    {
        public bool AtesEt() => true;
        public bool HareketEt() => true;
    }
}
