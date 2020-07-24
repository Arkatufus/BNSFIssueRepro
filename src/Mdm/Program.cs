using System.IO;
using System.Threading.Tasks;
using Akka.Actor;
using Akka.Configuration;

namespace Mdm
{
    public static class Program
    {
        static async Task Main(string[] args)
        {
            var hocon = File.ReadAllText("Mdm.conf");
            var config = ConfigurationFactory.ParseString(hocon);
            var sys = ActorSystem.Create("NcsBackOffice", config);

            await sys.WhenTerminated;
        }
    }
}
