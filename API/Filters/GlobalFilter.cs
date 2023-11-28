using Microsoft.AspNetCore.Mvc.Filters;

namespace API.Filters
{
    public class GlobalFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("Filter OnActionExecuting");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("Filter OnActionExecuted");
        }
    }
}
