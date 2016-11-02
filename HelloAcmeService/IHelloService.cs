using System.ServiceModel;

namespace HelloAcmeService {
    [ServiceContract]
    public interface IHelloService {
        [OperationContract]
        string GetData(int value);
    }
}
