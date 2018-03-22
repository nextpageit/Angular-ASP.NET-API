using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MessageTransfer.Models
{
    /// <summary>
    /// Message Class
    /// </summary>
    public class tblMessage
    {
        /// <summary>
        /// Message ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Message Transfer
        /// </summary>
        public string Message { get; set; }
    }
}