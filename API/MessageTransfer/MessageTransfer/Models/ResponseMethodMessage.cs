using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageTransfer.Models
{

    public class ResponseMethodMessage
    {
        public string Success { get; set; }
        public string Message { get; set; }
        public List<tblMessage> ResponseData { get; set; }
    }
    
}