using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloAcmeService {
    [ServiceContract]
    public interface IHelloService {
        [OperationContract]
        string GetData(int value);
    }
}
