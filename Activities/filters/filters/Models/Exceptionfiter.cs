using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Filters;

namespace filters.Models
{
    public class Exceptionfiter : Attribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            Debug.WriteLine("ExceptionFilter");
        }
    }
}
