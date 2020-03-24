using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SoapFaultService
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CalculatorService" in both code and config file together.
    public class CalculatorService : ICalculatorService
    {
        public double Divide(int value1, int value2)
        {
            if (value2 == 0)
                throw new FaultException("Denometer cannot be 0", new FaultCode("DivideByZero"));

            return value1 / value2;
        }

        public double Minus(int value1, int value2)
        {
            return value1 - value2;
        }

        public double Multiply(int value1, int value2)
        {
            return value1 * value2;
        }

        public double Plus(int value1, int value2)
        {
            return value1 + value2;
        }

        
    }
}
