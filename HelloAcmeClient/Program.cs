using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloAcmeService;

namespace HelloServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var clientProxy = new HelloAcmeClient.ServiceReference1.HelloServiceClient();
            var msg = clientProxy.GetData(101);
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
