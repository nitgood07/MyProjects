using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace HelloServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost host = new ServiceHost(typeof(HelloService.HelloService)))
            {
                //Create end point and configuration behavior using code.
                ServiceMetadataBehavior serviceMetadataBehavior = new ServiceMetadataBehavior()
                {
                    HttpGetEnabled = true,
                };

                host.Description.Behaviors.Add(serviceMetadataBehavior);
                host.AddServiceEndpoint(typeof(HelloService.IHelloServiceChanged), new BasicHttpBinding(), "HelloService");
                host.AddServiceEndpoint(typeof(HelloService.IHelloServiceChanged), new NetTcpBinding(), "HelloService");

                host.Open();
                Console.WriteLine("Service Started at " + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
