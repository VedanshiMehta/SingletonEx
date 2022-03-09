using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonEx
{
    class Program
    {
        static void Main(string[] args)
        {

            Singleton fromMentors = Singleton.GetInstance;
            fromMentors.PrintDetails("From Mentors");
            Singleton fromInterns = Singleton.GetInstance;
            fromInterns.PrintDetails("From Interns");
            Console.ReadLine();
        }
    }
}
