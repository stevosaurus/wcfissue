using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFIssue.Services;

namespace WCFIssue.ServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseAddress = new Uri("net.pipe://localhost/WCFIssue");

            System.ServiceModel.ServiceHost serviceHost = new System.ServiceModel.ServiceHost(typeof(AdditionService), baseAddress);
            NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            serviceHost.AddServiceEndpoint(typeof(IAdditionService), binding, "AdditionService");
            serviceHost.Open();
            
            Console.WriteLine($"ServiceHost running at {baseAddress}. Press Return to Exit");
        }
    }
}
