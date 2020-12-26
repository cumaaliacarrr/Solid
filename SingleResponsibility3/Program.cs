using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    /*Starttt*/
    //class Alisveris
    //{
    //    public double ProductPrice { get; set; }
    //    public bool LimitControl()
    //    {
    //        return true;
    //    }
    //    public bool Completed()
    //    {
    //        return true;
    //    }

    //}
    /*End */

    /*Start SRP uygulanmış hali */
    class Alisveris
    {
        public double ProductPrice { get; set; }
    }

    class LimitControl
    {
        public bool LimitValid()
        {
            return true;
        }
          }
    class CompletedControl
    {
        public bool Completed()
        {
            return true;
        }
    }

    /*End */


}
