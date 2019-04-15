using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using WcfServiceContract;

namespace WebServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:10004/ServiceWCF");
            ServiceHost myHost = new ServiceHost(typeof(MyCalculator), baseAddress);
            try
            {
                WSHttpBinding myBinding = new WSHttpBinding();
                myHost.AddServiceEndpoint(typeof(ICalculator), myBinding, "endpoint1");
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                myHost.Description.Behaviors.Add(smb);
                myHost.Open();
                Console.WriteLine("Service Started");
                Console.WriteLine("Press <ENTER> to dismiss");
                Console.WriteLine();
                Console.ReadLine();
                myHost.Close();
            }
            catch(CommunicationException ce)
            {
                Console.WriteLine("Exception occured: {0}", ce.Message);
                myHost.Abort();
            }
        }
    }
}
