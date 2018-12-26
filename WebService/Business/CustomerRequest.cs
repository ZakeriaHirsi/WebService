using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;

namespace WebService
{
    [MessageContract]
    public class CustomerRequest
    {
        [MessageBodyMember]
        public int ID { get; set; }
    }
}