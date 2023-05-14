using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Filters;

namespace filters.Models
{
    public class Resourcefilter : Attribute, IResourceFilter
    {
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Debug.WriteLine("Action filter started - Before Logic");
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Debug.WriteLine("Action filter started - After Logic");
        }
    }
}
