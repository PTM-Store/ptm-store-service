using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace ptm_store_service.Models
{
    public class UserFilter : ActionFilterAttribute
    {
        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            next();
        }
    }
}
