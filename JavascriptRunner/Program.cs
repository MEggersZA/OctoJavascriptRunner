using System;
using System.Configuration;
using System.Threading.Tasks;
using EdgeJs;

namespace JavascriptRunner
{
    class Program
    {
        public static async Task Start()
        {
            try
            {
                var main = ConfigurationManager.AppSettings["main"];
                var func = Edge.Func(@"return require('./../bootstrap.js')");
                Console.WriteLine(await func(main));

                Console.ReadKey();
                Environment.ExitCode = 0;
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
                Environment.ExitCode = -1;
            }
                      
        }

        static void Main(string[] args)
        {
            Start().Wait();
        }
    }
}
