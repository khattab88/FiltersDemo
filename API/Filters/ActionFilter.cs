using Microsoft.AspNetCore.Mvc.Filters;

namespace API.Filters
{
    public class ActionFilterAttribute : Attribute, IActionFilter
    {
        private readonly string _caller;

        public ActionFilterAttribute(string caller)
        {
            _caller = caller;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"{_caller} - Filter OnActionExecuting");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"{_caller} - Filter OnActionExecuted");
        }
    }
}
