using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RoraAPI.Model
{
    public class UserActivities : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var resultContext = await next();
            var userid = int.Parse(resultContext.HttpContext.User.FindFirst
                (ClaimTypes.NameIdentifier).Value);
            //   var repo= resultContext.HttpContext.RequestServices.GetService
        }
    }
}
