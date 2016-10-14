namespace HelloAcmeService {
    public class HelloService : IHelloService {
        public string GetData(int value) {
            return string.Format("You entered: {0}", value);
        } 
    }
}
