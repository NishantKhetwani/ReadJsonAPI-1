using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;

namespace ReadJsonAPI
{
    /// <summary>
    /// Custom Attribute to handle error. Registered Globally 
    /// </summary>
    public class HandleExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            HttpResponseMessage httpResponseMessage = context.Request.CreateResponse(HttpStatusCode.InternalServerError, context.Exception.Message);
            context.Response = httpResponseMessage;
        }
    }
}