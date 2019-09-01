using System;
using System.Web.Http.Filters;

namespace OrdiOwin.Core.Filters
{
    public class ExceptionHandlingAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {            var exception = actionExecutedContext.Exception;            if (exception != null)            {
                Console.Clear();                Console.WriteLine(actionExecutedContext.Exception.ToString());            }
            base.OnException(actionExecutedContext);
        }
    }
}