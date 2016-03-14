using MVC_LoggingExcepion_with_ExceptionFilter.Models;
using System;
using System.Web.Mvc;

namespace MVC_LoggingExcepion_with_ExceptionFilter.CustomFilter
{
    public class ExceptionHandlerAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled) {
                 

                ExceptionLogger logger = new ExceptionLogger()
                {
                    ExceptionMessage = filterContext.Exception.Message,
                    ExceptionStackTrace = filterContext.Exception.StackTrace,
                    ControllerName = filterContext.RouteData.Values["controller"].ToString(),
                    LogTime  = DateTime.Now
                };

                ApplicationModel ctx = new ApplicationModel();
                ctx.ExceptionLoggers.Add(logger);
                ctx.SaveChanges();

                filterContext.ExceptionHandled = true;
            }
        }
    }
}