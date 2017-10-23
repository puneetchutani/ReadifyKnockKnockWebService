using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ReadifyKnockKnockWebService
{  /// <summary>
   /// This represents the readify service contract.
   /// </summary>
   /// 
    [ServiceContract(Namespace ="http://knocknock.readify.net")]
    public interface IKnock
    {

        [OperationContract]
        Guid GetToken();

        [OperationContract]
        long Fibonacci(long num);

        [OperationContract]
        string ReverseWords(string s);

        [OperationContract]
        string TriangleType(int a, int b, int c);
    }
}
