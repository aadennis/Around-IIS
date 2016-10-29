using System;

namespace HelloServiceAClient
{
    class Program
    {
        static void Main(string[] args)         {
            var clientProxy = new ServiceReference1.HelloServiceClient();
            var msg = clientProxy.GetData(101);
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
