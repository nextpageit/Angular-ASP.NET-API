using MessageTransfer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MessageTransfer.Controllers
{
    [System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]
    public class MessageController : ApiController
    {
        MessageContext messagecontext = new MessageContext();
       
        /// <summary>
        /// Save Message
        /// </summary>
        /// <param name="msg"></param>
        /// <returns>Object</returns>
        [AllowAnonymous]
        [Route("api/SaveMessage")]
        [HttpPost, HttpOptions]

        public ResponseMethod SaveMessage(tblMessage msg)
        {

            ResponseMethod responseMethod = new ResponseMethod();
            try
            {
                if (msg != null)
                {
                    messagecontext.tblMessages.Add(msg);
                    messagecontext.SaveChanges();
                    responseMethod.Success = "success";
                    responseMethod.Message = "record added successfully.";
                }
            }
            catch (Exception ex)
            {
                Exception(responseMethod, ex);

                responseMethod.Message = ex.Message;
            }
            return responseMethod;
        }
        /// <summary>
        /// Get all messages
        /// </summary>
        /// <returns>list</returns>
        [AllowAnonymous]
        [Route("api/GetAllMessages")]
        [HttpGet]
        public IQueryable<tblMessage> GetAllMessages()
        {
            ResponseMethod responseMethod = new ResponseMethod();
            try
            {
                return messagecontext.tblMessages;
            }
            catch (Exception ex)
            {
                Exception(responseMethod, ex);

                responseMethod.Message = ex.Message;
            }
            return null;
        }
        /// <summary>
        /// Get all messages by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [Route("api/GetMessageById/{id}")]
        [HttpGet]
        public IQueryable<tblMessage> GetMessageById(int? id)
        {
            ResponseMethod responseMethod = new ResponseMethod();
            try
            {
                IQueryable<tblMessage> messageModels = messagecontext.tblMessages.Where(u => u.Id == id);
                return messageModels;
            }
            catch (Exception ex)
            {
                Exception(responseMethod, ex);


            }
            return null;
        }
        private static void Exception(ResponseMethod responseMethod, Exception ex)
        {
            responseMethod.Success = (!string.IsNullOrEmpty(responseMethod.Success)) ? responseMethod.Success : "failed";
            responseMethod.Message = ex.Message;
        }
    }
}
