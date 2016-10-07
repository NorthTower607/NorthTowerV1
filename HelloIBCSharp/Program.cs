using Domain;
using IBApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//turkey607/Blue88

namespace HelloIBCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Hello IBC Sharp";

            //IB's main object
            var ibClient = new EWrapperImpl();

            //Connect
            ibClient.ClientSocket.eConnect("127.0.0.1", 7496, 0);

            //Create and define a contract to fetch data for
            var contract = new Contract();
            contract.Symbol = "EUR";
            contract.SecType = "CASH";
            contract.Currency = "GBP";
            contract.Exchange = "IDEALPRO";

            //Invoke IB's ClientSocket's data request
            ibClient.ClientSocket.reqMktData(1, contract, "", false, null);

            //Stay alive for 10 seconds
            Thread.Sleep(10000);
        }
    }
}
