using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{

    public class Singleton
    {
        private static int counter = 0;
        private static Lazy<Singleton> instance = new Lazy<Singleton>(()=> new Singleton());

        private static readonly object instanceLock = new object();

        private Singleton()
        {
            Console.WriteLine(counter++);
        }


        public static Singleton GetInstance
        {
            get
            {
              return instance.Value;
            }

        }

        //step 5 method to perform some operation
        public string GetSingleTonMethod()
        {
            return $"This is singleton class method";
        }


    }


}
