using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Ferrari();
            //car.Run();

            //Car car2 = new Murat();
            //car2.OpenAirConditioning();
        }
    }
    //Aynı sınıflardan oluşan nesnelerin base sınıfın nesneleri ile yer değiştirdikleri zaman aynı davranışları sergilemesi gerekir.
    // Türetilen sınıflar türeyen sınıfların tüm özelliklerini kullanabilmelidirler...
    //public abstract class Car
    //{
    //    public string Run()
    //    {
    //        return "Araba calisti";
    //    }
    //    public abstract string OpenAirConditioning();
    //}
    //public class Ferrari : Car
    //{
    //    public override string OpenAirConditioning()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //public class Murat : Car
    //{
    //    public override string OpenAirConditioning()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    /*Liskov Yöntemi Uygulanmış Hali*/
    public interface IAirConditionable
    {
        string OpenAirConditioning();
    }
    public abstract class Car
    {
        public string Run()
        {
            return "Araba calisti";
        }
    }
    public class Ferrari : Car, IAirConditionable
    {
        public string OpenAirConditioning()
        {
            return "Klima Acildi";
        }
    }
    public class Murat : Car
    {

    }
}
