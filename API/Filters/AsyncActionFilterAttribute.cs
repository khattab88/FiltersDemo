using Microsoft.AspNetCore.Mvc.Filters;

namespace API.Filters
{
    public class AsyncActionFilterAttribute : Attribute, IAsyncActionFilter
    {
        private readonly string _caller;

        public AsyncActionFilterAttribute(string caller)
        {
            _caller = caller;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Console.WriteLine($"{_caller} - Async Filter: During Execution");

            await next();

            Console.WriteLine($"{_caller} - Async Filter: After Execution");
        }
    }
}
