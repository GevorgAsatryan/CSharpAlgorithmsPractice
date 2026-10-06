using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//global using
namespace ConsoleApp17
{
    public class Singleton
    {
        //private static Singleton Instance;
        //private static readonly object _object = new object();

        //private static readonly Lazy<Singleton> _lazyInstance =
        //new Lazy<Singleton>(CreateInstance);

        private static readonly Singleton _instance = new Singleton();

        static Singleton()
        {
            Console.WriteLine("Instance Created");
        }
        
        public static Singleton CreateInstance()
        {
            Console.WriteLine("Trying To Create");
            return _instance;
        }
       

        //public static Singleton SingletonInstance
        //{
        //    get
        //    {
        //        return _lazyInstance.Value;
        //    }
        //}

        //private static Singleton CreateInstance()
        //{
        //    Console.WriteLine("Trying to create");
        //    return new Singleton();
        //}

        //public static Singleton CreateInstance()
        //{

        //    if (Instance != null)
        //    {
        //        Console.WriteLine("There is already an instance.");
        //        return Instance;
        //    }
        //    else
        //    {
        //        lock (_object)
        //        {
        //            if (Instance == null)
        //            {
        //                Instance = new Singleton();
        //                Console.WriteLine("Constructor Called");
        //                return Instance;
        //            }
        //            return Instance;
        //        }
        //    }

        //}

    }

    public class S
    {
        public Singleton _Singleton { get; set; }

        public void CallSingleton()
        {
            _Singleton = Singleton.CreateInstance();
            //Console.WriteLine("Call");
            //_Singleton = Singleton.SingletonInstance;
        }

    }
}
