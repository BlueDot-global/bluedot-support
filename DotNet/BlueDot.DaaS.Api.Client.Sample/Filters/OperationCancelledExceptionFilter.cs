using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Net;

namespace BlueDot.DaaS.Api.Client.Sample.Filters
{
    /// <summary>
    /// Filter to handle cancelled requests gracefully
    /// </summary>
    public class OperationCancelledExceptionFilter : ExceptionFilterAttribute
    {
        private readonly ILogger _logger;

        public OperationCancelledExceptionFilter(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<OperationCancelledExceptionFilter>();
        }
        public override void OnException(ExceptionContext context)
        {
            if (context.Exception is OperationCanceledException)
            {
                _logger.LogInformation("Request was cancelled by the caller...");
                context.ExceptionHandled = true;
                context.Result = new StatusCodeResult((int)HttpStatusCode.BadRequest);
            }
        }
    }

}
