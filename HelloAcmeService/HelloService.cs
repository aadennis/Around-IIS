namespace HelloAcmeService {
    public class HelloService : IHelloService {
        public string GetData(int value) {
            return string.Format("You pretty much entered: {0}", value);
        }
    }
}
