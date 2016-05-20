using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Message
    {
        public void PrintMsg(string message)
        {
            Console.WriteLine(message);
        }

        public void PrintMsgs(List<string> messages)
        {
            foreach (string message in messages)
            {
                Console.WriteLine(message);
                Console.WriteLine('\n');
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message();
            message.PrintMsg("Hello, World!");
        }
    }
}
