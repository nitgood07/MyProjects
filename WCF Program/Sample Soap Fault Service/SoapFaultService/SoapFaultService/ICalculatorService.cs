using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SoapFaultService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculatorService" in both code and config file together.
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        Double Divide(int value1, int value2);

        [OperationContract]
        double Multiply(int value1, int value2);

        [OperationContract]
        double Minus(int value1, int value2);

        [OperationContract]
        double Plus(int value1, int value2);
    }
}
