using System;

namespace HelloServiceClient {
    class Program {
        static void Main(string[] args) {
            var clientProxy = new HelloAcmeClient.ServiceReference.HelloServiceClient();
            var msg = clientProxy.GetData(101);
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
