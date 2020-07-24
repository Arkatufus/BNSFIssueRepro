using System.IO;
using System.Threading.Tasks;
using Akka.Configuration;
using Akka.Actor;

namespace BackOffice
{
    public static class Program
    {
        static async Task Main(string[] args)
        {
            var hocon = File.ReadAllText("BackOffice.conf");
            var config = ConfigurationFactory.ParseString(hocon);
            var sys = ActorSystem.Create("NcsBackOffice", config);

            await sys.WhenTerminated;
        }
    }
}
