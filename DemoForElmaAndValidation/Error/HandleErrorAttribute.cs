using Elmah;
using System.Web.Mvc;
namespace DemoForElmaAndValidation.Error
{
    public class HandleErrorAttribute: System.Web.Mvc.HandleErrorAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            base.OnException(context);
            if (!context.ExceptionHandled)
                return;
            var httpContext = context.HttpContext.ApplicationInstance.Context;
            var signal = ErrorSignal.FromContext(httpContext);
            signal.Raise(context.Exception, httpContext);
        }
    }
}