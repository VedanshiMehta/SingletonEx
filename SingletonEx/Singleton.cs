using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonEx
{
    public sealed class  Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;

        private  Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value" + counter.ToString());

        }

        public static Singleton GetInstance
        {
            get {

                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
            
        }

        public void PrintDetails(string message)
        {

            Console.WriteLine(message);

        }

    }
}
