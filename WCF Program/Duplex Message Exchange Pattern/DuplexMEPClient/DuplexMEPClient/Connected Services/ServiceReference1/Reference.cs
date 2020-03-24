﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DuplexMEPClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IDuplexMessagePatternService", CallbackContract=typeof(DuplexMEPClient.ServiceReference1.IDuplexMessagePatternServiceCallback))]
    public interface IDuplexMessagePatternService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDuplexMessagePatternService/ProcessReport", ReplyAction="http://tempuri.org/IDuplexMessagePatternService/ProcessReportResponse")]
        void ProcessReport();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDuplexMessagePatternService/ProcessReport", ReplyAction="http://tempuri.org/IDuplexMessagePatternService/ProcessReportResponse")]
        System.Threading.Tasks.Task ProcessReportAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDuplexMessagePatternServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDuplexMessagePatternService/ProgressMethod", ReplyAction="http://tempuri.org/IDuplexMessagePatternService/ProgressMethodResponse")]
        void ProgressMethod(int percentageCompleted);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDuplexMessagePatternServiceChannel : DuplexMEPClient.ServiceReference1.IDuplexMessagePatternService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DuplexMessagePatternServiceClient : System.ServiceModel.DuplexClientBase<DuplexMEPClient.ServiceReference1.IDuplexMessagePatternService>, DuplexMEPClient.ServiceReference1.IDuplexMessagePatternService {
        
        public DuplexMessagePatternServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public DuplexMessagePatternServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public DuplexMessagePatternServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public DuplexMessagePatternServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public DuplexMessagePatternServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void ProcessReport() {
            base.Channel.ProcessReport();
        }
        
        public System.Threading.Tasks.Task ProcessReportAsync() {
            return base.Channel.ProcessReportAsync();
        }
    }
}
