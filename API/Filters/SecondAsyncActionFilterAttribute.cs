using Microsoft.AspNetCore.Mvc.Filters;

namespace API.Filters
{
    public class SecondAsyncActionFilterAttribute : Attribute, IAsyncActionFilter
    {
        private readonly string _caller;

        public SecondAsyncActionFilterAttribute(string caller)
        {
            _caller = caller;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Console.WriteLine($"{_caller} - Second Async Filter: During Execution");

            await next();

            Console.WriteLine($"{_caller} - Second Async Filter: After Execution");
        }
    }
}
