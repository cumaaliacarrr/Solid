using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegragation2
{
    class Program
    {
        static void Main(string[] args)
        {
            Batman b = new Batman();
            Console.WriteLine(b.Costume());
            Console.WriteLine(b.Power());
            Console.WriteLine(b.UseBatMobile());
            Console.WriteLine("---------");
            SuperMan s = new SuperMan();
            Console.WriteLine(s.Costume());
            Console.WriteLine(s.Power());
            Console.WriteLine(s.FlyToSomeWhere());
            Console.ReadLine();
            
        }
    }
    //public interface ISuperHero
    //{
    //    string Costume();
    //    string Power();
    //    string BatMobile();
    //    string Fly();
    //}
    //public class Batman : ISuperHero
    //{

    //    public string BatMobile()
    //    {
    //        return "I can use BatMobile";
    //    }
    //    public string Power()
    //    {
    //        return "My power is my money :D ";
    //    }
    //    public string Costume()
    //    {
    //        return "My Costume is dark";
    //    }
    //    public string Fly()
    //    {
    //        return "I can not fly";
    //    }
    //}
    //public class SuperMan : ISuperHero
    //{
    //    public string BatMobile()
    //    {
    //        return "I can not use BatMobile";
    //    }
    //    public string Power()
    //    {
    //        return "I am from Krypton. Is that enough? ";
    //    }

    //    public string Costume()
    //    {
    //        return "My Costume is red and blue";
    //    }

    //    public string Fly()
    //    {
    //        return "I can fly";
    //    }
    //}

    /*------ISP uygulanmış hali------*/
 
public interface ISuperHero
    {
        string Costume();
        string Power();
    }
    public interface IBatMobile
    {
        string UseBatMobile();
    }
    public interface IFly
    {
        string FlyToSomeWhere();
    }
    public class Batman : ISuperHero, IBatMobile
    {
        public string UseBatMobile()
        {
            return "I can use BatMobile";
        }
        public string Power()
        {
            return "My power is my money :D ";
        }
        public string Costume()
        {
            return "My Costume is dark";
        }
    }
    public class SuperMan : ISuperHero, IFly
    {
        public string Costume()
        {
            return "My Costume is red and blue";
        }
        public string Power()
        {
            return "I am from Krypton. Is that enough? ";
        }
        public string FlyToSomeWhere()
        {
            return "I can fly";
        }
    }


}
