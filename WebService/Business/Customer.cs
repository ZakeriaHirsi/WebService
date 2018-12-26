using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WebService.Business
{
    [MessageContract]
    public class CustomerEntity
    {
        #region Properties
        [MessageHeader]
        public int ID { get; set; }
        [MessageBodyMember]
        public string Forename { get; set; }
        [MessageBodyMember]
        public string Surname { get; set; }
        [MessageBodyMember]
        public string Address { get; set; }
        #endregion

    }
}