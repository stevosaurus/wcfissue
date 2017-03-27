using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFIssue.Services
{
    [ServiceContract(SessionMode = SessionMode.Required,
        Namespace = "http://Petrolytics.DataAdapters.MsAccessServices")]
    public interface IAdditionService
    {
        [OperationContract]
        int Add(int a, int b);
    }
}
