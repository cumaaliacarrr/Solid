using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed2
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlLog x = new XmlLog();
            Console.Write(x.Log("asdasd"));
            Console.Read();
        }
    }

    //class XmlLog
    //{
    //    public bool Log(string value)
    //    {
    //        return true;
    //    }
    //}
    //class DbLog
    //{
    //    public bool Log(string value)
    //    {
    //        return true;
    //    }
    //}

    //enum LogType
    //{
    //    Xml,
    //    Db
    //}
    //class Logger
    //{
    //    private readonly XmlLog _xmlLog;
    //    private readonly DbLog _dbLog;

    //    public Logger(XmlLog xmlLog, DbLog dbLog)
    //    {
    //        _xmlLog = xmlLog;
    //        _dbLog = dbLog;
    //    }
    //    public void Log(LogType type, string value)
    //    {
    //        switch (type)
    //            case LogType.Xml:
    //            _xmlLog.Log(value);
    //            break;
    //        case LogType.Db:
    //            _dbLog.Log(value);
    //            break;
    //        }
    //    }

    //}

    /*OCP uygun hali Start*/
    interface ILogger
    {
        bool Log(string value);

    }
    class XmlLog : ILogger
    {
        public bool Log(string value)
        {
            return true;
        }
    }
    class DbLog : ILogger
    {
        public bool Log(string value)
        {
            return true;
        }
    }
    class JsonLog : ILogger
    {
        public bool Log(string value)
        {
            return true;
        }
    }
    class Logger
    {
        private readonly ILogger _Logger;
        public Logger(ILogger logger)
        {
            _Logger = logger;
        }
        public void Log(string value)
        {
            _Logger.Log(value);
        }
    }
    /*OCP uygun hali End*/
}
