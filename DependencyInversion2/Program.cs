using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Email e = new Email();
            e.Send();
            Sms s = new Sms();
            s.Send();
            Console.ReadLine();
        }
    }
    //public class Information
    //{
    //    Email InformationSender { get; set; }
    //    public Information(Email email)
    //    {
    //        InformationSender = email;
    //    }
    //    public void SendInformation()
    //    {
    //        InformationSender.Send();
    //    }
    //}
    //public class Email
    //{
    //    public void Send()
    //    {
    //        Console.WriteLine("Bildirim");
    //    }
    //}
    /*Dependency ile Düzeltilmiş Hali*/
    public class Information
    {
        ISender InformationSender { get; set; }
        public Information(ISender informationSender)
        {
            InformationSender = informationSender;
        }
        public void SendInformation()
        {
            InformationSender.Send();
        }
    }
    public interface ISender
    {
        void Send();
    }
    public class Email : ISender
    {
        public void Send()
        {
            Console.WriteLine("Email Bildirim");
        }
    }
    public class Sms : ISender
    {
        public void Send()
        {
            Console.WriteLine("Sms bildirim");
        }
    }
}
