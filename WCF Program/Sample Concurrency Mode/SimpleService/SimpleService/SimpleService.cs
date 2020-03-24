using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace SimpleService
{
    [ServiceBehavior(ConcurrencyMode=ConcurrencyMode.Single,InstanceContextMode =InstanceContextMode.Single)]
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SimpleService" in both code and config file together.
    public class SimpleService : ISimpleService
    {
        public List<int> GetEvenNumbers()
        {
            Console.WriteLine("Thread {0} started processing GetEvenNumbers at {1}", Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString());
            List<int> listEvenNumber = new List<int>();
            for(int i=0; i< 10; i++)
            {
                Thread.Sleep(200);
                if (i % 2 == 0)
                {
                    listEvenNumber.Add(i);
                }
            }
            Console.WriteLine("Thread {0} completed processing GetEvenNumbers at {1}", Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString());
            return listEvenNumber;
        }

        public List<int> GetOddNumbers()
        {
            Console.WriteLine("Thread {0} started processing GetOddNumbers at {1}", Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString());
            List<int> listOddNumber = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
                if (i % 2 != 0)
                {
                    listOddNumber.Add(i);
                }
            }
            Console.WriteLine("Thread {0} completed processing GetOddNumbers at {1}", Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString());
            return listOddNumber;
        }
    }
}
