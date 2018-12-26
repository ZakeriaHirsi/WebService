using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace WebService
{
    [DataContract]
    public class ExceptionHandler
    {
        [DataMember]
        public string Details { get; set; }
        [DataMember]
        public string Issue { get; set; }
    }
}