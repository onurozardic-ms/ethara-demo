using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossPlatformConsoleApplication
{
    public class HelloWorld
    {
        private void HelloFromPrivate()
        {
            Console.WriteLine("Hello World from private");
        }

        public void HelloFromPublic()
        {
            Console.WriteLine("Hello World from public");
        }

        public int sum(int a, int b)
        {
            return a + b;
        }

        public void callHelloInPrivate()
        {
            this.HelloFromPrivate();
        }
    }
}
