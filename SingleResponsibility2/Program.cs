using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility2
{
    class Program
    {
        static void Main(string[] args)
        {
            SendMail s1 = new SendMail();
            Console.Write(s1.SendMailForX("aa", "bb"));
            Console.ReadLine();
        }
    }
    /*SRP yapılmamış hali Start*/
    /*
     Bu şekilde kod yazılırsa SRP ye uymaz çünkü SendMail sınıfının işi mail göndremek
     format kontrol etmek değil. Bu yüzden IsMailAdressValid metodu bu classsın içerisinde olmamalıdır... 
         */
    //public class SendMail
    //{
    //    public bool SendMailForX(string input,string mailAdress)
    //    {
    //        //Kural Denetimi Talep et
    //        if(!isMailAdressValid(mailAdress))
    //                return false;
    //        //Formatlama işlemi yap
    //        return true;
    //    }
    //    public bool isMailAdressValid(string mailAdress)
    //    {
    //        //Kural denetimi yap
    //        return true;
    //    }
    //}
    /*--SRP yapılmamış hali end--*/

    /*SRP uygulanmış hali Start*/
    public class SendMail
    {
        public bool SendMailForX(string input, string mailAdress)
        {
            MailAdressValidator _validator = new MailAdressValidator();
            //Kural Denetimi Talep et
            if (!_validator.isMailAdressValid(mailAdress))
                return false;
            //Formatlama işlemi yap
            return true;
        }
    }
    public class MailAdressValidator
    {
        public bool isMailAdressValid(string mailAdress)
        {
            //Kural denetimi yap
            return true;
        }
    }
}
