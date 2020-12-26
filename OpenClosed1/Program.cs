using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed1
{
    class Program
    {
        static void Main(string[] args)
        {
        
        }
    }

    //public class Rectangle
    //{
    //    public double Width  { get; set; }
    //    public double  Height{ get; set; }
    //}
    //public class Circle
    //{
    //    public double Radius { get; set; }
    //}
    ////public class AreaCalculator
    ////{
    ////    public double Area(Rectangle[] shapes){
    ////        double area = 0;
    ////        foreach (var shape in shapes)
    ////        {/*
    ////            Rectangle’ın alanını hesaplayabiliyoruz. 
    ////            Peki müşterimizden gelen bir istek ile Circle(Daire)’ında alanını hesaplamak istediğini belirtti bize.
    ////             Aklımıza gelen ilk şey olarak artık Rectangle tipinde bir dizi yerine object tipinde dizi tanımlayarak bunu da ufak bir if else bloğuna sokarak bir type kontrolü ile halledebiliriz */
    ////            area += shape.Height * shape.Width;
    ////        }
    ////        return area;
    ////    }
    ////}

    ///*Her şey güzel gidiyor derken müşterimizden gelen bir haber ile tekrar bir yeni isteği olduğunu belirtiyor. Bu seferde Triangles (Üçgen) için bir alan hesaplamak istiyor. Elbette bunu hesaplamak çok zor değil fakat yine kodumuzda değişiklikler gerekiyor.*/
    //public class AreaCalculator
    //{
    //    public double Area(object[] shapes)
    //    {
    //        double area=0;
    //        foreach (var shape in shapes)
    //        {
    //            if(shape is Rectangle)
    //            {
    //                Rectangle rec = (Rectangle)shape;
    //                area += rec.Width * rec.Height;
    //            }
    //            else
    //            {
    //                Circle circ = (Circle)shape;
    //                area += circ.Radius * circ.Radius * Math.PI;
    //            }
    //        }
    //        return area;
    //    }
    //}

    /*-----OCP Start------*/
    public abstract class Shape
    {
        public abstract double Area();
    }
    public class Rectangle : Shape
    {
        public double Width  { get; set; }
        public double  Height { get; set; }
        public override double Area()
        {
            return Width * Height;
        }
    }
    public class Circle:Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
    public class Triangles : Shape
    {
        public double Height  { get; set; }
        public double  Side { get; set; }
        public override double Area()
        {
            return Height * Side / 2;
        }
    }
    public class AreaCalculator
    {
        public double Area(Shape[] Shapes)
        {
            double area = 0;
            foreach (var shape in Shapes)
            {
                area += shape.Area();
            }
            return area;
        }
    }

    /*-----OCP End------*/

}
