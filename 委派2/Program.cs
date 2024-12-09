using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace 委派2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 想辦法運用今天教的委派的概念 完成 Select Where 

            say(x => { Console.WriteLine("Hi Leo" + x); });
            Console.ReadLine();
        }


        private static List<int> Select(List<int> list)
        {

        } 

        private static List<int> Where(List<int> list)
        {00

        }


        private static void SayHi(string name)
        {
            Console.WriteLine("Hi Leo" + name);

        }

        
        private static void say(Action<string> callback)
        {
            callback.Invoke("AAA");
        }
    }
}
