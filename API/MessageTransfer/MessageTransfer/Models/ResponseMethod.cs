using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageTransfer.Models
{
    /// <summary>
    /// Response Method Class
    /// </summary>
    public class ResponseMethod
    {/// <summary>
     /// Success
     /// </summary>
        public string Success { get; set; }
        /// <summary>
        /// Messages
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Response data
        /// </summary>
        public Responsedata ResponseData { get; set; }
    }
    /// <summary>
    /// Response Data Class
    /// </summary>
    public class Responsedata
    {
        /// <summary>
        /// Id
        /// </summary>
        public Nullable<int> id { get; set; }
    }

}