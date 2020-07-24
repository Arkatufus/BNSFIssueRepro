using System.IO;
using System.Threading.Tasks;
using Akka.Actor;
using Akka.Configuration;

namespace NmsClientInterface
{
    public static class Program
    {
        static async Task Main(string[] args)
        {
            var hocon = File.ReadAllText("NmsClientInterface.conf");
            var config = ConfigurationFactory.ParseString(hocon);
            var sys = ActorSystem.Create("NcsBackOffice", config);

            await sys.WhenTerminated;
        }
    }
}
