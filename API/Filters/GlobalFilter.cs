using Microsoft.AspNetCore.Mvc.Filters;

namespace API.Filters
{
    public class GlobalFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("Global Filter OnActionExecuting");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("Global Filter OnActionExecuted");
        }
    }
}
