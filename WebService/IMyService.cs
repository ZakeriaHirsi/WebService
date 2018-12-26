using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WebService.Business;

namespace WebService
{
    [ServiceContract]
    public interface IMyService
    {
        [FaultContract (typeof(ExceptionHandler))]
        [OperationContract]
        string GetForename(int id);

        [FaultContract(typeof(ExceptionHandler))]
        [OperationContract]
        CustomerEntity GetCustomer(CustomerRequest id);
    }    

}
