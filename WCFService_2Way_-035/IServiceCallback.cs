using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService_2Way__035
{
    namespace WCFService_2Way_115
    {
        [ServiceContract(CallbackContract = typeof(IClientCallback))]
        public interface IServiceCallback
        {
            [OperationContract(IsOneWay = true)]
            void gabung(string username);
            [OperationContract(IsOneWay = true)]
            void kirimPesan(string pesan);
        }

    }
}