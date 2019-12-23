﻿using System;
using System.Web.Http.Filters;

namespace OrdiOwin.Core.Filters
{
    public class ExceptionHandlingAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
                Console.Clear();
            base.OnException(actionExecutedContext);
        }
    }
}