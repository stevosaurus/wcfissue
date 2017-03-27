using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFIssue.Services;

namespace WCFIssue
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionAddress = "net.pipe://localhost/DummyEndPoint";
            var binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            var ep = new EndpointAddress(connectionAddress);

            var additionService = ChannelFactory<IAdditionService>.CreateChannel(binding, ep, new Uri(connectionAddress));

            var additionResult = additionService.Add(1, 2);

            Console.WriteLine($"Results from adding 1 and 2: {additionResult}");
            Console.ReadLine();
        }
    }
}
