using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
namespace MessageTransfer.Models
{
    

    public partial class MessageContext : DbContext
    {
      /// <summary>
     /// Default Constructor
     /// </summary>
        public MessageContext()
            : base("name=MsgModel")
        {
        }
        /// <summary>
        /// Table Name for messages
        /// </summary>
        public DbSet<tblMessage> tblMessages { get; set; }
        /// <summary>
        /// On Model Creating
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
