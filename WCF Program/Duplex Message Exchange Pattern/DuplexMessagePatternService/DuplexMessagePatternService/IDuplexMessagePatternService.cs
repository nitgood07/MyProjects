using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DuplexMessagePatternService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDuplexMessagePatternService" in both code and config file together.
    [ServiceContract(CallbackContract = typeof(IDuplexMessagePatternServiceCallback))]
    public interface IDuplexMessagePatternService
    {
        //[OperationContract(IsOneWay = true)]
        [OperationContract]
        void ProcessReport();
    }

    [ServiceContract]
    public interface IDuplexMessagePatternServiceCallback
    {
        //[OperationContract(IsOneWay = true)]
        [OperationContract]
        void ProgressMethod(int percentageCompleted);
        
    }
}
