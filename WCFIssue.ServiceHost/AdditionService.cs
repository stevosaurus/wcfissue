using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFIssue.Services;

namespace WCFIssue.ServiceHost
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class AdditionService : IAdditionService
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
