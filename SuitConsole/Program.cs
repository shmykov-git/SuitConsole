using System;
using Suit;
using Suit.Logs;
using SuitConsole.Tools;

namespace SuitConsole
{
    class Program
    {
        static Program()
        {
            IoC.Configure(IoCSuitConsole.Register);
        }

        static void Main(string[] args)
        {
            var log = IoC.Get<ILog>();

            log.Debug("### Start console ###");

            IoC.Get<MyTool>().Start();

            Console.ReadLine();

            log.Debug("### End ###");
        }
    }
}
