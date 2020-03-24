using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace HelloServiceWindowsServiceHost
{
    public partial class HelloWindowsService : ServiceBase
    {

        //create host object
        ServiceHost host;
        public HelloWindowsService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            host = new ServiceHost(typeof(HelloService.HelloService));

            ServiceMetadataBehavior serviceMetadataBehavior = new ServiceMetadataBehavior()
            {
                HttpGetEnabled = true,
            };
            host.Description.Behaviors.Add(serviceMetadataBehavior);
            host.AddServiceEndpoint(typeof(HelloService.IHelloServiceChanged), new BasicHttpBinding(), "HelloService");
            host.AddServiceEndpoint(typeof(HelloService.IHelloServiceChanged), new NetTcpBinding (), "HelloService");

            host.Open();
        }

        protected override void OnStop()
        {
            host.Close();
        }
    }
}
