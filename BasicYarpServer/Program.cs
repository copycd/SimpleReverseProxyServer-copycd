using Cm.ReverseProxyServer;


namespace BasicYARPSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var proxyServer = new CmYarpReverseProxyServer();
            proxyServer.run(args);
        }
    }
}
