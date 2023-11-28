using Microsoft.AspNetCore.Mvc.Filters;

namespace API.Filters
{
    public class AsyncActionFilterAttribute : Attribute, IAsyncActionFilter, IOrderedFilter
    {
        private readonly string _caller;

        /// <summary>
        /// the least the number, the higher the priority
        /// </summary>
        public int Order { get; set; }

        public AsyncActionFilterAttribute(string caller, int order = 0)
        {
            _caller = caller;
            Order = order;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Console.WriteLine($"{_caller} - Async Filter: During Execution");

            await next();

            Console.WriteLine($"{_caller} - Async Filter: After Execution");
        }
    }
}
