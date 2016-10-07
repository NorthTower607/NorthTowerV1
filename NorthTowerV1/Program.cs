using IBApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//turkey607/Blue88

namespace NorthTowerV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "North Tower V1";

            var myClient = new EWrapperImpl();

            myClient.ClientSocket.eConnect("127.0.0.1", 7496, 0);

            //Thread.Sleep(10000);

            //Console.WriteLine("");
            //Console.WriteLine("Press any key to exit...");
            //Console.ReadLine();
        }
    }
}
