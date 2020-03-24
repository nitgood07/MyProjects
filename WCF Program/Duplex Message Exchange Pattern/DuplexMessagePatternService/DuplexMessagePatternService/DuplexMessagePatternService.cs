using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace DuplexMessagePatternService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DuplexMessagePatternService" in both code and config file together.
    [ServiceBehavior(ConcurrencyMode=ConcurrencyMode.Reentrant)]
    public class DuplexMessagePatternService : IDuplexMessagePatternService
    {
       
        public void ProcessReport()
        {
            for(int i = 1; i<100; i++)
            {
                Thread.Sleep(100);
                OperationContext.Current.GetCallbackChannel<IDuplexMessagePatternServiceCallback>().ProgressMethod(i);
            }
        }
    }
}
